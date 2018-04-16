Public Class SelectMeal
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsNothing(Session("MealID")) Or IsNothing(Session("weekid")) Then
            Response.Redirect("WeeklyPlanner.aspx") 
        End If
    End Sub
    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim foodService As FoodServiceRef.FoodSecretServiceClient = New FoodServiceRef.FoodSecretServiceClient()
            Dim foodServiceResult1() As FoodServiceRef.Recipe
            Dim foodServiceResult2() As FoodServiceRef.Recipe = Nothing

            If RadioButtonList1.SelectedValue = 1 Then
                foodServiceResult1 = foodService.SearchRecipeByIngredients(TextBox1.Text)
                foodServiceResult2 = foodService.SearchRecipeByName(TextBox1.Text)
            Else
                foodServiceResult1 = foodService.SearchRecipeByNutrients(TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
            End If


            Dim recipeTemplate As String = "<td style='width:25%;'> " +
                       "<a href='SelectMealConfirm.aspx?id=$id'>  " +
                           "<img src='$img'  class='img-responsive' alt=''/><br/>" +
                           "<p> " +
                               "$title $healthy" +
                           "</p> " +
                       "</a> " +
                   "</td>"
             
            'Dim recipeTemplate As String = "<div class='col-sm-3 wrapper'> " +
            '            "<a href='SelectMealConfirm.aspx?id=$id'>  " +
            '                "<img src='$img'  class='img-responsive' alt=''/> " +
            '                "<div class='desc'> " +
            '                    "<p class='desc_content'>$title $healthy</p> " +
            '                "</div> " +
            '            "</a> " +
            '        "</div>"
            Dim i As Integer = 1
            Dim strBuidler As StringBuilder = New StringBuilder()
            For Each item As FoodServiceRef.Recipe In foodServiceResult1
                If i = 1 Then
                    strBuidler.Append("<tr>")
                End If

                Dim info As FoodServiceRef.RecipeInformation = foodService.GetRecipeInformation(item.id)

                If (info.veryHealthy) Then
                    strBuidler.Append(((recipeTemplate.Replace("$img", item.image)).Replace("$title", item.title)).Replace("$id", item.id).Replace("$healthy", "<i class=""fa fa-check""></i>"))
                Else
                    strBuidler.Append(((recipeTemplate.Replace("$img", item.image)).Replace("$title", item.title)).Replace("$id", item.id).Replace("$healthy", "<i class=""fa fa-remove""></i>"))
                End If


                If i = 4 Then
                    strBuidler.Append("</tr>")
                    i = 0
                End If
                i = i + 1
            Next

            For Each item2 As FoodServiceRef.Recipe In foodServiceResult2
                If i = 1 Then
                    strBuidler.Append("<tr>")
                End If
                Dim info As FoodServiceRef.RecipeInformation = foodService.GetRecipeInformation(item2.id)

                If (info.veryHealthy) Then
                    strBuidler.Append(((recipeTemplate.Replace("$img", item2.image)).Replace("$title", item2.title)).Replace("$id", item2.id).Replace("$healthy", "<i class=""fa fa-check""></i>"))
                Else
                    strBuidler.Append(((recipeTemplate.Replace("$img", item2.image)).Replace("$title", item2.title)).Replace("$id", item2.id).Replace("$healthy", "<i class=""fa fa-remove""></i>"))
                End If
                 
                If i = 4 Then
                    strBuidler.Append("</tr>")
                    i = 0
                End If
                i = i + 1
            Next

            lblResult.Text = strBuidler.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub RadioButtonList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList1.SelectedIndexChanged
        If RadioButtonList1.SelectedValue = 1 Then
            byIngredients.Visible = True
            byNutrition.Visible = False
        Else
            byIngredients.Visible = False
            byNutrition.Visible = True
        End If
    End Sub
End Class