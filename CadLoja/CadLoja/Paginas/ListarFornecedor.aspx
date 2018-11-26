<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarFornecedor.aspx.cs" Inherits="CadLoja.Paginas.ListarFornecedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          
            
            
            <asp:GridView ID="GridView1" runat="server">


            </asp:GridView>
          
            
            
        </div>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Paginas/Home.aspx">Home</asp:HyperLink>
&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Paginas/CadFornecedor.aspx">Cadastrar</asp:HyperLink>
&nbsp;<asp:LinkButton ID="lbSair" runat="server" OnClick="lbSair_Click">Sair</asp:LinkButton>
        </p>
    </form>
</body>
</html>
