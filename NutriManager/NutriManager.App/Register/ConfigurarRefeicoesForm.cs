using NutriManager.App.Base;
using NutriManager.App.ViewModel;
using NutriManager.Domain.Base;
using NutriManager.Domain.Entities;
using NutriManager.Service.Validators;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NutriManager.App.Pages
{
    public partial class ConfigurarRefeicoesForm : MaterialForm
    {
        private readonly int _planoId;
        private readonly IBaseService<Refeicao> _refeicaoService;
        private readonly IBaseService<Alimento> _alimentoService;
        private readonly IBaseService<RefeicaoAlimento> _refeicaoAlimentoService;

        private int _refeicaoSelecionadaId = 0;

        public ConfigurarRefeicoesForm(
            int planoId,
            IBaseService<Refeicao> refeicaoService,
            IBaseService<Alimento> alimentoService,
            IBaseService<RefeicaoAlimento> refeicaoAlimentoService)
        {
            _planoId = planoId;
            _refeicaoService = refeicaoService;
            _alimentoService = alimentoService;
            _refeicaoAlimentoService = refeicaoAlimentoService;

            InitializeComponent();
            CarregarRefeicoesDoPlano();
            CarregarComboAlimentos();
        }

        // --- LADO ESQUERDO: REFEIÇÕES ---
        private void CarregarRefeicoesDoPlano()
        {
            var todas = _refeicaoService.Get<Refeicao>();
            var doPlano = todas.Where(r => r.PlanoAlimentarId == _planoId)
                               .OrderBy(r => r.HorarioSugestao)
                               .ToList();

            listaRefeicoes.DataSource = doPlano;
            listaRefeicoes.DisplayMember = "Nome";
            listaRefeicoes.ValueMember = "Id";
        }

        private void btnAddRefeicao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeRefeicao.Text))
            {
                MessageBox.Show("Digite um nome para a refeição.");
                return;
            }

            try
            {
                var novaRefeicao = new Refeicao
                {
                    Nome = txtNomeRefeicao.Text,
                    PlanoAlimentarId = _planoId,
                    HorarioSugestao = DateTime.Today.Add(timePickerRefeicao.Value.TimeOfDay)
                };

                _refeicaoService.Add<Refeicao, Refeicao, RefeicaoValidator>(novaRefeicao);

                txtNomeRefeicao.Text = "";
                CarregarRefeicoesDoPlano();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar refeição: " + ex.Message);
            }
        }

        private void listaRefeicoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaRefeicoes.SelectedValue != null &&
                int.TryParse(listaRefeicoes.SelectedValue.ToString(), out int id))
            {
                _refeicaoSelecionadaId = id;
                lblRefeicaoSelecionada.Text = "Refeição: " + listaRefeicoes.Text;
                groupBoxAlimentos.Enabled = true;
                CarregarAlimentosDaRefeicao();
            }
        }

        // --- LADO DIREITO: ALIMENTOS ---
        private void CarregarComboAlimentos()
        {
            
            var alimentos = _alimentoService.Get<Alimento>()
                                            .OrderBy(a => a.Nome)
                                            .ToList();

            cboAlimentos.DataSource = alimentos;
            cboAlimentos.DisplayMember = "Nome";
            cboAlimentos.ValueMember = "Id";
            cboAlimentos.SelectedIndex = -1;
        }

        private void CarregarAlimentosDaRefeicao()
        {
            var vinculos = _refeicaoAlimentoService.Get<RefeicaoAlimento>()
                                           .Where(ra => ra.RefeicaoId == _refeicaoSelecionadaId)
                                           .ToList();

            var gridData = vinculos.Select(ra => new
            {
                Alimento = _alimentoService.GetById<Alimento>(ra.AlimentoId)?.Nome ?? "Desconhecido",
                Porcao = ra.Porcao
            }).ToList();

            gridAlimentos.DataSource = gridData;
        }

        private void btnAddAlimento_Click(object sender, EventArgs e)
        {
            if (_refeicaoSelecionadaId == 0) return;
            if (cboAlimentos.SelectedValue == null)
            {
                MessageBox.Show("Selecione um alimento na lista.");
                return;
            }

            try
            {
                int alimentoId = (int)cboAlimentos.SelectedValue;

                var vinculo = new RefeicaoAlimento
                {
                    RefeicaoId = _refeicaoSelecionadaId,
                    AlimentoId = alimentoId,
                    Porcao = txtPorcao.Text
                };

                _refeicaoAlimentoService.Add<RefeicaoAlimento, RefeicaoAlimento, RefeicaoAlimentoValidator>(vinculo);

                txtPorcao.Text = "";
                CarregarAlimentosDaRefeicao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar alimento: " + ex.Message);
            }
        }
        private void btnConcluir_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}