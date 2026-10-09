using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teclou CTRL + C");
        }
        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teclou CTRL + V");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<FrmExercicio2>().Count() > 0)
            {
                Application.OpenForms["FrmExercicio2"].BringToFront();
            }
            else
            {
                FrmExercicio2 frm2 = new FrmExercicio2();
                frm2.MdiParent = this;
                frm2.WindowState = FormWindowState.Maximized;
                frm2.Show();
            }
        }
        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio3>().Count() > 0)
            {
                Application.OpenForms["FrmExercicio3"].BringToFront();
            }
            else
            {
                FrmExercicio3 frm3 = new FrmExercicio3();
                frm3.MdiParent = this;
                frm3.WindowState = FormWindowState.Maximized;
                frm3.Show();
            }
        }
        private void exercícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio4>().Count() > 0)
            {
                Application.OpenForms["FrmExercicio4"].BringToFront();
            }
            else
            {
                FrmExercicio4 frm4 = new FrmExercicio4();
                frm4.MdiParent = this;
                frm4.WindowState = FormWindowState.Maximized;
                frm4.Show();
            }
        }
        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio5>().Count() > 0)
            {
                Application.OpenForms["FrmExercicio5"].BringToFront();
            }
            else
            {
                FrmExercicio5 frm5 = new FrmExercicio5();
                frm5.MdiParent = this;
                frm5.WindowState = FormWindowState.Maximized;
                frm5.Show();
            }
        }
    }
}
