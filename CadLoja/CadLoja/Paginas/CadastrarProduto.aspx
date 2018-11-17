<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarProduto.aspx.cs" Inherits="CadLoja.Paginas.Cadastrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Cadastro de Produtos<br />
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
            <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
            <br />
            <br />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </div>
    </form>
    <a href="ListarProduto.aspx">Visualizar</a>
    <a href="Home.html">Home</a>
</body>
</html>
