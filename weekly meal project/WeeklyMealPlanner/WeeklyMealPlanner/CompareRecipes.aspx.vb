Public Class CompareRecipes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

    Protected Sub btnSearch1_Click(sender As Object, e As EventArgs) Handles btnSearch1.Click
        Try
            Dim foodService As FoodServiceRef.FoodSecretServiceClient = New FoodServiceRef.FoodSecretServiceClient()
            Dim foodServiceResult1() As FoodServiceRef.Recipe
            foodServiceResult1 = foodService.SearchRecipeByName(TextBox1.Text)
            RadioButtonList1.DataSource = foodServiceResult1.ToList()
            RadioButtonList1.DataTextField = "title"
            RadioButtonList1.DataValueField = "id"
            RadioButtonList1.DataBind()
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btnSearch2_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click
        Try
            Dim foodService As FoodServiceRef.FoodSecretServiceClient = New FoodServiceRef.FoodSecretServiceClient()
            Dim foodServiceResult2() As FoodServiceRef.Recipe
            foodServiceResult2 = foodService.SearchRecipeByName(TextBox2.Text)
            RadioButtonList2.DataSource = foodServiceResult2.ToList()
            RadioButtonList2.DataTextField = "title"
            RadioButtonList2.DataValueField = "id"
            RadioButtonList2.DataBind()
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        If Not RadioButtonList1.SelectedValue Is Nothing And Not RadioButtonList2.SelectedValue Is Nothing Then
            compareRecipes(RadioButtonList1.SelectedValue, RadioButtonList2.SelectedValue)
        End If
    End Sub

    Private Sub compareRecipes(ByVal id1 As String, ByVal id2 As String)
        Try
            If Not id1 Is Nothing _
               And Not id2 Is Nothing Then

                resultTable.Visible = True

                Dim recipeID1 As Integer = id1
                Dim recipeID2 As Integer = id2

                Dim foodService As FoodServiceRef.FoodSecretServiceClient = New FoodServiceRef.FoodSecretServiceClient()
                Dim foodServiceResult1 As FoodServiceRef.RecipeInformation
                Dim foodServiceResult2 As FoodServiceRef.RecipeInformation

                foodServiceResult1 = foodService.GetRecipeInformation(recipeID1)
                foodServiceResult2 = foodService.GetRecipeInformation(recipeID2)

                lblTitle.Text = foodServiceResult1.title + "<img src='" + foodServiceResult1.image + "' class='img-responsive' alt=''/> "
                lblTitlea.Text = foodServiceResult2.title + "<img src='" + foodServiceResult2.image + "' class='img-responsive' alt=''/> "

                Label1.Text = foodServiceResult1.Calories
                Label2.Text = foodServiceResult1.Carbs
                Label3.Text = foodServiceResult1.Fat
                Label4.Text = foodServiceResult1.Protein
                Label5.Text = foodServiceResult1.veryHealthy
                Label6.Text = foodServiceResult1.weightWatcherSmartPoints
                Label7.Text = foodServiceResult1.spoonacularScore
                Label8.Text = foodServiceResult1.aggregateLikes
                Label9.Text = foodServiceResult1.readyInMinutes

                Label1a.Text = foodServiceResult2.Calories
                Label2a.Text = foodServiceResult2.Carbs
                Label3a.Text = foodServiceResult2.Fat
                Label4a.Text = foodServiceResult2.Protein
                Label5a.Text = foodServiceResult2.veryHealthy
                Label6a.Text = foodServiceResult2.weightWatcherSmartPoints
                Label7a.Text = foodServiceResult2.spoonacularScore
                Label8a.Text = foodServiceResult2.aggregateLikes
                Label9a.Text = foodServiceResult2.readyInMinutes

                Dim points1 As Integer = 0
                Dim points2 As Integer = 0

                If foodServiceResult1.Calories < foodServiceResult2.Calories Then
                    points1 = points1 + 1
                ElseIf foodServiceResult1.Calories > foodServiceResult2.Calories Then
                    points2 = points2 + 1
                End If

                If foodServiceResult1.Carbs < foodServiceResult2.Carbs Then
                    points1 = points1 + 1
                ElseIf foodServiceResult1.Carbs > foodServiceResult2.Carbs Then
                    points2 = points2 + 1
                End If

                If foodServiceResult1.Fat < foodServiceResult2.Fat Then
                    points1 = points1 + 1
                ElseIf foodServiceResult1.Fat > foodServiceResult2.Fat Then
                    points2 = points2 + 1
                End If

                If foodServiceResult1.Protein > foodServiceResult2.Protein Then
                    points1 = points1 + 1
                ElseIf foodServiceResult1.Protein < foodServiceResult2.Protein Then
                    points2 = points2 + 1
                End If

                If foodServiceResult1.weightWatcherSmartPoints > foodServiceResult2.weightWatcherSmartPoints Then
                    points1 = points1 + 1
                ElseIf foodServiceResult1.weightWatcherSmartPoints < foodServiceResult2.weightWatcherSmartPoints Then
                    points2 = points2 + 1
                End If

                If foodServiceResult1.spoonacularScore > foodServiceResult2.spoonacularScore Then
                    points1 = points1 + 1
                ElseIf foodServiceResult1.spoonacularScore < foodServiceResult2.spoonacularScore Then
                    points2 = points2 + 1
                End If

                If foodServiceResult1.aggregateLikes > foodServiceResult2.aggregateLikes Then
                    points1 = points1 + 1
                ElseIf foodServiceResult1.aggregateLikes < foodServiceResult2.aggregateLikes Then
                    points2 = points2 + 1
                End If

                If foodServiceResult1.readyInMinutes < foodServiceResult2.readyInMinutes Then
                    points1 = points1 + 1
                ElseIf foodServiceResult1.readyInMinutes > foodServiceResult2.readyInMinutes Then
                    points2 = points2 + 1
                End If

                If foodServiceResult1.veryHealthy = True Then
                    points1 = points1 + 1
                End If

                If foodServiceResult2.veryHealthy = True Then
                    points2 = points2 + 1
                End If

                If points1 > points2 Then
                    LabelTotal1.Text = "<img src='imgCheck.jpg' title='score: " + points1.ToString() + "'>"
                    LabelTotal2.Text = "<img src='imgX.jpg' title='score: " + points2.ToString() + "'>"
                ElseIf points1 < points2 Then
                    LabelTotal1.Text = "<img src='imgX.jpg' title='score: " + points1.ToString() + "'>"
                    LabelTotal2.Text = "<img src='imgCheck.jpg' title='score: " + points2.ToString() + "'>"
                ElseIf points1 = points2 Then
                    LabelTotal1.Text = "<img src='imgCheck.jpg' title='score: " + points1.ToString() + "'>"
                    LabelTotal2.Text = "<img src='imgCheck.jpg' title='score: " + points2.ToString() + "'>"
                End If

            End If


        Catch ex As Exception

        End Try
    End Sub

End Class