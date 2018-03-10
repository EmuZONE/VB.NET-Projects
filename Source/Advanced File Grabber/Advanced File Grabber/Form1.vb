Imports System.Net
Public Class Form1

    Dim t As System.Threading.Thread = Nothing

    Dim now As DateTime

    Delegate Sub SetTextCallback(ByVal [text] As String)



    Private Sub SetText(ByVal [text] As String)

        If Me.Clocklbl.InvokeRequired Then

            Dim d As New SetTextCallback(AddressOf SetText)

            Me.Invoke(d, New Object() {[text]})

        Else

            Me.Clocklbl.Text = text

        End If

    End Sub



    Private Sub showtime()

        While True

            System.Threading.Thread.Sleep(1000)

            now = now.AddSeconds(1)

            SetText(now.ToString("dd.MM.yyyy    hh:mm:ss"))

        End While

    End Sub



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        now = DateTime.Now

        t = New System.Threading.Thread(New System.Threading.ThreadStart(AddressOf showtime))

        t.Start()

        If My.Computer.Network.Ping("www.google.de") Then
            OfflinePic.Visible = False
            OnlinePic.Visible = True
        Else
            OfflinePic.Visible = True
            OnlinePic.Visible = False
        End If

    End Sub



    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        t.Abort()

    End Sub

    Public WithEvents download As WebClient

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            download = New WebClient
            download.DownloadFileAsync(New Uri(TextBox1.Text), TextBox2.Text)
            Button1.Enabled = False
            ProgressBar2.Location = New Point(21, 125)
            ProgressBar1.Location = New Point(21, 104)
        Catch ex As Exception
            Me.Text = "Fehler!"
            MsgBox("Fehler! -" & ex.Message)
            Button1.Enabled = True
        End Try
        TextBox1.Text = ListBox1.SelectedItem
    End Sub
    Private Sub download_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles download.DownloadFileCompleted
        Try
            Me.Text = "Download abgeschlossen!"
            Button1.Enabled = True
            ProgressBar1.Location = New Point(21, 125)
            ProgressBar2.Location = New Point(21, 104)
        Catch ex As Exception
            Me.Text = "Fehler! Die Datei wurde nicht geladen."
        End Try

    End Sub
    Private Sub download_DownloadProgressChanged(ByVal sender As System.Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged
        Dim totalbytes As Long = e.TotalBytesToReceive / 1024
        Dim mtotalbytes As Long = totalbytes / 1024

        Dim bytes As Long = e.BytesReceived / 1024
        Dim mbytes As Long = bytes / 1024

        If totalbytes < 1 Then totalbytes = 1
        If bytes < 1 Then bytes = 1

        If totalbytes > 1024 Then

            Label1.Text = mbytes.ToString & " MB von " & mtotalbytes & " MB"
        Else
            Label1.Text = bytes.ToString & " KB von " & totalbytes & " KB"
        End If
        Me.Text = "Download läuft..."
        ProgressBar1.Value = e.ProgressPercentage
        Label2.Text = ProgressBar1.Value & "%"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim osd As New SaveFileDialog
        osd.Filter = "All Files (*.*)|*.*"
        osd.ShowDialog()
        TextBox2.Text = osd.FileName
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        URLEntry.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = ListBox1.SelectedItem
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        download.CancelAsync()
        Me.Text = "Download abgebrochen..."
    End Sub

    Private Sub ListBoxBtn1_Click(sender As Object, e As EventArgs) Handles ListBoxBtn1.Click
        ListBoxPnl.Size = New Size(423, 1)
        ListBoxBtn1.Visible = False
        ListBoxBtn2.Visible = True
        Panel14.Visible = False
        FormPnlR2.Visible = True
        FormPnlR.Visible = False
        FilePnl.Visible = False
        NetworkPnl.Visible = True
        NetworkPnl2.Visible = False
        Me.Size = New Size(650, 723)
    End Sub

    Private Sub ListBoxBtn2_Click(sender As Object, e As EventArgs) Handles ListBoxBtn2.Click
        ListBoxPnl.Size = New Size(423, 511)
        FormPnlR.Visible = True
        FormPnlR2.Visible = False
        ListBoxBtn2.Visible = False
        ListBoxBtn1.Visible = True
        FilePnl.Visible = True
        Me.Size = New Size(1094, 723)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        ListBoxPnl.Size = New Size(423, 511)
        FormPnlR.Visible = True
        FormPnlR2.Visible = False
        ListBoxBtn2.Visible = False
        ListBoxBtn1.Visible = True
        Panel14.Visible = True
        FilePnl.Visible = True
        NetworkPnl2.Visible = True
        NetworkPnl.Visible = False
        Me.Size = New Size(1094, 723)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        URLEntry2.Show()
    End Sub
End Class
