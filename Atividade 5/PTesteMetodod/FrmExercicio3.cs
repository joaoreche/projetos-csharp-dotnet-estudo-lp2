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
    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
            MessageBox.Show(txtPalavra2.Text.ToString());
        }

        private void btnInverso_Click(object sender, EventArgs e)
        {
            string auxiliar = txtPalavra1.Text;
            char[] arr = auxiliar.ToCharArray();
            Array.Reverse(arr);

            auxiliar = "";
            foreach(char cara in arr)
            {
                auxiliar += cara.ToString();
            }
            MessageBox.Show(auxiliar);
        }
    }
}
