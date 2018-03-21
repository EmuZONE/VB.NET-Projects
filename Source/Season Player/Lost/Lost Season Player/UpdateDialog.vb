Imports System.IO
Imports System.Net

Public Class UpdateDialog
    Dim Download As New WebClient
    Private Sub UpdateDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Download = New WebClient
        Dim ProgrammVersion As String = "1.0.0.1"
        Dim UpdateVersion As String = Download.DownloadString("http://playlist.bplaced.net/docs/lost.version.txt")

        Settings.Updatelbl.Text = UpdateVersion
        Settings.Versionlbl.Text = ProgrammVersion

        If ProgrammVersion = UpdateVersion Then
            MsgBox("Die Anwendung befindet sich bereits auf dem aktuellsten Stand.", MsgBoxStyle.Information)
            Me.Close()
            Form1.Show()
        Else
            MsgBox("Es liegen Aktualisierungen vor!", MsgBoxStyle.Information)
            Download.DownloadFile("https://github.com/EmuZONE/YouTube/raw/master/Source/StreamKiste/ddf.update.exe", "lost.update.exe")
            Try
                Process.Start("lost.update.exe")
            Catch ex As Exception
                MsgBox("ex.Message", MsgBoxStyle.Critical)
            End Try
            End
        End If
    End Sub
End Class