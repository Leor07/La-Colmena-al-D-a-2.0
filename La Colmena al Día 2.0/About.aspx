<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="La_Colmena_al_Día_2._0.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Sube Noticias</h3>
    <p>Título</p>
    <p>&nbsp;
        <asp:TextBox ID="txtTitulo" runat="server" Width="414px"></asp:TextBox>
    </p>
    <p>&nbsp;Detalle</p>
    <p>
        <asp:TextBox ID="txtDetalle" runat="server" Height="98px" Width="414px"></asp:TextBox>
    </p>
    <p>Imagen&nbsp;
        <asp:FileUpload ID="fuImagen" runat="server" Width="461px" />
    </p>
    <p>
        <asp:Image ID="imgFoto" runat="server" Height="150px" Width="185px" />
        <asp:Label ID="lblCelebridad" runat="server" AssociatedControlID="fuImagen"></asp:Label>
    </p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    </p>
    <p>Categoría</p>
    <p>
        <asp:DropDownList ID="ddlCategoria" runat="server" Width="399px">
            <asp:ListItem>-</asp:ListItem>
            <asp:ListItem>Profesores</asp:ListItem>
            <asp:ListItem>Actividades</asp:ListItem>
            <asp:ListItem>Estudiantes</asp:ListItem>
            <asp:ListItem>Institucionales</asp:ListItem>
            <asp:ListItem>Vida Estudiantil</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
    </p>
    </asp:Content>
