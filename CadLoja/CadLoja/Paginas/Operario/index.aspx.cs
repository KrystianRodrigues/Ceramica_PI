using CadLoja.App_Code.Persistencia;
using CadLoja.App_Code.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadLoja.Paginas.Operario
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(Session["ID"]);
            PessoaBD bd = new PessoaBD();
            Pessoa pessoa = bd.Select(codigo);
            if (!IsCliente(pessoa.Tipo))
            {
                Response.Redirect("../Erro/AcessoNegado.aspx");
            }
            else
            {
                lblTitulo.Text = "Bem vindo (Empregado) : " + pessoa.Nome;
            }
        }
        private bool IsCliente(int tipo)
        {
            bool retorno = false;
            if (tipo == 1)
            {
                retorno = true;
            }
            return retorno;
        }



        protected void lbSair_Click(object sender, EventArgs e)
        {
            {
                Session.Abandon();
                Session.Clear();
                Session.RemoveAll();
                Response.Redirect("../Login.aspx");
            }
        }
    }
}