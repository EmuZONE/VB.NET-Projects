<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Player
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Player))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.fullscreen = New System.Windows.Forms.Button()
        Me.AlbOffBtn = New System.Windows.Forms.Button()
        Me.AlbumOnBtn = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.ForwardBtn = New System.Windows.Forms.Button()
        Me.PlayBtn = New System.Windows.Forms.Button()
        Me.PauseBtn = New System.Windows.Forms.Button()
        Me.StopBtn = New System.Windows.Forms.Button()
        Me.RewindBtn = New System.Windows.Forms.Button()
        Me.PrevBtn = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.ListPlayBtn = New System.Windows.Forms.Button()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.VolumePnl = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.URLBtn1 = New System.Windows.Forms.Button()
        Me.URLBtn2 = New System.Windows.Forms.Button()
        Me.URLinput = New System.Windows.Forms.TextBox()
        Me.PosBtn = New System.Windows.Forms.Button()
        Me.VolBtn = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.URLPnl = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PositionPnl = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.AlbumPnl = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Offlinelbl = New System.Windows.Forms.Label()
        Me.Onlinelbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VolumePnl.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.URLPnl.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PositionPnl.SuspendLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AlbumPnl.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Panel1.Location = New System.Drawing.Point(332, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(396, 301)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.fullscreen)
        Me.Panel2.Controls.Add(Me.Button23)
        Me.Panel2.Controls.Add(Me.AlbOffBtn)
        Me.Panel2.Controls.Add(Me.AlbumOnBtn)
        Me.Panel2.Controls.Add(Me.NextBtn)
        Me.Panel2.Controls.Add(Me.ForwardBtn)
        Me.Panel2.Controls.Add(Me.PlayBtn)
        Me.Panel2.Controls.Add(Me.PauseBtn)
        Me.Panel2.Controls.Add(Me.StopBtn)
        Me.Panel2.Controls.Add(Me.RewindBtn)
        Me.Panel2.Controls.Add(Me.PrevBtn)
        Me.Panel2.Location = New System.Drawing.Point(15, 254)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(367, 35)
        Me.Panel2.TabIndex = 7
        '
        'fullscreen
        '
        Me.fullscreen.BackgroundImage = CType(resources.GetObject("fullscreen.BackgroundImage"), System.Drawing.Image)
        Me.fullscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fullscreen.Location = New System.Drawing.Point(289, 4)
        Me.fullscreen.Name = "fullscreen"
        Me.fullscreen.Size = New System.Drawing.Size(30, 30)
        Me.fullscreen.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fullscreen, "Vollbild")
        Me.fullscreen.UseVisualStyleBackColor = True
        '
        'AlbOffBtn
        '
        Me.AlbOffBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AlbOffBtn.BackgroundImage = CType(resources.GetObject("AlbOffBtn.BackgroundImage"), System.Drawing.Image)
        Me.AlbOffBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AlbOffBtn.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlbOffBtn.Location = New System.Drawing.Point(6, 9)
        Me.AlbOffBtn.Name = "AlbOffBtn"
        Me.AlbOffBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AlbOffBtn.Size = New System.Drawing.Size(26, 26)
        Me.AlbOffBtn.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.AlbOffBtn, "Musik Alben anzeigen")
        Me.AlbOffBtn.UseVisualStyleBackColor = False
        '
        'AlbumOnBtn
        '
        Me.AlbumOnBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AlbumOnBtn.BackgroundImage = CType(resources.GetObject("AlbumOnBtn.BackgroundImage"), System.Drawing.Image)
        Me.AlbumOnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AlbumOnBtn.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlbumOnBtn.Location = New System.Drawing.Point(6, 9)
        Me.AlbumOnBtn.Name = "AlbumOnBtn"
        Me.AlbumOnBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AlbumOnBtn.Size = New System.Drawing.Size(26, 26)
        Me.AlbumOnBtn.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.AlbumOnBtn, "Playlisten anzeigen")
        Me.AlbumOnBtn.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(620, 408)
        Me.Button4.Name = "Button4"
        Me.Button4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button4.Size = New System.Drawing.Size(30, 20)
        Me.Button4.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.Button4, "URL Eingabe einblenden")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'NextBtn
        '
        Me.NextBtn.BackgroundImage = CType(resources.GetObject("NextBtn.BackgroundImage"), System.Drawing.Image)
        Me.NextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NextBtn.Location = New System.Drawing.Point(254, 4)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(30, 30)
        Me.NextBtn.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.NextBtn, "Weiter")
        Me.NextBtn.UseVisualStyleBackColor = True
        '
        'ForwardBtn
        '
        Me.ForwardBtn.BackgroundImage = CType(resources.GetObject("ForwardBtn.BackgroundImage"), System.Drawing.Image)
        Me.ForwardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ForwardBtn.Location = New System.Drawing.Point(218, 5)
        Me.ForwardBtn.Name = "ForwardBtn"
        Me.ForwardBtn.Size = New System.Drawing.Size(30, 30)
        Me.ForwardBtn.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.ForwardBtn, "schneller Vorlauf")
        Me.ForwardBtn.UseVisualStyleBackColor = True
        '
        'PlayBtn
        '
        Me.PlayBtn.BackgroundImage = CType(resources.GetObject("PlayBtn.BackgroundImage"), System.Drawing.Image)
        Me.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlayBtn.Location = New System.Drawing.Point(182, 5)
        Me.PlayBtn.Name = "PlayBtn"
        Me.PlayBtn.Size = New System.Drawing.Size(30, 30)
        Me.PlayBtn.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.PlayBtn, "Wiedergabe")
        Me.PlayBtn.UseVisualStyleBackColor = True
        '
        'PauseBtn
        '
        Me.PauseBtn.BackgroundImage = CType(resources.GetObject("PauseBtn.BackgroundImage"), System.Drawing.Image)
        Me.PauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PauseBtn.Location = New System.Drawing.Point(146, 5)
        Me.PauseBtn.Name = "PauseBtn"
        Me.PauseBtn.Size = New System.Drawing.Size(30, 30)
        Me.PauseBtn.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.PauseBtn, "Pause")
        Me.PauseBtn.UseVisualStyleBackColor = True
        '
        'StopBtn
        '
        Me.StopBtn.BackgroundImage = CType(resources.GetObject("StopBtn.BackgroundImage"), System.Drawing.Image)
        Me.StopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StopBtn.Location = New System.Drawing.Point(110, 4)
        Me.StopBtn.Name = "StopBtn"
        Me.StopBtn.Size = New System.Drawing.Size(30, 30)
        Me.StopBtn.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.StopBtn, "Stop")
        Me.StopBtn.UseVisualStyleBackColor = True
        '
        'RewindBtn
        '
        Me.RewindBtn.BackgroundImage = CType(resources.GetObject("RewindBtn.BackgroundImage"), System.Drawing.Image)
        Me.RewindBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RewindBtn.Location = New System.Drawing.Point(74, 4)
        Me.RewindBtn.Name = "RewindBtn"
        Me.RewindBtn.Size = New System.Drawing.Size(30, 30)
        Me.RewindBtn.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.RewindBtn, "schneller Rücklauf")
        Me.RewindBtn.UseVisualStyleBackColor = True
        '
        'PrevBtn
        '
        Me.PrevBtn.BackgroundImage = CType(resources.GetObject("PrevBtn.BackgroundImage"), System.Drawing.Image)
        Me.PrevBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PrevBtn.Location = New System.Drawing.Point(38, 4)
        Me.PrevBtn.Name = "PrevBtn"
        Me.PrevBtn.Size = New System.Drawing.Size(30, 30)
        Me.PrevBtn.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.PrevBtn, "Zurück")
        Me.PrevBtn.UseVisualStyleBackColor = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.AllowDrop = True
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(15, 17)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(367, 269)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        Me.AxWindowsMediaPlayer1.UseWaitCursor = True
        '
        'ListPlayBtn
        '
        Me.ListPlayBtn.BackgroundImage = CType(resources.GetObject("ListPlayBtn.BackgroundImage"), System.Drawing.Image)
        Me.ListPlayBtn.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListPlayBtn.Location = New System.Drawing.Point(231, 322)
        Me.ListPlayBtn.Name = "ListPlayBtn"
        Me.ListPlayBtn.Size = New System.Drawing.Size(95, 36)
        Me.ListPlayBtn.TabIndex = 3
        Me.ListPlayBtn.Text = "Wiedergabe"
        Me.ToolTip1.SetToolTip(Me.ListPlayBtn, "Wiedergabeliste abspielen")
        Me.ListPlayBtn.UseVisualStyleBackColor = True
        '
        'DelBtn
        '
        Me.DelBtn.BackgroundImage = CType(resources.GetObject("DelBtn.BackgroundImage"), System.Drawing.Image)
        Me.DelBtn.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBtn.ForeColor = System.Drawing.Color.Black
        Me.DelBtn.Location = New System.Drawing.Point(12, 322)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(87, 36)
        Me.DelBtn.TabIndex = 4
        Me.DelBtn.Text = "Löschen"
        Me.ToolTip1.SetToolTip(Me.DelBtn, "Alle Einträge entfernen")
        Me.DelBtn.UseVisualStyleBackColor = True
        '
        'AddBtn
        '
        Me.AddBtn.BackgroundImage = CType(resources.GetObject("AddBtn.BackgroundImage"), System.Drawing.Image)
        Me.AddBtn.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(98, 322)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(88, 36)
        Me.AddBtn.TabIndex = 5
        Me.AddBtn.Text = "Hinzufügen"
        Me.ToolTip1.SetToolTip(Me.AddBtn, "Eintrag hinzufügen")
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.BackgroundImage = CType(resources.GetObject("ExitBtn.BackgroundImage"), System.Drawing.Image)
        Me.ExitBtn.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.Location = New System.Drawing.Point(653, 495)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 36)
        Me.ExitBtn.TabIndex = 6
        Me.ExitBtn.Text = "Beenden"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'VolumePnl
        '
        Me.VolumePnl.BackColor = System.Drawing.Color.Transparent
        Me.VolumePnl.BackgroundImage = CType(resources.GetObject("VolumePnl.BackgroundImage"), System.Drawing.Image)
        Me.VolumePnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VolumePnl.Controls.Add(Me.Label2)
        Me.VolumePnl.Controls.Add(Me.TrackBar1)
        Me.VolumePnl.Location = New System.Drawing.Point(347, 319)
        Me.VolumePnl.Name = "VolumePnl"
        Me.VolumePnl.Size = New System.Drawing.Size(355, 52)
        Me.VolumePnl.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lautstärke"
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TrackBar1.LargeChange = 2
        Me.TrackBar1.Location = New System.Drawing.Point(12, 3)
        Me.TrackBar1.Maximum = 20
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(327, 45)
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.Value = 10
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(505, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button1.Size = New System.Drawing.Size(42, 42)
        Me.Button1.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.Button1, "Einstellungen anzeigen")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(553, 386)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button2.Size = New System.Drawing.Size(42, 42)
        Me.Button2.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.Button2, "Netzwerk Einstellungen")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'URLBtn1
        '
        Me.URLBtn1.BackgroundImage = CType(resources.GetObject("URLBtn1.BackgroundImage"), System.Drawing.Image)
        Me.URLBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.URLBtn1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.URLBtn1.Location = New System.Drawing.Point(402, 380)
        Me.URLBtn1.Name = "URLBtn1"
        Me.URLBtn1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.URLBtn1.Size = New System.Drawing.Size(30, 20)
        Me.URLBtn1.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.URLBtn1, "URL Eingabe ausblenden")
        Me.URLBtn1.UseVisualStyleBackColor = True
        '
        'URLBtn2
        '
        Me.URLBtn2.BackgroundImage = CType(resources.GetObject("URLBtn2.BackgroundImage"), System.Drawing.Image)
        Me.URLBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.URLBtn2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.URLBtn2.Location = New System.Drawing.Point(402, 380)
        Me.URLBtn2.Name = "URLBtn2"
        Me.URLBtn2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.URLBtn2.Size = New System.Drawing.Size(30, 20)
        Me.URLBtn2.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.URLBtn2, "URL Eingabe einblenden")
        Me.URLBtn2.UseVisualStyleBackColor = True
        '
        'URLinput
        '
        Me.URLinput.BackColor = System.Drawing.Color.Black
        Me.URLinput.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.URLinput.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.URLinput.Location = New System.Drawing.Point(6, 18)
        Me.URLinput.Name = "URLinput"
        Me.URLinput.Size = New System.Drawing.Size(318, 22)
        Me.URLinput.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.URLinput, "URL Adresse der Playliste angeben")
        '
        'PosBtn
        '
        Me.PosBtn.BackgroundImage = CType(resources.GetObject("PosBtn.BackgroundImage"), System.Drawing.Image)
        Me.PosBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PosBtn.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PosBtn.Location = New System.Drawing.Point(620, 386)
        Me.PosBtn.Name = "PosBtn"
        Me.PosBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PosBtn.Size = New System.Drawing.Size(30, 20)
        Me.PosBtn.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.PosBtn, "Zur Positionsanzeige wechseln")
        Me.PosBtn.UseVisualStyleBackColor = True
        '
        'VolBtn
        '
        Me.VolBtn.BackgroundImage = CType(resources.GetObject("VolBtn.BackgroundImage"), System.Drawing.Image)
        Me.VolBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VolBtn.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VolBtn.Location = New System.Drawing.Point(620, 386)
        Me.VolBtn.Name = "VolBtn"
        Me.VolBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.VolBtn.Size = New System.Drawing.Size(30, 20)
        Me.VolBtn.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.VolBtn, "Positionsanzeige verbergen")
        Me.VolBtn.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(124, 125)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(76, 76)
        Me.Button10.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.Button10, resources.GetString("Button10.ToolTip"))
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(124, 31)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(76, 76)
        Me.Button7.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.Button7, resources.GetString("Button7.ToolTip"))
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(27, 31)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(76, 76)
        Me.Button6.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.Button6, resources.GetString("Button6.ToolTip"))
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.BackgroundImage = CType(resources.GetObject("Button21.BackgroundImage"), System.Drawing.Image)
        Me.Button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button21.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.Location = New System.Drawing.Point(402, 402)
        Me.Button21.Name = "Button21"
        Me.Button21.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button21.Size = New System.Drawing.Size(30, 20)
        Me.Button21.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.Button21, "Zwischenablage ansehen")
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.BackgroundImage = CType(resources.GetObject("Button22.BackgroundImage"), System.Drawing.Image)
        Me.Button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button22.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.Location = New System.Drawing.Point(672, 386)
        Me.Button22.Name = "Button22"
        Me.Button22.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button22.Size = New System.Drawing.Size(30, 30)
        Me.Button22.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.Button22, "URL Eingabefeld für Playlisten")
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.BackgroundImage = CType(resources.GetObject("Button20.BackgroundImage"), System.Drawing.Image)
        Me.Button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button20.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.Location = New System.Drawing.Point(457, 386)
        Me.Button20.Name = "Button20"
        Me.Button20.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button20.Size = New System.Drawing.Size(42, 42)
        Me.Button20.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.Button20, "Playlist Bibliothek anzeigen")
        Me.Button20.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Mediendatei"
        Me.OpenFileDialog1.Filter = "*.m3u|*.m3u|*.mp3|*.mp3|*.wma|*.wma|*.mp4|*.mp4|*.wpl|*.wpl"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(353, 493)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(278, 34)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.BackColor = System.Drawing.Color.Black
        Me.ListBox1.ColumnWidth = 150
        Me.ListBox1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(12, 18)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(314, 292)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 0
        '
        'URLPnl
        '
        Me.URLPnl.Controls.Add(Me.Label1)
        Me.URLPnl.Controls.Add(Me.URLinput)
        Me.URLPnl.Controls.Add(Me.Button3)
        Me.URLPnl.Location = New System.Drawing.Point(347, 425)
        Me.URLPnl.Name = "URLPnl"
        Me.URLPnl.Size = New System.Drawing.Size(376, 41)
        Me.URLPnl.TabIndex = 13
        Me.URLPnl.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "URL:"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(330, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(43, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(374, 386)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 28)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(353, 470)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(80, 25)
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'PositionPnl
        '
        Me.PositionPnl.BackColor = System.Drawing.Color.Transparent
        Me.PositionPnl.BackgroundImage = CType(resources.GetObject("PositionPnl.BackgroundImage"), System.Drawing.Image)
        Me.PositionPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PositionPnl.Controls.Add(Me.Label3)
        Me.PositionPnl.Controls.Add(Me.TrackBar2)
        Me.PositionPnl.Location = New System.Drawing.Point(347, 319)
        Me.PositionPnl.Name = "PositionPnl"
        Me.PositionPnl.Size = New System.Drawing.Size(355, 52)
        Me.PositionPnl.TabIndex = 8
        Me.PositionPnl.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Position"
        '
        'TrackBar2
        '
        Me.TrackBar2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TrackBar2.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.TrackBar2.LargeChange = 1
        Me.TrackBar2.Location = New System.Drawing.Point(12, 3)
        Me.TrackBar2.Maximum = 20
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(327, 45)
        Me.TrackBar2.TabIndex = 0
        Me.TrackBar2.TabStop = False
        '
        'AlbumPnl
        '
        Me.AlbumPnl.BackgroundImage = CType(resources.GetObject("AlbumPnl.BackgroundImage"), System.Drawing.Image)
        Me.AlbumPnl.Controls.Add(Me.Button5)
        Me.AlbumPnl.Controls.Add(Me.Button18)
        Me.AlbumPnl.Controls.Add(Me.Button19)
        Me.AlbumPnl.Controls.Add(Me.Button12)
        Me.AlbumPnl.Controls.Add(Me.Button13)
        Me.AlbumPnl.Controls.Add(Me.Button14)
        Me.AlbumPnl.Controls.Add(Me.Button15)
        Me.AlbumPnl.Controls.Add(Me.Button16)
        Me.AlbumPnl.Controls.Add(Me.Button17)
        Me.AlbumPnl.Controls.Add(Me.Button9)
        Me.AlbumPnl.Controls.Add(Me.Button10)
        Me.AlbumPnl.Controls.Add(Me.Button11)
        Me.AlbumPnl.Controls.Add(Me.Button8)
        Me.AlbumPnl.Controls.Add(Me.Button7)
        Me.AlbumPnl.Controls.Add(Me.Button6)
        Me.AlbumPnl.Location = New System.Drawing.Point(1, 3)
        Me.AlbumPnl.Name = "AlbumPnl"
        Me.AlbumPnl.Size = New System.Drawing.Size(325, 549)
        Me.AlbumPnl.TabIndex = 22
        Me.AlbumPnl.Visible = False
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(223, 417)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(76, 76)
        Me.Button5.TabIndex = 63
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.BackgroundImage = CType(resources.GetObject("Button18.BackgroundImage"), System.Drawing.Image)
        Me.Button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button18.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.Location = New System.Drawing.Point(124, 417)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(76, 76)
        Me.Button18.TabIndex = 62
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.BackgroundImage = CType(resources.GetObject("Button19.BackgroundImage"), System.Drawing.Image)
        Me.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button19.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.Location = New System.Drawing.Point(27, 417)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(76, 76)
        Me.Button19.TabIndex = 61
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(223, 317)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(76, 76)
        Me.Button12.TabIndex = 60
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.BackgroundImage = CType(resources.GetObject("Button13.BackgroundImage"), System.Drawing.Image)
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(124, 317)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(76, 76)
        Me.Button13.TabIndex = 59
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.BackgroundImage = CType(resources.GetObject("Button14.BackgroundImage"), System.Drawing.Image)
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button14.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(27, 317)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(76, 76)
        Me.Button14.TabIndex = 58
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.BackgroundImage = CType(resources.GetObject("Button15.BackgroundImage"), System.Drawing.Image)
        Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button15.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(223, 218)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(76, 76)
        Me.Button15.TabIndex = 57
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.BackgroundImage = CType(resources.GetObject("Button16.BackgroundImage"), System.Drawing.Image)
        Me.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button16.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(124, 218)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(76, 76)
        Me.Button16.TabIndex = 56
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.BackgroundImage = CType(resources.GetObject("Button17.BackgroundImage"), System.Drawing.Image)
        Me.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button17.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Location = New System.Drawing.Point(27, 218)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(76, 76)
        Me.Button17.TabIndex = 55
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(223, 125)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(76, 76)
        Me.Button9.TabIndex = 54
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(27, 125)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(76, 76)
        Me.Button11.TabIndex = 52
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(223, 31)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(76, 76)
        Me.Button8.TabIndex = 51
        Me.Button8.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(476, 524)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(144, 17)
        Me.PictureBox4.TabIndex = 26
        Me.PictureBox4.TabStop = False
        '
        'Button23
        '
        Me.Button23.BackgroundImage = CType(resources.GetObject("Button23.BackgroundImage"), System.Drawing.Image)
        Me.Button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button23.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.Location = New System.Drawing.Point(344, 5)
        Me.Button23.Name = "Button23"
        Me.Button23.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button23.Size = New System.Drawing.Size(20, 20)
        Me.Button23.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.Button23, "Programminfos")
        Me.Button23.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(18, 499)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(81, 42)
        Me.PictureBox5.TabIndex = 64
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(114, 496)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(45, 48)
        Me.PictureBox6.TabIndex = 65
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Location = New System.Drawing.Point(174, 508)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(71, 36)
        Me.PictureBox7.TabIndex = 66
        Me.PictureBox7.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.Location = New System.Drawing.Point(18, 39)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 10)
        Me.Panel3.TabIndex = 67
        Me.Panel3.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Maroon
        Me.Panel4.Location = New System.Drawing.Point(18, 39)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 10)
        Me.Panel4.TabIndex = 68
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Onlinelbl)
        Me.Panel5.Controls.Add(Me.Offlinelbl)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Location = New System.Drawing.Point(28, 386)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(120, 67)
        Me.Panel5.TabIndex = 0
        '
        'Offlinelbl
        '
        Me.Offlinelbl.AutoSize = True
        Me.Offlinelbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Offlinelbl.ForeColor = System.Drawing.Color.Black
        Me.Offlinelbl.Location = New System.Drawing.Point(36, 36)
        Me.Offlinelbl.Name = "Offlinelbl"
        Me.Offlinelbl.Size = New System.Drawing.Size(44, 17)
        Me.Offlinelbl.TabIndex = 69
        Me.Offlinelbl.Text = "Offline"
        '
        'Onlinelbl
        '
        Me.Onlinelbl.AutoSize = True
        Me.Onlinelbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Onlinelbl.ForeColor = System.Drawing.Color.Black
        Me.Onlinelbl.Location = New System.Drawing.Point(37, 36)
        Me.Onlinelbl.Name = "Onlinelbl"
        Me.Onlinelbl.Size = New System.Drawing.Size(43, 17)
        Me.Onlinelbl.TabIndex = 70
        Me.Onlinelbl.Text = "Online"
        Me.Onlinelbl.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Netzwerk Status:"
        '
        'Player
        '
        Me.AcceptButton = Me.ListPlayBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(735, 553)
        Me.Controls.Add(Me.AlbumPnl)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.PositionPnl)
        Me.Controls.Add(Me.VolBtn)
        Me.Controls.Add(Me.PosBtn)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.URLPnl)
        Me.Controls.Add(Me.URLBtn2)
        Me.Controls.Add(Me.URLBtn1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.DelBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.VolumePnl)
        Me.Controls.Add(Me.ListPlayBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Player"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Player 2018"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VolumePnl.ResumeLayout(False)
        Me.VolumePnl.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.URLPnl.ResumeLayout(False)
        Me.URLPnl.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PositionPnl.ResumeLayout(False)
        Me.PositionPnl.PerformLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AlbumPnl.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ListPlayBtn As Button
    Friend WithEvents DelBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents NextBtn As Button
    Friend WithEvents ForwardBtn As Button
    Friend WithEvents PlayBtn As Button
    Friend WithEvents PauseBtn As Button
    Friend WithEvents StopBtn As Button
    Friend WithEvents RewindBtn As Button
    Friend WithEvents PrevBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents VolumePnl As Panel
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents URLBtn1 As Button
    Friend WithEvents URLBtn2 As Button
    Friend WithEvents URLPnl As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents URLinput As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents AlbumOnBtn As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PositionPnl As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents PosBtn As Button
    Friend WithEvents VolBtn As Button
    Friend WithEvents AlbOffBtn As Button
    Friend WithEvents AlbumPnl As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents fullscreen As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button23 As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Offlinelbl As Label
    Friend WithEvents Onlinelbl As Label
    Friend WithEvents Label4 As Label
End Class
