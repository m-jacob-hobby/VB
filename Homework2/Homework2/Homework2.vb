' Title: Homework 2
' Author: M Jacob Hobby, 2/24/2016
' Description: Takes inputs for number of miles driven and gallons used, then outputs list of previous entries, the MPG
'               and total calculations for all entries.

Public Class MilesPerGallonForn
    ' Global variables for totals and number of times calculations were done
    Dim TotalMilesDecimal,
            TotalGallonsDecimal,
            TotalMPGDecimal As Decimal

    Dim CalculationCountInteger As Integer

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ' Variables from entries and calculations
        Dim MilesDrivenDecimal,
            GallonsUsedDecimal,
            MPGDecimal,
            MPGAverage As Decimal


        Try
            ' Attempt to parse miles driven to decimal
            MilesDrivenDecimal = Decimal.Parse(MilesDrivenTextBox.Text)

            Try
                ' Attempt to parse gallons used to decimal
                GallonsUsedDecimal = Decimal.Parse(GallonsUsedTextBox.Text)

                ' Calculate MPG
                MPGDecimal = MilesDrivenDecimal / GallonsUsedDecimal

                ' Add the user input and MPG into their associated list boxes
                MilesListBox.Items.Add(MilesDrivenDecimal.ToString("N"))
                GallonsListBox.Items.Add(GallonsUsedDecimal.ToString("N"))
                MPGListBox.Items.Add(MPGDecimal.ToString("N"))

                ' Calculate totals
                TotalMilesDecimal += MilesDrivenDecimal
                TotalGallonsDecimal += GallonsUsedDecimal
                TotalMPGDecimal += MPGDecimal
                CalculationCountInteger += 1
                MPGAverage = TotalMPGDecimal / CalculationCountInteger

                ' Print totals to totals textbox
                TotalsTextBox.Text = "Total miles driven: " & TotalMilesDecimal.ToString("N") & vbCrLf & "Total gallons used: " & TotalGallonsDecimal.ToString("N") & vbCrLf & "Total MPG: " & MPGAverage.ToString("N")

                ' Clear user entry text box and return focus to miles driven
                MilesDrivenTextBox.Clear()
                MilesDrivenTextBox.Focus()
                GallonsUsedTextBox.Clear()

            Catch ex As Exception
                ' Failure to parse gallons used to decimal because of user input
                MessageBox.Show("Invalid entry for number of gallons used.",
                                "Invalid Entry!",
                                MessageBoxButtons.OK)

                ' Clear and refocus on the gallons used entry
                With GallonsUsedTextBox
                    .Clear()
                    .Focus()
                End With
            End Try

        Catch ex As Exception
            ' Failure to parse miles driven to decimal because of user input
            MessageBox.Show("Invalid entry for number of miles driven.",
                            "Invalid Entry!",
                            MessageBoxButtons.OK)

            ' Clear and refocus on the miles driven entry
            With MilesDrivenTextBox
                .Clear()
                .Focus()
            End With
        End Try

    End Sub
End Class
