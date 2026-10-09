namespace PClasses
{
    partial class frmMensalista
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
            this.TxtDataEntrada = new System.Windows.Forms.TextBox();
            this.LblData = new System.Windows.Forms.Label();
            this.BtnInstanciar = new System.Windows.Forms.Button();
            this.TxtSalarioMensal = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.LblSalario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.LblMatricula = new System.Windows.Forms.Label();
            this.BtnInstanciarParametros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDataEntrada
            // 
            this.TxtDataEntrada.Location = new System.Drawing.Point(335, 151);
            this.TxtDataEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDataEntrada.Name = "TxtDataEntrada";
            this.TxtDataEntrada.Size = new System.Drawing.Size(332, 26);
            this.TxtDataEntrada.TabIndex = 33;
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Location = new System.Drawing.Point(13, 155);
            this.LblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(183, 19);
            this.LblData.TabIndex = 27;
            this.LblData.Text = "Data de Entrada na Empresa";
            // 
            // BtnInstanciar
            // 
            this.BtnInstanciar.Location = new System.Drawing.Point(13, 196);
            this.BtnInstanciar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInstanciar.Name = "BtnInstanciar";
            this.BtnInstanciar.Size = new System.Drawing.Size(293, 87);
            this.BtnInstanciar.TabIndex = 35;
            this.BtnInstanciar.Text = "Instanciar Mensalista";
            this.BtnInstanciar.UseVisualStyleBackColor = true;
            this.BtnInstanciar.Click += new System.EventHandler(this.BtnInstanciar_Click);
            // 
            // TxtSalarioMensal
            // 
            this.TxtSalarioMensal.Location = new System.Drawing.Point(335, 105);
            this.TxtSalarioMensal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSalarioMensal.Name = "TxtSalarioMensal";
            this.TxtSalarioMensal.Size = new System.Drawing.Size(332, 26);
            this.TxtSalarioMensal.TabIndex = 31;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(335, 57);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(332, 26);
            this.TxtNome.TabIndex = 30;
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Location = new System.Drawing.Point(335, 9);
            this.TxtMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(332, 26);
            this.TxtMatricula.TabIndex = 29;
            // 
            // LblSalario
            // 
            this.LblSalario.AutoSize = true;
            this.LblSalario.Location = new System.Drawing.Point(13, 109);
            this.LblSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSalario.Name = "LblSalario";
            this.LblSalario.Size = new System.Drawing.Size(99, 19);
            this.LblSalario.TabIndex = 25;
            this.LblSalario.Text = "Salário Mensal";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 61);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 19);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome";
            // 
            // LblMatricula
            // 
            this.LblMatricula.AutoSize = true;
            this.LblMatricula.Location = new System.Drawing.Point(13, 9);
            this.LblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMatricula.Name = "LblMatricula";
            this.LblMatricula.Size = new System.Drawing.Size(66, 19);
            this.LblMatricula.TabIndex = 23;
            this.LblMatricula.Text = "Matrícula";
            // 
            // BtnInstanciarParametros
            // 
            this.BtnInstanciarParametros.Location = new System.Drawing.Point(314, 196);
            this.BtnInstanciarParametros.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInstanciarParametros.Name = "BtnInstanciarParametros";
            this.BtnInstanciarParametros.Size = new System.Drawing.Size(293, 87);
            this.BtnInstanciarParametros.TabIndex = 36;
            this.BtnInstanciarParametros.Text = "Instanciar por Parâmetros";
            this.BtnInstanciarParametros.UseVisualStyleBackColor = true;
            this.BtnInstanciarParametros.Click += new System.EventHandler(this.BtnInstanciarParametros_Click);
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 767);
            this.Controls.Add(this.BtnInstanciarParametros);
            this.Controls.Add(this.TxtDataEntrada);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.BtnInstanciar);
            this.Controls.Add(this.TxtSalarioMensal);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.LblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.LblMatricula);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtDataEntrada;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Button BtnInstanciar;
        private System.Windows.Forms.TextBox TxtSalarioMensal;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.Label LblSalario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label LblMatricula;
        private System.Windows.Forms.Button BtnInstanciarParametros;
    }
}