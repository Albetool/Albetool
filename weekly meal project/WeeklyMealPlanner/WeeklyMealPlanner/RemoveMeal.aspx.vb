Public Class RemoveMeal
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Request.QueryString("id") Is Nothing Then

            Dim planID As Integer = Request.QueryString("id")

            Dim _context As MyDbContext = New MyDbContext()
            Dim item As WeeklyPlan = _context.WeeklyPlans.Find(planID)
            _context.WeeklyPlans.Remove(item)
            _context.SaveChanges()
        End If

        Response.Redirect("WeeklyPlanner.aspx")
    End Sub

End Class