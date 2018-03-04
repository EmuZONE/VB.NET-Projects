<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ablage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ablage))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Black
        Me.ListBox1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Items.AddRange(New Object() {"https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/freddy.m3u", "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/Elster01.m3" &
                "u", "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/Elster02.m3" &
                "u", "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/BdeRn3r.wpl" &
                "", "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/13te.m3u", "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/SbmDGeS.wpl" &
                "", "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/Secrt.m3u", "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/felon.m3u", "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/hood.m3u", "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/letzte", "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/skf04.wpl", "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/skf05.wpl", "https://raw.githubusercontent.com/EmuZONE/YouTube/master/HTML/Listing/skf06.wpl"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(543, 327)
        Me.ListBox1.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.ListBox1, resources.GetString("ListBox1.ToolTip"))
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Windows_OnlineTV.My.Resources.Resources.MenuStrip
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Markieren"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Windows_OnlineTV.My.Resources.Resources.MenuStrip
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(482, 357)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Schließen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Ablage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(569, 397)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ablage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Erweiterte Zwischenablage"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button2 As Button
End Class
