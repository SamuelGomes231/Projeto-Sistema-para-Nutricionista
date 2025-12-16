namespace NutriManager.App.Register
{
    partial class ConsultaForm
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
            tabConsultaInterna = new ReaLTaiizor.Controls.MaterialTabControl();
            tabGeral = new TabPage();
            txtObsGerais = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtObservacoes = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtObjetivo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboPlano = new ReaLTaiizor.Controls.MaterialComboBox();
            cboPaciente = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDataConsulta = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tabMedidas = new TabPage();
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
            tabBio = new TabPage();
            txtTaxaMetabolica = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMassaMagra = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMassaGorda = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAgua = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPercMassaMagra = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPercGordura = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabDobras = new TabPage();
            txtDobraCoxa = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDobraSuprailiaca = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDobraSubescapular = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDobraAbdominal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDobraTricipital = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            selectorInterno = new ReaLTaiizor.Controls.MaterialTabSelector();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            tabConsultaInterna.SuspendLayout();
            tabGeral.SuspendLayout();
            tabMedidas.SuspendLayout();
            tabBio.SuspendLayout();
            tabDobras.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Dock = DockStyle.None;
            tabControlRegister.Location = new Point(-8, 62);
            tabControlRegister.Margin = new Padding(5, 65, 3, 2);
            tabControlRegister.Size = new Size(792, 492);
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(tabConsultaInterna);
            tabPageRegister.Controls.Add(selectorInterno);
            tabPageRegister.Controls.Add(txtId);
            tabPageRegister.Size = new Size(784, 464);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            tabPageRegister.Controls.SetChildIndex(selectorInterno, 0);
            tabPageRegister.Controls.SetChildIndex(tabConsultaInterna, 0);
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
            txtId.LeadingIcon = null;
            txtId.Location = new Point(3, 4);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(219, 48);
            txtId.TabIndex = 11;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            txtId.Visible = false;
            // 
            // tabConsultaInterna
            // 
            tabConsultaInterna.Controls.Add(tabGeral);
            tabConsultaInterna.Controls.Add(tabMedidas);
            tabConsultaInterna.Controls.Add(tabBio);
            tabConsultaInterna.Controls.Add(tabDobras);
            tabConsultaInterna.Depth = 0;
            tabConsultaInterna.Location = new Point(3, 38);
            tabConsultaInterna.Margin = new Padding(3, 2, 3, 2);
            tabConsultaInterna.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabConsultaInterna.Multiline = true;
            tabConsultaInterna.Name = "tabConsultaInterna";
            tabConsultaInterna.SelectedIndex = 0;
            tabConsultaInterna.Size = new Size(776, 368);
            tabConsultaInterna.TabIndex = 3;
            // 
            // tabGeral
            // 
            tabGeral.Controls.Add(txtObsGerais);
            tabGeral.Controls.Add(txtObservacoes);
            tabGeral.Controls.Add(txtObjetivo);
            tabGeral.Controls.Add(cboPlano);
            tabGeral.Controls.Add(cboPaciente);
            tabGeral.Controls.Add(txtDataConsulta);
            tabGeral.Location = new Point(4, 24);
            tabGeral.Margin = new Padding(3, 2, 3, 2);
            tabGeral.Name = "tabGeral";
            tabGeral.Size = new Size(768, 340);
            tabGeral.TabIndex = 0;
            tabGeral.Text = "Dados Gerais";
            // 
            // txtObsGerais
            // 
            txtObsGerais.AnimateReadOnly = false;
            txtObsGerais.AutoCompleteMode = AutoCompleteMode.None;
            txtObsGerais.AutoCompleteSource = AutoCompleteSource.None;
            txtObsGerais.BackgroundImageLayout = ImageLayout.None;
            txtObsGerais.CharacterCasing = CharacterCasing.Normal;
            txtObsGerais.Depth = 0;
            txtObsGerais.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtObsGerais.HideSelection = true;
            txtObsGerais.Hint = "Obs. Gerais";
            txtObsGerais.LeadingIcon = null;
            txtObsGerais.Location = new Point(18, 267);
            txtObsGerais.Margin = new Padding(3, 2, 3, 2);
            txtObsGerais.MaxLength = 32767;
            txtObsGerais.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtObsGerais.Name = "txtObsGerais";
            txtObsGerais.PasswordChar = '\0';
            txtObsGerais.PrefixSuffixText = null;
            txtObsGerais.ReadOnly = false;
            txtObsGerais.RightToLeft = RightToLeft.No;
            txtObsGerais.SelectedText = "";
            txtObsGerais.SelectionLength = 0;
            txtObsGerais.SelectionStart = 0;
            txtObsGerais.ShortcutsEnabled = true;
            txtObsGerais.Size = new Size(743, 48);
            txtObsGerais.TabIndex = 0;
            txtObsGerais.TabStop = false;
            txtObsGerais.TextAlign = HorizontalAlignment.Left;
            txtObsGerais.TrailingIcon = null;
            txtObsGerais.UseSystemPasswordChar = false;
            // 
            // txtObservacoes
            // 
            txtObservacoes.AnimateReadOnly = false;
            txtObservacoes.AutoCompleteMode = AutoCompleteMode.None;
            txtObservacoes.AutoCompleteSource = AutoCompleteSource.None;
            txtObservacoes.BackgroundImageLayout = ImageLayout.None;
            txtObservacoes.CharacterCasing = CharacterCasing.Normal;
            txtObservacoes.Depth = 0;
            txtObservacoes.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtObservacoes.HideSelection = true;
            txtObservacoes.Hint = "Obs. Consulta";
            txtObservacoes.LeadingIcon = null;
            txtObservacoes.Location = new Point(18, 204);
            txtObservacoes.Margin = new Padding(3, 2, 3, 2);
            txtObservacoes.MaxLength = 32767;
            txtObservacoes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.PasswordChar = '\0';
            txtObservacoes.PrefixSuffixText = null;
            txtObservacoes.ReadOnly = false;
            txtObservacoes.RightToLeft = RightToLeft.No;
            txtObservacoes.SelectedText = "";
            txtObservacoes.SelectionLength = 0;
            txtObservacoes.SelectionStart = 0;
            txtObservacoes.ShortcutsEnabled = true;
            txtObservacoes.Size = new Size(743, 48);
            txtObservacoes.TabIndex = 1;
            txtObservacoes.TabStop = false;
            txtObservacoes.TextAlign = HorizontalAlignment.Left;
            txtObservacoes.TrailingIcon = null;
            txtObservacoes.UseSystemPasswordChar = false;
            // 
            // txtObjetivo
            // 
            txtObjetivo.AnimateReadOnly = false;
            txtObjetivo.AutoCompleteMode = AutoCompleteMode.None;
            txtObjetivo.AutoCompleteSource = AutoCompleteSource.None;
            txtObjetivo.BackgroundImageLayout = ImageLayout.None;
            txtObjetivo.CharacterCasing = CharacterCasing.Normal;
            txtObjetivo.Depth = 0;
            txtObjetivo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtObjetivo.HideSelection = true;
            txtObjetivo.Hint = "Objetivo";
            txtObjetivo.LeadingIcon = null;
            txtObjetivo.Location = new Point(18, 72);
            txtObjetivo.Margin = new Padding(3, 2, 3, 2);
            txtObjetivo.MaxLength = 32767;
            txtObjetivo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtObjetivo.Name = "txtObjetivo";
            txtObjetivo.PasswordChar = '\0';
            txtObjetivo.PrefixSuffixText = null;
            txtObjetivo.ReadOnly = false;
            txtObjetivo.RightToLeft = RightToLeft.No;
            txtObjetivo.SelectedText = "";
            txtObjetivo.SelectionLength = 0;
            txtObjetivo.SelectionStart = 0;
            txtObjetivo.ShortcutsEnabled = true;
            txtObjetivo.Size = new Size(743, 48);
            txtObjetivo.TabIndex = 2;
            txtObjetivo.TabStop = false;
            txtObjetivo.TextAlign = HorizontalAlignment.Left;
            txtObjetivo.TrailingIcon = null;
            txtObjetivo.UseSystemPasswordChar = false;
            // 
            // cboPlano
            // 
            cboPlano.AutoResize = false;
            cboPlano.BackColor = Color.FromArgb(255, 255, 255);
            cboPlano.Depth = 0;
            cboPlano.DrawMode = DrawMode.OwnerDrawVariable;
            cboPlano.DropDownHeight = 174;
            cboPlano.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlano.DropDownWidth = 121;
            cboPlano.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPlano.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPlano.Hint = "Plano Alimentar";
            cboPlano.IntegralHeight = false;
            cboPlano.ItemHeight = 43;
            cboPlano.Location = new Point(18, 141);
            cboPlano.Margin = new Padding(3, 2, 3, 2);
            cboPlano.MaxDropDownItems = 4;
            cboPlano.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPlano.Name = "cboPlano";
            cboPlano.Size = new Size(743, 49);
            cboPlano.StartIndex = 0;
            cboPlano.TabIndex = 3;
            // 
            // cboPaciente
            // 
            cboPaciente.AutoResize = false;
            cboPaciente.BackColor = Color.FromArgb(255, 255, 255);
            cboPaciente.Depth = 0;
            cboPaciente.DrawMode = DrawMode.OwnerDrawVariable;
            cboPaciente.DropDownHeight = 174;
            cboPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaciente.DropDownWidth = 121;
            cboPaciente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPaciente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPaciente.Hint = "Paciente";
            cboPaciente.IntegralHeight = false;
            cboPaciente.ItemHeight = 43;
            cboPaciente.Location = new Point(210, 7);
            cboPaciente.Margin = new Padding(3, 2, 3, 2);
            cboPaciente.MaxDropDownItems = 4;
            cboPaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(551, 49);
            cboPaciente.StartIndex = 0;
            cboPaciente.TabIndex = 4;
            // 
            // txtDataConsulta
            // 
            txtDataConsulta.AllowPromptAsInput = true;
            txtDataConsulta.AnimateReadOnly = false;
            txtDataConsulta.AsciiOnly = false;
            txtDataConsulta.BackgroundImageLayout = ImageLayout.None;
            txtDataConsulta.BeepOnError = false;
            txtDataConsulta.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataConsulta.Depth = 0;
            txtDataConsulta.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataConsulta.HidePromptOnLeave = false;
            txtDataConsulta.HideSelection = true;
            txtDataConsulta.Hint = "Data/Hora";
            txtDataConsulta.InsertKeyMode = InsertKeyMode.Default;
            txtDataConsulta.LeadingIcon = null;
            txtDataConsulta.Location = new Point(18, 8);
            txtDataConsulta.Margin = new Padding(3, 2, 3, 2);
            txtDataConsulta.Mask = "00/00/0000 90:00";
            txtDataConsulta.MaxLength = 32767;
            txtDataConsulta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataConsulta.Name = "txtDataConsulta";
            txtDataConsulta.PasswordChar = '\0';
            txtDataConsulta.PrefixSuffixText = null;
            txtDataConsulta.PromptChar = '_';
            txtDataConsulta.ReadOnly = false;
            txtDataConsulta.RejectInputOnFirstFailure = false;
            txtDataConsulta.ResetOnPrompt = true;
            txtDataConsulta.ResetOnSpace = true;
            txtDataConsulta.RightToLeft = RightToLeft.No;
            txtDataConsulta.SelectedText = "";
            txtDataConsulta.SelectionLength = 0;
            txtDataConsulta.SelectionStart = 0;
            txtDataConsulta.ShortcutsEnabled = true;
            txtDataConsulta.Size = new Size(175, 48);
            txtDataConsulta.SkipLiterals = true;
            txtDataConsulta.TabIndex = 5;
            txtDataConsulta.TabStop = false;
            txtDataConsulta.Text = "  /  /       :";
            txtDataConsulta.TextAlign = HorizontalAlignment.Left;
            txtDataConsulta.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataConsulta.TrailingIcon = null;
            txtDataConsulta.UseSystemPasswordChar = false;
            txtDataConsulta.ValidatingType = null;
            // 
            // tabMedidas
            // 
            tabMedidas.Controls.Add(txtPanturrilhaE);
            tabMedidas.Controls.Add(txtPanturrilhaD);
            tabMedidas.Controls.Add(txtCoxaE);
            tabMedidas.Controls.Add(txtCoxaD);
            tabMedidas.Controls.Add(txtBracoE);
            tabMedidas.Controls.Add(txtBracoD);
            tabMedidas.Controls.Add(txtQuadril);
            tabMedidas.Controls.Add(txtCintura);
            tabMedidas.Controls.Add(txtAltura);
            tabMedidas.Controls.Add(txtPeso);
            tabMedidas.Location = new Point(4, 24);
            tabMedidas.Margin = new Padding(3, 2, 3, 2);
            tabMedidas.Name = "tabMedidas";
            tabMedidas.Size = new Size(768, 340);
            tabMedidas.TabIndex = 1;
            tabMedidas.Text = "Medidas";
            // 
            // txtPanturrilhaE
            // 
            txtPanturrilhaE.AnimateReadOnly = false;
            txtPanturrilhaE.AutoCompleteMode = AutoCompleteMode.None;
            txtPanturrilhaE.AutoCompleteSource = AutoCompleteSource.None;
            txtPanturrilhaE.BackgroundImageLayout = ImageLayout.None;
            txtPanturrilhaE.CharacterCasing = CharacterCasing.Normal;
            txtPanturrilhaE.Depth = 0;
            txtPanturrilhaE.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPanturrilhaE.HideSelection = true;
            txtPanturrilhaE.Hint = "Panturrilha Esq.";
            txtPanturrilhaE.LeadingIcon = null;
            txtPanturrilhaE.Location = new Point(394, 269);
            txtPanturrilhaE.Margin = new Padding(3, 2, 3, 2);
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
            txtPanturrilhaE.Size = new Size(370, 48);
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
            txtPanturrilhaD.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPanturrilhaD.HideSelection = true;
            txtPanturrilhaD.Hint = "Panturrilha Dir.";
            txtPanturrilhaD.LeadingIcon = null;
            txtPanturrilhaD.Location = new Point(13, 269);
            txtPanturrilhaD.Margin = new Padding(3, 2, 3, 2);
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
            txtPanturrilhaD.Size = new Size(375, 48);
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
            txtCoxaE.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCoxaE.HideSelection = true;
            txtCoxaE.Hint = "Coxa Esq. (cm)";
            txtCoxaE.LeadingIcon = null;
            txtCoxaE.Location = new Point(394, 208);
            txtCoxaE.Margin = new Padding(3, 2, 3, 2);
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
            txtCoxaE.Size = new Size(370, 48);
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
            txtCoxaD.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCoxaD.HideSelection = true;
            txtCoxaD.Hint = "Coxa Dir. (cm)";
            txtCoxaD.LeadingIcon = null;
            txtCoxaD.Location = new Point(13, 208);
            txtCoxaD.Margin = new Padding(3, 2, 3, 2);
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
            txtCoxaD.Size = new Size(375, 48);
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
            txtBracoE.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBracoE.HideSelection = true;
            txtBracoE.Hint = "Braço Esq. (cm)";
            txtBracoE.LeadingIcon = null;
            txtBracoE.Location = new Point(394, 147);
            txtBracoE.Margin = new Padding(3, 2, 3, 2);
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
            txtBracoE.Size = new Size(370, 48);
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
            txtBracoD.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBracoD.HideSelection = true;
            txtBracoD.Hint = "Braço Dir. (cm)";
            txtBracoD.LeadingIcon = null;
            txtBracoD.Location = new Point(13, 147);
            txtBracoD.Margin = new Padding(3, 2, 3, 2);
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
            txtBracoD.Size = new Size(375, 48);
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
            txtQuadril.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuadril.HideSelection = true;
            txtQuadril.Hint = "Quadril (cm)";
            txtQuadril.LeadingIcon = null;
            txtQuadril.Location = new Point(394, 84);
            txtQuadril.Margin = new Padding(3, 2, 3, 2);
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
            txtQuadril.Size = new Size(370, 48);
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
            txtCintura.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCintura.HideSelection = true;
            txtCintura.Hint = "Cintura (cm)";
            txtCintura.LeadingIcon = null;
            txtCintura.Location = new Point(13, 84);
            txtCintura.Margin = new Padding(3, 2, 3, 2);
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
            txtCintura.Size = new Size(375, 48);
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
            txtAltura.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAltura.HideSelection = true;
            txtAltura.Hint = "Altura (m)";
            txtAltura.LeadingIcon = null;
            txtAltura.Location = new Point(394, 17);
            txtAltura.Margin = new Padding(3, 2, 3, 2);
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
            txtAltura.Size = new Size(370, 48);
            txtAltura.TabIndex = 8;
            txtAltura.TabStop = false;
            txtAltura.TextAlign = HorizontalAlignment.Left;
            txtAltura.TrailingIcon = null;
            txtAltura.UseSystemPasswordChar = false;
            txtAltura.Click += txtAltura_Click;
            // 
            // txtPeso
            // 
            txtPeso.AnimateReadOnly = false;
            txtPeso.AutoCompleteMode = AutoCompleteMode.None;
            txtPeso.AutoCompleteSource = AutoCompleteSource.None;
            txtPeso.BackgroundImageLayout = ImageLayout.None;
            txtPeso.CharacterCasing = CharacterCasing.Normal;
            txtPeso.Depth = 0;
            txtPeso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPeso.HideSelection = true;
            txtPeso.Hint = "Peso (kg)";
            txtPeso.LeadingIcon = null;
            txtPeso.Location = new Point(13, 17);
            txtPeso.Margin = new Padding(3, 2, 3, 2);
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
            txtPeso.Size = new Size(375, 48);
            txtPeso.TabIndex = 9;
            txtPeso.TabStop = false;
            txtPeso.TextAlign = HorizontalAlignment.Left;
            txtPeso.TrailingIcon = null;
            txtPeso.UseSystemPasswordChar = false;
            // 
            // tabBio
            // 
            tabBio.Controls.Add(txtTaxaMetabolica);
            tabBio.Controls.Add(txtMassaMagra);
            tabBio.Controls.Add(txtMassaGorda);
            tabBio.Controls.Add(txtAgua);
            tabBio.Controls.Add(txtPercMassaMagra);
            tabBio.Controls.Add(txtPercGordura);
            tabBio.Location = new Point(4, 24);
            tabBio.Margin = new Padding(3, 2, 3, 2);
            tabBio.Name = "tabBio";
            tabBio.Size = new Size(768, 340);
            tabBio.TabIndex = 2;
            tabBio.Text = "Bioimpedância";
            // 
            // txtTaxaMetabolica
            // 
            txtTaxaMetabolica.AnimateReadOnly = false;
            txtTaxaMetabolica.AutoCompleteMode = AutoCompleteMode.None;
            txtTaxaMetabolica.AutoCompleteSource = AutoCompleteSource.None;
            txtTaxaMetabolica.BackgroundImageLayout = ImageLayout.None;
            txtTaxaMetabolica.CharacterCasing = CharacterCasing.Normal;
            txtTaxaMetabolica.Depth = 0;
            txtTaxaMetabolica.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTaxaMetabolica.HideSelection = true;
            txtTaxaMetabolica.Hint = "Taxa Metab. Basal";
            txtTaxaMetabolica.LeadingIcon = null;
            txtTaxaMetabolica.Location = new Point(389, 116);
            txtTaxaMetabolica.Margin = new Padding(3, 2, 3, 2);
            txtTaxaMetabolica.MaxLength = 32767;
            txtTaxaMetabolica.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTaxaMetabolica.Name = "txtTaxaMetabolica";
            txtTaxaMetabolica.PasswordChar = '\0';
            txtTaxaMetabolica.PrefixSuffixText = null;
            txtTaxaMetabolica.ReadOnly = false;
            txtTaxaMetabolica.RightToLeft = RightToLeft.No;
            txtTaxaMetabolica.SelectedText = "";
            txtTaxaMetabolica.SelectionLength = 0;
            txtTaxaMetabolica.SelectionStart = 0;
            txtTaxaMetabolica.ShortcutsEnabled = true;
            txtTaxaMetabolica.Size = new Size(375, 48);
            txtTaxaMetabolica.TabIndex = 0;
            txtTaxaMetabolica.TabStop = false;
            txtTaxaMetabolica.TextAlign = HorizontalAlignment.Left;
            txtTaxaMetabolica.TrailingIcon = null;
            txtTaxaMetabolica.UseSystemPasswordChar = false;
            // 
            // txtMassaMagra
            // 
            txtMassaMagra.AnimateReadOnly = false;
            txtMassaMagra.AutoCompleteMode = AutoCompleteMode.None;
            txtMassaMagra.AutoCompleteSource = AutoCompleteSource.None;
            txtMassaMagra.BackgroundImageLayout = ImageLayout.None;
            txtMassaMagra.CharacterCasing = CharacterCasing.Normal;
            txtMassaMagra.Depth = 0;
            txtMassaMagra.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMassaMagra.HideSelection = true;
            txtMassaMagra.Hint = "Massa Magra (kg)";
            txtMassaMagra.LeadingIcon = null;
            txtMassaMagra.Location = new Point(389, 64);
            txtMassaMagra.Margin = new Padding(3, 2, 3, 2);
            txtMassaMagra.MaxLength = 32767;
            txtMassaMagra.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMassaMagra.Name = "txtMassaMagra";
            txtMassaMagra.PasswordChar = '\0';
            txtMassaMagra.PrefixSuffixText = null;
            txtMassaMagra.ReadOnly = false;
            txtMassaMagra.RightToLeft = RightToLeft.No;
            txtMassaMagra.SelectedText = "";
            txtMassaMagra.SelectionLength = 0;
            txtMassaMagra.SelectionStart = 0;
            txtMassaMagra.ShortcutsEnabled = true;
            txtMassaMagra.Size = new Size(375, 48);
            txtMassaMagra.TabIndex = 1;
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
            txtMassaGorda.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMassaGorda.HideSelection = true;
            txtMassaGorda.Hint = "Massa Gorda (kg)";
            txtMassaGorda.LeadingIcon = null;
            txtMassaGorda.Location = new Point(7, 64);
            txtMassaGorda.Margin = new Padding(3, 2, 3, 2);
            txtMassaGorda.MaxLength = 32767;
            txtMassaGorda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMassaGorda.Name = "txtMassaGorda";
            txtMassaGorda.PasswordChar = '\0';
            txtMassaGorda.PrefixSuffixText = null;
            txtMassaGorda.ReadOnly = false;
            txtMassaGorda.RightToLeft = RightToLeft.No;
            txtMassaGorda.SelectedText = "";
            txtMassaGorda.SelectionLength = 0;
            txtMassaGorda.SelectionStart = 0;
            txtMassaGorda.ShortcutsEnabled = true;
            txtMassaGorda.Size = new Size(376, 48);
            txtMassaGorda.TabIndex = 2;
            txtMassaGorda.TabStop = false;
            txtMassaGorda.TextAlign = HorizontalAlignment.Left;
            txtMassaGorda.TrailingIcon = null;
            txtMassaGorda.UseSystemPasswordChar = false;
            // 
            // txtAgua
            // 
            txtAgua.AnimateReadOnly = false;
            txtAgua.AutoCompleteMode = AutoCompleteMode.None;
            txtAgua.AutoCompleteSource = AutoCompleteSource.None;
            txtAgua.BackgroundImageLayout = ImageLayout.None;
            txtAgua.CharacterCasing = CharacterCasing.Normal;
            txtAgua.Depth = 0;
            txtAgua.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAgua.HideSelection = true;
            txtAgua.Hint = "% Água Corporal";
            txtAgua.LeadingIcon = null;
            txtAgua.Location = new Point(8, 116);
            txtAgua.Margin = new Padding(3, 2, 3, 2);
            txtAgua.MaxLength = 32767;
            txtAgua.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAgua.Name = "txtAgua";
            txtAgua.PasswordChar = '\0';
            txtAgua.PrefixSuffixText = null;
            txtAgua.ReadOnly = false;
            txtAgua.RightToLeft = RightToLeft.No;
            txtAgua.SelectedText = "";
            txtAgua.SelectionLength = 0;
            txtAgua.SelectionStart = 0;
            txtAgua.ShortcutsEnabled = true;
            txtAgua.Size = new Size(375, 48);
            txtAgua.TabIndex = 3;
            txtAgua.TabStop = false;
            txtAgua.TextAlign = HorizontalAlignment.Left;
            txtAgua.TrailingIcon = null;
            txtAgua.UseSystemPasswordChar = false;
            // 
            // txtPercMassaMagra
            // 
            txtPercMassaMagra.AnimateReadOnly = false;
            txtPercMassaMagra.AutoCompleteMode = AutoCompleteMode.None;
            txtPercMassaMagra.AutoCompleteSource = AutoCompleteSource.None;
            txtPercMassaMagra.BackgroundImageLayout = ImageLayout.None;
            txtPercMassaMagra.CharacterCasing = CharacterCasing.Normal;
            txtPercMassaMagra.Depth = 0;
            txtPercMassaMagra.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPercMassaMagra.HideSelection = true;
            txtPercMassaMagra.Hint = "% Massa Magra";
            txtPercMassaMagra.LeadingIcon = null;
            txtPercMassaMagra.Location = new Point(389, 12);
            txtPercMassaMagra.Margin = new Padding(3, 2, 3, 2);
            txtPercMassaMagra.MaxLength = 32767;
            txtPercMassaMagra.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPercMassaMagra.Name = "txtPercMassaMagra";
            txtPercMassaMagra.PasswordChar = '\0';
            txtPercMassaMagra.PrefixSuffixText = null;
            txtPercMassaMagra.ReadOnly = false;
            txtPercMassaMagra.RightToLeft = RightToLeft.No;
            txtPercMassaMagra.SelectedText = "";
            txtPercMassaMagra.SelectionLength = 0;
            txtPercMassaMagra.SelectionStart = 0;
            txtPercMassaMagra.ShortcutsEnabled = true;
            txtPercMassaMagra.Size = new Size(375, 48);
            txtPercMassaMagra.TabIndex = 4;
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
            txtPercGordura.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPercGordura.HideSelection = true;
            txtPercGordura.Hint = "% Gordura";
            txtPercGordura.LeadingIcon = null;
            txtPercGordura.Location = new Point(8, 12);
            txtPercGordura.Margin = new Padding(3, 2, 3, 2);
            txtPercGordura.MaxLength = 32767;
            txtPercGordura.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPercGordura.Name = "txtPercGordura";
            txtPercGordura.PasswordChar = '\0';
            txtPercGordura.PrefixSuffixText = null;
            txtPercGordura.ReadOnly = false;
            txtPercGordura.RightToLeft = RightToLeft.No;
            txtPercGordura.SelectedText = "";
            txtPercGordura.SelectionLength = 0;
            txtPercGordura.SelectionStart = 0;
            txtPercGordura.ShortcutsEnabled = true;
            txtPercGordura.Size = new Size(375, 48);
            txtPercGordura.TabIndex = 5;
            txtPercGordura.TabStop = false;
            txtPercGordura.TextAlign = HorizontalAlignment.Left;
            txtPercGordura.TrailingIcon = null;
            txtPercGordura.UseSystemPasswordChar = false;
            // 
            // tabDobras
            // 
            tabDobras.Controls.Add(txtDobraCoxa);
            tabDobras.Controls.Add(txtDobraSuprailiaca);
            tabDobras.Controls.Add(txtDobraSubescapular);
            tabDobras.Controls.Add(txtDobraAbdominal);
            tabDobras.Controls.Add(txtDobraTricipital);
            tabDobras.Location = new Point(4, 24);
            tabDobras.Margin = new Padding(3, 2, 3, 2);
            tabDobras.Name = "tabDobras";
            tabDobras.Size = new Size(768, 340);
            tabDobras.TabIndex = 3;
            tabDobras.Text = "Dobras Cutâneas";
            // 
            // txtDobraCoxa
            // 
            txtDobraCoxa.AnimateReadOnly = false;
            txtDobraCoxa.AutoCompleteMode = AutoCompleteMode.None;
            txtDobraCoxa.AutoCompleteSource = AutoCompleteSource.None;
            txtDobraCoxa.BackgroundImageLayout = ImageLayout.None;
            txtDobraCoxa.CharacterCasing = CharacterCasing.Normal;
            txtDobraCoxa.Depth = 0;
            txtDobraCoxa.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDobraCoxa.HideSelection = true;
            txtDobraCoxa.Hint = "Coxa (mm)";
            txtDobraCoxa.LeadingIcon = null;
            txtDobraCoxa.Location = new Point(9, 117);
            txtDobraCoxa.Margin = new Padding(3, 2, 3, 2);
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
            txtDobraCoxa.Size = new Size(756, 48);
            txtDobraCoxa.TabIndex = 0;
            txtDobraCoxa.TabStop = false;
            txtDobraCoxa.TextAlign = HorizontalAlignment.Left;
            txtDobraCoxa.TrailingIcon = null;
            txtDobraCoxa.UseSystemPasswordChar = false;
            // 
            // txtDobraSuprailiaca
            // 
            txtDobraSuprailiaca.AnimateReadOnly = false;
            txtDobraSuprailiaca.AutoCompleteMode = AutoCompleteMode.None;
            txtDobraSuprailiaca.AutoCompleteSource = AutoCompleteSource.None;
            txtDobraSuprailiaca.BackgroundImageLayout = ImageLayout.None;
            txtDobraSuprailiaca.CharacterCasing = CharacterCasing.Normal;
            txtDobraSuprailiaca.Depth = 0;
            txtDobraSuprailiaca.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDobraSuprailiaca.HideSelection = true;
            txtDobraSuprailiaca.Hint = "Supra-ilíaca (mm)";
            txtDobraSuprailiaca.LeadingIcon = null;
            txtDobraSuprailiaca.Location = new Point(390, 65);
            txtDobraSuprailiaca.Margin = new Padding(3, 2, 3, 2);
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
            txtDobraSuprailiaca.Size = new Size(375, 48);
            txtDobraSuprailiaca.TabIndex = 1;
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
            txtDobraSubescapular.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDobraSubescapular.HideSelection = true;
            txtDobraSubescapular.Hint = "Subescapular (mm)";
            txtDobraSubescapular.LeadingIcon = null;
            txtDobraSubescapular.Location = new Point(9, 65);
            txtDobraSubescapular.Margin = new Padding(3, 2, 3, 2);
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
            txtDobraSubescapular.Size = new Size(375, 48);
            txtDobraSubescapular.TabIndex = 2;
            txtDobraSubescapular.TabStop = false;
            txtDobraSubescapular.TextAlign = HorizontalAlignment.Left;
            txtDobraSubescapular.TrailingIcon = null;
            txtDobraSubescapular.UseSystemPasswordChar = false;
            // 
            // txtDobraAbdominal
            // 
            txtDobraAbdominal.AnimateReadOnly = false;
            txtDobraAbdominal.AutoCompleteMode = AutoCompleteMode.None;
            txtDobraAbdominal.AutoCompleteSource = AutoCompleteSource.None;
            txtDobraAbdominal.BackgroundImageLayout = ImageLayout.None;
            txtDobraAbdominal.CharacterCasing = CharacterCasing.Normal;
            txtDobraAbdominal.Depth = 0;
            txtDobraAbdominal.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDobraAbdominal.HideSelection = true;
            txtDobraAbdominal.Hint = "Abdominal (mm)";
            txtDobraAbdominal.LeadingIcon = null;
            txtDobraAbdominal.Location = new Point(390, 13);
            txtDobraAbdominal.Margin = new Padding(3, 2, 3, 2);
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
            txtDobraAbdominal.Size = new Size(375, 48);
            txtDobraAbdominal.TabIndex = 3;
            txtDobraAbdominal.TabStop = false;
            txtDobraAbdominal.TextAlign = HorizontalAlignment.Left;
            txtDobraAbdominal.TrailingIcon = null;
            txtDobraAbdominal.UseSystemPasswordChar = false;
            // 
            // txtDobraTricipital
            // 
            txtDobraTricipital.AnimateReadOnly = false;
            txtDobraTricipital.AutoCompleteMode = AutoCompleteMode.None;
            txtDobraTricipital.AutoCompleteSource = AutoCompleteSource.None;
            txtDobraTricipital.BackgroundImageLayout = ImageLayout.None;
            txtDobraTricipital.CharacterCasing = CharacterCasing.Normal;
            txtDobraTricipital.Depth = 0;
            txtDobraTricipital.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDobraTricipital.HideSelection = true;
            txtDobraTricipital.Hint = "Tricipital (mm)";
            txtDobraTricipital.LeadingIcon = null;
            txtDobraTricipital.Location = new Point(9, 13);
            txtDobraTricipital.Margin = new Padding(3, 2, 3, 2);
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
            txtDobraTricipital.Size = new Size(375, 48);
            txtDobraTricipital.TabIndex = 4;
            txtDobraTricipital.TabStop = false;
            txtDobraTricipital.TextAlign = HorizontalAlignment.Left;
            txtDobraTricipital.TrailingIcon = null;
            txtDobraTricipital.UseSystemPasswordChar = false;
            // 
            // selectorInterno
            // 
            selectorInterno.BaseTabControl = tabConsultaInterna;
            selectorInterno.CharacterCasing = ReaLTaiizor.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            selectorInterno.Depth = 0;
            selectorInterno.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            selectorInterno.HeadAlignment = ReaLTaiizor.Controls.MaterialTabSelector.Alignment.Left;
            selectorInterno.Location = new Point(0, 0);
            selectorInterno.Margin = new Padding(3, 2, 3, 2);
            selectorInterno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            selectorInterno.Name = "selectorInterno";
            selectorInterno.Size = new Size(886, 30);
            selectorInterno.TabIndex = 10;
            // 
            // ConsultaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 557);
            Location = new Point(0, 0);
            MaximizeBox = false;
            Name = "ConsultaForm";
            Padding = new Padding(3, 36, 3, 2);
            Text = "Realizar Consulta";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            tabConsultaInterna.ResumeLayout(false);
            tabGeral.ResumeLayout(false);
            tabMedidas.ResumeLayout(false);
            tabBio.ResumeLayout(false);
            tabDobras.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // Controles atualizados
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTabControl tabConsultaInterna;
        private ReaLTaiizor.Controls.MaterialTabSelector selectorInterno;
        private System.Windows.Forms.TabPage tabGeral, tabMedidas, tabBio, tabDobras;

        // Geral
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataConsulta;
        private ReaLTaiizor.Controls.MaterialComboBox cboPaciente;
        private ReaLTaiizor.Controls.MaterialComboBox cboPlano;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtObjetivo, txtObservacoes, txtObsGerais;

        // Medidas
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPeso, txtAltura, txtCintura, txtQuadril;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBracoD, txtBracoE, txtCoxaD, txtCoxaE, txtPanturrilhaD, txtPanturrilhaE;

        // Bio
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPercGordura, txtPercMassaMagra, txtAgua, txtMassaGorda, txtMassaMagra;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTaxaMetabolica; // NOVO

        // Dobras
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDobraTricipital, txtDobraAbdominal, txtDobraSubescapular, txtDobraSuprailiaca, txtDobraCoxa;
    }
}