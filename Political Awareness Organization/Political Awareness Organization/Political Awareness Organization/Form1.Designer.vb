<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.partyListBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ageTextBox = New System.Windows.Forms.TextBox()
        Me.writeButton = New System.Windows.Forms.Button()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.inLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.reLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DeLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Party:"
        '
        'partyListBox
        '
        Me.partyListBox.FormattingEnabled = True
        Me.partyListBox.ItemHeight = 15
        Me.partyListBox.Location = New System.Drawing.Point(35, 48)
        Me.partyListBox.Name = "partyListBox"
        Me.partyListBox.Size = New System.Drawing.Size(122, 94)
        Me.partyListBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Age:"
        '
        'ageTextBox
        '
        Me.ageTextBox.Location = New System.Drawing.Point(196, 55)
        Me.ageTextBox.Name = "ageTextBox"
        Me.ageTextBox.Size = New System.Drawing.Size(70, 23)
        Me.ageTextBox.TabIndex = 3
        '
        'writeButton
        '
        Me.writeButton.Location = New System.Drawing.Point(332, 36)
        Me.writeButton.Name = "writeButton"
        Me.writeButton.Size = New System.Drawing.Size(118, 42)
        Me.writeButton.TabIndex = 4
        Me.writeButton.Text = "&Write to the file"
        Me.writeButton.UseVisualStyleBackColor = True
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(332, 82)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(118, 42)
        Me.displayButton.TabIndex = 5
        Me.displayButton.Text = "&Display Totals"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(332, 126)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(118, 42)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "Ex&it"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.inLabel)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.reLabel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DeLabel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 144)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totals"
        '
        'inLabel
        '
        Me.inLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inLabel.Location = New System.Drawing.Point(115, 98)
        Me.inLabel.Name = "inLabel"
        Me.inLabel.Size = New System.Drawing.Size(82, 29)
        Me.inLabel.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Independent:"
        '
        'reLabel
        '
        Me.reLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reLabel.Location = New System.Drawing.Point(115, 59)
        Me.reLabel.Name = "reLabel"
        Me.reLabel.Size = New System.Drawing.Size(82, 29)
        Me.reLabel.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Republicans:"
        '
        'DeLabel
        '
        Me.DeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeLabel.Location = New System.Drawing.Point(115, 18)
        Me.DeLabel.Name = "DeLabel"
        Me.DeLabel.Size = New System.Drawing.Size(82, 29)
        Me.DeLabel.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Democrats:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 316)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.writeButton)
        Me.Controls.Add(Me.ageTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.partyListBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.Text = "Political Awareness Organization"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents partyListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents writeButton As System.Windows.Forms.Button
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents inLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents reLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DeLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
