Public Class Form1
    Private Sub PauseBtn_Click(sender As Object, e As EventArgs) Handles PauseBtn.Click
        PauseBtn.Visible = False
        PlayBtn.Visible = True
        AxVLCPlugin21.playlist.togglePause()
    End Sub

    Private Sub PlayBtn_Click(sender As Object, e As EventArgs) Handles PlayBtn.Click
        PauseBtn.Visible = True
        PlayBtn.Visible = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        End
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Der%20Supercop.mp4")
            Case 1
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Maniac%20Cop.mp4")
            Case 2
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Maniac%20Cop%202.mp4")
            Case 3
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Maniac%20Cop%203.mp4")
            Case 4
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/The%20Day%20After.mp4")
            Case 5
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 6
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 7
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 8
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 9
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 10
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 11
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 12
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 13
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 14
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 15
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 16
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 17
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 18
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 19
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 20
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 21
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 22
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 23
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 24
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 25
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 26
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 27
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 28
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 29
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 30
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 31
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 32
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 33
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 34
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 35
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 36
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 37
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 38
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 39
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 40
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 41
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 42
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 43
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 44
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 45
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 46
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 47
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 48
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 49
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 50
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 51
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 52
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 53
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 54
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 55
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 56
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 57
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 58
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 59
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 60
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 61
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 62
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 63
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 64
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 65
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 66
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 67
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 68
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 69
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 70
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 71
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
        End Select
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PlayBtn.Visible = False
        PauseBtn.Visible = True
        AxVLCPlugin21.playlist.next()
        AxVLCPlugin21.playlist.play()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxVLCPlugin21.video.fullscreen = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AxVLCPlugin21.playlist.next()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AxVLCPlugin21.video.crop = "16:9"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxVLCPlugin21.playlist.stop()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxVLCPlugin21.playlist.prev()
    End Sub

    Private Sub PlayerBtn2_Click(sender As Object, e As EventArgs) Handles PlayerBtn2.Click
        PlayerBtn2.Visible = False
        PlayerBtn1.Visible = True
        PlayerPic2.Visible = True
        PlayerPic1.Visible = False
        VLCPnl.Visible = True
        WMPPnl.Visible = False
    End Sub

    Private Sub PlayerBtn1_Click(sender As Object, e As EventArgs) Handles PlayerBtn1.Click
        PlayerBtn1.Visible = False
        PlayerBtn2.Visible = True
        PlayerPic1.Visible = True
        PlayerPic2.Visible = False
        VLCPnl.Visible = False
        WMPPnl.Visible = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ActionPnl.Visible = True
        ComedyPnl.Visible = False
        SciFiPnl.Visible = False
        HorrorPnl.Visible = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ComedyPnl.Visible = True
        ActionPnl.Visible = False
        SciFiPnl.Visible = False
        HorrorPnl.Visible = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ActionPnl.Visible = False
        ComedyPnl.Visible = False
        SciFiPnl.Visible = True
        HorrorPnl.Visible = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ActionPnl.Visible = False
        ComedyPnl.Visible = False
        SciFiPnl.Visible = False
        HorrorPnl.Visible = True
    End Sub
End Class
