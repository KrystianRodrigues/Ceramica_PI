<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadPerda.aspx.cs" Inherits="CadLoja.Paginas.CadPerda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Cadastro de Perdas<br />
            <br />
            Tipo
            <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
            <br />
            Quantidade
            <asp:TextBox ID="txtQuantidade" runat="server"></asp:TextBox>
            <br />
            Medidas
            <asp:TextBox ID="txtMedidas" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
            <br />
            <br />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </div>
    <a href="ListarPerda.aspx">Visualizar</a>
    <a href="Home.aspx">Home</a>
            <asp:LinkButton ID="lbSair" runat="server" OnClick="lbSair_Click">Sair</asp:LinkButton>
    </form>
    </body>
</html>
