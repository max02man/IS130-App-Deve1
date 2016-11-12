' Project name:         Conway Project
' Project purpose:      The project calculates a company's total domestic,
'                       total internainal, and total company sales made during
'                       a six-month period. 
' Created/revised by:   Alaa Hawsawi on 11/12/2012

Option Explicit On
Option Strict On
Option Infer Off
Public Class mainForm
    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub disButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disButton.Click
        Dim totals(,) As Integer = {{100000, 150000}, {90000, 120000},
                                      {75000, 210000}, {88000, 50000},
                                       {125000, 220000}, {63000, 80000}}
        Dim row As Integer = 0
        Dim dom As Integer
        Dim totaldom As Integer
        Dim int As Integer
        Dim totalint As Integer
        Dim com As Integer
        Do While row <= 5
            dom = totals(row, 0)
            int = totals(row, 1)
            totaldom += dom
            totalint += int
            row += 1
        Loop
        com = totaldom + totalint
        domLabel.Text = totaldom.ToString("c0")
        interLabel.Text = totalint.ToString("C0")
        compLabel.Text = com.ToString("C0")
    End Sub
End Class
