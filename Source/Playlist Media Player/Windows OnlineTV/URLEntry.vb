﻿Public Class URLEntry
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            Player.ListBox1.Items.Add(TextBox1.Text)
        Else
            Player.ListBox1.Items.Add(TextBox1.Text)
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class