<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminPelis.aspx.cs" Inherits="CinePapu.AdminPelis" %>
<asp:Content ID="TP" ContentPlaceHolderID="AdministradorPag" runat="server">
    <div class="w3-main w3-content w3-padding" style="max-width:1200px;margin-top:100px">
    <form id="form1" runat="server">
        <asp:GridView ID="GvPelis" runat="server" AllowPaging="True" AllowSorting="True" DataSourceID="SqlDataSource1" >
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:cinepapuConnectionStringInternet %>" DeleteCommand="DELETE FROM peliculas WHERE Nombre = ?" InsertCommand="INSERT INTO peliculas] (Nombre, Descripccion, Autor, Ano, Genero, UrlVideo, UrlImagen) VALUES (?, ?, ?, ?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:cinepapuConnectionStringInternet.ProviderName %>" SelectCommand="SELECT * FROM peliculas" UpdateCommand="UPDATE peliculas SET Descripccion = ?, Autor = ?, Ano = ?, Genero = ?, UrlVideo = ?, UrlImagen = ? WHERE Nombre = ?">
            <DeleteParameters>
                <asp:Parameter Name="Nombre" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Descripccion" Type="String" />
                <asp:Parameter Name="Autor" Type="String" />
                <asp:Parameter Name="Ano" Type="String" />
                <asp:Parameter Name="Genero" Type="String" />
                <asp:Parameter Name="UrlVideo" Type="String" />
                <asp:Parameter Name="UrlImagen" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Descripccion" Type="String" />
                <asp:Parameter Name="Autor" Type="String" />
                <asp:Parameter Name="Ano" Type="String" />
                <asp:Parameter Name="Genero" Type="String" />
                <asp:Parameter Name="UrlVideo" Type="String" />
                <asp:Parameter Name="UrlImagen" Type="String" />
                <asp:Parameter Name="Nombre" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
        </div>
</asp:Content>
