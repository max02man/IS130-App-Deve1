' Project name:         CD Collection Project
' Project purpose:      Allows the user to add and delete list box entries
'                       Reads CD information from a sequential access file
'                       Writes CD information to a sequential access file
' Created/revised by:   Alaa Hawsawi on 11/26/2012

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_formClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Save the list box infromation
        Dim outfile As IO.StreamWriter
        'open then file for output
        outfile = IO.File.CreateText("Cds.txt")
        'write each cd in the list box
        For Each cd As String In cdsListBox.Items
            outfile.WriteLine(cd)

        Next cd

        'close the file
        outfile.Close()

    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'fills the list box with data 
        'stored in a sequential access file
        'decleare variable
        Dim infile As IO.StreamReader
        Dim filename As String = "cds.txt"
        Dim cdinfo As String

        'verify that the file exists
        If IO.File.Exists(filename) Then
            infile = IO.File.OpenText(filename)
            Do Until infile.Peek = -1
                cdinfo = infile.ReadLine
                cdsListBox.Items.Add(cdinfo)
            Loop
            infile.Close()
            cdsListBox.SelectedIndex = 0
        Else
            MessageBox.Show("can't find the cds.txt file", "CD Collection",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        'adds CD infronation to the the list box

        'declare Varibles 
        Dim inputName As String
        Dim inputArtist As String
        Dim inputPrice As String
        Dim concatenateInfo As String
        Dim price As Double

        'get the CD information
        inputName = InputBox("CD name: ", "CD collection")
        inputArtist = InputBox("Artist: ", "CD collection")
        inputPrice = InputBox("Price: ", "CD collection")

        'format the price, then concatenate the inout items,
        'using 40 characters for the CD name,
        ' 25 characters for artist name and 5 character for price
        Double.TryParse(inputPrice, price)
        inputPrice = price.ToString("n2")
        concatenateInfo = inputName.PadRight(40) & inputArtist.PadRight(25) & inputPrice.PadLeft(5)
        'add the inforatiion to the list box
        cdsListBox.Items.Add(concatenateInfo)
    End Sub

    Private Sub removeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeButton.Click
        'remove the selected Cd from the list box
        Dim index As Integer = cdsListBox.SelectedIndex

        If index <> -1 Then
            cdsListBox.Items.Remove(index)
        End If
    End Sub
End Class
