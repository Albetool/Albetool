Imports System.Data.Entity

Public Class MyDbContext
    Inherits DbContext
    Public Sub New()
        MyBase.New("DefaultConnection")
    End Sub

    Private _weeklyPlan As DbSet(Of WeeklyPlan)
    Public Property WeeklyPlans() As DbSet(Of WeeklyPlan)
        Get
            Return _weeklyPlan
        End Get
        Set(value As DbSet(Of WeeklyPlan))
            _weeklyPlan = value
        End Set
    End Property


    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        MyBase.OnModelCreating(modelBuilder)
        Entity.Database.SetInitializer(Of MyDbContext)(Nothing)
    End Sub

End Class
Public Class WeeklyPlan
    Property WeeklyPlanID As Integer
    Property WeekID As String
    Property UserId As String
    Property MealId As String
    Property RecipeID As String
End Class