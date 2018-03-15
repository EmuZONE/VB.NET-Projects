Imports System.Net
Public Class Updater
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub
    Dim vs As New WebClient
    Private Sub Updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ProgrammVersion As String = "1.0.0.3"
        Dim UpdateVersion As String = vs.DownloadString("https://drive.google.com/uc?export=download&id=1fNlMc1Mt4ZFVnArJ5Txd7_SxL_oywWsZ")
        Label1.Text = UpdateVersion
        Label4.Text = ProgrammVersion
        If ProgrammVersion = UpdateVersion Then
            MsgBox("Die aktuellste Version ist bereits Installiert.", MsgBoxStyle.Information)
            Me.Close()
            Form1.Show()
        Else
            MsgBox("Es sind Aktualisierungen verfügbar.", MsgBoxStyle.Information)
            Try
                vs.DownloadFile("https://github.com/EmuZONE/VB.NET-Projects/blob/master/Source/MovieTown/Updates/Update.exe?raw=true", "Update.exe")
                Process.Start("Update.exe")
                Me.Close()
                End
            Catch ex As Exception
                MsgBox("ex.Message", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
End Class