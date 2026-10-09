namespace Parray
{
    partial class FrmEx5
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
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.LbEx5 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Location = new System.Drawing.Point(12, 12);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(140, 80);
            this.BtnVerificar.TabIndex = 0;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // LbEx5
            // 
            this.LbEx5.FormattingEnabled = true;
            this.LbEx5.ItemHeight = 19;
            this.LbEx5.Location = new System.Drawing.Point(205, 12);
            this.LbEx5.Name = "LbEx5";
            this.LbEx5.Size = new System.Drawing.Size(415, 403);
            this.LbEx5.TabIndex = 1;
            // 
            // FrmEx5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 672);
            this.Controls.Add(this.LbEx5);
            this.Controls.Add(this.BtnVerificar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmEx5";
            this.Text = "FrmEx5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.ListBox LbEx5;
    }
}