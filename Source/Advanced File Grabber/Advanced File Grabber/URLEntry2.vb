Public Class URLEntry2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.TextBox1.Text = Me.TextBox1.Text
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub URLEntry2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
End Class