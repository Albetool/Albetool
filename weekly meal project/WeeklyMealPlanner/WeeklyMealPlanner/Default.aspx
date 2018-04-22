<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WeeklyMealPlanner._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div class="jumbotron">
        <h1>Healthy Meals Planner</h1>
        <p class="lead">mealplanner.com is a free web site for helping people plan there weekly meals.</p>
         
    </div>

    <div class="row">
        <div class="col-md-12">
            <h2>Plan your weekly meals</h2>
            <p>
                This is the service that matches recipes to daily calories. you can choose your daily meals to plan your week.
            </p>
            <p>
                <a class="btn btn-primary btn-large" href="WeeklyPlanner.aspx">Plan your weekly meals &raquo;</a>
            </p>
        </div> 
    </div>

</asp:Content>
