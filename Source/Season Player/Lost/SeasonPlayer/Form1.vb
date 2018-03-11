Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles PauseBtn.Click
        PauseBtn.Visible = False
        PlayBtn.Visible = True
        SuchBtn2.Enabled = True
        SuchBtn1.Enabled = True
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub
    Private Sub PlayBtn_Click(sender As Object, e As EventArgs) Handles PlayBtn.Click
        PlayBtn.Visible = False
        PauseBtn.Visible = True
        PlayerHider.Visible = False
        AxWindowsMediaPlayer1.Visible = True
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        SuchBtn2.Enabled = True
        SuchBtn1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        AxWindowsMediaPlayer1.currentPlaylist.clear()
        AxWindowsMediaPlayer1.Visible = False
        PlayerHider.Visible = True
        PauseBtn.Visible = False
        PlayBtn.Visible = True
        SuchBtn2.Enabled = False
        SuchBtn1.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AxWindowsMediaPlayer1.Ctlcontrols.next()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AxWindowsMediaPlayer1.Ctlcontrols.fastForward()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.previous()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxWindowsMediaPlayer1.Ctlcontrols.fastReverse()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AxWindowsMediaPlayer1.currentPlaylist.clear()
        End
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/LostS01.wpl"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 1
            Case 2
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e01.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 3
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e02.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 4
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e03.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 5
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e04.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 6
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e05.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 7
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e06.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 8
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e07.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 9
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e08.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 10
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e09.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 11
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e10.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 12
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e11.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 13
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e12.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 14
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e13.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 15
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e14.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 16
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e15.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 17
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e16.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 18
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e17.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 19
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e18.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 20
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e19.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 21
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e20.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 22
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e21.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 23
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e22.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 24
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e23.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 25
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e24.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 26
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e25.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.SelectedIndex
            Case 0
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/LostS02.wpl"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 1
            Case 2
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostxvid-s02e01.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 3
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostxvid-s02e02.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 4
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostxvid-s02e03.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 5
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostxvid-s02e04.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 6
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-s02e05.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 7
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-s02e06.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 8
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-s02e07.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 9
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostxvid-s02e08.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 10
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostxvid-s02e09.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 11
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostxvid-s02e10.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 12
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostxvid-s02e11.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 13
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostxvid-s02e12.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 14
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostdxvid-s02e13.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 15
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostdxvid-s02e14.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 16
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostdxvid-s02e15.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 17
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostdxvid-s02e16.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 18
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostdxvid-s02e17.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 19
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostdxvid-s02e18.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 20
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostdxvid-s02e19.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 21
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostdxvid-s02e20.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 22
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostdxvid-s02e21.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 23
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostdxvid-s02e22.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 24
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostdxvid-s02e23.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 25
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S02/isd-lostdxvid-s02e24.mp4"
        End Select
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Select Case ComboBox3.SelectedIndex
            Case 0
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e01.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Me.Text = "Lost Season Player: Es läuft Staffel 3 Complete..."
            Case 1
            Case 2
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e02.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Me.Text = "Lost Season Player: S03E01 - Die zwei Städte"
            Case 3
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e03.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Me.Text = "Lost Season Player: S03E02 - Die gläserne Ballerina"
            Case 4
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e04.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Me.Text = "Lost Season Player: S03E03 - Der Auftrag"
            Case 5
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e05.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Me.Text = "Lost Season Player: S03E04 - Jeder für sich"
            Case 6
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e06.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 7
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e07.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 8
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e08.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 9
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e09.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 10
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e10.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 11
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e11.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 12
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e12.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 13
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e13.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 14
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e14.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 15
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e15.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 16
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e16.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 17
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e17.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 18
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e18.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 19
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e19.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 20
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e20.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 21
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e21.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 22
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e22.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 23
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e23.mp4"
        End Select
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Select Case ComboBox4.SelectedIndex
            Case 0
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/LostS04.wpl"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 1
            Case 2
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS04/etm-lost-s04e01.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 3
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS04/etm-lost-s04e02.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 4
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS04/etm-lost-s04e03.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 5
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS04/etm-lost-s04e04.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 6
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS04/etm-lost-s04e05.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 7
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS04/etm-lost-s04e06.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 8
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS04/etm-lost-s04e07.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 9
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS04/etm-lost-s04e08.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 10
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS04/etm-lost-s04e09.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 11
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS04/etm-lost-s04e10.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 12
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS04/etm-lost-s04e11.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 13
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS04/etm-lost-s04e12.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 14
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS04/etm-lost-s04e13.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 15
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS04/etm-lost-s04e14.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
        End Select
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        Select Case ComboBox5.SelectedIndex
            Case 0
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/LostS05.wpl"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 1
            Case 2
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS05/exp-lostxvid-s05e01.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 3
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS05/exp-lostxvid-s05e02.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 4
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS05/exp-lostxvid-s05e03.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 5
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS05/exp-lostxvid-s05e04.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 6
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS05/exp-lostxvid-s05e05.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 7
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS05/exp-lostxvid-s05e06.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 8
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS05/exp-lostxvid-s05e07.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 9
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS05/exp-lostxvid-s05e08.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 10
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS05/exp-lostxvid-s05e09.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 11
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS05/exp-lostxvid-s05e10.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 12
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS05/exp-lostxvid-s05e11.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 13
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS05/exp-lostxvid-s05e12.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 14
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS05/exp-lostxvid-s05e13.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 15
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS05/exp-lostxvid-s05e14.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 16
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS05/exp-lostxvid-s05e15.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 17
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS05/exp-lostxvid-s05e16.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 18
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS05/exp-lostxvid-s05e17.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
        End Select
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        Select Case ComboBox6.SelectedIndex
            Case 0
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/LostS06.wpl"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 1
            Case 2
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS06/deli-lostxvid-s06e01.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 3
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS06/deli-lostxvid-s06e02.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 4
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS06/deli-lostxvid-s06e03.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 5
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS06/deli-lostxvid-s06e04.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 6
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS06/deli-lostxvid-s06e05.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 7
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS06/deli-lostxvid-s06e06.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 8
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS06/deli-lostxvid-s06e07.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 9
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS06/deli-lostxvid-s06e08.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 10
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS06/deli-lostxvid-s06e09.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 11
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS06/deli-lostxvid-s06e10.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 12
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS06/deli-lostxvid-s06e11.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 13
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS06/deli-lostxvid-s06e12.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 14
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS06/deli-lostxvid-s06e13.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 15
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS06/deli-lostxvid-s06e14.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 16
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS06/deli-lostxvid-s06e15.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 17
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS06/deli-lostxvid-s06e16.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 18
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS06/deli-lostxvid-s06e17.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
        End Select
    End Sub

    Private Sub VolOffBtn_Click(sender As Object, e As EventArgs) Handles VolOffBtn.Click
        VolOffBtn.Visible = False
        VolOnBtn.Visible = True
        VolPnl.Visible = False
        NetworkPnl.Visible = True
    End Sub

    Private Sub VolOnBtn_Click(sender As Object, e As EventArgs) Handles VolOnBtn.Click
        VolOffBtn.Visible = True
        VolOnBtn.Visible = False
        VolPnl.Visible = True
        NetworkPnl.Visible = False
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value & "0"
        Label44.Text = TrackBar1.Value
    End Sub

    Private Sub FullScrnBtn_Click(sender As Object, e As EventArgs) Handles FullScrnBtn.Click

        If (AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying) Then

            AxWindowsMediaPlayer1.fullScreen = True
            InfoPnl.Visible = True
            BufferBar.Value = AxWindowsMediaPlayer1.network.bufferingProgress
            Label31.Text = AxWindowsMediaPlayer1.currentMedia.duration
            Label33.Text = AxWindowsMediaPlayer1.currentMedia.name
        End If

        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            PauseBtn.Visible = True
            PlayBtn.Visible = False
        End If
    End Sub
    Private WithEvents tm As New Timer With {.Enabled = False, .Interval = 100}
    Private CountdownValue As Integer = 2491.56
    Private Startzeit As DateTime
    Private Sub GoBtn_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If tm.Enabled Then Exit Sub
        Me.Timerlbl.Text = CountdownValue.ToString
        Startzeit = Now
        tm.Enabled = True
    End Sub
    Private Sub tm_Tick(sender As Object, e As System.EventArgs) Handles tm.Tick
        Dim elapsed = TimeSpan.FromTicks(Now.Ticks - Startzeit.Ticks).Seconds
        If CountdownValue - elapsed <= 0 Then
            tm.Enabled = False
            Me.Timerlbl.Text = "00"
            Debug.Print("Elapsed: {0} ms", TimeSpan.FromTicks(Now.Ticks - Startzeit.Ticks))
        Else
            If Me.Timerlbl.Text <> (CountdownValue - elapsed).ToString Then
                Me.Timerlbl.Text = (CountdownValue - elapsed).ToString
                Debug.Print("Elapsed: {0} ms", TimeSpan.FromTicks(Now.Ticks - Startzeit.Ticks))
            End If
        End If
    End Sub
    Private Sub MuteOff_Click(sender As Object, e As EventArgs) Handles MuteOff.Click
        AxWindowsMediaPlayer1.settings.mute = False
        MuteOff.Visible = False
        MuteOn.Visible = True
        TrackBar1.Value = "100"
        Label44.Text = TrackBar1.Value
    End Sub

    Private Sub MuteOn_Click(sender As Object, e As EventArgs) Handles MuteOn.Click
        AxWindowsMediaPlayer1.settings.mute = True
        MuteOff.Visible = True
        MuteOn.Visible = False
        TrackBar1.Value = "0"
        Label44.Text = TrackBar1.Value
    End Sub

    Private Sub AutoPlayOff_Click(sender As Object, e As EventArgs) Handles AutoPlayOff.Click
        AutoPlayOn.Visible = True
        AutoPlayOff.Visible = False
        OnPic.Visible = True
        OffPic.Visible = False
        AxWindowsMediaPlayer1.settings.autoStart = False
        S1ChkBx.Checked = False
        S2ChkBx.Checked = False
        S3ChkBx.Checked = False
        S4ChkBx.Checked = False
        S5ChkBx.Checked = False
        S6ChkBx.Checked = False
        S1AutoOff.Visible = True
        S2AutoOff.Visible = True
        S3AutoOff.Visible = True
        S4AutoOff.Visible = True
        S5AutoOff.Visible = True
        S6AutoOff.Visible = True
        S1AutoOn.Visible = False
        S2AutoOn.Visible = False
        S3AutoOn.Visible = False
        S4AutoOn.Visible = False
        S5AutoOn.Visible = False
        S6AutoOn.Visible = False
    End Sub

    Private Sub AutoPlayOn_Click(sender As Object, e As EventArgs) Handles AutoPlayOn.Click
        AutoPlayOn.Visible = False
        AutoPlayOff.Visible = True
        OffPic.Visible = True
        OnPic.Visible = False
        AxWindowsMediaPlayer1.settings.autoStart = True
        S1ChkBx.Checked = True
        S2ChkBx.Checked = True
        S3ChkBx.Checked = True
        S4ChkBx.Checked = True
        S5ChkBx.Checked = True
        S6ChkBx.Checked = True
        S1AutoOn.Visible = True
        S2AutoOn.Visible = True
        S3AutoOn.Visible = True
        S4AutoOn.Visible = True
        S5AutoOn.Visible = True
        S6AutoOn.Visible = True
        S1AutoOff.Visible = False
        S2AutoOff.Visible = False
        S3AutoOff.Visible = False
        S4AutoOff.Visible = False
        S5AutoOff.Visible = False
        S6AutoOff.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BufferBar3.Value = AxWindowsMediaPlayer1.network.downloadProgress
        AxWindowsMediaPlayer1.settings.volume = "100"
        Label26.Text = AxWindowsMediaPlayer1.network.bitRate
        Label29.Text = AxWindowsMediaPlayer1.network.bufferingProgress
        Label38.Text = AxWindowsMediaPlayer1.network.bandWidth
        Label40.Text = AxWindowsMediaPlayer1.network.maxBitRate
        Label42.Text = AxWindowsMediaPlayer1.settings.playCount
        Label42.Text = AxWindowsMediaPlayer1.settings.baseURL
        Label44.Text = AxWindowsMediaPlayer1.settings.volume
        If AxWindowsMediaPlayer1.isOnline Then
            Panel4.Visible = False
            Panel3.Visible = True
            Onlinelbl.Visible = True
            Offlinelbl.Visible = False
        End If
        If (AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying) Then
            InfoPnl.Visible = True
            Dim interval As New TimeSpan()
            Console.WriteLine(interval.Equals(TimeSpan.Zero))
            Label33.Text = AxWindowsMediaPlayer1.network.maxBandwidth
            Label31.Text = AxWindowsMediaPlayer1.currentMedia.duration / 60
            PauseBtn.Visible = True
            PlayBtn.Visible = False
            SuchBtn2.Enabled = True
            SuchBtn1.Enabled = True
        End If
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then
            InfoPnl.Visible = False
            PauseBtn.Visible = False
            PlayBtn.Visible = True
            SuchBtn2.Enabled = False
            SuchBtn1.Enabled = False
            AxWindowsMediaPlayer1.Visible = False
            PlayerHider.Visible = True
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Uhr1.Click
        Uhr.Show()
        Uhr.Size = New Size(366, 214)
        Uhr.Cal.Visible = False
        Uhr.CalOn.Visible = True
        Uhr.CalOff.Visible = False
        Uhr.CloseBtn2.Visible = True
        Uhr.CloseBtn1.Visible = False
        Uhr1.Visible = False
        Uhr2.Visible = True
    End Sub

    Private Sub Uhr2_Click(sender As Object, e As EventArgs) Handles Uhr2.Click
        Uhr.Close()
        Uhr2.Visible = False
        Uhr1.Visible = True
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        Select Case ComboBox7.SelectedIndex
            Case 0
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e01.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 1
            Case 2
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e02.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 3
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e03.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 4
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e04.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 5
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e05.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 6
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e06.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 7
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e07.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 8
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e08.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 9
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e09.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 10
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e10.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 11
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e11.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 12
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e12.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 13
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e13.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 14
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e14.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 15
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e15.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 16
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e16.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 17
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e17.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 18
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e18.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 19
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e19.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 20
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e20.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 21
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e21.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 22
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e22.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 23
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                PlayBtn.Visible = False
                PauseBtn.Visible = True
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/LostS03/itg-lost-s03e23.mp4"
        End Select
    End Sub

    Private Sub SuchBtn1_Click(sender As Object, e As EventArgs) Handles SuchBtn1.Click
        SuchBar.Visible = True
        SuchBtn1.Visible = False
        SuchBtn2.Visible = True
        MainCtrlPnl.Size = New Size(454, 160)
        MainCtrlPnl.Location = New Point(427, 277)
    End Sub

    Private Sub SuchBtn2_Click(sender As Object, e As EventArgs) Handles SuchBtn2.Click
        SuchBar.Visible = False
        SuchBtn1.Visible = True
        SuchBtn2.Visible = False
        MainCtrlPnl.Location = New Point(427, 289)
        MainCtrlPnl.Size = New Size(454, 148)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles S1ChkBx.CheckedChanged
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then
            ComboBox1.SelectedItem = ComboBox1.SelectedIndex + 1
            AxWindowsMediaPlayer1.settings.autoStart = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles S2ChkBx.CheckedChanged
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then
            ComboBox2.SelectedItem = ComboBox2.SelectedIndex + 1
            AxWindowsMediaPlayer1.settings.autoStart = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles S3ChkBx.CheckedChanged
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then
            ComboBox3.SelectedItem = ComboBox3.SelectedIndex + 1
            AxWindowsMediaPlayer1.settings.autoStart = True
        End If
    End Sub

    Private Sub S6AutoOffBtn_Click(sender As Object, e As EventArgs) Handles S6AutoOffBtn.Click
        S6AutoOff.Visible = True
        S6AutoOn.Visible = False
        S6AutoOffBtn.Visible = False
        S6AutoOnBtn.Visible = True
        S6ChkBx.Checked = False
    End Sub

    Private Sub S6AutoOnBtn_Click(sender As Object, e As EventArgs) Handles S6AutoOnBtn.Click
        S6AutoOff.Visible = False
        S6AutoOn.Visible = True
        S6AutoOffBtn.Visible = True
        S6AutoOnBtn.Visible = False
        S6ChkBx.Checked = True
    End Sub

    Private Sub S5AutoOffBtn_Click(sender As Object, e As EventArgs) Handles S5AutoOffBtn.Click
        S5AutoOff.Visible = True
        S5AutoOn.Visible = False
        S5AutoOffBtn.Visible = False
        S5AutoOnBtn.Visible = True
        S5ChkBx.Checked = False
    End Sub

    Private Sub S4AutoOffBtn_Click(sender As Object, e As EventArgs) Handles S4AutoOffBtn.Click
        S4AutoOff.Visible = True
        S4AutoOn.Visible = False
        S4AutoOffBtn.Visible = False
        S4AutoOnBtn.Visible = True
        S4ChkBx.Checked = False
    End Sub

    Private Sub S3AutoOffBtn_Click(sender As Object, e As EventArgs) Handles S3AutoOffBtn.Click
        S3AutoOff.Visible = True
        S3AutoOn.Visible = False
        S3AutoOffBtn.Visible = False
        S3AutoOnBtn.Visible = True
        S3ChkBx.Checked = False
    End Sub

    Private Sub S2AutoOffBtn_Click(sender As Object, e As EventArgs) Handles S2AutoOffBtn.Click
        S2AutoOff.Visible = True
        S2AutoOn.Visible = False
        S2AutoOffBtn.Visible = False
        S2AutoOnBtn.Visible = True
        S2ChkBx.Checked = False
    End Sub

    Private Sub S1AutoOffBtn_Click(sender As Object, e As EventArgs) Handles S1AutoOffBtn.Click
        S1AutoOff.Visible = True
        S1AutoOn.Visible = False
        S1AutoOffBtn.Visible = False
        S1AutoOnBtn.Visible = True
        S1ChkBx.Checked = False
    End Sub

    Private Sub S5AutoOnBtn_Click(sender As Object, e As EventArgs) Handles S5AutoOnBtn.Click
        S5AutoOff.Visible = False
        S5AutoOn.Visible = True
        S5AutoOffBtn.Visible = True
        S5AutoOnBtn.Visible = False
        S5ChkBx.Checked = True
    End Sub

    Private Sub S4AutoOnBtn_Click(sender As Object, e As EventArgs) Handles S4AutoOnBtn.Click
        S4AutoOff.Visible = False
        S4AutoOn.Visible = True
        S4AutoOffBtn.Visible = True
        S4AutoOnBtn.Visible = False
        S4ChkBx.Checked = True
    End Sub

    Private Sub S3AutoOnBtn_Click(sender As Object, e As EventArgs) Handles S3AutoOnBtn.Click
        S3AutoOff.Visible = False
        S3AutoOn.Visible = True
        S3AutoOffBtn.Visible = True
        S3AutoOnBtn.Visible = False
        S3ChkBx.Checked = True
    End Sub

    Private Sub S2AutoOnBtn_Click(sender As Object, e As EventArgs) Handles S2AutoOnBtn.Click
        S2AutoOff.Visible = False
        S2AutoOn.Visible = True
        S2AutoOffBtn.Visible = True
        S2AutoOnBtn.Visible = False
        S2ChkBx.Checked = True
    End Sub

    Private Sub S1AutoOnBtn_Click(sender As Object, e As EventArgs) Handles S1AutoOnBtn.Click
        S1AutoOff.Visible = False
        S1AutoOn.Visible = True
        S1AutoOffBtn.Visible = True
        S1AutoOnBtn.Visible = False
        S1ChkBx.Checked = True
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub VolPnl_Paint(sender As Object, e As PaintEventArgs) Handles VolPnl.Paint

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AxWindowsMediaPlayer1.currentPlaylist.clear()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        AxWindowsMediaPlayer1.stretchToFit = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AxWindowsMediaPlayer1.ShowPropertyPages()
    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
    Private Function TakeImage(ByVal X As Integer, ByVal Y As Integer, ByVal Width As Integer, ByVal Height As Integer) As Bitmap
        Dim Img As New Bitmap(Width, Height)
        Dim g As Graphics = Graphics.FromImage(Img)
        g.CopyFromScreen(X, Y, 0, 0, Img.Size)
        g.Dispose()
        Return Img
    End Function
    Public ReadOnly Property status As System.String
    Public Property Timerlbl As Object

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub InfoBtn_Click(sender As Object, e As EventArgs) Handles InfoBtn.Click
        NetInfoPnl.Visible = False
        InfoPnl.Visible = True
        NetBoxPic.Visible = False
        InfoBoxPic.Visible = True
        NetInfoBtn.Visible = True
        InfoBtn.Visible = False
    End Sub

    Private Sub NetInfoBtn_Click(sender As Object, e As EventArgs) Handles NetInfoBtn.Click
        NetInfoPnl.Visible = True
        InfoPnl.Visible = False
        NetBoxPic.Visible = True
        InfoBoxPic.Visible = False
        NetInfoBtn.Visible = False
        InfoBtn.Visible = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form2.Show()
        Button11.Visible = False
        Button14.Visible = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        LinkBox.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Form2.Close()
        Form2.Show()
        Button11.Visible = True
        Button14.Visible = False
    End Sub

    Private Sub SeasonBtn1_Click(sender As Object, e As EventArgs) Handles SeasonBtn1.Click
        S01Pnl.Visible = True
        S02Pnl.Visible = False
    End Sub

    Private Sub SeasonBtn2_Click(sender As Object, e As EventArgs) Handles SeasonBtn2.Click
        S01Pnl.Visible = False
        S02Pnl.Visible = True
    End Sub

    Private Sub EpiOnBtn_Click(sender As Object, e As EventArgs) Handles EpiOnBtn.Click
        EpiOnBtn.Visible = False
        EpiOffBtn.Visible = True
        EpiPnl.Visible = True
        S01Pnl.Visible = True
        SeasonPnl2.Visible = False
    End Sub

    Private Sub EpiOffBtn_Click(sender As Object, e As EventArgs) Handles EpiOffBtn.Click
        EpiOnBtn.Visible = True
        EpiOffBtn.Visible = False
        EpiPnl.Visible = False
        S02Pnl.Visible = False
        S01Pnl.Visible = False
        SeasonPnl2.Visible = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)
        S01Pnl.Visible = False
        S02Pnl.Visible = True
    End Sub
End Class