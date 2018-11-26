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
            fornecedor.Cnpj = Convert.ToInt32(txtCnpj.Text);
            fornecedor.Cell = Convert.ToInt32(txtCelular.Text);
            fornecedor.Telefone = Convert.ToInt32(txtTelefone.Text);
            fornecedor.Endereco = txtEndereco.Text;
            fornecedor.Cep = Convert.ToInt32(txtCep.Text);
            fornecedor.Cidade = txtCidade.Text;
            fornecedor.Estado = txtEstado.Text;
            fornecedor.Email = txtEmail.Text;
            FornecedorBD bd = new FornecedorBD();
            if (bd.Insert(fornecedor))
            {
                lblMensagem.Text = "Fornecedor cadastrado com sucesso";
                txtNome.Text = "";
                txtEmpresa.Text = "";
                txtCnpj.Text = "";
                txtCelular.Text = "";
                txtTelefone.Text = "";
                txtEndereco.Text = "";
                txtCep.Text = "";
                txtCidade.Text = "";
                txtEstado.Text = "";
                txtEmail.Text = "";
                txtNome.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }
        }

        protected void lbSair_Click(object sender, EventArgs e)
        {
            {
                Session.Abandon();
                Session.Clear();
                Session.RemoveAll();
                Response.Redirect("Login.aspx");
            }
        }
    }
}