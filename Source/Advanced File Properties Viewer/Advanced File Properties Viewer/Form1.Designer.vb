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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ShowPropertiesButton = New System.Windows.Forms.Button()
        Me.BrowseFolderButton = New System.Windows.Forms.Button()
        Me.BrowseFileButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FileNameTextBox = New System.Windows.Forms.TextBox()
        Me.ExtendedPropertiesLV = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FilePropertiesLV = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ShowPropertiesButton
        '
        Me.ShowPropertiesButton.Enabled = False
        Me.ShowPropertiesButton.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPropertiesButton.Location = New System.Drawing.Point(680, 8)
        Me.ShowPropertiesButton.Name = "ShowPropertiesButton"
        Me.ShowPropertiesButton.Size = New System.Drawing.Size(95, 47)
        Me.ShowPropertiesButton.TabIndex = 0
        Me.ShowPropertiesButton.Text = "Eigenschaften"
        Me.ShowPropertiesButton.UseVisualStyleBackColor = True
        '
        'BrowseFolderButton
        '
        Me.BrowseFolderButton.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseFolderButton.Location = New System.Drawing.Point(582, 32)
        Me.BrowseFolderButton.Name = "BrowseFolderButton"
        Me.BrowseFolderButton.Size = New System.Drawing.Size(92, 23)
        Me.BrowseFolderButton.TabIndex = 1
        Me.BrowseFolderButton.Text = "Verzeichnis..."
        Me.BrowseFolderButton.UseVisualStyleBackColor = True
        '
        'BrowseFileButton
        '
        Me.BrowseFileButton.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseFileButton.Location = New System.Drawing.Point(582, 8)
        Me.BrowseFileButton.Name = "BrowseFileButton"
        Me.BrowseFileButton.Size = New System.Drawing.Size(92, 23)
        Me.BrowseFileButton.TabIndex = 2
        Me.BrowseFileButton.Text = "Datei..."
        Me.BrowseFileButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Datei/Verzeichnis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Erweiterte Datei Eigenschaften"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Datei / Verzeichnis Eigenschaften"
        '
        'FileNameTextBox
        '
        Me.FileNameTextBox.Location = New System.Drawing.Point(16, 22)
        Me.FileNameTextBox.Name = "FileNameTextBox"
        Me.FileNameTextBox.Size = New System.Drawing.Size(560, 20)
        Me.FileNameTextBox.TabIndex = 6
        '
        'ExtendedPropertiesLV
        '
        Me.ExtendedPropertiesLV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ExtendedPropertiesLV.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtendedPropertiesLV.FullRowSelect = True
        Me.ExtendedPropertiesLV.GridLines = True
        Me.ExtendedPropertiesLV.Location = New System.Drawing.Point(16, 280)
        Me.ExtendedPropertiesLV.Name = "ExtendedPropertiesLV"
        Me.ExtendedPropertiesLV.Size = New System.Drawing.Size(759, 264)
        Me.ExtendedPropertiesLV.TabIndex = 7
        Me.ExtendedPropertiesLV.UseCompatibleStateImageBehavior = False
        Me.ExtendedPropertiesLV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Eigenschaft"
        Me.ColumnHeader3.Width = 160
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Wert"
        Me.ColumnHeader4.Width = 595
        '
        'FilePropertiesLV
        '
        Me.FilePropertiesLV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.FilePropertiesLV.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilePropertiesLV.FullRowSelect = True
        Me.FilePropertiesLV.GridLines = True
        Me.FilePropertiesLV.Location = New System.Drawing.Point(16, 76)
        Me.FilePropertiesLV.Name = "FilePropertiesLV"
        Me.FilePropertiesLV.Size = New System.Drawing.Size(759, 172)
        Me.FilePropertiesLV.TabIndex = 8
        Me.FilePropertiesLV.UseCompatibleStateImageBehavior = False
        Me.FilePropertiesLV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Eigenschaft"
        Me.ColumnHeader1.Width = 160
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Wert"
        Me.ColumnHeader2.Width = 596
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 556)
        Me.Controls.Add(Me.FilePropertiesLV)
        Me.Controls.Add(Me.ExtendedPropertiesLV)
        Me.Controls.Add(Me.FileNameTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BrowseFileButton)
        Me.Controls.Add(Me.BrowseFolderButton)
        Me.Controls.Add(Me.ShowPropertiesButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advanced File Properties Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ShowPropertiesButton As Button
    Friend WithEvents BrowseFolderButton As Button
    Friend WithEvents BrowseFileButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FileNameTextBox As TextBox
    Friend WithEvents ExtendedPropertiesLV As ListView
    Friend WithEvents FilePropertiesLV As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
