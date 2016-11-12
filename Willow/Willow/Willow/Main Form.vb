' Project name:         Willow Health Club
' Project purpose:      display daily calories a person needs
' Created/revised by:   Alaa Hawsawi on 10/4/2012

Option Explicit On
Option Strict On
Option Infer Off
Public Class MainForm

    Private Sub exitButton_Click(sender As System.Object, e As System.EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub calButton_Click(sender As System.Object, e As System.EventArgs) Handles calButton.Click
        Dim weight As Integer
        Const maleact As Integer = 15
        Const maleinact As Integer = 13
        Const femaleact As Integer = 12
        Const femaleinact As Integer = 10
        Dim daily As Integer
        Integer.TryParse(weightTextBox.Text, weight)
        If maleRadioButton.Checked = True Then
            If activeRadioButton.Checked = True Then
                daily = weight * maleact
            ElseIf inactiveRadioButton.Checked = True Then
                daily = weight * maleinact
            End If
        End If
        If femaleRadioButton.Checked = True Then
            If activeRadioButton.Checked = True Then
                daily = weight * femaleact
            ElseIf inactiveRadioButton.Checked = True Then
                daily = weight * femaleinact
            End If
        End If
        'display
        dailyLabel.Text = daily.ToString() & " Calories per pound"
    End Sub

    Private Sub weightTextBox_keypress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles weightTextBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <>
            ControlChars.Back Then
            e.Handled = True
        End If

    End Sub
End Class
