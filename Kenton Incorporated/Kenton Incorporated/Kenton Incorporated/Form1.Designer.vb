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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sto1Label = New System.Windows.Forms.Label()
        Me.sto2Label = New System.Windows.Forms.Label()
        Me.sto3Label = New System.Windows.Forms.Label()
        Me.comLabel = New System.Windows.Forms.Label()
        Me.calButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.comLabel)
        Me.GroupBox1.Controls.Add(Me.sto3Label)
        Me.GroupBox1.Controls.Add(Me.sto2Label)
        Me.GroupBox1.Controls.Add(Me.sto1Label)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(178, 192)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payroll amounts"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Store 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Store 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Store 3:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Company:"
        '
        'sto1Label
        '
        Me.sto1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sto1Label.Location = New System.Drawing.Point(77, 19)
        Me.sto1Label.Name = "sto1Label"
        Me.sto1Label.Size = New System.Drawing.Size(95, 27)
        Me.sto1Label.TabIndex = 4
        Me.sto1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sto2Label
        '
        Me.sto2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sto2Label.Location = New System.Drawing.Point(77, 61)
        Me.sto2Label.Name = "sto2Label"
        Me.sto2Label.Size = New System.Drawing.Size(95, 27)
        Me.sto2Label.TabIndex = 5
        Me.sto2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sto3Label
        '
        Me.sto3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sto3Label.Location = New System.Drawing.Point(77, 103)
        Me.sto3Label.Name = "sto3Label"
        Me.sto3Label.Size = New System.Drawing.Size(95, 27)
        Me.sto3Label.TabIndex = 6
        Me.sto3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'comLabel
        '
        Me.comLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.comLabel.Location = New System.Drawing.Point(77, 145)
        Me.comLabel.Name = "comLabel"
        Me.comLabel.Size = New System.Drawing.Size(95, 27)
        Me.comLabel.TabIndex = 7
        Me.comLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calButton
        '
        Me.calButton.Location = New System.Drawing.Point(238, 31)
        Me.calButton.Name = "calButton"
        Me.calButton.Size = New System.Drawing.Size(73, 27)
        Me.calButton.TabIndex = 1
        Me.calButton.Text = "&Calculate"
        Me.calButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(238, 77)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(73, 27)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "&Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 302)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kenton Incorporated"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents comLabel As System.Windows.Forms.Label
    Friend WithEvents sto3Label As System.Windows.Forms.Label
    Friend WithEvents sto2Label As System.Windows.Forms.Label
    Friend WithEvents sto1Label As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents calButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
