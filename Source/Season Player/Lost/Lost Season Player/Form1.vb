Imports Lost_Season_Player.Settings
Public Class Form1
    'Declare the variables
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub
    Private Sub S01Btn_Click(sender As Object, e As EventArgs) Handles S01Btn.Click
        S01.Visible = True
        S02.Visible = False
        S03.Visible = False
        S04.Visible = False
        S05.Visible = False
        S06.Visible = False
        S01Btn.Visible = False
        S02Btn.Visible = True
        S03Btn.Visible = False
        S04Btn.Visible = False
        S05Btn.Visible = False
        S06Btn.Visible = False
        S01lbl.Visible = True
        S02lbl.Visible = False
        S03lbl.Visible = False
        S04lbl.Visible = False
        S05lbl.Visible = False
        S06lbl.Visible = False
    End Sub

    Private Sub S02Btn_Click(sender As Object, e As EventArgs) Handles S02Btn.Click
        S01.Visible = False
        S02.Visible = True
        S03.Visible = False
        S04.Visible = False
        S05.Visible = False
        S06.Visible = False
        S01Btn.Visible = False
        S02Btn.Visible = False
        S03Btn.Visible = True
        S04Btn.Visible = False
        S05Btn.Visible = False
        S06Btn.Visible = False
        S01lbl.Visible = False
        S02lbl.Visible = True
        S03lbl.Visible = False
        S04lbl.Visible = False
        S05lbl.Visible = False
        S06lbl.Visible = False
    End Sub

    Private Sub S03Btn_Click(sender As Object, e As EventArgs) Handles S03Btn.Click
        S01.Visible = False
        S02.Visible = False
        S03.Visible = True
        S04.Visible = False
        S05.Visible = False
        S06.Visible = False
        S01Btn.Visible = False
        S02Btn.Visible = False
        S03Btn.Visible = False
        S04Btn.Visible = True
        S05Btn.Visible = False
        S06Btn.Visible = False
        S01lbl.Visible = False
        S02lbl.Visible = False
        S03lbl.Visible = True
        S04lbl.Visible = False
        S05lbl.Visible = False
        S06lbl.Visible = False
    End Sub

    Private Sub S04Btn_Click(sender As Object, e As EventArgs) Handles S04Btn.Click
        S01.Visible = False
        S02.Visible = False
        S03.Visible = False
        S04.Visible = True
        S05.Visible = False
        S06.Visible = False
        S01Btn.Visible = False
        S02Btn.Visible = False
        S03Btn.Visible = False
        S04Btn.Visible = False
        S05Btn.Visible = True
        S06Btn.Visible = False
        S01lbl.Visible = False
        S02lbl.Visible = False
        S03lbl.Visible = False
        S04lbl.Visible = True
        S05lbl.Visible = False
        S06lbl.Visible = False
    End Sub

    Private Sub S05Btn_Click(sender As Object, e As EventArgs) Handles S05Btn.Click
        S01.Visible = False
        S02.Visible = False
        S03.Visible = False
        S04.Visible = False
        S05.Visible = True
        S06.Visible = False
        S01Btn.Visible = False
        S02Btn.Visible = False
        S03Btn.Visible = False
        S04Btn.Visible = False
        S05Btn.Visible = False
        S06Btn.Visible = True
        S01lbl.Visible = False
        S02lbl.Visible = False
        S03lbl.Visible = False
        S04lbl.Visible = False
        S05lbl.Visible = True
        S06lbl.Visible = False
    End Sub

    Private Sub S06Btn_Click(sender As Object, e As EventArgs) Handles S06Btn.Click
        S01.Visible = False
        S02.Visible = False
        S03.Visible = False
        S04.Visible = False
        S05.Visible = False
        S06.Visible = True
        S01Btn.Visible = True
        S02Btn.Visible = False
        S03Btn.Visible = False
        S04Btn.Visible = False
        S05Btn.Visible = False
        S06Btn.Visible = False
        S01lbl.Visible = False
        S02lbl.Visible = False
        S03lbl.Visible = False
        S04lbl.Visible = False
        S05lbl.Visible = False
        S06lbl.Visible = True
    End Sub

    Private Sub HideOff_Click(sender As Object, e As EventArgs) Handles HideOff.Click
        HideOff.Visible = False
        HideOn.Visible = True
        PlayerHider.Visible = False
    End Sub

    Private Sub HideOn_Click(sender As Object, e As EventArgs) Handles HideOn.Click
        HideOff.Visible = True
        HideOn.Visible = False
        PlayerHider.Visible = True
    End Sub

    Private Sub S01_SelectedIndexChanged(sender As Object, e As EventArgs) Handles S01.SelectedIndexChanged
        Select Case S01.SelectedIndex
            Case 0
                Timer2.Start()
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/LostS01.wpl"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 1
            Case 2
                Timer2.Start()
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e01.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 3
                Timer2.Start()
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e02.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 4
                Timer2.Start()
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e03.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 5
                Timer2.Start()
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e04.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 6
                Timer2.Start()
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e05.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 7
                Timer2.Start()
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e06.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 8
                Timer2.Start()
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e07.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 9
                Timer2.Start()
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e08.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 10
                Timer2.Start()
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e09.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 11
                Timer2.Start()
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
                Timer2.Start()
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
                Timer2.Start()
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
                Timer2.Start()
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
                Timer2.Start()
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
                Timer2.Start()
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
                Timer2.Start()
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
                Timer2.Start()
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
                Timer2.Start()
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
                Timer2.Start()
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
                Timer2.Start()
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
                Timer2.Start()
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e21.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 23
                Timer2.Start()
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e22.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 24
                Timer2.Start()
                SuchBtn2.Enabled = True
                SuchBtn1.Enabled = True
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.Visible = True
                PlayerHider.Visible = False
                AxWindowsMediaPlayer1.URL = "https://archive.org/download/Lost-S01/itg-lost-s01e23.avi.mp4"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 25
                Timer2.Start()
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
                Timer2.Start()
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

    Private Sub S02_SelectedIndexChanged(sender As Object, e As EventArgs) Handles S02.SelectedIndexChanged
        Select Case S02.SelectedIndex
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

    Private Sub S03_SelectedIndexChanged(sender As Object, e As EventArgs) Handles S03.SelectedIndexChanged
        Select Case S03.SelectedIndex
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
                AxWindowsMediaPlayer1.Ctlcontrols.play()
        End Select
    End Sub

    Private Sub S04_SelectedIndexChanged(sender As Object, e As EventArgs) Handles S04.SelectedIndexChanged
        Select Case S04.SelectedIndex
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

    Private Sub S05_SelectedIndexChanged(sender As Object, e As EventArgs) Handles S05.SelectedIndexChanged
        Select Case S05.SelectedIndex
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

    Private Sub S06_SelectedIndexChanged(sender As Object, e As EventArgs) Handles S06.SelectedIndexChanged
        Select Case S06.SelectedIndex
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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AxWindowsMediaPlayer1.currentPlaylist.clear()
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        AxWindowsMediaPlayer1.settings.volume = 100
        Settings.Autostart.Checked = My.Settings.Autostart
        Settings.Stretch.Checked = My.Settings.Stretch
        Settings.Balance.Value = My.Settings.Balance
        Settings.Volume.Value = My.Settings.Volume
    End Sub

    Private Sub SettingsBtn_Click(sender As Object, e As EventArgs) Handles SettingsBtn.Click
        Settings.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AxWindowsMediaPlayer1.fullScreen = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = DateTime.Now
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        DurationBar.Maximum = AxWindowsMediaPlayer1.currentMedia.duration
        DurationBar.Value = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
        DurationBar.Increment(1)
        If DurationBar.Value = 2 Then
            BufferingBar.Visible = False
            DurationBar.Visible = True
        End If
        If DurationBar.Value = 0 Then
            BufferingBar.Visible = True
            DurationBar.Visible = False
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles PlayerBtn1.Click
        AxWindowsMediaPlayer1.Size = New Size(278, 225)
        PlayerBtn1.Visible = False
        PlayerBtn2.Visible = True
    End Sub

    Private Sub PlayerBtn2_Click(sender As Object, e As EventArgs) Handles PlayerBtn2.Click
        AxWindowsMediaPlayer1.Size = New Size(278, 210)
        PlayerBtn1.Visible = True
        PlayerBtn2.Visible = False
    End Sub
End Class
