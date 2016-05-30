<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MilesPerGallonForn
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
        Me.MilesDrivenLabel = New System.Windows.Forms.Label()
        Me.GallonsUsedLabel = New System.Windows.Forms.Label()
        Me.MilesDrivenTextBox = New System.Windows.Forms.TextBox()
        Me.GallonsUsedTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.MilesLabel = New System.Windows.Forms.Label()
        Me.MilesListBox = New System.Windows.Forms.ListBox()
        Me.GallonsLabel = New System.Windows.Forms.Label()
        Me.GallonsListBox = New System.Windows.Forms.ListBox()
        Me.MPGLabel = New System.Windows.Forms.Label()
        Me.MPGListBox = New System.Windows.Forms.ListBox()
        Me.TotalsLabel = New System.Windows.Forms.Label()
        Me.TotalsTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'MilesDrivenLabel
        '
        Me.MilesDrivenLabel.AutoSize = True
        Me.MilesDrivenLabel.Location = New System.Drawing.Point(13, 13)
        Me.MilesDrivenLabel.Name = "MilesDrivenLabel"
        Me.MilesDrivenLabel.Size = New System.Drawing.Size(93, 13)
        Me.MilesDrivenLabel.TabIndex = 0
        Me.MilesDrivenLabel.Text = "Enter miles driven:"
        '
        'GallonsUsedLabel
        '
        Me.GallonsUsedLabel.AutoSize = True
        Me.GallonsUsedLabel.Location = New System.Drawing.Point(13, 44)
        Me.GallonsUsedLabel.Name = "GallonsUsedLabel"
        Me.GallonsUsedLabel.Size = New System.Drawing.Size(97, 13)
        Me.GallonsUsedLabel.TabIndex = 1
        Me.GallonsUsedLabel.Text = "Enter gallons used:"
        '
        'MilesDrivenTextBox
        '
        Me.MilesDrivenTextBox.Location = New System.Drawing.Point(113, 13)
        Me.MilesDrivenTextBox.Name = "MilesDrivenTextBox"
        Me.MilesDrivenTextBox.Size = New System.Drawing.Size(124, 20)
        Me.MilesDrivenTextBox.TabIndex = 2
        '
        'GallonsUsedTextBox
        '
        Me.GallonsUsedTextBox.Location = New System.Drawing.Point(113, 39)
        Me.GallonsUsedTextBox.Name = "GallonsUsedTextBox"
        Me.GallonsUsedTextBox.Size = New System.Drawing.Size(124, 20)
        Me.GallonsUsedTextBox.TabIndex = 3
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(113, 66)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(124, 23)
        Me.CalculateButton.TabIndex = 4
        Me.CalculateButton.Text = "Calculate MPG"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'MilesLabel
        '
        Me.MilesLabel.AutoSize = True
        Me.MilesLabel.Location = New System.Drawing.Point(16, 100)
        Me.MilesLabel.Name = "MilesLabel"
        Me.MilesLabel.Size = New System.Drawing.Size(34, 13)
        Me.MilesLabel.TabIndex = 5
        Me.MilesLabel.Text = "Miles:"
        '
        'MilesListBox
        '
        Me.MilesListBox.FormattingEnabled = True
        Me.MilesListBox.Location = New System.Drawing.Point(17, 119)
        Me.MilesListBox.Name = "MilesListBox"
        Me.MilesListBox.Size = New System.Drawing.Size(65, 82)
        Me.MilesListBox.TabIndex = 6
        '
        'GallonsLabel
        '
        Me.GallonsLabel.AutoSize = True
        Me.GallonsLabel.Location = New System.Drawing.Point(88, 100)
        Me.GallonsLabel.Name = "GallonsLabel"
        Me.GallonsLabel.Size = New System.Drawing.Size(45, 13)
        Me.GallonsLabel.TabIndex = 7
        Me.GallonsLabel.Text = "Gallons:"
        '
        'GallonsListBox
        '
        Me.GallonsListBox.FormattingEnabled = True
        Me.GallonsListBox.Location = New System.Drawing.Point(91, 119)
        Me.GallonsListBox.Name = "GallonsListBox"
        Me.GallonsListBox.Size = New System.Drawing.Size(73, 82)
        Me.GallonsListBox.TabIndex = 8
        '
        'MPGLabel
        '
        Me.MPGLabel.AutoSize = True
        Me.MPGLabel.Location = New System.Drawing.Point(171, 100)
        Me.MPGLabel.Name = "MPGLabel"
        Me.MPGLabel.Size = New System.Drawing.Size(31, 13)
        Me.MPGLabel.TabIndex = 9
        Me.MPGLabel.Text = "MPG"
        '
        'MPGListBox
        '
        Me.MPGListBox.FormattingEnabled = True
        Me.MPGListBox.Location = New System.Drawing.Point(174, 119)
        Me.MPGListBox.Name = "MPGListBox"
        Me.MPGListBox.Size = New System.Drawing.Size(69, 82)
        Me.MPGListBox.TabIndex = 10
        '
        'TotalsLabel
        '
        Me.TotalsLabel.AutoSize = True
        Me.TotalsLabel.Location = New System.Drawing.Point(16, 208)
        Me.TotalsLabel.Name = "TotalsLabel"
        Me.TotalsLabel.Size = New System.Drawing.Size(39, 13)
        Me.TotalsLabel.TabIndex = 11
        Me.TotalsLabel.Text = "Totals:"
        '
        'TotalsTextBox
        '
        Me.TotalsTextBox.Location = New System.Drawing.Point(12, 225)
        Me.TotalsTextBox.Multiline = True
        Me.TotalsTextBox.Name = "TotalsTextBox"
        Me.TotalsTextBox.ReadOnly = True
        Me.TotalsTextBox.Size = New System.Drawing.Size(231, 56)
        Me.TotalsTextBox.TabIndex = 12
        '
        'MilesPerGallonForn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 293)
        Me.Controls.Add(Me.TotalsTextBox)
        Me.Controls.Add(Me.TotalsLabel)
        Me.Controls.Add(Me.MPGListBox)
        Me.Controls.Add(Me.MPGLabel)
        Me.Controls.Add(Me.GallonsListBox)
        Me.Controls.Add(Me.GallonsLabel)
        Me.Controls.Add(Me.MilesListBox)
        Me.Controls.Add(Me.MilesLabel)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.GallonsUsedTextBox)
        Me.Controls.Add(Me.MilesDrivenTextBox)
        Me.Controls.Add(Me.GallonsUsedLabel)
        Me.Controls.Add(Me.MilesDrivenLabel)
        Me.Name = "MilesPerGallonForn"
        Me.Text = "Miles Per Gallon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MilesDrivenLabel As System.Windows.Forms.Label
    Friend WithEvents GallonsUsedLabel As System.Windows.Forms.Label
    Friend WithEvents MilesDrivenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GallonsUsedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents MilesLabel As System.Windows.Forms.Label
    Friend WithEvents MilesListBox As System.Windows.Forms.ListBox
    Friend WithEvents GallonsLabel As System.Windows.Forms.Label
    Friend WithEvents GallonsListBox As System.Windows.Forms.ListBox
    Friend WithEvents MPGLabel As System.Windows.Forms.Label
    Friend WithEvents MPGListBox As System.Windows.Forms.ListBox
    Friend WithEvents TotalsLabel As System.Windows.Forms.Label
    Friend WithEvents TotalsTextBox As System.Windows.Forms.TextBox

End Class
