<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserDescripcionPelicula.aspx.cs" Inherits="CinePapu.UserDescripcionPelicula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ListaPelis" runat="server">
    <div class="w3-container">
        <div class="w3-row w3-padding-64" id="about">
            <div class="w3-col m6 w3-padding-large w3-hide-small">
                <asp:Image ID="ImagenPeli" runat="server" class="w3-round w3-image " alt="Table Setting" Width="600" Height="750" />
            </div>

            <div class="w3-col m6 w3-padding-large ">
                <div class="w3-left-align">
                    <asp:Label ID="txtTitulo" runat="server" Text="Label"></asp:Label>
                </div>
                <br />
                <div class="w3-left-align">
                    <asp:Label ID="txtAno" runat="server" Text="Label"></asp:Label>
                </div>
                <br />
                <div class="w3-left-align">
                    <asp:Label ID="txtDescripcion" runat="server" Text="Label"></asp:Label>
                </div>

                <div class="w3-display-topright ">

                    Like 
                </div>

            </div>
        </div>
        <hr />
        <div class="w3-container w3-center">
        <iframe id="UrlPeli" width="720" height="420" frameborder="0" allowfullscreen runat="server" ></iframe>
            </div>

        <hr />
        <div class="w3-row ">
            <div class="w3-col m1 w3-border-aqua">
                <img src="img/usuario-sin-foto.png" style="width:75%" class="w3-centered"/>
            </div>
            <div class="w3-col m11 w3-bordered w3-centered">
                <div class="w3-centered">
                    <form runat="server">
            <textarea id="txtComentario"  class="w3-input" placeholder="Comentario..." runat="server"></textarea>
                    <asp:Button ID="btnCComentar" Class="w3-button w3-right w3-indigo" runat="server" Text="Enviar comentario" OnClick="btnCComentar_Click" />
                    </form>
                    <div class="w3-row">
                        <hr />
                       
                        
                        
                            <asp:Literal ID="LiteralComentarios" runat="server"></asp:Literal>
                            


                        
                    </div>

    </div>
</asp:Content>
