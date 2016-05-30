<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homework3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RateLabel = New System.Windows.Forms.Label()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ResultsLabel = New System.Windows.Forms.Label()
        Me.ResultsTextBox = New System.Windows.Forms.TextBox()
        Me.RatingComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'RateLabel
        '
        Me.RateLabel.AutoSize = True
        Me.RateLabel.Location = New System.Drawing.Point(15, 13)
        Me.RateLabel.Name = "RateLabel"
        Me.RateLabel.Size = New System.Drawing.Size(101, 13)
        Me.RateLabel.TabIndex = 0
        Me.RateLabel.Text = "Rate cafeteria food:"
        '
        'SubmitButton
        '
        Me.SubmitButton.AutoSize = True
        Me.SubmitButton.Location = New System.Drawing.Point(69, 37)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(83, 23)
        Me.SubmitButton.TabIndex = 2
        Me.SubmitButton.Text = "Submit Rating"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ResultsLabel
        '
        Me.ResultsLabel.AutoSize = True
        Me.ResultsLabel.Location = New System.Drawing.Point(12, 63)
        Me.ResultsLabel.Name = "ResultsLabel"
        Me.ResultsLabel.Size = New System.Drawing.Size(76, 13)
        Me.ResultsLabel.TabIndex = 3
        Me.ResultsLabel.Text = "Survey results:"
        '
        'ResultsTextBox
        '
        Me.ResultsTextBox.Location = New System.Drawing.Point(14, 85)
        Me.ResultsTextBox.Multiline = True
        Me.ResultsTextBox.Name = "ResultsTextBox"
        Me.ResultsTextBox.ReadOnly = True
        Me.ResultsTextBox.Size = New System.Drawing.Size(186, 165)
        Me.ResultsTextBox.TabIndex = 4
        '
        'RatingComboBox
        '
        Me.RatingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RatingComboBox.FormattingEnabled = True
        Me.RatingComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.RatingComboBox.Location = New System.Drawing.Point(123, 13)
        Me.RatingComboBox.Name = "RatingComboBox"
        Me.RatingComboBox.Size = New System.Drawing.Size(75, 21)
        Me.RatingComboBox.TabIndex = 5
        '
        'Homework3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 262)
        Me.Controls.Add(Me.RatingComboBox)
        Me.Controls.Add(Me.ResultsTextBox)
        Me.Controls.Add(Me.ResultsLabel)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.RateLabel)
        Me.Name = "Homework3"
        Me.Text = "Cafeteria Survey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RateLabel As System.Windows.Forms.Label
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents ResultsLabel As System.Windows.Forms.Label
    Friend WithEvents ResultsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RatingComboBox As ComboBox
End Class
