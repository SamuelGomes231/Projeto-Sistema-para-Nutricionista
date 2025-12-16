using NutriManager.App.Base;
using NutriManager.App.Infra;
using NutriManager.App.Pages;
using NutriManager.App.Register;
using NutriManager.App.ViewModel;
using NutriManager.Domain.Base;
using NutriManager.Domain.Entities;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NutriManager.App
{
    public partial class MainForm : MaterialForm
    {
        // Serviços necessários para o Main e para o Dashboard
        private readonly IBaseService<Paciente> _pacienteService;
        private readonly IBaseService<Consulta> _consultaService;
        private readonly IBaseService<PlanoAlimentar> _planoService;

        // Injeção de Dependência no Construtor
        public MainForm(
            IBaseService<Paciente> pacienteService,
            IBaseService<Consulta> consultaService,
            IBaseService<PlanoAlimentar> planoService)
        {
            _pacienteService = pacienteService;
            _consultaService = consultaService;
            _planoService = planoService;

            InitializeComponent();
            CarregarGridPacientes();
        }

        // --- LÓGICA DA ABA DE PACIENTES ---

        private void txtBuscaPacientes_TextChanged(object sender, EventArgs e)
        {
            CarregarGridPacientes(txtBuscaPacientes.Text);
        }

        private void CarregarGridPacientes(string termo = "")
        {
            try
            {
                var lista = _pacienteService.Get<PacienteViewModel>();

                if (!string.IsNullOrEmpty(termo))
                {
                    lista = lista.Where(p => p.Nome.ToLower().Contains(termo.ToLower())).ToList();
                }

                gridPacientes.DataSource = lista;

                if (gridPacientes.Columns["Id"] != null) gridPacientes.Columns["Id"].Visible = false;
                if (gridPacientes.Columns["Nome"] != null) gridPacientes.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {

            }
        }

        private void gridPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var idVal = gridPacientes.Rows[e.RowIndex].Cells["Id"].Value;

                if (idVal != null && int.TryParse(idVal.ToString(), out int idPaciente))
                {

                    var prontuario = ConfigureDI.serviceProvider.GetService<ProntuarioForm>();

                    if (prontuario != null)
                    {
                        prontuario.CarregarProntuario(idPaciente);
                        prontuario.ShowDialog();
                    }
                }
            }
        }

        // --- BOTÕES DO PAINEL GERAL ---

        private void btnNovoPaciente_Click(object sender, EventArgs e)
        {
            FormLoad<PacienteForm>();
            CarregarGridPacientes();
        }

        private void btnCadAlimento_Click(object sender, EventArgs e)
        {
            FormLoad<AlimentoForm>();
        }

        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {
            FormLoad<ConsultaForm>();
        }

        private void btnCadPlano_Click(object sender, EventArgs e)
        {
            FormLoad<PlanoAlimentarForm>();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {
        }

        // --- AQUI ESTÁ A LÓGICA DO DASHBOARD ---
        private void btnDashboard_Click(object sender, EventArgs e)
        {

            var dashboard = new DashboardForm(_pacienteService, _consultaService, _planoService);
            dashboard.StartPosition = FormStartPosition.CenterParent;
            dashboard.ShowDialog();
        }

        private void FormLoad<T>() where T : Form
        {
            var form = ConfigureDI.serviceProvider.GetService<T>();
            if (form != null)
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }
    }
}