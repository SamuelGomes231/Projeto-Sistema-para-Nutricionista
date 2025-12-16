namespace NutriManager.App.Pages
{
    partial class DashboardForm
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
            cardPacientes = new ReaLTaiizor.Controls.MaterialCard();
            lblNumPacientes = new Label();
            lblTituloPacientes = new Label();
            cardConsultas = new ReaLTaiizor.Controls.MaterialCard();
            lblNumConsultas = new Label();
            lblTituloConsultas = new Label();
            cardPlanos = new ReaLTaiizor.Controls.MaterialCard();
            lblNumPlanos = new Label();
            lblTituloPlanos = new Label();
            cardPacientes.SuspendLayout();
            cardConsultas.SuspendLayout();
            cardPlanos.SuspendLayout();
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
            lblTitulo.Size = new Size(287, 29);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Visão Geral do Consultório";
            // 
            // cardPacientes
            // 
            cardPacientes.BackColor = Color.FromArgb(255, 255, 255);
            cardPacientes.Controls.Add(lblNumPacientes);
            cardPacientes.Controls.Add(lblTituloPacientes);
            cardPacientes.Depth = 0;
            cardPacientes.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardPacientes.Location = new Point(20, 130);
            cardPacientes.Margin = new Padding(14);
            cardPacientes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            cardPacientes.Name = "cardPacientes";
            cardPacientes.Padding = new Padding(14);
            cardPacientes.Size = new Size(220, 120);
            cardPacientes.TabIndex = 1;
            // 
            // lblNumPacientes
            // 
            lblNumPacientes.AutoSize = true;
            lblNumPacientes.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblNumPacientes.ForeColor = Color.DarkSlateBlue;
            lblNumPacientes.Location = new Point(10, 40);
            lblNumPacientes.Name = "lblNumPacientes";
            lblNumPacientes.Size = new Size(56, 65);
            lblNumPacientes.TabIndex = 1;
            lblNumPacientes.Text = "0";
            // 
            // lblTituloPacientes
            // 
            lblTituloPacientes.AutoSize = true;
            lblTituloPacientes.Font = new Font("Segoe UI", 12F);
            lblTituloPacientes.ForeColor = Color.Gray;
            lblTituloPacientes.Location = new Point(14, 14);
            lblTituloPacientes.Name = "lblTituloPacientes";
            lblTituloPacientes.Size = new Size(74, 21);
            lblTituloPacientes.TabIndex = 0;
            lblTituloPacientes.Text = "Pacientes";
            // 
            // cardConsultas
            // 
            cardConsultas.BackColor = Color.FromArgb(255, 255, 255);
            cardConsultas.Controls.Add(lblNumConsultas);
            cardConsultas.Controls.Add(lblTituloConsultas);
            cardConsultas.Depth = 0;
            cardConsultas.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardConsultas.Location = new Point(260, 130);
            cardConsultas.Margin = new Padding(14);
            cardConsultas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            cardConsultas.Name = "cardConsultas";
            cardConsultas.Padding = new Padding(14);
            cardConsultas.Size = new Size(220, 120);
            cardConsultas.TabIndex = 2;
            // 
            // lblNumConsultas
            // 
            lblNumConsultas.AutoSize = true;
            lblNumConsultas.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblNumConsultas.ForeColor = Color.Teal;
            lblNumConsultas.Location = new Point(10, 40);
            lblNumConsultas.Name = "lblNumConsultas";
            lblNumConsultas.Size = new Size(56, 65);
            lblNumConsultas.TabIndex = 1;
            lblNumConsultas.Text = "0";
            // 
            // lblTituloConsultas
            // 
            lblTituloConsultas.AutoSize = true;
            lblTituloConsultas.Font = new Font("Segoe UI", 12F);
            lblTituloConsultas.ForeColor = Color.Gray;
            lblTituloConsultas.Location = new Point(14, 14);
            lblTituloConsultas.Name = "lblTituloConsultas";
            lblTituloConsultas.Size = new Size(155, 21);
            lblTituloConsultas.TabIndex = 0;
            lblTituloConsultas.Text = "Consultas Realizadas";
            // 
            // cardPlanos
            // 
            cardPlanos.BackColor = Color.FromArgb(255, 255, 255);
            cardPlanos.Controls.Add(lblNumPlanos);
            cardPlanos.Controls.Add(lblTituloPlanos);
            cardPlanos.Depth = 0;
            cardPlanos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardPlanos.Location = new Point(500, 130);
            cardPlanos.Margin = new Padding(14);
            cardPlanos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            cardPlanos.Name = "cardPlanos";
            cardPlanos.Padding = new Padding(14);
            cardPlanos.Size = new Size(220, 120);
            cardPlanos.TabIndex = 3;
            // 
            // lblNumPlanos
            // 
            lblNumPlanos.AutoSize = true;
            lblNumPlanos.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblNumPlanos.ForeColor = Color.OrangeRed;
            lblNumPlanos.Location = new Point(10, 40);
            lblNumPlanos.Name = "lblNumPlanos";
            lblNumPlanos.Size = new Size(56, 65);
            lblNumPlanos.TabIndex = 1;
            lblNumPlanos.Text = "0";
            // 
            // lblTituloPlanos
            // 
            lblTituloPlanos.AutoSize = true;
            lblTituloPlanos.Font = new Font("Segoe UI", 12F);
            lblTituloPlanos.ForeColor = Color.Gray;
            lblTituloPlanos.Location = new Point(14, 14);
            lblTituloPlanos.Name = "lblTituloPlanos";
            lblTituloPlanos.Size = new Size(143, 21);
            lblTituloPlanos.TabIndex = 0;
            lblTituloPlanos.Text = "Planos Alimentares";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 280);
            Controls.Add(cardPlanos);
            Controls.Add(cardConsultas);
            Controls.Add(cardPacientes);
            Controls.Add(lblTitulo);
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dashboard";
            cardPacientes.ResumeLayout(false);
            cardPacientes.PerformLayout();
            cardConsultas.ResumeLayout(false);
            cardConsultas.PerformLayout();
            cardPlanos.ResumeLayout(false);
            cardPlanos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private ReaLTaiizor.Controls.MaterialLabel lblTitulo;

        // Card Pacientes
        private ReaLTaiizor.Controls.MaterialCard cardPacientes;
        private System.Windows.Forms.Label lblTituloPacientes;
        private System.Windows.Forms.Label lblNumPacientes;

        // Card Consultas
        private ReaLTaiizor.Controls.MaterialCard cardConsultas;
        private System.Windows.Forms.Label lblTituloConsultas;
        private System.Windows.Forms.Label lblNumConsultas;

        // Card Planos
        private ReaLTaiizor.Controls.MaterialCard cardPlanos;
        private System.Windows.Forms.Label lblTituloPlanos;
        private System.Windows.Forms.Label lblNumPlanos;
    }
}