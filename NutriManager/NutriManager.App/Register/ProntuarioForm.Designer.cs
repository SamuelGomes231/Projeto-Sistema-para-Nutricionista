namespace NutriManager.App.Pages
{
    partial class ProntuarioForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNome = new ReaLTaiizor.Controls.MaterialLabel();
            lblEmail = new ReaLTaiizor.Controls.MaterialLabel();
            lblIdade = new ReaLTaiizor.Controls.MaterialLabel();
            tabControlProntuario = new ReaLTaiizor.Controls.MaterialTabControl();
            tabConsultas = new TabPage();
            gridConsultas = new DataGridView();
            tabPlanos = new TabPage();
            gridPlanos = new DataGridView();
            selectorProntuario = new ReaLTaiizor.Controls.MaterialTabSelector();
            tabControlProntuario.SuspendLayout();
            tabConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridConsultas).BeginInit();
            tabPlanos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPlanos).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Depth = 0;
            lblNome.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNome.Location = new Point(20, 80);
            lblNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(600, 50);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome do Paciente";
            // 
            // lblEmail
            // 
            lblEmail.Depth = 0;
            lblEmail.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEmail.Location = new Point(25, 130);
            lblEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(300, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "email@email.com";
            // 
            // lblIdade
            // 
            lblIdade.Depth = 0;
            lblIdade.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblIdade.Location = new Point(350, 130);
            lblIdade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(100, 20);
            lblIdade.TabIndex = 2;
            lblIdade.Text = "00 anos";
            // 
            // tabControlProntuario
            // 
            tabControlProntuario.Controls.Add(tabConsultas);
            tabControlProntuario.Controls.Add(tabPlanos);
            tabControlProntuario.Depth = 0;
            tabControlProntuario.Dock = DockStyle.Bottom;
            tabControlProntuario.Location = new Point(3, 206);
            tabControlProntuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlProntuario.Multiline = true;
            tabControlProntuario.Name = "tabControlProntuario";
            tabControlProntuario.SelectedIndex = 0;
            tabControlProntuario.Size = new Size(981, 403);
            tabControlProntuario.TabIndex = 0;
            // 
            // tabConsultas
            // 
            tabConsultas.Controls.Add(gridConsultas);
            tabConsultas.Location = new Point(4, 24);
            tabConsultas.Name = "tabConsultas";
            tabConsultas.Size = new Size(973, 375);
            tabConsultas.TabIndex = 0;
            tabConsultas.Text = "Histórico de Consultas";
            // 
            // gridConsultas
            // 
            gridConsultas.BackgroundColor = Color.White;
            gridConsultas.Dock = DockStyle.Fill;
            gridConsultas.Location = new Point(0, 0);
            gridConsultas.Name = "gridConsultas";
            gridConsultas.Size = new Size(973, 375);
            gridConsultas.TabIndex = 0;
            // 
            // tabPlanos
            // 
            tabPlanos.Controls.Add(gridPlanos);
            tabPlanos.Location = new Point(4, 24);
            tabPlanos.Name = "tabPlanos";
            tabPlanos.Size = new Size(973, 375);
            tabPlanos.TabIndex = 1;
            tabPlanos.Text = "Planos Alimentares";
            // 
            // gridPlanos
            // 
            gridPlanos.BackgroundColor = Color.White;
            gridPlanos.Dock = DockStyle.Fill;
            gridPlanos.Location = new Point(0, 0);
            gridPlanos.Name = "gridPlanos";
            gridPlanos.Size = new Size(973, 375);
            gridPlanos.TabIndex = 0;
            // 
            // selectorProntuario
            // 
            selectorProntuario.BaseTabControl = tabControlProntuario;
            selectorProntuario.CharacterCasing = ReaLTaiizor.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            selectorProntuario.Depth = 0;
            selectorProntuario.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            selectorProntuario.HeadAlignment = ReaLTaiizor.Controls.MaterialTabSelector.Alignment.Left;
            selectorProntuario.Location = new Point(-6, 160);
            selectorProntuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            selectorProntuario.Name = "selectorProntuario";
            selectorProntuario.Size = new Size(1006, 40);
            selectorProntuario.TabIndex = 1;
            // 
            // ProntuarioForm
            // 
            ClientSize = new Size(987, 612);
            Controls.Add(tabControlProntuario);
            Controls.Add(selectorProntuario);
            Controls.Add(lblIdade);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            MaximizeBox = false;
            Name = "ProntuarioForm";
            Text = "Prontuário";
            tabControlProntuario.ResumeLayout(false);
            tabConsultas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridConsultas).EndInit();
            tabPlanos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridPlanos).EndInit();
            ResumeLayout(false);
        }

        private ReaLTaiizor.Controls.MaterialLabel lblNome;
        private ReaLTaiizor.Controls.MaterialLabel lblEmail;
        private ReaLTaiizor.Controls.MaterialLabel lblIdade;
        private ReaLTaiizor.Controls.MaterialTabControl tabControlProntuario;
        private ReaLTaiizor.Controls.MaterialTabSelector selectorProntuario;
        private System.Windows.Forms.TabPage tabConsultas;
        private System.Windows.Forms.DataGridView gridConsultas;
        private System.Windows.Forms.TabPage tabPlanos;
        private System.Windows.Forms.DataGridView gridPlanos;
    }
}