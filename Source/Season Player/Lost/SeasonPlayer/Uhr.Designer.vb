<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Uhr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Uhr))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Datelbl = New System.Windows.Forms.Label()
        Me.CloseBtn1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CalOn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CalOff = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cal = New System.Windows.Forms.MonthCalendar()
        Me.CloseBtn2 = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown()
        Me.DomainUpDown2 = New System.Windows.Forms.DomainUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Datelbl)
        Me.Panel1.Location = New System.Drawing.Point(24, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 84)
        Me.Panel1.TabIndex = 0
        '
        'Datelbl
        '
        Me.Datelbl.AutoSize = True
        Me.Datelbl.BackColor = System.Drawing.Color.Transparent
        Me.Datelbl.Font = New System.Drawing.Font("Terminator Two", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datelbl.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Datelbl.Location = New System.Drawing.Point(13, 25)
        Me.Datelbl.Name = "Datelbl"
        Me.Datelbl.Size = New System.Drawing.Size(120, 27)
        Me.Datelbl.TabIndex = 1
        Me.Datelbl.Text = "Label1"
        Me.ToolTip1.SetToolTip(Me.Datelbl, "Aktuelle Uhrzeit")
        '
        'CloseBtn1
        '
        Me.CloseBtn1.BackgroundImage = CType(resources.GetObject("CloseBtn1.BackgroundImage"), System.Drawing.Image)
        Me.CloseBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CloseBtn1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn1.Location = New System.Drawing.Point(444, 196)
        Me.CloseBtn1.Name = "CloseBtn1"
        Me.CloseBtn1.Size = New System.Drawing.Size(75, 23)
        Me.CloseBtn1.TabIndex = 1
        Me.CloseBtn1.Text = "Schließen"
        Me.CloseBtn1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 131)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 33)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'CalOn
        '
        Me.CalOn.BackgroundImage = CType(resources.GetObject("CalOn.BackgroundImage"), System.Drawing.Image)
        Me.CalOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CalOn.Location = New System.Drawing.Point(54, 131)
        Me.CalOn.Name = "CalOn"
        Me.CalOn.Size = New System.Drawing.Size(26, 18)
        Me.CalOn.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CalOn, "Kalender anzeigen")
        Me.CalOn.UseVisualStyleBackColor = True
        '
        'CalOff
        '
        Me.CalOff.BackgroundImage = CType(resources.GetObject("CalOff.BackgroundImage"), System.Drawing.Image)
        Me.CalOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CalOff.Location = New System.Drawing.Point(54, 131)
        Me.CalOff.Name = "CalOff"
        Me.CalOff.Size = New System.Drawing.Size(26, 18)
        Me.CalOff.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.CalOff, "Kalender ausblenden")
        Me.CalOff.UseVisualStyleBackColor = True
        Me.CalOff.Visible = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(105, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 18)
        Me.Button1.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.Button1, "Kalender ausblenden")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cal
        '
        Me.Cal.Location = New System.Drawing.Point(341, 18)
        Me.Cal.Name = "Cal"
        Me.Cal.TabIndex = 5
        '
        'CloseBtn2
        '
        Me.CloseBtn2.BackgroundImage = CType(resources.GetObject("CloseBtn2.BackgroundImage"), System.Drawing.Image)
        Me.CloseBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CloseBtn2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn2.Location = New System.Drawing.Point(260, 141)
        Me.CloseBtn2.Name = "CloseBtn2"
        Me.CloseBtn2.Size = New System.Drawing.Size(75, 23)
        Me.CloseBtn2.TabIndex = 6
        Me.CloseBtn2.Text = "Schließen"
        Me.CloseBtn2.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.BackColor = System.Drawing.Color.Black
        Me.DomainUpDown1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainUpDown1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.DomainUpDown1.Items.Add("01")
        Me.DomainUpDown1.Items.Add("02")
        Me.DomainUpDown1.Items.Add("03")
        Me.DomainUpDown1.Items.Add("04")
        Me.DomainUpDown1.Items.Add("05")
        Me.DomainUpDown1.Items.Add("06")
        Me.DomainUpDown1.Items.Add("07")
        Me.DomainUpDown1.Items.Add("08")
        Me.DomainUpDown1.Items.Add("09")
        Me.DomainUpDown1.Items.Add("10")
        Me.DomainUpDown1.Items.Add("11")
        Me.DomainUpDown1.Items.Add("12")
        Me.DomainUpDown1.Items.Add("13")
        Me.DomainUpDown1.Items.Add("14")
        Me.DomainUpDown1.Items.Add("15")
        Me.DomainUpDown1.Items.Add("16")
        Me.DomainUpDown1.Items.Add("17")
        Me.DomainUpDown1.Items.Add("18")
        Me.DomainUpDown1.Items.Add("19")
        Me.DomainUpDown1.Items.Add("20")
        Me.DomainUpDown1.Items.Add("21")
        Me.DomainUpDown1.Items.Add("22")
        Me.DomainUpDown1.Items.Add("23")
        Me.DomainUpDown1.Items.Add("00")
        Me.DomainUpDown1.Location = New System.Drawing.Point(6, 28)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(43, 21)
        Me.DomainUpDown1.TabIndex = 7
        Me.DomainUpDown1.Text = "HH"
        '
        'DomainUpDown2
        '
        Me.DomainUpDown2.BackColor = System.Drawing.Color.Black
        Me.DomainUpDown2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainUpDown2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.DomainUpDown2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DomainUpDown2.Items.Add("01")
        Me.DomainUpDown2.Items.Add("02")
        Me.DomainUpDown2.Items.Add("03")
        Me.DomainUpDown2.Items.Add("04")
        Me.DomainUpDown2.Items.Add("05")
        Me.DomainUpDown2.Items.Add("06")
        Me.DomainUpDown2.Items.Add("07")
        Me.DomainUpDown2.Items.Add("08")
        Me.DomainUpDown2.Items.Add("09")
        Me.DomainUpDown2.Items.Add("10")
        Me.DomainUpDown2.Items.Add("11")
        Me.DomainUpDown2.Items.Add("12")
        Me.DomainUpDown2.Items.Add("13")
        Me.DomainUpDown2.Items.Add("14")
        Me.DomainUpDown2.Items.Add("15")
        Me.DomainUpDown2.Items.Add("16")
        Me.DomainUpDown2.Items.Add("17")
        Me.DomainUpDown2.Items.Add("18")
        Me.DomainUpDown2.Items.Add("19")
        Me.DomainUpDown2.Items.Add("20")
        Me.DomainUpDown2.Items.Add("21")
        Me.DomainUpDown2.Items.Add("22")
        Me.DomainUpDown2.Items.Add("23")
        Me.DomainUpDown2.Items.Add("24")
        Me.DomainUpDown2.Items.Add("25")
        Me.DomainUpDown2.Items.Add("26")
        Me.DomainUpDown2.Items.Add("27")
        Me.DomainUpDown2.Items.Add("28")
        Me.DomainUpDown2.Items.Add("29")
        Me.DomainUpDown2.Items.Add("30")
        Me.DomainUpDown2.Items.Add("31")
        Me.DomainUpDown2.Items.Add("32")
        Me.DomainUpDown2.Items.Add("33")
        Me.DomainUpDown2.Items.Add("34")
        Me.DomainUpDown2.Items.Add("35")
        Me.DomainUpDown2.Items.Add("36")
        Me.DomainUpDown2.Items.Add("37")
        Me.DomainUpDown2.Items.Add("38")
        Me.DomainUpDown2.Items.Add("39")
        Me.DomainUpDown2.Items.Add("40")
        Me.DomainUpDown2.Items.Add("41")
        Me.DomainUpDown2.Items.Add("42")
        Me.DomainUpDown2.Items.Add("43")
        Me.DomainUpDown2.Items.Add("44")
        Me.DomainUpDown2.Items.Add("45")
        Me.DomainUpDown2.Items.Add("46")
        Me.DomainUpDown2.Items.Add("47")
        Me.DomainUpDown2.Items.Add("48")
        Me.DomainUpDown2.Items.Add("49")
        Me.DomainUpDown2.Items.Add("50")
        Me.DomainUpDown2.Items.Add("51")
        Me.DomainUpDown2.Items.Add("52")
        Me.DomainUpDown2.Items.Add("53")
        Me.DomainUpDown2.Items.Add("54")
        Me.DomainUpDown2.Items.Add("55")
        Me.DomainUpDown2.Items.Add("56")
        Me.DomainUpDown2.Items.Add("57")
        Me.DomainUpDown2.Items.Add("58")
        Me.DomainUpDown2.Items.Add("59")
        Me.DomainUpDown2.Items.Add("00")
        Me.DomainUpDown2.Location = New System.Drawing.Point(55, 28)
        Me.DomainUpDown2.Name = "DomainUpDown2"
        Me.DomainUpDown2.Size = New System.Drawing.Size(44, 21)
        Me.DomainUpDown2.TabIndex = 8
        Me.DomainUpDown2.Text = "MM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Alarm:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DomainUpDown1)
        Me.GroupBox1.Controls.Add(Me.DomainUpDown2)
        Me.GroupBox1.Location = New System.Drawing.Point(99, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(135, 62)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'Uhr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(531, 231)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CloseBtn2)
        Me.Controls.Add(Me.Cal)
        Me.Controls.Add(Me.CalOff)
        Me.Controls.Add(Me.CalOn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CloseBtn1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Uhr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aktuelle Uhrzeit"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Datelbl As Label
    Friend WithEvents CloseBtn1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CalOn As Button
    Friend WithEvents CalOff As Button
    Friend WithEvents Cal As MonthCalendar
    Friend WithEvents CloseBtn2 As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents DomainUpDown1 As DomainUpDown
    Friend WithEvents DomainUpDown2 As DomainUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
