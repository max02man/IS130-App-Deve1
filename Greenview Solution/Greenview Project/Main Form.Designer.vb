<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.tennisCheckBox = New System.Windows.Forms.CheckBox()
        Me.racquetballCheckBox = New System.Windows.Forms.CheckBox()
        Me.monthlyDuesLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.basicTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(160, 123)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(97, 30)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(160, 89)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(97, 30)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate"
        '
        'tennisCheckBox
        '
        Me.tennisCheckBox.AutoSize = True
        Me.tennisCheckBox.Location = New System.Drawing.Point(169, 17)
        Me.tennisCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.tennisCheckBox.Name = "tennisCheckBox"
        Me.tennisCheckBox.Size = New System.Drawing.Size(61, 19)
        Me.tennisCheckBox.TabIndex = 2
        Me.tennisCheckBox.Text = "&Tennis"
        '
        'racquetballCheckBox
        '
        Me.racquetballCheckBox.AutoSize = True
        Me.racquetballCheckBox.Location = New System.Drawing.Point(169, 42)
        Me.racquetballCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.racquetballCheckBox.Name = "racquetballCheckBox"
        Me.racquetballCheckBox.Size = New System.Drawing.Size(88, 19)
        Me.racquetballCheckBox.TabIndex = 3
        Me.racquetballCheckBox.Text = "&Racquetball"
        '
        'monthlyDuesLabel
        '
        Me.monthlyDuesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monthlyDuesLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthlyDuesLabel.Location = New System.Drawing.Point(20, 100)
        Me.monthlyDuesLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.monthlyDuesLabel.Name = "monthlyDuesLabel"
        Me.monthlyDuesLabel.Size = New System.Drawing.Size(97, 53)
        Me.monthlyDuesLabel.TabIndex = 7
        Me.monthlyDuesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 83)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Monthly dues:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Basic monthly fee:"
        '
        'basicTextBox
        '
        Me.basicTextBox.Location = New System.Drawing.Point(20, 34)
        Me.basicTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.basicTextBox.Name = "basicTextBox"
        Me.basicTextBox.Size = New System.Drawing.Size(61, 23)
        Me.basicTextBox.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 177)
        Me.Controls.Add(Me.racquetballCheckBox)
        Me.Controls.Add(Me.tennisCheckBox)
        Me.Controls.Add(Me.basicTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.monthlyDuesLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Greenview Health Club"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents tennisCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents racquetballCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents monthlyDuesLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents basicTextBox As System.Windows.Forms.TextBox

End Class
