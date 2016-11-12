'Project Name:          Vita Credit
'Project Purpose:       Generates the fifth number of a credit card
'Created/revised by:    Alaa Hawsawi

Option Explicit On
Option Strict On
Option Infer Off

Imports System.IO


Public Class Form1

    Private _streamWriter As StreamWriter

    Private Property StreamWriter(p1 As String) As StreamWriter
        Get
            Return _streamWriter
        End Get
        Set(value As StreamWriter)
            _streamWriter = value
        End Set
    End Property



    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub generateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generateButton.Click

        'declare variables
        Dim input As String
        'assign variable to the textbox`s text
        input = digitTextBox.Text
        'access second and last digit
        Dim fNum As String = input.Substring(0, 1)
        Dim sNum As String = input.Substring(1, 1)
        Dim tNum As String = input.Substring(2, 1)
        Dim lNum As String = input.Substring(3, 1)
        'second number times 2
        Dim generate As Double
        'last number times 2
        Dim generate2 As Double
        Dim sum As Double
        Dim sumIndex As String
        'last number of sum
        Dim addition As String 'last number of sum
        'declare variable for the fifth digit
        Dim getNew As String
        If IsNumeric(input) Then
            generate = CDbl(sNum) * 2
            generate2 = CDbl(lNum) * 2
            sum = CDbl(fNum) + generate + CDbl(tNum) + generate2
            sumIndex = CStr(sum)
            If sum < 10 Then
                addition = sumIndex.Substring(0, 1)
                getNew = input.Insert(4, addition)
            ElseIf sum < 100 Then
                addition = sumIndex.Substring(1, 1)
                getNew = input.Insert(4, addition)
            Else
                addition = sumIndex.Substring(2, 1)
                getNew = input.Insert(4, addition)
            End If
            creditLabel.Text = getNew.ToString()


        Else
            MessageBox.Show("Invalid Entry",
                            "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'decler variables for add money
        Dim money As String
        Dim money1 As Integer

        If addRadioButton.Checked Then

            Dim counter As Integer = 1
            Do While counter < 2
                money = InputBox("How much would you like to add to you Account")
                Integer.TryParse(money, money1)
                counter += 1
            Loop

            Dim outfile As StreamWriter = New StreamWriter("check.txt", True)
            Dim filename As String = "check.txt"
            ' write to the file
            If IO.File.Exists(filename) Then

                outfile.WriteLine(getNew & " , " & money1.ToString("c0"))

                outfile.Close()
            Else
                MessageBox.Show("Don't have the file",
                           "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        Dim check As String
        Dim check1 As Integer
        If checkRadioButton.Checked Then

            Dim counter As Integer = 1
            Do While counter < 2
                check = InputBox("type your crudt card number")
                Integer.TryParse(check, check1)
                counter += 1
            Loop
            Dim infile As StreamReader
            Dim filename As String = "check.txt"
            Dim info As String
            If IO.File.Exists(filename) Then
                infile = IO.File.OpenText(filename)
                info = infile.ReadLine
                Dim x As Integer = 0
                Do Until infile.Peek = -1
                    If check = info.Substring(0, 4) Then
                        MessageBox.Show(info.Substring(0, 5) & " is exist, and you have " &
                                        info.Substring(7))
                        infile.Close()
                    Else
                        MessageBox.Show(check & " is not exist")
                    End If

                Loop
            End If
        End If
    End Sub

End Class
