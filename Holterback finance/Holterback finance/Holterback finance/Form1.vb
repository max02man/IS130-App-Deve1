' Project name:         Holterback Finance 
' Project purpose:      change the old password and reverse it
' Created/revised by:   Alaa Hawsawi on 11/20/2012

Option Explicit On
Option Strict On
Option Infer Off
Public Class Form1
    Private Sub oldTextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oldTextBox.Enter
        oldTextBox.SelectAll()
    End Sub
    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles displayButton.Click
        Dim old As String
        Dim newp As String
        old = oldTextBox.Text.Trim
        old.ToLower()

        old = (Replace(old, "0", "z"))
        old = (Replace(old, "1", "z"))
        old = (Replace(old, "2", "z"))
        old = (Replace(old, "3", "z"))
        old = (Replace(old, "4", "z"))
        old = (Replace(old, "5", "z"))
        old = (Replace(old, "6", "z"))
        old = (Replace(old, "7", "z"))
        old = (Replace(old, "8", "z"))
        old = (Replace(old, "9", "z"))
        old = (Replace(old, "a", "1"))
        old = (Replace(old, "e", "2"))
        old = (Replace(old, "i", "9"))
        old = (Replace(old, "o", "9"))
        old = (Replace(old, "u", "9"))
        newp = StrReverse(old)

        newLabel.Text = newp
    End Sub
End Class
