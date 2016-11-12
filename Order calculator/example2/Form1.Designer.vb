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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.totalpoundslabel = New System.Windows.Forms.Label()
        Me.totalpricelabel = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.cityTextBox = New System.Windows.Forms.TextBox()
        Me.stateTextBox = New System.Windows.Forms.TextBox()
        Me.zipTextBox = New System.Windows.Forms.TextBox()
        Me.regularTextBox = New System.Windows.Forms.TextBox()
        Me.decafTextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 37)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Order Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 210)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 278)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ci&ty:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 400)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "&State:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(147, 400)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "&ZIP:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(255, 400)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "&Regular:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(363, 400)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "&Decaf:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(467, 129)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Pounds ordered:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(467, 210)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Total price:"
        '
        'totalpoundslabel
        '
        Me.totalpoundslabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalpoundslabel.Location = New System.Drawing.Point(471, 160)
        Me.totalpoundslabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.totalpoundslabel.Name = "totalpoundslabel"
        Me.totalpoundslabel.Size = New System.Drawing.Size(149, 28)
        Me.totalpoundslabel.TabIndex = 19
        Me.totalpoundslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalpricelabel
        '
        Me.totalpricelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalpricelabel.Location = New System.Drawing.Point(471, 230)
        Me.totalpricelabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.totalpricelabel.Name = "totalpricelabel"
        Me.totalpricelabel.Size = New System.Drawing.Size(149, 28)
        Me.totalpricelabel.TabIndex = 21
        Me.totalpricelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(40, 164)
        Me.nameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(348, 22)
        Me.nameTextBox.TabIndex = 1
        '
        'addressTextBox
        '
        Me.addressTextBox.Location = New System.Drawing.Point(40, 230)
        Me.addressTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(348, 22)
        Me.addressTextBox.TabIndex = 3
        '
        'cityTextBox
        '
        Me.cityTextBox.Location = New System.Drawing.Point(40, 298)
        Me.cityTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cityTextBox.Name = "cityTextBox"
        Me.cityTextBox.Size = New System.Drawing.Size(348, 22)
        Me.cityTextBox.TabIndex = 5
        '
        'stateTextBox
        '
        Me.stateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.stateTextBox.Location = New System.Drawing.Point(40, 432)
        Me.stateTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.stateTextBox.MaxLength = 2
        Me.stateTextBox.Name = "stateTextBox"
        Me.stateTextBox.Size = New System.Drawing.Size(67, 22)
        Me.stateTextBox.TabIndex = 7
        '
        'zipTextBox
        '
        Me.zipTextBox.Location = New System.Drawing.Point(151, 431)
        Me.zipTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.zipTextBox.Name = "zipTextBox"
        Me.zipTextBox.Size = New System.Drawing.Size(64, 22)
        Me.zipTextBox.TabIndex = 9
        '
        'regularTextBox
        '
        Me.regularTextBox.Location = New System.Drawing.Point(259, 432)
        Me.regularTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.regularTextBox.Name = "regularTextBox"
        Me.regularTextBox.Size = New System.Drawing.Size(64, 22)
        Me.regularTextBox.TabIndex = 11
        '
        'decafTextBox
        '
        Me.decafTextBox.Location = New System.Drawing.Point(367, 432)
        Me.decafTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.decafTextBox.Name = "decafTextBox"
        Me.decafTextBox.Size = New System.Drawing.Size(64, 22)
        Me.decafTextBox.TabIndex = 13
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(471, 282)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(148, 26)
        Me.calcButton.TabIndex = 14
        Me.calcButton.Text = "&Calcuate Order"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(471, 336)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(148, 26)
        Me.PrintButton.TabIndex = 15
        Me.PrintButton.Text = "&Print Order"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(471, 390)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(148, 26)
        Me.ClearButton.TabIndex = 16
        Me.ClearButton.Text = "C&lear Order"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(472, 444)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(148, 26)
        Me.exitButton.TabIndex = 17
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 607)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.decafTextBox)
        Me.Controls.Add(Me.regularTextBox)
        Me.Controls.Add(Me.zipTextBox)
        Me.Controls.Add(Me.stateTextBox)
        Me.Controls.Add(Me.cityTextBox)
        Me.Controls.Add(Me.addressTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.totalpricelabel)
        Me.Controls.Add(Me.totalpoundslabel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "mainForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents totalpoundslabel As System.Windows.Forms.Label
    Friend WithEvents totalpricelabel As System.Windows.Forms.Label
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents addressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents stateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents zipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents regularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents decafTextBox As System.Windows.Forms.TextBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
