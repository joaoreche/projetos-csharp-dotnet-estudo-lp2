namespace Ploops
{
    partial class frmExercicio1
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
            this.rchtxtEx1 = new System.Windows.Forms.RichTextBox();
            this.btnContarWhiteSpaces = new System.Windows.Forms.Button();
            this.btnContarR = new System.Windows.Forms.Button();
            this.btnContarPares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtEx1
            // 
            this.rchtxtEx1.Location = new System.Drawing.Point(17, 16);
            this.rchtxtEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rchtxtEx1.MaxLength = 100;
            this.rchtxtEx1.Name = "rchtxtEx1";
            this.rchtxtEx1.Size = new System.Drawing.Size(536, 215);
            this.rchtxtEx1.TabIndex = 0;
            this.rchtxtEx1.Text = "";
            this.rchtxtEx1.Validated += new System.EventHandler(this.rchtxtEx1_Validated);
            // 
            // btnContarWhiteSpaces
            // 
            this.btnContarWhiteSpaces.Location = new System.Drawing.Point(17, 240);
            this.btnContarWhiteSpaces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContarWhiteSpaces.Name = "btnContarWhiteSpaces";
            this.btnContarWhiteSpaces.Size = new System.Drawing.Size(173, 81);
            this.btnContarWhiteSpaces.TabIndex = 1;
            this.btnContarWhiteSpaces.Text = "Contar White Spaces";
            this.btnContarWhiteSpaces.UseVisualStyleBackColor = true;
            this.btnContarWhiteSpaces.Click += new System.EventHandler(this.btnContarWhiteSpaces_Click);
            // 
            // btnContarR
            // 
            this.btnContarR.Location = new System.Drawing.Point(199, 240);
            this.btnContarR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContarR.Name = "btnContarR";
            this.btnContarR.Size = new System.Drawing.Size(173, 81);
            this.btnContarR.TabIndex = 2;
            this.btnContarR.Text = "Contar \'R\'";
            this.btnContarR.UseVisualStyleBackColor = true;
            this.btnContarR.Click += new System.EventHandler(this.btnContarR_Click);
            // 
            // btnContarPares
            // 
            this.btnContarPares.Location = new System.Drawing.Point(381, 240);
            this.btnContarPares.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContarPares.Name = "btnContarPares";
            this.btnContarPares.Size = new System.Drawing.Size(173, 81);
            this.btnContarPares.TabIndex = 3;
            this.btnContarPares.Text = "Contar Par de Letras";
            this.btnContarPares.UseVisualStyleBackColor = true;
            this.btnContarPares.Click += new System.EventHandler(this.btnContarPares_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 938);
            this.Controls.Add(this.btnContarPares);
            this.Controls.Add(this.btnContarR);
            this.Controls.Add(this.btnContarWhiteSpaces);
            this.Controls.Add(this.rchtxtEx1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtEx1;
        private System.Windows.Forms.Button btnContarWhiteSpaces;
        private System.Windows.Forms.Button btnContarR;
        private System.Windows.Forms.Button btnContarPares;
    }
}