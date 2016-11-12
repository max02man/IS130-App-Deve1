' Project name:         Mouse Game Project
' Project purpose:      Simulates the Find the Mouse game
' Created/revised by:   Alaa on 9/26/2012

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    ' class-level variable for storing a random number
    Private randomnumber As Integer

    
    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub startButton_Click(sender As System.Object, e As System.EventArgs) Handles startButton.Click
        ' perpaers the interface for a new game
        Dim randomGenerator As New Random
        ' generate random number from 1 though 5
        randomnumber = randomGenerator.Next(1, 6)

        'display the "Is the mouse here?"image
        PictureBox1.Image = questionPictureBox.Image
        PictureBox2.Image = questionPictureBox.Image
        PictureBox3.Image = questionPictureBox.Image
        PictureBox4.Image = questionPictureBox.Image
        PictureBox5.Image = questionPictureBox.Image
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        'displays the appropriale image

        If randomnumber = 1 Then
            PictureBox1.Image = mousePictureBox.Image
        Else
            PictureBox1.Image = notHerePictureBox.Image
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        'displays the appropriale image
        If randomnumber = 2 Then
            PictureBox2.Image = mousePictureBox.Image
        Else
            PictureBox2.Image = notHerePictureBox.Image
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        'displays the appropriale image
        If randomnumber = 3 Then
            PictureBox3.Image = mousePictureBox.Image
        Else
            PictureBox3.Image = notHerePictureBox.Image
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        'displays the appropriale image
        If randomnumber = 4 Then
            PictureBox4.Image = mousePictureBox.Image
        Else
            PictureBox4.Image = notHerePictureBox.Image
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        'displays the appropriale image
        If randomnumber = 5 Then
            PictureBox5.Image = mousePictureBox.Image
        Else
            PictureBox5.Image = notHerePictureBox.Image
        End If
    End Sub
End Class
