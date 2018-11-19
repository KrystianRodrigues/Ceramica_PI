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
    public partial class CadMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Materia materia = new Materia();
            materia.Tipo = txtTipo.Text;
            materia.Quantidade = txtQuantidade.Text;
            materia.Medidas = txtMedidas.Text;
            materia.Fornecedor = txtFornecedor.Text;
            MateriaBD bd = new MateriaBD();
            if (bd.Insert(materia))
            {
                lblMensagem.Text = "Materia Prima cadastrada com sucesso";
                txtTipo.Text = "";
                txtQuantidade.Text = "";
                txtMedidas.Text = "";
                txtFornecedor.Text = "";
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