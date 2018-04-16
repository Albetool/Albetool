Public Class Search
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim foodService As FoodServiceRef.FoodSecretServiceClient = New FoodServiceRef.FoodSecretServiceClient()
            Dim foodServiceResult1() As FoodServiceRef.Recipe

            If RadioButtonList1.SelectedValue = 1 Then
                foodServiceResult1 = foodService.SearchRecipeByIngredients(TextBox1.Text)
            Else
                foodServiceResult1 = foodService.SearchRecipeByNutrients(TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
            End If



            Dim recipeTemplate As String = "<div class='col-sm-3 wrapper'> " +
                        "<a href='RecipeDetails.aspx?id=$id'>  " +
                            "<img src='$img' class='img-responsive' alt=''/> " +
                            "<div class='desc'> " +
                                "<p class='desc_content'>$title</p> " +
                            "</div> " +
                        "</a> " +
                    "</div>"
            Dim i As Integer = 1
            Dim strBuidler As StringBuilder = New StringBuilder()
            For Each item As FoodServiceRef.Recipe In foodServiceResult1

                strBuidler.Append(((recipeTemplate.Replace("$img", item.image)).Replace("$title", item.title)).Replace("$id", item.id))
                If i = 4 Then
                    strBuidler.Append("</div><div class='row'>")
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