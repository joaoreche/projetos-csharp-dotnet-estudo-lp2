namespace Parray
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuEx1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEx2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEx3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEx4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEx5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEx1,
            this.MenuEx2,
            this.MenuEx3,
            this.MenuEx4,
            this.MenuEx5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuEx1
            // 
            this.MenuEx1.Name = "MenuEx1";
            this.MenuEx1.Size = new System.Drawing.Size(74, 20);
            this.MenuEx1.Text = "Exercício 1";
            this.MenuEx1.Click += new System.EventHandler(this.MenuEx1_Click);
            // 
            // MenuEx2
            // 
            this.MenuEx2.Name = "MenuEx2";
            this.MenuEx2.Size = new System.Drawing.Size(74, 20);
            this.MenuEx2.Text = "Exercício 2";
            this.MenuEx2.Click += new System.EventHandler(this.MenuEx2_Click);
            // 
            // MenuEx3
            // 
            this.MenuEx3.Name = "MenuEx3";
            this.MenuEx3.Size = new System.Drawing.Size(74, 20);
            this.MenuEx3.Text = "Exercício 3";
            this.MenuEx3.Click += new System.EventHandler(this.MenuEx3_Click);
            // 
            // MenuEx4
            // 
            this.MenuEx4.Name = "MenuEx4";
            this.MenuEx4.Size = new System.Drawing.Size(74, 20);
            this.MenuEx4.Text = "Exercício 4";
            this.MenuEx4.Click += new System.EventHandler(this.MenuEx4_Click);
            // 
            // MenuEx5
            // 
            this.MenuEx5.Name = "MenuEx5";
            this.MenuEx5.Size = new System.Drawing.Size(74, 20);
            this.MenuEx5.Text = "Exercício 5";
            this.MenuEx5.Click += new System.EventHandler(this.MenuEx5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 575);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuEx1;
        private System.Windows.Forms.ToolStripMenuItem MenuEx2;
        private System.Windows.Forms.ToolStripMenuItem MenuEx3;
        private System.Windows.Forms.ToolStripMenuItem MenuEx4;
        private System.Windows.Forms.ToolStripMenuItem MenuEx5;
    }
}

