' Project name:         Yolanda Drapery Project
' Project purpose:      Display a report, but only 
'                       if the user enters a valid password
' Created/revised by:   Alaa Hawsawi on 11/16/2012

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private salespeople() As String = {"Janice Sterns", "lois Kim",
                                     "Robert Pfeiffer",
                                     "joseph Bonazo",
                                     "Chris Vans"}
    Private bonus() As Integer = {3456, 457, 560, 3000, 425}

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub reportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reportButton.Click
        'display either the name or the name and bonus
        Dim password As String

        'clear list box
        reportListBox.Items.Clear()

        'get password
        password = InputBox("Password:", "Password Entry")

        'determine whether passwod is valid
        If password Like "[a-z]##[EM]3[a-d]#" Then
            Const namehead As String = "Name"
            Const bonushead As String = "Bonus $"
            Dim line As String

            ' dispaly column headers
            reportListBox.Items.Add(namehead.PadRight(20) & bonushead.PadLeft(8))
            'display report
            For x As Integer = 0 To 4
                line = salespeople(x).PadRight(20) & bonus(x).ToString("NO").PadLeft(8)
                reportListBox.Items.Add(line)

            Next x
        Else
            MessageBox.Show("Invalid password", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
End Class
