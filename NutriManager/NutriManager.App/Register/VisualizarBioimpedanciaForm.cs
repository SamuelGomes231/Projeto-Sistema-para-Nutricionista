using NutriManager.Domain.Base;
using NutriManager.Domain.Entities;
using ReaLTaiizor.Forms;
using System;
using System.Windows.Forms;

namespace NutriManager.App.Pages
{
    public partial class VisualizarBioimpedanciaForm : MaterialForm
    {
        private readonly int _bioimpedanciaId;
        private readonly IBaseService<Bioimpedancia> _bioService;

        public VisualizarBioimpedanciaForm(int bioimpedanciaId, IBaseService<Bioimpedancia> bioService)
        {
            _bioimpedanciaId = bioimpedanciaId;
            _bioService = bioService;
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            try
            {

                var bio = _bioService.GetById<Bioimpedancia>(_bioimpedanciaId);

                if (bio != null)
                {
                    // Linha 1: Percentuais
                    txtPercGordura.Text = bio.PercentualGordura.ToString("N2") + "%";
                    txtPercMassaMagra.Text = bio.PercentualMassaMagra.ToString("N2") + "%";
                    txtPercAgua.Text = bio.PercentualAguaCorporal.ToString("N2") + "%";

                    // Linha 2: Massas (Kg) e TMB
                    txtMassaGorda.Text = bio.MassaGorda.ToString("N2") + " kg";
                    txtMassaMagra.Text = bio.MassaMagra.ToString("N2") + " kg";
                    txtTMB.Text = bio.TaxaMetabolicaBasal.ToString("N0") + " kcal";
                }
                else
                {
                    MessageBox.Show("Dados da bioimpedância não encontrados.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}