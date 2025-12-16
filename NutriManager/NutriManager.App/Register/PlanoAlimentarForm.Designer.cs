namespace NutriManager.App.Register
{
    partial class PlanoAlimentarForm
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
            txtId = new TextBox();
            cboPaciente = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblPaciente = new ReaLTaiizor.Controls.MaterialLabel();
            lblDataInicio = new ReaLTaiizor.Controls.MaterialLabel();
            dtpDataInicio = new DateTimePicker();
            lblDataFim = new ReaLTaiizor.Controls.MaterialLabel();
            dtpDataFim = new DateTimePicker();
            lblCalorias = new ReaLTaiizor.Controls.MaterialLabel();
            nudCalorias = new NumericUpDown();
            lblRefeicoesDia = new ReaLTaiizor.Controls.MaterialLabel();
            nudRefeicoesDia = new NumericUpDown();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCalorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRefeicoesDia).BeginInit();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(794, 450);
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtId);
            tabPageRegister.Controls.Add(nudRefeicoesDia);
            tabPageRegister.Controls.Add(lblRefeicoesDia);
            tabPageRegister.Controls.Add(nudCalorias);
            tabPageRegister.Controls.Add(lblCalorias);
            tabPageRegister.Controls.Add(dtpDataFim);
            tabPageRegister.Controls.Add(lblDataFim);
            tabPageRegister.Controls.Add(dtpDataInicio);
            tabPageRegister.Controls.Add(lblDataInicio);
            tabPageRegister.Controls.Add(lblPaciente);
            tabPageRegister.Controls.Add(txtDescricao);
            tabPageRegister.Controls.Add(cboPaciente);
            tabPageRegister.Size = new Size(786, 422);
            tabPageRegister.Controls.SetChildIndex(cboPaciente, 0);
            tabPageRegister.Controls.SetChildIndex(txtDescricao, 0);
            tabPageRegister.Controls.SetChildIndex(lblPaciente, 0);
            tabPageRegister.Controls.SetChildIndex(lblDataInicio, 0);
            tabPageRegister.Controls.SetChildIndex(dtpDataInicio, 0);
            tabPageRegister.Controls.SetChildIndex(lblDataFim, 0);
            tabPageRegister.Controls.SetChildIndex(dtpDataFim, 0);
            tabPageRegister.Controls.SetChildIndex(lblCalorias, 0);
            tabPageRegister.Controls.SetChildIndex(nudCalorias, 0);
            tabPageRegister.Controls.SetChildIndex(lblRefeicoesDia, 0);
            tabPageRegister.Controls.SetChildIndex(nudRefeicoesDia, 0);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            // 
            // txtId
            // 
            txtId.Location = new Point(723, 16);
            txtId.Name = "txtId";
            txtId.Size = new Size(56, 23);
            txtId.TabIndex = 99;
            txtId.Visible = false;
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
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Hint = "Selecione o Paciente";
            cboPaciente.IntegralHeight = false;
            cboPaciente.ItemHeight = 43;
            cboPaciente.Location = new Point(20, 45);
            cboPaciente.MaxDropDownItems = 4;
            cboPaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(759, 49);
            cboPaciente.StartIndex = 0;
            cboPaciente.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.AnimateReadOnly = false;
            txtDescricao.AutoCompleteMode = AutoCompleteMode.None;
            txtDescricao.AutoCompleteSource = AutoCompleteSource.None;
            txtDescricao.BackgroundImageLayout = ImageLayout.None;
            txtDescricao.CharacterCasing = CharacterCasing.Normal;
            txtDescricao.Depth = 0;
            txtDescricao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricao.HideSelection = true;
            txtDescricao.Hint = "Descrição Geral (Ex: Dieta Hipertrofia)";
            txtDescricao.LeadingIcon = null;
            txtDescricao.Location = new Point(20, 110);
            txtDescricao.MaxLength = 32767;
            txtDescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PasswordChar = '\0';
            txtDescricao.PrefixSuffixText = null;
            txtDescricao.ReadOnly = false;
            txtDescricao.RightToLeft = RightToLeft.No;
            txtDescricao.SelectedText = "";
            txtDescricao.SelectionLength = 0;
            txtDescricao.SelectionStart = 0;
            txtDescricao.ShortcutsEnabled = true;
            txtDescricao.Size = new Size(759, 48);
            txtDescricao.TabIndex = 1;
            txtDescricao.TabStop = false;
            txtDescricao.TextAlign = HorizontalAlignment.Left;
            txtDescricao.TrailingIcon = null;
            txtDescricao.UseSystemPasswordChar = false;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Depth = 0;
            lblPaciente.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPaciente.Location = new Point(20, 20);
            lblPaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(66, 19);
            lblPaciente.TabIndex = 2;
            lblPaciente.Text = "Paciente:";
            // 
            // lblDataInicio
            // 
            lblDataInicio.AutoSize = true;
            lblDataInicio.Depth = 0;
            lblDataInicio.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDataInicio.Location = new Point(20, 175);
            lblDataInicio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblDataInicio.Name = "lblDataInicio";
            lblDataInicio.Size = new Size(81, 19);
            lblDataInicio.TabIndex = 100;
            lblDataInicio.Text = "Data Início:";
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.Format = DateTimePickerFormat.Short;
            dtpDataInicio.Location = new Point(20, 197);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(130, 23);
            dtpDataInicio.TabIndex = 2;
            // 
            // lblDataFim
            // 
            lblDataFim.AutoSize = true;
            lblDataFim.Depth = 0;
            lblDataFim.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDataFim.Location = new Point(180, 175);
            lblDataFim.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblDataFim.Name = "lblDataFim";
            lblDataFim.Size = new Size(70, 19);
            lblDataFim.TabIndex = 101;
            lblDataFim.Text = "Data Fim:";
            // 
            // dtpDataFim
            // 
            dtpDataFim.Format = DateTimePickerFormat.Short;
            dtpDataFim.Location = new Point(180, 197);
            dtpDataFim.Name = "dtpDataFim";
            dtpDataFim.Size = new Size(130, 23);
            dtpDataFim.TabIndex = 3;
            // 
            // lblCalorias
            // 
            lblCalorias.AutoSize = true;
            lblCalorias.Depth = 0;
            lblCalorias.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCalorias.Location = new Point(20, 240);
            lblCalorias.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblCalorias.Name = "lblCalorias";
            lblCalorias.Size = new Size(117, 19);
            lblCalorias.TabIndex = 102;
            lblCalorias.Text = "Calorias Diárias:";
            // 
            // nudCalorias
            // 
            nudCalorias.Location = new Point(20, 262);
            nudCalorias.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudCalorias.Name = "nudCalorias";
            nudCalorias.Size = new Size(130, 23);
            nudCalorias.TabIndex = 4;
            nudCalorias.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // lblRefeicoesDia
            // 
            lblRefeicoesDia.AutoSize = true;
            lblRefeicoesDia.Depth = 0;
            lblRefeicoesDia.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRefeicoesDia.Location = new Point(180, 240);
            lblRefeicoesDia.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblRefeicoesDia.Name = "lblRefeicoesDia";
            lblRefeicoesDia.Size = new Size(105, 19);
            lblRefeicoesDia.TabIndex = 103;
            lblRefeicoesDia.Text = "Refeições/Dia:";
            // 
            // nudRefeicoesDia
            // 
            nudRefeicoesDia.Location = new Point(180, 262);
            nudRefeicoesDia.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudRefeicoesDia.Name = "nudRefeicoesDia";
            nudRefeicoesDia.Size = new Size(130, 23);
            nudRefeicoesDia.TabIndex = 5;
            nudRefeicoesDia.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // PlanoAlimentarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Location = new Point(0, 0);
            MaximizeBox = false;
            Name = "PlanoAlimentarForm";
            Text = "Cadastro de Plano Alimentar";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            tabPageRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCalorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRefeicoesDia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Declarei o txtId aqui embaixo
        private System.Windows.Forms.TextBox txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboPaciente;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricao;
        private ReaLTaiizor.Controls.MaterialLabel lblPaciente;
        private ReaLTaiizor.Controls.MaterialLabel lblDataInicio;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private ReaLTaiizor.Controls.MaterialLabel lblDataFim;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private ReaLTaiizor.Controls.MaterialLabel lblCalorias;
        private System.Windows.Forms.NumericUpDown nudCalorias;
        private ReaLTaiizor.Controls.MaterialLabel lblRefeicoesDia;
        private System.Windows.Forms.NumericUpDown nudRefeicoesDia;
    }
}