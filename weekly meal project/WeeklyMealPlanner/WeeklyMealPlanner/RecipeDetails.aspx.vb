Public Class RecipeDetails
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            If Not Request.QueryString("id") Is Nothing Then

                Dim recipeID As Integer = Request.QueryString("id")

                Dim foodService As FoodServiceRef.FoodSecretServiceClient = New FoodServiceRef.FoodSecretServiceClient()
                Dim foodServiceResult1 As FoodServiceRef.RecipeInformation

                foodServiceResult1 = foodService.GetRecipeInformation(recipeID)

                lblTitle.Text = foodServiceResult1.title + "<img src='" + foodServiceResult1.image + "' class='img-responsive' alt=''/> "

                Label1.Text = foodServiceResult1.Calories
                Label2.Text = foodServiceResult1.Carbs
                Label3.Text = foodServiceResult1.Fat
                Label4.Text = foodServiceResult1.Protein
                Label5.Text = foodServiceResult1.veryHealthy
                Label6.Text = foodServiceResult1.weightWatcherSmartPoints
                Label7.Text = foodServiceResult1.spoonacularScore
                Label8.Text = foodServiceResult1.aggregateLikes
                Label9.Text = foodServiceResult1.readyInMinutes

            End If


        Catch ex As Exception

        End Try



    End Sub

End Class