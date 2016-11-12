' Project name:         Guess the Word Project
' Project purpose:      Simulates the Guess the 
'                       Word game 
' Created/revised by:   Alaa Hawsawi on 11/16/2012

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    'class-level variables
    Private word As String
    Private incorrect As Integer

    Private Sub EnableDisableButtons(ByVal setting As Boolean)
        ' enable or disable letter buttons

        aButton.Enabled = setting
        bButton.Enabled = setting
        cButton.Enabled = setting
        dButton.Enabled = setting
        eButton.Enabled = setting
        fButton.Enabled = setting
        gButton.Enabled = setting
        hButton.Enabled = setting
        iButton.Enabled = setting
        jButton.Enabled = setting
        kButton.Enabled = setting
        lButton.Enabled = setting
        mButton.Enabled = setting
        nButton.Enabled = setting
        oButton.Enabled = setting
        pButton.Enabled = setting
        qButton.Enabled = setting
        rButton.Enabled = setting
        sButton.Enabled = setting
        tButton.Enabled = setting
        uButton.Enabled = setting
        vButton.Enabled = setting
        wButton.Enabled = setting
        xButton.Enabled = setting
        yButton.Enabled = setting
        zButton.Enabled = setting
    End Sub

    Private Sub CheckStatus(ByVal dashStatus As Boolean)
        'determines whether the game is over
        If dashStatus = True Then
            If wordLabel.Text.Contains("-") = False Then
                'the game is over because the word was guessed
                MessageBox.Show("Great guessing!",
                                 "Game over", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information)
                Call EnableDisableButtons(False)
            End If
        Else
            incorrect += 1
            incorrectLabel.Text = incorrect.ToString
            If incorrect = 10 Then
                MessageBox.Show("Sorry, the word is " & word,
                                "Game over", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Call EnableDisableButtons(False)
            End If
        End If

    End Sub

    Private Sub LetterButtons(ByVal sender As Object, ByVal e As System.EventArgs) Handles aButton.Click,
        bButton.Click, cButton.Click, dButton.Click, eButton.Click, jButton.Click, iButton.Click, hButton.Click,
        gButton.Click, fButton.Click, oButton.Click, nButton.Click, mButton.Click, lButton.Click, kButton.Click,
        tButton.Click, sButton.Click, rButton.Click, qButton.Click, pButton.Click, yButton.Click, xButton.Click,
        wButton.Click, vButton.Click, uButton.Click, zButton.Click
        'DETERMINES whether the button's letter is in the word
        Dim clickedbutton As Button
        Dim dashpeplaced As Boolean

        clickedbutton = TryCast(sender, Button)
        clickedbutton.Enabled = False

        For index As Integer = 0 To 4
            'if the current letter in the word
            'matches player 2's letter, replace the
            'associated dash in the wordlable with 
            'player 2's letter and the indicate
            'that a replacement was made 
            If word.Substring(index, 1) = clickedbutton.Text Then
                wordLabel.Text = wordLabel.Text.Remove(index, 1)
                wordLabel.Text = wordLabel.Text.Insert(index, clickedbutton.Text)
                dashpeplaced = True


            End If
        Next index
        Call CheckStatus(dashpeplaced)

    End Sub

    Private Sub gameExitMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gameExitMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GameNewMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameNewMenuItem.Click
        'prepares the application for a new game

        wordLabel.Text = String.Empty
        incorrectLabel.Text = String.Empty
        incorrect = 0

        word = InputBox("Ender a 5-letter word: ", "player 1").ToUpper
        'validate the word
        If word.Length <> 5 OrElse word Like "*[!A-z]*" Then
            MessageBox.Show("Please enter 5 letters only", "guess the word", MessageBoxButtons.OK,
                             MessageBoxIcon.Information)
        Else
            wordLabel.Text = "-----"
            Call EnableDisableButtons(True)
        End If
    End Sub
End Class
