namespace PClasses
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnMensalista = new System.Windows.Forms.Button();
            this.BtnHorista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMensalista
            // 
            this.BtnMensalista.Location = new System.Drawing.Point(218, 144);
            this.BtnMensalista.Name = "BtnMensalista";
            this.BtnMensalista.Size = new System.Drawing.Size(141, 83);
            this.BtnMensalista.TabIndex = 0;
            this.BtnMensalista.Text = "Mensalista";
            this.BtnMensalista.UseVisualStyleBackColor = true;
            this.BtnMensalista.Click += new System.EventHandler(this.BtnMensalista_Click);
            // 
            // BtnHorista
            // 
            this.BtnHorista.Location = new System.Drawing.Point(476, 144);
            this.BtnHorista.Name = "BtnHorista";
            this.BtnHorista.Size = new System.Drawing.Size(153, 83);
            this.BtnHorista.TabIndex = 1;
            this.BtnHorista.Text = "Horista";
            this.BtnHorista.UseVisualStyleBackColor = true;
            this.BtnHorista.Click += new System.EventHandler(this.BtnHorista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 688);
            this.Controls.Add(this.BtnHorista);
            this.Controls.Add(this.BtnMensalista);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMensalista;
        private System.Windows.Forms.Button BtnHorista;
    }
}

