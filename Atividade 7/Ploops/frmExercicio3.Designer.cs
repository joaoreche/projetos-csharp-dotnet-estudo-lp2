namespace Ploops
{
    partial class frmExercicio3
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
            this.btnPalindromo = new System.Windows.Forms.Button();
            this.txtPalindromo = new System.Windows.Forms.TextBox();
            this.lblFrase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPalindromo
            // 
            this.btnPalindromo.Location = new System.Drawing.Point(19, 67);
            this.btnPalindromo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPalindromo.Name = "btnPalindromo";
            this.btnPalindromo.Size = new System.Drawing.Size(165, 76);
            this.btnPalindromo.TabIndex = 5;
            this.btnPalindromo.Text = "Testar Palíndromo";
            this.btnPalindromo.UseVisualStyleBackColor = true;
            this.btnPalindromo.Click += new System.EventHandler(this.btnPalindromo_Click);
            // 
            // txtPalindromo
            // 
            this.txtPalindromo.Location = new System.Drawing.Point(217, 6);
            this.txtPalindromo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPalindromo.Name = "txtPalindromo";
            this.txtPalindromo.Size = new System.Drawing.Size(355, 26);
            this.txtPalindromo.TabIndex = 4;
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Location = new System.Drawing.Point(15, 9);
            this.lblFrase.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(109, 19);
            this.lblFrase.TabIndex = 3;
            this.lblFrase.Text = "Digite uma frase:";
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 584);
            this.Controls.Add(this.btnPalindromo);
            this.Controls.Add(this.txtPalindromo);
            this.Controls.Add(this.lblFrase);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPalindromo;
        private System.Windows.Forms.TextBox txtPalindromo;
        private System.Windows.Forms.Label lblFrase;
    }
}