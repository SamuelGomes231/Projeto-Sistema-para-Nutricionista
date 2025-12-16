using NutriManager.App.Base;
using NutriManager.App.ViewModel;
using NutriManager.Domain.Base;
using NutriManager.Domain.Entities;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NutriManager.App.Pages
{
    public partial class ProntuarioForm : MaterialForm
    {
        // Serviços
        private readonly IBaseService<Paciente> _pacienteService;
        private readonly IBaseService<Consulta> _consultaService;
        private readonly IBaseService<PlanoAlimentar> _planoService;
        private readonly IBaseService<Refeicao> _refeicaoService;
        private readonly IBaseService<Alimento> _alimentoService;
        private readonly IBaseService<RefeicaoAlimento> _refeicaoAlimentoService;
        private readonly IBaseService<Bioimpedancia> _bioService;
        private readonly IBaseService<MedidasAntropometricas> _medidasService;
        private readonly IBaseService<DobrasCutaneas> _dobrasService;

        private int _pacienteId;

        public ProntuarioForm(
            IBaseService<Paciente> pacienteService,
            IBaseService<Consulta> consultaService,
            IBaseService<PlanoAlimentar> planoService,
            IBaseService<Refeicao> refeicaoService,
            IBaseService<Alimento> alimentoService,
            IBaseService<RefeicaoAlimento> refeicaoAlimentoService,
            IBaseService<Bioimpedancia> bioService,
            IBaseService<MedidasAntropometricas> medidasService,
            IBaseService<DobrasCutaneas> dobrasService)
        {
            _pacienteService = pacienteService;
            _consultaService = consultaService;
            _planoService = planoService;
            _refeicaoService = refeicaoService;
            _alimentoService = alimentoService;
            _refeicaoAlimentoService = refeicaoAlimentoService;
            _bioService = bioService;
            _medidasService = medidasService;
            _dobrasService = dobrasService;

            InitializeComponent();

            gridPlanos.CellDoubleClick += gridPlanos_CellDoubleClick;
            gridConsultas.CellContentClick += gridConsultas_CellContentClick;
        }

        public void CarregarProntuario(int pacienteId)
        {
            _pacienteId = pacienteId;
            CarregarCabecalho();
            CarregarHistoricoConsultas();
            CarregarPlanos();
        }

        private void CarregarHistoricoConsultas()
        {
            try
            {
                var consultas = _consultaService.Get<ConsultaViewModel>()
                                .Where(c => c.IdPaciente == _pacienteId)
                                .OrderByDescending(c => c.DataConsulta)
                                .ToList();

                gridConsultas.DataSource = consultas;
                ConfigurarGridConsultas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar consultas: " + ex.Message);
            }
        }

        private void ConfigurarGridConsultas()
        {
            EsconderColunas(gridConsultas);

            string[] colunasParaEsconder = {
                "ObservacoesGera", "IdPlanoAlimentar", "DescricaoPlano",
                "IdMediasAntropo", "IdMediasAntropometricas",
                "IdBioimpedancia", "IdDobrasCutaneas"
            };

            foreach (var col in colunasParaEsconder)
            {
                if (gridConsultas.Columns[col] != null)
                    gridConsultas.Columns[col].Visible = false;
            }

            AdicionarBotaoSeNaoExistir("btnBio", "Bioimpedância", "Ver Bio");
            AdicionarBotaoSeNaoExistir("btnMedidas", "Medidas", "Ver Medidas");
            AdicionarBotaoSeNaoExistir("btnDobras", "Dobras", "Ver Dobras");
        }

        private void AdicionarBotaoSeNaoExistir(string nomeColuna, string header, string textoBotao)
        {
            if (gridConsultas.Columns[nomeColuna] == null)
            {
                var btn = new DataGridViewButtonColumn();
                btn.Name = nomeColuna;
                btn.HeaderText = header;
                btn.Text = textoBotao;
                btn.UseColumnTextForButtonValue = true;
                btn.FlatStyle = FlatStyle.Popup;
                btn.DefaultCellStyle.BackColor = Color.LightGray;
                btn.DefaultCellStyle.ForeColor = Color.Black;
                gridConsultas.Columns.Add(btn);
            }
        }

        private void gridConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idConsulta = 0;
            if (gridConsultas.Rows[e.RowIndex].Cells["Id"].Value != null)
                int.TryParse(gridConsultas.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out idConsulta);

            if (idConsulta == 0) return;

            string nomeColuna = gridConsultas.Columns[e.ColumnIndex].Name;

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

                        if (gridConsultas.Columns.Contains("IdMediasAntropometricas"))
                            cellValue = gridConsultas.Rows[e.RowIndex].Cells["IdMediasAntropometricas"].Value;
                        else if (gridConsultas.Columns.Contains("IdMediasAntropo"))
                            cellValue = gridConsultas.Rows[e.RowIndex].Cells["IdMediasAntropo"].Value;

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

                        if (gridConsultas.Columns.Contains("IdDobrasCutaneas"))
                            cellValue = gridConsultas.Rows[e.RowIndex].Cells["IdDobrasCutaneas"].Value;
                        else if (gridConsultas.Columns.Contains("IdDobras"))
                            cellValue = gridConsultas.Rows[e.RowIndex].Cells["IdDobras"].Value;

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
                            MessageBox.Show("Nenhuma dobra cadastrada para esta consulta.");
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Erro Dobras: " + ex.Message); }
                    break;
            }
        }

        private void gridPlanos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                var cellValue = gridPlanos.Rows[e.RowIndex].Cells["Id"].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int idPlano))
                {
                    var formRefeicoes = new ConfigurarRefeicoesForm(
                        idPlano,
                        _refeicaoService,
                        _alimentoService,
                        _refeicaoAlimentoService
                    );
                    formRefeicoes.StartPosition = FormStartPosition.CenterParent;
                    formRefeicoes.ShowDialog();
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro Plano: " + ex.Message); }
        }

        private void CarregarPlanos()
        {
            try
            {
                var planosEntidade = _planoService.Get<PlanoAlimentar>(new[] { "Paciente" })
                                                  .Where(p => p.Paciente != null && p.Paciente.Id == _pacienteId)
                                                  .ToList();

                var listaParaGrid = planosEntidade.Select(p => new
                {
                    Id = p.Id,
                    Descricao = p.DescricaoGeral,
                    Inicio = p.DataInicio.ToShortDateString(),
                    Fim = p.DataFim.ToShortDateString(),
                    Calorias = p.CaloriasDiarias,
                    Refeicoes = p.RefeicoesPorDia
                }).ToList();

                gridPlanos.DataSource = listaParaGrid;
                if (gridPlanos.Columns["Id"] != null) gridPlanos.Columns["Id"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("Erro Carregar Planos: " + ex.Message); }
        }

        private void CarregarCabecalho()
        {
            try
            {
                var paciente = _pacienteService.GetById<Paciente>(_pacienteId);
                if (paciente != null)
                {
                    lblNome.Text = paciente.Nome;
                    lblEmail.Text = paciente.Email;
                    lblIdade.Text = CalculateAge(paciente.DataNascimento).ToString() + " anos";
                    this.Text = $"Prontuário: {paciente.Nome}";
                }
            }
            catch { }
        }

        private int CalculateAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }

        private void EsconderColunas(DataGridView grid)
        {
            string[] colunasEsconder = { "Id", "IdPaciente", "PacienteId", "ConsultaId" };
            foreach (var col in colunasEsconder)
            {
                if (grid.Columns[col] != null) grid.Columns[col].Visible = false;
            }
        }
    }
}