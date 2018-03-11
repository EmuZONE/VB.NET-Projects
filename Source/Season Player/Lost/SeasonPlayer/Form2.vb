Imports System.Net
Public Class Form2
    Public WithEvents download As WebClient

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            download = New WebClient
            download.DownloadFileAsync(New Uri(TextBox1.Text), TextBox2.Text)
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
        Catch ex As Exception
            MsgBox("Fehler! -" & ex.Message)
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True
        End Try
    End Sub

    Private Sub download_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles download.DownloadFileCompleted
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        Me.Text = ("Download abgeschlossen...")
    End Sub
    Private Sub download_DownloadProgressChanged(ByVal sender As System.Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged
        Try
            Byteslbl.Text = "Bereits geladen: " & e.BytesReceived / 1000000 & "  MB / " & e.TotalBytesToReceive / 1000000 & " MB"
            ProgressBar1.Value = e.ProgressPercentage
            Statuslbl.Text = ProgressBar1.Value & "%"
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
        Catch ex As Exception
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True
        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim osd As New SaveFileDialog
        osd.Filter = "All Files (*.*)|*.*"
        osd.ShowDialog()
        TextBox2.Text = TextBox1.Text
        osd.FileName = TextBox2.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        download.CancelAsync()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Dim osd As New SaveFileDialog
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Process.Start("Links.txt")
        Catch ex As Exception
            Me.Text = ("Die Datei ist nicht vorhanden.")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Process.Start("Movies\")
        Catch ex As Exception
            Me.Text = ("Die Datei ist nicht vorhanden.")
        End Try
    End Sub
End Class