<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadFornecedor.aspx.cs" Inherits="CadLoja.Paginas.CadFornecedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Label ID="lbl" runat="server" Text="Cadastro de Fornecedor"></asp:Label>
            <br />
            <asp:Label ID="lbl2" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl3" runat="server" Text="Empresa"></asp:Label>
            <asp:TextBox ID="txtEmpresa" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl4" runat="server" Text="CPNJ"></asp:Label>
            <asp:TextBox ID="txtCnpj" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl5" runat="server" Text="Celular"></asp:Label>
            <asp:TextBox ID="txtCelular" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl6" runat="server" Text="Telefone"></asp:Label>
            <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl7" runat="server" Text="Endereço"></asp:Label>
            <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl8" runat="server" Text="Cidade"></asp:Label>
            <asp:TextBox ID="txtCidade" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl9" runat="server" Text="Estado"></asp:Label>
            <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl10" runat="server" Text="CEP"></asp:Label>
            <asp:TextBox ID="txtCep" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl11" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
            <br />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </div>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Paginas/Home.aspx">Home</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Paginas/ListarFornecedor.aspx">Visualizar</asp:HyperLink>
&nbsp;<asp:LinkButton ID="lbSair" runat="server" OnClick="lbSair_Click">Sair</asp:LinkButton>
        </p>
    </form>
</body>
</html>
