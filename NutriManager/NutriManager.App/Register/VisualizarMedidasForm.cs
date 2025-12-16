using NutriManager.Domain.Base;
using NutriManager.Domain.Entities;
using ReaLTaiizor.Forms;
using System;
using System.Windows.Forms;

namespace NutriManager.App.Pages
{
    public partial class VisualizarMedidasForm : MaterialForm
    {
        private readonly int _medidasId;
        private readonly IBaseService<MedidasAntropometricas> _medidasService;

        public VisualizarMedidasForm(int medidasId, IBaseService<MedidasAntropometricas> medidasService)
        {
            _medidasId = medidasId;
            _medidasService = medidasService;
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            try
            {
                var medidas = _medidasService.GetById<MedidasAntropometricas>(_medidasId);

                if (medidas != null)
                {
                    // Gerais
                    txtPeso.Text = medidas.Peso.ToString("N2");
                    txtAltura.Text = medidas.Altura.ToString("N2");

                    // Tronco
                    txtCintura.Text = medidas.CircunferenciaCintura.ToString("N2");
                    txtQuadril.Text = medidas.CircunferenciaQuadril.ToString("N2");

                    // Membros Superiores
                    txtBracoD.Text = medidas.CircunferenciaBracoDireito.ToString("N2");
                    txtBracoE.Text = medidas.CircunferenciaBracoEsquerdo.ToString("N2");

                    // Membros Inferiores
                    txtCoxaD.Text = medidas.CircunferenciaCoxaDireita.ToString("N2");
                    txtCoxaE.Text = medidas.CircunferenciaCoxaEsquerda.ToString("N2");

                    txtPanturrilhaD.Text = medidas.CircunferenciaPanturrilhaDireita.ToString("N2");
                    txtPanturrilhaE.Text = medidas.CircunferenciaPanturrilhaEsquerda.ToString("N2");
                }
                else
                {
                    MessageBox.Show("Dados não encontrados.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar medidas: " + ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}