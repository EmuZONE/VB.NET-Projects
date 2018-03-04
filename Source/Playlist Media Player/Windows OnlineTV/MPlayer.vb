Imports System.IO
Public Class Player

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        End
    End Sub

    Private Sub PlayBtn_Click(sender As Object, e As EventArgs) Handles PlayBtn.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub PauseBtn_Click(sender As Object, e As EventArgs) Handles PauseBtn.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub StopBtn_Click(sender As Object, e As EventArgs) Handles StopBtn.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub RewindBtn_Click(sender As Object, e As EventArgs) Handles RewindBtn.Click
        AxWindowsMediaPlayer1.Ctlcontrols.fastReverse()
    End Sub

    Private Sub ForwardBtn_Click(sender As Object, e As EventArgs) Handles ForwardBtn.Click
        AxWindowsMediaPlayer1.Ctlcontrols.fastForward()
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        AxWindowsMediaPlayer1.Ctlcontrols.next()
    End Sub

    Private Sub PrevBtn_Click(sender As Object, e As EventArgs) Handles PrevBtn.Click
        AxWindowsMediaPlayer1.Ctlcontrols.previous()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value & "10"
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        OpenFileDialog1.ShowDialog()
        ListBox1.Items.Add(OpenFileDialog1.FileName)
        ListBox1.Select()
    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub ListPlayBtn_Click(sender As Object, e As EventArgs) Handles ListPlayBtn.Click
        AxWindowsMediaPlayer1.URL = ListBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxWindowsMediaPlayer1.ShowPropertyPages()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles URLBtn1.Click
        URLPnl.Visible = False
        URLBtn1.Visible = False
        URLBtn2.Visible = True
    End Sub

    Private Sub URLBtn2_Click(sender As Object, e As EventArgs) Handles URLBtn2.Click
        URLPnl.Visible = True
        URLBtn1.Visible = True
        URLBtn2.Visible = False
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.URL = URLinput.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start(".\")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles VolBtn.Click
        VolumePnl.Visible = True
        PositionPnl.Visible = False
        VolBtn.Visible = False
        PosBtn.Visible = True
    End Sub

    Private Sub PosBtn_Click(sender As Object, e As EventArgs) Handles PosBtn.Click
        VolumePnl.Visible = False
        PositionPnl.Visible = True
        VolBtn.Visible = True
        PosBtn.Visible = False
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = TrackBar2.Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles AlbumOnBtn.Click
        AlbumPnl.Visible = False
        AlbumOnBtn.Visible = False
        AlbOffBtn.Visible = True
        MovOnBtn.Enabled = False
        MovOffBtn.Enabled = False
        UnLockPic.Visible = False
        LockPic.Visible = True
    End Sub

    Private Sub AlbOffBtn_Click(sender As Object, e As EventArgs) Handles AlbOffBtn.Click
        AlbumPnl.Visible = True
        AlbumOnBtn.Visible = True
        AlbOffBtn.Visible = False
        MovOnBtn.Enabled = True
        MovOffBtn.Enabled = True
        UnLockPic.Visible = True
        LockPic.Visible = False
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs)
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/010/088.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs)
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/014/088.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/017/088.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button7_Click_2(sender As Object, e As EventArgs) Handles Button7.Click
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/020/088.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/021/088.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/025/088.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/019/088.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/018/088.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button17_Click_1(sender As Object, e As EventArgs) Handles Button17.Click
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/026/088.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/001/016.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/003/016.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/028/088.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/042/088.m3u"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button5_Click_2(sender As Object, e As EventArgs) Handles Button5.Click
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/004/010.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/030/088.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button18_Click_1(sender As Object, e As EventArgs) Handles Button18.Click
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/014/088.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/010/088.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Ablage.Show()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        URLEntry.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Libary.Show()
    End Sub

    Public Sub fullScreen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles fullscreen.Click

        If (AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying) Then

            AxWindowsMediaPlayer1.fullScreen = True

        End If

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Info.Show()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
        If AxWindowsMediaPlayer1.isOnline Then
            Panel4.Visible = False
            Panel3.Visible = True
            Onlinelbl.Visible = True
            Offlinelbl.Visible = False
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles MovOffBtn.Click
        MoviePnl.Visible = False
        MovOnBtn.Visible = True
        MovOffBtn.Visible = False
    End Sub

    Private Sub MovOnBtn_Click(sender As Object, e As EventArgs) Handles MovOnBtn.Click
        MoviePnl.Visible = True
        MovOnBtn.Visible = False
        MovOffBtn.Visible = True
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        AxWindowsMediaPlayer1.currentPlaylist.clear()
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/Back2Futur3.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        AxWindowsMediaPlayer1.currentPlaylist.clear()
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/JCVDFilms.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        AxWindowsMediaPlayer1.currentPlaylist.clear()
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/KultHorror.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        AxWindowsMediaPlayer1.currentPlaylist.clear()
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/LWCollection.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        AxWindowsMediaPlayer1.currentPlaylist.clear()
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/DieHard.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        AxWindowsMediaPlayer1.currentPlaylist.clear()
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/Termine.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        AxWindowsMediaPlayer1.currentPlaylist.clear()
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/007Coll/007.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button34_Click_1(sender As Object, e As EventArgs) Handles Button34.Click
        AxWindowsMediaPlayer1.currentPlaylist.clear()
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/Didi.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        AxWindowsMediaPlayer1.currentPlaylist.clear()
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/StarWars.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        AxWindowsMediaPlayer1.currentPlaylist.clear()
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/Indy.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        AxWindowsMediaPlayer1.currentPlaylist.clear()
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/Conan.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        AxWindowsMediaPlayer1.currentPlaylist.clear()
        AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/MovColl1.wpl"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub
End Class
