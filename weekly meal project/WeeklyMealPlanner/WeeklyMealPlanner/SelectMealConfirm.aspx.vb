Imports Microsoft.AspNet.Identity.EntityFramework

Public Class SelectMealConfirm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Context.User.Identity.IsAuthenticated Then
            Response.Redirect("~/Account/Login.aspx")
        End If
                     
        Dim userId = Context.User.Identity.Name


        If IsNothing(Session("MealID")) Or IsNothing(Session("weekid")) Or IsNothing(Request.QueryString("id")) Then
            Response.Redirect("WeeklyPlanner.aspx")
        End If

        Dim recipeID As Integer = Request.QueryString("id")
        Dim MealID As String = Session("MealID")
        Dim weekid As String = Session("weekid")


        Dim _weeklyPlan As WeeklyPlan = New WeeklyPlan()
        _weeklyPlan.MealId = MealID
        _weeklyPlan.UserId = userId
        _weeklyPlan.WeekID = weekid
        _weeklyPlan.RecipeID = recipeID

        Dim _context As MyDbContext = New MyDbContext()
        _context.WeeklyPlans.Add(_weeklyPlan)
        _context.SaveChanges()

        Response.Redirect("WeeklyPlanner.aspx")
    End Sub

End Class