'project name:           Allenton water Department Project
'Project purpose:        Allows the user to enter current meter reading of water 
'                        and pervious meter reading too the applaction should
'                        calculate gallons of water used
'Created/revised by:     Alaa on 9/27/2012

Option Explicit On
Option Strict On
Option Infer Off

Public Class mainForm

    Private Sub exitButton_Click(sender As System.Object, e As System.EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub calbutton_Click(sender As System.Object, e As System.EventArgs) Handles calbutton.Click
        'declare
        Dim current As Double
        Dim previous As Double
        Const gallons As Double = 0.00175
        Dim total As Double
        Dim used As Double
        'assgn
        Double.TryParse(currentTextBox.Text, current)
        Double.TryParse(previousTextBox.Text, previous)
        'calculate
        used = current - previous
        If current >= previous Then
            total = gallons * used
            totLabel.Text = total.ToString("c2")
            galLabel.Text = used.ToString()
        Else
            mesLabel.Text = "Error!!! The current reading should be greater than previous reading"
        End If



    End Sub
End Class
