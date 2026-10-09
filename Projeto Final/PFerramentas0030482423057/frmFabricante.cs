using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFerramentas0030482423057
{
    public partial class frmFabricante : Form
    {
        private BindingSource bnFabricante = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsFabricante = new DataSet();

        public frmFabricante()
        {
            InitializeComponent();
        }

        private void frmFabricante_Load(object sender, EventArgs e)
        {
            try
            {
                Fabricante RegFab = new Fabricante();
                dsFabricante.Tables.Add(RegFab.Listar());
                bnFabricante.DataSource = dsFabricante.Tables["Fabricante"];
                dgvFabricante.DataSource = bnFabricante;
                bnvFabricante.BindingSource = bnFabricante;

                txtId.DataBindings.Add("TEXT", bnFabricante, "ID");
                txtNomeFantasia.DataBindings.Add("TEXT", bnFabricante, "NOMEFANTASIA");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tbFabricante.SelectedIndex == 0)
            {
                tbFabricante.SelectTab(1);
            }

            bnFabricante.AddNew();
            txtNomeFantasia.Enabled = true;
            txtNomeFantasia.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbFabricante.SelectedIndex == 0)
            {
                tbFabricante.SelectTab(1);
            }

            if (MessageBox.Show("Confirma Exclusão?", "Yes or No",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Fabricante RegFab = new Fabricante();
                RegFab.IdFabricante = Convert.ToInt16(txtId.Text);

                if (RegFab.Excluir() > 0)
                {
                    MessageBox.Show("Fabricante excluído com sucesso!");

                    Fabricante R = new Fabricante();
                    dsFabricante.Tables.Clear();
                    dsFabricante.Tables.Add(R.Listar());
                    bnFabricante.DataSource = dsFabricante.Tables["FABRICANTE"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir fabricante!");
                }
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbFabricante.SelectedIndex == 0)
            {
                tbFabricante.SelectTab(1);
            }

            txtNomeFantasia.Enabled = true;
            txtNomeFantasia.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeFantasia.Text == "" || (txtNomeFantasia.Text.Replace(" ", "").Length < 2))
            {
                MessageBox.Show("Fabricante Inválido!");
            }
            else
            {
                Fabricante RegFab = new Fabricante();
                RegFab.IdFabricante = Convert.ToInt16(txtId.Text);
                RegFab.NomeFantasia = txtNomeFantasia.Text;
                if (bInclusao)
                {
                    if (RegFab.Salvar() > 0)
                    {
                        MessageBox.Show("Fabricante adicionado com sucesso!");

                        txtId.Enabled = false;
                        txtNomeFantasia.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                        bInclusao = false;

                        //recarrega o grid
                        dsFabricante.Tables.Clear();
                        dsFabricante.Tables.Add(RegFab.Listar());
                        bnFabricante.DataSource = dsFabricante.Tables["FABRICANTE"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar fabricante!");
                    }
                }
                else //ALTERAÇÃO
                {
                    if (RegFab.Alterar() > 0)
                    {
                        MessageBox.Show("Fabricante alterada com sucesso!");

                        txtId.Enabled = false;
                        txtNomeFantasia.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        //recarrega o grid
                        dsFabricante.Tables.Clear();
                        dsFabricante.Tables.Add(RegFab.Listar());
                        bnFabricante.DataSource = dsFabricante.Tables["FABRICANTE"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar fabricante!");
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnFabricante.CancelEdit();

            txtNomeFantasia.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;

            bInclusao = false;
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
