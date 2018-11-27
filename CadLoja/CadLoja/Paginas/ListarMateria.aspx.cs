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
    public partial class ListarMateria : System.Web.UI.Page
    {

        private void Carrega()
        {
            MateriaBD bd = new MateriaBD();
            DataSet ds = bd.SelectAll();
            GridView1.DataSource = ds.Tables[0].DefaultView;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Carrega();
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