using NutriManager.App.Base;
using NutriManager.App.ViewModel;
using NutriManager.Domain.Base;
using NutriManager.Domain.Entities;
using NutriManager.Service.Validators;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NutriManager.App.Register
{
    public partial class PacienteForm : BaseForm
    {
        private readonly IBaseService<Paciente> _pacienteService;
        private List<PacienteViewModel>? pacientes;

        public PacienteForm(IBaseService<Paciente> pacienteService)
        {
            _pacienteService = pacienteService;
            InitializeComponent();
            LoadSexo();
        }

        private void LoadSexo()
        {
            cboSexo.Items.Clear();
            cboSexo.Items.Add("Masculino");
            cboSexo.Items.Add("Feminino");
            cboSexo.Items.Add("Outro");
            cboSexo.SelectedIndex = -1;
        }

        private void FormToObject(Paciente paciente)
        {
            paciente.Nome = txtNome.Text;

            paciente.Telefone = txtTelefone.Text;

            paciente.Sexo = cboSexo.Text;
            paciente.Email = txtEmail.Text;

            if (DateTime.TryParse(txtDataNascimento.Text, out DateTime dataNasc))
            {
                paciente.DataNascimento = dataNasc;
            }
            else
            {
                paciente.DataNascimento = DateTime.Now;
            }
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var paciente = _pacienteService.GetById<Paciente>(id);

                    if (paciente == null)
                    {
                        MessageBox.Show("Paciente não encontrado para edição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    FormToObject(paciente);
                    _pacienteService.Update<Paciente, Paciente, PacienteValidator>(paciente);
                    MessageBox.Show("Paciente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var paciente = new Paciente();
                    FormToObject(paciente);
                    _pacienteService.Add<Paciente, Paciente, PacienteValidator>(paciente);
                    MessageBox.Show("Paciente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                PopulateGrid();
                ClearFields();
                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "NutriManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {

                _pacienteService.Delete(id);
                PopulateGrid();
                MessageBox.Show("Paciente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível excluir o paciente. Verifique se ele possui consultas ou planos vinculados.\nErro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {

            pacientes = _pacienteService.Get<PacienteViewModel>().ToList();
            dataGridViewList.DataSource = pacientes;

            if (dataGridViewList.Columns["Nome"] != null)
                dataGridViewList.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (dataGridViewList.Columns["Id"] != null)
                dataGridViewList.Columns["Id"].Visible = false;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            if (record == null) return;

            txtId.Text = record.Cells["Id"].Value.ToString();
            txtNome.Text = record.Cells["Nome"].Value?.ToString();
            txtTelefone.Text = record.Cells["Telefone"].Value?.ToString();
            cboSexo.Text = record.Cells["Sexo"].Value?.ToString();

            if (dataGridViewList.Columns.Contains("Email"))
                txtEmail.Text = record.Cells["Email"].Value?.ToString();

            if (record.Cells["DataNascimento"].Value != null &&
                DateTime.TryParse(record.Cells["DataNascimento"].Value.ToString(), out DateTime data))
            {
                txtDataNascimento.Text = data.ToString("dd/MM/yyyy");
            }
        }

        private void ClearFields()
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDataNascimento.Text = string.Empty;
            cboSexo.SelectedIndex = -1;
            IsEditMode = false;
        }

        private void txtId_Click(object sender, EventArgs e)
        {

        }

        private void txtDataNascimento_Click(object sender, EventArgs e)
        {

        }
    }
}