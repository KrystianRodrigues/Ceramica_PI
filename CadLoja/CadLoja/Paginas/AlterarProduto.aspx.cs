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
    public partial class Alterar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ProdutoBD bd = new ProdutoBD();
                Produto produto = bd.Select(Convert.ToInt32(Session["ID"]));
                txtNome.Text = produto.Nome;
                txtQuantidade.Text = produto.Quantidade;
                txtValor.Text = produto.Valor.ToString();
                txtVenda.Text = produto.Venda.ToString();

            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoBD bd = new ProdutoBD();
            Produto produto = bd.Select(Convert.ToInt32(Session["ID"]));
            produto.Nome = txtNome.Text;
            produto.Quantidade = txtQuantidade.Text;
            produto.Valor = Convert.ToDouble(txtValor.Text);
            produto.Venda = Convert.ToDouble(txtVenda.Text);

            if (bd.Update(produto))
            {
                lblMensagem.Text = "Produto alterado com sucesso";
                txtNome.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }
        }
    }
}