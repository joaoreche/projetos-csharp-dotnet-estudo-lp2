namespace Parray
{
    partial class FrmEx4
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
            this.BtnExecutar = new System.Windows.Forms.Button();
            this.LbEx4 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnExecutar
            // 
            this.BtnExecutar.Location = new System.Drawing.Point(12, 12);
            this.BtnExecutar.Name = "BtnExecutar";
            this.BtnExecutar.Size = new System.Drawing.Size(140, 80);
            this.BtnExecutar.TabIndex = 0;
            this.BtnExecutar.Text = "Executar";
            this.BtnExecutar.UseVisualStyleBackColor = true;
            this.BtnExecutar.Click += new System.EventHandler(this.BtnExecutar_Click);
            // 
            // LbEx4
            // 
            this.LbEx4.FormattingEnabled = true;
            this.LbEx4.ItemHeight = 19;
            this.LbEx4.Location = new System.Drawing.Point(213, 12);
            this.LbEx4.Name = "LbEx4";
            this.LbEx4.Size = new System.Drawing.Size(351, 232);
            this.LbEx4.TabIndex = 1;
            // 
            // FrmEx4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 664);
            this.Controls.Add(this.LbEx4);
            this.Controls.Add(this.BtnExecutar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmEx4";
            this.Text = "FrmEx4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExecutar;
        private System.Windows.Forms.ListBox LbEx4;
    }
}