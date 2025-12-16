namespace NutriManager.App.Pages
{
    partial class ConfigurarRefeicoesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBoxRefeicoes = new GroupBox();
            listaRefeicoes = new ListBox();
            btnAddRefeicao = new ReaLTaiizor.Controls.MaterialButton();
            timePickerRefeicao = new DateTimePicker();
            txtNomeRefeicao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            groupBoxAlimentos = new GroupBox();
            btnAddAlimento = new ReaLTaiizor.Controls.MaterialButton();
            txtPorcao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboAlimentos = new ComboBox();
            gridAlimentos = new DataGridView();
            lblRefeicaoSelecionada = new Label();
            btnConcluir = new ReaLTaiizor.Controls.MaterialButton();
            groupBoxRefeicoes.SuspendLayout();
            groupBoxAlimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridAlimentos).BeginInit();
            SuspendLayout();
            // 
            // groupBoxRefeicoes
            // 
            groupBoxRefeicoes.Controls.Add(listaRefeicoes);
            groupBoxRefeicoes.Controls.Add(btnAddRefeicao);
            groupBoxRefeicoes.Controls.Add(timePickerRefeicao);
            groupBoxRefeicoes.Controls.Add(txtNomeRefeicao);
            groupBoxRefeicoes.Location = new Point(12, 80);
            groupBoxRefeicoes.Name = "groupBoxRefeicoes";
            groupBoxRefeicoes.Size = new Size(367, 400);
            groupBoxRefeicoes.TabIndex = 0;
            groupBoxRefeicoes.TabStop = false;
            groupBoxRefeicoes.Text = "1. Cadastrar Refeições";
            // 
            // listaRefeicoes
            // 
            listaRefeicoes.ItemHeight = 15;
            listaRefeicoes.Location = new Point(10, 20);
            listaRefeicoes.Name = "listaRefeicoes";
            listaRefeicoes.Size = new Size(351, 244);
            listaRefeicoes.TabIndex = 0;
            listaRefeicoes.SelectedIndexChanged += listaRefeicoes_SelectedIndexChanged;
            // 
            // btnAddRefeicao
            // 
            btnAddRefeicao.AutoSize = false;
            btnAddRefeicao.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddRefeicao.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddRefeicao.Depth = 0;
            btnAddRefeicao.HighEmphasis = true;
            btnAddRefeicao.Icon = null;
            btnAddRefeicao.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAddRefeicao.Location = new Point(13, 340);
            btnAddRefeicao.Margin = new Padding(4, 6, 4, 6);
            btnAddRefeicao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddRefeicao.Name = "btnAddRefeicao";
            btnAddRefeicao.NoAccentTextColor = Color.Empty;
            btnAddRefeicao.Size = new Size(347, 40);
            btnAddRefeicao.TabIndex = 3;
            btnAddRefeicao.Text = "Criar Refeição";
            btnAddRefeicao.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddRefeicao.UseAccentColor = true;
            btnAddRefeicao.UseVisualStyleBackColor = true;
            btnAddRefeicao.Click += btnAddRefeicao_Click;
            // 
            // timePickerRefeicao
            // 
            timePickerRefeicao.Format = DateTimePickerFormat.Time;
            timePickerRefeicao.Location = new Point(271, 295);
            timePickerRefeicao.Name = "timePickerRefeicao";
            timePickerRefeicao.ShowUpDown = true;
            timePickerRefeicao.Size = new Size(90, 23);
            timePickerRefeicao.TabIndex = 2;
            // 
            // txtNomeRefeicao
            // 
            txtNomeRefeicao.AnimateReadOnly = false;
            txtNomeRefeicao.AutoCompleteMode = AutoCompleteMode.None;
            txtNomeRefeicao.AutoCompleteSource = AutoCompleteSource.None;
            txtNomeRefeicao.BackgroundImageLayout = ImageLayout.None;
            txtNomeRefeicao.CharacterCasing = CharacterCasing.Normal;
            txtNomeRefeicao.Depth = 0;
            txtNomeRefeicao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeRefeicao.HideSelection = true;
            txtNomeRefeicao.Hint = "Nome (Ex: Café da Manhã)";
            txtNomeRefeicao.LeadingIcon = null;
            txtNomeRefeicao.Location = new Point(10, 280);
            txtNomeRefeicao.MaxLength = 32767;
            txtNomeRefeicao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNomeRefeicao.Name = "txtNomeRefeicao";
            txtNomeRefeicao.PasswordChar = '\0';
            txtNomeRefeicao.PrefixSuffixText = null;
            txtNomeRefeicao.ReadOnly = false;
            txtNomeRefeicao.RightToLeft = RightToLeft.No;
            txtNomeRefeicao.SelectedText = "";
            txtNomeRefeicao.SelectionLength = 0;
            txtNomeRefeicao.SelectionStart = 0;
            txtNomeRefeicao.ShortcutsEnabled = true;
            txtNomeRefeicao.Size = new Size(255, 48);
            txtNomeRefeicao.TabIndex = 1;
            txtNomeRefeicao.TabStop = false;
            txtNomeRefeicao.TextAlign = HorizontalAlignment.Left;
            txtNomeRefeicao.TrailingIcon = null;
            txtNomeRefeicao.UseSystemPasswordChar = false;
            // 
            // groupBoxAlimentos
            // 
            groupBoxAlimentos.Controls.Add(btnAddAlimento);
            groupBoxAlimentos.Controls.Add(txtPorcao);
            groupBoxAlimentos.Controls.Add(cboAlimentos);
            groupBoxAlimentos.Controls.Add(gridAlimentos);
            groupBoxAlimentos.Controls.Add(lblRefeicaoSelecionada);
            groupBoxAlimentos.Enabled = false;
            groupBoxAlimentos.Location = new Point(385, 80);
            groupBoxAlimentos.Name = "groupBoxAlimentos";
            groupBoxAlimentos.Size = new Size(537, 400);
            groupBoxAlimentos.TabIndex = 1;
            groupBoxAlimentos.TabStop = false;
            groupBoxAlimentos.Text = "2. Adicionar Alimentos";
            // 
            // btnAddAlimento
            // 
            btnAddAlimento.AutoSize = false;
            btnAddAlimento.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddAlimento.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddAlimento.Depth = 0;
            btnAddAlimento.HighEmphasis = true;
            btnAddAlimento.Icon = null;
            btnAddAlimento.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAddAlimento.Location = new Point(447, 43);
            btnAddAlimento.Margin = new Padding(4, 6, 4, 6);
            btnAddAlimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddAlimento.Name = "btnAddAlimento";
            btnAddAlimento.NoAccentTextColor = Color.Empty;
            btnAddAlimento.Size = new Size(65, 48);
            btnAddAlimento.TabIndex = 3;
            btnAddAlimento.Text = "+";
            btnAddAlimento.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddAlimento.UseAccentColor = true;
            btnAddAlimento.UseVisualStyleBackColor = true;
            btnAddAlimento.Click += btnAddAlimento_Click;
            // 
            // txtPorcao
            // 
            txtPorcao.AnimateReadOnly = false;
            txtPorcao.AutoCompleteMode = AutoCompleteMode.None;
            txtPorcao.AutoCompleteSource = AutoCompleteSource.None;
            txtPorcao.BackgroundImageLayout = ImageLayout.None;
            txtPorcao.CharacterCasing = CharacterCasing.Normal;
            txtPorcao.Depth = 0;
            txtPorcao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPorcao.HideSelection = true;
            txtPorcao.Hint = "Porção (Ex: 100g)";
            txtPorcao.LeadingIcon = null;
            txtPorcao.Location = new Point(270, 46);
            txtPorcao.MaxLength = 32767;
            txtPorcao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPorcao.Name = "txtPorcao";
            txtPorcao.PasswordChar = '\0';
            txtPorcao.PrefixSuffixText = null;
            txtPorcao.ReadOnly = false;
            txtPorcao.RightToLeft = RightToLeft.No;
            txtPorcao.SelectedText = "";
            txtPorcao.SelectionLength = 0;
            txtPorcao.SelectionStart = 0;
            txtPorcao.ShortcutsEnabled = true;
            txtPorcao.Size = new Size(170, 48);
            txtPorcao.TabIndex = 2;
            txtPorcao.TabStop = false;
            txtPorcao.TextAlign = HorizontalAlignment.Left;
            txtPorcao.TrailingIcon = null;
            txtPorcao.UseSystemPasswordChar = false;
            // 
            // cboAlimentos
            // 
            cboAlimentos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAlimentos.Location = new Point(10, 55);
            cboAlimentos.Name = "cboAlimentos";
            cboAlimentos.Size = new Size(250, 23);
            cboAlimentos.TabIndex = 1;
            // 
            // gridAlimentos
            // 
            gridAlimentos.AllowUserToAddRows = false;
            gridAlimentos.Location = new Point(10, 100);
            gridAlimentos.Name = "gridAlimentos";
            gridAlimentos.ReadOnly = true;
            gridAlimentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridAlimentos.Size = new Size(502, 280);
            gridAlimentos.TabIndex = 4;
            // 
            // lblRefeicaoSelecionada
            // 
            lblRefeicaoSelecionada.AutoSize = true;
            lblRefeicaoSelecionada.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRefeicaoSelecionada.Location = new Point(10, 25);
            lblRefeicaoSelecionada.Name = "lblRefeicaoSelecionada";
            lblRefeicaoSelecionada.Size = new Size(232, 19);
            lblRefeicaoSelecionada.TabIndex = 0;
            lblRefeicaoSelecionada.Text = "Selecione uma refeição ao lado...";
            // 
            // btnConcluir
            // 
            btnConcluir.AutoSize = false;
            btnConcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConcluir.Depth = 0;
            btnConcluir.HighEmphasis = true;
            btnConcluir.Icon = null;
            btnConcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnConcluir.Location = new Point(12, 489);
            btnConcluir.Margin = new Padding(4, 6, 4, 6);
            btnConcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnConcluir.Name = "btnConcluir";
            btnConcluir.NoAccentTextColor = Color.Empty;
            btnConcluir.Size = new Size(910, 45);
            btnConcluir.TabIndex = 5;
            btnConcluir.Text = "CONCLUIR E FECHAR";
            btnConcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConcluir.UseAccentColor = true;
            btnConcluir.UseVisualStyleBackColor = true;
            btnConcluir.Click += btnConcluir_Click;
            // 
            // ConfigurarRefeicoesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 550);
            Controls.Add(btnConcluir);
            Controls.Add(groupBoxAlimentos);
            Controls.Add(groupBoxRefeicoes);
            MaximizeBox = false;
            Name = "ConfigurarRefeicoesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Configurar Cardápio do Plano";
            groupBoxRefeicoes.ResumeLayout(false);
            groupBoxAlimentos.ResumeLayout(false);
            groupBoxAlimentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridAlimentos).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxRefeicoes;
        private System.Windows.Forms.ListBox listaRefeicoes;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeRefeicao;
        private System.Windows.Forms.DateTimePicker timePickerRefeicao;
        private ReaLTaiizor.Controls.MaterialButton btnAddRefeicao;

        private System.Windows.Forms.GroupBox groupBoxAlimentos;
        private System.Windows.Forms.Label lblRefeicaoSelecionada;
        private System.Windows.Forms.DataGridView gridAlimentos;
        private System.Windows.Forms.ComboBox cboAlimentos;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPorcao;
        private ReaLTaiizor.Controls.MaterialButton btnAddAlimento;

        // Declaração do novo botão
        private ReaLTaiizor.Controls.MaterialButton btnConcluir;
    }
}