using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CadLoja.App_Code.Classes;
using CadLoja.App_Code.Persistencia;
using System.Data;

namespace CadLoja.Paginas
{
    public partial class CadastrarVenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Venda venda= new Venda();
            venda.DataVenda = DateTime.Now;
            venda.TipoVenda = txtTipoVenda.Text;

            VendaBD bd = new VendaBD();

            if (bd.Insert(venda))
            {
                lblMensagem.Text = "Venda cadastrada com sucesso";

                txtDataVenda.Text = "";
                txtTipoVenda.Text = "";
                txtDataVenda.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }
        }
    }
}