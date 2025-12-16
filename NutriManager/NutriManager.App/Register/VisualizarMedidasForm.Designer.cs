namespace NutriManager.App.Pages
{
    partial class VisualizarMedidasForm
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
            txtPanturrilhaE = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPanturrilhaD = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCoxaE = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCoxaD = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBracoE = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBracoD = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtQuadril = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCintura = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAltura = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPeso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            lblTitulo.Size = new Size(280, 29);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Medidas Antropométricas";
            // 
            // groupBoxDados
            // 
            groupBoxDados.Controls.Add(txtPanturrilhaE);
            groupBoxDados.Controls.Add(txtPanturrilhaD);
            groupBoxDados.Controls.Add(txtCoxaE);
            groupBoxDados.Controls.Add(txtCoxaD);
            groupBoxDados.Controls.Add(txtBracoE);
            groupBoxDados.Controls.Add(txtBracoD);
            groupBoxDados.Controls.Add(txtQuadril);
            groupBoxDados.Controls.Add(txtCintura);
            groupBoxDados.Controls.Add(txtAltura);
            groupBoxDados.Controls.Add(txtPeso);
            groupBoxDados.Font = new Font("Segoe UI", 10F);
            groupBoxDados.Location = new Point(20, 120);
            groupBoxDados.Name = "groupBoxDados";
            groupBoxDados.Size = new Size(460, 340);
            groupBoxDados.TabIndex = 1;
            groupBoxDados.TabStop = false;
            groupBoxDados.Text = "Resultados (cm / kg)";
            // 
            // txtPanturrilhaE
            // 
            txtPanturrilhaE.AnimateReadOnly = false;
            txtPanturrilhaE.AutoCompleteMode = AutoCompleteMode.None;
            txtPanturrilhaE.AutoCompleteSource = AutoCompleteSource.None;
            txtPanturrilhaE.BackgroundImageLayout = ImageLayout.None;
            txtPanturrilhaE.CharacterCasing = CharacterCasing.Normal;
            txtPanturrilhaE.Depth = 0;
            txtPanturrilhaE.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPanturrilhaE.HideSelection = true;
            txtPanturrilhaE.LeadingIcon = null;
            txtPanturrilhaE.Location = new Point(0, 0);
            txtPanturrilhaE.MaxLength = 32767;
            txtPanturrilhaE.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPanturrilhaE.Name = "txtPanturrilhaE";
            txtPanturrilhaE.PasswordChar = '\0';
            txtPanturrilhaE.PrefixSuffixText = null;
            txtPanturrilhaE.ReadOnly = false;
            txtPanturrilhaE.RightToLeft = RightToLeft.No;
            txtPanturrilhaE.SelectedText = "";
            txtPanturrilhaE.SelectionLength = 0;
            txtPanturrilhaE.SelectionStart = 0;
            txtPanturrilhaE.ShortcutsEnabled = true;
            txtPanturrilhaE.Size = new Size(250, 48);
            txtPanturrilhaE.TabIndex = 0;
            txtPanturrilhaE.TabStop = false;
            txtPanturrilhaE.TextAlign = HorizontalAlignment.Left;
            txtPanturrilhaE.TrailingIcon = null;
            txtPanturrilhaE.UseSystemPasswordChar = false;
            // 
            // txtPanturrilhaD
            // 
            txtPanturrilhaD.AnimateReadOnly = false;
            txtPanturrilhaD.AutoCompleteMode = AutoCompleteMode.None;
            txtPanturrilhaD.AutoCompleteSource = AutoCompleteSource.None;
            txtPanturrilhaD.BackgroundImageLayout = ImageLayout.None;
            txtPanturrilhaD.CharacterCasing = CharacterCasing.Normal;
            txtPanturrilhaD.Depth = 0;
            txtPanturrilhaD.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPanturrilhaD.HideSelection = true;
            txtPanturrilhaD.LeadingIcon = null;
            txtPanturrilhaD.Location = new Point(0, 0);
            txtPanturrilhaD.MaxLength = 32767;
            txtPanturrilhaD.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPanturrilhaD.Name = "txtPanturrilhaD";
            txtPanturrilhaD.PasswordChar = '\0';
            txtPanturrilhaD.PrefixSuffixText = null;
            txtPanturrilhaD.ReadOnly = false;
            txtPanturrilhaD.RightToLeft = RightToLeft.No;
            txtPanturrilhaD.SelectedText = "";
            txtPanturrilhaD.SelectionLength = 0;
            txtPanturrilhaD.SelectionStart = 0;
            txtPanturrilhaD.ShortcutsEnabled = true;
            txtPanturrilhaD.Size = new Size(250, 48);
            txtPanturrilhaD.TabIndex = 1;
            txtPanturrilhaD.TabStop = false;
            txtPanturrilhaD.TextAlign = HorizontalAlignment.Left;
            txtPanturrilhaD.TrailingIcon = null;
            txtPanturrilhaD.UseSystemPasswordChar = false;
            // 
            // txtCoxaE
            // 
            txtCoxaE.AnimateReadOnly = false;
            txtCoxaE.AutoCompleteMode = AutoCompleteMode.None;
            txtCoxaE.AutoCompleteSource = AutoCompleteSource.None;
            txtCoxaE.BackgroundImageLayout = ImageLayout.None;
            txtCoxaE.CharacterCasing = CharacterCasing.Normal;
            txtCoxaE.Depth = 0;
            txtCoxaE.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCoxaE.HideSelection = true;
            txtCoxaE.LeadingIcon = null;
            txtCoxaE.Location = new Point(0, 0);
            txtCoxaE.MaxLength = 32767;
            txtCoxaE.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCoxaE.Name = "txtCoxaE";
            txtCoxaE.PasswordChar = '\0';
            txtCoxaE.PrefixSuffixText = null;
            txtCoxaE.ReadOnly = false;
            txtCoxaE.RightToLeft = RightToLeft.No;
            txtCoxaE.SelectedText = "";
            txtCoxaE.SelectionLength = 0;
            txtCoxaE.SelectionStart = 0;
            txtCoxaE.ShortcutsEnabled = true;
            txtCoxaE.Size = new Size(250, 48);
            txtCoxaE.TabIndex = 2;
            txtCoxaE.TabStop = false;
            txtCoxaE.TextAlign = HorizontalAlignment.Left;
            txtCoxaE.TrailingIcon = null;
            txtCoxaE.UseSystemPasswordChar = false;
            // 
            // txtCoxaD
            // 
            txtCoxaD.AnimateReadOnly = false;
            txtCoxaD.AutoCompleteMode = AutoCompleteMode.None;
            txtCoxaD.AutoCompleteSource = AutoCompleteSource.None;
            txtCoxaD.BackgroundImageLayout = ImageLayout.None;
            txtCoxaD.CharacterCasing = CharacterCasing.Normal;
            txtCoxaD.Depth = 0;
            txtCoxaD.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCoxaD.HideSelection = true;
            txtCoxaD.LeadingIcon = null;
            txtCoxaD.Location = new Point(0, 0);
            txtCoxaD.MaxLength = 32767;
            txtCoxaD.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCoxaD.Name = "txtCoxaD";
            txtCoxaD.PasswordChar = '\0';
            txtCoxaD.PrefixSuffixText = null;
            txtCoxaD.ReadOnly = false;
            txtCoxaD.RightToLeft = RightToLeft.No;
            txtCoxaD.SelectedText = "";
            txtCoxaD.SelectionLength = 0;
            txtCoxaD.SelectionStart = 0;
            txtCoxaD.ShortcutsEnabled = true;
            txtCoxaD.Size = new Size(250, 48);
            txtCoxaD.TabIndex = 3;
            txtCoxaD.TabStop = false;
            txtCoxaD.TextAlign = HorizontalAlignment.Left;
            txtCoxaD.TrailingIcon = null;
            txtCoxaD.UseSystemPasswordChar = false;
            // 
            // txtBracoE
            // 
            txtBracoE.AnimateReadOnly = false;
            txtBracoE.AutoCompleteMode = AutoCompleteMode.None;
            txtBracoE.AutoCompleteSource = AutoCompleteSource.None;
            txtBracoE.BackgroundImageLayout = ImageLayout.None;
            txtBracoE.CharacterCasing = CharacterCasing.Normal;
            txtBracoE.Depth = 0;
            txtBracoE.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBracoE.HideSelection = true;
            txtBracoE.LeadingIcon = null;
            txtBracoE.Location = new Point(0, 0);
            txtBracoE.MaxLength = 32767;
            txtBracoE.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBracoE.Name = "txtBracoE";
            txtBracoE.PasswordChar = '\0';
            txtBracoE.PrefixSuffixText = null;
            txtBracoE.ReadOnly = false;
            txtBracoE.RightToLeft = RightToLeft.No;
            txtBracoE.SelectedText = "";
            txtBracoE.SelectionLength = 0;
            txtBracoE.SelectionStart = 0;
            txtBracoE.ShortcutsEnabled = true;
            txtBracoE.Size = new Size(250, 48);
            txtBracoE.TabIndex = 4;
            txtBracoE.TabStop = false;
            txtBracoE.TextAlign = HorizontalAlignment.Left;
            txtBracoE.TrailingIcon = null;
            txtBracoE.UseSystemPasswordChar = false;
            // 
            // txtBracoD
            // 
            txtBracoD.AnimateReadOnly = false;
            txtBracoD.AutoCompleteMode = AutoCompleteMode.None;
            txtBracoD.AutoCompleteSource = AutoCompleteSource.None;
            txtBracoD.BackgroundImageLayout = ImageLayout.None;
            txtBracoD.CharacterCasing = CharacterCasing.Normal;
            txtBracoD.Depth = 0;
            txtBracoD.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBracoD.HideSelection = true;
            txtBracoD.LeadingIcon = null;
            txtBracoD.Location = new Point(0, 0);
            txtBracoD.MaxLength = 32767;
            txtBracoD.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBracoD.Name = "txtBracoD";
            txtBracoD.PasswordChar = '\0';
            txtBracoD.PrefixSuffixText = null;
            txtBracoD.ReadOnly = false;
            txtBracoD.RightToLeft = RightToLeft.No;
            txtBracoD.SelectedText = "";
            txtBracoD.SelectionLength = 0;
            txtBracoD.SelectionStart = 0;
            txtBracoD.ShortcutsEnabled = true;
            txtBracoD.Size = new Size(250, 48);
            txtBracoD.TabIndex = 5;
            txtBracoD.TabStop = false;
            txtBracoD.TextAlign = HorizontalAlignment.Left;
            txtBracoD.TrailingIcon = null;
            txtBracoD.UseSystemPasswordChar = false;
            // 
            // txtQuadril
            // 
            txtQuadril.AnimateReadOnly = false;
            txtQuadril.AutoCompleteMode = AutoCompleteMode.None;
            txtQuadril.AutoCompleteSource = AutoCompleteSource.None;
            txtQuadril.BackgroundImageLayout = ImageLayout.None;
            txtQuadril.CharacterCasing = CharacterCasing.Normal;
            txtQuadril.Depth = 0;
            txtQuadril.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuadril.HideSelection = true;
            txtQuadril.LeadingIcon = null;
            txtQuadril.Location = new Point(0, 0);
            txtQuadril.MaxLength = 32767;
            txtQuadril.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQuadril.Name = "txtQuadril";
            txtQuadril.PasswordChar = '\0';
            txtQuadril.PrefixSuffixText = null;
            txtQuadril.ReadOnly = false;
            txtQuadril.RightToLeft = RightToLeft.No;
            txtQuadril.SelectedText = "";
            txtQuadril.SelectionLength = 0;
            txtQuadril.SelectionStart = 0;
            txtQuadril.ShortcutsEnabled = true;
            txtQuadril.Size = new Size(250, 48);
            txtQuadril.TabIndex = 6;
            txtQuadril.TabStop = false;
            txtQuadril.TextAlign = HorizontalAlignment.Left;
            txtQuadril.TrailingIcon = null;
            txtQuadril.UseSystemPasswordChar = false;
            // 
            // txtCintura
            // 
            txtCintura.AnimateReadOnly = false;
            txtCintura.AutoCompleteMode = AutoCompleteMode.None;
            txtCintura.AutoCompleteSource = AutoCompleteSource.None;
            txtCintura.BackgroundImageLayout = ImageLayout.None;
            txtCintura.CharacterCasing = CharacterCasing.Normal;
            txtCintura.Depth = 0;
            txtCintura.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCintura.HideSelection = true;
            txtCintura.LeadingIcon = null;
            txtCintura.Location = new Point(0, 0);
            txtCintura.MaxLength = 32767;
            txtCintura.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCintura.Name = "txtCintura";
            txtCintura.PasswordChar = '\0';
            txtCintura.PrefixSuffixText = null;
            txtCintura.ReadOnly = false;
            txtCintura.RightToLeft = RightToLeft.No;
            txtCintura.SelectedText = "";
            txtCintura.SelectionLength = 0;
            txtCintura.SelectionStart = 0;
            txtCintura.ShortcutsEnabled = true;
            txtCintura.Size = new Size(250, 48);
            txtCintura.TabIndex = 7;
            txtCintura.TabStop = false;
            txtCintura.TextAlign = HorizontalAlignment.Left;
            txtCintura.TrailingIcon = null;
            txtCintura.UseSystemPasswordChar = false;
            // 
            // txtAltura
            // 
            txtAltura.AnimateReadOnly = false;
            txtAltura.AutoCompleteMode = AutoCompleteMode.None;
            txtAltura.AutoCompleteSource = AutoCompleteSource.None;
            txtAltura.BackgroundImageLayout = ImageLayout.None;
            txtAltura.CharacterCasing = CharacterCasing.Normal;
            txtAltura.Depth = 0;
            txtAltura.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAltura.HideSelection = true;
            txtAltura.LeadingIcon = null;
            txtAltura.Location = new Point(0, 0);
            txtAltura.MaxLength = 32767;
            txtAltura.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAltura.Name = "txtAltura";
            txtAltura.PasswordChar = '\0';
            txtAltura.PrefixSuffixText = null;
            txtAltura.ReadOnly = false;
            txtAltura.RightToLeft = RightToLeft.No;
            txtAltura.SelectedText = "";
            txtAltura.SelectionLength = 0;
            txtAltura.SelectionStart = 0;
            txtAltura.ShortcutsEnabled = true;
            txtAltura.Size = new Size(250, 48);
            txtAltura.TabIndex = 8;
            txtAltura.TabStop = false;
            txtAltura.TextAlign = HorizontalAlignment.Left;
            txtAltura.TrailingIcon = null;
            txtAltura.UseSystemPasswordChar = false;
            // 
            // txtPeso
            // 
            txtPeso.AnimateReadOnly = false;
            txtPeso.AutoCompleteMode = AutoCompleteMode.None;
            txtPeso.AutoCompleteSource = AutoCompleteSource.None;
            txtPeso.BackgroundImageLayout = ImageLayout.None;
            txtPeso.CharacterCasing = CharacterCasing.Normal;
            txtPeso.Depth = 0;
            txtPeso.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPeso.HideSelection = true;
            txtPeso.LeadingIcon = null;
            txtPeso.Location = new Point(0, 0);
            txtPeso.MaxLength = 32767;
            txtPeso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPeso.Name = "txtPeso";
            txtPeso.PasswordChar = '\0';
            txtPeso.PrefixSuffixText = null;
            txtPeso.ReadOnly = false;
            txtPeso.RightToLeft = RightToLeft.No;
            txtPeso.SelectedText = "";
            txtPeso.SelectionLength = 0;
            txtPeso.SelectionStart = 0;
            txtPeso.ShortcutsEnabled = true;
            txtPeso.Size = new Size(250, 48);
            txtPeso.TabIndex = 9;
            txtPeso.TabStop = false;
            txtPeso.TextAlign = HorizontalAlignment.Left;
            txtPeso.TrailingIcon = null;
            txtPeso.UseSystemPasswordChar = false;
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
            btnFechar.Location = new Point(330, 480);
            btnFechar.Margin = new Padding(4, 6, 4, 6);
            btnFechar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnFechar.Name = "btnFechar";
            btnFechar.NoAccentTextColor = Color.Empty;
            btnFechar.Size = new Size(150, 36);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "FECHAR";
            btnFechar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFechar.UseAccentColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // VisualizarMedidasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 540);
            Controls.Add(btnFechar);
            Controls.Add(groupBoxDados);
            Controls.Add(lblTitulo);
            MaximizeBox = false;
            Name = "VisualizarMedidasForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Consulta de Medidas";
            groupBoxDados.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        // Método auxiliar para não repetir código de configuração
        private void ConfigurarCampo(ReaLTaiizor.Controls.MaterialTextBoxEdit txt, string hint, int x, int y)
        {
            txt.Depth = 0;
            txt.Hint = hint;
            txt.Location = new System.Drawing.Point(x, y);
            txt.MaxLength = 32767;
            txt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txt.Name = "txt" + hint.Replace(" ", "").Replace(".", ""); // Nome genérico temporário
            txt.ReadOnly = true;
            txt.Size = new System.Drawing.Size(180, 48);
            txt.UseSystemPasswordChar = false;
        }

        private ReaLTaiizor.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxDados;
        private ReaLTaiizor.Controls.MaterialButton btnFechar;

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPeso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAltura;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCintura;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuadril;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBracoD;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBracoE;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCoxaD;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCoxaE;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPanturrilhaD;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPanturrilhaE;
    }
}