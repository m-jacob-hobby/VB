Public Class Homework1
    Const MILEAGE_RATE_DOUBLE As Double = 0.12
    Const DAILY_RATE_INTEGER As Integer = 15

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim OdomBeginningDouble,
            OdomEndingDouble,
            TotalMileageDouble,
            TotalChargeDouble As Double                 ' Odometer beginning and ending mileage as double
        Dim DaysRentedInteger As Integer                ' Days vehicle rented as an integer

        Try
            ' Try to parse text for beginning odometer mileage
            OdomBeginningDouble = Double.Parse(BeginningOdomTextBox.Text)

            Try
                ' Try to parse text for ending odometer mileage
                OdomEndingDouble = Double.Parse(EndingOdomTextBox.Text)

                Try
                    ' Try to parse days rented
                    DaysRentedInteger = Integer.Parse(DaysNumTextBox.Text)

                    ' Calculations
                    TotalMileageDouble = OdomEndingDouble - OdomBeginningDouble
                    TotalChargeDouble = (TotalMileageDouble * MILEAGE_RATE_DOUBLE) + (DAILY_RATE_INTEGER * DaysRentedInteger)

                    ' Output calculations into the totals text boxes
                    MilesDrivenTextBox.Text = TotalMileageDouble.ToString()
                    TotalChargeTextBox.Text = TotalChargeDouble.ToString("C")

                Catch ex As Exception
                    MessageBox.Show("Number of days must be a numeric value.",
                                    "Entry Error!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation)

                    With DaysNumTextBox
                        .Focus()
                        .Clear()
                    End With

                End Try

            Catch OdomEndingError As Exception
                MessageBox.Show("Odometer Ending must be a numeric value.",
                                "Entry Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)

                With EndingOdomTextBox
                    .Focus()
                    .Clear()
                End With

            End Try

        Catch OdomBeginningError As Exception
            MessageBox.Show("Odometer Beginning must be a numeric value.",
                            "Entry Error!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

            With BeginningOdomTextBox
                .Focus()
                .Clear()
            End With

        End Try

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Exit button closes the application
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' When clear button clicked all  text boxes are cleared
        NameTextBox.Clear()
        AddressTextBox.Clear()
        StateTextBox.Clear()
        CityTextBox.Clear()
        ZipTextBox.Clear()
        BeginningOdomTextBox.Clear()
        EndingOdomTextBox.Clear()
        DaysNumTextBox.Clear()
        MilesDrivenTextBox.Clear()
        TotalChargeTextBox.Clear()
    End Sub
End Class
