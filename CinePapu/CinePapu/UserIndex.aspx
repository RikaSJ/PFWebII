<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserIndex.aspx.cs" Inherits="CinePapu.UserIndex" %>
<asp:Content ID="ListaPelis" ContentPlaceHolderID="ListaPelis" runat="server">
    <h2>Index</h2> 

        <table>

            <tr>

                <th></th>

                <th>

                    Id

                </th>

                <th>

                    Title

                </th>

                <th>

                    Director

                </th>

                <th>

                    DateReleased

                </th>

            </tr> 

        <% foreach (var item in Model) { %>

            <tr>

                <td>

                    <%= Html.ActionLink("Edit", "Edit", new { id=item.Id }) %> |

                    <%= Html.ActionLink("Details", "Details", new { id=item.Id })%>

                </td>

                <td>

                    <%= Html.Encode(item.Id) %>

                </td>

                <td>

                    <%= Html.Encode(item.Title) %>

                </td>

                <td>

                    <%= Html.Encode(item.Director) %>

                </td>

                <td>

                    <%= Html.Encode(String.Format("{0:g}", item.DateReleased)) %>

                </td>

            </tr>

        <% } %> 

        </table> 

        <p>

            <%= Html.ActionLink("Create New", "Create") %>

        </p> 

        <!-- First Photo Grid
  <div class="w3-row-padding w3-padding-16 w3-center" id="food">
    <div class="w3-quarter">
      <img src="/w3images/sandwich.jpg" alt="Sandwich" style="width:100%"/>
      <h3>The Perfect Sandwich, A Real NYC Classic</h3>
      <p>Just some random text, lorem ipsum text praesent tincidunt ipsum lipsum.</p>
    </div>
  </div>-->
</asp:Content>
