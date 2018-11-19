using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteExemplo.Persistencia;
using System.Data;


namespace CadLoja.Paginas
{
    public partial class Listar : System.Web.UI.Page
    {

        private void Carrega()
        {
            ProdutoBD bd = new ProdutoBD();
            DataSet ds = bd.SelectAll();
            GridView1.DataSource = ds.Tables[0].DefaultView;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Carrega();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int codigo = 0;
            switch (e.CommandName)
            {
                case "Alterar":
                    codigo = Convert.ToInt32(e.CommandArgument);
                    Session["ID"] = codigo;
                    Response.Redirect("AlterarProduto.aspx");
                    break;
                case "Deletar":
                    codigo = Convert.ToInt32(e.CommandArgument);
                    ProdutoBD bd = new ProdutoBD();
                    bd.Delete(codigo);
                    Carrega();
                    break;
                default:
                    break;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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