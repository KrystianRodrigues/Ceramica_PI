using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CadLoja.Classes;
using CadLoja.App_Code.Persistencia;
using CadLoja.Persistencia;


namespace CadLoja.Paginas
{
    public partial class CadFornecedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Nome = txtNome.Text;
            fornecedor.Empresa = txtEmpresa.Text;
            fornecedor.Cnpj = txtCnpj.Text;
            fornecedor.Cell = txtCell.Text;
            fornecedor.Telefone = txtTelefone.Text;
            fornecedor.Cell = txtFornecedor.Text;
            fornecedor.Cell = txtFornecedor.Text;
            FornecedorBD bd = new FornecedorBD();
            if (bd.Insert(fornecedor))
            {
                lblMensagem.Text = "Fornecedor cadastrada com sucesso";
                txtTipo.Text = "";
                txtQuantidade.Text = "";
                txtMedidas.Text = "";
                txtFornecedor.Text = "";
                txtTipo.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }
        }
    }
}