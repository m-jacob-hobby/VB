<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalorieCounter
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
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CurrentCaloriesTextBox = New System.Windows.Forms.TextBox()
        Me.ItemsNumberTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCaloriesTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentCaloriesLabel = New System.Windows.Forms.Label()
        Me.ItemsNumberLabel = New System.Windows.Forms.Label()
        Me.TotalCaloriesLabel = New System.Windows.Forms.Label()
        Me.GramNumbersGroupBox = New System.Windows.Forms.GroupBox()
        Me.ProteinLabel = New System.Windows.Forms.Label()
        Me.CarbsLabel = New System.Windows.Forms.Label()
        Me.FatLabel = New System.Windows.Forms.Label()
        Me.ProteinTextBox = New System.Windows.Forms.TextBox()
        Me.CarbsTextBox = New System.Windows.Forms.TextBox()
        Me.FatTextBox = New System.Windows.Forms.TextBox()
        Me.GramNumbersGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(197, 57)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 0
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(197, 86)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(197, 115)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CurrentCaloriesTextBox
        '
        Me.CurrentCaloriesTextBox.Location = New System.Drawing.Point(170, 157)
        Me.CurrentCaloriesTextBox.Name = "CurrentCaloriesTextBox"
        Me.CurrentCaloriesTextBox.ReadOnly = True
        Me.CurrentCaloriesTextBox.Size = New System.Drawing.Size(75, 20)
        Me.CurrentCaloriesTextBox.TabIndex = 3
        '
        'ItemsNumberTextBox
        '
        Me.ItemsNumberTextBox.Location = New System.Drawing.Point(170, 202)
        Me.ItemsNumberTextBox.Name = "ItemsNumberTextBox"
        Me.ItemsNumberTextBox.ReadOnly = True
        Me.ItemsNumberTextBox.Size = New System.Drawing.Size(75, 20)
        Me.ItemsNumberTextBox.TabIndex = 4
        '
        'TotalCaloriesTextBox
        '
        Me.TotalCaloriesTextBox.Location = New System.Drawing.Point(170, 228)
        Me.TotalCaloriesTextBox.Name = "TotalCaloriesTextBox"
        Me.TotalCaloriesTextBox.ReadOnly = True
        Me.TotalCaloriesTextBox.Size = New System.Drawing.Size(75, 20)
        Me.TotalCaloriesTextBox.TabIndex = 5
        '
        'CurrentCaloriesLabel
        '
        Me.CurrentCaloriesLabel.AutoSize = True
        Me.CurrentCaloriesLabel.Location = New System.Drawing.Point(44, 160)
        Me.CurrentCaloriesLabel.Name = "CurrentCaloriesLabel"
        Me.CurrentCaloriesLabel.Size = New System.Drawing.Size(120, 13)
        Me.CurrentCaloriesLabel.TabIndex = 6
        Me.CurrentCaloriesLabel.Text = "Calories for current item:"
        '
        'ItemsNumberLabel
        '
        Me.ItemsNumberLabel.AutoSize = True
        Me.ItemsNumberLabel.Location = New System.Drawing.Point(81, 205)
        Me.ItemsNumberLabel.Name = "ItemsNumberLabel"
        Me.ItemsNumberLabel.Size = New System.Drawing.Size(83, 13)
        Me.ItemsNumberLabel.TabIndex = 7
        Me.ItemsNumberLabel.Text = "Total # of items:"
        '
        'TotalCaloriesLabel
        '
        Me.TotalCaloriesLabel.AutoSize = True
        Me.TotalCaloriesLabel.Location = New System.Drawing.Point(69, 231)
        Me.TotalCaloriesLabel.Name = "TotalCaloriesLabel"
        Me.TotalCaloriesLabel.Size = New System.Drawing.Size(95, 13)
        Me.TotalCaloriesLabel.TabIndex = 8
        Me.TotalCaloriesLabel.Text = "Total # of calories:"
        '
        'GramNumbersGroupBox
        '
        Me.GramNumbersGroupBox.Controls.Add(Me.ProteinLabel)
        Me.GramNumbersGroupBox.Controls.Add(Me.CarbsLabel)
        Me.GramNumbersGroupBox.Controls.Add(Me.FatLabel)
        Me.GramNumbersGroupBox.Controls.Add(Me.ProteinTextBox)
        Me.GramNumbersGroupBox.Controls.Add(Me.CarbsTextBox)
        Me.GramNumbersGroupBox.Controls.Add(Me.FatTextBox)
        Me.GramNumbersGroupBox.Location = New System.Drawing.Point(13, 13)
        Me.GramNumbersGroupBox.Name = "GramNumbersGroupBox"
        Me.GramNumbersGroupBox.Size = New System.Drawing.Size(165, 125)
        Me.GramNumbersGroupBox.TabIndex = 9
        Me.GramNumbersGroupBox.TabStop = False
        Me.GramNumbersGroupBox.Text = "Enter the # of Grams:"
        '
        'ProteinLabel
        '
        Me.ProteinLabel.AutoSize = True
        Me.ProteinLabel.Location = New System.Drawing.Point(17, 91)
        Me.ProteinLabel.Name = "ProteinLabel"
        Me.ProteinLabel.Size = New System.Drawing.Size(43, 13)
        Me.ProteinLabel.TabIndex = 5
        Me.ProteinLabel.Text = "Protein:"
        '
        'CarbsLabel
        '
        Me.CarbsLabel.AutoSize = True
        Me.CarbsLabel.Location = New System.Drawing.Point(17, 54)
        Me.CarbsLabel.Name = "CarbsLabel"
        Me.CarbsLabel.Size = New System.Drawing.Size(37, 13)
        Me.CarbsLabel.TabIndex = 4
        Me.CarbsLabel.Text = "Carbs:"
        '
        'FatLabel
        '
        Me.FatLabel.AutoSize = True
        Me.FatLabel.Location = New System.Drawing.Point(17, 22)
        Me.FatLabel.Name = "FatLabel"
        Me.FatLabel.Size = New System.Drawing.Size(25, 13)
        Me.FatLabel.TabIndex = 3
        Me.FatLabel.Text = "Fat:"
        '
        'ProteinTextBox
        '
        Me.ProteinTextBox.Location = New System.Drawing.Point(82, 88)
        Me.ProteinTextBox.Name = "ProteinTextBox"
        Me.ProteinTextBox.Size = New System.Drawing.Size(69, 20)
        Me.ProteinTextBox.TabIndex = 2
        '
        'CarbsTextBox
        '
        Me.CarbsTextBox.Location = New System.Drawing.Point(82, 52)
        Me.CarbsTextBox.Name = "CarbsTextBox"
        Me.CarbsTextBox.Size = New System.Drawing.Size(69, 20)
        Me.CarbsTextBox.TabIndex = 1
        '
        'FatTextBox
        '
        Me.FatTextBox.Location = New System.Drawing.Point(82, 19)
        Me.FatTextBox.Name = "FatTextBox"
        Me.FatTextBox.Size = New System.Drawing.Size(69, 20)
        Me.FatTextBox.TabIndex = 1
        '
        'CalorieCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.GramNumbersGroupBox)
        Me.Controls.Add(Me.TotalCaloriesLabel)
        Me.Controls.Add(Me.ItemsNumberLabel)
        Me.Controls.Add(Me.CurrentCaloriesLabel)
        Me.Controls.Add(Me.TotalCaloriesTextBox)
        Me.Controls.Add(Me.ItemsNumberTextBox)
        Me.Controls.Add(Me.CurrentCaloriesTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Name = "CalorieCounter"
        Me.Text = "Calorie Counter"
        Me.GramNumbersGroupBox.ResumeLayout(False)
        Me.GramNumbersGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents CurrentCaloriesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemsNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCaloriesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CurrentCaloriesLabel As System.Windows.Forms.Label
    Friend WithEvents ItemsNumberLabel As System.Windows.Forms.Label
    Friend WithEvents TotalCaloriesLabel As System.Windows.Forms.Label
    Friend WithEvents GramNumbersGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ProteinLabel As System.Windows.Forms.Label
    Friend WithEvents CarbsLabel As System.Windows.Forms.Label
    Friend WithEvents FatLabel As System.Windows.Forms.Label
    Friend WithEvents ProteinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CarbsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FatTextBox As System.Windows.Forms.TextBox

End Class
