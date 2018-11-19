<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarProduto.aspx.cs" Inherits="CadLoja.Paginas.Listar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                 <Columns>
                         <asp:BoundField DataField="pro_codigo" HeaderText="ID" />
                         <asp:BoundField DataField="pro_nome" HeaderText="Descrição" />
                         <asp:BoundField DataField="pro_quantidade" HeaderText="Quantidade" />
                         <asp:BoundField DataField="pro_valor" HeaderText="Valor de Produção" />
                         <asp:BoundField DataField="pro_venda" HeaderText="Valor de Venda" />
                         <asp:TemplateField HeaderText="Alterar">
                         <ItemTemplate>
                         <asp:LinkButton ID="lbAlterar" runat="server" CommandName="Alterar"
                        CommandArgument='<%# Bind("pro_codigo")%>'>Alterar</asp:LinkButton>
                         </ItemTemplate>
                         </asp:TemplateField>
                         <asp:TemplateField HeaderText="Deletar">
                         <ItemTemplate>
                         <asp:LinkButton ID="lbDeletar" runat="server" CommandName="Deletar"
                        CommandArgument='<%# Bind("pro_codigo")%>'>Excluir</asp:LinkButton>
                         </ItemTemplate>
                         </asp:TemplateField>
                 </Columns>
                 </asp:GridView> 
        </div>
    <a href="CadastrarProduto.aspx">Cadastrar Novo</a>
    <a href="Home.aspx">Home</a>
            <asp:LinkButton ID="lbSair" runat="server" OnClick="lbSair_Click">Sair</asp:LinkButton>
    </form>
    </body>
</html>
