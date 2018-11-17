<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadCliente.aspx.cs" Inherits="CrudPi.Paginas.Cadastrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Cadastro de Clientes<br />
        <br />
        Nome&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
        CPF&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
        <br />
        Telefone
        <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
        <br />
        CEP&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCep" runat="server"></asp:TextBox>
        <br />
        Cidade&nbsp;&nbsp;
        <asp:TextBox ID="txtCidade" runat="server"></asp:TextBox>
        <br />
        Estado&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
        <br />
        Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
        <br />
        <br />
        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
    </form>
    <a href="ListarCliente.aspx">Visualizar</a>
    <a href="Home.html">Home</a>
</body>
</html>
