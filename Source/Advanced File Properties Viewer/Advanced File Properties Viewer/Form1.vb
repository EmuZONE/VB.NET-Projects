
Public Class Form1
    Private Sub BrowseButton_Click(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) _
                               Handles BrowseFileButton.Click
        Dim ofd As New OpenFileDialog
        ofd.CheckFileExists = True
        If ofd.ShowDialog = DialogResult.OK Then
            ShowPropertiesButton.Enabled = True
        End If
        If Not String.IsNullOrEmpty(ofd.FileName) Then
            FileNameTextBox.Text = ofd.FileName
            ShowPropertiesButton.PerformClick()
        End If
    End Sub

    Private Sub BrowseFolderButton_Click(ByVal sender As System.Object,
                                     ByVal e As System.EventArgs) _
                                     Handles BrowseFolderButton.Click
        Dim fbd As New FolderBrowserDialog
        If fbd.ShowDialog = DialogResult.OK Then
            ShowPropertiesButton.Enabled = True
        End If
        If Not String.IsNullOrEmpty(fbd.SelectedPath) Then
            FileNameTextBox.Text = fbd.SelectedPath
            ShowPropertiesButton.PerformClick()
        End If
    End Sub

    Private Sub ShowPropertiesButton_Click(ByVal sender As System.Object,
                                       ByVal e As System.EventArgs) _
                                       Handles ShowPropertiesButton.Click
        '' populate the File Properties ListView
        FilePropertiesLV.Items.Clear()
        FillPropertiesListView()

        '' populate the Extended File Properties ListView
        ExtendedPropertiesLV.Items.Clear()
        FillExtendedPropertiesListView()
    End Sub

    Private Sub FillPropertiesListView()
        Dim propertiesList As New Dictionary(Of String, Object)
        Dim fi As New IO.FileInfo(FileNameTextBox.Text)
        Dim di As New IO.DirectoryInfo(FileNameTextBox.Text)
        Try




            If fi.Exists OrElse di.Exists Then
                propertiesList.Add("File/Folder Name", fi.Name)
                propertiesList.Add("In Folder", fi.DirectoryName)
                propertiesList.Add("Creation Time", fi.CreationTime.ToString)
                propertiesList.Add("Last Access Time", fi.LastAccessTime.ToString)
                propertiesList.Add("Last Write Time", fi.LastWriteTime.ToString)
                If fi.Exists Then
                    propertiesList.Add("File Size", (fi.Length / 1024).ToString("0.00") & " KB")
                Else

                    propertiesList.Add("Folder Contents", di.GetDirectories.Count & " Folders, " &
                                                      di.GetFiles.Count.ToString & " files")

                End If
                For Each attr In [Enum].GetValues(fi.Attributes.GetType)
                    Dim value As String = If((fi.Attributes And attr) = attr, "Yes", "No")
                    propertiesList.Add(attr.ToString, value)
                Next
                Dim lvi = From item In propertiesList
                          Select New ListViewItem(New String() {item.Key, item.Value.ToString})
                FilePropertiesLV.Items.AddRange(lvi.ToArray)
            Else

                MessageBox.Show("Invalid filename or path!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("ex.Message", MsgBoxStyle.Critical)
        End Try
        Exit Sub


    End Sub

    Private Sub FillExtendedPropertiesListView()

        Dim propertiesList As New Dictionary(Of String, Object)
        Dim fi As New IO.FileInfo(FileNameTextBox.Text)
        Dim di As New IO.DirectoryInfo(FileNameTextBox.Text)

        propertiesList.Clear()

        If fi.Exists Then

            Dim dsoDocument As New DSOFile.OleDocumentProperties

            dsoDocument.Open(fi.FullName, True,
DSOFile.dsoFileOpenOptions.dsoOptionOpenReadOnlyIfNoWriteAccess)



            On Error Resume Next    '' These properties may or maynot be implemented.
            '' We ignore them in the latter case.

            With dsoDocument.SummaryProperties
                propertiesList.Add("Application Name", .ApplicationName)
                propertiesList.Add("Author", .Author)
                propertiesList.Add("Byte Count", .ByteCount)
                propertiesList.Add("Category", .Category)
                propertiesList.Add("Character Count", .CharacterCount)
                propertiesList.Add("Character Count With Spaces", .CharacterCountWithSpaces)
                propertiesList.Add("Comments", .Comments)
                propertiesList.Add("Company", .Company)
                propertiesList.Add("Date Created", .DateCreated)
                propertiesList.Add("Date Last Printed", .DateLastPrinted)
                propertiesList.Add("Date Last Saved", .DateLastSaved)
                propertiesList.Add("Digital Signature", .DigitalSignature)
                propertiesList.Add("Document Security", .DocumentSecurity)
                propertiesList.Add("Hidden Slide Count", .HiddenSlideCount)
                propertiesList.Add("Keywords", .Keywords)
                propertiesList.Add("Last Saved By", .LastSavedBy)
                propertiesList.Add("Line Count", .LineCount)
                propertiesList.Add("Manager", .Manager)
                propertiesList.Add("Multimedia Clip Count", .MultimediaClipCount)
                propertiesList.Add("Note Count", .NoteCount)
                propertiesList.Add("Page Count", .PageCount)
                propertiesList.Add("Paragraph Count", .ParagraphCount)
                propertiesList.Add("Presentation Format", .PresentationFormat)
                propertiesList.Add("Revision Number", .RevisionNumber)
                propertiesList.Add("Shared Document", .SharedDocument)
                propertiesList.Add("Slide Count", .SlideCount)
                propertiesList.Add("Subject", .Subject)
                propertiesList.Add("Template", .Template)
                propertiesList.Add("Thumbnail", .Thumbnail)
                propertiesList.Add("Title", .Title)
                propertiesList.Add("Total Edit Time", .TotalEditTime)
                propertiesList.Add("Version", .Version)
                propertiesList.Add("Word Count", .WordCount)
            End With
            propertiesList.Add("Icon", dsoDocument.Icon)
            propertiesList.Add("Is Dirty", dsoDocument.IsDirty)
            propertiesList.Add("Is OLE File", dsoDocument.IsOleFile)
            propertiesList.Add("Is ReadOnly", dsoDocument.IsReadOnly)
            propertiesList.Add("Name", dsoDocument.Name)
            propertiesList.Add("Path", dsoDocument.Path)
            If dsoDocument.IsOleFile Then
                propertiesList.Add("OLE Document Format", dsoDocument.OleDocumentFormat)
                propertiesList.Add("OLE Document Type", dsoDocument.OleDocumentType)
                propertiesList.Add("Prog ID", dsoDocument.ProgID)
            End If
            On Error GoTo 0
            dsoDocument.Close()

            Dim lvi = From item In propertiesList
                      Select New ListViewItem(New String() {item.Key,
                                                        If(item.Value Is Nothing, "",
                                                           item.Value.ToString)})

            ExtendedPropertiesLV.Items.AddRange(lvi.ToArray)
        End If
    End Sub
End Class
