﻿Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
    End Sub
    Public Class Form1
        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles 
Button1.Click()
            Form2.Show()
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles 
Button2.Click()
            Form3.Show()
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles 
Button3.Click()
            Form4.Show()
        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles 
Button4.Click()
            Form5.Show()
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles 
MyBase.Load
            Me.FormBorderStyle = FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
        End Sub
    End Class
End Class
