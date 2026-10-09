using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ploops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio1>().Count() > 0)
            {
                Application.OpenForms["frmExercicio1"].BringToFront(); // form existe traz ele para a frente
            }
            else
            {
                frmExercicio1 frm1 = new frmExercicio1(); // crio o objeto do novo formulario
                frm1.MdiParent = this;
                frm1.WindowState = FormWindowState.Maximized;
                frm1.Show();
            }
        }
        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio2>().Count() > 0)
            {
                Application.OpenForms["frmExercicio2"].BringToFront(); // form existe traz ele para a frente
            }
            else
            {
                frmExercicio2 frm2 = new frmExercicio2(); // crio o objeto do novo formulario
                frm2.MdiParent = this;
                frm2.WindowState = FormWindowState.Maximized;
                frm2.Show();
            }
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio3>().Count() > 0)
            {
                Application.OpenForms["frmExercicio3"].BringToFront(); // form existe traz ele para a frente
            }
            else
            {
                frmExercicio3 frm3 = new frmExercicio3(); // crio o objeto do novo formulario
                frm3.MdiParent = this;
                frm3.WindowState = FormWindowState.Maximized;
                frm3.Show();
            }
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                Application.OpenForms["frmExercicio4"].BringToFront(); // form existe traz ele para a frente
            }
            else
            {
                frmExercicio4 frm4 = new frmExercicio4(); // crio o objeto do novo formulario
                frm4.MdiParent = this;
                frm4.WindowState = FormWindowState.Maximized;
                frm4.Show();
            }
        }

        private void saírToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
