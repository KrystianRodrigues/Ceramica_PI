<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadFuncionario.aspx.cs" Inherits="CadLoja.Paginas.CadFuncionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Cadastro de Funcionario"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="CPF"></asp:Label>
            <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Telefone"></asp:Label>
            <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Celular"></asp:Label>
            <asp:TextBox ID="txtCell" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Endereço"></asp:Label>
            <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Cidade"></asp:Label>
            <asp:TextBox ID="txtCidade" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label9" runat="server" Text="Estado"></asp:Label>
            <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label10" runat="server" Text="CEP"></asp:Label>
            <asp:TextBox ID="txtCep" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label13" runat="server" Text="Permissão"></asp:Label>
            :
            <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label14" runat="server" Text="Senha inicial"></asp:Label>
            <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label11" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label12" runat="server" Text="Contrato"></asp:Label>
            <asp:TextBox ID="txtContrato" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
            <br />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
            <br />
            <br />
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Paginas/Home.aspx">Home</asp:HyperLink>
&nbsp;&nbsp;
            <asp:LinkButton ID="lbSair" runat="server" OnClick="lbSair_Click">Sair</asp:LinkButton>
    </form>
</body>
</html>
