namespace NutriManager.App.Pages
{
    partial class VisualizarDobrasForm
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
            txtDobraCoxa = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDobraAbdominal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDobraSuprailiaca = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDobraSubescapular = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDobraTricipital = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            lblTitulo.Size = new Size(184, 29);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Dobras Cutâneas";
            // 
            // groupBoxDados
            // 
            groupBoxDados.Controls.Add(txtDobraCoxa);
            groupBoxDados.Controls.Add(txtDobraAbdominal);
            groupBoxDados.Controls.Add(txtDobraSuprailiaca);
            groupBoxDados.Controls.Add(txtDobraSubescapular);
            groupBoxDados.Controls.Add(txtDobraTricipital);
            groupBoxDados.Font = new Font("Segoe UI", 10F);
            groupBoxDados.Location = new Point(20, 120);
            groupBoxDados.Name = "groupBoxDados";
            groupBoxDados.Size = new Size(460, 240);
            groupBoxDados.TabIndex = 1;
            groupBoxDados.TabStop = false;
            groupBoxDados.Text = "Resultados (mm)";
            // 
            // txtDobraCoxa
            // 
            txtDobraCoxa.AnimateReadOnly = false;
            txtDobraCoxa.AutoCompleteMode = AutoCompleteMode.None;
            txtDobraCoxa.AutoCompleteSource = AutoCompleteSource.None;
            txtDobraCoxa.BackgroundImageLayout = ImageLayout.None;
            txtDobraCoxa.CharacterCasing = CharacterCasing.Normal;
            txtDobraCoxa.Depth = 0;
            txtDobraCoxa.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDobraCoxa.HideSelection = true;
            txtDobraCoxa.LeadingIcon = null;
            txtDobraCoxa.Location = new Point(0, 0);
            txtDobraCoxa.MaxLength = 32767;
            txtDobraCoxa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDobraCoxa.Name = "txtDobraCoxa";
            txtDobraCoxa.PasswordChar = '\0';
            txtDobraCoxa.PrefixSuffixText = null;
            txtDobraCoxa.ReadOnly = false;
            txtDobraCoxa.RightToLeft = RightToLeft.No;
            txtDobraCoxa.SelectedText = "";
            txtDobraCoxa.SelectionLength = 0;
            txtDobraCoxa.SelectionStart = 0;
            txtDobraCoxa.ShortcutsEnabled = true;
            txtDobraCoxa.Size = new Size(250, 48);
            txtDobraCoxa.TabIndex = 0;
            txtDobraCoxa.TabStop = false;
            txtDobraCoxa.TextAlign = HorizontalAlignment.Left;
            txtDobraCoxa.TrailingIcon = null;
            txtDobraCoxa.UseSystemPasswordChar = false;
            // 
            // txtDobraAbdominal
            // 
            txtDobraAbdominal.AnimateReadOnly = false;
            txtDobraAbdominal.AutoCompleteMode = AutoCompleteMode.None;
            txtDobraAbdominal.AutoCompleteSource = AutoCompleteSource.None;
            txtDobraAbdominal.BackgroundImageLayout = ImageLayout.None;
            txtDobraAbdominal.CharacterCasing = CharacterCasing.Normal;
            txtDobraAbdominal.Depth = 0;
            txtDobraAbdominal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDobraAbdominal.HideSelection = true;
            txtDobraAbdominal.LeadingIcon = null;
            txtDobraAbdominal.Location = new Point(0, 0);
            txtDobraAbdominal.MaxLength = 32767;
            txtDobraAbdominal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDobraAbdominal.Name = "txtDobraAbdominal";
            txtDobraAbdominal.PasswordChar = '\0';
            txtDobraAbdominal.PrefixSuffixText = null;
            txtDobraAbdominal.ReadOnly = false;
            txtDobraAbdominal.RightToLeft = RightToLeft.No;
            txtDobraAbdominal.SelectedText = "";
            txtDobraAbdominal.SelectionLength = 0;
            txtDobraAbdominal.SelectionStart = 0;
            txtDobraAbdominal.ShortcutsEnabled = true;
            txtDobraAbdominal.Size = new Size(250, 48);
            txtDobraAbdominal.TabIndex = 1;
            txtDobraAbdominal.TabStop = false;
            txtDobraAbdominal.TextAlign = HorizontalAlignment.Left;
            txtDobraAbdominal.TrailingIcon = null;
            txtDobraAbdominal.UseSystemPasswordChar = false;
            // 
            // txtDobraSuprailiaca
            // 
            txtDobraSuprailiaca.AnimateReadOnly = false;
            txtDobraSuprailiaca.AutoCompleteMode = AutoCompleteMode.None;
            txtDobraSuprailiaca.AutoCompleteSource = AutoCompleteSource.None;
            txtDobraSuprailiaca.BackgroundImageLayout = ImageLayout.None;
            txtDobraSuprailiaca.CharacterCasing = CharacterCasing.Normal;
            txtDobraSuprailiaca.Depth = 0;
            txtDobraSuprailiaca.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDobraSuprailiaca.HideSelection = true;
            txtDobraSuprailiaca.LeadingIcon = null;
            txtDobraSuprailiaca.Location = new Point(0, 0);
            txtDobraSuprailiaca.MaxLength = 32767;
            txtDobraSuprailiaca.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDobraSuprailiaca.Name = "txtDobraSuprailiaca";
            txtDobraSuprailiaca.PasswordChar = '\0';
            txtDobraSuprailiaca.PrefixSuffixText = null;
            txtDobraSuprailiaca.ReadOnly = false;
            txtDobraSuprailiaca.RightToLeft = RightToLeft.No;
            txtDobraSuprailiaca.SelectedText = "";
            txtDobraSuprailiaca.SelectionLength = 0;
            txtDobraSuprailiaca.SelectionStart = 0;
            txtDobraSuprailiaca.ShortcutsEnabled = true;
            txtDobraSuprailiaca.Size = new Size(250, 48);
            txtDobraSuprailiaca.TabIndex = 2;
            txtDobraSuprailiaca.TabStop = false;
            txtDobraSuprailiaca.TextAlign = HorizontalAlignment.Left;
            txtDobraSuprailiaca.TrailingIcon = null;
            txtDobraSuprailiaca.UseSystemPasswordChar = false;
            // 
            // txtDobraSubescapular
            // 
            txtDobraSubescapular.AnimateReadOnly = false;
            txtDobraSubescapular.AutoCompleteMode = AutoCompleteMode.None;
            txtDobraSubescapular.AutoCompleteSource = AutoCompleteSource.None;
            txtDobraSubescapular.BackgroundImageLayout = ImageLayout.None;
            txtDobraSubescapular.CharacterCasing = CharacterCasing.Normal;
            txtDobraSubescapular.Depth = 0;
            txtDobraSubescapular.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDobraSubescapular.HideSelection = true;
            txtDobraSubescapular.LeadingIcon = null;
            txtDobraSubescapular.Location = new Point(0, 0);
            txtDobraSubescapular.MaxLength = 32767;
            txtDobraSubescapular.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDobraSubescapular.Name = "txtDobraSubescapular";
            txtDobraSubescapular.PasswordChar = '\0';
            txtDobraSubescapular.PrefixSuffixText = null;
            txtDobraSubescapular.ReadOnly = false;
            txtDobraSubescapular.RightToLeft = RightToLeft.No;
            txtDobraSubescapular.SelectedText = "";
            txtDobraSubescapular.SelectionLength = 0;
            txtDobraSubescapular.SelectionStart = 0;
            txtDobraSubescapular.ShortcutsEnabled = true;
            txtDobraSubescapular.Size = new Size(250, 48);
            txtDobraSubescapular.TabIndex = 3;
            txtDobraSubescapular.TabStop = false;
            txtDobraSubescapular.TextAlign = HorizontalAlignment.Left;
            txtDobraSubescapular.TrailingIcon = null;
            txtDobraSubescapular.UseSystemPasswordChar = false;
            // 
            // txtDobraTricipital
            // 
            txtDobraTricipital.AnimateReadOnly = false;
            txtDobraTricipital.AutoCompleteMode = AutoCompleteMode.None;
            txtDobraTricipital.AutoCompleteSource = AutoCompleteSource.None;
            txtDobraTricipital.BackgroundImageLayout = ImageLayout.None;
            txtDobraTricipital.CharacterCasing = CharacterCasing.Normal;
            txtDobraTricipital.Depth = 0;
            txtDobraTricipital.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDobraTricipital.HideSelection = true;
            txtDobraTricipital.LeadingIcon = null;
            txtDobraTricipital.Location = new Point(0, 0);
            txtDobraTricipital.MaxLength = 32767;
            txtDobraTricipital.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDobraTricipital.Name = "txtDobraTricipital";
            txtDobraTricipital.PasswordChar = '\0';
            txtDobraTricipital.PrefixSuffixText = null;
            txtDobraTricipital.ReadOnly = false;
            txtDobraTricipital.RightToLeft = RightToLeft.No;
            txtDobraTricipital.SelectedText = "";
            txtDobraTricipital.SelectionLength = 0;
            txtDobraTricipital.SelectionStart = 0;
            txtDobraTricipital.ShortcutsEnabled = true;
            txtDobraTricipital.Size = new Size(250, 48);
            txtDobraTricipital.TabIndex = 4;
            txtDobraTricipital.TabStop = false;
            txtDobraTricipital.TextAlign = HorizontalAlignment.Left;
            txtDobraTricipital.TrailingIcon = null;
            txtDobraTricipital.UseSystemPasswordChar = false;
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
            btnFechar.Location = new Point(330, 380);
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
            // VisualizarDobrasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 440);
            Controls.Add(btnFechar);
            Controls.Add(groupBoxDados);
            Controls.Add(lblTitulo);
            MaximizeBox = false;
            Name = "VisualizarDobrasForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Consulta de Dobras Cutâneas";
            groupBoxDados.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void ConfigurarCampo(ReaLTaiizor.Controls.MaterialTextBoxEdit txt, string hint, int x, int y)
        {
            txt.Depth = 0;
            txt.Hint = hint;
            txt.Location = new System.Drawing.Point(x, y);
            txt.MaxLength = 32767;
            txt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txt.Name = "txt" + hint.Replace(" ", "");
            txt.ReadOnly = true;
            txt.Size = new System.Drawing.Size(180, 48);
            txt.UseSystemPasswordChar = false;
        }

        private ReaLTaiizor.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxDados;
        private ReaLTaiizor.Controls.MaterialButton btnFechar;

        // Apenas as 5 dobras existentes
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDobraTricipital;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDobraSubescapular;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDobraSuprailiaca;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDobraAbdominal;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDobraCoxa;
    }
}