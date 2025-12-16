namespace NutriManager.App
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageGeral = new TabPage();
            panelGeral = new Panel();
            btnDashboard = new ReaLTaiizor.Controls.MaterialButton();
            groupBoxAtendimento = new GroupBox();
            btnCadPlano = new ReaLTaiizor.Controls.MaterialButton();
            btnNovaConsulta = new ReaLTaiizor.Controls.MaterialButton();
            groupBoxCadastros = new GroupBox();
            btnCadAlimento = new ReaLTaiizor.Controls.MaterialButton();
            btnNovoPaciente = new ReaLTaiizor.Controls.MaterialButton();
            tabPagePacientes = new TabPage();
            gridPacientes = new DataGridView();
            txtBuscaPacientes = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTabSelector1 = new ReaLTaiizor.Controls.MaterialTabSelector();
            materialTabControl1.SuspendLayout();
            tabPageGeral.SuspendLayout();
            panelGeral.SuspendLayout();
            groupBoxAtendimento.SuspendLayout();
            groupBoxCadastros.SuspendLayout();
            tabPagePacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPacientes).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPageGeral);
            materialTabControl1.Controls.Add(tabPagePacientes);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.Location = new Point(3, 116);
            materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(789, 350);
            materialTabControl1.TabIndex = 1;
            // 
            // tabPageGeral
            // 
            tabPageGeral.BackColor = Color.White;
            tabPageGeral.Controls.Add(panelGeral);
            tabPageGeral.Location = new Point(4, 24);
            tabPageGeral.Name = "tabPageGeral";
            tabPageGeral.Padding = new Padding(3);
            tabPageGeral.Size = new Size(781, 322);
            tabPageGeral.TabIndex = 0;
            tabPageGeral.Text = "Painel Geral";
            // 
            // panelGeral
            // 
            panelGeral.Controls.Add(btnDashboard);
            panelGeral.Controls.Add(groupBoxAtendimento);
            panelGeral.Controls.Add(groupBoxCadastros);
            panelGeral.Dock = DockStyle.Fill;
            panelGeral.Location = new Point(3, 3);
            panelGeral.Name = "panelGeral";
            panelGeral.Size = new Size(775, 316);
            panelGeral.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSize = false;
            btnDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDashboard.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDashboard.Depth = 0;
            btnDashboard.HighEmphasis = true;
            btnDashboard.Icon = null;
            btnDashboard.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnDashboard.Location = new Point(30, 248);
            btnDashboard.Margin = new Padding(4, 6, 4, 6);
            btnDashboard.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnDashboard.Name = "btnDashboard";
            btnDashboard.NoAccentTextColor = Color.Empty;
            btnDashboard.Size = new Size(720, 50);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "VISÃO GERAL (DASHBOARD)";
            btnDashboard.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDashboard.UseAccentColor = true;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // groupBoxAtendimento
            // 
            groupBoxAtendimento.Controls.Add(btnCadPlano);
            groupBoxAtendimento.Controls.Add(btnNovaConsulta);
            groupBoxAtendimento.Font = new Font("Segoe UI", 12F);
            groupBoxAtendimento.Location = new Point(400, 30);
            groupBoxAtendimento.Name = "groupBoxAtendimento";
            groupBoxAtendimento.Size = new Size(350, 209);
            groupBoxAtendimento.TabIndex = 1;
            groupBoxAtendimento.TabStop = false;
            groupBoxAtendimento.Text = "Atendimento";
            // 
            // btnCadPlano
            // 
            btnCadPlano.AutoSize = false;
            btnCadPlano.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCadPlano.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCadPlano.Depth = 0;
            btnCadPlano.HighEmphasis = true;
            btnCadPlano.Icon = null;
            btnCadPlano.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCadPlano.Location = new Point(20, 130);
            btnCadPlano.Margin = new Padding(4, 6, 4, 6);
            btnCadPlano.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCadPlano.Name = "btnCadPlano";
            btnCadPlano.NoAccentTextColor = Color.Empty;
            btnCadPlano.Size = new Size(300, 50);
            btnCadPlano.TabIndex = 1;
            btnCadPlano.Text = "Cadastrar Plano Alimentar";
            btnCadPlano.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCadPlano.UseAccentColor = true;
            btnCadPlano.UseVisualStyleBackColor = true;
            btnCadPlano.Click += btnCadPlano_Click;
            // 
            // btnNovaConsulta
            // 
            btnNovaConsulta.AutoSize = false;
            btnNovaConsulta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovaConsulta.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovaConsulta.Depth = 0;
            btnNovaConsulta.HighEmphasis = true;
            btnNovaConsulta.Icon = null;
            btnNovaConsulta.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovaConsulta.Location = new Point(20, 60);
            btnNovaConsulta.Margin = new Padding(4, 6, 4, 6);
            btnNovaConsulta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovaConsulta.Name = "btnNovaConsulta";
            btnNovaConsulta.NoAccentTextColor = Color.Empty;
            btnNovaConsulta.Size = new Size(300, 50);
            btnNovaConsulta.TabIndex = 0;
            btnNovaConsulta.Text = "Realizar Nova Consulta";
            btnNovaConsulta.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovaConsulta.UseAccentColor = true;
            btnNovaConsulta.UseVisualStyleBackColor = true;
            btnNovaConsulta.Click += btnNovaConsulta_Click;
            // 
            // groupBoxCadastros
            // 
            groupBoxCadastros.Controls.Add(btnCadAlimento);
            groupBoxCadastros.Controls.Add(btnNovoPaciente);
            groupBoxCadastros.Font = new Font("Segoe UI", 12F);
            groupBoxCadastros.Location = new Point(30, 30);
            groupBoxCadastros.Name = "groupBoxCadastros";
            groupBoxCadastros.Size = new Size(350, 209);
            groupBoxCadastros.TabIndex = 0;
            groupBoxCadastros.TabStop = false;
            groupBoxCadastros.Text = "Cadastros Rápidos";
            // 
            // btnCadAlimento
            // 
            btnCadAlimento.AutoSize = false;
            btnCadAlimento.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCadAlimento.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCadAlimento.Depth = 0;
            btnCadAlimento.HighEmphasis = true;
            btnCadAlimento.Icon = null;
            btnCadAlimento.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCadAlimento.Location = new Point(20, 130);
            btnCadAlimento.Margin = new Padding(4, 6, 4, 6);
            btnCadAlimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCadAlimento.Name = "btnCadAlimento";
            btnCadAlimento.NoAccentTextColor = Color.Empty;
            btnCadAlimento.Size = new Size(300, 50);
            btnCadAlimento.TabIndex = 1;
            btnCadAlimento.Text = "Cadastrar Alimento";
            btnCadAlimento.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCadAlimento.UseAccentColor = true;
            btnCadAlimento.UseVisualStyleBackColor = true;
            btnCadAlimento.Click += btnCadAlimento_Click;
            // 
            // btnNovoPaciente
            // 
            btnNovoPaciente.AutoSize = false;
            btnNovoPaciente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovoPaciente.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovoPaciente.Depth = 0;
            btnNovoPaciente.HighEmphasis = true;
            btnNovoPaciente.Icon = null;
            btnNovoPaciente.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovoPaciente.Location = new Point(20, 60);
            btnNovoPaciente.Margin = new Padding(4, 6, 4, 6);
            btnNovoPaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovoPaciente.Name = "btnNovoPaciente";
            btnNovoPaciente.NoAccentTextColor = Color.Empty;
            btnNovoPaciente.Size = new Size(300, 50);
            btnNovoPaciente.TabIndex = 0;
            btnNovoPaciente.Text = "Novo Paciente";
            btnNovoPaciente.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovoPaciente.UseAccentColor = true;
            btnNovoPaciente.UseVisualStyleBackColor = true;
            btnNovoPaciente.Click += btnNovoPaciente_Click;
            // 
            // tabPagePacientes
            // 
            tabPagePacientes.BackColor = Color.White;
            tabPagePacientes.Controls.Add(gridPacientes);
            tabPagePacientes.Controls.Add(txtBuscaPacientes);
            tabPagePacientes.Location = new Point(4, 24);
            tabPagePacientes.Name = "tabPagePacientes";
            tabPagePacientes.Padding = new Padding(3);
            tabPagePacientes.Size = new Size(804, 363);
            tabPagePacientes.TabIndex = 1;
            tabPagePacientes.Text = "Meus Pacientes";
            // 
            // gridPacientes
            // 
            gridPacientes.AllowUserToAddRows = false;
            gridPacientes.AllowUserToDeleteRows = false;
            gridPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPacientes.Dock = DockStyle.Fill;
            gridPacientes.Location = new Point(3, 51);
            gridPacientes.MultiSelect = false;
            gridPacientes.Name = "gridPacientes";
            gridPacientes.ReadOnly = true;
            gridPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPacientes.Size = new Size(798, 309);
            gridPacientes.TabIndex = 1;
            gridPacientes.CellDoubleClick += gridPacientes_CellDoubleClick;
            // 
            // txtBuscaPacientes
            // 
            txtBuscaPacientes.AnimateReadOnly = false;
            txtBuscaPacientes.AutoCompleteMode = AutoCompleteMode.None;
            txtBuscaPacientes.AutoCompleteSource = AutoCompleteSource.None;
            txtBuscaPacientes.BackgroundImageLayout = ImageLayout.None;
            txtBuscaPacientes.CharacterCasing = CharacterCasing.Normal;
            txtBuscaPacientes.Depth = 0;
            txtBuscaPacientes.Dock = DockStyle.Top;
            txtBuscaPacientes.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscaPacientes.HideSelection = true;
            txtBuscaPacientes.Hint = "🔍 Pesquisar Paciente por Nome...";
            txtBuscaPacientes.LeadingIcon = null;
            txtBuscaPacientes.Location = new Point(3, 3);
            txtBuscaPacientes.MaxLength = 32767;
            txtBuscaPacientes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBuscaPacientes.Name = "txtBuscaPacientes";
            txtBuscaPacientes.PasswordChar = '\0';
            txtBuscaPacientes.PrefixSuffixText = null;
            txtBuscaPacientes.ReadOnly = false;
            txtBuscaPacientes.RightToLeft = RightToLeft.No;
            txtBuscaPacientes.SelectedText = "";
            txtBuscaPacientes.SelectionLength = 0;
            txtBuscaPacientes.SelectionStart = 0;
            txtBuscaPacientes.ShortcutsEnabled = true;
            txtBuscaPacientes.Size = new Size(798, 48);
            txtBuscaPacientes.TabIndex = 0;
            txtBuscaPacientes.TabStop = false;
            txtBuscaPacientes.TextAlign = HorizontalAlignment.Left;
            txtBuscaPacientes.TrailingIcon = null;
            txtBuscaPacientes.UseSystemPasswordChar = false;
            txtBuscaPacientes.TextChanged += txtBuscaPacientes_TextChanged;
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BaseTabControl = materialTabControl1;
            materialTabSelector1.CharacterCasing = ReaLTaiizor.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Dock = DockStyle.Top;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.HeadAlignment = ReaLTaiizor.Controls.MaterialTabSelector.Alignment.Left;
            materialTabSelector1.Location = new Point(3, 64);
            materialTabSelector1.Margin = new Padding(0, 3, 0, 3);
            materialTabSelector1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(789, 52);
            materialTabSelector1.TabIndex = 0;
            materialTabSelector1.Click += materialTabSelector1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 469);
            Controls.Add(materialTabControl1);
            Controls.Add(materialTabSelector1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriSync - Gestão Inteligente";
            materialTabControl1.ResumeLayout(false);
            tabPageGeral.ResumeLayout(false);
            panelGeral.ResumeLayout(false);
            groupBoxAtendimento.ResumeLayout(false);
            groupBoxCadastros.ResumeLayout(false);
            tabPagePacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageGeral;
        private System.Windows.Forms.TabPage tabPagePacientes;
        private ReaLTaiizor.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Panel panelGeral;
        private System.Windows.Forms.GroupBox groupBoxAtendimento;
        private System.Windows.Forms.GroupBox groupBoxCadastros;
        private ReaLTaiizor.Controls.MaterialButton btnCadPlano;
        private ReaLTaiizor.Controls.MaterialButton btnNovaConsulta;
        private ReaLTaiizor.Controls.MaterialButton btnCadAlimento;
        private ReaLTaiizor.Controls.MaterialButton btnNovoPaciente;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBuscaPacientes;
        private System.Windows.Forms.DataGridView gridPacientes;
        private ReaLTaiizor.Controls.MaterialButton btnDashboard;
    }
}