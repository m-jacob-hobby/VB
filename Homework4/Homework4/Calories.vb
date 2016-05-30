'Program:		Homework 4: Calorie counter
'Programmer:	M Jacob Hobby
'Date:			04/06/2016
'Description:	Calculate calories using the Calories class.
'				Instantiate Calories as a new object of the Calories class.

Public Class Calories
    ' instance variables
    Private FatInteger As Integer
    Private CarbsInteger As Integer
    Private ProteinInteger As Integer
    Private CaloriesTotalInteger As Integer
    ' shared variables
    Private Shared CalorieTotalCountInteger As Integer
    Private Shared ItemsTotalCountInteger As Integer

    ' properties
    Property Fat As Integer
        Get
            Return FatInteger
        End Get
        Set(value As Integer)
            FatInteger = value
        End Set
    End Property

    Property Carbs As Integer
        Get
            Return CarbsInteger
        End Get
        Set(value As Integer)
            CarbsInteger = value
        End Set
    End Property

    Property Protein As Integer
        Get
            Return ProteinInteger
        End Get
        Set(value As Integer)
            ProteinInteger = value
        End Set
    End Property

    ReadOnly Property CaloriesTotal As Integer
        Get
            Return CaloriesTotalInteger
        End Get
    End Property


    ' Shared properties
    Shared ReadOnly Property CalorieTotalCount As Integer
        Get
            Return CalorieTotalCountInteger
        End Get
    End Property

    Shared ReadOnly Property ItemsTotalCount As Integer
        Get
            Return ItemsTotalCountInteger
        End Get
    End Property


    ' Constructors
    Sub New()

    End Sub

    Sub New(FatIn As Integer,
            CarbsIn As Integer,
            ProteinIn As Integer)
        'overloaded constructor

        ' Properties assigned
        Fat = FatIn
        Carbs = CarbsIn
        Protein = ProteinIn

        CalculateCalories()

        ' add to the totals
        AddToTotal()
    End Sub


    ' subroutines
    Private Sub CalculateCalories()
        ' calculate the total calories
        CaloriesTotalInteger = (Fat * 9) + (Carbs * 4) + (Protein * 4)
    End Sub

    Private Sub AddToTotal()
        ' add to summary information
        CalorieTotalCountInteger += CaloriesTotal
        ItemsTotalCountInteger += 1
    End Sub

End Class
