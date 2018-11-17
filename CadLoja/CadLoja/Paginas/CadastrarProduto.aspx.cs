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
    public partial class Cadastrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Nome = txtNome.Text;
            produto.Quantidade = txtQuantidade.Text;
            produto.Valor = Convert.ToDouble(txtValor.Text);
            produto.Venda = Convert.ToDouble(txtVenda.Text);
            ProdutoBD bd = new ProdutoBD();
            if (bd.Insert(produto))
            {
                lblMensagem.Text = "Produto cadastrado com sucesso";
                txtNome.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
                txtVenda.Text = "";
                txtNome.Focus();
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }
        }
    }
}