namespace NutriManager.App.Pages
{
    partial class VisualizarBioimpedanciaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new ReaLTaiizor.Controls.MaterialLabel();
            groupBoxDados = new GroupBox();
            txtTMB = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMassaMagra = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMassaGorda = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPercAgua = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPercMassaMagra = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPercGordura = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnFechar = new ReaLTaiizor.Controls.MaterialButton();
            groupBoxDados.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Depth = 0;
            lblTitulo.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTitulo.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            lblTitulo.Location = new Point(20, 80);
            lblTitulo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(294, 29);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Detalhes da Bioimpedância";
            // 
            // groupBoxDados
            // 
            groupBoxDados.Controls.Add(txtTMB);
            groupBoxDados.Controls.Add(txtMassaMagra);
            groupBoxDados.Controls.Add(txtMassaGorda);
            groupBoxDados.Controls.Add(txtPercAgua);
            groupBoxDados.Controls.Add(txtPercMassaMagra);
            groupBoxDados.Controls.Add(txtPercGordura);
            groupBoxDados.Font = new Font("Segoe UI", 10F);
            groupBoxDados.Location = new Point(20, 120);
            groupBoxDados.Name = "groupBoxDados";
            groupBoxDados.Size = new Size(560, 200);
            groupBoxDados.TabIndex = 1;
            groupBoxDados.TabStop = false;
            groupBoxDados.Text = "Resultados";
            // 
            // txtTMB
            // 
            txtTMB.AnimateReadOnly = false;
            txtTMB.AutoCompleteMode = AutoCompleteMode.None;
            txtTMB.AutoCompleteSource = AutoCompleteSource.None;
            txtTMB.BackgroundImageLayout = ImageLayout.None;
            txtTMB.CharacterCasing = CharacterCasing.Normal;
            txtTMB.Depth = 0;
            txtTMB.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTMB.HideSelection = true;
            txtTMB.Hint = "TMB (Kcal)";
            txtTMB.LeadingIcon = null;
            txtTMB.Location = new Point(360, 110);
            txtTMB.MaxLength = 32767;
            txtTMB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTMB.Name = "txtTMB";
            txtTMB.PasswordChar = '\0';
            txtTMB.PrefixSuffixText = null;
            txtTMB.ReadOnly = true;
            txtTMB.RightToLeft = RightToLeft.No;
            txtTMB.SelectedText = "";
            txtTMB.SelectionLength = 0;
            txtTMB.SelectionStart = 0;
            txtTMB.ShortcutsEnabled = true;
            txtTMB.Size = new Size(150, 48);
            txtTMB.TabIndex = 5;
            txtTMB.TabStop = false;
            txtTMB.TextAlign = HorizontalAlignment.Left;
            txtTMB.TrailingIcon = null;
            txtTMB.UseSystemPasswordChar = false;
            // 
            // txtMassaMagra
            // 
            txtMassaMagra.AnimateReadOnly = false;
            txtMassaMagra.AutoCompleteMode = AutoCompleteMode.None;
            txtMassaMagra.AutoCompleteSource = AutoCompleteSource.None;
            txtMassaMagra.BackgroundImageLayout = ImageLayout.None;
            txtMassaMagra.CharacterCasing = CharacterCasing.Normal;
            txtMassaMagra.Depth = 0;
            txtMassaMagra.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMassaMagra.HideSelection = true;
            txtMassaMagra.Hint = "Massa Magra (kg)";
            txtMassaMagra.LeadingIcon = null;
            txtMassaMagra.Location = new Point(190, 110);
            txtMassaMagra.MaxLength = 32767;
            txtMassaMagra.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMassaMagra.Name = "txtMassaMagra";
            txtMassaMagra.PasswordChar = '\0';
            txtMassaMagra.PrefixSuffixText = null;
            txtMassaMagra.ReadOnly = true;
            txtMassaMagra.RightToLeft = RightToLeft.No;
            txtMassaMagra.SelectedText = "";
            txtMassaMagra.SelectionLength = 0;
            txtMassaMagra.SelectionStart = 0;
            txtMassaMagra.ShortcutsEnabled = true;
            txtMassaMagra.Size = new Size(150, 48);
            txtMassaMagra.TabIndex = 4;
            txtMassaMagra.TabStop = false;
            txtMassaMagra.TextAlign = HorizontalAlignment.Left;
            txtMassaMagra.TrailingIcon = null;
            txtMassaMagra.UseSystemPasswordChar = false;
            // 
            // txtMassaGorda
            // 
            txtMassaGorda.AnimateReadOnly = false;
            txtMassaGorda.AutoCompleteMode = AutoCompleteMode.None;
            txtMassaGorda.AutoCompleteSource = AutoCompleteSource.None;
            txtMassaGorda.BackgroundImageLayout = ImageLayout.None;
            txtMassaGorda.CharacterCasing = CharacterCasing.Normal;
            txtMassaGorda.Depth = 0;
            txtMassaGorda.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMassaGorda.HideSelection = true;
            txtMassaGorda.Hint = "Massa Gorda (kg)";
            txtMassaGorda.LeadingIcon = null;
            txtMassaGorda.Location = new Point(20, 110);
            txtMassaGorda.MaxLength = 32767;
            txtMassaGorda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMassaGorda.Name = "txtMassaGorda";
            txtMassaGorda.PasswordChar = '\0';
            txtMassaGorda.PrefixSuffixText = null;
            txtMassaGorda.ReadOnly = true;
            txtMassaGorda.RightToLeft = RightToLeft.No;
            txtMassaGorda.SelectedText = "";
            txtMassaGorda.SelectionLength = 0;
            txtMassaGorda.SelectionStart = 0;
            txtMassaGorda.ShortcutsEnabled = true;
            txtMassaGorda.Size = new Size(150, 48);
            txtMassaGorda.TabIndex = 3;
            txtMassaGorda.TabStop = false;
            txtMassaGorda.TextAlign = HorizontalAlignment.Left;
            txtMassaGorda.TrailingIcon = null;
            txtMassaGorda.UseSystemPasswordChar = false;
            // 
            // txtPercAgua
            // 
            txtPercAgua.AnimateReadOnly = false;
            txtPercAgua.AutoCompleteMode = AutoCompleteMode.None;
            txtPercAgua.AutoCompleteSource = AutoCompleteSource.None;
            txtPercAgua.BackgroundImageLayout = ImageLayout.None;
            txtPercAgua.CharacterCasing = CharacterCasing.Normal;
            txtPercAgua.Depth = 0;
            txtPercAgua.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPercAgua.HideSelection = true;
            txtPercAgua.Hint = "% Água Corporal";
            txtPercAgua.LeadingIcon = null;
            txtPercAgua.Location = new Point(360, 40);
            txtPercAgua.MaxLength = 32767;
            txtPercAgua.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPercAgua.Name = "txtPercAgua";
            txtPercAgua.PasswordChar = '\0';
            txtPercAgua.PrefixSuffixText = null;
            txtPercAgua.ReadOnly = true;
            txtPercAgua.RightToLeft = RightToLeft.No;
            txtPercAgua.SelectedText = "";
            txtPercAgua.SelectionLength = 0;
            txtPercAgua.SelectionStart = 0;
            txtPercAgua.ShortcutsEnabled = true;
            txtPercAgua.Size = new Size(150, 48);
            txtPercAgua.TabIndex = 2;
            txtPercAgua.TabStop = false;
            txtPercAgua.TextAlign = HorizontalAlignment.Left;
            txtPercAgua.TrailingIcon = null;
            txtPercAgua.UseSystemPasswordChar = false;
            // 
            // txtPercMassaMagra
            // 
            txtPercMassaMagra.AnimateReadOnly = false;
            txtPercMassaMagra.AutoCompleteMode = AutoCompleteMode.None;
            txtPercMassaMagra.AutoCompleteSource = AutoCompleteSource.None;
            txtPercMassaMagra.BackgroundImageLayout = ImageLayout.None;
            txtPercMassaMagra.CharacterCasing = CharacterCasing.Normal;
            txtPercMassaMagra.Depth = 0;
            txtPercMassaMagra.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPercMassaMagra.HideSelection = true;
            txtPercMassaMagra.Hint = "% Massa Magra";
            txtPercMassaMagra.LeadingIcon = null;
            txtPercMassaMagra.Location = new Point(190, 40);
            txtPercMassaMagra.MaxLength = 32767;
            txtPercMassaMagra.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPercMassaMagra.Name = "txtPercMassaMagra";
            txtPercMassaMagra.PasswordChar = '\0';
            txtPercMassaMagra.PrefixSuffixText = null;
            txtPercMassaMagra.ReadOnly = true;
            txtPercMassaMagra.RightToLeft = RightToLeft.No;
            txtPercMassaMagra.SelectedText = "";
            txtPercMassaMagra.SelectionLength = 0;
            txtPercMassaMagra.SelectionStart = 0;
            txtPercMassaMagra.ShortcutsEnabled = true;
            txtPercMassaMagra.Size = new Size(150, 48);
            txtPercMassaMagra.TabIndex = 1;
            txtPercMassaMagra.TabStop = false;
            txtPercMassaMagra.TextAlign = HorizontalAlignment.Left;
            txtPercMassaMagra.TrailingIcon = null;
            txtPercMassaMagra.UseSystemPasswordChar = false;
            // 
            // txtPercGordura
            // 
            txtPercGordura.AnimateReadOnly = false;
            txtPercGordura.AutoCompleteMode = AutoCompleteMode.None;
            txtPercGordura.AutoCompleteSource = AutoCompleteSource.None;
            txtPercGordura.BackgroundImageLayout = ImageLayout.None;
            txtPercGordura.CharacterCasing = CharacterCasing.Normal;
            txtPercGordura.Depth = 0;
            txtPercGordura.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPercGordura.HideSelection = true;
            txtPercGordura.Hint = "% Gordura";
            txtPercGordura.LeadingIcon = null;
            txtPercGordura.Location = new Point(20, 40);
            txtPercGordura.MaxLength = 32767;
            txtPercGordura.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPercGordura.Name = "txtPercGordura";
            txtPercGordura.PasswordChar = '\0';
            txtPercGordura.PrefixSuffixText = null;
            txtPercGordura.ReadOnly = true;
            txtPercGordura.RightToLeft = RightToLeft.No;
            txtPercGordura.SelectedText = "";
            txtPercGordura.SelectionLength = 0;
            txtPercGordura.SelectionStart = 0;
            txtPercGordura.ShortcutsEnabled = true;
            txtPercGordura.Size = new Size(150, 48);
            txtPercGordura.TabIndex = 0;
            txtPercGordura.TabStop = false;
            txtPercGordura.TextAlign = HorizontalAlignment.Left;
            txtPercGordura.TrailingIcon = null;
            txtPercGordura.UseSystemPasswordChar = false;
            // 
            // btnFechar
            // 
            btnFechar.AutoSize = false;
            btnFechar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFechar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFechar.Depth = 0;
            btnFechar.HighEmphasis = true;
            btnFechar.Icon = null;
            btnFechar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnFechar.Location = new Point(430, 340);
            btnFechar.Margin = new Padding(4, 6, 4, 6);
            btnFechar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnFechar.Name = "btnFechar";
            btnFechar.NoAccentTextColor = Color.Empty;
            btnFechar.Size = new Size(150, 36);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "FECHAR";
            btnFechar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFechar.UseAccentColor = true;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // VisualizarBioimpedanciaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(btnFechar);
            Controls.Add(groupBoxDados);
            Controls.Add(lblTitulo);
            MaximizeBox = false;
            Name = "VisualizarBioimpedanciaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Consulta de Bioimpedância";
            groupBoxDados.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private ReaLTaiizor.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxDados;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPercGordura;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPercMassaMagra;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPercAgua;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMassaGorda;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMassaMagra;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTMB;
        private ReaLTaiizor.Controls.MaterialButton btnFechar;
    }
}