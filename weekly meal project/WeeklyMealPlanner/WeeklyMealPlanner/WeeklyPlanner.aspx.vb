Public Class WeeklyPlanner
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim weekId As String = ""
        Dim weeklabel As String = ""
        If Not Page.IsPostBack Then
            If (IsNothing(Session("weekid"))) Then

                Dim now As DateTime = DateTime.Now
                If Not now.DayOfWeek = DayOfWeek.Sunday Then
                    While Not now.DayOfWeek = DayOfWeek.Sunday
                        now = now.AddDays(-1)

                    End While
                End If
                weekId = now.ToString("MM-dd-yyyy")
                weeklabel = now.ToString("dd-MM-yyyy") & " TO "
                weekId = weekId & now.AddDays(6).ToString("MM-dd-yyyy")
                weeklabel = weeklabel & now.AddDays(6).ToString("dd-MM-yyyy")
                Session("weekid") = weekId
                Session("weeklabel") = weeklabel

                Label1.Text = weeklabel

            End If

            resetPanel()

            weekId = Session("weekid")
            weeklabel = Session("weeklabel")
            Label1.Text = weeklabel

            If Context.User.Identity.IsAuthenticated Then

                Dim userId = Context.User.Identity.Name


                Dim _context As MyDbContext = New MyDbContext()
                Dim _list As List(Of WeeklyPlan) = _context.WeeklyPlans.Where(Function(a) a.WeekID = weekId And a.UserId = userId).ToList()

                For Each item As WeeklyPlan In _list

                    Dim btnName As String = "LinkButton" & item.MealId
                    Dim lblName As String = "Label" & item.MealId
                    Dim recipeID As String = item.RecipeID
                    For Each btn As LinkButton In MyPanel.Controls.OfType(Of LinkButton)()
                        If btn.ID = btnName Then
                            btn.Visible = False
                        End If
                    Next


                    For Each lbl As Label In MyPanel.Controls.OfType(Of Label)()
                        If lbl.ID = lblName Then
                            lbl.Visible = True

                            Dim foodService As FoodServiceRef.FoodSecretServiceClient = New FoodServiceRef.FoodSecretServiceClient()
                            Dim foodServiceResult1 As FoodServiceRef.RecipeInformation

                            foodServiceResult1 = foodService.GetRecipeInformation(recipeID)

                            lbl.Text = "<a href='RecipeDetails.aspx?id=" & item.RecipeID & "'>" & foodServiceResult1.title + "</a><img src='" + foodServiceResult1.image + "' class='img-responsive' width='100%' alt=''/> "
                            lbl.Text = "<br />" & lbl.Text & "<small><b><a style='color: red !important;' href='RemoveMeal.aspx?id=" & item.WeeklyPlanID & "'>X REMOVE</a></b></small>"
                        End If
                    Next

                Next
            End If

        End If
    End Sub


    Public Sub resetPanel()
        For Each btn As LinkButton In MyPanel.Controls.OfType(Of LinkButton)()
            btn.Visible = True
        Next
        For Each lbl As Label In MyPanel.Controls.OfType(Of Label)()
            lbl.Text = ""
            lbl.Visible = False
        Next
    End Sub
    Protected Sub lbtnPrev_Click(sender As Object, e As EventArgs)
        Dim weeklabel As String = ""
        Dim weekId As String = Session("weekid")
        Dim now As DateTime = DateTime.Parse(weekId.Substring(0, 10))
        now = now.AddDays(-7)
        weekId = now.ToString("MM-dd-yyyy")
        weeklabel = now.ToString("dd-MM-yyyy") & " TO "
        weekId = weekId & now.AddDays(6).ToString("MM-dd-yyyy")
        weeklabel = weeklabel & now.AddDays(6).ToString("dd-MM-yyyy")
        Session("weekid") = weekId
        Session("weeklabel") = weeklabel

        Label1.Text = weeklabel

        resetPanel()

        weekId = Session("weekid")
        weeklabel = Session("weeklabel")
        Label1.Text = weeklabel

        If Context.User.Identity.IsAuthenticated Then

            Dim userId = Context.User.Identity.Name


            Dim _context As MyDbContext = New MyDbContext()
            Dim _list As List(Of WeeklyPlan) = _context.WeeklyPlans.Where(Function(a) a.WeekID = weekId And a.UserId = userId).ToList()

            For Each item As WeeklyPlan In _list

                Dim btnName As String = "LinkButton" & item.MealId
                Dim lblName As String = "Label" & item.MealId
                Dim recipeID As String = item.RecipeID
                For Each btn As LinkButton In MyPanel.Controls.OfType(Of LinkButton)()
                    If btn.ID = btnName Then
                        btn.Visible = False
                    End If
                Next


                For Each lbl As Label In MyPanel.Controls.OfType(Of Label)()
                    If lbl.ID = lblName Then
                        lbl.Visible = True

                        Dim foodService As FoodServiceRef.FoodSecretServiceClient = New FoodServiceRef.FoodSecretServiceClient()
                        Dim foodServiceResult1 As FoodServiceRef.RecipeInformation

                        foodServiceResult1 = foodService.GetRecipeInformation(recipeID)

                        lbl.Text = "<a href='RecipeDetails.aspx?id=" & item.RecipeID & "'>" & foodServiceResult1.title + "</a><img src='" + foodServiceResult1.image + "' class='img-responsive' width='100%' alt=''/> "
                        lbl.Text = "<br />" & lbl.Text & "<small><b><a style='color: red !important;' href='RemoveMeal.aspx?id=" & item.WeeklyPlanID & "'>X REMOVE</a></b></small>"
                    End If
                Next

            Next
        End If
    End Sub

    Protected Sub lbtnNext_Click(sender As Object, e As EventArgs)
        Dim weeklabel As String = ""
        Dim weekId As String = Session("weekid")
        Dim now As DateTime = DateTime.Parse(weekId.Substring(10, 10))
        now = now.AddDays(1)
        weekId = now.ToString("MM-dd-yyyy")
        weeklabel = now.ToString("dd-MM-yyyy") & " TO "
        weekId = weekId & now.AddDays(6).ToString("MM-dd-yyyy")
        weeklabel = weeklabel & now.AddDays(6).ToString("dd-MM-yyyy")
        Session("weekid") = weekId
        Session("weeklabel") = weeklabel

        Label1.Text = weeklabel

        resetPanel()
        weekId = Session("weekid")
        weeklabel = Session("weeklabel")
        Label1.Text = weeklabel

        If Context.User.Identity.IsAuthenticated Then

            Dim userId = Context.User.Identity.Name


            Dim _context As MyDbContext = New MyDbContext()
            Dim _list As List(Of WeeklyPlan) = _context.WeeklyPlans.Where(Function(a) a.WeekID = weekId And a.UserId = userId).ToList()

            For Each item As WeeklyPlan In _list

                Dim btnName As String = "LinkButton" & item.MealId
                Dim lblName As String = "Label" & item.MealId
                Dim recipeID As String = item.RecipeID
                For Each btn As LinkButton In MyPanel.Controls.OfType(Of LinkButton)()
                    If btn.ID = btnName Then
                        btn.Visible = False
                    End If
                Next


                For Each lbl As Label In MyPanel.Controls.OfType(Of Label)()
                    If lbl.ID = lblName Then
                        lbl.Visible = True

                        Dim foodService As FoodServiceRef.FoodSecretServiceClient = New FoodServiceRef.FoodSecretServiceClient()
                        Dim foodServiceResult1 As FoodServiceRef.RecipeInformation

                        foodServiceResult1 = foodService.GetRecipeInformation(recipeID)

                        lbl.Text = "<a href='RecipeDetails.aspx?id=" & item.RecipeID & "'>" & foodServiceResult1.title + "</a><img src='" + foodServiceResult1.image + "' class='img-responsive' width='100%' alt=''/> "
                        lbl.Text = "<br />" & lbl.Text & "<small><b><a style='color: red !important;' href='RemoveMeal.aspx?id=" & item.WeeklyPlanID & "'>X REMOVE</a></b></small>"
                    End If
                Next

            Next
        End If

    End Sub

    Protected Sub LinkButtonAll_Click(sender As Object, e As EventArgs)

        Dim thisButton As LinkButton = CType(sender, LinkButton)
        Dim MealID As String = thisButton.ID.Substring(10, 2)

        'If thisButton.ID.Substring(10, 2) = "11" Then
        '    MealID = "11"
        'ElseIf thisButton.ID.Substring(10, 2) = "21" Then
        '    MealID = "11"
        'ElseIf thisButton.ID.Substring(10, 2) = "31" Then
        'ElseIf thisButton.ID.Substring(10, 2) = "41" Then
        'ElseIf thisButton.ID.Substring(10, 2) = "51" Then
        'ElseIf thisButton.ID.Substring(10, 2) = "61" Then
        'ElseIf thisButton.ID.Substring(10, 2) = "71" Then
        'ElseIf thisButton.ID.Substring(10, 2) = "12" Then
        'ElseIf thisButton.ID.Substring(10, 2) = "22" Then
        'ElseIf thisButton.ID.Substring(10, 2) = "32" Then
        'ElseIf thisButton.ID.Substring(10, 2) = "42" Then
        'ElseIf thisButton.ID.Substring(10, 2) = "52" Then
        'ElseIf thisButton.ID.Substring(10, 2) = "62" Then
        'ElseIf thisButton.ID.Substring(10, 2) = "72" Then
        'ElseIf thisButton.ID.Substring(10, 2) = "13" Then
        'ElseIf thisButton.ID.Substring(10, 2) = "23" Then
        'ElseIf thisButton.ID.Substring(10, 2) = "33" Then
        'ElseIf thisButton.ID.Substring(10, 2) = "43" Then
        'ElseIf thisButton.ID.Substring(10, 2) = "53" Then
        'ElseIf thisButton.ID.Substring(10, 2) = "63" Then
        'ElseIf thisButton.ID.Substring(10, 2) = "73" Then
        'End If

        Session("MealID") = MealID

        Response.Redirect("SelectMeal.aspx")
    End Sub
End Class

