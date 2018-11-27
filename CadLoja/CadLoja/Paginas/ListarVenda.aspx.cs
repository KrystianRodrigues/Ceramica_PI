using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CadLoja.App_Code.Persistencia;

namespace CadLoja.Paginas
{
    public partial class ListarVenda : System.Web.UI.Page
    {
        private void Carrega()
        {
            VendaBD bd = new VendaBD();
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