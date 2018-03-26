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
        Me.Volume = New System.Windows.Forms.TrackBar()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.AutoStart = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Volumelbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Serverlbl = New System.Windows.Forms.Label()
        Me.locallbl = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Volume)
        Me.Panel1.Controls.Add(Me.TrackBar2)
        Me.Panel1.Location = New System.Drawing.Point(23, 154)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 124)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Volume"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Balance"
        '
        'Volume
        '
        Me.Volume.BackColor = System.Drawing.Color.Black
        Me.Volume.Location = New System.Drawing.Point(-2, 15)
        Me.Volume.Name = "Volume"
        Me.Volume.Size = New System.Drawing.Size(350, 45)
        Me.Volume.TabIndex = 1
        Me.Volume.Value = 10
        '
        'TrackBar2
        '
        Me.TrackBar2.BackColor = System.Drawing.Color.Black
        Me.TrackBar2.Location = New System.Drawing.Point(-2, 77)
        Me.TrackBar2.Maximum = 2
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(350, 45)
        Me.TrackBar2.TabIndex = 2
        Me.TrackBar2.Value = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.CheckBox2)
        Me.Panel2.Controls.Add(Me.AutoStart)
        Me.Panel2.Location = New System.Drawing.Point(23, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(138, 72)
        Me.Panel2.TabIndex = 1
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(6, 37)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(128, 19)
        Me.CheckBox2.TabIndex = 3
        Me.CheckBox2.Text = "autom. Aktualisieren"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'AutoStart
        '
        Me.AutoStart.AutoSize = True
        Me.AutoStart.BackColor = System.Drawing.Color.Transparent
        Me.AutoStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AutoStart.ForeColor = System.Drawing.Color.White
        Me.AutoStart.Location = New System.Drawing.Point(6, 12)
        Me.AutoStart.Name = "AutoStart"
        Me.AutoStart.Size = New System.Drawing.Size(111, 19)
        Me.AutoStart.TabIndex = 2
        Me.AutoStart.Text = "autom. Abspielen"
        Me.AutoStart.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Volumelbl)
        Me.Panel3.Location = New System.Drawing.Point(318, 23)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(55, 27)
        Me.Panel3.TabIndex = 2
        '
        'Volumelbl
        '
        Me.Volumelbl.AutoSize = True
        Me.Volumelbl.BackColor = System.Drawing.Color.Transparent
        Me.Volumelbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volumelbl.ForeColor = System.Drawing.Color.Red
        Me.Volumelbl.Location = New System.Drawing.Point(3, 0)
        Me.Volumelbl.Name = "Volumelbl"
        Me.Volumelbl.Size = New System.Drawing.Size(43, 24)
        Me.Volumelbl.TabIndex = 3
        Me.Volumelbl.Text = "100"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(309, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Speichern"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(182, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 30)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "...nach Updates suchen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(188, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Server Version:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(187, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Lokale Version:"
        '
        'Serverlbl
        '
        Me.Serverlbl.AutoSize = True
        Me.Serverlbl.BackColor = System.Drawing.Color.Transparent
        Me.Serverlbl.ForeColor = System.Drawing.Color.LimeGreen
        Me.Serverlbl.Location = New System.Drawing.Point(274, 101)
        Me.Serverlbl.Name = "Serverlbl"
        Me.Serverlbl.Size = New System.Drawing.Size(16, 15)
        Me.Serverlbl.TabIndex = 7
        Me.Serverlbl.Text = "..."
        '
        'locallbl
        '
        Me.locallbl.AutoSize = True
        Me.locallbl.BackColor = System.Drawing.Color.Transparent
        Me.locallbl.Location = New System.Drawing.Point(274, 119)
        Me.locallbl.Name = "locallbl"
        Me.locallbl.Size = New System.Drawing.Size(16, 15)
        Me.locallbl.TabIndex = 8
        Me.locallbl.Text = "..."
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(396, 332)
        Me.Controls.Add(Me.locallbl)
        Me.Controls.Add(Me.Serverlbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Einstellungen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Volume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Volume As TrackBar
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents AutoStart As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Volumelbl As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Serverlbl As Label
    Friend WithEvents locallbl As Label
End Class
