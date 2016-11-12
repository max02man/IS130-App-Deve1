' Project name:         CD Collection Project
' Project purpose:      Allows the user to add and delete list box entries
'                       Reads CD information from a sequential access file
'                       Writes CD information to a sequential access file
' Created/revised by:   Alaa Hawsawi on 11/26/2012

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    ' define the product structure
    Structure product
        Public number As String
        Public price As Decimal
    End Structure
    'declare class-level array
    Private items(4) As product


    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'fills the list box with data 
        'stored in a sequential access file
        'decleare variable
        Dim infile As IO.StreamReader
        Dim filename As String = "iteminfo.txt"
        Dim x As Integer
        Dim fields() As String

        'verify that the file exists
        If IO.File.Exists(filename) Then
            infile = IO.File.OpenText(filename)
            Do Until infile.Peek = -1
                fields = infile.ReadLine.Split(","c)
                items(x).number = fields(0)
                items(x).price = Convert.ToDecimal(fields(1))
                numbersListBox.Items.Add(items(x).number)
                x += 1
            Loop
            infile.Close()
            numbersListBox.SelectedIndex = 0
        Else
            MessageBox.Show("can't find " & filename, "Glovers Industries",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub numbersListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numbersListBox.SelectedIndexChanged
        Dim index As Integer = numbersListBox.SelectedIndex
        priceLabel.Text = items(index).price.ToString("N2")
    End Sub
End Class
