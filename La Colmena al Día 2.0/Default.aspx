<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="La_Colmena_al_Día_2._0._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>
            <asp:Image ID="Image1" runat="server" ImageUrl="C:\Users\Admin\Downloads\LA COLMENA.png" Width="230px" Height="153px" />
&nbsp;<span style="font-size: 45pt">La Colmena al Día</span></h1>
        <p class="lead">Bienvenidos a la Colmena al Día, la página informativa favorita de la comunidad intecciana.</p>
        <p><a href="https://localhost:44341/About" class="Subir Noticias">Subir Noticias &raquo;</a></p>
        <p><a href="https://localhost:44341/Contact" class="Leer Noticias">Leer Noticias &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
        </div>
        <div class="col-md-4">
            <h2>&nbsp;</h2>
        </div>
    </div>

</asp:Content>
