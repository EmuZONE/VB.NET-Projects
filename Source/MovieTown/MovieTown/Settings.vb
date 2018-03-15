Imports MovieTown.Form1
Public Class Settings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.SpeakerSettings = SpeakerSettings.SelectedIndex
        My.Settings.SoundSettings = SoundSettings.SelectedIndex
        My.Settings.ScreenSettings = ScreenSettings.SelectedIndex
        My.Settings.ResolutionSettings = ResolutionSettings.SelectedIndex
        My.Settings.Save()
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SpeakerSettings.SelectedIndex = My.Settings.SpeakerSettings
        SoundSettings.SelectedIndex = My.Settings.SoundSettings
        ScreenSettings.SelectedIndex = My.Settings.ScreenSettings
        ResolutionSettings.SelectedIndex = My.Settings.ResolutionSettings
    End Sub
End Class