<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserDescripcionPelicula.aspx.cs" Inherits="CinePapu.UserDescripcionPelicula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ListaPelis" runat="server">
    <div class="w3-container">

        <div class="w3-card w3-border-right w3-col m6">

            <asp:Image ID="ImagenPortada" runat="server" CssClass="w3-display-left w3-hover-blue" />

        </div>

        <div class="w3-col m6 ">
            <asp:Label ID="txtTitulo" runat="server" Text="Label">asd</asp:Label>
        </div>
    </div>

</asp:Content>
