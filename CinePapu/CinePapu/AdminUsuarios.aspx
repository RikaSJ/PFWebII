<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminUsuarios.aspx.cs" Inherits="CinePapu.AdminUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AdministradorPag" runat="server">
    <form id="form1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" DataSourceID="TodosU">
    </asp:GridView>
    <asp:ObjectDataSource ID="TodosU" runat="server" SelectMethod="Todos" TypeName="CinePapu.Daos.UsuariosDao"></asp:ObjectDataSource>
</form>
</asp:Content>
