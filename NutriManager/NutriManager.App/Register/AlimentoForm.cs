using NutriManager.App.Base;
using NutriManager.App.ViewModel;
using NutriManager.Domain.Base;
using NutriManager.Domain.Entities;
using NutriManager.Service.Validators;
using ReaLTaiizor.Controls;
using System.Globalization;

namespace NutriManager.App.Register
{
    public partial class AlimentoForm : BaseForm
    {
        private readonly IBaseService<Alimento> _alimentoService;
        private List<AlimentoViewModel>? alimentos;

        public AlimentoForm(IBaseService<Alimento> alimentoService)
        {
            _alimentoService = alimentoService;
            InitializeComponent();
        }

        private void FormToObject(Alimento alimento)
        {
            alimento.Nome = txtNome.Text;
            alimento.Porcao = txtPorcao.Text;

            alimento.Calorias = ParseDecimal(txtCalorias.Text);
            alimento.Carboidratos = ParseDecimal(txtCarboidratos.Text);
            alimento.Proteinas = ParseDecimal(txtProteinas.Text);
            alimento.Gorduras = ParseDecimal(txtGorduras.Text);
        }

        private decimal ParseDecimal(string value)
        {
            if (decimal.TryParse(value, out decimal result))
                return result;
            return 0;
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var alimento = _alimentoService.GetById<Alimento>(id);
                    FormToObject(alimento);
                    _alimentoService.Update<Alimento, Alimento, AlimentoValidator>(alimento);
                }
                else
                {
                    var alimento = new Alimento();
                    FormToObject(alimento);
                    _alimentoService.Add<Alimento, Alimento, AlimentoValidator>(alimento);
                }

                PopulateGrid();
                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"NutriManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _alimentoService.Delete(id);
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"NutriManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            alimentos = _alimentoService.Get<AlimentoViewModel>().ToList();
            dataGridViewList.DataSource = alimentos;

            if (dataGridViewList.Columns["Nome"] != null)
                dataGridViewList.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (dataGridViewList.Columns["Id"] != null)
                dataGridViewList.Columns["Id"].Visible = false;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            if (record == null) return;

            txtId.Text = record.Cells["Id"].Value.ToString();
            txtNome.Text = record.Cells["Nome"].Value.ToString();
            txtPorcao.Text = record.Cells["Porcao"].Value?.ToString();

            txtCalorias.Text = record.Cells["Calorias"].Value?.ToString();
            txtCarboidratos.Text = record.Cells["Carboidratos"].Value?.ToString();
            txtProteinas.Text = record.Cells["Proteinas"].Value?.ToString();
            txtGorduras.Text = record.Cells["Gorduras"].Value?.ToString();
        }

        private void txtProteinas_Click(object sender, EventArgs e)
        {

        }
    }
}