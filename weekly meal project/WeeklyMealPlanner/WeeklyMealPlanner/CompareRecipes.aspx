<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="CompareRecipes.aspx.vb" Inherits="WeeklyMealPlanner.CompareRecipes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Compare</h1>
    </div>

    <div class="row">

        <div class="col-md-4">
                 <h2>Search recipes</h2>
             
            <p>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="input" Style="width: 100%; padding: 5px;" placeholder="Recipe Name ..."></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnSearch1" runat="server" CssClass="btn btn-primary btn-sm" Text="Search" />
            </p>
            <p>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>
            </p>
            
            <p>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="input" Style="width: 100%; padding: 5px;" placeholder="Recipe Name ..."></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnSearch2" runat="server" CssClass="btn btn-primary btn-sm" Text="Search" />
            </p>
            <p>
                <asp:RadioButtonList  ID="RadioButtonList2" runat="server"></asp:RadioButtonList>
            </p>

            <p>
                
                <asp:Button ID="btnCompare" runat="server" CssClass="btn btn-success btn-large" Text="Compare recipes &raquo;" />
            </p>
        </div>

        <div class="col-md-8" runat="server" id="resultTable" visible="false">
             
            <table class="table">

                <tr>
                    <th></th>
                    <td>
                        <h3>
                            <asp:Label ID="lblTitle" runat="server"></asp:Label>
                        </h3>
                    </td>
                    <td>
                        <h3>
                            <asp:Label ID="lblTitlea" runat="server"></asp:Label>
                        </h3>
                    </td>
                </tr>
                <tr>
                    <th>Calories</th>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
                    <td>
                        <asp:Label ID="Label1a" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>Carbohydrates</th>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
                    <td>
                        <asp:Label ID="Label2a" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>Fat</th>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
                    <td>
                        <asp:Label ID="Label3a" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>Protein</th>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>
                    <td>
                        <asp:Label ID="Label4a" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>Very Healthy</th>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>
                    <td>
                        <asp:Label ID="Label5a" runat="server" Text="Label"></asp:Label></td>
                </tr>

                <tr>
                    <th>Weight Watcher Smart Points</th>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></td>
                    <td>
                        <asp:Label ID="Label6a" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>Spoonacular Score</th>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></td>
                    <td>
                        <asp:Label ID="Label7a" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>Aggregate Likes</th>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></td>
                    <td>
                        <asp:Label ID="Label8a" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <th>Ready In </th>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                        Minutes</td>
                    <td>
                        <asp:Label ID="Label9a" runat="server" Text="Label"></asp:Label>
                        Minutes</td>
                </tr>
                <tr>
                    <th></th>
                    <td>
                        <asp:Label ID="LabelTotal1" runat="server" Text="Label"></asp:Label></td>
                    <td>
                        <asp:Label ID="LabelTotal2" runat="server" Text="Label"></asp:Label></td>
                </tr>
            </table>

        </div>
    </div>
     

</asp:Content>
