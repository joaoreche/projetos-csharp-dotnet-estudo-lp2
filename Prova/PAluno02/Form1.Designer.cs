namespace PAluno02
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
            this.BtnExecutar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.LstBxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnExecutar
            // 
            this.BtnExecutar.Location = new System.Drawing.Point(13, 13);
            this.BtnExecutar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExecutar.Name = "BtnExecutar";
            this.BtnExecutar.Size = new System.Drawing.Size(140, 80);
            this.BtnExecutar.TabIndex = 0;
            this.BtnExecutar.Text = "Executar";
            this.BtnExecutar.UseVisualStyleBackColor = true;
            this.BtnExecutar.Click += new System.EventHandler(this.BtnExecutar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(13, 178);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(140, 80);
            this.BtnLimpar.TabIndex = 1;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // LstBxResultado
            // 
            this.LstBxResultado.FormattingEnabled = true;
            this.LstBxResultado.ItemHeight = 27;
            this.LstBxResultado.Location = new System.Drawing.Point(176, 13);
            this.LstBxResultado.Name = "LstBxResultado";
            this.LstBxResultado.Size = new System.Drawing.Size(884, 517);
            this.LstBxResultado.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 711);
            this.Controls.Add(this.LstBxResultado);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnExecutar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExecutar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.ListBox LstBxResultado;
    }
}

