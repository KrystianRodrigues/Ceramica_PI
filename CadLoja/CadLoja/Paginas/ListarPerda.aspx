<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarPerda.aspx.cs" Inherits="CadLoja.Paginas.ListarPerda" %>

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
                    <asp:BoundField DataField="per_codigo" HeaderText="ID" />
                    <asp:BoundField DataField="per_tipo" HeaderText="Descrição" />
                    <asp:BoundField DataField="per_quantidade" HeaderText="Quantidade" />
                    <asp:BoundField DataField="per_medidas" HeaderText="Medidas" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
    <a href="CadPerda.aspx">Cadastrar</a>
    <a href="Home.html">Home</a>
</body>
</html>
