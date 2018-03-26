Imports Audio_Books.Form1
Imports System.Net
Public Class Settings
    Dim download As New WebClient
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.AutoStart = AutoStart.Checked
        My.Settings.Volume = Volume.Value
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles Volume.Scroll
        Form1.AxWindowsMediaPlayer1.settings.volume = Volume.Value & "0"
        Volumelbl.Text = Volume.Value * 10
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles AutoStart.CheckedChanged
        If AutoStart.Checked = True Then
            Form1.AxWindowsMediaPlayer1.settings.autoStart = False
        Else
            Form1.AxWindowsMediaPlayer1.settings.autoStart = True
        End If
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoStart.Checked = My.Settings.AutoStart
        Volume.Value = My.Settings.Volume
        Dim ProgrammVersion As String = "1.0.0.2"
        Dim UpdateVersion As String = download.DownloadString("http://playlist.bplaced.net/docs/ab-version.txt")
        Serverlbl.Text = UpdateVersion
        locallbl.Text = ProgrammVersion
        If ProgrammVersion = UpdateVersion Then
            locallbl.ForeColor = Color.LimeGreen
        Else
            locallbl.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        download = New WebClient
        Dim ProgrammVersion As String = "1.0.0.2"
        Dim UpdateVersion As String = download.DownloadString("http://playlist.bplaced.net/docs/ab-version.txt")

        If ProgrammVersion = UpdateVersion Then
            MsgBox("Die Anwendung befindet sich bereits auf dem aktuellsten Stand.", MsgBoxStyle.Information)
            Me.Close()
        Else
            MsgBox("Es liegen Aktualisierungen vor!", MsgBoxStyle.Information)
            download.DownloadFile("https://github.com/EmuZONE/YouTube/raw/master/Source/StreamKiste/ab.update.exe", "ab.update.exe")
            Try
                Process.Start("ab.update.exe")
            Catch ex As Exception
                MsgBox("ex.Message", MsgBoxStyle.Critical)
            End Try
            End
        End If
    End Sub
End Class