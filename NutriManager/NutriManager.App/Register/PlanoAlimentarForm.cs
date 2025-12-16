using NutriManager.App.Base;
using NutriManager.App.Pages;
using NutriManager.App.ViewModel;
using NutriManager.Domain.Base;
using NutriManager.Domain.Entities;
using NutriManager.Service.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NutriManager.App.Register
{
    public partial class PlanoAlimentarForm : BaseForm
    {
        private readonly IBaseService<PlanoAlimentar> _planoService;
        private readonly IBaseService<Paciente> _pacienteService;

        private readonly IBaseService<Refeicao> _refeicaoService;
        private readonly IBaseService<Alimento> _alimentoService;
        private readonly IBaseService<RefeicaoAlimento> _refeicaoAlimentoService;

        private List<PlanoAlimentar>? planos;

        public PlanoAlimentarForm(
            IBaseService<PlanoAlimentar> planoService,
            IBaseService<Paciente> pacienteService,
            IBaseService<Refeicao> refeicaoService,
            IBaseService<Alimento> alimentoService,
            IBaseService<RefeicaoAlimento> refeicaoAlimentoService)
        {
            _planoService = planoService;
            _pacienteService = pacienteService;
            _refeicaoService = refeicaoService;
            _alimentoService = alimentoService;
            _refeicaoAlimentoService = refeicaoAlimentoService;

            InitializeComponent();
            CarregarPacientes();


            if (dataGridViewList != null)
            {
                dataGridViewList.CellDoubleClick += dataGridViewList_CellDoubleClick;
            }
        }

        private void CarregarPacientes()
        {
            try
            {
                var pacientes = _pacienteService.Get<Paciente>().ToList();
                cboPaciente.DataSource = pacientes;
                cboPaciente.DisplayMember = "Nome";
                cboPaciente.ValueMember = "Id";
                cboPaciente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar pacientes: " + ex.Message);
            }
        }

        private void FormToObject(PlanoAlimentar plano)
        {
            plano.DescricaoGeral = txtDescricao.Text;
            plano.DataInicio = dtpDataInicio.Value;
            plano.DataFim = dtpDataFim.Value;
            plano.CaloriasDiarias = (int)nudCalorias.Value;
            plano.RefeicoesPorDia = (int)nudRefeicoesDia.Value;

            if (cboPaciente.SelectedItem != null)
            {
                plano.Paciente = (Paciente)cboPaciente.SelectedItem;
            }
        }

        protected override void Save()
        {
            try
            {
                if (cboPaciente.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um Paciente.", "NutriManager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var plano = _planoService.GetById<PlanoAlimentar>(id);
                    FormToObject(plano);

                    _planoService.Update<PlanoAlimentar, PlanoAlimentar, PlanoAlimentarValidator>(plano);

                    PopulateGrid();
                    tabControlRegister.SelectedIndex = 1;
                    MessageBox.Show("Plano atualizado com sucesso!");
                }
                else
                {
                    var plano = new PlanoAlimentar();
                    FormToObject(plano);

                    var planoSalvo = _planoService.Add<PlanoAlimentar, PlanoAlimentar, PlanoAlimentarValidator>(plano);

                    if (planoSalvo != null && planoSalvo.Id > 0)
                    {
                        MessageBox.Show("Plano salvo! Configurando refeições...", "NutriManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AbrirConfiguracaoRefeicoes(planoSalvo.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"NutriManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirConfiguracaoRefeicoes(int idPlano)
        {
            var formRefeicoes = new ConfigurarRefeicoesForm(
                idPlano,
                _refeicaoService,
                _alimentoService,
                _refeicaoAlimentoService
            );

            this.Hide();
            formRefeicoes.StartPosition = FormStartPosition.CenterParent;
            formRefeicoes.ShowDialog();
            this.Show();

            PopulateGrid();
            tabControlRegister.SelectedIndex = 1;
        }

        private void dataGridViewList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var cellValue = dataGridViewList.Rows[e.RowIndex].Cells["Id"].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int idPlano))
                {
                    AbrirConfiguracaoRefeicoes(idPlano);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir plano: " + ex.Message);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _planoService.Delete(id);
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"NutriManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {

            planos = _planoService.Get<PlanoAlimentar>(new[] { "Paciente" }).ToList();
            dataGridViewList.DataSource = planos;

            if (dataGridViewList.Columns["Paciente"] != null)
                dataGridViewList.Columns["Paciente"].Visible = false;

            if (dataGridViewList.Columns["Refeicoes"] != null)
                dataGridViewList.Columns["Refeicoes"].Visible = false;

            if (dataGridViewList.Columns["DescricaoGeral"] != null)
                dataGridViewList.Columns["DescricaoGeral"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (dataGridViewList.Columns["Id"] != null)
                dataGridViewList.Columns["Id"].Visible = false;

            if (dataGridViewList.Columns["IdPaciente"] != null)
                dataGridViewList.Columns["IdPaciente"].Visible = false;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            if (record == null) return;

            txtId.Text = record.Cells["Id"].Value.ToString();
            txtDescricao.Text = record.Cells["DescricaoGeral"].Value.ToString();

            if (record.Cells["DataInicio"].Value != null)
                dtpDataInicio.Value = Convert.ToDateTime(record.Cells["DataInicio"].Value);

            if (record.Cells["DataFim"].Value != null)
                dtpDataFim.Value = Convert.ToDateTime(record.Cells["DataFim"].Value);

            if (record.Cells["CaloriasDiarias"].Value != null)
                nudCalorias.Value = Convert.ToDecimal(record.Cells["CaloriasDiarias"].Value);

            if (record.Cells["RefeicoesPorDia"].Value != null)
                nudRefeicoesDia.Value = Convert.ToDecimal(record.Cells["RefeicoesPorDia"].Value);

            if (record.DataBoundItem is PlanoAlimentar plano && plano.Paciente != null)
            {
                cboPaciente.SelectedValue = plano.Paciente.Id;
            }
        }
    }
}