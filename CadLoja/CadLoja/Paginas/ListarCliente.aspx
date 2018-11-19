<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarCliente.aspx.cs" Inherits="CrudPi.Paginas.Listar" %>

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
                        <asp:BoundField DataField="cli_codigo" HeaderText="ID" />
                        <asp:BoundField DataField="cli_nome" HeaderText="Nome" />
                        <asp:BoundField DataField="cli_cpf" HeaderText="CPF" />
                        <asp:BoundField DataField="cli_telefone" HeaderText="Telefone" />
                        <asp:BoundField DataField="cli_cep" HeaderText="CEP" />
                        <asp:BoundField DataField="cli_cidade" HeaderText="Cidade" />
                        <asp:BoundField DataField="cli_estado" HeaderText="Estado" />
                        <asp:BoundField DataField="cli_email" HeaderText="Email" />
                        <asp:TemplateField HeaderText="Deletar">
                             <ItemTemplate>
                             <asp:LinkButton ID="lbDeletar" runat="server" CommandName="Deletar"
                            CommandArgument='<%# Bind("cli_codigo")%>'>Excluir</asp:LinkButton>
                             </ItemTemplate>
                       </asp:TemplateField>
                  
                </Columns>

            </asp:GridView>
            
        </div>
    <a href="CadCliente.aspx">Novo</a>
    <a href="Home.aspx">Home</a>
            <asp:LinkButton ID="lbSair" runat="server" OnClick="lbSair_Click">Sair</asp:LinkButton>
    </form>
    </body>
</html>
