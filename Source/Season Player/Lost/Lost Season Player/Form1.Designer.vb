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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.S03 = New System.Windows.Forms.ComboBox()
        Me.S04 = New System.Windows.Forms.ComboBox()
        Me.S05 = New System.Windows.Forms.ComboBox()
        Me.S06 = New System.Windows.Forms.ComboBox()
        Me.S01 = New System.Windows.Forms.ComboBox()
        Me.S02 = New System.Windows.Forms.ComboBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SettingsBtn = New System.Windows.Forms.Button()
        Me.HideOff = New System.Windows.Forms.Button()
        Me.HideOn = New System.Windows.Forms.Button()
        Me.S03Btn = New System.Windows.Forms.Button()
        Me.S04Btn = New System.Windows.Forms.Button()
        Me.S06Btn = New System.Windows.Forms.Button()
        Me.S01Btn = New System.Windows.Forms.Button()
        Me.S05Btn = New System.Windows.Forms.Button()
        Me.S02Btn = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.S06lbl = New System.Windows.Forms.Label()
        Me.S04lbl = New System.Windows.Forms.Label()
        Me.S05lbl = New System.Windows.Forms.Label()
        Me.S03lbl = New System.Windows.Forms.Label()
        Me.S01lbl = New System.Windows.Forms.Label()
        Me.S02lbl = New System.Windows.Forms.Label()
        Me.PlayerHider = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SuchBtn2 = New System.Windows.Forms.Button()
        Me.SuchBtn1 = New System.Windows.Forms.Button()
        Me.PlayBtn = New System.Windows.Forms.Button()
        Me.PauseBtn = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BufferingBar = New System.Windows.Forms.ProgressBar()
        Me.DurationBar = New System.Windows.Forms.ProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PlayerBtn1 = New System.Windows.Forms.Button()
        Me.PlayerBtn2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PlayerHider.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Panel1.Location = New System.Drawing.Point(258, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(278, 184)
        Me.Panel1.TabIndex = 0
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(-2, 3)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(278, 207)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Button9)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(269, 218)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(256, 37)
        Me.Panel2.TabIndex = 1
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Location = New System.Drawing.Point(221, 0)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(30, 30)
        Me.Button9.TabIndex = 10
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.Lost_Season_Player.My.Resources.Resources.FastForward
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Location = New System.Drawing.Point(175, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(30, 30)
        Me.Button7.TabIndex = 9
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Location = New System.Drawing.Point(146, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(30, 30)
        Me.Button6.TabIndex = 8
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.Lost_Season_Player.My.Resources.Resources.Play
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(117, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(30, 30)
        Me.Button5.TabIndex = 7
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Lost_Season_Player.My.Resources.Resources.Pause
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(88, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(30, 30)
        Me.Button4.TabIndex = 6
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Lost_Season_Player.My.Resources.Resources._Stop
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(59, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 30)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Lost_Season_Player.My.Resources.Resources.Back
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(30, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 30)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(1, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.S03)
        Me.Panel3.Controls.Add(Me.S04)
        Me.Panel3.Controls.Add(Me.S05)
        Me.Panel3.Controls.Add(Me.S06)
        Me.Panel3.Controls.Add(Me.S01)
        Me.Panel3.Controls.Add(Me.S02)
        Me.Panel3.Location = New System.Drawing.Point(26, 21)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(213, 27)
        Me.Panel3.TabIndex = 2
        '
        'S03
        '
        Me.S03.BackColor = System.Drawing.Color.Black
        Me.S03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S03.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S03.ForeColor = System.Drawing.Color.Beige
        Me.S03.FormattingEnabled = True
        Me.S03.Items.AddRange(New Object() {"Alles abspielen (23 Episoden)", "", "01. Die zwei Städte", "02. Die gläserne Ballerina", "03. Der Auftrag", "04. Jeder für sich", "05. Der Preis des Lebens", "06. Ja, ich will", "07. Nicht in Portland", "08. Erinnerungsfetzen", "09. Fremd in fremdem Land", "10. Tricia Tanaka ist tot", "11. Die Flamme", "12. Luftpost", "13. Der Mann aus Tallahassee", "14. Exposé", "15. Allein", "16. Eine von uns", "17. Catch 22", "18. Tag der Empfängnis", "19. Im Loch", "20. Der Mann hinter dem Vorhang", "21. Greatest Hits", "22. Hinter dem Spiegel Teil 1", "23. Hinter dem Spiegel Teil 2"})
        Me.S03.Location = New System.Drawing.Point(-2, -2)
        Me.S03.Name = "S03"
        Me.S03.Size = New System.Drawing.Size(213, 25)
        Me.S03.TabIndex = 12
        Me.S03.Visible = False
        '
        'S04
        '
        Me.S04.BackColor = System.Drawing.Color.Black
        Me.S04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S04.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S04.ForeColor = System.Drawing.Color.Beige
        Me.S04.FormattingEnabled = True
        Me.S04.Items.AddRange(New Object() {"Alles abspielen (14 Episoden)", "", "01. Der Anfang vom Ende", "02. Für tot erklärt", "03. Der Ökonom", "04. Der Deal", "05. Die Konstante", "06. Die andere Frau", "07. Ji Yeon", "08. Mein Name ist Kevin Johnson", "09. Konturen der Zukunft", "10. Die Operation", "11. Hüttenzauber", "12. Die Rückkehr Teil 1", "13. Die Rückkehr Teil 2", "14. Die Rückkehr Teil 3"})
        Me.S04.Location = New System.Drawing.Point(-2, -2)
        Me.S04.Name = "S04"
        Me.S04.Size = New System.Drawing.Size(213, 25)
        Me.S04.TabIndex = 12
        Me.S04.Visible = False
        '
        'S05
        '
        Me.S05.BackColor = System.Drawing.Color.Black
        Me.S05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S05.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S05.ForeColor = System.Drawing.Color.Beige
        Me.S05.FormattingEnabled = True
        Me.S05.Items.AddRange(New Object() {"Alles abspielen (17 Episoden)", "", "01. Weil du gegangen bist", "02. Die Lüge", "03. Die Bombe", "04. Der kleine Prinz", "05. Dieser Ort ist der Tod", "06. 316", "07. Leben und Tod des Jeremy Bentham", "08. LaFleur", "09. Namaste", "10. Deswegen bin ich hier", "11. Zurück in die Zukunft", "12. Tot ist tot", "13. Das Imperium schlägt zurück", "14. Die Variable", "15. Der Anführer", "16. Der Vorfall Teil 1", "17. Der Vorfall Teil 2"})
        Me.S05.Location = New System.Drawing.Point(-2, -2)
        Me.S05.Name = "S05"
        Me.S05.Size = New System.Drawing.Size(213, 25)
        Me.S05.TabIndex = 3
        Me.S05.Visible = False
        '
        'S06
        '
        Me.S06.BackColor = System.Drawing.Color.Black
        Me.S06.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S06.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S06.ForeColor = System.Drawing.Color.Beige
        Me.S06.FormattingEnabled = True
        Me.S06.Items.AddRange(New Object() {"Alles abspielen (17 Episoden)", "", "01. Los Angeles Teil 1", "02. Los Angeles Teil 2", "03. Taxi in die Freiheit", "04. Der Stellvertreter", "05. Der Leuchtturm", "06. Bei Sonnenuntergang", "07. Dr. Linus", "08. Kundschafter", "09. Seit Anbeginn der Zeit", "10. Die Fracht", "11. Bis ans Ende ihrer Tage", "12. Alle lieben Hugo", "13. Der letzte Rekrut", "14. Der Kandidat", "15. Übers Meer", "16. Wofür sie gestorben sind", "17. Das Ende"})
        Me.S06.Location = New System.Drawing.Point(-2, -2)
        Me.S06.Name = "S06"
        Me.S06.Size = New System.Drawing.Size(213, 25)
        Me.S06.TabIndex = 3
        Me.S06.Visible = False
        '
        'S01
        '
        Me.S01.BackColor = System.Drawing.Color.Black
        Me.S01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S01.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S01.ForeColor = System.Drawing.Color.Beige
        Me.S01.FormattingEnabled = True
        Me.S01.Items.AddRange(New Object() {"Alles abspielen (25 Episoden)", "", "01. Gestrandet Teil 1", "02. Gestrandet Teil 2", "03. Tabula Rasa", "04. Wildschweinjagd", "05. Das weiße Kaninchen", "06. Die Höhle", "07. Der Nachtfalter", "08. Der Betrüger", "09. Einzelhaft", "10. Volkszählung", "11. Fährtensucher", "12. Der silberne Koffer", "13. Gefühl und Verstand", "14. Der Eisbär", "15. Heimkehr", "16. Outlaws", "17. … In Translation", "18. Verfluchte Zahlen", "19. Deus Ex Machina", "20. Schade nicht", "21. Ein höheres Ziel", "22. Rastlos", "23. Exodus Teil 1", "24. Exodus Teil 2", "25. Exodus Teil 3"})
        Me.S01.Location = New System.Drawing.Point(-2, -2)
        Me.S01.Name = "S01"
        Me.S01.Size = New System.Drawing.Size(213, 25)
        Me.S01.TabIndex = 12
        '
        'S02
        '
        Me.S02.BackColor = System.Drawing.Color.Black
        Me.S02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S02.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S02.ForeColor = System.Drawing.Color.Beige
        Me.S02.FormattingEnabled = True
        Me.S02.Items.AddRange(New Object() {"Alles abspielen (24 Episoden)", "", "01. Glaube und Wissenschaft", "02. Treibholz", "03. Orientierung", "04. Alle hassen Hugo", "05. Gefunden", "06. Verlassen", "07. Die anderen 48 Tage", "08. Kollision", "09. Was Kate getan hat", "10. Psalm 23", "11. Jagdgesellschaft", "12. Feuer und Wasser", "13. Langer Atem", "14. Einer von ihnen", "15. Mutterschutz", "16. Die ganze Wahrheit", "17. Verriegelt", "18. Dave", "19. S.O.S.", "20. Zwei für unterwegs", "21. ? (Fragezeichen)", "22. Drei Minuten", "23. Zusammen leben – Alleine sterben Teil 1", "24. Zusammen leben – Alleine sterben Teil 2"})
        Me.S02.Location = New System.Drawing.Point(-2, -2)
        Me.S02.Name = "S02"
        Me.S02.Size = New System.Drawing.Size(213, 25)
        Me.S02.TabIndex = 12
        Me.S02.Visible = False
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Location = New System.Drawing.Point(514, 261)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(25, 25)
        Me.Button8.TabIndex = 10
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.PlayerBtn2)
        Me.Panel4.Controls.Add(Me.PlayerBtn1)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.SettingsBtn)
        Me.Panel4.Controls.Add(Me.HideOff)
        Me.Panel4.Controls.Add(Me.HideOn)
        Me.Panel4.Controls.Add(Me.S03Btn)
        Me.Panel4.Controls.Add(Me.S04Btn)
        Me.Panel4.Controls.Add(Me.S06Btn)
        Me.Panel4.Controls.Add(Me.S01Btn)
        Me.Panel4.Controls.Add(Me.S05Btn)
        Me.Panel4.Controls.Add(Me.S02Btn)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(12, 171)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(240, 53)
        Me.Panel4.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Season"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(163, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Player"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Settings"
        '
        'SettingsBtn
        '
        Me.SettingsBtn.BackgroundImage = CType(resources.GetObject("SettingsBtn.BackgroundImage"), System.Drawing.Image)
        Me.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SettingsBtn.Location = New System.Drawing.Point(120, 8)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.Size = New System.Drawing.Size(27, 17)
        Me.SettingsBtn.TabIndex = 16
        Me.SettingsBtn.UseVisualStyleBackColor = True
        '
        'HideOff
        '
        Me.HideOff.BackgroundImage = CType(resources.GetObject("HideOff.BackgroundImage"), System.Drawing.Image)
        Me.HideOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HideOff.Location = New System.Drawing.Point(168, 8)
        Me.HideOff.Name = "HideOff"
        Me.HideOff.Size = New System.Drawing.Size(27, 17)
        Me.HideOff.TabIndex = 15
        Me.HideOff.UseVisualStyleBackColor = True
        '
        'HideOn
        '
        Me.HideOn.BackgroundImage = CType(resources.GetObject("HideOn.BackgroundImage"), System.Drawing.Image)
        Me.HideOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HideOn.Location = New System.Drawing.Point(168, 8)
        Me.HideOn.Name = "HideOn"
        Me.HideOn.Size = New System.Drawing.Size(27, 17)
        Me.HideOn.TabIndex = 14
        Me.HideOn.UseVisualStyleBackColor = True
        Me.HideOn.Visible = False
        '
        'S03Btn
        '
        Me.S03Btn.BackgroundImage = CType(resources.GetObject("S03Btn.BackgroundImage"), System.Drawing.Image)
        Me.S03Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.S03Btn.Location = New System.Drawing.Point(13, 8)
        Me.S03Btn.Name = "S03Btn"
        Me.S03Btn.Size = New System.Drawing.Size(27, 17)
        Me.S03Btn.TabIndex = 13
        Me.S03Btn.UseVisualStyleBackColor = True
        Me.S03Btn.Visible = False
        '
        'S04Btn
        '
        Me.S04Btn.BackgroundImage = CType(resources.GetObject("S04Btn.BackgroundImage"), System.Drawing.Image)
        Me.S04Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.S04Btn.Location = New System.Drawing.Point(13, 7)
        Me.S04Btn.Name = "S04Btn"
        Me.S04Btn.Size = New System.Drawing.Size(27, 17)
        Me.S04Btn.TabIndex = 14
        Me.S04Btn.UseVisualStyleBackColor = True
        Me.S04Btn.Visible = False
        '
        'S06Btn
        '
        Me.S06Btn.BackgroundImage = CType(resources.GetObject("S06Btn.BackgroundImage"), System.Drawing.Image)
        Me.S06Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.S06Btn.Location = New System.Drawing.Point(13, 7)
        Me.S06Btn.Name = "S06Btn"
        Me.S06Btn.Size = New System.Drawing.Size(27, 17)
        Me.S06Btn.TabIndex = 16
        Me.S06Btn.UseVisualStyleBackColor = True
        Me.S06Btn.Visible = False
        '
        'S01Btn
        '
        Me.S01Btn.BackgroundImage = CType(resources.GetObject("S01Btn.BackgroundImage"), System.Drawing.Image)
        Me.S01Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.S01Btn.Location = New System.Drawing.Point(13, 7)
        Me.S01Btn.Name = "S01Btn"
        Me.S01Btn.Size = New System.Drawing.Size(27, 17)
        Me.S01Btn.TabIndex = 12
        Me.S01Btn.UseVisualStyleBackColor = True
        Me.S01Btn.Visible = False
        '
        'S05Btn
        '
        Me.S05Btn.BackgroundImage = CType(resources.GetObject("S05Btn.BackgroundImage"), System.Drawing.Image)
        Me.S05Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.S05Btn.Location = New System.Drawing.Point(13, 7)
        Me.S05Btn.Name = "S05Btn"
        Me.S05Btn.Size = New System.Drawing.Size(27, 17)
        Me.S05Btn.TabIndex = 15
        Me.S05Btn.UseVisualStyleBackColor = True
        Me.S05Btn.Visible = False
        '
        'S02Btn
        '
        Me.S02Btn.BackgroundImage = CType(resources.GetObject("S02Btn.BackgroundImage"), System.Drawing.Image)
        Me.S02Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.S02Btn.Location = New System.Drawing.Point(13, 7)
        Me.S02Btn.Name = "S02Btn"
        Me.S02Btn.Size = New System.Drawing.Size(27, 17)
        Me.S02Btn.TabIndex = 12
        Me.S02Btn.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.S06lbl)
        Me.Panel5.Controls.Add(Me.S04lbl)
        Me.Panel5.Controls.Add(Me.S05lbl)
        Me.Panel5.Controls.Add(Me.S03lbl)
        Me.Panel5.Controls.Add(Me.S01lbl)
        Me.Panel5.Controls.Add(Me.S02lbl)
        Me.Panel5.Location = New System.Drawing.Point(56, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(36, 27)
        Me.Panel5.TabIndex = 12
        '
        'S06lbl
        '
        Me.S06lbl.AutoSize = True
        Me.S06lbl.BackColor = System.Drawing.Color.Transparent
        Me.S06lbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S06lbl.ForeColor = System.Drawing.Color.Red
        Me.S06lbl.Location = New System.Drawing.Point(3, 4)
        Me.S06lbl.Name = "S06lbl"
        Me.S06lbl.Size = New System.Drawing.Size(22, 16)
        Me.S06lbl.TabIndex = 18
        Me.S06lbl.Text = "06"
        Me.S06lbl.Visible = False
        '
        'S04lbl
        '
        Me.S04lbl.AutoSize = True
        Me.S04lbl.BackColor = System.Drawing.Color.Transparent
        Me.S04lbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S04lbl.ForeColor = System.Drawing.Color.Red
        Me.S04lbl.Location = New System.Drawing.Point(3, 4)
        Me.S04lbl.Name = "S04lbl"
        Me.S04lbl.Size = New System.Drawing.Size(22, 16)
        Me.S04lbl.TabIndex = 17
        Me.S04lbl.Text = "04"
        Me.S04lbl.Visible = False
        '
        'S05lbl
        '
        Me.S05lbl.AutoSize = True
        Me.S05lbl.BackColor = System.Drawing.Color.Transparent
        Me.S05lbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S05lbl.ForeColor = System.Drawing.Color.Red
        Me.S05lbl.Location = New System.Drawing.Point(3, 4)
        Me.S05lbl.Name = "S05lbl"
        Me.S05lbl.Size = New System.Drawing.Size(22, 16)
        Me.S05lbl.TabIndex = 17
        Me.S05lbl.Text = "05"
        Me.S05lbl.Visible = False
        '
        'S03lbl
        '
        Me.S03lbl.AutoSize = True
        Me.S03lbl.BackColor = System.Drawing.Color.Transparent
        Me.S03lbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S03lbl.ForeColor = System.Drawing.Color.Red
        Me.S03lbl.Location = New System.Drawing.Point(3, 4)
        Me.S03lbl.Name = "S03lbl"
        Me.S03lbl.Size = New System.Drawing.Size(22, 16)
        Me.S03lbl.TabIndex = 15
        Me.S03lbl.Text = "03"
        Me.S03lbl.Visible = False
        '
        'S01lbl
        '
        Me.S01lbl.AutoSize = True
        Me.S01lbl.BackColor = System.Drawing.Color.Transparent
        Me.S01lbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S01lbl.ForeColor = System.Drawing.Color.Red
        Me.S01lbl.Location = New System.Drawing.Point(3, 4)
        Me.S01lbl.Name = "S01lbl"
        Me.S01lbl.Size = New System.Drawing.Size(22, 16)
        Me.S01lbl.TabIndex = 13
        Me.S01lbl.Text = "01"
        '
        'S02lbl
        '
        Me.S02lbl.AutoSize = True
        Me.S02lbl.BackColor = System.Drawing.Color.Transparent
        Me.S02lbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S02lbl.ForeColor = System.Drawing.Color.Red
        Me.S02lbl.Location = New System.Drawing.Point(3, 4)
        Me.S02lbl.Name = "S02lbl"
        Me.S02lbl.Size = New System.Drawing.Size(22, 16)
        Me.S02lbl.TabIndex = 14
        Me.S02lbl.Text = "02"
        Me.S02lbl.Visible = False
        '
        'PlayerHider
        '
        Me.PlayerHider.BackColor = System.Drawing.Color.Transparent
        Me.PlayerHider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlayerHider.Controls.Add(Me.PictureBox1)
        Me.PlayerHider.Location = New System.Drawing.Point(258, 6)
        Me.PlayerHider.Name = "PlayerHider"
        Me.PlayerHider.Size = New System.Drawing.Size(289, 249)
        Me.PlayerHider.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(318, 179)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'SuchBtn2
        '
        Me.SuchBtn2.BackgroundImage = CType(resources.GetObject("SuchBtn2.BackgroundImage"), System.Drawing.Image)
        Me.SuchBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SuchBtn2.Location = New System.Drawing.Point(343, 337)
        Me.SuchBtn2.Name = "SuchBtn2"
        Me.SuchBtn2.Size = New System.Drawing.Size(27, 17)
        Me.SuchBtn2.TabIndex = 16
        Me.SuchBtn2.UseVisualStyleBackColor = True
        Me.SuchBtn2.Visible = False
        '
        'SuchBtn1
        '
        Me.SuchBtn1.BackgroundImage = CType(resources.GetObject("SuchBtn1.BackgroundImage"), System.Drawing.Image)
        Me.SuchBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SuchBtn1.Location = New System.Drawing.Point(343, 337)
        Me.SuchBtn1.Name = "SuchBtn1"
        Me.SuchBtn1.Size = New System.Drawing.Size(27, 17)
        Me.SuchBtn1.TabIndex = 17
        Me.SuchBtn1.UseVisualStyleBackColor = True
        Me.SuchBtn1.Visible = False
        '
        'PlayBtn
        '
        Me.PlayBtn.BackgroundImage = CType(resources.GetObject("PlayBtn.BackgroundImage"), System.Drawing.Image)
        Me.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlayBtn.Location = New System.Drawing.Point(328, 396)
        Me.PlayBtn.Name = "PlayBtn"
        Me.PlayBtn.Size = New System.Drawing.Size(27, 17)
        Me.PlayBtn.TabIndex = 18
        Me.PlayBtn.UseVisualStyleBackColor = True
        Me.PlayBtn.Visible = False
        '
        'PauseBtn
        '
        Me.PauseBtn.BackgroundImage = CType(resources.GetObject("PauseBtn.BackgroundImage"), System.Drawing.Image)
        Me.PauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PauseBtn.Location = New System.Drawing.Point(361, 387)
        Me.PauseBtn.Name = "PauseBtn"
        Me.PauseBtn.Size = New System.Drawing.Size(27, 17)
        Me.PauseBtn.TabIndex = 19
        Me.PauseBtn.UseVisualStyleBackColor = True
        Me.PauseBtn.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Location = New System.Drawing.Point(58, 67)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(142, 67)
        Me.Panel6.TabIndex = 20
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.TextBox1)
        Me.Panel7.Location = New System.Drawing.Point(28, 13)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(84, 33)
        Me.Panel7.TabIndex = 21
        '
        'Panel8
        '
        Me.Panel8.Location = New System.Drawing.Point(-2, -2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(18, 28)
        Me.Panel8.TabIndex = 22
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Red
        Me.TextBox1.Location = New System.Drawing.Point(-41, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 13)
        Me.TextBox1.TabIndex = 21
        Me.TextBox1.Text = "00:00:00"
        '
        'Timer1
        '
        '
        'BufferingBar
        '
        Me.BufferingBar.Location = New System.Drawing.Point(258, 205)
        Me.BufferingBar.MarqueeAnimationSpeed = 10
        Me.BufferingBar.Name = "BufferingBar"
        Me.BufferingBar.Size = New System.Drawing.Size(278, 10)
        Me.BufferingBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.BufferingBar.TabIndex = 21
        '
        'DurationBar
        '
        Me.DurationBar.Location = New System.Drawing.Point(258, 205)
        Me.DurationBar.Name = "DurationBar"
        Me.DurationBar.Size = New System.Drawing.Size(278, 10)
        Me.DurationBar.TabIndex = 22
        Me.DurationBar.Visible = False
        '
        'Timer2
        '
        '
        'PlayerBtn1
        '
        Me.PlayerBtn1.BackgroundImage = CType(resources.GetObject("PlayerBtn1.BackgroundImage"), System.Drawing.Image)
        Me.PlayerBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlayerBtn1.Location = New System.Drawing.Point(201, 8)
        Me.PlayerBtn1.Name = "PlayerBtn1"
        Me.PlayerBtn1.Size = New System.Drawing.Size(27, 17)
        Me.PlayerBtn1.TabIndex = 23
        Me.PlayerBtn1.UseVisualStyleBackColor = True
        '
        'PlayerBtn2
        '
        Me.PlayerBtn2.BackgroundImage = CType(resources.GetObject("PlayerBtn2.BackgroundImage"), System.Drawing.Image)
        Me.PlayerBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlayerBtn2.Location = New System.Drawing.Point(201, 8)
        Me.PlayerBtn2.Name = "PlayerBtn2"
        Me.PlayerBtn2.Size = New System.Drawing.Size(27, 17)
        Me.PlayerBtn2.TabIndex = 24
        Me.PlayerBtn2.UseVisualStyleBackColor = True
        Me.PlayerBtn2.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(202, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 15)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "I|O"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(551, 298)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.PauseBtn)
        Me.Controls.Add(Me.PlayBtn)
        Me.Controls.Add(Me.SuchBtn1)
        Me.Controls.Add(Me.SuchBtn2)
        Me.Controls.Add(Me.PlayerHider)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DurationBar)
        Me.Controls.Add(Me.BufferingBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOST: The Complete Series"
        Me.Panel1.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.PlayerHider.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents S06 As ComboBox
    Friend WithEvents Button8 As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Panel4 As Panel
    Friend WithEvents S05 As ComboBox
    Friend WithEvents S01 As ComboBox
    Friend WithEvents S02 As ComboBox
    Friend WithEvents S03 As ComboBox
    Friend WithEvents S04 As ComboBox
    Friend WithEvents S01Btn As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents S01lbl As Label
    Friend WithEvents S02Btn As Button
    Friend WithEvents S03lbl As Label
    Friend WithEvents S02lbl As Label
    Friend WithEvents S03Btn As Button
    Friend WithEvents S04Btn As Button
    Friend WithEvents S06Btn As Button
    Friend WithEvents S05Btn As Button
    Friend WithEvents S06lbl As Label
    Friend WithEvents S04lbl As Label
    Friend WithEvents S05lbl As Label
    Friend WithEvents PlayerHider As Panel
    Friend WithEvents HideOn As Button
    Friend WithEvents HideOff As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SettingsBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SuchBtn2 As Button
    Friend WithEvents SuchBtn1 As Button
    Friend WithEvents PlayBtn As Button
    Friend WithEvents PauseBtn As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel8 As Panel
    Friend WithEvents BufferingBar As ProgressBar
    Friend WithEvents DurationBar As ProgressBar
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PlayerBtn1 As Button
    Friend WithEvents PlayerBtn2 As Button
    Friend WithEvents Label4 As Label
End Class
