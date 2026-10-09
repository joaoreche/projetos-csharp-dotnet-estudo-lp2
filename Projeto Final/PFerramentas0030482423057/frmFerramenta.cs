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
    public partial class frmFerramenta : Form
    {
        private BindingSource bnFerramenta = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsFerramenta = new DataSet();
        private DataSet dsCategoria = new DataSet();
        private DataSet dsFabricante = new DataSet();


        public frmFerramenta()
        {
            InitializeComponent();
        }

        private void frmFerramenta_Load(object sender, EventArgs e)
        {
            try
            {
                Ferramenta RegFerr = new Ferramenta();
                dsFerramenta.Tables.Add(RegFerr.Listar());
                bnFerramenta.DataSource = dsFerramenta.Tables["Ferramenta"];
                dgvFerramenta.DataSource = bnFerramenta;
                bnvFerramenta.BindingSource = bnFerramenta;

                txtId.DataBindings.Add("TEXT", bnFerramenta, "id");
                txtNome.DataBindings.Add("TEXT", bnFerramenta, "nome");
                cbxDistribuicao.DataBindings.Add("SelectedItem", bnFerramenta, "distribuicao");
                dtpCadastro.DataBindings.Add("TEXT", bnFerramenta, "dtcadastro");
                txtSiteOficial.DataBindings.Add("TEXT", bnFerramenta, "siteoficial");

                //carrega dados da Categoria
                Categoria RegCat = new Categoria();
                dsCategoria.Tables.Add(RegCat.Listar());
                cbxCategoria.DataSource = dsCategoria.Tables["Categoria"];
                cbxCategoria.DisplayMember = "descricao";
                cbxCategoria.ValueMember = "id";
                cbxCategoria.DataBindings.Add("SelectedValue", bnFerramenta, "idCategoria");

                //carrega dados do fabricante
                Fabricante RegFab = new Fabricante();
                dsFabricante.Tables.Add(RegFab.Listar());
                cbxFabricante.DataSource = dsFabricante.Tables["Fabricante"];
                cbxFabricante.DisplayMember = "nomefanstasia";
                cbxFabricante.ValueMember = "id";
                cbxFabricante.DataBindings.Add("SelectedValue", bnFerramenta, "idFabricante");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tbFerramenta.SelectedIndex == 0)
            {
                tbFerramenta.SelectTab(1);
            }

            bnFerramenta.AddNew();
            txtNome.Enabled = true;
            txtNome.Focus();
            txtSiteOficial.Enabled = true;
            cbxDistribuicao.Enabled = true;
            dtpCadastro.Enabled = true;
            cbxCategoria.Enabled = true;
            cbxFabricante.Enabled = true;

            cbxCategoria.SelectedIndex = 0;
            cbxFabricante.SelectedIndex = 0;
            cbxDistribuicao.SelectedIndex = 0;

            btnNovoRegistro.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = true;
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbFerramenta.SelectedIndex == 0)
            {
                tbFerramenta.SelectTab(1);
            }

            if (MessageBox.Show("Confirma Exclusão?", "Yes or No",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Ferramenta RegFerr = new Ferramenta();
                RegFerr.IdFerramenta = Convert.ToInt32(txtId.Text);

                if (RegFerr.Excluir() > 0)
                {
                    MessageBox.Show("Ferramenta excluída com sucesso!");
                    ;
                    dsFerramenta.Tables.Clear();
                    dsFerramenta.Tables.Add(RegFerr.Listar());
                    bnFerramenta.DataSource = dsFerramenta.Tables["Ferramenta"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir Ferramenta!");
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbFerramenta.SelectedIndex == 0)
            {
                tbFerramenta.SelectTab(1);
            }

            txtNome.Enabled = true;
            txtSiteOficial.Enabled = true;
            cbxDistribuicao.Enabled = true;
            dtpCadastro.Enabled = true;
            cbxCategoria.Enabled = true;
            cbxFabricante.Enabled = true;

            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || (txtNome.Text.Replace(" ", "").Length < 1))
            {
                MessageBox.Show("Nome Inválido!");
            }
            else if (cbxDistribuicao.SelectedIndex == -1)
            {
                MessageBox.Show("Distribuição Inválida!");
            }
            else if (txtSiteOficial.Text == "" || (txtSiteOficial.Text.Replace(" ", "").Length < 8))
            {
                MessageBox.Show("Site Oficial Inválido!");
            }
            else if (Convert.ToDateTime(dtpCadastro.Value) < DateTime.Today)
            {
                MessageBox.Show("Data Inválida!");
            }
            else if (cbxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Categoria Inválida!");
            }
            else if (cbxFabricante.SelectedIndex == -1)
            {
                MessageBox.Show("Fabricante Inválido!");
            }
            else
            {
                Ferramenta RegFerr = new Ferramenta();
                RegFerr.Nome = txtNome.Text;
                RegFerr.Distribuicao = Convert.ToChar(cbxDistribuicao.SelectedItem);
                RegFerr.DtCadastro = dtpCadastro.Value;
                RegFerr.SiteOficial = txtSiteOficial.Text;
                RegFerr.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue.ToString());
                RegFerr.IdFabricante = Convert.ToInt32(cbxFabricante.SelectedValue.ToString());

                if (bInclusao)
                {
                    if (RegFerr.Salvar() > 0)
                    {
                        MessageBox.Show("Ferramenta adicionada com sucesso!");

                        txtNome.Enabled = false;
                        txtSiteOficial.Enabled = false;
                        cbxDistribuicao.Enabled = false;
                        dtpCadastro.Enabled = false;
                        cbxCategoria.Enabled = false;
                        cbxFabricante.Enabled = false;

                        btnNovoRegistro.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;
                        bInclusao = false;

                        //recarrega o grid
                        dsFerramenta.Tables.Clear();
                        dsFerramenta.Tables.Add(RegFerr.Listar());
                        bnFerramenta.DataSource = dsFerramenta.Tables["Ferramenta"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar ferramenta!");
                    }
                }
                else //ALTERAÇÃO
                {
                    RegFerr.IdFerramenta = Convert.ToInt32(txtId.Text);

                    if (RegFerr.Alterar() > 0)
                    {
                        MessageBox.Show("Ferramenta alterada com sucesso!");

                        txtNome.Enabled = false;
                        txtSiteOficial.Enabled = false;
                        cbxDistribuicao.Enabled = false;
                        dtpCadastro.Enabled = false;
                        cbxCategoria.Enabled = false;
                        cbxFabricante.Enabled = false;

                        btnNovoRegistro.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;
                        bInclusao = false;

                        //recarrega o grid
                        dsFerramenta.Tables.Clear();
                        dsFerramenta.Tables.Add(RegFerr.Listar());
                        bnFerramenta.DataSource = dsFerramenta.Tables["FERRAMENTA"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar Ferramenta!");
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnFerramenta.CancelEdit();

            txtNome.Enabled = false;
            txtSiteOficial.Enabled = false;
            cbxDistribuicao.Enabled = false;
            dtpCadastro.Enabled = false;
            cbxCategoria.Enabled = false;
            cbxFabricante.Enabled = false;

            btnNovoRegistro.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;

            bInclusao = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
