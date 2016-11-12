'Project name:             Ship With Us Project
'Project Purpose:          Allows the user to put in a Zip code in the first ListBox to = $15 or $20 ,
'                          for second to get the Shipping charge.
'Created/revised by:        Alaa Hawsawi on 10/15/2012
Option Explicit On
Option Strict On
Option Infer Off
Public Class mainForm

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub mainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'fills the list box with zip codes
        ListBox1.Items.Add("60611")
        ListBox1.Items.Add("60234")
        ListBox1.Items.Add("56789")
        ListBox1.Items.Add("23467")
        ListBox1.Items.Add("60543")
        ListBox1.Items.Add("60561")
        ListBox1.Items.Add("55905")
        ListBox1.Items.Add("89567")
        'fills the list box with second set of zip codes
        ListBox2.Items.Add("50978")
        ListBox2.Items.Add("78432")
        ListBox2.Items.Add("98432")
        ListBox2.Items.Add("97654")
        ListBox2.Items.Add("20245")


    End Sub

    Private Sub exitButton_Click(sender As System.Object, e As System.EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub displayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles displayButton.Click
        Dim zip As String
        'find zip for list box 1
        Dim isfound As Boolean
        Dim count As Integer
        Dim index As Integer
        zip = zipTextBox.Text.ToUpper
        count = ListBox1.Items.Count
        Do While index < count AndAlso isfound = False
            If zip = ListBox1.Items(index).ToString.ToUpper Then
                isfound = True
            Else
                index = index + 1
            End If
        Loop
        If isfound = True Then
            ListBox1.SelectedIndex = index
            priceLabel.Text = ("$15")

        End If
        'find zip in listbox 2
        Dim isfound2 As Boolean
        Dim count2 As Integer
        Dim index2 As Integer
        zip = zipTextBox.Text.ToUpper
        count2 = ListBox2.Items.Count
        Do While index2 < count2 AndAlso isfound2 = False
            If zip = ListBox2.Items(index2).ToString.ToUpper Then
                isfound2 = True
            Else
                index2 = index2 + 1
            End If
        Loop


        If isfound2 = True Then
            ListBox2.SelectedIndex = index2
            priceLabel.Text = ("$20")
        Else
            ListBox2.SelectedIndex = -1
            ListBox1.SelectedIndex = -1
            MessageBox.Show("Not found", "Shipping",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If

    End Sub
End Class
