<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.digitTextBox = New System.Windows.Forms.TextBox()
        Me.creditLabel = New System.Windows.Forms.Label()
        Me.generateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.addRadioButton = New System.Windows.Forms.RadioButton()
        Me.checkRadioButton = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Enter First Four Digits:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Credit Card Number:"
        '
        'digitTextBox
        '
        Me.digitTextBox.Location = New System.Drawing.Point(14, 81)
        Me.digitTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.digitTextBox.Name = "digitTextBox"
        Me.digitTextBox.Size = New System.Drawing.Size(116, 25)
        Me.digitTextBox.TabIndex = 2
        '
        'creditLabel
        '
        Me.creditLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.creditLabel.Location = New System.Drawing.Point(14, 166)
        Me.creditLabel.Name = "creditLabel"
        Me.creditLabel.Size = New System.Drawing.Size(136, 35)
        Me.creditLabel.TabIndex = 3
        Me.creditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'generateButton
        '
        Me.generateButton.Location = New System.Drawing.Point(221, 68)
        Me.generateButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.generateButton.Name = "generateButton"
        Me.generateButton.Size = New System.Drawing.Size(191, 49)
        Me.generateButton.TabIndex = 4
        Me.generateButton.Text = "&Credit Card Number"
        Me.generateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(221, 159)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(191, 49)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'addRadioButton
        '
        Me.addRadioButton.AutoSize = True
        Me.addRadioButton.Location = New System.Drawing.Point(17, 236)
        Me.addRadioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.addRadioButton.Name = "addRadioButton"
        Me.addRadioButton.Size = New System.Drawing.Size(94, 21)
        Me.addRadioButton.TabIndex = 6
        Me.addRadioButton.TabStop = True
        Me.addRadioButton.Text = "Add Money"
        Me.addRadioButton.UseVisualStyleBackColor = True
        '
        'checkRadioButton
        '
        Me.checkRadioButton.AutoSize = True
        Me.checkRadioButton.Location = New System.Drawing.Point(278, 236)
        Me.checkRadioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.checkRadioButton.Name = "checkRadioButton"
        Me.checkRadioButton.Size = New System.Drawing.Size(64, 21)
        Me.checkRadioButton.TabIndex = 7
        Me.checkRadioButton.TabStop = True
        Me.checkRadioButton.Text = "Check "
        Me.checkRadioButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 290)
        Me.Controls.Add(Me.checkRadioButton)
        Me.Controls.Add(Me.addRadioButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.generateButton)
        Me.Controls.Add(Me.creditLabel)
        Me.Controls.Add(Me.digitTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vita Credit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents digitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents creditLabel As System.Windows.Forms.Label
    Friend WithEvents generateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents addRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents checkRadioButton As System.Windows.Forms.RadioButton

End Class
