namespace Ploops
{
    partial class frmExercicio2
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnGerarH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(13, 9);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(123, 19);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Digite um Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(217, 6);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(143, 26);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.Validated += new System.EventHandler(this.txtNumero_Validated);
            // 
            // btnGerarH
            // 
            this.btnGerarH.Location = new System.Drawing.Point(18, 65);
            this.btnGerarH.Name = "btnGerarH";
            this.btnGerarH.Size = new System.Drawing.Size(153, 75);
            this.btnGerarH.TabIndex = 2;
            this.btnGerarH.Text = "Gerar Número H";
            this.btnGerarH.UseVisualStyleBackColor = true;
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 592);
            this.Controls.Add(this.btnGerarH);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnGerarH;
    }
}