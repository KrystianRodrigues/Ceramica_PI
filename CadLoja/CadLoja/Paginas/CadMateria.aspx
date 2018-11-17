<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadMateria.aspx.cs" Inherits="CadLoja.Paginas.CadMateria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Cadastro de Materia Prima<br />
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
            Fornecedor
            <asp:TextBox ID="txtFornecedor" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
            <br />
            <br />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </div>
    </form>
    <a href="ListarMateria.aspx">Visualizar</a>
    <a href="Home.html">Home</a>
    
</body>
</html>
