<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Relatorios.aspx.cs" Inherits="CadLoja.Paginas.Relatórios" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource2">
                <series>
                    <asp:Series Name="Series1">
                        <Points>
                            <asp:DataPoint YValues="7" />
                            <asp:DataPoint YValues="5" />
                            <asp:DataPoint YValues="3" />
                            <asp:DataPoint YValues="13" />
                            <asp:DataPoint YValues="8" />
                            <asp:DataPoint YValues="0" />
                        </Points>
                    </asp:Series>
                    <asp:Series ChartArea="ChartArea2" ChartType="Bar" Name="BarChart">
                        <Points>
                            <asp:DataPoint YValues="1" />
                            <asp:DataPoint YValues="2" />
                            <asp:DataPoint YValues="4" />
                            <asp:DataPoint YValues="8" />
                            <asp:DataPoint YValues="0" />
                        </Points>
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                    <asp:ChartArea Name="ChartArea2">
                    </asp:ChartArea>
                </chartareas>
            </asp:Chart>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            <br />
        </div>
        <p>
            <asp:Label ID="lblTitulo" runat="server" Text="Administrador"></asp:Label>
        </p>
    </form>
</body>
</html>
