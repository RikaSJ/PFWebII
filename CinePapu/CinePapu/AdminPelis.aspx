<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminPelis.aspx.cs" Inherits="CinePapu.AdminPelis" %>
<asp:Content ID="TP" ContentPlaceHolderID="AdministradorPag" runat="server">
    <form id="form1" runat="server">
        <asp:GridView ID="GvPelis" runat="server" AllowPaging="True" AllowSorting="True" DataSourceID="Todo">
        </asp:GridView>
        <asp:ObjectDataSource ID="Todo" runat="server" SelectMethod="Todas" TypeName="CinePapu.Daos.PeliculaDao"></asp:ObjectDataSource>
    </form>
</asp:Content>
