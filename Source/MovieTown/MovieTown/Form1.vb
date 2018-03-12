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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ActionList.SelectedIndexChanged
        Select Case ActionList.SelectedIndex
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

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComedyList.SelectedIndexChanged
        Select Case ComedyList.SelectedIndex
            Case 0
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KleinErnaAufDemJungfernstieg1969/Die%20Supernasen.mp4")
            Case 1
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KleinErnaAufDemJungfernstieg1969/Zwei%20Nasen%20tanken%20Super.mp4")
            Case 2
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ZrtlicheChaoten/Z%C3%A4rtliche%20Chaoten%20%281987%29%20HD%20Stream%20%C2%BB%20StreamKistetv.mp4")
            Case 3
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ZrtlicheChaoten/Z%C3%A4rtliche%20Chaoten%20II%20%281988%29%20HD%20Stream%20%C2%BB%20StreamKistetv.mp4")
            Case 4
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KleinErnaAufDemJungfernstieg1969/Piratensender%20Power%20Play.mp4")
            Case 5
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/My80sFavorites/DieEinsteiger.mp4")
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

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HorrorList.SelectedIndexChanged
        Select Case HorrorList.SelectedIndex
            Case 0
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 1
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 2
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 3
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 4
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
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

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SciFiList.SelectedIndexChanged
        Select Case SciFiList.SelectedIndex
            Case 0
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 1
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 2
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 3
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
            Case 4
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
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
        ActionList.Visible = True
        ComedyList.Visible = False
        SciFiList.Visible = False
        HorrorList.Visible = False
        HorrorPic2.Visible = False
        ActionPic2.Visible = True
        ComedyPic2.Visible = False
        SciFiPic2.Visible = False
        SciFiPic1.Visible = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ComedyList.Visible = True
        ActionList.Visible = False
        SciFiList.Visible = False
        HorrorList.Visible = False
        HorrorPic2.Visible = False
        ActionPic2.Visible = False
        ComedyPic2.Visible = True
        SciFiPic2.Visible = False
        SciFiPic1.Visible = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ActionList.Visible = False
        ComedyList.Visible = False
        SciFiList.Visible = True
        HorrorPic2.Visible = False
        ActionPic2.Visible = False
        ComedyPic2.Visible = False
        SciFiPic2.Visible = True
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ActionList.Visible = False
        ComedyList.Visible = False
        SciFiList.Visible = False
        HorrorList.Visible = True
        HorrorPic2.Visible = True
        ActionPic2.Visible = False
        ComedyPic2.Visible = False
        SciFiPic2.Visible = False
        SciFiPic1.Visible = True
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles VolOnBtn.Click
        VolPnl.Visible = True
        VolOnBtn.Visible = False
        VolOffBtn.Visible = True
    End Sub

    Private Sub VolOffBtn_Click(sender As Object, e As EventArgs) Handles VolOffBtn.Click
        VolPnl.Visible = False
        VolOnBtn.Visible = True
        VolOffBtn.Visible = False
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If VLCPnl.Visible = True Then
            AxVLCPlugin21.volume = TrackBar1.Value & "0"
        Else
            AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value & "0"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.settings.volume = "100"
    End Sub

    Private Sub PosOnBtn_Click(sender As Object, e As EventArgs) Handles PosOnBtn.Click
        VolPnl.Visible = True
        TrackBar2.Visible = True
        PosOnBtn.Visible = False
        PosOffBtn.Visible = True
    End Sub

    Private Sub PosOffBtn_Click(sender As Object, e As EventArgs) Handles PosOffBtn.Click
        VolPnl.Visible = False
        TrackBar2.Visible = False
        PosOnBtn.Visible = True
        PosOffBtn.Visible = False
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If VLCPnl.Visible = True Then
            AxVLCPlugin21.video.takeSnapshot()
        Else
            Me.Text = "Comming Soon..."
        End If
    End Sub
End Class
