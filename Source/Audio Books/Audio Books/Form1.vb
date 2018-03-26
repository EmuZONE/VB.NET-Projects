Imports System.Net
Public Class Form1
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = True
        AxWindowsMediaPlayer1.settings.volume = 100
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        AxWindowsMediaPlayer1.currentPlaylist.clear()
        PictureBox1.Image = Nothing
        ProgressBar1.Visible = True
        DurationBar.Value = 0
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AxWindowsMediaPlayer1.Ctlcontrols.next()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.previous()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AxWindowsMediaPlayer1.Ctlcontrols.fastForward()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxWindowsMediaPlayer1.Ctlcontrols.fastReverse()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Settings.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            DurationBar.Maximum = AxWindowsMediaPlayer1.currentMedia.duration
            DurationBar.Value = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
            DurationBar.Increment(1)
            ProgressBar1.Visible = False
            If DurationBar.Value > 0 Then
                BufferingBar.Visible = False
                ProgressBar1.Visible = True
            Else
                BufferingBar.Visible = True
                ProgressBar1.Visible = False
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Zukunft_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Zukunft.SelectedIndexChanged
        Select Case Zukunft.SelectedIndex
            Case 0
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/ZidZ01.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Future_01
            Case 1
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/ZidZ02.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Future_02
            Case 2
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/ZidZ03.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Future_03
        End Select
    End Sub

    Private Sub Freddy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Freddy.SelectedIndexChanged
        Select Case Freddy.SelectedIndex
            Case 0
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Freddy01.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Freddy_01
            Case 1
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Freddy02.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Freddy_02
            Case 2
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Freddy03.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Freddy_03
            Case 3
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Freddy04.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Freddy_04
            Case 4
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Freddy05.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Freddy_05
            Case 5
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Freddy06.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Freddy_06
        End Select
    End Sub

    Private Sub Alien_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Alien.SelectedIndexChanged
        Select Case Alien.SelectedIndex
            Case 0
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/HB01/088.wpl"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Alien_01
            Case 1
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/HB02/088.wpl"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Alien_02
        End Select
    End Sub

    Private Sub Asterix_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Asterix.SelectedIndexChanged
        Select Case Asterix.SelectedIndex
            Case 0
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Asterix01.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Asterix_01
            Case 1
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Asterix02.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Asterix_02
            Case 2
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Asterix03.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Asterix_03
            Case 3
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Asterix04.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Asterix_04
            Case 4
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Asterix05.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Asterix_05
            Case 5
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Asterix06.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Asterix_06
            Case 6
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Asterix07.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Asterix_07
            Case 7
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Asterix08.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Asterix_08
            Case 8
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Asterix09.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Asterix_09
            Case 9
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Asterix10.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Asterix_10
            Case 10
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = ""
                Timer1.Start()
                PictureBox1.Image = My.Resources.Asterix_01
            Case 11
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Asterix12.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Asterix_12
            Case 12
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = ""
                Timer1.Start()
        End Select
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AxWindowsMediaPlayer1.currentPlaylist.clear()
        End
    End Sub

    Private Sub Alf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Alf.SelectedIndexChanged
        Select Case Alf.SelectedIndex
            Case 0
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Alf01.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Alf_01
            Case 1
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Alf02.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Alf_02
            Case 2
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Alf03.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Alf_03
            Case 3
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Alf04.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Alf_04
            Case 4
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Alf05.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Alf_05
            Case 5
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Alf06.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Alf_00
            Case 6
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Alf07.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Alf_00
            Case 7
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Alf08.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Alf_00
        End Select
    End Sub

    Private Sub Kim_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Kim.SelectedIndexChanged
        Select Case Kim.SelectedIndex
            Case 0
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Kim01.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Kim
            Case 1
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Kim02.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Kim
            Case 2
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Kim03.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Kim
            Case 3
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Kim04.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Kim
            Case 4
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Kim05.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Kim
            Case 5
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Kim06.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Kim
        End Select


    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                Alien.Visible = True
                Asterix.Visible = False
                Zukunft.Visible = False
                Freddy.Visible = False
                Alf.Visible = False
                Kim.Visible = False
                bibi.Visible = False
                Benjamin.Visible = False
                Ape.Visible = False
                DDF.Visible = False
                TKKG.Visible = False
                Freunde.Visible = False
                SW.Visible = False
            Case 1
                Alien.Visible = False
                Asterix.Visible = False
                Zukunft.Visible = False
                Freddy.Visible = False
                Alf.Visible = True
                Kim.Visible = False
                bibi.Visible = False
                Benjamin.Visible = False
                Ape.Visible = False
                DDF.Visible = False
                TKKG.Visible = False
                Freunde.Visible = False
                SW.Visible = False
            Case 2
                Alien.Visible = False
                Asterix.Visible = False
                Zukunft.Visible = False
                Freddy.Visible = False
                Alf.Visible = False
                Kim.Visible = True
                bibi.Visible = False
                Benjamin.Visible = False
                Ape.Visible = False
                DDF.Visible = False
                TKKG.Visible = False
                Freunde.Visible = False
                SW.Visible = False
            Case 3
                Alien.Visible = False
                Asterix.Visible = True
                Zukunft.Visible = False
                Freddy.Visible = False
                Alf.Visible = False
                Kim.Visible = False
                bibi.Visible = False
                Benjamin.Visible = False
                Ape.Visible = False
                DDF.Visible = False
                TKKG.Visible = False
                Freunde.Visible = False
                SW.Visible = False
            Case 4
                Alien.Visible = False
                Asterix.Visible = False
                Zukunft.Visible = False
                Freddy.Visible = False
                Alf.Visible = False
                Kim.Visible = False
                bibi.Visible = False
                Benjamin.Visible = False
                Ape.Visible = False
                DDF.Visible = True
                TKKG.Visible = False
                Freunde.Visible = False
                SW.Visible = False
            Case 5
                Alien.Visible = False
                Asterix.Visible = False
                Zukunft.Visible = False
                Freddy.Visible = False
                Alf.Visible = False
                Kim.Visible = False
                bibi.Visible = False
                Benjamin.Visible = False
                Ape.Visible = False
                DDF.Visible = False
                TKKG.Visible = True
                Freunde.Visible = False
                SW.Visible = False
            Case 6
                Alien.Visible = False
                Asterix.Visible = False
                Zukunft.Visible = True
                Freddy.Visible = False
                Alf.Visible = False
                Kim.Visible = False
                bibi.Visible = False
                Benjamin.Visible = True
                Ape.Visible = False
                DDF.Visible = False
                TKKG.Visible = False
                Freunde.Visible = False
                SW.Visible = False
            Case 7
                Alien.Visible = False
                Asterix.Visible = False
                Zukunft.Visible = True
                Freddy.Visible = False
                Alf.Visible = False
                Kim.Visible = False
                bibi.Visible = True
                Benjamin.Visible = False
                Ape.Visible = False
                DDF.Visible = False
                TKKG.Visible = False
                Freunde.Visible = False
                SW.Visible = False
            Case 8
                Alien.Visible = False
                Asterix.Visible = False
                Zukunft.Visible = False
                Freddy.Visible = True
                Alf.Visible = False
                Kim.Visible = False
                bibi.Visible = False
                Benjamin.Visible = False
                Ape.Visible = False
                DDF.Visible = False
                TKKG.Visible = False
                Freunde.Visible = False
                SW.Visible = False
            Case 9
                Alien.Visible = False
                Asterix.Visible = False
                Zukunft.Visible = False
                Freddy.Visible = False
                Alf.Visible = False
                Kim.Visible = False
                bibi.Visible = False
                Benjamin.Visible = False
                Ape.Visible = False
                DDF.Visible = False
                TKKG.Visible = False
                Freunde.Visible = True
                SW.Visible = False
            Case 10
                Alien.Visible = False
                Asterix.Visible = False
                Zukunft.Visible = False
                Freddy.Visible = False
                Alf.Visible = False
                Kim.Visible = False
                bibi.Visible = False
                Benjamin.Visible = False
                Ape.Visible = True
                DDF.Visible = False
                TKKG.Visible = False
                Freunde.Visible = False
                SW.Visible = False
            Case 11
                Alien.Visible = False
                Asterix.Visible = False
                Zukunft.Visible = True
                Freddy.Visible = False
                Alf.Visible = False
                Kim.Visible = False
                bibi.Visible = False
                Benjamin.Visible = False
                Ape.Visible = False
                DDF.Visible = False
                TKKG.Visible = False
                Freunde.Visible = False
                SW.Visible = True
            Case 12
                Alien.Visible = False
                Asterix.Visible = False
                Zukunft.Visible = True
                Freddy.Visible = False
                Alf.Visible = False
                Kim.Visible = False
                bibi.Visible = False
                Benjamin.Visible = False
                Ape.Visible = False
                DDF.Visible = False
                TKKG.Visible = False
                Freunde.Visible = False
                SW.Visible = False
        End Select
    End Sub

    Private Sub bibi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bibi.SelectedIndexChanged
        Select Case bibi.SelectedIndex
            Case 0
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/BB001.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Bibi_001
            Case 1
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/BB002.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Bibi_002
            Case 2
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/BB003.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Bibi_003
            Case 3
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/BB004.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Bibi_004
            Case 4
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/BB005.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Bibi_005
            Case 5
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/BB006.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Bibi_006
            Case 6
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/BB007.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Bibi_007
            Case 7
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/BB008.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Bibi_008
            Case 8
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/BB009.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Bibi_009
            Case 9
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/BB010.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Bibi_010
        End Select
    End Sub

    Private Sub Benjamin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Benjamin.SelectedIndexChanged
        Select Case Benjamin.SelectedIndex
            Case 0
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Ben000.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Ben_000
            Case 1
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Ben001.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Ben_001
            Case 2
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Ben002.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Ben_002
            Case 3
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Ben003.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Ben_003
            Case 4
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Ben004.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Ben_004
            Case 5
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Ben005.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Ben_005
            Case 6
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Ben006.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Ben_006
            Case 7
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Ben007.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Ben_007
        End Select
    End Sub

    Private Sub Ape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ape.SelectedIndexChanged
        Select Case Ape.SelectedIndex
            Case 0
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/Ape.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.Ape
        End Select
    End Sub

    Private Sub DDF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDF.SelectedIndexChanged
        Select Case DDF.SelectedIndex
            Case 0
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/001.m3u"
                PictureBox1.Image = My.Resources._0011
                Timer1.Start()
            Case 1
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/002.m3u"
                PictureBox1.Image = My.Resources._002
                Timer1.Start()
            Case 2
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/003.m3u"
                PictureBox1.Image = My.Resources._003
                Timer1.Start()
            Case 3
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/004.m3u"
                PictureBox1.Image = My.Resources._004
                Timer1.Start()
            Case 4
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/005.m3u"
                PictureBox1.Image = My.Resources._005
                Timer1.Start()
            Case 5
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/006.m3u"
                PictureBox1.Image = My.Resources._006
                Timer1.Start()
            Case 6
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/007.m3u"
                PictureBox1.Image = My.Resources._007
                Timer1.Start()
            Case 7
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/008.m3u"
                PictureBox1.Image = My.Resources._008
                Timer1.Start()
            Case 8
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/009.m3u"
                PictureBox1.Image = My.Resources._009
                Timer1.Start()
            Case 9
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/010.m3u"
                PictureBox1.Image = My.Resources._010
                Timer1.Start()
            Case 10
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/011.m3u"
                PictureBox1.Image = My.Resources._011
                Timer1.Start()
            Case 11
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/012.m3u"
                PictureBox1.Image = My.Resources._012
                Timer1.Start()
            Case 12
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/013.m3u"
                PictureBox1.Image = My.Resources._013
                Timer1.Start()
            Case 13
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/014.m3u"
                PictureBox1.Image = My.Resources._014
                Timer1.Start()
            Case 14
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/015.m3u"
                PictureBox1.Image = My.Resources._015
                Timer1.Start()
            Case 15
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/016.m3u"
                PictureBox1.Image = My.Resources._016
                Timer1.Start()
            Case 16
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/017.m3u"
                PictureBox1.Image = My.Resources._017
                Timer1.Start()
            Case 17
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/018.m3u"
                PictureBox1.Image = My.Resources._018
                Timer1.Start()
            Case 18
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/019.m3u"
                PictureBox1.Image = My.Resources._019
                Timer1.Start()
            Case 19
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/020.m3u"
                PictureBox1.Image = My.Resources._020
                Timer1.Start()
            Case 20
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/021.m3u"
                PictureBox1.Image = My.Resources._021
                Timer1.Start()
            Case 21
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/022.m3u"
                PictureBox1.Image = My.Resources._022
                Timer1.Start()
            Case 22
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/023.m3u"
                PictureBox1.Image = My.Resources._023
                Timer1.Start()
            Case 23
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/024.m3u"
                PictureBox1.Image = My.Resources._024
                Timer1.Start()
            Case 24
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/025.m3u"
                PictureBox1.Image = My.Resources._025
                Timer1.Start()
            Case 25
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/026.m3u"
                PictureBox1.Image = My.Resources._026
                Timer1.Start()
            Case 26
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/027.m3u"
                PictureBox1.Image = My.Resources._027
                Timer1.Start()
            Case 27
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/028.m3u"
                PictureBox1.Image = My.Resources._028
                Timer1.Start()
            Case 28
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/029.m3u"
                PictureBox1.Image = My.Resources._029
                Timer1.Start()
            Case 29
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/030.m3u"
                PictureBox1.Image = My.Resources._030
                Timer1.Start()
            Case 30
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/031.m3u"
                PictureBox1.Image = My.Resources._031
                Timer1.Start()
            Case 31
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/032.m3u"
                PictureBox1.Image = My.Resources._032
                Timer1.Start()
            Case 32
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/033.m3u"
                PictureBox1.Image = My.Resources._033
                Timer1.Start()
            Case 33
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/034.m3u"
                PictureBox1.Image = My.Resources._034
                Timer1.Start()
            Case 34
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/035.m3u"
                PictureBox1.Image = My.Resources._035
                Timer1.Start()
            Case 35
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/036.m3u"
                PictureBox1.Image = My.Resources._036
                Timer1.Start()
            Case 36
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/037.m3u"
                PictureBox1.Image = My.Resources._037
                Timer1.Start()
            Case 37
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/038.m3u"
                PictureBox1.Image = My.Resources._038
                Timer1.Start()
            Case 38
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/039.m3u"
                PictureBox1.Image = My.Resources._039
                Timer1.Start()
            Case 39
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/040.m3u"
                PictureBox1.Image = My.Resources._040
                Timer1.Start()
            Case 40
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/041.m3u"
                PictureBox1.Image = My.Resources._041
                Timer1.Start()
            Case 41
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/042.m3u"
                PictureBox1.Image = My.Resources._042
                Timer1.Start()
            Case 42
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/043.m3u"
                PictureBox1.Image = My.Resources._043
                Timer1.Start()
            Case 43
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/044.m3u"
                PictureBox1.Image = My.Resources._044
                Timer1.Start()
            Case 44
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/045.m3u"
                PictureBox1.Image = My.Resources._045
                Timer1.Start()
            Case 45
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/046.m3u"
                PictureBox1.Image = My.Resources._046
                Timer1.Start()
            Case 46
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/047.m3u"
                PictureBox1.Image = My.Resources._047
                Timer1.Start()
            Case 47
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/048.m3u"
                PictureBox1.Image = My.Resources._048
                Timer1.Start()
            Case 48
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/049.m3u"
                PictureBox1.Image = My.Resources._049
                Timer1.Start()
            Case 49
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/050.m3u"
                PictureBox1.Image = My.Resources._050
                Timer1.Start()
            Case 50
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/051.m3u"
                PictureBox1.Image = My.Resources._051
                Timer1.Start()
            Case 51
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/052.m3u"
                PictureBox1.Image = My.Resources._052
                Timer1.Start()
            Case 52
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/053.m3u"
                PictureBox1.Image = My.Resources._053
                Timer1.Start()
            Case 53
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/054.m3u"
                PictureBox1.Image = My.Resources._054
                Timer1.Start()
            Case 54
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/055.m3u"
                PictureBox1.Image = My.Resources._055
                Timer1.Start()
            Case 55
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/056.m3u"
                PictureBox1.Image = My.Resources._056
                Timer1.Start()
            Case 56
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/057.m3u"
                PictureBox1.Image = My.Resources._057
                Timer1.Start()
            Case 57
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/058.m3u"
                PictureBox1.Image = My.Resources._058
                Timer1.Start()
            Case 58
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/059.m3u"
                PictureBox1.Image = My.Resources._059
                Timer1.Start()
            Case 59
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/050.m3u"
                PictureBox1.Image = My.Resources._060
                Timer1.Start()
            Case 60
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/061.m3u"
                PictureBox1.Image = My.Resources._061
                Timer1.Start()
            Case 61
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/062.m3u"
                PictureBox1.Image = My.Resources._062
                Timer1.Start()
            Case 62
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/063.m3u"
                PictureBox1.Image = My.Resources._063
                Timer1.Start()
            Case 63
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/064.m3u"
                PictureBox1.Image = My.Resources._064
                Timer1.Start()
            Case 64
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/065.m3u"
                PictureBox1.Image = My.Resources._065
                Timer1.Start()
            Case 65
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/066.m3u"
                PictureBox1.Image = My.Resources._066
                Timer1.Start()
            Case 66
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/067.m3u"
                PictureBox1.Image = My.Resources._067
                Timer1.Start()
            Case 67
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/068.m3u"
                PictureBox1.Image = My.Resources._068
                Timer1.Start()
            Case 68
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/069.m3u"
                PictureBox1.Image = My.Resources._069
                Timer1.Start()
            Case 69
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/070.m3u"
                PictureBox1.Image = My.Resources._070
                Timer1.Start()
            Case 70
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/071.m3u"
                PictureBox1.Image = My.Resources._071
                Timer1.Start()
            Case 71
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/072.m3u"
                PictureBox1.Image = My.Resources._072
                Timer1.Start()
            Case 72
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/073.m3u"
                PictureBox1.Image = My.Resources._073
                Timer1.Start()
            Case 73
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/074.m3u"
                PictureBox1.Image = My.Resources._074
                Timer1.Start()
            Case 74
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/075.m3u"
                PictureBox1.Image = My.Resources._075
                Timer1.Start()
            Case 75
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/076.m3u"
                PictureBox1.Image = My.Resources._076
                Timer1.Start()
            Case 76
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/077.m3u"
                PictureBox1.Image = My.Resources._077
                Timer1.Start()
            Case 77
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/078.m3u"
                PictureBox1.Image = My.Resources._078
                Timer1.Start()
            Case 78
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/079.m3u"
                PictureBox1.Image = My.Resources._079
                Timer1.Start()
            Case 79
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/080.m3u"
                PictureBox1.Image = My.Resources._080
                Timer1.Start()
            Case 80
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/081.m3u"
                PictureBox1.Image = My.Resources._081
                Timer1.Start()
            Case 81
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/082.m3u"
                PictureBox1.Image = My.Resources._082
                Timer1.Start()
            Case 82
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/083.m3u"
                PictureBox1.Image = My.Resources._083
                Timer1.Start()
            Case 83
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/084.m3u"
                PictureBox1.Image = My.Resources._084
                Timer1.Start()
            Case 84
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/085.m3u"
                PictureBox1.Image = My.Resources._085
                Timer1.Start()
            Case 85
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/086.m3u"
                PictureBox1.Image = My.Resources._086
                Timer1.Start()
            Case 86
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/087.m3u"
                PictureBox1.Image = My.Resources._087
                Timer1.Start()
            Case 87
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/088.m3u"
                PictureBox1.Image = My.Resources._088
                Timer1.Start()
            Case 88
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/089.m3u"
                PictureBox1.Image = My.Resources._089
                Timer1.Start()
            Case 89
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/090.m3u"
                PictureBox1.Image = My.Resources._090
                Timer1.Start()
            Case 90
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/091.m3u"
                PictureBox1.Image = My.Resources._091
                Timer1.Start()
            Case 91
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/092.m3u"
                PictureBox1.Image = My.Resources._092
                Timer1.Start()
            Case 92
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/093.m3u"
                PictureBox1.Image = My.Resources._093
                Timer1.Start()
            Case 93
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/094.m3u"
                PictureBox1.Image = My.Resources._094
                Timer1.Start()
            Case 94
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/095.m3u"
                PictureBox1.Image = My.Resources._095
                Timer1.Start()
            Case 95
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/096.m3u"
                PictureBox1.Image = My.Resources._096
                Timer1.Start()
            Case 96
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/097.m3u"
                PictureBox1.Image = My.Resources._097
                Timer1.Start()
            Case 97
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/098.m3u"
                PictureBox1.Image = My.Resources._098
                Timer1.Start()
            Case 98
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/100a.m3u"
                PictureBox1.Image = My.Resources._099
                Timer1.Start()
            Case 99
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/100b.m3u"
                PictureBox1.Image = My.Resources._100
                Timer1.Start()
            Case 100
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/100c.m3u"
                PictureBox1.Image = My.Resources._100
                Timer1.Start()
            Case 101
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/101.m3u"
                PictureBox1.Image = My.Resources._101
                Timer1.Start()
            Case 102
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/102.m3u"
                PictureBox1.Image = My.Resources._102
                Timer1.Start()
            Case 103
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/103.m3u"
                PictureBox1.Image = My.Resources._103
                Timer1.Start()
            Case 104
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/104.m3u"
                PictureBox1.Image = My.Resources._104
                Timer1.Start()
            Case 105
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/105.m3u"
                PictureBox1.Image = My.Resources._105
                Timer1.Start()
            Case 106
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/106.m3u"
                PictureBox1.Image = My.Resources._106
                Timer1.Start()
            Case 107
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/107.m3u"
                PictureBox1.Image = My.Resources._107
                Timer1.Start()
            Case 108
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/108.m3u"
                PictureBox1.Image = My.Resources._108
                Timer1.Start()
            Case 109
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/109.m3u"
                PictureBox1.Image = My.Resources._109
                Timer1.Start()
            Case 110
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/110.m3u"
                PictureBox1.Image = My.Resources._110
                Timer1.Start()
            Case 111
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/111.m3u"
                PictureBox1.Image = My.Resources._111
                Timer1.Start()
            Case 112
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/112.m3u"
                PictureBox1.Image = My.Resources._112
                Timer1.Start()
            Case 113
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/113.m3u"
                PictureBox1.Image = My.Resources._113
                Timer1.Start()
            Case 114
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/114.m3u"
                PictureBox1.Image = My.Resources._114
                Timer1.Start()
            Case 115
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/115.m3u"
                PictureBox1.Image = My.Resources._115
                Timer1.Start()
            Case 116
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/116.m3u"
                PictureBox1.Image = My.Resources._116
                Timer1.Start()
            Case 117
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/117.m3u"
                PictureBox1.Image = My.Resources._117
                Timer1.Start()
            Case 118
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/118.m3u"
                PictureBox1.Image = My.Resources._118
                Timer1.Start()
            Case 119
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/119.m3u"
                PictureBox1.Image = My.Resources._119
                Timer1.Start()
            Case 120
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/120.m3u"
                PictureBox1.Image = My.Resources._120
                Timer1.Start()
            Case 121
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/121.m3u"
                PictureBox1.Image = My.Resources._121
                Timer1.Start()
            Case 122
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/DDF/122.m3u"
                PictureBox1.Image = My.Resources._122
                Timer1.Start()
        End Select
    End Sub

    Private Sub TKKG_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TKKG.SelectedIndexChanged
        Select Case TKKG.SelectedIndex
            Case 0
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg001.m3u"
                PictureBox1.Image = My.Resources.TKKG_001
                Timer1.Start()
            Case 1
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg002.m3u"
                PictureBox1.Image = My.Resources.TKKG_002
                Timer1.Start()
            Case 2
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg003.m3u"
                PictureBox1.Image = My.Resources.TKKG_003
                Timer1.Start()
            Case 3
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg004.m3u"
                PictureBox1.Image = My.Resources.TKKG_004
                Timer1.Start()
            Case 4
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg005.m3u"
                PictureBox1.Image = My.Resources.TKKG_005
                Timer1.Start()
            Case 5
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg006.m3u"
                PictureBox1.Image = My.Resources.TKKG_006
                Timer1.Start()
            Case 6
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg007.m3u"
                PictureBox1.Image = My.Resources.TKKG_007
                Timer1.Start()
            Case 7
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg008.m3u"
                PictureBox1.Image = My.Resources.TKKG_008
                Timer1.Start()
            Case 8
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg009.m3u"
                PictureBox1.Image = My.Resources.TKKG_009
                Timer1.Start()
            Case 9
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg010.m3u"
                PictureBox1.Image = My.Resources.TKKG_010
                Timer1.Start()
            Case 10
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg011.m3u"
                PictureBox1.Image = My.Resources.TKKG_011
                Timer1.Start()
            Case 11
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg012.m3u"
                PictureBox1.Image = My.Resources.TKKG_012
                Timer1.Start()
            Case 12
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg013.m3u"
                PictureBox1.Image = My.Resources.TKKG_013
                Timer1.Start()
            Case 13
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg014.m3u"
                PictureBox1.Image = My.Resources.TKKG_014
                Timer1.Start()
            Case 14
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg015.m3u"
                PictureBox1.Image = My.Resources.TKKG_015
                Timer1.Start()
            Case 15
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg016.m3u"
                PictureBox1.Image = My.Resources.TKKG_016
                Timer1.Start()
            Case 16
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg017.m3u"
                PictureBox1.Image = My.Resources.TKKG_017
                Timer1.Start()
            Case 17
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg018.m3u"
                PictureBox1.Image = My.Resources.TKKG_018
                Timer1.Start()
            Case 18
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg019.m3u"
                PictureBox1.Image = My.Resources.TKKG_019
                Timer1.Start()
            Case 19
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg020.m3u"
                PictureBox1.Image = My.Resources.TKKG_020
                Timer1.Start()
            Case 20
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg021.m3u"
                PictureBox1.Image = My.Resources.TKKG_021
                Timer1.Start()
            Case 21
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg022.m3u"
                PictureBox1.Image = My.Resources.TKKG_022
                Timer1.Start()
            Case 22
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg023.m3u"
                PictureBox1.Image = My.Resources.TKKG_023
                Timer1.Start()
            Case 23
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg024.m3u"
                PictureBox1.Image = My.Resources.TKKG_024
                Timer1.Start()
            Case 24
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg025.m3u"
                PictureBox1.Image = My.Resources.TKKG_025
                Timer1.Start()
            Case 25
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg026.m3u"
            Case 26
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg027.m3u"
            Case 27
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg028.m3u"
            Case 28
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg029.m3u"
            Case 29
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg030.m3u"
            Case 30
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/tkkg031.m3u"
        End Select
    End Sub

    Private Sub Freunde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Freunde.SelectedIndexChanged
        Select Case Freunde.SelectedIndex
            Case 0
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF001.wpl"
                PictureBox1.Image = My.Resources.FF_001
                Timer1.Start()
            Case 1
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF002.wpl"
                PictureBox1.Image = My.Resources.FF_002
                Timer1.Start()
            Case 2
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF003.wpl"
                PictureBox1.Image = My.Resources.FF_003
                Timer1.Start()
            Case 3
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF004.wpl"
                PictureBox1.Image = My.Resources.FF_004
                Timer1.Start()
            Case 4
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF005.wpl"
                PictureBox1.Image = My.Resources.FF_005
                Timer1.Start()
            Case 5
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF006.wpl"
                PictureBox1.Image = My.Resources.FF_006
                Timer1.Start()
            Case 6
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF007.wpl"
                PictureBox1.Image = My.Resources.FF_007
                Timer1.Start()
            Case 7
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF008.wpl"
                PictureBox1.Image = My.Resources.FF_008
                Timer1.Start()
            Case 8
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF009.wpl"
                PictureBox1.Image = My.Resources.FF_009
                Timer1.Start()
            Case 9
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF010.wpl"
                PictureBox1.Image = My.Resources.FF_010
                Timer1.Start()
            Case 10
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF011.wpl"
                PictureBox1.Image = My.Resources.FF_011
                Timer1.Start()
            Case 11
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF012.wpl"
                PictureBox1.Image = My.Resources.FF_012
                Timer1.Start()
            Case 12
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF013.wpl"
                PictureBox1.Image = My.Resources.FF_013
                Timer1.Start()
            Case 13
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF014.wpl"
                PictureBox1.Image = My.Resources.FF_014
                Timer1.Start()
            Case 14

                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF015.wpl"
                PictureBox1.Image = My.Resources.FF_015
                Timer1.Start()
            Case 15
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF016.wpl"
                PictureBox1.Image = My.Resources.FF_016
                Timer1.Start()
            Case 16
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF017.wpl"
                PictureBox1.Image = My.Resources.FF_017
                Timer1.Start()
            Case 17
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF018.wpl"
                PictureBox1.Image = My.Resources.FF_018
                Timer1.Start()
            Case 18
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF019.wpl"
                PictureBox1.Image = My.Resources.FF_019
                Timer1.Start()
            Case 19
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF020.wpl"
                PictureBox1.Image = My.Resources.FF_020
                Timer1.Start()
            Case 20
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF021.wpl"
                PictureBox1.Image = My.Resources.FF_021
                Timer1.Start()
            Case 21
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF022.wpl"
                PictureBox1.Image = My.Resources.FF_022
                Timer1.Start()
            Case 22
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF023.wpl"
                PictureBox1.Image = My.Resources.FF_023
                Timer1.Start()
            Case 23
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF024.wpl"
                PictureBox1.Image = My.Resources.FF_024
                Timer1.Start()
            Case 24

                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF025.wpl"
                PictureBox1.Image = My.Resources.FF_025
                Timer1.Start()
            Case 25
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF026.wpl"
                PictureBox1.Image = My.Resources.FF_026
                Timer1.Start()
            Case 26
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF027.wpl"
                PictureBox1.Image = My.Resources.FF_027
                Timer1.Start()
            Case 27
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF028.wpl"
                PictureBox1.Image = My.Resources.FF_028
                Timer1.Start()
            Case 28
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF029.wpl"
                PictureBox1.Image = My.Resources.FF_029
                Timer1.Start()
            Case 29
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF030.wpl"
                PictureBox1.Image = My.Resources.FF_030
                Timer1.Start()
            Case 30
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/FF/FF031.wpl"
                Timer1.Start()
                PictureBox1.Image = My.Resources.FF_031
        End Select
    End Sub

    Private Sub SW_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SW.SelectedIndexChanged
        Select Case SW.SelectedIndex
            Case 0
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/SW01.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.SW_01
            Case 1
                AxWindowsMediaPlayer1.currentPlaylist.clear()
                AxWindowsMediaPlayer1.URL = "https://raw.githubusercontent.com/EmuZONE/YouTube/master/Sounds/HB/SW02.m3u"
                Timer1.Start()
                PictureBox1.Image = My.Resources.SW_02
        End Select
    End Sub
End Class
