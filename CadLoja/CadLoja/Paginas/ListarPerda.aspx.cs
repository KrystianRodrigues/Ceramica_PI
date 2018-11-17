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
    public partial class ListarPerda : System.Web.UI.Page
    {
        private void Carrega()
        {
            PerdaBD bd = new PerdaBD();
            DataSet ds = bd.SelectAll();
            GridView1.DataSource = ds.Tables[0].DefaultView;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Carrega();
        }
    }
}