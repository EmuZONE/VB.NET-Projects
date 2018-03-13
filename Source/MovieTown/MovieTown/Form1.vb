Public Class Form1
    Private Sub PauseBtn_Click(sender As Object, e As EventArgs) Handles PauseBtn.Click
        PauseBtn.Visible = False
        PlayBtn.Visible = True
        AxVLCPlugin21.playlist.togglePause()
    End Sub

    Private Sub PlayBtn_Click(sender As Object, e As EventArgs) Handles PlayBtn.Click
        PauseBtn.Visible = True
        PlayBtn.Visible = True
        BufferBarOff.Visible = False
        BufferBarOn.Visible = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        End
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ActionList.SelectedIndexChanged
        Select Case ActionList.SelectedIndex
            Case 0
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/NachEigenenRegeln1996.mp4")
            Case 1
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Rookie%20der%20Anf%C3%A4nger.mp4")
            Case 2
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/True%20Lies.mp4")
            Case 3
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/FromDuskTillDawn.mp4")
            Case 4
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Cliffhanger.mp4")
            Case 5
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Tango%20%26%20Cash.mp4")
            Case 6
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Last%20Action%20Hero.mp4")
            Case 7
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Lethal%20Weapon.mp4")
            Case 8
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Lethal%20Weapon%202_2.mp4")
            Case 9
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Lethal%20Weapon%202.mp4")
            Case 10
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Lethal%20Weapon%204.mp4")
            Case 11
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Red%20Heat.mp4")
            Case 12
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Rambo.mp4")
            Case 13
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Rambo%202.mp4")
            Case 14
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Rambo%20III.mp4")
            Case 15
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/John%20rambo.mp4")
            Case 16
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Der%20City%20Hai.mp4")
            Case 17
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Die%20Hard.mp4")
            Case 18
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Die%20Hard%202.mp4")
            Case 19
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Die%20Hard%203.mp4")
            Case 20
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Die%20Hard%204.mp4")
            Case 21
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Die%20Hard%205.mp4")
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
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Tanz%20der%20Teufel%20%281981%29.mp4")
            Case 1
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Tanz%20der%20Teufel%202%20%281984%29.mp4")
            Case 2
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Tanz%20der%20Teufel%203%20%281992%29.mp4")
            Case 3
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Tant%20der%20Teufel%204.mp4")
            Case 4
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Braindead%20%281992%29.mp4")
            Case 5
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Final%20Destination.mp4")
            Case 6
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Final%20Destination%202.mp4")
            Case 7
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Final%20Destination%203.mp4")
            Case 8
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Final%20Destination%204.mp4")
            Case 9
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Final%20Destination%205.mp4")
            Case 10
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Maniac%20Cop.mp4")
            Case 11
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Maniac%20Cop%202.mp4")
            Case 12
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Maniac%20Cop%203.mp4")
            Case 13
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Halloween.mp4")
            Case 14
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Halloween2.mp4")
            Case 15
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Halloween%20III.mp4")
            Case 16
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Halloween%204.mp4")
            Case 17
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Halloween%206.mp4")
            Case 18
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Halloween%207.mp4")
            Case 19
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Halloween%208.mp4")
            Case 20
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Halloween%20H20.mp4")
            Case 21
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Halloween%20Resurrection.mp4")
            Case 22
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Halloween%20Remake.mp4")
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
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/LostInSpace.mp4")
            Case 1
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/EventHorizon.mp4")
            Case 2
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Star%20Wars%20Episode%201.mp4")
            Case 3
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Star%20Wars%20Episode%202.mp4")
            Case 4
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Star%20Wars%20Episode%203.mp4")
            Case 5
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Star%20Wars%20Episode%204.mp4")
            Case 6
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Star%20Wars%20Episode%205.mp4")
            Case 7
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Star%20Wars%20Episode%206.mp4")
            Case 8
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Star%20Wars%20Episode%208.mp4")
            Case 9
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Star%20Wars%20Episode.mp4")
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

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FantasyList.SelectedIndexChanged
        Select Case FantasyList.SelectedIndex
            Case 0
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Herr%20der%20Ringe.mp4")
            Case 1
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Herr%20der%20Ringe%202.mp4")
            Case 2
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Herr%20der%20Ringe%203.mp4")
            Case 3
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Der%20Hobbit.mp4")
            Case 4
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Der%20Hobbit%202.mp4")
            Case 5
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Der%20Hobbit%203.mp4")
            Case 6
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/DieUnendlicheGeschichte.mp4")
            Case 7
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/DieUnendlicheGeschichte2.mp4")
            Case 8
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/My80sFavorites/Highlander.mp4")
            Case 9
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Indiana%20Jones%20-%20J%C3%A4ger%20des%20verlorenen%20Schatzes.mp4")
            Case 10
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Indiana%20Jones%20und%20der%20Tempel%20des%20Todes.mp4")
            Case 11
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Indiana%20Jones%20und%20der%20letzte%20Kreuzzug.mp4")
            Case 12
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Indiana%20Jones%20und%20das%20K%C3%B6nigreich%20des%20Kristallsch%C3%A4dels.mp4")
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
        BufferBarOff.Visible = False
        BufferBarOn.Visible = True
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
        BufferBarOff.Visible = True
        BufferBarOn.Visible = False
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
        FantasyList.Visible = False
        HorrorList.Visible = False
        HorrorPic2.Visible = False
        ActionPic2.Visible = True
        ComedyPic2.Visible = False
        SciFiPic2.Visible = False
        SciFiPic1.Visible = True
        FantasyPic2.Visible = False
        FantasyPic1.Visible = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ComedyList.Visible = True
        ActionList.Visible = False
        SciFiList.Visible = False
        FantasyList.Visible = False
        HorrorList.Visible = False
        HorrorPic2.Visible = False
        ActionPic2.Visible = False
        ComedyPic2.Visible = True
        SciFiPic2.Visible = False
        SciFiPic1.Visible = True
        FantasyPic2.Visible = False
        FantasyPic1.Visible = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ActionList.Visible = False
        ComedyList.Visible = False
        SciFiList.Visible = True
        FantasyList.Visible = False
        HorrorPic2.Visible = False
        ActionPic2.Visible = False
        ComedyPic2.Visible = False
        SciFiPic2.Visible = True
        FantasyPic2.Visible = False
        FantasyPic1.Visible = True
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
        FantasyPic2.Visible = False
        FantasyPic1.Visible = True
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

    Private Sub MenuOn_Click(sender As Object, e As EventArgs) Handles MenuOn.Click
        MenuPnlHider.Location = New Point(9, 375)
        MenuOff.Visible = True
        MenuOn.Visible = False
    End Sub

    Private Sub MenuOff_Click(sender As Object, e As EventArgs) Handles MenuOff.Click
        MenuPnlHider.Location = New Point(9, 277)
        MenuOff.Visible = False
        MenuOn.Visible = True
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        FantasyPic2.Visible = True
        FantasyPic1.Visible = False
        ActionList.Visible = False
        ComedyList.Visible = False
        SciFiList.Visible = False
        HorrorList.Visible = False
        HorrorPic2.Visible = False
        ActionPic2.Visible = False
        ComedyPic2.Visible = False
        SciFiPic2.Visible = False
        SciFiPic1.Visible = True
        FantasyList.Visible = True
    End Sub
End Class
