namespace NutriManager.App.Register
{
    partial class AlimentoForm
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
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPorcao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCalorias = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCarboidratos = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtProteinas = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtGorduras = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Location = new Point(3, 36);
            tabControlRegister.Size = new Size(860, 374);
            // 
            // tabPageList
            // 
            tabPageList.Size = new Size(852, 346);
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtGorduras);
            tabPageRegister.Controls.Add(txtProteinas);
            tabPageRegister.Controls.Add(txtCarboidratos);
            tabPageRegister.Controls.Add(txtCalorias);
            tabPageRegister.Controls.Add(txtPorcao);
            tabPageRegister.Controls.Add(txtNome);
            tabPageRegister.Controls.Add(txtId);
            tabPageRegister.Size = new Size(852, 346);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            tabPageRegister.Controls.SetChildIndex(txtNome, 0);
            tabPageRegister.Controls.SetChildIndex(txtPorcao, 0);
            tabPageRegister.Controls.SetChildIndex(txtCalorias, 0);
            tabPageRegister.Controls.SetChildIndex(txtCarboidratos, 0);
            tabPageRegister.Controls.SetChildIndex(txtProteinas, 0);
            tabPageRegister.Controls.SetChildIndex(txtGorduras, 0);
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(709, 51);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(136, 48);
            txtId.TabIndex = 11;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome do Alimento";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(18, 51);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(685, 48);
            txtNome.TabIndex = 10;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
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
            txtPorcao.Hint = "Porção (ex: 100g)";
            txtPorcao.LeadingIcon = null;
            txtPorcao.Location = new Point(18, 103);
            txtPorcao.Margin = new Padding(3, 2, 3, 2);
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
            txtPorcao.Size = new Size(827, 48);
            txtPorcao.TabIndex = 9;
            txtPorcao.TabStop = false;
            txtPorcao.TextAlign = HorizontalAlignment.Left;
            txtPorcao.TrailingIcon = null;
            txtPorcao.UseSystemPasswordChar = false;
            // 
            // txtCalorias
            // 
            txtCalorias.AnimateReadOnly = false;
            txtCalorias.AutoCompleteMode = AutoCompleteMode.None;
            txtCalorias.AutoCompleteSource = AutoCompleteSource.None;
            txtCalorias.BackgroundImageLayout = ImageLayout.None;
            txtCalorias.CharacterCasing = CharacterCasing.Normal;
            txtCalorias.Depth = 0;
            txtCalorias.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCalorias.HideSelection = true;
            txtCalorias.Hint = "Calorias (Kcal)";
            txtCalorias.LeadingIcon = null;
            txtCalorias.Location = new Point(18, 207);
            txtCalorias.Margin = new Padding(3, 2, 3, 2);
            txtCalorias.MaxLength = 32767;
            txtCalorias.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCalorias.Name = "txtCalorias";
            txtCalorias.PasswordChar = '\0';
            txtCalorias.PrefixSuffixText = null;
            txtCalorias.ReadOnly = false;
            txtCalorias.RightToLeft = RightToLeft.No;
            txtCalorias.SelectedText = "";
            txtCalorias.SelectionLength = 0;
            txtCalorias.SelectionStart = 0;
            txtCalorias.ShortcutsEnabled = true;
            txtCalorias.Size = new Size(406, 48);
            txtCalorias.TabIndex = 8;
            txtCalorias.TabStop = false;
            txtCalorias.TextAlign = HorizontalAlignment.Left;
            txtCalorias.TrailingIcon = null;
            txtCalorias.UseSystemPasswordChar = false;
            // 
            // txtCarboidratos
            // 
            txtCarboidratos.AnimateReadOnly = false;
            txtCarboidratos.AutoCompleteMode = AutoCompleteMode.None;
            txtCarboidratos.AutoCompleteSource = AutoCompleteSource.None;
            txtCarboidratos.BackgroundImageLayout = ImageLayout.None;
            txtCarboidratos.CharacterCasing = CharacterCasing.Normal;
            txtCarboidratos.Depth = 0;
            txtCarboidratos.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCarboidratos.HideSelection = true;
            txtCarboidratos.Hint = "Carboidratos (g)";
            txtCarboidratos.LeadingIcon = null;
            txtCarboidratos.Location = new Point(430, 155);
            txtCarboidratos.Margin = new Padding(3, 2, 3, 2);
            txtCarboidratos.MaxLength = 32767;
            txtCarboidratos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCarboidratos.Name = "txtCarboidratos";
            txtCarboidratos.PasswordChar = '\0';
            txtCarboidratos.PrefixSuffixText = null;
            txtCarboidratos.ReadOnly = false;
            txtCarboidratos.RightToLeft = RightToLeft.No;
            txtCarboidratos.SelectedText = "";
            txtCarboidratos.SelectionLength = 0;
            txtCarboidratos.SelectionStart = 0;
            txtCarboidratos.ShortcutsEnabled = true;
            txtCarboidratos.Size = new Size(415, 48);
            txtCarboidratos.TabIndex = 7;
            txtCarboidratos.TabStop = false;
            txtCarboidratos.TextAlign = HorizontalAlignment.Left;
            txtCarboidratos.TrailingIcon = null;
            txtCarboidratos.UseSystemPasswordChar = false;
            // 
            // txtProteinas
            // 
            txtProteinas.AnimateReadOnly = false;
            txtProteinas.AutoCompleteMode = AutoCompleteMode.None;
            txtProteinas.AutoCompleteSource = AutoCompleteSource.None;
            txtProteinas.BackgroundImageLayout = ImageLayout.None;
            txtProteinas.CharacterCasing = CharacterCasing.Normal;
            txtProteinas.Depth = 0;
            txtProteinas.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtProteinas.HideSelection = true;
            txtProteinas.Hint = "Proteínas (g)";
            txtProteinas.LeadingIcon = null;
            txtProteinas.Location = new Point(18, 155);
            txtProteinas.Margin = new Padding(3, 2, 3, 2);
            txtProteinas.MaxLength = 32767;
            txtProteinas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtProteinas.Name = "txtProteinas";
            txtProteinas.PasswordChar = '\0';
            txtProteinas.PrefixSuffixText = null;
            txtProteinas.ReadOnly = false;
            txtProteinas.RightToLeft = RightToLeft.No;
            txtProteinas.SelectedText = "";
            txtProteinas.SelectionLength = 0;
            txtProteinas.SelectionStart = 0;
            txtProteinas.ShortcutsEnabled = true;
            txtProteinas.Size = new Size(406, 48);
            txtProteinas.TabIndex = 6;
            txtProteinas.TabStop = false;
            txtProteinas.TextAlign = HorizontalAlignment.Left;
            txtProteinas.TrailingIcon = null;
            txtProteinas.UseSystemPasswordChar = false;
            txtProteinas.Click += txtProteinas_Click;
            // 
            // txtGorduras
            // 
            txtGorduras.AnimateReadOnly = false;
            txtGorduras.AutoCompleteMode = AutoCompleteMode.None;
            txtGorduras.AutoCompleteSource = AutoCompleteSource.None;
            txtGorduras.BackgroundImageLayout = ImageLayout.None;
            txtGorduras.CharacterCasing = CharacterCasing.Normal;
            txtGorduras.Depth = 0;
            txtGorduras.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGorduras.HideSelection = true;
            txtGorduras.Hint = "Gorduras (g)";
            txtGorduras.LeadingIcon = null;
            txtGorduras.Location = new Point(430, 207);
            txtGorduras.Margin = new Padding(3, 2, 3, 2);
            txtGorduras.MaxLength = 32767;
            txtGorduras.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtGorduras.Name = "txtGorduras";
            txtGorduras.PasswordChar = '\0';
            txtGorduras.PrefixSuffixText = null;
            txtGorduras.ReadOnly = false;
            txtGorduras.RightToLeft = RightToLeft.No;
            txtGorduras.SelectedText = "";
            txtGorduras.SelectionLength = 0;
            txtGorduras.SelectionStart = 0;
            txtGorduras.ShortcutsEnabled = true;
            txtGorduras.Size = new Size(415, 48);
            txtGorduras.TabIndex = 5;
            txtGorduras.TabStop = false;
            txtGorduras.TextAlign = HorizontalAlignment.Left;
            txtGorduras.TrailingIcon = null;
            txtGorduras.UseSystemPasswordChar = false;
            // 
            // AlimentoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 412);
            Location = new Point(0, 0);
            MaximizeBox = false;
            Name = "AlimentoForm";
            Padding = new Padding(3, 36, 3, 2);
            Text = "Cadastro de Alimentos";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPorcao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCalorias;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCarboidratos;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtProteinas;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtGorduras;
    }
}