' Project name:         Political Awareness Organization Project
' Project purpose:      Allows the user to enter their politcal party and age
'                       writes the user's party and age to a sequential access file
'                       reads user infromation from a sequential access file
' Created/revised by:   Alaa Hawsawi on 11/29/2012

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        partyListBox.Items.Add("D")
        partyListBox.Items.Add("R")
        partyListBox.Items.Add("I")

    End Sub
    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub writeButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles writeButton.Click
        Dim outFile As IO.StreamWriter
        Dim age As String
        Dim party As String

        age = ageTextBox.Text
        party = CStr(partyListBox.SelectedItem)
        outFile = IO.File.AppendText("filename.txt")

        outFile.WriteLine(party & " " & age)

        outFile.Close()

    End Sub

    Private Sub displayButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles displayButton.Click

        Dim inFile As IO.StreamReader
        Dim fileName As String = "filename.txt"

        Dim decounter As Integer
        Dim recounter As Integer
        Dim incounter As Integer
        Dim first As Char

        If IO.File.Exists(fileName) Then
            inFile = IO.File.OpenText(fileName)
            Do Until inFile.Peek = -1
                first = CChar(inFile.ReadLine)
                If first = "D" Then
                    decounter += 1
                End If
                If first = "R" Then
                    recounter += 1
                End If
                If first = "I" Then
                    incounter += 1
                End If
            Loop
            inFile.Close()
        Else
            MessageBox.Show("Can't find the filename.txt file",
            "Political Awareness Organization",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

        End If

        DeLabel.Text = decounter.ToString
        reLabel.Text = recounter.ToString
        inLabel.Text = incounter.ToString

    End Sub
End Class
