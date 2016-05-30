'Program:		Homework 5: Web book store order page
'Programmer:	M Jacob Hobby
'Date:			04/21/2016
'Description:	Allow user to select quantity and price of books
'               and returns extended price, discount, and discounted price
'               as well as link to contact page

Partial Class _Default
    Inherits System.Web.UI.Page
    Const DISCOUNT_DECIMAL As Decimal = 0.15
    Dim DiscountDecimal As Decimal
    Protected Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' set all text boxes to empty
        QuantityTextBox.Text = ""
        TitleTextBox.Text = ""
        PriceTextBox.Text = ""
        ExtPriceTextBox.Text = ""
        DiscountedPriceTextBox.Text = ""
        DiscountTextBox.Text = ""
        DiscountSummaryTextBox.Text = ""
        DiscountSummaryTextBox.Visible = False
        DiscountSummaryHiddenField.Value = 0
    End Sub


    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim QuantityInteger As Integer              ' quantity value from user
        Dim PriceDecimal As Decimal                 ' price value from user
        Dim ExtendedPriceDecimal As Decimal         ' calculated price from quantity and price
        Dim DiscountPriceDecimal As Decimal         ' total price after discount

        Try
            ' get the quantity value
            QuantityInteger = Integer.Parse(QuantityTextBox.Text)

            Try
                ' get the price value
                PriceDecimal = Decimal.Parse(PriceTextBox.Text)

                ' calculate the extended price and print to text box
                ExtendedPriceDecimal = QuantityInteger * PriceDecimal
                ExtPriceTextBox.Text = ExtendedPriceDecimal.ToString("C")

                ' calculate the discount and print to text box
                DiscountDecimal = ExtendedPriceDecimal * DISCOUNT_DECIMAL
                DiscountTextBox.Text = DiscountDecimal.ToString("C")

                ' calculate the discount price and print to text box
                DiscountPriceDecimal = ExtendedPriceDecimal - DiscountDecimal
                DiscountedPriceTextBox.Text = DiscountPriceDecimal.ToString("C")



            Catch ex As Exception

            End Try

        Catch ex As Exception

        End Try
    End Sub

    ' Display total discounts
    Protected Sub DiscountSummaryButton_Click(sender As Object, e As EventArgs) Handles DiscountSummaryButton.Click
        Dim SummaryDiscountDecimal As Decimal

        Try
            ' Retrieve value from hidden field
            SummaryDiscountDecimal = Integer.Parse(DiscountSummaryHiddenField.Value)
            ' increment tickets total
            SummaryDiscountDecimal += DiscountDecimal
            ' push it back to hidden field
            DiscountSummaryHiddenField.Value = SummaryDiscountDecimal

            DiscountSummaryTextBox.Text = " Total Discounts: " & SummaryDiscountDecimal.ToString
        Catch ex As Exception

        End Try


    End Sub
End Class
