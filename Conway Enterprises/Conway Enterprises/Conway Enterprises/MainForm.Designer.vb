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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.domLabel = New System.Windows.Forms.Label()
        Me.interLabel = New System.Windows.Forms.Label()
        Me.compLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.disButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Domestic:"
        '
        'domLabel
        '
        Me.domLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.domLabel.Location = New System.Drawing.Point(151, 29)
        Me.domLabel.Name = "domLabel"
        Me.domLabel.Size = New System.Drawing.Size(145, 37)
        Me.domLabel.TabIndex = 1
        Me.domLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'interLabel
        '
        Me.interLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.interLabel.Location = New System.Drawing.Point(151, 76)
        Me.interLabel.Name = "interLabel"
        Me.interLabel.Size = New System.Drawing.Size(145, 37)
        Me.interLabel.TabIndex = 2
        Me.interLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'compLabel
        '
        Me.compLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.compLabel.Location = New System.Drawing.Point(151, 122)
        Me.compLabel.Name = "compLabel"
        Me.compLabel.Size = New System.Drawing.Size(145, 37)
        Me.compLabel.TabIndex = 3
        Me.compLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total International:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total Company:"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(204, 183)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(110, 29)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "&Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'disButton
        '
        Me.disButton.Location = New System.Drawing.Point(45, 183)
        Me.disButton.Name = "disButton"
        Me.disButton.Size = New System.Drawing.Size(110, 29)
        Me.disButton.TabIndex = 7
        Me.disButton.Text = "&Display Totals"
        Me.disButton.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 240)
        Me.Controls.Add(Me.disButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.compLabel)
        Me.Controls.Add(Me.interLabel)
        Me.Controls.Add(Me.domLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "mainForm"
        Me.Text = "Conwat Enterprises"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents domLabel As System.Windows.Forms.Label
    Friend WithEvents interLabel As System.Windows.Forms.Label
    Friend WithEvents compLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents disButton As System.Windows.Forms.Button

End Class
