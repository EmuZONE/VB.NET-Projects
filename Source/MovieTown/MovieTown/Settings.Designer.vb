<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SoundSettings = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SpeakerSettings = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ScreenSettings = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ResolutionSettings = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.TrackBar3 = New System.Windows.Forms.TrackBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.SoundSettings)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.SpeakerSettings)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(258, 168)
        Me.Panel1.TabIndex = 0
        '
        'SoundSettings
        '
        Me.SoundSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SoundSettings.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoundSettings.FormattingEnabled = True
        Me.SoundSettings.Items.AddRange(New Object() {"Stereo (Standard)", "Dolby Stereo (Digital)", "Dolby Prologic", "Dolby Surround", "Digital Theater Sound", "Digital Theater Sound HD"})
        Me.SoundSettings.Location = New System.Drawing.Point(15, 88)
        Me.SoundSettings.Name = "SoundSettings"
        Me.SoundSettings.Size = New System.Drawing.Size(203, 24)
        Me.SoundSettings.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sound System"
        '
        'SpeakerSettings
        '
        Me.SpeakerSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SpeakerSettings.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeakerSettings.FormattingEnabled = True
        Me.SpeakerSettings.Items.AddRange(New Object() {"2.0", "2.1", "5.1", "7.1"})
        Me.SpeakerSettings.Location = New System.Drawing.Point(15, 27)
        Me.SpeakerSettings.Name = "SpeakerSettings"
        Me.SpeakerSettings.Size = New System.Drawing.Size(203, 24)
        Me.SpeakerSettings.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Lautsprecher"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.ScreenSettings)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.ResolutionSettings)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(289, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(361, 381)
        Me.Panel2.TabIndex = 1
        '
        'ScreenSettings
        '
        Me.ScreenSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ScreenSettings.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScreenSettings.FormattingEnabled = True
        Me.ScreenSettings.Items.AddRange(New Object() {" 4:3 Standard", " 4:3 Pan Scan", "16:9 Breitbild", "16:9 Theater", "16:10 Widescreen"})
        Me.ScreenSettings.Location = New System.Drawing.Point(20, 97)
        Me.ScreenSettings.Name = "ScreenSettings"
        Me.ScreenSettings.Size = New System.Drawing.Size(235, 24)
        Me.ScreenSettings.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Bildschirm Modus"
        '
        'ResolutionSettings
        '
        Me.ResolutionSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ResolutionSettings.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResolutionSettings.FormattingEnabled = True
        Me.ResolutionSettings.Items.AddRange(New Object() {"  800 x 600", "1024 x 768", "1280 x 800", "1280 x 1050", "1600 x 1200", "1920 x 1080 (Empfohlen)"})
        Me.ResolutionSettings.Location = New System.Drawing.Point(20, 36)
        Me.ResolutionSettings.Name = "ResolutionSettings"
        Me.ResolutionSettings.Size = New System.Drawing.Size(235, 24)
        Me.ResolutionSettings.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Auflösung"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Audio Einstellungen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(286, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Video Einstellungen"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.TrackBar3)
        Me.Panel3.Controls.Add(Me.TrackBar2)
        Me.Panel3.Controls.Add(Me.TrackBar1)
        Me.Panel3.Location = New System.Drawing.Point(20, 139)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(318, 225)
        Me.Panel3.TabIndex = 4
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.Silver
        Me.TrackBar1.Location = New System.Drawing.Point(44, 30)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(267, 45)
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.Value = 6
        '
        'TrackBar2
        '
        Me.TrackBar2.BackColor = System.Drawing.Color.Silver
        Me.TrackBar2.Location = New System.Drawing.Point(44, 96)
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(267, 45)
        Me.TrackBar2.TabIndex = 1
        Me.TrackBar2.Value = 4
        '
        'TrackBar3
        '
        Me.TrackBar3.BackColor = System.Drawing.Color.Silver
        Me.TrackBar3.Location = New System.Drawing.Point(44, 162)
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(267, 45)
        Me.TrackBar3.TabIndex = 2
        Me.TrackBar3.Value = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Helligkeit"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(43, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Kontrast"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(43, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Farbe"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(7, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 30)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(7, 87)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 30)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(7, 148)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(31, 30)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(546, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Speichern"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(60, 253)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(145, 150)
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MovieTown.My.Resources.Resources.Silver_Matt
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(658, 464)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Einstellungen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SoundSettings As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SpeakerSettings As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ScreenSettings As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ResolutionSettings As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TrackBar3 As TrackBar
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox4 As PictureBox
End Class
