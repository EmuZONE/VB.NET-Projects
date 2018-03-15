Public Class Form1
    Private Sub PauseBtn_Click(sender As Object, e As EventArgs) Handles PauseBtn.Click
        PauseBtn.Visible = False
        PlayBtn.Visible = True
        AxVLCPlugin21.playlist.togglePause()
    End Sub

    Private Sub PlayBtn_Click(sender As Object, e As EventArgs) Handles PlayBtn.Click
        PauseBtn.Visible = True
        PlayBtn.Visible = False
        BufferBarOff.Visible = False
        BufferBarOn.Visible = True
        If VLCPnl.Visible = True Then
            AxVLCPlugin21.playlist.play()
        Else
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        End
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ActionList.SelectedIndexChanged
        Select Case ActionList.SelectedIndex
            Case 0
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/NachEigenenRegeln1996.mp4")
                Durationlbl.Text = "107 Minuten"
                Genrelbl.Text = "Thriller"
                Yearlbl.Text = "1996"
                IMDBlbl.Text = "6.2/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
                Me.Text = "Movie Town - Gewählter Titel: Nach eigenen Regeln"
            Case 1
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Rookie%20der%20Anf%C3%A4nger.mp4")
                Durationlbl.Text = "121 Minuten"
                Genrelbl.Text = "Action / Comedy"
                Yearlbl.Text = "1990"
                IMDBlbl.Text = "5.9/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
                Me.Text = "Movie Town - Gewählter Titel: The Rookie"
            Case 2
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/True%20Lies.mp4")
                Durationlbl.Text = "135 Minuten"
                Genrelbl.Text = "Action"
                Yearlbl.Text = "1994"
                IMDBlbl.Text = "7.2/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 3
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/FromDuskTillDawn.mp4")
                Durationlbl.Text = "104 Minuten"
                Genrelbl.Text = "Action / Horror"
                Yearlbl.Text = "1996"
                IMDBlbl.Text = "7.3/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
                Me.Text = "Movie Town - Gewählter Titel: From Dusk Till Dawn"
            Case 4
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Cliffhanger.mp4")
                Durationlbl.Text = "118 Minuten"
                Genrelbl.Text = "Action"
                Yearlbl.Text = "1993"
                IMDBlbl.Text = "6.4/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
                Me.Text = "Movie Town - Gewählter Titel: Cliffhanger - Überleben ist alles"
            Case 5
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Tango%20%26%20Cash.mp4")
                Durationlbl.Text = "104 Minuten"
                Genrelbl.Text = "Action"
                Yearlbl.Text = "1989"
                IMDBlbl.Text = "6.4/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
                Me.Text = "Movie Town - Gewählter Titel: Tango & Cash"
            Case 6
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Last%20Action%20Hero.mp4")
                Durationlbl.Text = "130 Minuten"
                Genrelbl.Text = "Action / Comedy"
                Yearlbl.Text = "1993"
                IMDBlbl.Text = "6.3/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 7
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Lethal%20Weapon.mp4")
                Durationlbl.Text = "112 Minuten"
                Genrelbl.Text = "Action / Comedy"
                Yearlbl.Text = "1987"
                IMDBlbl.Text = "7.6/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 8
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Lethal%20Weapon%202_2.mp4")
                Durationlbl.Text = "113 Minuten"
                Genrelbl.Text = "Action / Comedy"
                Yearlbl.Text = "1989"
                IMDBlbl.Text = "6.7/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 9
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Lethal%20Weapon%202.mp4")
                Durationlbl.Text = "116 Minuten"
                Genrelbl.Text = "Action / Comedy"
                Yearlbl.Text = "1992"
                IMDBlbl.Text = "6.7/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 10
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Lethal%20Weapon%204.mp4")
                Durationlbl.Text = "127 Minuten"
                Genrelbl.Text = "Action / Comedy"
                Yearlbl.Text = "1998"
                IMDBlbl.Text = "6.6/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 11
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Red%20Heat.mp4")
                Durationlbl.Text = "104 Minuten"
                Genrelbl.Text = "Action"
                Yearlbl.Text = "1988"
                IMDBlbl.Text = "6.1/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 12
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Rambo.mp4")
                Durationlbl.Text = "93 Minuten"
                Genrelbl.Text = "Action / Survival"
                Yearlbl.Text = "1982"
                IMDBlbl.Text = "7.7/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 13
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Rambo%202.mp4")
                Durationlbl.Text = "96 Minuten"
                Genrelbl.Text = "Action / Survival"
                Yearlbl.Text = "1985"
                IMDBlbl.Text = "6.4/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 14
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Rambo%20III.mp4")
                Durationlbl.Text = "102 Minuten"
                Genrelbl.Text = "Action / Survival"
                Yearlbl.Text = "1988"
                IMDBlbl.Text = "5.7/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 15
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/John%20rambo.mp4")
                Durationlbl.Text = "92 Minuten"
                Genrelbl.Text = "Action / Splatter"
                Yearlbl.Text = "2008"
                IMDBlbl.Text = "7.0/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 16
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Der%20City%20Hai.mp4")
                Durationlbl.Text = "106 Minuten"
                Genrelbl.Text = "Action"
                Yearlbl.Text = "1986"
                IMDBlbl.Text = "5.5/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 17
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Die%20Hard.mp4")
                Durationlbl.Text = "132 Minuten"
                Genrelbl.Text = "Action"
                Yearlbl.Text = "1988"
                IMDBlbl.Text = "8.2/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 18
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Die%20Hard%202.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 19
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Die%20Hard%203.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 20
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Die%20Hard%204.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 21
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Die%20Hard%205.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 22
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Es%20war%20einmal%20in%20Amerika%20%281984%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Action / Crime"
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 23
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Goodfellas.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Action / Crime"
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 24
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KleinErnaAufDemJungfernstieg1969/Felon2008.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 25
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Iron%20Rules%20-%20Nach%20eisernen%20Regeln%20%281996%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Action / Crime"
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 26
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Pulp%20Fiction%20%281994%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 27
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Fight%20Club%20%281999%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 28
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/My80sFavorites/Undercover1995.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 29
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Der%20Pate%20%281972%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Action / Crime"
                Yearlbl.Text = "1972"
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 30
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Der%20Pate%202%20%281974%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Action / Crime"
                Yearlbl.Text = "1974"
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 31
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Der%20Pate%203%20%281990%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Action / Crime"
                Yearlbl.Text = "1990"
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 32
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/AmericanPsycho2000.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 33
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/AmericanPsychoIi-DerHorrorGehtWeiter.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 34
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesII/Babylon%20A.D.%20%282008%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 35
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesII/American%20Psycho%20%282000%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 36
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesII/American%20Psycho%20II%20-%20Der%20Horror%20geht%20weiter.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 37
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Mad%20Max%20%281979%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 38
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Mad%20Max%202%20-%20Der%20Vollstrecker%20%281981%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 39
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Mad%20Max%203%20-%20Jenseits%20der%20Donnerkuppel%20%281985%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 40
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Mad.Max.Fury.Road.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 41
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Sin%20City%20%282005%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 42
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Hellboy%20%282004%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 43
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Pfad%20der%20Rache%20%282017%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 44
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Natural%20Born%20Killers%20%281994%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 45
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Rocky%20%281976%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 46
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/The%20Colony%20-%20Hell%20Freezes%20Over%20%282013%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 47
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Universal%20Soldier%20-%20Die%20R%C3%BCckkehr%20%281999%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 48
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Universal%20Soldier%20Day%20of%20Reckoning%20%282012%29%20.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 49
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MadeOfSteelHartWieStahl/Made%20Of%20Steel%20-%20Hart%20wie%20Stahl.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 50
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 51
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 52
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 53
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 54
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 55
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 56
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 57
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 58
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 59
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 60
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 61
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 62
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 63
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 64
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 65
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 66
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 67
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 68
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 69
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 70
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 71
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComedyList.SelectedIndexChanged
        Select Case ComedyList.SelectedIndex
            Case 0
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KleinErnaAufDemJungfernstieg1969/Die%20Supernasen.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 1
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KleinErnaAufDemJungfernstieg1969/Zwei%20Nasen%20tanken%20Super.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 2
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ZrtlicheChaoten/Z%C3%A4rtliche%20Chaoten%20%281987%29%20HD%20Stream%20%C2%BB%20StreamKistetv.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 3
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ZrtlicheChaoten/Z%C3%A4rtliche%20Chaoten%20II%20%281988%29%20HD%20Stream%20%C2%BB%20StreamKistetv.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 4
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KleinErnaAufDemJungfernstieg1969/Piratensender%20Power%20Play.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 5
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/My80sFavorites/DieEinsteiger.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 6
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/00%20Schneider%20-%20Jagd%20auf%20Nihil%20Baxter.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 7
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/00%20Schneider%20-%20Im%20Wendekreis%20der%20Eidechse.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 8
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Fant%C3%B4mas%20%281964%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 9
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Fant%C3%B4mas%20se%20d%C3%A9cha%C3%AEne%20%281965%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 10
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Fant%C3%B4mas%20contre%20Scotland%20Yard%20%281967%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 11
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Ein%20Zwilling%20kommt%20selten%20allein.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 12
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/My80sFavorites/Ach%20du%20lieber%20Harry%20%281981%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 13
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KleinErnaAufDemJungfernstieg1969/Didi%20auf%20vollen%20Touren.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 14
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/My80sFavorites/Didi%20-%20Der%20Doppelg%C3%A4nger%20%281984%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 15
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/My80sFavorites/Didi-DerExperte1988.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 16
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/My80sFavorites/DidiUndDieRacheDerEnterbten.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 17
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KleinErnaAufDemJungfernstieg1969/ImBanneDerRouladenknigin.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 18
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KleinErnaAufDemJungfernstieg1969/ElsterglanzUndDerSchlsselFrDieWeibersauna2016.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 19
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KleinErnaAufDemJungfernstieg1969/TopSecret1984.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 20
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Otto%20der%20Film.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 21
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KleinErnaAufDemJungfernstieg1969/Otto%20der%20neue%20Film.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 22
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Der%20Supercop.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 23
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KleinErnaAufDemJungfernstieg1969/Spaceballs1987.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 24
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Bullyparade-DerFilm2017.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 25
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/AdrianoCelentano_201803/Die%20Indianer%20von%20Cleveland.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 26
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/AdrianoCelentano_201803/Die%20Indianer%20von%20Cleveland%202.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 27
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Cinderella%20%2780%20%281984%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 28
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Die%20Maske%20%281994%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 29
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Mein%20Partner%20mit%20der%20kalten%20Schnauze%20%281989%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 30
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/South%20Park%20-%20Der%20Film%20%281999%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 31
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Jumanji%20-%20Willkommen%20im%20Dschungel%20%282017%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Action/Comedy"
                Yearlbl.Text = "2017"
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 32
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/yggdrazil_hotmail_TBL/TheBigLebowski.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Action/Comedy"
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 33
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Zwei%20au%C3%9Fer%20Rand%20und%20Band.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Action/Comedy"
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 34
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 35
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 36
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 37
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 38
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 39
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 40
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 41
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 42
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 43
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 44
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 45
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 46
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 47
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 48
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 49
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 50
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 51
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 52
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 53
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 54
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 55
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 56
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 57
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 58
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 59
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 60
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 61
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 62
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 63
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 64
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 65
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 66
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 67
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 68
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 69
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 70
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 71
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
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
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Nightmare%20on%20Elm%20Street%201%20-%20M%C3%B6rderische%20Tr%C3%A4ume.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 24
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/Nightmare%20on%20Elm%20Street%202.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 25
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Nightmare%20on%20Elm%20Street%203%20-%20Freddy%20lebt.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 26
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Nightmare%20on%20Elm%20Street%204_%20The%20Dream%20Master.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 27
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Nightmare%20on%20Elm%20Street%205%20-%20Das%20Trauma.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 28
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Nightmare%20on%20Elm%20Street%206%20-%20Freddy%27s%20Finale.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 29
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ClassicMovieCollection/A%20Nightmare%20on%20Elm%20Street%20%282010%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 30
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Leprechaun%20-%20Der%20Killerkobold.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 31
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Leprechaun%202%20-%20Der%20Killerkobold%20kehrt%20zur%C3%BCck.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 32
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Leprechaun%203%20-%20T%C3%B6dliches%20Spiel%20in%20Las%20Vegas.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 33
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Leprechaun%204%20-%20Space%20Platoon.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 34
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Leprechaun%205%20-%20In%20The%20Hood.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 35
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Leprechaun%202%20-%20Back%202%20tha%20Hood.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 36
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Leprechaun%20Origins.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 37
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Mimic.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 38
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/The%20Fog%20-%20Nebel%20des%20Grauens.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 39
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Seekers.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 40
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Sharknado.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 41
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Shin%20Godzilla.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 42
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Way%20of%20the%20Living%20Dead.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 43
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/The%20Canal.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 44
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 45
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/The%20Conjuring%202.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 46
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/The%20Dead%202.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 47
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/REC%203.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 48
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/House%20of%20the%20Dead.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 49
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Joyride%20-%20Spritztour.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 50
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Der%20Fluch%20-%20The%20Grudge%20%282004%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 51
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Der%20Fluch%20-%20The%20Grudge%202%20%282006%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 52
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Der%20Fluch%20-%20The%20Grudge%203%20%282009%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 53
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Wes%20Craven%27s%20Wishmaster%20%281997%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 54
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Wishmaster%202%20-%20Das%20B%C3%B6se%20stirbt%20nie.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 55
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Wishmaster%203%20-%20Der%20H%C3%B6llenstein%20%282001%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 56
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 57
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 58
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 59
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 60
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 61
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 62
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 63
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 64
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 65
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 66
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 67
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 68
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 69
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 70
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 71
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
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
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Star%20Wars%20-%20Die%20letzten%20Jedi%20%282017%29.mp4")
            Case 10
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Terminator.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 11
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Terminator2.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 12
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = "https://archive.org/download/OldSchool-Movies/Terminator3.mp4"
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 13
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Terminator4.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 14
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Terminator.5.Genesys.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 15
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/TotalRecall-DieTotaleErinnerung.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 16
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KultHorror02/Sie%20Leben.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 17
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/The%20Sixt%20Sence.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 18
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Signs%20-%20Zeichen.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 19
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/Robocop1-3UnC/Robocop%20%281987%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 20
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/Robocop1-3UnC/Robocop%202.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 21
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/Robocop1-3UnC/Robocop%203.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 22
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Der%20Flug%20des%20Navigators.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 23
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/CowboysAliens.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 24
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 25
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 26
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 27
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 28
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 29
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 30
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 31
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 32
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 33
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 34
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 35
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 36
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 37
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 38
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 39
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 40
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 41
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 42
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 43
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 44
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 45
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 46
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 47
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 48
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 49
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 50
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 51
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 52
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 53
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 54
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 55
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 56
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 57
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 58
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 59
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 60
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 61
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 62
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 63
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 64
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 65
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 66
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 67
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 68
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 69
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 70
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 71
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
        End Select
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FantasyList.SelectedIndexChanged
        Select Case FantasyList.SelectedIndex
            Case 0
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Herr%20der%20Ringe.mp4")
                Durationlbl.Text = "178 Minuten"
                Genrelbl.Text = "Fantasy / Abenteuer"
                Yearlbl.Text = "2001"
                IMDBlbl.Text = "8.8/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 1
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Herr%20der%20Ringe%202.mp4")
                Durationlbl.Text = "184 Minuten"
                Genrelbl.Text = "Fantasy / Abenteuer"
                Yearlbl.Text = "2002"
                IMDBlbl.Text = "8.7/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 2
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Herr%20der%20Ringe%203.mp4")
                Durationlbl.Text = "201 Minuten"
                Genrelbl.Text = "Fantasy / Abenteuer"
                Yearlbl.Text = "2003"
                IMDBlbl.Text = "8.9/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 3
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Der%20Hobbit.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Fantasy / Abenteuer"
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 4
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Der%20Hobbit%202.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Fantasy / Abenteuer"
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 5
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Der%20Hobbit%203.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Fantasy / Abenteuer"
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 6
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/DieUnendlicheGeschichte.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Fantasy / Abenteuer"
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 7
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/DieUnendlicheGeschichte2.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Fantasy / Abenteuer"
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 8
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/My80sFavorites/Highlander.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Fantasy / Abenteuer"
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 9
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Indiana%20Jones%20-%20J%C3%A4ger%20des%20verlorenen%20Schatzes.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Abenteuer"
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 10
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Indiana%20Jones%20und%20der%20Tempel%20des%20Todes.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Abenteuer"
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 11
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Indiana%20Jones%20und%20der%20letzte%20Kreuzzug.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Abenteuer"
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 12
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Indiana%20Jones%20und%20das%20K%C3%B6nigreich%20des%20Kristallsch%C3%A4dels.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Abenteuer"
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 13
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Auf%20der%20Jagd%20nach%20dem%20gr%C3%BCnen%20Diamanten.mp4")
                Durationlbl.Text = "106 Minuten"
                Genrelbl.Text = "Abenteuer"
                Yearlbl.Text = "1984"
                IMDBlbl.Text = "6.9/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 14
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Auf%20der%20Jagd%20nach%20dem%20Juwel%20vom%20Nil.mp4")
                Durationlbl.Text = "106 Minuten"
                Genrelbl.Text = "Abenteuer"
                Yearlbl.Text = "1986"
                IMDBlbl.Text = "6.1/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 15
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Conan%20der%20Barbar.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 16
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Conan%20der%20Zerst%C3%B6rer.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 17
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Red%20Sonja.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 18
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KleinErnaAufDemJungfernstieg1969/Der13Krieger1999.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 19
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesII/Batman%20%281989%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Superhero / Fantasy"
                Yearlbl.Text = "1989"
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 20
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesII/Batman%20Forever%20%281995%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Superhero / Fantasy"
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 21
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Batman%20%26%20Robin.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Superhero / Fantasy"
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 22
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesII/Batman%20Begins%20%282005%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 23
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 24
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 25
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 26
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 27
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 28
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 29
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 30
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 31
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 32
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 33
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 34
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 35
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 36
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 37
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 38
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 39
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 40
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 41
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 42
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 43
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 44
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 45
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 46
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 47
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 48
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 49
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 50
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 51
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 52
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 53
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 54
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 55
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 56
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 57
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 58
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 59
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 60
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 61
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 62
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 63
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 64
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 65
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 66
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 67
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 68
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 69
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 70
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 71
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
        End Select
    End Sub

    Private Sub ActionListPlayBtn_Click(sender As Object, e As EventArgs) Handles ActionListPlayBtn.Click
        PlayBtn.Visible = False
        PauseBtn.Visible = True
        AxVLCPlugin21.playlist.next()
        AxVLCPlugin21.playlist.play()
        BufferBarOff.Visible = False
        BufferBarOn.Visible = True
        Min.Start()
        Sek.Start()
        Millisek.Start()
    End Sub

    Private Sub Millisek_Tick(sender As Object, e As EventArgs) Handles Millisek.Tick
        Milliseklbl.Text = Milliseklbl.Text + 1
        If Milliseklbl.Text = 10 Then
            Milliseklbl.Text = "00"
        End If
        If Milliseklbl.Text = 1 Then
            Milliseklbl.Text = "01"
        End If
        If Milliseklbl.Text = 2 Then
            Milliseklbl.Text = "02"
        End If
        If Milliseklbl.Text = 3 Then
            Milliseklbl.Text = "03"
        End If
        If Milliseklbl.Text = 4 Then
            Milliseklbl.Text = "04"
        End If
        If Milliseklbl.Text = 5 Then
            Milliseklbl.Text = "05"
        End If
        If Milliseklbl.Text = 6 Then
            Milliseklbl.Text = "06"
        End If
        If Milliseklbl.Text = 7 Then
            Milliseklbl.Text = "07"
        End If
        If Milliseklbl.Text = 8 Then
            Milliseklbl.Text = "08"
        End If
        If Milliseklbl.Text = 9 Then
            Milliseklbl.Text = "09"
        End If
    End Sub

    Private Sub Sek_Tick(sender As Object, e As EventArgs) Handles Sek.Tick
        Seklbl.Text = Seklbl.Text + 1
        If Seklbl.Text = 60 Then
            Seklbl.Text = "00"
        End If
        If Seklbl.Text = 1 Then
            Seklbl.Text = "01"
        End If
        If Seklbl.Text = 2 Then
            Seklbl.Text = "02"
        End If
        If Seklbl.Text = 3 Then
            Seklbl.Text = "03"
        End If
        If Seklbl.Text = 4 Then
            Seklbl.Text = "04"
        End If
        If Seklbl.Text = 5 Then
            Seklbl.Text = "05"
        End If
        If Seklbl.Text = 6 Then
            Seklbl.Text = "06"
        End If
        If Seklbl.Text = 7 Then
            Seklbl.Text = "07"
        End If
        If Seklbl.Text = 8 Then
            Seklbl.Text = "08"
        End If
        If Seklbl.Text = 9 Then
            Seklbl.Text = "09"
        End If
    End Sub

    Private Sub Min_Tick(sender As Object, e As EventArgs) Handles Min.Tick
        Minlbl.Text = Minlbl.Text + 1
        If Minlbl.Text = 1 Then
            Minlbl.Text = "01"
        End If
        If Minlbl.Text = 2 Then
            Minlbl.Text = "02"
        End If
        If Minlbl.Text = 3 Then
            Minlbl.Text = "03"
        End If
        If Minlbl.Text = 4 Then
            Minlbl.Text = "04"
        End If
        If Minlbl.Text = 5 Then
            Minlbl.Text = "05"
        End If
        If Minlbl.Text = 6 Then
            Minlbl.Text = "06"
        End If
        If Minlbl.Text = 7 Then
            Minlbl.Text = "07"
        End If
        If Minlbl.Text = 8 Then
            Minlbl.Text = "08"
        End If
        If Minlbl.Text = 9 Then
            Minlbl.Text = "09"
        End If
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
        PlayBtn.Visible = True
        BufferBarOff.Visible = True
        BufferBarOn.Visible = False
        Durationlbl.Visible = False
        Genrelbl.Visible = False
        Yearlbl.Visible = False
        IMDBlbl.Visible = False
        Min.Stop()
        Sek.Stop()
        Millisek.Stop()
        Me.Text = "Movie Town: Advanced Online Movie Player"
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
        WesternList.Visible = False
        WesternPic2.Visible = False
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
        WesternList.Visible = False
        WesternPic2.Visible = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles SciFiBtn.Click
        ActionList.Visible = False
        HorrorList.Visible = False
        ComedyList.Visible = False
        SciFiList.Visible = True
        FantasyList.Visible = False
        HorrorPic2.Visible = False
        ActionPic2.Visible = False
        ComedyPic2.Visible = False
        SciFiPic2.Visible = True
        FantasyPic2.Visible = False
        FantasyPic1.Visible = True
        WesternList.Visible = False
        WesternPic2.Visible = False
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
        WesternList.Visible = False
        WesternPic2.Visible = False
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles VolOnBtn.Click
        VolPnl.Visible = True
        InfoPnl.Visible = False
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
        If ActionList.Visible = True Then
            ActionListPlayBtn.Visible = True
            Button8.Visible = False
        Else
            If ComedyList.Visible Then
                ComedyListPlayBtn.Visible = True
                Button8.Visible = False
            Else
                If SciFiList.Visible = True Then
                    SciFiListPlayBtn.Visible = True
                    Button8.Visible = False
                Else
                    If HorrorList.Visible = True Then
                        HorrorListPlayBtn.Visible = True
                        Button8.Visible = False
                    Else
                        If FantasyList.Visible = True Then
                            FantasyListPlayBtn.Visible = True
                            Button8.Visible = False
                        End If
                    End If
                End If
            End If
        End If
        ActionList.Visible = True
        ActionPic2.Visible = True
        SciFiPic2.Visible = False
        SciFiPic1.Visible = True
        AxVLCPlugin21.input.position = BufferBarOff.Value
    End Sub

    Private Sub PosOnBtn_Click(sender As Object, e As EventArgs) Handles PosOnBtn.Click
        VolPnl.Visible = True
        InfoPnl.Visible = False
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
        MenuPnlHider.Location = New Point(46, 387)
        MenuOff.Visible = True
        MenuOn.Visible = False
    End Sub

    Private Sub MenuOff_Click(sender As Object, e As EventArgs) Handles MenuOff.Click
        MenuPnlHider.Location = New Point(46, 289)
        MenuOff.Visible = False
        MenuOn.Visible = True
        InfoPnl.Visible = False
        Durationlbl.Visible = False
        Genrelbl.Visible = False
        Yearlbl.Visible = False
        IMDBlbl.Visible = False
        InfoOffBtn.Visible = False
        InfoOnBtn.Visible = True
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
        WesternList.Visible = False
        WesternPic2.Visible = False
    End Sub

    Private Sub InfoOnBtn_Click(sender As Object, e As EventArgs) Handles InfoOnBtn.Click
        InfoOffBtn.Visible = True
        InfoOnBtn.Visible = False
        InfoPnl.Visible = True
        VolPnl.Visible = False
    End Sub

    Private Sub InfoOffBtn_Click(sender As Object, e As EventArgs) Handles InfoOffBtn.Click
        InfoOffBtn.Visible = False
        InfoOnBtn.Visible = True
        InfoPnl.Visible = False
    End Sub

    Private Sub TimerStopBtn_Click(sender As Object, e As EventArgs)
        Min.Stop()
        Sek.Stop()
        Millisek.Stop()
    End Sub

    Private Sub TimerResetBtn_Click(sender As Object, e As EventArgs)
        Min.Stop()
        Sek.Stop()
        Millisek.Stop()
        Minlbl.Text = "00"
        Seklbl.Text = "00"
        Milliseklbl.Text = "00"
    End Sub

    Private Sub FantasyListPlayBtn_Click(sender As Object, e As EventArgs) Handles FantasyListPlayBtn.Click
        PlayBtn.Visible = False
        PauseBtn.Visible = True
        AxVLCPlugin21.playlist.next()
        AxVLCPlugin21.playlist.play()
        BufferBarOff.Visible = False
        BufferBarOn.Visible = True
        Min.Start()
        Sek.Start()
        Millisek.Start()
    End Sub

    Private Sub HorrorListPlayBtn_Click(sender As Object, e As EventArgs) Handles HorrorListPlayBtn.Click
        PlayBtn.Visible = False
        PauseBtn.Visible = True
        AxVLCPlugin21.playlist.next()
        AxVLCPlugin21.playlist.play()
        BufferBarOff.Visible = False
        BufferBarOn.Visible = True
        Min.Start()
        Sek.Start()
        Millisek.Start()
    End Sub

    Private Sub ComedyListPlayBtn_Click(sender As Object, e As EventArgs) Handles ComedyListPlayBtn.Click
        PlayBtn.Visible = False
        PauseBtn.Visible = True
        AxVLCPlugin21.playlist.next()
        AxVLCPlugin21.playlist.play()
        BufferBarOff.Visible = False
        BufferBarOn.Visible = True
        Min.Start()
        Sek.Start()
        Millisek.Start()
    End Sub

    Private Sub SciFiListPlayBtn_Click(sender As Object, e As EventArgs) Handles SciFiListPlayBtn.Click
        PlayBtn.Visible = False
        PauseBtn.Visible = True
        AxVLCPlugin21.playlist.next()
        AxVLCPlugin21.playlist.play()
        BufferBarOff.Visible = False
        BufferBarOn.Visible = True
        Min.Start()
        Sek.Start()
        Millisek.Start()
    End Sub

    Private Sub WesternList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WesternList.SelectedIndexChanged
        Select Case WesternList.SelectedIndex
            Case 0
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Mein%20Name%20ist%20Nobody.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 1
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Nobody%20ist%20der%20Gr%C3%B6%C3%9Fte.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 2
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Django.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 3
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Django%20II.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 4
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Auch%20Djangos%20Kopf%20hat%20einen%20Preis.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 5
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Django%20-%20Nacht%20der%20langen%20Messer.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 6
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Winnetou%201%20%281963%29.mp4")
                Durationlbl.Text = "101 Minuten"
                Genrelbl.Text = "Western"
                Yearlbl.Text = "1963"
                IMDBlbl.Text = "6.9/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 7
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Winnetou%20II%20%281964%29.mp4")
                Durationlbl.Text = "91 Minuten"
                Genrelbl.Text = "Western"
                Yearlbl.Text = "1964"
                IMDBlbl.Text = "6.6/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 8
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Winnetou%20III%20%281965%29.mp4")
                Durationlbl.Text = "92 Minuten"
                Genrelbl.Text = "Western"
                Yearlbl.Text = "1965"
                IMDBlbl.Text = "6.7/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 9
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/DerOelprinzAbenteuerfilm1965/Der_Oelprinz_Abenteuerfilm_1965.mp4")
                Durationlbl.Text = "89 Minuten"
                Genrelbl.Text = "Western"
                Yearlbl.Text = "1965"
                IMDBlbl.Text = "5.9/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 10
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/UnterGeiernDeutschlandFranceItaly1964SpielfilmWestern/Unter_Geiern_Deutschland_France_Italy_1964_Spielfilm_Western.mp4")
                Durationlbl.Text = "98 Minuten"
                Genrelbl.Text = "Western"
                Yearlbl.Text = "1964"
                IMDBlbl.Text = "5.9/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 11
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSurehandAbenteuerfilm1965/Old_Surehand_Abenteuerfilm_1965.mp4")
                Durationlbl.Text = "90 Minuten"
                Genrelbl.Text = "Western"
                Yearlbl.Text = "1965"
                IMDBlbl.Text = "5.9/10"
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 12
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldShatterhand1964SpielfilmDeutschlandYugoslawienAbenteuerfilmWestern/Old_Shatterhand_1964_Spielfilm_Deutschland_Yugoslawien_Abenteuerfilm_Western.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 13
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/DjangoDerRaecherItalienSpanien1966SpielfilmDramaWesternItalowestern/Django_der_Raecher_Italien_Spanien_1966_Spielfilm_Drama_Western_Italowestern.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 14
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/GermanMoviesVol2/Zwiebeljack%20r%C3%A4umt%20auf.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
        End Select
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        FantasyPic2.Visible = False
        FantasyPic1.Visible = True
        ActionList.Visible = False
        ComedyList.Visible = False
        SciFiList.Visible = False
        HorrorList.Visible = False
        HorrorPic2.Visible = False
        ActionPic2.Visible = False
        ComedyPic2.Visible = False
        SciFiPic2.Visible = False
        SciFiPic1.Visible = True
        FantasyList.Visible = False
        WesternList.Visible = True
        WesternPic2.Visible = True
        JCVDPic2.Visible = False
        JCVDList.Visible = False
        KlassikPic2.Visible = False
        KlassikList.Visible = False
        ArniPic2.Visible = False
        ArniList.Visible = False
        StalonePic2.Visible = True
        StaloneList.Visible = True
        LouisPic2.Visible = False
        LouisList.Visible = False
        AdrianoPic2.Visible = False
        AdrianoList.Visible = False
    End Sub

    Private Sub BarBtn1_Click(sender As Object, e As EventArgs) Handles BarBtn1.Click
        BufferBarOn.Visible = False
        BufferBarOff.Visible = True
        BarBtn1.Visible = False
        BarBtn2.Visible = True
    End Sub

    Private Sub BarBtn2_Click(sender As Object, e As EventArgs) Handles BarBtn2.Click
        BufferBarOn.Visible = True
        BufferBarOff.Visible = False
        BarBtn1.Visible = True
        BarBtn2.Visible = False
        BufferBarOff.PerformStep()
    End Sub

    Private Sub ExtraOnBtn_Click(sender As Object, e As EventArgs) Handles ExtraOnBtn.Click
        ExtraOnBtn.Visible = False
        ExtraOffBtn.Visible = True
        ExtraPnl.Visible = True
        JCVDPic2.Visible = True
        JCVDList.Visible = True
        ArniPic2.Visible = False
        ArniList.Visible = False
    End Sub

    Private Sub ExtraOffBtn_Click(sender As Object, e As EventArgs) Handles ExtraOffBtn.Click
        ExtraOnBtn.Visible = True
        ExtraOffBtn.Visible = False
        ExtraPnl.Visible = False
        JCVDPic2.Visible = False
        JCVDList.Visible = False
        ArniList.Visible = False
        AdrianoList.Visible = False
        KlassikList.Visible = False
        StaloneList.Visible = False
        LouisList.Visible = False
    End Sub

    Private Sub JCVDBtn_Click(sender As Object, e As EventArgs) Handles JCVDBtn.Click
        FantasyPic2.Visible = False
        FantasyPic1.Visible = True
        ActionList.Visible = False
        ComedyList.Visible = False
        SciFiList.Visible = False
        HorrorList.Visible = False
        HorrorPic2.Visible = False
        ActionPic2.Visible = False
        ComedyPic2.Visible = False
        SciFiPic2.Visible = False
        SciFiPic1.Visible = True
        FantasyList.Visible = False
        WesternList.Visible = False
        WesternPic2.Visible = False
        JCVDPic2.Visible = True
        JCVDList.Visible = True
        KlassikPic2.Visible = False
        KlassikList.Visible = False
        ArniPic2.Visible = False
        ArniList.Visible = False
        StalonePic2.Visible = False
        StaloneList.Visible = False
        LouisPic2.Visible = False
        LouisList.Visible = False
        AdrianoPic2.Visible = False
        AdrianoList.Visible = False
    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles KlassikBtn.Click
        FantasyPic2.Visible = False
        FantasyPic1.Visible = True
        ActionList.Visible = False
        ComedyList.Visible = False
        SciFiList.Visible = False
        HorrorList.Visible = False
        HorrorPic2.Visible = False
        ActionPic2.Visible = False
        ComedyPic2.Visible = False
        SciFiPic2.Visible = False
        SciFiPic1.Visible = True
        FantasyList.Visible = False
        WesternList.Visible = False
        WesternPic2.Visible = False
        JCVDPic2.Visible = False
        JCVDList.Visible = False
        KlassikPic2.Visible = True
        KlassikList.Visible = True
        ArniPic2.Visible = False
        ArniList.Visible = False
        StalonePic2.Visible = False
        StaloneList.Visible = False
        LouisPic2.Visible = False
        LouisList.Visible = False
        AdrianoPic2.Visible = False
        AdrianoList.Visible = False
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles ArniBtn.Click
        FantasyPic2.Visible = False
        FantasyPic1.Visible = True
        ActionList.Visible = False
        ComedyList.Visible = False
        SciFiList.Visible = False
        HorrorList.Visible = False
        HorrorPic2.Visible = False
        ActionPic2.Visible = False
        ComedyPic2.Visible = False
        SciFiPic2.Visible = False
        SciFiPic1.Visible = True
        FantasyList.Visible = False
        WesternList.Visible = False
        WesternPic2.Visible = False
        JCVDPic2.Visible = False
        JCVDList.Visible = False
        KlassikPic2.Visible = False
        KlassikList.Visible = False
        ArniPic2.Visible = True
        ArniList.Visible = True
        StalonePic2.Visible = False
        StaloneList.Visible = False
        LouisPic2.Visible = False
        LouisList.Visible = False
        AdrianoPic2.Visible = False
        AdrianoList.Visible = False
    End Sub

    Private Sub StaloneBtn_Click(sender As Object, e As EventArgs) Handles StaloneBtn.Click
        FantasyPic2.Visible = False
        FantasyPic1.Visible = True
        ActionList.Visible = False
        ComedyList.Visible = False
        SciFiList.Visible = False
        HorrorList.Visible = False
        HorrorPic2.Visible = False
        ActionPic2.Visible = False
        ComedyPic2.Visible = False
        SciFiPic2.Visible = False
        SciFiPic1.Visible = True
        FantasyList.Visible = False
        WesternList.Visible = False
        WesternPic2.Visible = False
        JCVDPic2.Visible = False
        JCVDList.Visible = False
        KlassikPic2.Visible = False
        KlassikList.Visible = False
        ArniPic2.Visible = False
        ArniList.Visible = False
        StalonePic2.Visible = True
        StalonePic1.Visible = True
        StaloneList.Visible = True
        LouisPic2.Visible = False
        LouisList.Visible = False
        AdrianoPic2.Visible = False
        AdrianoList.Visible = False
    End Sub

    Private Sub LouisBtn_Click(sender As Object, e As EventArgs) Handles LouisBtn.Click
        FantasyPic2.Visible = False
        FantasyPic1.Visible = True
        ActionList.Visible = False
        ComedyList.Visible = False
        SciFiList.Visible = False
        HorrorList.Visible = False
        HorrorPic2.Visible = False
        ActionPic2.Visible = False
        ComedyPic2.Visible = False
        SciFiPic2.Visible = False
        SciFiPic1.Visible = True
        FantasyList.Visible = False
        WesternList.Visible = False
        WesternPic2.Visible = False
        JCVDPic2.Visible = False
        JCVDList.Visible = False
        KlassikPic2.Visible = False
        KlassikList.Visible = False
        ArniPic2.Visible = False
        ArniList.Visible = False
        StalonePic2.Visible = False
        StalonePic1.Visible = True
        StaloneList.Visible = False
        LouisPic2.Visible = True
        LouisList.Visible = True
        AdrianoPic2.Visible = False
        AdrianoList.Visible = False
    End Sub

    Private Sub AdrianoBtn_Click(sender As Object, e As EventArgs) Handles AdrianoBtn.Click
        FantasyPic2.Visible = False
        FantasyPic1.Visible = True
        ActionList.Visible = False
        ComedyList.Visible = False
        SciFiList.Visible = False
        HorrorList.Visible = False
        HorrorPic2.Visible = False
        ActionPic2.Visible = False
        ComedyPic2.Visible = False
        SciFiPic2.Visible = False
        SciFiPic1.Visible = True
        FantasyList.Visible = False
        WesternList.Visible = False
        WesternPic2.Visible = False
        JCVDPic2.Visible = False
        JCVDList.Visible = False
        KlassikPic2.Visible = False
        KlassikList.Visible = False
        ArniPic2.Visible = False
        ArniList.Visible = False
        StalonePic2.Visible = False
        StalonePic1.Visible = True
        StaloneList.Visible = False
        LouisPic2.Visible = False
        LouisList.Visible = False
        AdrianoPic2.Visible = True
        AdrianoList.Visible = True
    End Sub

    Private Sub ArniList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ArniList.SelectedIndexChanged
        Select Case ArniList.SelectedIndex
            Case 0
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Conan%20der%20Barbar.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 1
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Conan%20der%20Zerst%C3%B6rer.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 2
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Last%20Action%20Hero.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 3
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Predator.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 4
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Red%20Heat.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 5
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Red%20Sonja.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 6
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/True%20Lies.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 7
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/TotalRecall-DieTotaleErinnerung.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 8
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Terminator.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 9
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Terminator2.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 10
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Terminator3.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 11
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Terminator4.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 12
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Terminator.5.Genesys.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 13
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Der%20City%20Hai.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 14
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 15

        End Select
    End Sub

    Private Sub JCVDList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JCVDList.SelectedIndexChanged
        Select Case JCVDList.SelectedIndex
            Case 0
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/JCVDFilms/Bloodsport.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 1
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/JCVDFilms/Cyborg.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 2
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/JCVDFilms/Der%20Kickboxer.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 3
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/JCVDFilms/Double%20Team.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 4
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/JCVDFilms/Geballte%20Ladung.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 5
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/JCVDFilms/Harte%20Ziele.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 6
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/JCVDFilms/Inferno.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 7
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/JCVDFilms/Kickboxer%20-%20Vergeltung.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 8
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/JCVDFilms/Knock%20Off.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 9
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/JCVDFilms/Lionheart.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 10
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/JCVDFilms/Maximum%20Risk.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 11
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/JCVDFilms/Mit%20st%C3%A4hlerner%20Faust.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 12
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/JCVDFilms/Ohne%20Ausweg.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 13
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/JCVDFilms/Replicant.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 14
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/JCVDFilms/Sudden%20Death.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 15
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/JCVDFilms/Timecop.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 16
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/JCVDFilms/Universal%20Soldier.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 17
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/JCVDFilms/Universal%20Soldier%20Regeneration.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 18
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Derailed%20-%20Terror%20im%20Zug.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
        End Select
    End Sub

    Private Sub LouisList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LouisList.SelectedIndexChanged
        Select Case LouisList.SelectedIndex
            Case 0
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Fant%C3%B4mas%20%281964%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 1
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Fant%C3%B4mas%20se%20d%C3%A9cha%C3%AEne%20%281965%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 2
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/CinemaOf90/Fant%C3%B4mas%20contre%20Scotland%20Yard%20%281967%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 3
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesII/Balduin%20der%20Ferienschreck.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Komödie"
                Yearlbl.Text = "1969"
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 4
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesII/Balduin%20der%20Sonntagsfahrer%20%281971%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Komödie"
                Yearlbl.Text = "1971"
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 5
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesII/Balduin%2C%20das%20Nachtgespenst%20%281968%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Komödie"
                Yearlbl.Text = "1971"
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 6
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesII/Balduin%2C%20der%20Heiratsmuffel%20%281968%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = "Komödie"
                Yearlbl.Text = "1971"
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
        End Select
    End Sub

    Private Sub AdrianoList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AdrianoList.SelectedIndexChanged
        Select Case AdrianoList.SelectedIndex
            Case 0
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/AdrianoCelentano_201803/Asso%20-%20Ein%20himmlischer%20Spieler.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 1
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/AdrianoCelentano_201803/Bingo%20Bongo.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 2
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/AdrianoCelentano_201803/Der%20gez%C3%A4hmte%20Widerspenstige.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 3
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/AdrianoCelentano_201803/Gib%20dem%20Affen%20Zucker.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 4
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
        End Select
    End Sub

    Private Sub StaloneList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StaloneList.SelectedIndexChanged
        Select Case StaloneList.SelectedIndex
            Case 0
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Tango%20und%20Cash%20%281989%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 1
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Rambo.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 2
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Rambo%202.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 3
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Rambo%20III.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 4
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/John%20rambo.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 5
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/OldSchool-Movies/Cliffhanger.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 6
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MoviesIII/Rocky%20%281976%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
        End Select
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Me.Hide()
        UpdateDialog.Show()
    End Sub

    Private Sub TimerResetBtn_Click_1(sender As Object, e As EventArgs) Handles TimerResetBtn.Click
        Minlbl.Text = "00"
        Seklbl.Text = "00"
        Milliseklbl.Text = "00"
        Min.Stop()
        Sek.Stop()
        Millisek.Stop()
    End Sub

    Private Sub KlassikList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KlassikList.SelectedIndexChanged
        Select Case KlassikList.SelectedIndex
            Case 0
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/PepeDerPaukerschreck/Die%20L%C3%BCmmel%20von%20der%20ersten%20Bank%20%281968%29%20HD%20Stream%20%C2%BB.mp4")
                Durationlbl.Text = "83 Minuten"
                Genrelbl.Text = "Komödie"
                Yearlbl.Text = "1968"
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 1
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/DieLmmelV.d.ErstenBankVol.1/Zum%20Teufel%20mit%20der%20Penne%20%281968%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 2
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/PepeDerPaukerschreck/Pepe%2C%20der%20Paukerschreck.mp4")
                Durationlbl.Text = "91 Minuten"
                Genrelbl.Text = "Komödie"
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 3
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/DieLmmelV.d.ErstenBankVol.1/Hurra%2C%20die%20Schule%20brennt.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 4
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MadeOfSteelHartWieStahl/Wir%20haun%20die%20Pauker%20in%20die%20Pfanne%20%281970%29%20HD%20Stream%20%C2%BB.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 5
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MadeOfSteelHartWieStahl/Morgen%20f%C3%A4llt%20die%20Schule%20aus%20%281971%29%20HD%20Stream%20%C2%BB%20StreamKistetv.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 6
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MadeOfSteelHartWieStahl/Betragen%20ungen%C3%BCgend%20%281972%29%20HD%20Stream%20%C2%BB%20StreamKistetv.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 7
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KleinErnaAufDemJungfernstieg1969/Der%20Hauptmann%20von%20K%C3%B6penik.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 8
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KleinErnaAufDemJungfernstieg1969/Klein%20Erna%20auf%20dem%20Jungfernstieg%20%281969%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 9
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/KleinErnaAufDemJungfernstieg1969/Ohne%20Krimi%20geht%20die%20Mimi%20nie%20ins%20Bett.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 10
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/DieLmmelV.d.ErstenBankVol.1/Unser%20Willi%20ist%20der%20Beste%20%281971%29.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 11
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/DieLmmelV.d.ErstenBankVol.1/Willi%20wird%20das%20Kind%20schon%20schaukeln.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 12
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/HeintjeEinmalWirdDieSonneWiederScheinenDeutschland1970Spielfilm/Heintje_Einmal_wird_die_Sonne_wieder_scheinen_Deutschland_1970_Spielfilm.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 13
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/HeintjeEinHerzGehtAufReisenDeutschland1969Spielfilm/Heintje_Ein_Herz_geht_auf_Reisen_Deutschland_1969_Spielfilm.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 14
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/HeintjeMeinBesterFreundDeutschland1970SpielfilmSchlagerHeimatkomoedie/Heintje_Mein_bester_Freund_Deutschland_1970_Spielfilm_Schlager_Heimatkomoedie.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 15
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/HauptsacheFerienDeutschland1972MusikKomoedieSpielfilm/Hauptsache_Ferien_Deutschland_1972_Musik_Komoedie_Spielfilm.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 16
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/WennDerWeisseFliederWiederBluehtDeutschland1953SpielfilmMusikfilm/Wenn_der_weisse_Flieder_wieder_blueht_Deutschland_1953_Spielfilm_Musikfilm.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 17
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/WennDuBeiMirBistDeutschland1970SpielfilmRoyBlack/Wenn_du_bei_mir_bist_Deutschland_1970_Spielfilm_Roy_Black.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 18
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/UnserDoktorIstDerBesteSpielfilmDeutschland1969RoyBlack/Unser_Doktor_ist_der_Beste_Spielfilm_Deutschland_1969_Roy_Black.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 19
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ImmerAergerMitHochwuerdenSpielfilmDeutschland1972Komoedie/Immer_Aerger_mit_Hochwuerden_Spielfilm_Deutschland_1972_Komoedie.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 20
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/LausbubengeschichtenSpielfilmLausbubenfilmDeutschlandMHansiKraus/Lausbubengeschichten_Spielfilm_Lausbubenfilm_Deutschland_m_Hansi_Kraus.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 21
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/HochwuerdenDruecktEinAugeZuRoyBlackHeimatfilm1971/Hochwuerden_Drueckt_ein_Auge_Zu_Roy_Black_Heimatfilm_1971.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 22
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/MeineTanteDeineTanteDeutschland1956KimoedieSpielfilmHMoser/Meine_Tante_Deine_Tante_Deutschland_1956_Kimoedie_Spielfilm_H_Moser.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 23
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/DasKannDochUnserenWilliNichtErschuetternSpielfilmDeutschland1970/Das_kann_doch_unseren_Willi_nicht_erschuettern_Spielfilm_Deutschland_1970.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
            Case 24
                AxVLCPlugin21.playlist.clear()
                AxVLCPlugin21.playlist.add("https://archive.org/download/ImmerDieRadfahrerDeutschlandOesterreich1958SpielfilmKomoedie/Immer_die_Radfahrer_Deutschland_Oesterreich_1958_Spielfilm_Komoedie.mp4")
                Durationlbl.Text = ""
                Genrelbl.Text = ""
                Yearlbl.Text = ""
                IMDBlbl.Text = ""
                Durationlbl.Visible = True
                Genrelbl.Visible = True
                Yearlbl.Visible = True
                IMDBlbl.Visible = True
        End Select
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Settings.Show()
    End Sub
End Class
