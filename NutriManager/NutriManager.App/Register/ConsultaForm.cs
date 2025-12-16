using FluentValidation;
using NutriManager.App.Base;
using NutriManager.App.ViewModel;
using NutriManager.App.Pages;
using NutriManager.Domain.Base;
using NutriManager.Domain.Entities;
using NutriManager.Service.Validators;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NutriManager.App.Register
{
    public partial class ConsultaForm : BaseForm
    {
        // Serviços necessários
        private readonly IBaseService<Consulta> _consultaService;
        private readonly IBaseService<Paciente> _pacienteService;
        private readonly IBaseService<PlanoAlimentar> _planoService;
        private readonly IBaseService<MedidasAntropometricas> _medidasService;
        private readonly IBaseService<Bioimpedancia> _bioService;
        private readonly IBaseService<DobrasCutaneas> _dobrasService;

        private List<ConsultaViewModel>? consultas;

        public ConsultaForm(
            IBaseService<Consulta> consultaService,
            IBaseService<Paciente> pacienteService,
            IBaseService<PlanoAlimentar> planoService,
            IBaseService<MedidasAntropometricas> medidasService,
            IBaseService<Bioimpedancia> bioService,
            IBaseService<DobrasCutaneas> dobrasService)
        {
            _consultaService = consultaService;
            _pacienteService = pacienteService;
            _planoService = planoService;
            _medidasService = medidasService;
            _bioService = bioService;
            _dobrasService = dobrasService;

            InitializeComponent();
            CarregarCombos();

            // VINCULA O EVENTO DE CLIQUE DA GRID
            if (dataGridViewList != null)
            {
                dataGridViewList.CellContentClick += dataGridViewList_CellContentClick;
            }
        }

        private void CarregarCombos()
        {
            cboPaciente.ValueMember = "Id";
            cboPaciente.DisplayMember = "Nome";
            cboPaciente.DataSource = _pacienteService.Get<PacienteViewModel>().ToList();

            cboPlano.ValueMember = "Id";
            cboPlano.DisplayMember = "DescricaoGeral";
            var planos = _planoService.Get<PlanoAlimentarViewModel>().ToList();
            cboPlano.DataSource = planos;
            cboPlano.SelectedIndex = -1;
        }

        private float ParseFloat(string value)
        {
            if (float.TryParse(value, out float result)) return result;
            return 0f;
        }

        // --- PREENCHIMENTO DO OBJETO ---
        private void FormToObject(Consulta consulta)
        {
            if (DateTime.TryParse(txtDataConsulta.Text, out DateTime data))
                consulta.DataConsulta = data;
            else
                consulta.DataConsulta = DateTime.Now;

            consulta.Objetivo = txtObjetivo.Text;
            consulta.Observacoes = txtObservacoes.Text;
            consulta.ObservacoesGerais = txtObsGerais.Text;

            if (cboPaciente.SelectedValue != null && int.TryParse(cboPaciente.SelectedValue.ToString(), out int idPac))
            {
                consulta.Paciente = _pacienteService.GetById<Paciente>(idPac);
            }

            if (cboPlano.SelectedValue != null && int.TryParse(cboPlano.SelectedValue.ToString(), out int idPlano))
            {
                consulta.PlanoAlimentar = _planoService.GetById<PlanoAlimentar>(idPlano);
            }
        }

        // --- CAPTURA DE DADOS DAS ABAS ---
        private MedidasAntropometricas GetMedidasFromForm()
        {
            return new MedidasAntropometricas
            {
                Peso = ParseFloat(txtPeso.Text),
                Altura = ParseFloat(txtAltura.Text),
                CircunferenciaCintura = ParseFloat(txtCintura.Text),
                CircunferenciaQuadril = ParseFloat(txtQuadril.Text),
                CircunferenciaBracoDireito = ParseFloat(txtBracoD.Text),
                CircunferenciaBracoEsquerdo = ParseFloat(txtBracoE.Text),
                CircunferenciaCoxaDireita = ParseFloat(txtCoxaD.Text),
                CircunferenciaCoxaEsquerda = ParseFloat(txtCoxaE.Text),
                CircunferenciaPanturrilhaDireita = ParseFloat(txtPanturrilhaD.Text),
                CircunferenciaPanturrilhaEsquerda = ParseFloat(txtPanturrilhaE.Text)
            };
        }

        private Bioimpedancia GetBioFromForm()
        {
            return new Bioimpedancia
            {
                PercentualGordura = ParseFloat(txtPercGordura.Text),
                PercentualMassaMagra = ParseFloat(txtPercMassaMagra.Text),
                PercentualAguaCorporal = ParseFloat(txtAgua.Text),
                MassaGorda = ParseFloat(txtMassaGorda.Text),
                MassaMagra = ParseFloat(txtMassaMagra.Text),
                TaxaMetabolicaBasal = ParseFloat(txtTaxaMetabolica.Text)
            };
        }

        private DobrasCutaneas GetDobrasFromForm()
        {
            return new DobrasCutaneas
            {
                DobraTricipital = ParseFloat(txtDobraTricipital.Text),
                DobraAbdominal = ParseFloat(txtDobraAbdominal.Text),
                DobraSubescapular = ParseFloat(txtDobraSubescapular.Text),
                DobraSuprailiaca = ParseFloat(txtDobraSuprailiaca.Text),
                DobraCoxa = ParseFloat(txtDobraCoxa.Text)
            };
        }

        // --- CRUD ---

        protected override void Save()
        {
            try
            {
                var medidas = GetMedidasFromForm();
                var bio = GetBioFromForm();
                var dobras = GetDobrasFromForm();

                var medidasSalvas = _medidasService.Add<MedidasAntropometricas, MedidasAntropometricas, MedidasValidator>(medidas);
                var bioSalva = _bioService.Add<Bioimpedancia, Bioimpedancia, BioimpedanciaValidator>(bio);
                var dobrasSalvas = _dobrasService.Add<DobrasCutaneas, DobrasCutaneas, DobrasCutaneasValidator>(dobras);

                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var consulta = _consultaService.GetById<Consulta>(id);
                    FormToObject(consulta);

                    consulta.MedidasAntropometricas = medidasSalvas;
                    consulta.Bioimpedancia = bioSalva;
                    consulta.DobrasCutaneas = dobrasSalvas;

                    _consultaService.Update<Consulta, Consulta, ConsultaValidator>(consulta);
                    MessageBox.Show("Consulta atualizada com sucesso!", "Sucesso");
                }
                else
                {
                    var consulta = new Consulta();
                    FormToObject(consulta);

                    consulta.MedidasAntropometricas = medidasSalvas;
                    consulta.Bioimpedancia = bioSalva;
                    consulta.DobrasCutaneas = dobrasSalvas;

                    _consultaService.Add<Consulta, Consulta, ConsultaValidator>(consulta);
                    MessageBox.Show("Consulta realizada com sucesso!", "Sucesso");
                }

                PopulateGrid();
                tabControlRegister.SelectedIndex = 1;
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _consultaService.Delete(id);
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"NutriManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            if (record == null) return;

            try
            {
                var item = record.DataBoundItem as ConsultaViewModel;

                if (item != null)
                {

                    txtId.Text = item.Id.ToString();
                    txtObjetivo.Text = item.Objetivo;
                    txtObservacoes.Text = item.Observacoes;
                    txtObsGerais.Text = item.ObservacoesGerais;

                    if (item.DataConsulta != DateTime.MinValue)
                        txtDataConsulta.Text = item.DataConsulta.ToString("dd/MM/yyyy HH:mm");
                    else
                        txtDataConsulta.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");


                    if (item.IdPaciente > 0)
                        cboPaciente.SelectedValue = item.IdPaciente;
                    else
                        cboPaciente.SelectedIndex = -1;

                    if (item.IdPlanoAlimentar > 0)
                        cboPlano.SelectedValue = item.IdPlanoAlimentar;
                    else
                        cboPlano.SelectedIndex = -1;

                    if (item.IdMediasAntropometricas > 0)
                    {

                        var m = _medidasService.GetById<MedidasAntropometricas>(item.IdMediasAntropometricas);
                        if (m != null)
                        {
                            txtPeso.Text = m.Peso.ToString();
                            txtAltura.Text = m.Altura.ToString();
                            txtCintura.Text = m.CircunferenciaCintura.ToString();
                            txtQuadril.Text = m.CircunferenciaQuadril.ToString();
                            txtBracoD.Text = m.CircunferenciaBracoDireito.ToString();
                            txtBracoE.Text = m.CircunferenciaBracoEsquerdo.ToString();
                            txtCoxaD.Text = m.CircunferenciaCoxaDireita.ToString();
                            txtCoxaE.Text = m.CircunferenciaCoxaEsquerda.ToString();
                            txtPanturrilhaD.Text = m.CircunferenciaPanturrilhaDireita.ToString();
                            txtPanturrilhaE.Text = m.CircunferenciaPanturrilhaEsquerda.ToString();
                        }
                    }


                    if (item.IdBioimpedancia > 0)
                    {
                        var b = _bioService.GetById<Bioimpedancia>(item.IdBioimpedancia);
                        if (b != null)
                        {
                            txtPercGordura.Text = b.PercentualGordura.ToString();
                            txtPercMassaMagra.Text = b.PercentualMassaMagra.ToString();
                            txtAgua.Text = b.PercentualAguaCorporal.ToString();
                            txtMassaGorda.Text = b.MassaGorda.ToString();
                            txtMassaMagra.Text = b.MassaMagra.ToString();
                            txtTaxaMetabolica.Text = b.TaxaMetabolicaBasal.ToString();
                        }
                    }

                    if (item.IdDobrasCutaneas > 0)
                    {
                        var d = _dobrasService.GetById<DobrasCutaneas>(item.IdDobrasCutaneas);
                        if (d != null)
                        {
                            txtDobraTricipital.Text = d.DobraTricipital.ToString();
                            txtDobraAbdominal.Text = d.DobraAbdominal.ToString();
                            txtDobraSubescapular.Text = d.DobraSubescapular.ToString();
                            txtDobraSuprailiaca.Text = d.DobraSuprailiaca.ToString();
                            txtDobraCoxa.Text = d.DobraCoxa.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void txtAltura_Click(object sender, EventArgs e) { }

        // =========================================================================
        // CONFIGURAÇÃO DO GRID E BOTÕES
        // =========================================================================

        protected override void PopulateGrid()
        {

            consultas = _consultaService.Get<ConsultaViewModel>().ToList();
            dataGridViewList.DataSource = consultas;


            string[] colunasEsconder = {
                "Id", "IdPaciente", "IdPlanoAlimentar",
                "IdMediasAntropometricas", "IdMediasAntropo",
                "IdBioimpedancia", "IdDobrasCutaneas", "IdDobras",
                "ObservacoesGera", "DescricaoPlano", "Observacoes", "ObservacoesGerais"
            };

            foreach (var col in colunasEsconder)
            {
                if (dataGridViewList.Columns[col] != null)
                    dataGridViewList.Columns[col].Visible = false;
            }

            if (dataGridViewList.Columns["NomePaciente"] != null)
                dataGridViewList.Columns["NomePaciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            ConfigurarBotoesGrid();
        }

        private void ConfigurarBotoesGrid()
        {
            AdicionarBotaoSeNaoExistir("btnBio", "Bioimpedância", "Ver Bio");
            AdicionarBotaoSeNaoExistir("btnMedidas", "Medidas", "Ver Medidas");
            AdicionarBotaoSeNaoExistir("btnDobras", "Dobras", "Ver Dobras");
        }

        private void AdicionarBotaoSeNaoExistir(string nomeColuna, string header, string textoBotao)
        {
            if (dataGridViewList.Columns[nomeColuna] == null)
            {
                var btn = new DataGridViewButtonColumn();
                btn.Name = nomeColuna;
                btn.HeaderText = header;
                btn.Text = textoBotao;
                btn.UseColumnTextForButtonValue = true;
                btn.FlatStyle = FlatStyle.Popup;
                btn.DefaultCellStyle.BackColor = Color.LightGray;
                btn.DefaultCellStyle.ForeColor = Color.Black;

                dataGridViewList.Columns.Add(btn);
            }
        }

        private void dataGridViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            int idConsulta = 0;
            if (dataGridViewList.Rows[e.RowIndex].Cells["Id"].Value != null)
            {
                int.TryParse(dataGridViewList.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out idConsulta);
            }

            if (idConsulta == 0) return;

            string nomeColuna = dataGridViewList.Columns[e.ColumnIndex].Name;

            switch (nomeColuna)
            {
                case "btnBio":
                    try
                    {
                        var frmBio = new VisualizarBioimpedanciaForm(idConsulta, _bioService);
                        frmBio.StartPosition = FormStartPosition.CenterParent;
                        frmBio.ShowDialog();
                    }
                    catch (Exception ex) { MessageBox.Show("Erro Bio: " + ex.Message); }
                    break;

                case "btnMedidas":
                    try
                    {
                        int idMedidas = 0;
                        object cellValue = null;

                        if (dataGridViewList.Columns.Contains("IdMediasAntropometricas"))
                            cellValue = dataGridViewList.Rows[e.RowIndex].Cells["IdMediasAntropometricas"].Value;
                        else if (dataGridViewList.Columns.Contains("IdMediasAntropo"))
                            cellValue = dataGridViewList.Rows[e.RowIndex].Cells["IdMediasAntropo"].Value;

                        if (cellValue != null) int.TryParse(cellValue.ToString(), out idMedidas);

                        if (idMedidas == 0)
                        {
                            var consultaCompleta = _consultaService.Get<Consulta>(new[] { "MedidasAntropometricas" })
                                                                   .FirstOrDefault(c => c.Id == idConsulta);
                            if (consultaCompleta?.MedidasAntropometricas != null)
                                idMedidas = consultaCompleta.MedidasAntropometricas.Id;
                        }

                        if (idMedidas > 0)
                        {
                            var frm = new VisualizarMedidasForm(idMedidas, _medidasService);
                            frm.StartPosition = FormStartPosition.CenterParent;
                            frm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma medida cadastrada.");
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Erro Medidas: " + ex.Message); }
                    break;

                case "btnDobras":
                    try
                    {
                        int idDobras = 0;
                        object cellValue = null;

                        if (dataGridViewList.Columns.Contains("IdDobrasCutaneas"))
                            cellValue = dataGridViewList.Rows[e.RowIndex].Cells["IdDobrasCutaneas"].Value;
                        else if (dataGridViewList.Columns.Contains("IdDobras"))
                            cellValue = dataGridViewList.Rows[e.RowIndex].Cells["IdDobras"].Value;

                        if (cellValue != null) int.TryParse(cellValue.ToString(), out idDobras);

                        if (idDobras == 0)
                        {
                            var consultaCompleta = _consultaService.Get<Consulta>(new[] { "DobrasCutaneas" })
                                                                   .FirstOrDefault(c => c.Id == idConsulta);
                            if (consultaCompleta?.DobrasCutaneas != null)
                                idDobras = consultaCompleta.DobrasCutaneas.Id;
                        }

                        if (idDobras > 0)
                        {
                            var frm = new VisualizarDobrasForm(idDobras, _dobrasService);
                            frm.StartPosition = FormStartPosition.CenterParent;
                            frm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma dobra cadastrada.");
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Erro Dobras: " + ex.Message); }
                    break;
            }
        }
    }
}