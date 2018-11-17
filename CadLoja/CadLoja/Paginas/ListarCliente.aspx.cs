using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteExemplo.Persistencia;
using System.Data;

namespace CrudPi.Paginas
{
    public partial class Listar : System.Web.UI.Page
    {

        private void Carrega()
        {
            ClienteBD bd = new ClienteBD();
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

                case "Deletar":
                    codigo = Convert.ToInt32(e.CommandArgument);
                    ClienteBD bd = new ClienteBD();
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
    }
}