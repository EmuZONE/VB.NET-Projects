Public Class Uhr
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CloseBtn1.Click
        Me.Close()
        Form1.Uhr2.Visible = False
        Form1.Uhr1.Visible = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Datelbl.Text = DateTime.Now.ToString
    End Sub

    Private Sub Uhr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub CalOn_Click(sender As Object, e As EventArgs) Handles CalOn.Click
        Me.Size = New Size(547, 269)
        Cal.Visible = True
        CalOn.Visible = False
        CalOff.Visible = True
        CloseBtn1.Visible = True
        CloseBtn2.Visible = False
    End Sub

    Private Sub CalOff_Click(sender As Object, e As EventArgs) Handles CalOff.Click
        Me.Size = New Size(366, 214)
        Cal.Visible = False
        CalOn.Visible = True
        CalOff.Visible = False
        CloseBtn2.Visible = True
        CloseBtn1.Visible = False
    End Sub

    Private Sub CloseBtn2_Click(sender As Object, e As EventArgs) Handles CloseBtn2.Click
        Me.Close()
        Form1.Uhr2.Visible = False
        Form1.Uhr1.Visible = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Alarm erfolgreich eingestellt")
    End Sub
End Class