using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteExemplo.Classes;
using WebSiteExemplo.Persistencia;

namespace CrudPi.Paginas
{
    public partial class Cadastrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Cep = txtCep.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Estado = txtEstado.Text;
            cliente.Email = txtEmail.Text;

            ClienteBD bd = new ClienteBD();
            if (bd.Insert(cliente))
            {
                lblMensagem.Text = "Funcionário cadastrado com sucesso";
                txtNome.Text = "";
                txtCpf.Text = "";
                txtTelefone.Text = "";
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