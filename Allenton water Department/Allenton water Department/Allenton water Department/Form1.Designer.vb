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
        Me.calbutton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.currentTextBox = New System.Windows.Forms.TextBox()
        Me.curLabel = New System.Windows.Forms.Label()
        Me.previousTextBox = New System.Windows.Forms.TextBox()
        Me.PrevLabel = New System.Windows.Forms.Label()
        Me.gallonsLabel = New System.Windows.Forms.Label()
        Me.galLabel = New System.Windows.Forms.Label()
        Me.totLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.mesLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'calbutton
        '
        Me.calbutton.Location = New System.Drawing.Point(201, 38)
        Me.calbutton.Name = "calbutton"
        Me.calbutton.Size = New System.Drawing.Size(74, 24)
        Me.calbutton.TabIndex = 0
        Me.calbutton.Text = "&Calculate"
        Me.calbutton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(199, 68)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(74, 24)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "&Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'currentTextBox
        '
        Me.currentTextBox.Location = New System.Drawing.Point(101, 42)
        Me.currentTextBox.Name = "currentTextBox"
        Me.currentTextBox.Size = New System.Drawing.Size(94, 20)
        Me.currentTextBox.TabIndex = 5
        '
        'curLabel
        '
        Me.curLabel.AutoSize = True
        Me.curLabel.Location = New System.Drawing.Point(11, 45)
        Me.curLabel.Name = "curLabel"
        Me.curLabel.Size = New System.Drawing.Size(87, 13)
        Me.curLabel.TabIndex = 4
        Me.curLabel.Text = "C&urrent Reading:"
        '
        'previousTextBox
        '
        Me.previousTextBox.Location = New System.Drawing.Point(101, 73)
        Me.previousTextBox.Name = "previousTextBox"
        Me.previousTextBox.Size = New System.Drawing.Size(94, 20)
        Me.previousTextBox.TabIndex = 7
        '
        'PrevLabel
        '
        Me.PrevLabel.AutoSize = True
        Me.PrevLabel.Location = New System.Drawing.Point(11, 76)
        Me.PrevLabel.Name = "PrevLabel"
        Me.PrevLabel.Size = New System.Drawing.Size(94, 13)
        Me.PrevLabel.TabIndex = 6
        Me.PrevLabel.Text = "&Previous Reading:"
        '
        'gallonsLabel
        '
        Me.gallonsLabel.AutoSize = True
        Me.gallonsLabel.Location = New System.Drawing.Point(12, 114)
        Me.gallonsLabel.Name = "gallonsLabel"
        Me.gallonsLabel.Size = New System.Drawing.Size(71, 13)
        Me.gallonsLabel.TabIndex = 8
        Me.gallonsLabel.Text = "Gallons used:"
        '
        'galLabel
        '
        Me.galLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.galLabel.Location = New System.Drawing.Point(101, 105)
        Me.galLabel.Name = "galLabel"
        Me.galLabel.Size = New System.Drawing.Size(110, 22)
        Me.galLabel.TabIndex = 9
        '
        'totLabel
        '
        Me.totLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totLabel.Location = New System.Drawing.Point(101, 143)
        Me.totLabel.Name = "totLabel"
        Me.totLabel.Size = New System.Drawing.Size(110, 22)
        Me.totLabel.TabIndex = 11
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Location = New System.Drawing.Point(11, 152)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(70, 13)
        Me.totalLabel.TabIndex = 10
        Me.totalLabel.Text = "Total charge:"
        '
        'mesLabel
        '
        Me.mesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesLabel.Location = New System.Drawing.Point(14, 185)
        Me.mesLabel.Name = "mesLabel"
        Me.mesLabel.Size = New System.Drawing.Size(235, 44)
        Me.mesLabel.TabIndex = 12
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.mesLabel)
        Me.Controls.Add(Me.totLabel)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.galLabel)
        Me.Controls.Add(Me.gallonsLabel)
        Me.Controls.Add(Me.previousTextBox)
        Me.Controls.Add(Me.PrevLabel)
        Me.Controls.Add(Me.currentTextBox)
        Me.Controls.Add(Me.curLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calbutton)
        Me.Name = "mainForm"
        Me.Text = "Allenton water Department"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calbutton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents currentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents curLabel As System.Windows.Forms.Label
    Friend WithEvents previousTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrevLabel As System.Windows.Forms.Label
    Friend WithEvents gallonsLabel As System.Windows.Forms.Label
    Friend WithEvents galLabel As System.Windows.Forms.Label
    Friend WithEvents totLabel As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents mesLabel As System.Windows.Forms.Label

End Class
