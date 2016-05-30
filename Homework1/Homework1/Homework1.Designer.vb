<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homework1
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
        Me.InformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.TotalsGroupBox = New System.Windows.Forms.GroupBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.BeginningOdomTextBox = New System.Windows.Forms.TextBox()
        Me.EndingOdomTextBox = New System.Windows.Forms.TextBox()
        Me.DaysNumTextBox = New System.Windows.Forms.TextBox()
        Me.MilesDrivenTextBox = New System.Windows.Forms.TextBox()
        Me.TotalChargeTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.BeginningOdomLabel = New System.Windows.Forms.Label()
        Me.EndingOdomLabel = New System.Windows.Forms.Label()
        Me.DaysNumLabel = New System.Windows.Forms.Label()
        Me.MilesDrivenLabel = New System.Windows.Forms.Label()
        Me.TotalChargeLabel = New System.Windows.Forms.Label()
        Me.InformationGroupBox.SuspendLayout()
        Me.TotalsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'InformationGroupBox
        '
        Me.InformationGroupBox.Controls.Add(Me.DaysNumLabel)
        Me.InformationGroupBox.Controls.Add(Me.EndingOdomLabel)
        Me.InformationGroupBox.Controls.Add(Me.BeginningOdomLabel)
        Me.InformationGroupBox.Controls.Add(Me.ZipLabel)
        Me.InformationGroupBox.Controls.Add(Me.StateLabel)
        Me.InformationGroupBox.Controls.Add(Me.CityLabel)
        Me.InformationGroupBox.Controls.Add(Me.AddressLabel)
        Me.InformationGroupBox.Controls.Add(Me.NameLabel)
        Me.InformationGroupBox.Controls.Add(Me.DaysNumTextBox)
        Me.InformationGroupBox.Controls.Add(Me.EndingOdomTextBox)
        Me.InformationGroupBox.Controls.Add(Me.BeginningOdomTextBox)
        Me.InformationGroupBox.Controls.Add(Me.ZipTextBox)
        Me.InformationGroupBox.Controls.Add(Me.StateTextBox)
        Me.InformationGroupBox.Controls.Add(Me.CityTextBox)
        Me.InformationGroupBox.Controls.Add(Me.AddressTextBox)
        Me.InformationGroupBox.Controls.Add(Me.NameTextBox)
        Me.InformationGroupBox.Location = New System.Drawing.Point(9, 10)
        Me.InformationGroupBox.Name = "InformationGroupBox"
        Me.InformationGroupBox.Size = New System.Drawing.Size(271, 258)
        Me.InformationGroupBox.TabIndex = 0
        Me.InformationGroupBox.TabStop = False
        Me.InformationGroupBox.Text = "Enter Rental Information:"
        '
        'TotalsGroupBox
        '
        Me.TotalsGroupBox.Controls.Add(Me.TotalChargeLabel)
        Me.TotalsGroupBox.Controls.Add(Me.MilesDrivenLabel)
        Me.TotalsGroupBox.Controls.Add(Me.TotalChargeTextBox)
        Me.TotalsGroupBox.Controls.Add(Me.MilesDrivenTextBox)
        Me.TotalsGroupBox.Location = New System.Drawing.Point(298, 59)
        Me.TotalsGroupBox.Name = "TotalsGroupBox"
        Me.TotalsGroupBox.Size = New System.Drawing.Size(198, 144)
        Me.TotalsGroupBox.TabIndex = 1
        Me.TotalsGroupBox.TabStop = False
        Me.TotalsGroupBox.Text = "Totals"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(70, 19)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(185, 20)
        Me.NameTextBox.TabIndex = 0
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(70, 45)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(185, 20)
        Me.AddressTextBox.TabIndex = 1
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(70, 71)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(107, 20)
        Me.CityTextBox.TabIndex = 2
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(70, 97)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(47, 20)
        Me.StateTextBox.TabIndex = 3
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(190, 96)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(65, 20)
        Me.ZipTextBox.TabIndex = 4
        '
        'BeginningOdomTextBox
        '
        Me.BeginningOdomTextBox.Location = New System.Drawing.Point(70, 159)
        Me.BeginningOdomTextBox.Name = "BeginningOdomTextBox"
        Me.BeginningOdomTextBox.Size = New System.Drawing.Size(107, 20)
        Me.BeginningOdomTextBox.TabIndex = 5
        '
        'EndingOdomTextBox
        '
        Me.EndingOdomTextBox.Location = New System.Drawing.Point(70, 185)
        Me.EndingOdomTextBox.Name = "EndingOdomTextBox"
        Me.EndingOdomTextBox.Size = New System.Drawing.Size(107, 20)
        Me.EndingOdomTextBox.TabIndex = 6
        '
        'DaysNumTextBox
        '
        Me.DaysNumTextBox.Location = New System.Drawing.Point(70, 215)
        Me.DaysNumTextBox.Name = "DaysNumTextBox"
        Me.DaysNumTextBox.Size = New System.Drawing.Size(46, 20)
        Me.DaysNumTextBox.TabIndex = 7
        '
        'MilesDrivenTextBox
        '
        Me.MilesDrivenTextBox.Location = New System.Drawing.Point(26, 53)
        Me.MilesDrivenTextBox.Name = "MilesDrivenTextBox"
        Me.MilesDrivenTextBox.ReadOnly = True
        Me.MilesDrivenTextBox.Size = New System.Drawing.Size(155, 20)
        Me.MilesDrivenTextBox.TabIndex = 0
        '
        'TotalChargeTextBox
        '
        Me.TotalChargeTextBox.Location = New System.Drawing.Point(27, 110)
        Me.TotalChargeTextBox.Name = "TotalChargeTextBox"
        Me.TotalChargeTextBox.ReadOnly = True
        Me.TotalChargeTextBox.Size = New System.Drawing.Size(154, 20)
        Me.TotalChargeTextBox.TabIndex = 1
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(126, 296)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(93, 26)
        Me.CalculateButton.TabIndex = 2
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(225, 296)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(92, 26)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(324, 296)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(94, 26)
        Me.PrintButton.TabIndex = 4
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(424, 296)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(84, 26)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(9, 19)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(38, 13)
        Me.NameLabel.TabIndex = 8
        Me.NameLabel.Text = "Name:"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(9, 45)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(48, 13)
        Me.AddressLabel.TabIndex = 9
        Me.AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(9, 74)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(27, 13)
        Me.CityLabel.TabIndex = 10
        Me.CityLabel.Text = "City:"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(9, 103)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(35, 13)
        Me.StateLabel.TabIndex = 11
        Me.StateLabel.Text = "State:"
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(138, 99)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(25, 13)
        Me.ZipLabel.TabIndex = 12
        Me.ZipLabel.Text = "Zip:"
        '
        'BeginningOdomLabel
        '
        Me.BeginningOdomLabel.Location = New System.Drawing.Point(9, 147)
        Me.BeginningOdomLabel.Name = "BeginningOdomLabel"
        Me.BeginningOdomLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BeginningOdomLabel.Size = New System.Drawing.Size(61, 32)
        Me.BeginningOdomLabel.TabIndex = 13
        Me.BeginningOdomLabel.Text = "Beginning Odometer:"
        '
        'EndingOdomLabel
        '
        Me.EndingOdomLabel.Location = New System.Drawing.Point(9, 173)
        Me.EndingOdomLabel.Name = "EndingOdomLabel"
        Me.EndingOdomLabel.Size = New System.Drawing.Size(57, 32)
        Me.EndingOdomLabel.TabIndex = 14
        Me.EndingOdomLabel.Text = "Ending Odometer:"
        '
        'DaysNumLabel
        '
        Me.DaysNumLabel.Location = New System.Drawing.Point(9, 203)
        Me.DaysNumLabel.Name = "DaysNumLabel"
        Me.DaysNumLabel.Size = New System.Drawing.Size(50, 32)
        Me.DaysNumLabel.TabIndex = 15
        Me.DaysNumLabel.Text = "Number of days:"
        '
        'MilesDrivenLabel
        '
        Me.MilesDrivenLabel.AutoSize = True
        Me.MilesDrivenLabel.Location = New System.Drawing.Point(24, 37)
        Me.MilesDrivenLabel.Name = "MilesDrivenLabel"
        Me.MilesDrivenLabel.Size = New System.Drawing.Size(68, 13)
        Me.MilesDrivenLabel.TabIndex = 2
        Me.MilesDrivenLabel.Text = "Miles Driven:"
        '
        'TotalChargeLabel
        '
        Me.TotalChargeLabel.AutoSize = True
        Me.TotalChargeLabel.Location = New System.Drawing.Point(24, 94)
        Me.TotalChargeLabel.Name = "TotalChargeLabel"
        Me.TotalChargeLabel.Size = New System.Drawing.Size(71, 13)
        Me.TotalChargeLabel.TabIndex = 3
        Me.TotalChargeLabel.Text = "Total Charge:"
        '
        'Homework1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 334)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.TotalsGroupBox)
        Me.Controls.Add(Me.InformationGroupBox)
        Me.Name = "Homework1"
        Me.Text = "Rental Charges"
        Me.InformationGroupBox.ResumeLayout(False)
        Me.InformationGroupBox.PerformLayout()
        Me.TotalsGroupBox.ResumeLayout(False)
        Me.TotalsGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InformationGroupBox As GroupBox
    Friend WithEvents DaysNumTextBox As TextBox
    Friend WithEvents EndingOdomTextBox As TextBox
    Friend WithEvents BeginningOdomTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents TotalsGroupBox As GroupBox
    Friend WithEvents TotalChargeTextBox As TextBox
    Friend WithEvents MilesDrivenTextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DaysNumLabel As Label
    Friend WithEvents EndingOdomLabel As Label
    Friend WithEvents BeginningOdomLabel As Label
    Friend WithEvents ZipLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents TotalChargeLabel As Label
    Friend WithEvents MilesDrivenLabel As Label
End Class
