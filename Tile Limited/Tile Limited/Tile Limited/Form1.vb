Option Explicit On
Option Infer Off
Option Strict On

Public Class Form

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles toLabel.Click

    End Sub
    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles totalLabel.Click

    End Sub

    Private Sub exitButton_Click(sender As System.Object, e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub caluButton_Click(sender As System.Object, e As System.EventArgs) Handles caluButton.Click
        'declear named constant and variables
        Dim length As Integer
        Dim width As Integer
        Dim price As Double
        Dim area As Integer
        Dim total As Double
        'assign input to variables
        Integer.TryParse(leTextBox.Text, length)
        Integer.TryParse(wiTextBox.Text, width)
        Double.TryParse(prTextBox.Text, price)
        ' make calu
        area = length * width
        total = area * price
        'display
        arLabel.Text = area.ToString()
        toLabel.Text = total.ToString("c2")
    End Sub
End Class
