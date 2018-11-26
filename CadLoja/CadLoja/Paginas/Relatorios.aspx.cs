using CadLoja.App_Code.Classes;
using CadLoja.App_Code.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadLoja.Paginas
{
    public partial class Relatórios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int codigo = Convert.ToInt32(Session["ID"]);
            PessoaBD bd = new PessoaBD();
            Pessoa pessoa = bd.Select(codigo);
            if (!IsAdministrador(pessoa.Tipo))
            {
                Response.Redirect("Erro/AcessoNegado.aspx");
            }
            else
            {
                lblTitulo.Text = "Bem vindo (Administrador) : " + pessoa.Nome;
            }
        }
        private bool IsAdministrador(int tipo)
        {
            bool retorno = false;
            if (tipo == 0)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}