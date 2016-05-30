' Project: Homework 3
' Description: Allows user to enter twenty rating values for the cafeteria, one at a time, and updates an output field displaying the number of ratings per value
' Author: M Jacob Hobby, m.jacob.hobby@gmail.com
' Date: 03/16/16

Public Class Homework3
    Dim RatingArray() As String = {"", "", "", "", "", "", "", "", "", ""}                      ' Array that will generate the bar graphs for # of ratings
    Dim RatingsCountInteger As Integer = 0                                                      ' Records the number of times ratings have been submitted


    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim RatingPositionInteger As Integer                                                    ' The position of the RatingArray that user has submitted a rating for
        Dim CountInteger As Integer = 1                                                         ' Output for rating value into ResultsTextBox
        Dim RatingOutputString As String = "Rating   Frequency"                                 ' Header text output to ResultsTextBox
        Dim RatingString As String                                                              ' The string value obtained from the RatingComboBox

        Try
            ' Get the value the user selected from the combo box
            RatingString = RatingComboBox.SelectedItem.ToString

            ' Parse string rating to its int value and modify the array bar graph
            RatingPositionInteger = Integer.Parse(RatingString)
            RatingArray(RatingPositionInteger - 1) &= "* "

            ResultsTextBox.Text = RatingOutputString & vbCrLf

            ' Output to the ResultsTextBox each rating value followed by its associated number of ratings as bar graph
            For Each RateString As String In RatingArray
                If CountInteger < 10 Then
                    ' if rating value is less then 10...
                    ResultsTextBox.Text &= CountInteger & "           " & RateString & vbCrLf
                Else
                    ' if rating is 10 spacing between value and bar is shortened
                    ResultsTextBox.Text &= CountInteger & "         " & RateString & vbCrLf
                End If
                ' increment the count to output each rating value from 1 to 10
                CountInteger += 1
            Next

            ' increase the count of number of times user has submitted a survey value
            RatingsCountInteger += 1

            ' Once 20 ratings have been submitted, disable the submit button
            If RatingsCountInteger = 20 Then
                SubmitButton.Enabled = False
            End If

        Catch ex As Exception
            ' If the user does not select a value from the drop down menu, output error message
            MessageBox.Show("You must select a value from the drop down menu.")

        End Try

    End Sub

End Class
