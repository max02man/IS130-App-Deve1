' Project name:         Greenview Project
' Project purpose:      Displays a member's monthly dues
' Created/revised by:  Alaa on 9/26/2012

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As System.Object, e As System.EventArgs) Handles calcButton.Click

        'calculates the monthly dues, which include
        'a basic fee and optional charges
        Const TennisChg As Integer = 20
        Const racquetballchg As Integer = 10
        Dim monthlydues As Integer

        Integer.TryParse(basicTextBox.Text, monthlydues)

        'add anyadditional charges to the monthly dues
        If tennisCheckBox.Checked = True Then monthlydues += TennisChg

        If racquetballCheckBox.Checked = True Then monthlydues += racquetballchg


        'display the monthly dues
        monthlyDuesLabel.Text = monthlydues.ToString("c2")
    End Sub
End Class
