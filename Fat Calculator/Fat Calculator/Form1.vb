'project name:           Fat Calculator Project
'Project purpose:        Allows the user to enter a food's callories and grams 
'                        of fat. it then calculates the food's fat
'                        calories and fat percentage.
'Created/revised by:     Alaa on 9/26/2012
Option Explicit On
Option Strict On
Option Infer Off

Public Class mainForm

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles fatLabel.Click

    End Sub

    Private Sub calcButton_Click(sender As System.Object, e As System.EventArgs) Handles calcButton.Click
        'declare 
        Dim calories As Double
        Dim grams As Double
        Dim fatcalo As Double
        Dim fatper As Double
        'input
        Double.TryParse(caloTextBox.Text, calories)
        Double.TryParse(fatTextBox.Text, grams)
        fatcalo = grams * 9
        fatper = fatcalo / calories
        'display caluclation
        fatcaloLabel.Text = Convert.ToString(fatcalo)
        fatpercentLabel.Text = fatper.ToString("P1")
        'display message
        If fatper > 0.3 Then
            messageLabel.Text = "This food is high in fat"
        Else
            messageLabel.Text = "this food is not high in fat"
        End If
    End Sub

    Private Sub exitButton_Click(sender As System.Object, e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub fatpercentLabel_Click(sender As System.Object, e As System.EventArgs) Handles fatpercentLabel.Click

    End Sub
End Class
