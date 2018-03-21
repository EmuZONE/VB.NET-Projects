Public Class Settings
    Private Sub Volume_Scroll(sender As Object, e As EventArgs) Handles Volume.Scroll
        Form1.AxWindowsMediaPlayer1.settings.volume = Volume.Value & "0"
    End Sub

    Private Sub Balance_Scroll(sender As Object, e As EventArgs) Handles Balance.Scroll
        Form1.AxWindowsMediaPlayer1.settings.balance = Balance.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Autostart = Autostart.Checked
        My.Settings.Stretch = Stretch.Checked
        My.Settings.Balance = Balance.Value
        My.Settings.Volume = Volume.Value
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpdateDialog.Show()
        Me.Close()
    End Sub
End Class