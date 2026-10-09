using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PFerramentas0030482423057
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=LEONARDO\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True;");

                //Chave de conexao
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados = /" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros Erros = /" + ex.Message);
            }
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCategoria>().Count() > 0)
            {
                Application.OpenForms["frmCategoria"].BringToFront();// form existe traz ele para a frente
            }

            else
            {
                frmCategoria obj1 = new frmCategoria(); // crio o objeto do novo formulario
                obj1.MdiParent = this;
                obj1.WindowState = FormWindowState.Maximized;
                obj1.Show();
            }
        }

        private void fabricantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFabricante>().Count() > 0)
            {
                Application.OpenForms["frmFabricante"].BringToFront();// form existe traz ele para a frente
            }

            else
            {
                frmFabricante obj2 = new frmFabricante(); // crio o objeto do novo formulario
                obj2.MdiParent = this;
                obj2.WindowState = FormWindowState.Maximized;
                obj2.Show();
            }
        }

        private void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFerramenta>().Count() > 0)
            {
                Application.OpenForms["frmFerramenta"].BringToFront();// form existe traz ele para a frente
            }

            else
            {
                frmFerramenta obj3 = new frmFerramenta(); // crio o objeto do novo formulario
                obj3.MdiParent = this;
                obj3.WindowState = FormWindowState.Maximized;
                obj3.Show();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSobre>().Count() > 0)
            {
                Application.OpenForms["frmSobre"].BringToFront();// form existe traz ele para a frente
            }

            else
            {
                frmSobre obj4 = new frmSobre(); // crio o objeto do novo formulario
                obj4.MdiParent = this;
                obj4.WindowState = FormWindowState.Maximized;
                obj4.Show();
            }
        }
    }    
}