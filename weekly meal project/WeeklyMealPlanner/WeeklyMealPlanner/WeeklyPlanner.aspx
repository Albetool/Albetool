<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="WeeklyPlanner.aspx.vb" Inherits="WeeklyMealPlanner.WeeklyPlanner" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Free Weekly Meal Planner</h1>

    <div class="month">
        <ul>
            <li class="prev">
                <asp:LinkButton ID="lbtnPrev" runat="server" OnClick="lbtnPrev_Click">&#10094;</asp:LinkButton></li>
            <li class="next">
                <asp:LinkButton ID="lbtnNext" runat="server" OnClick="lbtnNext_Click">&#10095;</asp:LinkButton></li>
            <li><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br>
                <span style="font-size: 18px">Weekly plan</span>
            </li>
        </ul>
    </div>
    <asp:Panel ID="MyPanel" runat="server">
    <table>
        <tr>
            <th style="width: 2% !important;"></th>
            <th>Sunday</th>
            <th>Monday</th>
            <th>Tuesday</th>
            <th>Wednesday</th>
            <th>Thursday</th>
            <th>Friday</th>
            <th>Saturday</th>
        </tr>
        <tr>
            <td style="width: 2% !important; transform: rotate(-90deg);">MORNING</td>
            <td><asp:Label ID="Label11" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton11" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
            <td><asp:Label ID="Label21" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton21" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
            <td><asp:Label ID="Label31" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton31" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
            <td><asp:Label ID="Label41" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton41" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
            <td><asp:Label ID="Label51" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton51" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
            <td><asp:Label ID="Label61" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton61" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
            <td><asp:Label ID="Label71" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton71" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
        </tr>
        <tr>
            <td style="width: 2% !important; transform: rotate(-90deg);">NOON</td>
            <td><asp:Label ID="Label12" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton12" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
            <td><asp:Label ID="Label22" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton22" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
            <td><asp:Label ID="Label32" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton32" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
            <td><asp:Label ID="Label42" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton42" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
            <td><asp:Label ID="Label52" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton52" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
            <td><asp:Label ID="Label62" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton62" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
            <td><asp:Label ID="Label72" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton72" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
        </tr>
        <tr>
            <td style="width: 2% !important; transform: rotate(-90deg);">EVENING</td>
            <td><asp:Label ID="Label13" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton13" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
            <td><asp:Label ID="Label23" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton23" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
            <td><asp:Label ID="Label33" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton33" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
            <td><asp:Label ID="Label43" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton43" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
            <td><asp:Label ID="Label53" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton53" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
            <td><asp:Label ID="Label63" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton63" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
            <td><asp:Label ID="Label73" runat="server" Visible="false"></asp:Label><asp:LinkButton ID="LinkButton73" runat="server" OnClick="LinkButtonAll_Click"><i class="glyphicon glyphicon-plus"></i>Meal</asp:LinkButton></td>
        </tr>
    </table>
</asp:Panel>
</asp:Content>
