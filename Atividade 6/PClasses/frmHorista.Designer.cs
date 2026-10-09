namespace PClasses
{
    partial class frmHorista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnInstanciar = new System.Windows.Forms.Button();
            this.TxtHoras = new System.Windows.Forms.TextBox();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.LblHora = new System.Windows.Forms.Label();
            this.LblSalario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.LblMatricula = new System.Windows.Forms.Label();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.LblData = new System.Windows.Forms.Label();
            this.TxtFaltas = new System.Windows.Forms.TextBox();
            this.LblFaltas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnInstanciar
            // 
            this.BtnInstanciar.Location = new System.Drawing.Point(8, 324);
            this.BtnInstanciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnInstanciar.Name = "BtnInstanciar";
            this.BtnInstanciar.Size = new System.Drawing.Size(293, 87);
            this.BtnInstanciar.TabIndex = 22;
            this.BtnInstanciar.Text = "Instanciar Horista";
            this.BtnInstanciar.UseVisualStyleBackColor = true;
            this.BtnInstanciar.Click += new System.EventHandler(this.BtnInstanciar_Click);
            // 
            // TxtHoras
            // 
            this.TxtHoras.Location = new System.Drawing.Point(335, 160);
            this.TxtHoras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtHoras.Name = "TxtHoras";
            this.TxtHoras.Size = new System.Drawing.Size(332, 35);
            this.TxtHoras.TabIndex = 19;
            // 
            // TxtSalario
            // 
            this.TxtSalario.Location = new System.Drawing.Point(335, 109);
            this.TxtSalario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(332, 35);
            this.TxtSalario.TabIndex = 18;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(335, 57);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(332, 35);
            this.TxtNome.TabIndex = 17;
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Location = new System.Drawing.Point(335, 9);
            this.TxtMatricula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(332, 35);
            this.TxtMatricula.TabIndex = 16;
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Location = new System.Drawing.Point(13, 164);
            this.LblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(182, 27);
            this.LblHora.TabIndex = 13;
            this.LblHora.Text = "Número de Horas";
            // 
            // LblSalario
            // 
            this.LblSalario.AutoSize = true;
            this.LblSalario.Location = new System.Drawing.Point(13, 113);
            this.LblSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSalario.Name = "LblSalario";
            this.LblSalario.Size = new System.Drawing.Size(170, 27);
            this.LblSalario.TabIndex = 12;
            this.LblSalario.Text = "Salário por Hora";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 61);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(70, 27);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome";
            // 
            // LblMatricula
            // 
            this.LblMatricula.AutoSize = true;
            this.LblMatricula.Location = new System.Drawing.Point(13, 9);
            this.LblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMatricula.Name = "LblMatricula";
            this.LblMatricula.Size = new System.Drawing.Size(105, 27);
            this.LblMatricula.TabIndex = 10;
            this.LblMatricula.Text = "Matrícula";
            // 
            // TxtData
            // 
            this.TxtData.Location = new System.Drawing.Point(335, 210);
            this.TxtData.Margin = new System.Windows.Forms.Padding(4);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(332, 35);
            this.TxtData.TabIndex = 20;
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Location = new System.Drawing.Point(13, 214);
            this.LblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(288, 27);
            this.LblData.TabIndex = 14;
            this.LblData.Text = "Data de Entrada na Empresa";
            // 
            // TxtFaltas
            // 
            this.TxtFaltas.Location = new System.Drawing.Point(335, 260);
            this.TxtFaltas.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFaltas.Name = "TxtFaltas";
            this.TxtFaltas.Size = new System.Drawing.Size(332, 35);
            this.TxtFaltas.TabIndex = 21;
            // 
            // LblFaltas
            // 
            this.LblFaltas.AutoSize = true;
            this.LblFaltas.Location = new System.Drawing.Point(13, 264);
            this.LblFaltas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFaltas.Name = "LblFaltas";
            this.LblFaltas.Size = new System.Drawing.Size(147, 27);
            this.LblFaltas.TabIndex = 15;
            this.LblFaltas.Text = "Dias de Faltas";
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1756, 963);
            this.Controls.Add(this.TxtFaltas);
            this.Controls.Add(this.LblFaltas);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.BtnInstanciar);
            this.Controls.Add(this.TxtHoras);
            this.Controls.Add(this.TxtSalario);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.LblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.LblMatricula);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnInstanciar;
        private System.Windows.Forms.TextBox TxtHoras;
        private System.Windows.Forms.TextBox TxtSalario;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label LblSalario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label LblMatricula;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.TextBox TxtFaltas;
        private System.Windows.Forms.Label LblFaltas;
    }
}