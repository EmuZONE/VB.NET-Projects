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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Balance = New System.Windows.Forms.TrackBar()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Volume = New System.Windows.Forms.TrackBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Stretch = New System.Windows.Forms.CheckBox()
        Me.Autostart = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Updatelbl = New System.Windows.Forms.Label()
        Me.Versionlbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.Balance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Location = New System.Drawing.Point(12, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 190)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Balance"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Lautstärke"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Balance)
        Me.Panel5.Location = New System.Drawing.Point(13, 109)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(320, 48)
        Me.Panel5.TabIndex = 2
        '
        'Balance
        '
        Me.Balance.BackColor = System.Drawing.Color.Gray
        Me.Balance.LargeChange = 1
        Me.Balance.Location = New System.Drawing.Point(-2, -2)
        Me.Balance.Maximum = 2
        Me.Balance.Name = "Balance"
        Me.Balance.Size = New System.Drawing.Size(320, 45)
        Me.Balance.TabIndex = 3
        Me.Balance.Value = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Volume)
        Me.Panel4.Location = New System.Drawing.Point(13, 27)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(320, 50)
        Me.Panel4.TabIndex = 1
        '
        'Volume
        '
        Me.Volume.BackColor = System.Drawing.Color.Gray
        Me.Volume.Location = New System.Drawing.Point(-2, -2)
        Me.Volume.Name = "Volume"
        Me.Volume.Size = New System.Drawing.Size(320, 45)
        Me.Volume.TabIndex = 4
        Me.Volume.Value = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Stretch)
        Me.Panel2.Controls.Add(Me.Autostart)
        Me.Panel2.Location = New System.Drawing.Point(12, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(152, 65)
        Me.Panel2.TabIndex = 1
        '
        'Stretch
        '
        Me.Stretch.AutoSize = True
        Me.Stretch.BackColor = System.Drawing.Color.Transparent
        Me.Stretch.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stretch.Location = New System.Drawing.Point(13, 29)
        Me.Stretch.Name = "Stretch"
        Me.Stretch.Size = New System.Drawing.Size(92, 20)
        Me.Stretch.TabIndex = 4
        Me.Stretch.Text = "Bild strecken"
        Me.Stretch.UseVisualStyleBackColor = False
        '
        'Autostart
        '
        Me.Autostart.AutoSize = True
        Me.Autostart.BackColor = System.Drawing.Color.Transparent
        Me.Autostart.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Autostart.Location = New System.Drawing.Point(13, 3)
        Me.Autostart.Name = "Autostart"
        Me.Autostart.Size = New System.Drawing.Size(112, 20)
        Me.Autostart.TabIndex = 3
        Me.Autostart.Text = "Autom. abspielen"
        Me.Autostart.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(394, 245)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(107, 43)
        Me.Panel3.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Speichern"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(352, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(131, 51)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(202, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Aktuelle Version:"
        '
        'Updatelbl
        '
        Me.Updatelbl.AutoSize = True
        Me.Updatelbl.BackColor = System.Drawing.Color.Transparent
        Me.Updatelbl.Location = New System.Drawing.Point(292, 18)
        Me.Updatelbl.Name = "Updatelbl"
        Me.Updatelbl.Size = New System.Drawing.Size(22, 13)
        Me.Updatelbl.TabIndex = 6
        Me.Updatelbl.Text = "1.0"
        '
        'Versionlbl
        '
        Me.Versionlbl.AutoSize = True
        Me.Versionlbl.BackColor = System.Drawing.Color.Transparent
        Me.Versionlbl.Location = New System.Drawing.Point(292, 38)
        Me.Versionlbl.Name = "Versionlbl"
        Me.Versionlbl.Size = New System.Drawing.Size(22, 13)
        Me.Versionlbl.TabIndex = 7
        Me.Versionlbl.Text = "1.0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(185, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Verwendete Version:"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(205, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 26)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Aktualisieren"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(514, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Versionlbl)
        Me.Controls.Add(Me.Updatelbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Einstellungen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Balance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Volume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Balance As TrackBar
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Volume As TrackBar
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Stretch As CheckBox
    Friend WithEvents Autostart As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Updatelbl As Label
    Friend WithEvents Versionlbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
End Class
