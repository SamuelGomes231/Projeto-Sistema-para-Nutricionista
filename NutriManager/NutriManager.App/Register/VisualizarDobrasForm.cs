using NutriManager.Domain.Base;
using NutriManager.Domain.Entities;
using ReaLTaiizor.Forms;
using System;
using System.Windows.Forms;

namespace NutriManager.App.Pages
{
    public partial class VisualizarDobrasForm : MaterialForm
    {
        private readonly int _dobrasId;
        private readonly IBaseService<DobrasCutaneas> _dobrasService;

        public VisualizarDobrasForm(int dobrasId, IBaseService<DobrasCutaneas> dobrasService)
        {
            _dobrasId = dobrasId;
            _dobrasService = dobrasService;
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            try
            {
                var dobras = _dobrasService.GetById<DobrasCutaneas>(_dobrasId);

                if (dobras != null)
                {

                    txtDobraTricipital.Text = dobras.DobraTricipital.ToString("N1");
                    txtDobraSubescapular.Text = dobras.DobraSubescapular.ToString("N1");
                    txtDobraSuprailiaca.Text = dobras.DobraSuprailiaca.ToString("N1");
                    txtDobraAbdominal.Text = dobras.DobraAbdominal.ToString("N1");
                    txtDobraCoxa.Text = dobras.DobraCoxa.ToString("N1");
                }
                else
                {
                    MessageBox.Show("Dados não encontrados.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dobras: " + ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}