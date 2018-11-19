using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteExemplo.Classes;
using WebSiteExemplo.Persistencia;

namespace CadLoja.Paginas
{
    public partial class CadPerda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Perda perda = new Perda();
            perda.Tipo = txtTipo.Text;
            perda.Quantidade = txtQuantidade.Text;
            perda.Medidas = txtMedidas.Text;
            PerdaBD bd = new PerdaBD();
            if (bd.Insert(perda))
            {
                lblMensagem.Text = "Perda cadastrada com sucesso";
                txtTipo.Text = "";
                txtQuantidade.Text = "";
                txtMedidas.Text = "";
                txtTipo.Focus();
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