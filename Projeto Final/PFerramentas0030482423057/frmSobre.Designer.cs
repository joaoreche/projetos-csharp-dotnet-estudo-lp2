namespace PFerramentas0030482423057
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            this.lblCorpoTexto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picFotoJoao = new System.Windows.Forms.PictureBox();
            this.lblInfoJoao = new System.Windows.Forms.Label();
            this.lblInfoLeo = new System.Windows.Forms.Label();
            this.picFotoLeo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoJoao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoLeo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCorpoTexto
            // 
            this.lblCorpoTexto.AutoSize = true;
            this.lblCorpoTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorpoTexto.Location = new System.Drawing.Point(18, 76);
            this.lblCorpoTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorpoTexto.Name = "lblCorpoTexto";
            this.lblCorpoTexto.Size = new System.Drawing.Size(1000, 288);
            this.lblCorpoTexto.TabIndex = 0;
            this.lblCorpoTexto.Text = resources.GetString("lblCorpoTexto.Text");
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTitulo.Location = new System.Drawing.Point(13, 18);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(239, 37);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Sobre o Projeto";
            // 
            // picFotoJoao
            // 
            this.picFotoJoao.Image = ((System.Drawing.Image)(resources.GetObject("picFotoJoao.Image")));
            this.picFotoJoao.Location = new System.Drawing.Point(40, 382);
            this.picFotoJoao.Margin = new System.Windows.Forms.Padding(4);
            this.picFotoJoao.Name = "picFotoJoao";
            this.picFotoJoao.Size = new System.Drawing.Size(260, 307);
            this.picFotoJoao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoJoao.TabIndex = 2;
            this.picFotoJoao.TabStop = false;
            // 
            // lblInfoJoao
            // 
            this.lblInfoJoao.AutoSize = true;
            this.lblInfoJoao.Location = new System.Drawing.Point(37, 693);
            this.lblInfoJoao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoJoao.Name = "lblInfoJoao";
            this.lblInfoJoao.Size = new System.Drawing.Size(241, 36);
            this.lblInfoJoao.TabIndex = 3;
            this.lblInfoJoao.Text = "  • Nome: João Vitor Pereira Reche\r\n  • RA: 0030482423057";
            // 
            // lblInfoLeo
            // 
            this.lblInfoLeo.AutoSize = true;
            this.lblInfoLeo.Location = new System.Drawing.Point(353, 693);
            this.lblInfoLeo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoLeo.Name = "lblInfoLeo";
            this.lblInfoLeo.Size = new System.Drawing.Size(273, 36);
            this.lblInfoLeo.TabIndex = 4;
            this.lblInfoLeo.Text = "  • Nome: Leonardo Cordeiro de Oliveira\r\n  • RA: 0030482423002";
            // 
            // picFotoLeo
            // 
            this.picFotoLeo.Image = ((System.Drawing.Image)(resources.GetObject("picFotoLeo.Image")));
            this.picFotoLeo.Location = new System.Drawing.Point(356, 382);
            this.picFotoLeo.Margin = new System.Windows.Forms.Padding(4);
            this.picFotoLeo.Name = "picFotoLeo";
            this.picFotoLeo.Size = new System.Drawing.Size(260, 307);
            this.picFotoLeo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoLeo.TabIndex = 5;
            this.picFotoLeo.TabStop = false;
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 755);
            this.Controls.Add(this.picFotoLeo);
            this.Controls.Add(this.lblInfoLeo);
            this.Controls.Add(this.lblInfoJoao);
            this.Controls.Add(this.picFotoJoao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCorpoTexto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSobre";
            this.Text = "frmSobre";
            ((System.ComponentModel.ISupportInitialize)(this.picFotoJoao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoLeo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorpoTexto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picFotoJoao;
        private System.Windows.Forms.Label lblInfoJoao;
        private System.Windows.Forms.Label lblInfoLeo;
        private System.Windows.Forms.PictureBox picFotoLeo;
    }
}