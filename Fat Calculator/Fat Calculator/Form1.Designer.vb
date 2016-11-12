<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.calorLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.fatLabel = New System.Windows.Forms.Label()
        Me.fatcaloLabel = New System.Windows.Forms.Label()
        Me.fatpercentLabel = New System.Windows.Forms.Label()
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.caloTextBox = New System.Windows.Forms.TextBox()
        Me.fatTextBox = New System.Windows.Forms.TextBox()
        Me.fatcalorieslabel = New System.Windows.Forms.Label()
        Me.fatperLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'calorLabel
        '
        Me.calorLabel.AutoSize = True
        Me.calorLabel.Location = New System.Drawing.Point(12, 19)
        Me.calorLabel.Name = "calorLabel"
        Me.calorLabel.Size = New System.Drawing.Size(52, 15)
        Me.calorLabel.TabIndex = 0
        Me.calorLabel.Text = "&Calories:"
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(240, 37)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(77, 27)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(238, 91)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(77, 27)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'fatLabel
        '
        Me.fatLabel.AutoSize = True
        Me.fatLabel.Location = New System.Drawing.Point(113, 19)
        Me.fatLabel.Name = "fatLabel"
        Me.fatLabel.Size = New System.Drawing.Size(62, 15)
        Me.fatLabel.TabIndex = 2
        Me.fatLabel.Text = "&Fat grams:"
        '
        'fatcaloLabel
        '
        Me.fatcaloLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fatcaloLabel.Location = New System.Drawing.Point(12, 96)
        Me.fatcaloLabel.Name = "fatcaloLabel"
        Me.fatcaloLabel.Size = New System.Drawing.Size(88, 22)
        Me.fatcaloLabel.TabIndex = 8
        Me.fatcaloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fatpercentLabel
        '
        Me.fatpercentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fatpercentLabel.Location = New System.Drawing.Point(116, 96)
        Me.fatpercentLabel.Name = "fatpercentLabel"
        Me.fatpercentLabel.Size = New System.Drawing.Size(88, 22)
        Me.fatpercentLabel.TabIndex = 9
        Me.fatpercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'messageLabel
        '
        Me.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.messageLabel.Location = New System.Drawing.Point(12, 132)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(303, 61)
        Me.messageLabel.TabIndex = 10
        Me.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'caloTextBox
        '
        Me.caloTextBox.Location = New System.Drawing.Point(12, 37)
        Me.caloTextBox.Name = "caloTextBox"
        Me.caloTextBox.Size = New System.Drawing.Size(69, 23)
        Me.caloTextBox.TabIndex = 1
        '
        'fatTextBox
        '
        Me.fatTextBox.Location = New System.Drawing.Point(116, 37)
        Me.fatTextBox.Name = "fatTextBox"
        Me.fatTextBox.Size = New System.Drawing.Size(69, 23)
        Me.fatTextBox.TabIndex = 3
        '
        'fatcalorieslabel
        '
        Me.fatcalorieslabel.AutoSize = True
        Me.fatcalorieslabel.Location = New System.Drawing.Point(12, 78)
        Me.fatcalorieslabel.Name = "fatcalorieslabel"
        Me.fatcalorieslabel.Size = New System.Drawing.Size(69, 15)
        Me.fatcalorieslabel.TabIndex = 6
        Me.fatcalorieslabel.Text = "Fat calories:"
        '
        'fatperLabel
        '
        Me.fatperLabel.AutoSize = True
        Me.fatperLabel.Location = New System.Drawing.Point(117, 78)
        Me.fatperLabel.Name = "fatperLabel"
        Me.fatperLabel.Size = New System.Drawing.Size(88, 15)
        Me.fatperLabel.TabIndex = 7
        Me.fatperLabel.Text = "Fat percentage:"
        '
        'mainForm
        '
        Me.AcceptButton = Me.calcButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 205)
        Me.Controls.Add(Me.fatperLabel)
        Me.Controls.Add(Me.fatcalorieslabel)
        Me.Controls.Add(Me.fatTextBox)
        Me.Controls.Add(Me.caloTextBox)
        Me.Controls.Add(Me.messageLabel)
        Me.Controls.Add(Me.fatpercentLabel)
        Me.Controls.Add(Me.fatcaloLabel)
        Me.Controls.Add(Me.fatLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.calorLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fat Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calorLabel As System.Windows.Forms.Label
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents fatLabel As System.Windows.Forms.Label
    Friend WithEvents fatcaloLabel As System.Windows.Forms.Label
    Friend WithEvents fatpercentLabel As System.Windows.Forms.Label
    Friend WithEvents messageLabel As System.Windows.Forms.Label
    Friend WithEvents caloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents fatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents fatcalorieslabel As System.Windows.Forms.Label
    Friend WithEvents fatperLabel As System.Windows.Forms.Label

End Class
