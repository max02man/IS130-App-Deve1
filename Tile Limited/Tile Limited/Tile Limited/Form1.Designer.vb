<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.caluButton = New System.Windows.Forms.Button()
        Me.leTextBox = New System.Windows.Forms.TextBox()
        Me.wiTextBox = New System.Windows.Forms.TextBox()
        Me.prTextBox = New System.Windows.Forms.TextBox()
        Me.lengthLabel = New System.Windows.Forms.Label()
        Me.widthLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.AreaLabel = New System.Windows.Forms.Label()
        Me.arLabel = New System.Windows.Forms.Label()
        Me.toLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(150, 171)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(62, 24)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "&Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'caluButton
        '
        Me.caluButton.Location = New System.Drawing.Point(150, 133)
        Me.caluButton.Name = "caluButton"
        Me.caluButton.Size = New System.Drawing.Size(59, 22)
        Me.caluButton.TabIndex = 1
        Me.caluButton.Text = "&Calculate"
        Me.caluButton.UseVisualStyleBackColor = True
        '
        'leTextBox
        '
        Me.leTextBox.Location = New System.Drawing.Point(30, 60)
        Me.leTextBox.Name = "leTextBox"
        Me.leTextBox.Size = New System.Drawing.Size(81, 20)
        Me.leTextBox.TabIndex = 2
        '
        'wiTextBox
        '
        Me.wiTextBox.Location = New System.Drawing.Point(30, 115)
        Me.wiTextBox.Name = "wiTextBox"
        Me.wiTextBox.Size = New System.Drawing.Size(81, 20)
        Me.wiTextBox.TabIndex = 3
        '
        'prTextBox
        '
        Me.prTextBox.Location = New System.Drawing.Point(30, 170)
        Me.prTextBox.Name = "prTextBox"
        Me.prTextBox.Size = New System.Drawing.Size(81, 20)
        Me.prTextBox.TabIndex = 4
        '
        'lengthLabel
        '
        Me.lengthLabel.AutoSize = True
        Me.lengthLabel.Location = New System.Drawing.Point(27, 36)
        Me.lengthLabel.Name = "lengthLabel"
        Me.lengthLabel.Size = New System.Drawing.Size(73, 13)
        Me.lengthLabel.TabIndex = 5
        Me.lengthLabel.Text = "&Length (Feet):"
        '
        'widthLabel
        '
        Me.widthLabel.AutoSize = True
        Me.widthLabel.Location = New System.Drawing.Point(27, 91)
        Me.widthLabel.Name = "widthLabel"
        Me.widthLabel.Size = New System.Drawing.Size(68, 13)
        Me.widthLabel.TabIndex = 6
        Me.widthLabel.Text = "&Width (Feet):"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Location = New System.Drawing.Point(27, 146)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(81, 13)
        Me.priceLabel.TabIndex = 7
        Me.priceLabel.Text = "&Price (sq. Feet):"
        '
        'AreaLabel
        '
        Me.AreaLabel.AutoSize = True
        Me.AreaLabel.Location = New System.Drawing.Point(137, 36)
        Me.AreaLabel.Name = "AreaLabel"
        Me.AreaLabel.Size = New System.Drawing.Size(29, 13)
        Me.AreaLabel.TabIndex = 8
        Me.AreaLabel.Text = "Area"
        '
        'arLabel
        '
        Me.arLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.arLabel.Location = New System.Drawing.Point(140, 60)
        Me.arLabel.Name = "arLabel"
        Me.arLabel.Size = New System.Drawing.Size(81, 20)
        Me.arLabel.TabIndex = 9
        '
        'toLabel
        '
        Me.toLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.toLabel.Location = New System.Drawing.Point(140, 110)
        Me.toLabel.Name = "toLabel"
        Me.toLabel.Size = New System.Drawing.Size(81, 20)
        Me.toLabel.TabIndex = 11
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Location = New System.Drawing.Point(137, 86)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(58, 13)
        Me.totalLabel.TabIndex = 10
        Me.totalLabel.Text = "Total Price"
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 206)
        Me.Controls.Add(Me.toLabel)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.arLabel)
        Me.Controls.Add(Me.AreaLabel)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.widthLabel)
        Me.Controls.Add(Me.lengthLabel)
        Me.Controls.Add(Me.prTextBox)
        Me.Controls.Add(Me.wiTextBox)
        Me.Controls.Add(Me.leTextBox)
        Me.Controls.Add(Me.caluButton)
        Me.Controls.Add(Me.exitButton)
        Me.Name = "Form"
        Me.Text = "Tile Limited"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents caluButton As System.Windows.Forms.Button
    Friend WithEvents leTextBox As System.Windows.Forms.TextBox
    Friend WithEvents wiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents prTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lengthLabel As System.Windows.Forms.Label
    Friend WithEvents widthLabel As System.Windows.Forms.Label
    Friend WithEvents priceLabel As System.Windows.Forms.Label
    Friend WithEvents AreaLabel As System.Windows.Forms.Label
    Friend WithEvents arLabel As System.Windows.Forms.Label
    Friend WithEvents toLabel As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label

End Class
