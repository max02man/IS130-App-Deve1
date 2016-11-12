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
        Me.maleRadioButton = New System.Windows.Forms.RadioButton()
        Me.activeRadioButton = New System.Windows.Forms.RadioButton()
        Me.femaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.inactiveRadioButton = New System.Windows.Forms.RadioButton()
        Me.genderGroupBox = New System.Windows.Forms.GroupBox()
        Me.actGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.weightTextBox = New System.Windows.Forms.TextBox()
        Me.Dailycalories = New System.Windows.Forms.Label()
        Me.dailyLabel = New System.Windows.Forms.Label()
        Me.calButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.genderGroupBox.SuspendLayout()
        Me.actGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'maleRadioButton
        '
        Me.maleRadioButton.AutoSize = True
        Me.maleRadioButton.Location = New System.Drawing.Point(15, 23)
        Me.maleRadioButton.Name = "maleRadioButton"
        Me.maleRadioButton.Size = New System.Drawing.Size(51, 19)
        Me.maleRadioButton.TabIndex = 0
        Me.maleRadioButton.TabStop = True
        Me.maleRadioButton.Text = "&Male"
        Me.maleRadioButton.UseVisualStyleBackColor = True
        '
        'activeRadioButton
        '
        Me.activeRadioButton.AutoSize = True
        Me.activeRadioButton.Location = New System.Drawing.Point(12, 23)
        Me.activeRadioButton.Name = "activeRadioButton"
        Me.activeRadioButton.Size = New System.Drawing.Size(58, 19)
        Me.activeRadioButton.TabIndex = 0
        Me.activeRadioButton.TabStop = True
        Me.activeRadioButton.Text = "&Active"
        Me.activeRadioButton.UseVisualStyleBackColor = True
        '
        'femaleRadioButton
        '
        Me.femaleRadioButton.AutoSize = True
        Me.femaleRadioButton.Location = New System.Drawing.Point(15, 65)
        Me.femaleRadioButton.Name = "femaleRadioButton"
        Me.femaleRadioButton.Size = New System.Drawing.Size(63, 19)
        Me.femaleRadioButton.TabIndex = 0
        Me.femaleRadioButton.TabStop = True
        Me.femaleRadioButton.Text = "&Female"
        Me.femaleRadioButton.UseVisualStyleBackColor = True
        '
        'inactiveRadioButton
        '
        Me.inactiveRadioButton.AutoSize = True
        Me.inactiveRadioButton.Location = New System.Drawing.Point(12, 65)
        Me.inactiveRadioButton.Name = "inactiveRadioButton"
        Me.inactiveRadioButton.Size = New System.Drawing.Size(66, 19)
        Me.inactiveRadioButton.TabIndex = 0
        Me.inactiveRadioButton.TabStop = True
        Me.inactiveRadioButton.Text = "&Inactive"
        Me.inactiveRadioButton.UseVisualStyleBackColor = True
        '
        'genderGroupBox
        '
        Me.genderGroupBox.Controls.Add(Me.femaleRadioButton)
        Me.genderGroupBox.Controls.Add(Me.maleRadioButton)
        Me.genderGroupBox.Location = New System.Drawing.Point(27, 36)
        Me.genderGroupBox.Name = "genderGroupBox"
        Me.genderGroupBox.Size = New System.Drawing.Size(128, 107)
        Me.genderGroupBox.TabIndex = 6
        Me.genderGroupBox.TabStop = False
        Me.genderGroupBox.Text = "Gender"
        '
        'actGroupBox
        '
        Me.actGroupBox.Controls.Add(Me.inactiveRadioButton)
        Me.actGroupBox.Controls.Add(Me.activeRadioButton)
        Me.actGroupBox.Location = New System.Drawing.Point(187, 36)
        Me.actGroupBox.Name = "actGroupBox"
        Me.actGroupBox.Size = New System.Drawing.Size(132, 107)
        Me.actGroupBox.TabIndex = 7
        Me.actGroupBox.TabStop = False
        Me.actGroupBox.Text = "Activity level"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(27, 163)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(48, 15)
        Me.Label.TabIndex = 0
        Me.Label.Text = "&Weight:"
        '
        'weightTextBox
        '
        Me.weightTextBox.Location = New System.Drawing.Point(30, 192)
        Me.weightTextBox.Name = "weightTextBox"
        Me.weightTextBox.Size = New System.Drawing.Size(79, 23)
        Me.weightTextBox.TabIndex = 1
        '
        'Dailycalories
        '
        Me.Dailycalories.AutoSize = True
        Me.Dailycalories.Location = New System.Drawing.Point(23, 230)
        Me.Dailycalories.Name = "Dailycalories"
        Me.Dailycalories.Size = New System.Drawing.Size(79, 15)
        Me.Dailycalories.TabIndex = 2
        Me.Dailycalories.Text = "Daily calories:"
        '
        'dailyLabel
        '
        Me.dailyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dailyLabel.Location = New System.Drawing.Point(23, 248)
        Me.dailyLabel.Name = "dailyLabel"
        Me.dailyLabel.Size = New System.Drawing.Size(114, 44)
        Me.dailyLabel.TabIndex = 3
        '
        'calButton
        '
        Me.calButton.Location = New System.Drawing.Point(221, 205)
        Me.calButton.Name = "calButton"
        Me.calButton.Size = New System.Drawing.Size(98, 25)
        Me.calButton.TabIndex = 4
        Me.calButton.Text = "&Display Calories"
        Me.calButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(221, 248)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(98, 25)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "&Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 302)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calButton)
        Me.Controls.Add(Me.dailyLabel)
        Me.Controls.Add(Me.Dailycalories)
        Me.Controls.Add(Me.weightTextBox)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.actGroupBox)
        Me.Controls.Add(Me.genderGroupBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.Text = "Willow Health Club"
        Me.genderGroupBox.ResumeLayout(False)
        Me.genderGroupBox.PerformLayout()
        Me.actGroupBox.ResumeLayout(False)
        Me.actGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents maleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents activeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents femaleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents inactiveRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents genderGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents actGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents weightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dailycalories As System.Windows.Forms.Label
    Friend WithEvents dailyLabel As System.Windows.Forms.Label
    Friend WithEvents calButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
