<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarVenda.aspx.cs" Inherits="CadLoja.Paginas.CadastrarVenda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Data da Venda"></asp:Label>
            <br />
            <asp:TextBox ID="txtDataVenda" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Tipo de venda"></asp:Label>
            <br />
            <asp:TextBox ID="txtTipoVenda" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSalvar" Text="Salvar" runat="server" OnClick="btnSalvar_Click" />
            <br />
            <br />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
