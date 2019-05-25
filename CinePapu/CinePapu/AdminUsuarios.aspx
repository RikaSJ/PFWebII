<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminUsuarios.aspx.cs" Inherits="CinePapu.AdminUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AdministradorPag" runat="server">
    <form id="form1" runat="server" style="margin-left: 40px">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:cinepapuConnectionStringInternet %>" DeleteCommand="DELETE FROM usuarios WHERE Email = ?" InsertCommand="INSERT INTO usuarios (Nombre, Email, Tipo, Contrasena) VALUES (?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:cinepapuConnectionStringInternet.ProviderName %>" SelectCommand="SELECT * FROM usuarios" UpdateCommand="UPDATE usuarios SET Nombre = ?, Tipo = ?, Contrasena = ? WHERE Email = ?">
            <DeleteParameters>
                <asp:Parameter Name="Email" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Tipo" Type="String" />
                <asp:Parameter Name="Contrasena" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Tipo" Type="String" />
                <asp:Parameter Name="Contrasena" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
</form>
</asp:Content>
