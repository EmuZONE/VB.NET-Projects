Public Class Command
    Private WithEvents MyProcess As Process
    Private Delegate Sub AppendOutputTextDelegate(ByVal text As String)

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.AcceptButton = ExecuteButton
        MyProcess = New Process
        With MyProcess.StartInfo
            .FileName = "CMD.EXE"
            .UseShellExecute = False
            .CreateNoWindow = True
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        MyProcess.Start()

        MyProcess.BeginErrorReadLine()
        MyProcess.BeginOutputReadLine()
        AppendOutputText("Process Started at: " & MyProcess.StartTime.ToString)




    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MyProcess.StandardInput.WriteLine("EXIT") 'send an EXIT command to the Command Prompt
        MyProcess.StandardInput.Flush()
        MyProcess.Close()
    End Sub

    Private Sub MyProcess_ErrorDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.ErrorDataReceived
        AppendOutputText(vbCrLf & "Error: " & e.Data)
    End Sub

    Private Sub MyProcess_OutputDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.OutputDataReceived
        AppendOutputText(vbCrLf & e.Data)
    End Sub

    Private Sub ExecuteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExecuteButton.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
    End Sub

    Private Sub AppendOutputText(ByVal text As String)
        If OutputTextBox.InvokeRequired Then
            Dim myDelegate As New AppendOutputTextDelegate(AddressOf AppendOutputText)
            Me.Invoke(myDelegate, text)
        Else
            OutputTextBox.AppendText(text)
        End If
        OutputTextBox.ScrollToCaret()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = "ping google.de"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = "help"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = "dir"
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        Dim MyDialog As New ColorDialog()
        ' Keeps the user from selecting a custom color.
        MyDialog.AllowFullOpen = False
        ' Allows the user to get help. (The default is false.)
        MyDialog.ShowHelp = True
        ' Sets the initial color select to the current text color,
        MyDialog.Color = OutputTextBox.ForeColor

        ' Update the text box color if the user clicks OK 
        If (MyDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            OutputTextBox.ForeColor = MyDialog.Color
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        End
    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = "Time"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = "assoc"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = "attrib"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = "break"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = "bootcfg"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = "calcs"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
    End Sub

    Private Sub cmdpnlbtn1_Click(sender As Object, e As EventArgs) Handles cmdpnlbtn1.Click
        cmdpnl1.Visible = True
        Panel5.Visible = False
        Button62.Visible = True
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        cmdpnl1.Visible = False
        Panel5.Visible = True
        Button62.Visible = False
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = "ICACLS"
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Write("Exit")
        InputTextBox.Text = "Exit"
        End
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Write("cd Data cd Bin start vlc.exe http://zdf1112-lh.akamaihd.net/i/de12_v1@392882/index_3096_av-p.m3u8 --sout file/ts:../../Aufnahmen\ZDFinfo\Aufnahme.mp4")
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        MyProcess.StandardInput.WriteLine(InputTextBox.Text)
        MyProcess.StandardInput.Write("ipconfig /all")
    End Sub
End Class
