Public Class Ablage
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 9
            Me.ListBox1.Items.Add("Eintrag " & i.ToString)
        Next
        Me.ListBox1.SelectedIndex = 0
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Clipboard.SetText(Me.ListBox1.SelectedItem)
    End Sub
End Class