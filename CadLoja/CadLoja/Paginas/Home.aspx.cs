﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadLoja.Paginas
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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