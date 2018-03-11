<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Byteslbl = New System.Windows.Forms.Label()
        Me.Statuslbl = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DimGray
        Me.Button1.Location = New System.Drawing.Point(276, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Download"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Button2.Location = New System.Drawing.Point(276, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Speichern"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Byteslbl
        '
        Me.Byteslbl.AutoSize = True
        Me.Byteslbl.BackColor = System.Drawing.Color.Transparent
        Me.Byteslbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Byteslbl.Location = New System.Drawing.Point(3, 0)
        Me.Byteslbl.Name = "Byteslbl"
        Me.Byteslbl.Size = New System.Drawing.Size(147, 17)
        Me.Byteslbl.TabIndex = 2
        Me.Byteslbl.Text = "Verbleibend 0 MB / 0 MB"
        '
        'Statuslbl
        '
        Me.Statuslbl.AutoSize = True
        Me.Statuslbl.BackColor = System.Drawing.Color.Transparent
        Me.Statuslbl.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Statuslbl.Location = New System.Drawing.Point(3, 17)
        Me.Statuslbl.Name = "Statuslbl"
        Me.Statuslbl.Size = New System.Drawing.Size(88, 17)
        Me.Statuslbl.TabIndex = 3
        Me.Statuslbl.Text = "Fortschritt: 0%"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(266, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(4, 41)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(266, 20)
        Me.TextBox2.TabIndex = 5
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 48)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(362, 23)
        Me.ProgressBar1.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DimGray
        Me.Button3.Location = New System.Drawing.Point(20, 207)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 27)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Abbrechen"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DimGray
        Me.Button4.Location = New System.Drawing.Point(306, 207)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 27)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Schließen"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Location = New System.Drawing.Point(20, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 78)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Byteslbl)
        Me.Panel2.Controls.Add(Me.Statuslbl)
        Me.Panel2.Location = New System.Drawing.Point(6, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(237, 38)
        Me.Panel2.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Button7)
        Me.Panel3.Controls.Add(Me.Button8)
        Me.Panel3.Controls.Add(Me.Button6)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(299, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(69, 39)
        Me.Panel3.TabIndex = 11
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DimGray
        Me.Button5.Location = New System.Drawing.Point(3, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(29, 17)
        Me.Button5.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Button5, "Download Links")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.DimGray
        Me.Button6.Location = New System.Drawing.Point(33, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(29, 17)
        Me.Button6.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Button6, "Downloads anzeigen")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.DimGray
        Me.Button7.Location = New System.Drawing.Point(33, 17)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(29, 17)
        Me.Button7.TabIndex = 5
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.DimGray
        Me.Button8.Location = New System.Drawing.Point(3, 17)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(29, 17)
        Me.Button8.TabIndex = 4
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Controls.Add(Me.TextBox2)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Location = New System.Drawing.Point(21, 21)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(374, 80)
        Me.Panel4.TabIndex = 11
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(416, 246)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advanced File Loader"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Byteslbl As Label
    Friend WithEvents Statuslbl As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel4 As Panel
End Class
