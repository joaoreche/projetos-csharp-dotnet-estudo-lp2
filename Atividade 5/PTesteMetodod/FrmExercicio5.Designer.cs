namespace PTesteMetodod
{
    partial class FrmExercicio5
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
            this.TxtNumero1 = new System.Windows.Forms.TextBox();
            this.TxtNumero2 = new System.Windows.Forms.TextBox();
            this.BtnSortear = new System.Windows.Forms.Button();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.LblNum2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtNumero1
            // 
            this.TxtNumero1.Location = new System.Drawing.Point(179, 25);
            this.TxtNumero1.Name = "TxtNumero1";
            this.TxtNumero1.Size = new System.Drawing.Size(225, 26);
            this.TxtNumero1.TabIndex = 3;
            // 
            // TxtNumero2
            // 
            this.TxtNumero2.Location = new System.Drawing.Point(179, 79);
            this.TxtNumero2.Name = "TxtNumero2";
            this.TxtNumero2.Size = new System.Drawing.Size(225, 26);
            this.TxtNumero2.TabIndex = 4;
            // 
            // BtnSortear
            // 
            this.BtnSortear.Location = new System.Drawing.Point(12, 127);
            this.BtnSortear.Name = "BtnSortear";
            this.BtnSortear.Size = new System.Drawing.Size(103, 55);
            this.BtnSortear.TabIndex = 5;
            this.BtnSortear.Text = "Sortear";
            this.BtnSortear.UseVisualStyleBackColor = true;
            this.BtnSortear.Click += new System.EventHandler(this.BtnSortear_Click);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(12, 28);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(114, 19);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "Primeiro Número";
            // 
            // LblNum2
            // 
            this.LblNum2.AutoSize = true;
            this.LblNum2.Location = new System.Drawing.Point(12, 82);
            this.LblNum2.Name = "LblNum2";
            this.LblNum2.Size = new System.Drawing.Size(116, 19);
            this.LblNum2.TabIndex = 2;
            this.LblNum2.Text = "Segundo Número";
            // 
            // FrmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.LblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.BtnSortear);
            this.Controls.Add(this.TxtNumero2);
            this.Controls.Add(this.TxtNumero1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmExercicio5";
            this.Text = "FrmExercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumero1;
        private System.Windows.Forms.TextBox TxtNumero2;
        private System.Windows.Forms.Button BtnSortear;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label LblNum2;
    }
}