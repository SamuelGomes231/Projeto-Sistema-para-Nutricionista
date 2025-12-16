using NutriManager.Domain.Base;
using NutriManager.Domain.Entities;
using ReaLTaiizor.Forms;
using System;
using System.Linq;

namespace NutriManager.App.Pages
{
    public partial class DashboardForm : MaterialForm
    {
        private readonly IBaseService<Paciente> _pacienteService;
        private readonly IBaseService<Consulta> _consultaService;
        private readonly IBaseService<PlanoAlimentar> _planoService;

        public DashboardForm(
            IBaseService<Paciente> pacienteService,
            IBaseService<Consulta> consultaService,
            IBaseService<PlanoAlimentar> planoService)
        {
            _pacienteService = pacienteService;
            _consultaService = consultaService;
            _planoService = planoService;

            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            try
            {
                // Contar Pacientes
                int totalPacientes = _pacienteService.Get<Paciente>().Count();
                lblNumPacientes.Text = totalPacientes.ToString();

                // Contar Consultas
                int totalConsultas = _consultaService.Get<Consulta>().Count();
                lblNumConsultas.Text = totalConsultas.ToString();

                // Contar Planos
                int totalPlanos = _planoService.Get<PlanoAlimentar>().Count();
                lblNumPlanos.Text = totalPlanos.ToString();
            }
            catch (Exception ex)
            {

                lblNumPacientes.Text = "-";
                lblNumConsultas.Text = "-";
                lblNumPlanos.Text = "-";

            }
        }
    }
}