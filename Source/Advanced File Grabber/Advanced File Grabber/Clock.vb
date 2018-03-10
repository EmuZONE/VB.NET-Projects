
Public Class Clock



        Dim t As System.Threading.Thread = Nothing

        Dim now As DateTime

        Delegate Sub SetTextCallback(ByVal [text] As String)



        Private Sub SetText(ByVal [text] As String)

        If Me.Clocklbl.InvokeRequired Then

            Dim d As New SetTextCallback(AddressOf SetText)

            Me.Invoke(d, New Object() {[text]})

        Else

            Me.Clocklbl.Text = text

        End If

        End Sub



        Private Sub showtime()

            While True

                System.Threading.Thread.Sleep(1000)

                now = now.AddSeconds(1)

                SetText(now.ToString("yyyy-MM-dd hh:mm:ss"))

            End While

        End Sub



        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            now = DateTime.Now

            t = New System.Threading.Thread(New System.Threading.ThreadStart(AddressOf showtime))

            t.Start()

        End Sub



        Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

            t.Abort()

        End Sub

    End Class