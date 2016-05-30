'Program:		Homework 4: Calorie counter
'Programmer:	M Jacob Hobby
'Date:			04/06/2016
'Description:	Calculate calories using the Calories class.
'				Instantiate Calories as a new object of the Calories class.

Public Class CalorieCounter
    ' Declare new Calories object
    Dim ItemCalories As Calories

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim FatInteger,
            CarbsInteger,
            ProteinInteger As Integer

        ' Attempt to parse the user input for fat
        Try
            FatInteger = Integer.Parse(FatTextBox.Text)

            'Attempt to parst the user input for carbs
            Try
                CarbsInteger = Integer.Parse(CarbsTextBox.Text)

                'Attempt to parse the user input for protein
                Try
                    ProteinInteger = Integer.Parse(ProteinTextBox.Text)

                    ' Input user values for fat, carbs, and protein in new Calorie object
                    ItemCalories = New Calories(FatInteger, CarbsInteger, ProteinInteger)

                    ' Output all the calculations into the form
                    CurrentCaloriesTextBox.Text = ItemCalories.CaloriesTotal.ToString
                    ItemsNumberTextBox.Text = Calories.ItemsTotalCount.ToString
                    TotalCaloriesTextBox.Text = Calories.CalorieTotalCount.ToString

                Catch ex As Exception
                    ' if invalid input for protein, throw message box
                    MessageBox.Show("Incorrect input for protein.")
                    With ProteinTextBox
                        .Clear()
                        .Focus()
                    End With
                End Try

            Catch ex As Exception
                ' if invalid input for carbs, throw message box
                MessageBox.Show("Incorrect input for carbs.")
                With CarbsTextBox
                    .Clear()
                    .Focus()
                End With

            End Try

        Catch ex As Exception
            ' if invalid input for fat, throw message box
            MessageBox.Show("Incorrect input for fat.")
            With FatTextBox
                .Clear()
                .Focus()
            End With
        End Try

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Clear all text boxes

        FatTextBox.Clear()
        FatTextBox.Focus()
        CarbsTextBox.Clear()
        ProteinTextBox.Clear()
        CurrentCaloriesTextBox.Clear()
        TotalCaloriesTextBox.Clear()
        ItemsNumberTextBox.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Exit the program
        Me.Close()

    End Sub

End Class
