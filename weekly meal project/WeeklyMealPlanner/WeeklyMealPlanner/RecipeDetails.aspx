<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="RecipeDetails.aspx.vb" Inherits="WeeklyMealPlanner.RecipeDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Recipe Information</h1>
    </div>

    <div class="row">
        <div class="col-md-offset-left-4 col-md-4 col-md-offset-right-4">

            <h3>
                <asp:Label ID="lblTitle" runat="server"></asp:Label>
            </h3>
            <table class="table">

                <tr>
                    <th>Calories</th>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>Carbohydrates</th>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>Fat</th>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>Protein</th>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>
                </tr> 
                <tr>
                    <th>Very Healthy</th>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>
                </tr>
                
                <tr>
                    <th>Weight Watcher Smart Points</th>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>Spoonacular Score</th>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>Aggregate Likes</th>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>Ready In </th>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label> Minutes</td>
                </tr> 
            </table>

        </div>
    </div>
</asp:Content>
