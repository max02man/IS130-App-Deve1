' Project name:        Kenton Incorporated
' Project purpose:     display payroll for three stores 
' Created/revised by:  Alaa Hawsawi on 

Option Explicit On
Option Strict On
Option Infer Off
Public Class mainForm

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calButton.Click
        Dim instore As String
        Dim store As Double
        Dim storeaccumlator As Double
        Dim compaccumlator As Double

        'clear the lable
        sto1Label.Text = String.Empty
        sto2Label.Text = String.Empty
        sto3Label.Text = String.Empty
        comLabel.Text = String.Empty

        For stores As Integer = 1 To 3
            For paymeant As Integer = 1 To 5
                instore = InputBox("sales for store " & paymeant.ToString, "store " & stores.ToString)
                Double.TryParse(instore, store)
                storeaccumlator += store

            Next paymeant
            compaccumlator += storeaccumlator
            'display 
            If stores.ToString = "1" Then
                sto1Label.Text = sto1Label.Text & storeaccumlator.ToString("c2")
            ElseIf stores.ToString = "2" Then
                sto2Label.Text = sto2Label.Text & storeaccumlator.ToString("c2")
            Else
                sto3Label.Text = sto3Label.Text & storeaccumlator.ToString("c2")
            End If
            storeaccumlator = 0
        Next stores

        comLabel.Text = compaccumlator.ToString("C2")


    End Sub
End Class
