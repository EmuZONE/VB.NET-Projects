<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SW = New System.Windows.Forms.ComboBox()
        Me.TKKG = New System.Windows.Forms.ComboBox()
        Me.Freunde = New System.Windows.Forms.ComboBox()
        Me.DDF = New System.Windows.Forms.ComboBox()
        Me.Ape = New System.Windows.Forms.ComboBox()
        Me.Benjamin = New System.Windows.Forms.ComboBox()
        Me.bibi = New System.Windows.Forms.ComboBox()
        Me.Kim = New System.Windows.Forms.ComboBox()
        Me.Alf = New System.Windows.Forms.ComboBox()
        Me.Freddy = New System.Windows.Forms.ComboBox()
        Me.Alien = New System.Windows.Forms.ComboBox()
        Me.Asterix = New System.Windows.Forms.ComboBox()
        Me.Zukunft = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BufferingBar = New System.Windows.Forms.ProgressBar()
        Me.DurationBar = New System.Windows.Forms.ProgressBar()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(522, 290)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(10, 10)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.SW)
        Me.Panel1.Controls.Add(Me.TKKG)
        Me.Panel1.Controls.Add(Me.Freunde)
        Me.Panel1.Controls.Add(Me.DDF)
        Me.Panel1.Controls.Add(Me.Ape)
        Me.Panel1.Controls.Add(Me.Benjamin)
        Me.Panel1.Controls.Add(Me.bibi)
        Me.Panel1.Controls.Add(Me.Kim)
        Me.Panel1.Controls.Add(Me.Alf)
        Me.Panel1.Controls.Add(Me.Freddy)
        Me.Panel1.Controls.Add(Me.Alien)
        Me.Panel1.Controls.Add(Me.Asterix)
        Me.Panel1.Controls.Add(Me.Zukunft)
        Me.Panel1.Location = New System.Drawing.Point(230, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 24)
        Me.Panel1.TabIndex = 1
        '
        'SW
        '
        Me.SW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SW.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SW.FormattingEnabled = True
        Me.SW.Items.AddRange(New Object() {"01. Band 1: Erben des Imperiums", "02. Band 2: Die dunkle Seite der Macht", "03. Band 3: Das letzte Kommando"})
        Me.SW.Location = New System.Drawing.Point(-2, -2)
        Me.SW.Name = "SW"
        Me.SW.Size = New System.Drawing.Size(223, 24)
        Me.SW.TabIndex = 27
        Me.SW.Visible = False
        '
        'TKKG
        '
        Me.TKKG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TKKG.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TKKG.FormattingEnabled = True
        Me.TKKG.Items.AddRange(New Object() {"001. Die Jagd nach den Millionendieben", "002. Der blinde Hellseher", "003. Das leere Grab im Moor", "004. Das Paket mit dem Totenkopf", "005. Das Phantom auf dem Feuerstuhl", "006. Angst in der 9a", "007. Rätsel um die alte Villa", "008. Auf der Spur der Vögelmörder", "009. Abenteuer im Ferienlager", "010. Alarm für Zirkus Sarani", "011. Die Falschmünzer vom Mäuseweg", "012. Nachts wenn der Feuerteufel kommt", "013. Die Bettelmönche aus Atlantis", "014. Der Schlangenmensch", "015. Ufos in Bad Finkenstein", "016. X7 antwortet nicht", "017. Die Doppelgängerin", "018. Hexenjagd in Lerchenbach", "019. Der Schatz der Drachenhöhle", "020. Das Geheimnis der chinesischen Vase", "021. Die Rache des Bombenlegers", "022. In den Klauen des Tigers", "023. Kampf der Spione", "024. Gefährliche Diamanten", "025. Die Stunde der schwarzen Maske", "026. Das Geiseldrama", "027. Banditen im Palasthotel", "028. Verrat im Höllental", "029. Hundediebe kennen keine Gnade", "030. Die Mafia kommt zur Geisterstunde", "031. Entführung in der Mondscheingasse", "032. "})
        Me.TKKG.Location = New System.Drawing.Point(-2, -2)
        Me.TKKG.Name = "TKKG"
        Me.TKKG.Size = New System.Drawing.Size(223, 24)
        Me.TKKG.TabIndex = 24
        Me.TKKG.Visible = False
        '
        'Freunde
        '
        Me.Freunde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Freunde.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Freunde.FormattingEnabled = True
        Me.Freunde.Items.AddRange(New Object() {"001. … beim Wanderzirkus", "002. … im Zeltlager", "003. … und das Burgverlies", "004. … als Retter in der Not", "005. … und der Zauberer Wuh", "006. … helfen ihren Kameraden", "007. … verfolgen die Strandräuber", "008. … und ein Zigeunermädchen", "009. … im Alten Turm", "010. … im Nebel", "011. … geraten in Schwierigkeiten", "012. … auf der Felseninsel", "013. … jagen die Entführer", "014. … machen eine Entdeckung", "015. … wittern ein Geheimnis", "016. … auf dem Leuchtturm", "017. … auf großer Fahrt", "018. … auf geheimnisvollen Spuren", "019. … auf Schmugglerjagd", "020. … erforschen die Schatzinsel", "021. … auf neuen Abenteuern", "022. … und die Museumsbande", "023. … und die Jagd nach den Smaragden", "024. … im Fernsehen", "025. … und die Flugzeugentführer", "026. … und die Perlenschmuggler", "027. … und die goldene Truhe", "028. … und die geheimnisvolle Stadt", "029. … und die Schwarze Maske", "030. … auf gefährlichen Pfaden", "031. ... In der Geisterbahn", "032. ... Das Geheimnis des Oldtimers", "033. … entdecken den Geheimgang", "034. … und die Gespensterinsel", "035. … und die gestohlene Briefmarke"})
        Me.Freunde.Location = New System.Drawing.Point(-2, -2)
        Me.Freunde.Name = "Freunde"
        Me.Freunde.Size = New System.Drawing.Size(223, 24)
        Me.Freunde.TabIndex = 25
        Me.Freunde.Visible = False
        '
        'DDF
        '
        Me.DDF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DDF.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DDF.FormattingEnabled = True
        Me.DDF.Items.AddRange(New Object() {"001. … und der Super-Papagei", "002. … und der Phantomsee ", "003. … und der Karpatenhund", "004. … und die schwarze Katze ", "005. … und der Fluch des Rubins ", "006. … und der sprechende Totenkopf ", "007. … und der unheimliche Drache ", "008. … und der grüne Geist ", "009. … und die rätselhaften Bilder", "010. … und die flüsternde Mumie ", "011. … und das Gespensterschloss", "012. … und der seltsame Wecker ", "013. … und der lachende Schatten ", "014. … und das Bergmonster ", "015. … und der rasende Löwe ", "016. … und der Zauberspiegel", "017. … und die gefährliche Erbschaft ", "018. … und die Geisterinsel", "019. … und der Teufelsberg ", "020. … und die flammende Spur ", "021. … und der Tanzende Teufel ", "022. … und der verschwundene Schatz ", "023. … und das Aztekenschwert", "024. … und die silberne Spinne", "025. … und die singende Schlange ", "026. … und die Silbermine", "027. … und der magische Kreis", "028. … und der Doppelgänger", "029. ... und die Originalmusik", "030. … und das Riff der Haie", "031. … und das Narbengesicht", "032. … und der Ameisenmensch", "033. … und die bedrohte Ranch", "034. … und der Rote Pirat ", "035. … und der Höhlenmensch ", "036. … und der Super-Wal ", "037. … und der heimliche Hehler ", "038. … und der unsichtbare Gegner ", "039. … und die Perlenvögel ", "040. … und der Automarder ", "041. … und das Volk der Winde ", "042. … und der weinende Sarg", "043. … und der höllische Werwolf", "044. … und der gestohlene Preis", "045. … und das Gold der Wikinger ", "046. … und der schrullige Millionär", "047. … und der giftige Gockel", "048. … und die gefährlichen Fässer ", "049. … und die Comic-Diebe", "050. … und der verschwundene Filmstar ", "051. … und der riskante Ritt ", "052. … und die Musikpiraten", "053. … und die Automafia", "054. ... Gefahr im Verzug", "055. ... Gekaufte Spieler ", "056. ... Angriff der Computerviren", "057. ... Tatort Zirkus ", "058. … und der verrückte Maler", "059. ... Giftiges Wasser", "060. ... Dopingmixer ", "061. ...und die Rache des Tigers", "062. ... Spuk im Hotel ", "063. ... Fußball Gangster", "064. ... Geisterstadt ", "065. ... Diamantenschmuggel", "066. ... Geisterstadt ", "067. ... Geheimnis der Särge", "068. ... Schatz im Bergsee", "069. ... Späte Rache", "070. ... Schüsse aus dem Dunkel", "071. ... Die verschwundene Seglerin", "072. ... Dreckiger Deal", "073. ... Poltergeist", "074. … und das brennende Schwert", "075. ... Die Spur des Raben", "076. ... Stimmen aus dem Nichts", "077. ... Pistenteufel", "078. ... Das leere Grab ", "079. ... Im Bann des Voodoo", "080. ... Geheimsache Ufo", "081. ... Verdeckte Fouls", "082. ... Die Karten des Bösen", "083. ... Meuterei auf hoher See", "084. ... Musik des Teufels", "085. ... Feuerturm", "086. ... Nacht in Angs", "087. ... Wolfsgesicht", "088. ... Vampir im Internet", "089. ... Tödliche Spur", "090. ... Der Feuerteufel", "091. ... Labyrinth der Götter", "092. ... Todesflug", "093. … und das Geisterschiff", "094. ... Das schwarze Monster", "095. ... Botschaft von Geisterhand", "096. … und der rote Rächer", "097. ... Insektenstachel", "098. ... Tal des Schreckens", "099. ... Rufmord", "100. ... Toteninsel: Das Rätsel der Sphinx", "100. ... Toteninsel: Das vergessene Volk", "100. ... Toteninsel: Der Fluch der Gräber", "101. ... und das Hexenhandy", "102. ... Doppelte Täuschung", "103. ... Das Erbe des Meisterdiebs", "104. ... Gift per E-Mail", "105. ... und der Nebelberg", "106. ... Der Mann ohne Kopf", "107. ... und der Schatz der Mönche", "108. ... Die sieben Tore", "109. ... Gefährliches Quiz ", "110. ... Panik im Park", "111. ... Die Höhle des Grauens ", "112. ... Schlucht der Dämonen ", "113. ... Das Auge des Drachen ", "114. ... Die Villa der Toten", "115. ... Auf tödlichem Kurs", "116. ... Codename: Cobra", "117. ... Der finstere Rivale ", "118. ... Das düstere Vermächtnis ", "119. ... Der geheime Schlüssel", "120. ... Der schwarze Skorpion", "121. ... Spur ins Nichts ", "122. ... und der Geisterzug", "123. ... Fußballfieber", "124. ... Geister-Canyon", "125. ... Feuermond: Das Rätsel der Meister", "125. ... Feuermond: Der Pfad der Täuschung", "125. ... Feuermond: Die Nacht der Schatten"})
        Me.DDF.Location = New System.Drawing.Point(-2, -2)
        Me.DDF.Name = "DDF"
        Me.DDF.Size = New System.Drawing.Size(223, 24)
        Me.DDF.TabIndex = 23
        Me.DDF.Visible = False
        '
        'Ape
        '
        Me.Ape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Ape.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ape.FormattingEnabled = True
        Me.Ape.Items.AddRange(New Object() {"Band 1: Planet der Affen"})
        Me.Ape.Location = New System.Drawing.Point(-2, -2)
        Me.Ape.Name = "Ape"
        Me.Ape.Size = New System.Drawing.Size(223, 24)
        Me.Ape.TabIndex = 22
        Me.Ape.Visible = False
        '
        'Benjamin
        '
        Me.Benjamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Benjamin.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Benjamin.FormattingEnabled = True
        Me.Benjamin.Items.AddRange(New Object() {"001. Als Apotheker (Sonderedition)", "002. Als Wetterelefant", "003. Rettet den Zoo", "004. Kampf dem Lärm", "005. In Afrika", "006. Auf hoher See", "007. Und die Schule"})
        Me.Benjamin.Location = New System.Drawing.Point(-2, -2)
        Me.Benjamin.Name = "Benjamin"
        Me.Benjamin.Size = New System.Drawing.Size(223, 24)
        Me.Benjamin.TabIndex = 21
        Me.Benjamin.Visible = False
        '
        'bibi
        '
        Me.bibi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bibi.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bibi.FormattingEnabled = True
        Me.bibi.Items.AddRange(New Object() {"001. Hexen gibt es doch", "002. Hexerei in der Schule", "003. Bibi und die Zauberlimonade", "004. Bibi und die Bankräuber", "005. Ein verhexter Urlaub", "006. Die Kuh im Schlafzimmer", "007. Bibi heilt den Bürgermeister", "008. Die Schlossgespenster", "009. Bibi verliebt sich", "010. Bibi´s neue Freundin"})
        Me.bibi.Location = New System.Drawing.Point(-2, -2)
        Me.bibi.Name = "bibi"
        Me.bibi.Size = New System.Drawing.Size(223, 24)
        Me.bibi.TabIndex = 20
        Me.bibi.Visible = False
        '
        'Kim
        '
        Me.Kim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Kim.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kim.FormattingEnabled = True
        Me.Kim.Items.AddRange(New Object() {"01. Mein Freund der Baum", "02. Die Sache mit dem Tümpel", "03. Das Geheimversteck", "05. Das Bordfest auf der Britta", "07. Ein toller Streich", "08. Das Geheimversteck"})
        Me.Kim.Location = New System.Drawing.Point(-2, -2)
        Me.Kim.Name = "Kim"
        Me.Kim.Size = New System.Drawing.Size(223, 24)
        Me.Kim.TabIndex = 19
        Me.Kim.Visible = False
        '
        'Alf
        '
        Me.Alf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Alf.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alf.FormattingEnabled = True
        Me.Alf.Items.AddRange(New Object() {"01. Hallo da bin ich", "02. Die Nacht in der die Pizza kam", "03. Kazenjammer", "04. Großer Mann was nun", "05. Parasit mit Puderquaste", "06. Ganz im Vertrauen", "07. Ein Mädchen namens Rhonda", "08. Eifersucht nach Noten"})
        Me.Alf.Location = New System.Drawing.Point(-2, -2)
        Me.Alf.Name = "Alf"
        Me.Alf.Size = New System.Drawing.Size(223, 24)
        Me.Alf.TabIndex = 18
        Me.Alf.Visible = False
        '
        'Freddy
        '
        Me.Freddy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Freddy.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Freddy.FormattingEnabled = True
        Me.Freddy.Items.AddRange(New Object() {"01. Nächte der Angst", "02. Die Traum-Falle", "03. Freddys Rache", "04. Party des Schreckens", "05. Freddy Krueger lebt", "06. Die Kralle des Bösen"})
        Me.Freddy.Location = New System.Drawing.Point(-2, -2)
        Me.Freddy.Name = "Freddy"
        Me.Freddy.Size = New System.Drawing.Size(223, 24)
        Me.Freddy.TabIndex = 3
        Me.Freddy.Visible = False
        '
        'Alien
        '
        Me.Alien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Alien.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alien.FormattingEnabled = True
        Me.Alien.Items.AddRange(New Object() {"Alien Band 1: In den Schatten", "Alien Band 2: Fluss des Todes"})
        Me.Alien.Location = New System.Drawing.Point(-2, -2)
        Me.Alien.Name = "Alien"
        Me.Alien.Size = New System.Drawing.Size(223, 24)
        Me.Alien.TabIndex = 2
        '
        'Asterix
        '
        Me.Asterix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Asterix.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Asterix.FormattingEnabled = True
        Me.Asterix.Items.AddRange(New Object() {"01. Asterix der Gallier", "02. Asterix und Kleopatra", "03. Asterix als Gladiator", "04. Der Kampf der Häuptlinge", "05. Die goldene Sichel", "06. Tour de France", "07. Asterix und die Goten", "08. Asterix bei den Briten", "09. Asterix und die Normannen", "10. Asterix als Legionär", "11. n.a.", "12. Bei den Olympischen Spielen", "13. n.a.", "14. n.a.", "15. n.a.", "16. Asterix bei den Schweizern", "17. n.a.", "18. n.a.", "19. Die Lorbeeren des Cäsar", "20. n.a.", "21. n.a.", "22. n.a.", "23. n.a.", "24. n.a.", "25. n.a.", "26. n.a.", "27. n.a.", "28. Asterix im Morgenland"})
        Me.Asterix.Location = New System.Drawing.Point(-2, -2)
        Me.Asterix.Name = "Asterix"
        Me.Asterix.Size = New System.Drawing.Size(223, 24)
        Me.Asterix.TabIndex = 2
        Me.Asterix.Visible = False
        '
        'Zukunft
        '
        Me.Zukunft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Zukunft.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zukunft.FormattingEnabled = True
        Me.Zukunft.Items.AddRange(New Object() {"Zurück in die Zukunft: Teil 1 (61 Minuten)", "Zurück in die Zukunft: Teil 2 (61 Minuten)", "Zurück in die Zukunft: Teil 3 (61 Minuten)"})
        Me.Zukunft.Location = New System.Drawing.Point(-2, -2)
        Me.Zukunft.Name = "Zukunft"
        Me.Zukunft.Size = New System.Drawing.Size(223, 24)
        Me.Zukunft.TabIndex = 4
        Me.Zukunft.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(46, 275)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(201, 27)
        Me.Panel2.TabIndex = 2
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Location = New System.Drawing.Point(173, -2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(25, 25)
        Me.Button8.TabIndex = 11
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Location = New System.Drawing.Point(142, -2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(25, 25)
        Me.Button7.TabIndex = 10
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Location = New System.Drawing.Point(118, -2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(25, 25)
        Me.Button6.TabIndex = 9
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(94, -2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(25, 25)
        Me.Button5.TabIndex = 8
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(70, -2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 25)
        Me.Button4.TabIndex = 7
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(46, -2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 25)
        Me.Button3.TabIndex = 6
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(22, -2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(-2, -2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(46, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(204, 190)
        Me.Panel3.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(3, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'BufferingBar
        '
        Me.BufferingBar.Location = New System.Drawing.Point(46, 258)
        Me.BufferingBar.MarqueeAnimationSpeed = 10
        Me.BufferingBar.Name = "BufferingBar"
        Me.BufferingBar.Size = New System.Drawing.Size(204, 11)
        Me.BufferingBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.BufferingBar.TabIndex = 9
        '
        'DurationBar
        '
        Me.DurationBar.Location = New System.Drawing.Point(12, 316)
        Me.DurationBar.Name = "DurationBar"
        Me.DurationBar.Size = New System.Drawing.Size(410, 11)
        Me.DurationBar.Step = 1
        Me.DurationBar.TabIndex = 10
        Me.DurationBar.Value = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(285, 96)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(137, 144)
        Me.Panel4.TabIndex = 12
        '
        'Timer1
        '
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Location = New System.Drawing.Point(428, 301)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(25, 26)
        Me.Button9.TabIndex = 16
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.ComboBox1)
        Me.Panel5.Location = New System.Drawing.Point(12, 24)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(212, 24)
        Me.Panel5.TabIndex = 18
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Alien", "Alf", "Arborex & der Geheimbund KIM", "Asterix & Obelix", "Die drei Fragezeichen", "Ein Fall für TKKG", "Benjamin Blümchen", "Bibi Blocksberg", "Freddy Kruger", "Fünf Freunde auf Abenteuern", "Planet der Affen", "Star Wars", "Zurück in die Zukunft"})
        Me.ComboBox1.Location = New System.Drawing.Point(-2, -4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(212, 24)
        Me.ComboBox1.TabIndex = 19
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(46, 258)
        Me.ProgressBar1.MarqueeAnimationSpeed = 10
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(204, 11)
        Me.ProgressBar1.TabIndex = 19
        Me.ProgressBar1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(276, 258)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(157, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(465, 345)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.DurationBar)
        Me.Controls.Add(Me.BufferingBar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmuZONE Audio Books Player"
        Me.TransparencyKey = System.Drawing.Color.Magenta
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Alien As ComboBox
    Friend WithEvents Asterix As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Zukunft As ComboBox
    Friend WithEvents Freddy As ComboBox
    Friend WithEvents BufferingBar As ProgressBar
    Friend WithEvents DurationBar As ProgressBar
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button9 As Button
    Friend WithEvents Alf As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Kim As ComboBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents bibi As ComboBox
    Friend WithEvents Benjamin As ComboBox
    Friend WithEvents Ape As ComboBox
    Friend WithEvents DDF As ComboBox
    Friend WithEvents TKKG As ComboBox
    Friend WithEvents Freunde As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SW As ComboBox
End Class
