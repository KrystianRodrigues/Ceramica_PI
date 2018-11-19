<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlterarProduto.aspx.cs" Inherits="CadLoja.Paginas.Alterar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            |Alteração&nbsp; de Produtos<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descrição&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Quantidade&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtQuantidade" runat="server"></asp:TextBox>
            <br />
            Valor de Produção R$<asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
            <br />
&nbsp; Valor de venda R$&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtVenda" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" style="height: 26px" />
            <br />
            <br />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </div>
    <a href="ListarProduto.aspx">Visualizar</a>
    <a href="Home.aspx">Home</a>
            <asp:LinkButton ID="lbSair" runat="server" OnClick="lbSair_Click">Sair</asp:LinkButton>
    </form>
    </body>
</html>
