﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CadLoja.Paginas.Home" %>

<!DOCTYPE html>
<!--
Template Name: Shiphile
Author: <a href="https://www.os-templates.com/">OS Templates</a>
Author URI: https://www.os-templates.com/
Copyright: OS-Templates.com
Licence: Free to use under our free template licence terms
Licence URI: https://www.os-templates.com/template-terms
-->
<html lang="">
<!-- To declare your language - read more here: https://www.w3.org/International/questions/qa-html-language-declarations -->
<head>
    <title>Atelie da Le</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no">
    <link href="layout/styles/layout.css" rel="stylesheet" type="text/css" media="all">
</head>
<body id="top">
    
    <form id="form1" runat="server">
    
    <div class="bgded overlay" style="background-image:url('images/demo/backgrounds/01.png');">

        <div class="wrapper row0">
            
            <header id="header" class="hoc clear center">
                <!-- ################################################################################################ -->
                <h1 id="logo"> <a href="Home.aspx">Atelie da Le</a></h1>
                <!-- ################################################################################################ -->

            </header>
        </div>

        <div class="wrapper row1">
            <nav id="mainav" class="hoc clear">
                <ul class="clear">

                    <li>
                        <a class="drop" href="#">Cadastrar e Listar</a>
                        <ul>
                            <li><a href="CadastrarProduto.aspx">Produto</a></li>
                            <li><a href="CadMateria.aspx">Materia Prima</a></li>
                            <li><a href="CadPerda.aspx">Perda de Materia</a></li>
                            <li><a href="CadCliente.aspx">Cliente</a></li>
                            <li><a href="CadFornecedor.aspx">Fornecedores</a></li>
                            <li><a href="CadFuncionario.aspx">Funcionarios</a></li>
                            <li><a href="ListarProduto.aspx">Listar Produto</a></li>
                            <li><a href="ListarFornecedor.aspx">Listar Fornecedor</a></li>
                            <li><a href="ListarMateria.aspx">Listar Materia</a></li>
                            <li><a href="ListarPerda.aspx">Listar Perda </a></li>
                            <li><a href="ListarCliente.aspx">Listar Cliente</a></li>
                            <li><a href="Relatorios.aspx">Relatórios</a></li>
                        </ul>
                        

                    </li>

                  

                </ul>
            </nav>
            
        </div>

      
    </div>
        <script src="layout/scripts/jquery.min.js"></script>
        <script src="layout/scripts/jquery.backtotop.js"></script>
        <script src="layout/scripts/jquery.mobilemenu.js"></script>
        <p>
            <asp:LinkButton ID="lbSair" runat="server" OnClick="lbSair_Click">Sair</asp:LinkButton>
        </p>
    </form>
</body>
</html>
