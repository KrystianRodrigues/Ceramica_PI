using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CadLoja.App_Code.Classes;
using CadLoja.App_Code.Persistencia;
using WebSiteExemplo.Classes;
using WebSiteExemplo.Persistencia;

namespace CadLoja.Paginas
{
    public partial class CadFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Cpf = Convert.ToInt32(txtCpf.Text);
            funcionario.Nome = txtNome.Text;
            funcionario.Telefone = txtTelefone.Text;
            funcionario.Cell = txtCell.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Estado = txtEstado.Text;
            funcionario.Cep = txtCep.Text;
            funcionario.Tipo = Convert.ToInt32(txtTipo.Text);
            funcionario.Senha = Convert.ToInt32(txtSenha.Text);
            funcionario.Email = txtEmail.Text;
            funcionario.Contrato = txtContrato.Text;
            FuncionarioBD bd = new FuncionarioBD();
            if (bd.Insert(funcionario))
            {
                lblMensagem.Text = "Funcionário cadastrado com sucesso";
                txtCpf.Text = "";
                txtNome.Text = "";
                txtTelefone.Text = "";
                txtCell.Text = "";
                txtEndereco.Text = "";
                txtCidade.Text = "";
                txtEstado.Text = "";
                txtCep.Text = "";
                txtTipo.Text = "";
                txtSenha.Text = "";
                txtEmail.Text = "";
                txtContrato.Text = "";
                txtCpf.Focus();
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