<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarMateria.aspx.cs" Inherits="CadLoja.Paginas.ListarMateria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="mat_codigo" HeaderText="ID" />
                    <asp:BoundField DataField="mat_tipo" HeaderText="Tipo" />
                    <asp:BoundField DataField="mat_quantidade" HeaderText="Quantidade" />
                    <asp:BoundField DataField="mat_medidas" HeaderText="Medidas" />
                    <asp:BoundField DataField="mat_fornecedor" HeaderText="Fornecedor" />
                </Columns>
            </asp:GridView>
        </div>
    <a href="CadMateria.aspx">Cadastrar</a>
    <a href="Home.aspx">Home</a>
            <asp:LinkButton ID="lbSair" runat="server" OnClick="lbSair_Click">Sair</asp:LinkButton>
    </form>
    </body>
</html>
