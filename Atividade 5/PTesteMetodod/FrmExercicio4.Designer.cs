namespace PTesteMetodod
{
    partial class FrmExercicio4
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
            this.rchTxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnCalcularNum = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnCalcularAlfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTxtFrase
            // 
            this.rchTxtFrase.Location = new System.Drawing.Point(12, 12);
            this.rchTxtFrase.Name = "rchTxtFrase";
            this.rchTxtFrase.Size = new System.Drawing.Size(450, 220);
            this.rchTxtFrase.TabIndex = 0;
            this.rchTxtFrase.Text = "";
            // 
            // btnCalcularNum
            // 
            this.btnCalcularNum.Location = new System.Drawing.Point(468, 17);
            this.btnCalcularNum.Name = "btnCalcularNum";
            this.btnCalcularNum.Size = new System.Drawing.Size(130, 67);
            this.btnCalcularNum.TabIndex = 1;
            this.btnCalcularNum.Text = "Calcular Caracteres Numericos";
            this.btnCalcularNum.UseVisualStyleBackColor = true;
            this.btnCalcularNum.Click += new System.EventHandler(this.btnCalcularNum_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(468, 88);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(130, 67);
            this.btnLocalizar.TabIndex = 2;
            this.btnLocalizar.Text = "Localizar Caracter em Branco";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnCalcularAlfa
            // 
            this.btnCalcularAlfa.Location = new System.Drawing.Point(468, 161);
            this.btnCalcularAlfa.Name = "btnCalcularAlfa";
            this.btnCalcularAlfa.Size = new System.Drawing.Size(130, 67);
            this.btnCalcularAlfa.TabIndex = 3;
            this.btnCalcularAlfa.Text = "Calcular Caracteres Alfabéticos";
            this.btnCalcularAlfa.UseVisualStyleBackColor = true;
            this.btnCalcularAlfa.Click += new System.EventHandler(this.btnCalcularAlfa_Click);
            // 
            // FrmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 709);
            this.Controls.Add(this.btnCalcularAlfa);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnCalcularNum);
            this.Controls.Add(this.rchTxtFrase);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Name = "FrmExercicio4";
            this.Text = "FrmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtFrase;
        private System.Windows.Forms.Button btnCalcularNum;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnCalcularAlfa;
    }
}