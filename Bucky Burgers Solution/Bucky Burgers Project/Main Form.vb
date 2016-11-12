' Project name:         Bucky Burgers Project
' Project purpose:      Add names in proper case 
'                       to a list box and print
'                       the interface
' Created/revised by:   Alaa Hawsawi on 11/16/2012

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub nameTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles nameTextBox.Enter
        ' select the existing text

        nameTextBox.SelectAll()
    End Sub

    Private Sub fileprintMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filePrintMenuItem.Click
        ' Send the printout to the print preview window

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub fileExitMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fileExitMenuItem.Click
        Me.Close()
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        'add names in proper case to the list box

        Dim fullname As String
        Dim firstname As String
        Dim lastname As String
        Dim index As Integer

        fullname = nameTextBox.Text.Trim
        If fullname = String.Empty Then
            MessageBox.Show("Please enter a name", "Bucky Burgers",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'locate the space
            index = fullname.IndexOf(" ")
            If index > -1 Then
                'separate first and last names
                firstname = fullname.Substring(0, index)
                lastname = fullname.Substring(index + 1)
                'change first name to proper case
                firstname = firstname.Substring(0, 1).ToUpper &
                firstname.Substring(1).ToLower
                'change last name to proper case
                lastname = lastname.Substring(0, 1).ToUpper &
               lastname.Substring(1).ToLower
                fullname = firstname & " " & lastname
            Else    'no space in name
                fullname = fullname.Substring(0, 1).ToUpper &
                    fullname.Substring(1).ToLower
            End If
            'add full name to list box
            namesListBox.Items.Add(fullname)
        End If
        nameTextBox.Focus()
        nameTextBox.SelectAll()
    End Sub
End Class
