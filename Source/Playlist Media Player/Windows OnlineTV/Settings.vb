Public Class Settings
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Player.AxWindowsMediaPlayer1.settings.balance = Me.TrackBar1.Value
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        Me.TrackBar2.Value = Player.TrackBar1.Value
    End Sub
End Class