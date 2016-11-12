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
        Me.reportListBox = New System.Windows.Forms.ListBox()
        Me.reportButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Report:"
        '
        'reportListBox
        '
        Me.reportListBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportListBox.FormattingEnabled = True
        Me.reportListBox.ItemHeight = 16
        Me.reportListBox.Location = New System.Drawing.Point(40, 60)
        Me.reportListBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.reportListBox.Name = "reportListBox"
        Me.reportListBox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.reportListBox.Size = New System.Drawing.Size(348, 180)
        Me.reportListBox.TabIndex = 3
        Me.reportListBox.TabStop = False
        '
        'reportButton
        '
        Me.reportButton.Location = New System.Drawing.Point(416, 78)
        Me.reportButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.reportButton.Name = "reportButton"
        Me.reportButton.Size = New System.Drawing.Size(119, 35)
        Me.reportButton.TabIndex = 0
        Me.reportButton.Text = "&Dispaly Prepot"
        Me.reportButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(416, 150)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(119, 35)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "&Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 290)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.reportButton)
        Me.Controls.Add(Me.reportListBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yalanda Drapery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents reportListBox As System.Windows.Forms.ListBox
    Friend WithEvents reportButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
