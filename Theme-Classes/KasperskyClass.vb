'
' * Kaspersky 2014 Theme 
' * v1.0.0.0
' * by Guilherme Santos
' * guilhermesantos97@live.com
' 


Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms

Namespace Themes_CSharp
	Public Class Kaspersky2014Form
		Inherits Form

		Protected Const WM_NCLBUTTONDOWN As Integer = &Ha1
		Protected Const HT_CAPTION As Integer = &H2

		<DllImport("user32.dll")> _
		Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As IntPtr
		End Function

		Public Declare Auto Function ReleaseCapture Lib "user32.dll" () As Boolean

		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				ReleaseCapture()
				SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
			End If
		End Sub

		Private closeButton As Kaspersky2014CloseButton
		Private minimizeButton As Kaspersky2014MinimizeButton

		Public Sub New()
			Me.FormBorderStyle = FormBorderStyle.None

			closeButton = New Kaspersky2014CloseButton()
			minimizeButton = New Kaspersky2014MinimizeButton()

			closeButton.Size = New Size(40, 23)
			minimizeButton.Size = New Size(32, 23)

			closeButton.Left = (Me.Width - closeButton.Width) - 15
			minimizeButton.Left = closeButton.Left - minimizeButton.Width

			closeButton.Top = border + 1
			minimizeButton.Top = border + 1

			Me.Controls.Add(closeButton)
			Me.Controls.Add(minimizeButton)
		End Sub

		Private m_headerHeight As Integer = 80
		Public Property HeaderHeight() As Integer
			Get
				Return m_headerHeight
			End Get
			Set
				m_headerHeight = value
				Me.Invalidate()
			End Set
		End Property

		Private m_footerHeight As Integer = 50
		Public Property FooterHeight() As Integer
			Get
				Return m_footerHeight
			End Get
			Set
				m_footerHeight = value
				Me.Invalidate()
			End Set
		End Property

		Private m_headerText As String
		Public Property HeaderText() As String
			Get
				Return m_headerText
			End Get
			Set
				m_headerText = value
				Me.Invalidate()
			End Set
		End Property

		Private m_headerFont As New Font("Tahoma", 12F)
		Public Property HeaderFont() As Font
			Get
				Return m_headerFont
			End Get
			Set
				m_headerFont = value
				Me.Invalidate()
			End Set
		End Property

		Private m_showDropShadow As Boolean = True
		Public Property ShowDropShadow() As Boolean
			Get
				Return m_showDropShadow
			End Get
			Set
				m_showDropShadow = value
				Me.Invalidate()
			End Set
		End Property

		Private border As Integer = 4
		Private dropShadowHeight As Integer = 25

		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			closeButton.Left = (Me.Width - closeButton.Width) - 15
			minimizeButton.Left = closeButton.Left - minimizeButton.Width
		End Sub

		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim g As Graphics = e.Graphics
			g.Clear(Color.White)

			Dim bg As New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(138, 157, 158), Color.FromArgb(58, 63, 66), LinearGradientMode.Vertical)

			g.FillRectangle(bg, Me.ClientRectangle)

			Dim headerRectangle As New Rectangle(border, border, Me.Width - (border * 2), m_headerHeight)

			Dim hbg As New HatchBrush(HatchStyle.DashedHorizontal, Color.FromArgb(50, 171, 157), Color.FromArgb(43, 163, 147))
			g.FillRectangle(hbg, headerRectangle)

			Dim grad As New LinearGradientBrush(headerRectangle, Color.FromArgb(20, Color.White), Color.FromArgb(120, Color.Black), LinearGradientMode.Vertical)
			g.FillRectangle(grad, headerRectangle)

			Dim sz As SizeF = g.MeasureString(m_headerText, Me.Font)

			g.DrawString(m_headerText, m_headerFont, Brushes.WhiteSmoke, New PointF(30, (headerRectangle.Height - sz.Height) / 2))

			g.DrawRectangle(New Pen(Color.FromArgb(80, Color.Black)), headerRectangle)

			Dim contentRectangle As New Rectangle(border, m_headerHeight, Me.Width - (border * 2), ((Me.Height - m_headerHeight) - (border)) - m_footerHeight)

			g.FillRectangle(Brushes.WhiteSmoke, contentRectangle)

			If m_showDropShadow Then
				Dim shadowRectangle As New Rectangle(contentRectangle.X, contentRectangle.Y, contentRectangle.Width, dropShadowHeight)

				Dim sbg As New LinearGradientBrush(shadowRectangle, Color.FromArgb(120, 50, 171, 157), Color.WhiteSmoke, LinearGradientMode.Vertical)
				g.FillRectangle(sbg, shadowRectangle)
			End If

			Dim footerRectangle As New Rectangle(border, (Me.Height - border) - m_footerHeight, Me.Width - (border * 2), m_footerHeight)

			Dim fbg As New LinearGradientBrush(footerRectangle, Color.FromArgb(54, 57, 62), Color.FromArgb(44, 47, 52), LinearGradientMode.Vertical)

			g.FillRectangle(fbg, footerRectangle)

			g.DrawRectangle(Pens.Black, footerRectangle)

			g.DrawRectangle(New Pen(Color.FromArgb(180, Color.Black)), contentRectangle)
		End Sub

	End Class

	Class Kaspersky2014ProgressBar
		Inherits Button

		' x-coordinate of upper-left corner
		' y-coordinate of upper-left corner
		' x-coordinate of lower-right corner
		' y-coordinate of lower-right corner
		' height of ellipse
		<DllImport("Gdi32.dll", EntryPoint := "CreateRoundRectRgn")> _
		Private Shared Function CreateRoundRectRgn(nLeftRect As Integer, nTopRect As Integer, nRightRect As Integer, nBottomRect As Integer, nWidthEllipse As Integer, nHeightEllipse As Integer) As IntPtr
			' width of ellipse
		End Function

		Public Sub DrawRoundRect(g As Graphics, p As Pen, X As Single, Y As Single, width As Single, height As Single, _
			radius As Single)
			Dim gp As New GraphicsPath()
			gp.AddLine(X + radius, Y, X + width - (radius * 2), Y)
			gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90)
			gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2))
			gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90)
			gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height)
			gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90)
			gp.AddLine(X, Y + height - (radius * 2), X, Y + radius)
			gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90)
			gp.CloseFigure()
			g.DrawPath(p, gp)
			gp.Dispose()
		End Sub



		Private m_maximum As Single = 100F
		Public Property Maximum() As Single
			Get
				Return m_maximum
			End Get
			Set
				m_maximum = value
				Me.Invalidate()
			End Set
		End Property

		Private mValue As Single = 0F
		Public Property Value() As Single
			Get
				Return mValue
			End Get
			Set
				mValue = value
				Me.Invalidate()
			End Set
		End Property

		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width - 1, Me.Height - 1, 3, 3))
		End Sub

		Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
			Dim g As Graphics = pevent.Graphics
			g.Clear(Color.White)


			Dim progressWidth As Integer = CInt(Math.Truncate((mValue / m_maximum) * Me.Width))

			Dim progressRect As New Rectangle(0, 0, progressWidth, Me.Height)

			If mValue > 0 Then
				Dim pbg As New LinearGradientBrush(progressRect, Color.FromArgb(2, 158, 131), Color.FromArgb(4, 129, 107), LinearGradientMode.Vertical)

				g.FillRectangle(pbg, New Rectangle(0, 0, progressWidth, Me.Height))
			End If
			Dim r1 As New RectangleF(1, 1, Me.Width - 2, Me.Height - 4)
			r1.Width = CSng(r1.Width * mValue / m_maximum)
			Dim reg1 As New Region(r1)
			Dim reg2 As New Region(Me.ClientRectangle)
			reg2.Exclude(reg1)

			Dim textSize As SizeF = g.MeasureString(Me.Text, Me.Font)

			Dim y As Single = (Me.ClientRectangle.Height - textSize.Height) / 2

			g.Clip = reg1
			g.DrawString(Me.Text, Me.Font, Brushes.WhiteSmoke, 10, y)
			g.Clip = reg2
			g.DrawString(Me.Text, Me.Font, Brushes.Gray, 10, y)

			reg1.Dispose()
			reg2.Dispose()

			DrawRoundRect(g, Pens.Gray, 0, 0, Me.Width - 3, Me.Height - 3, _
				3)
		End Sub

	End Class

	Class Kaspersky2014CloseButton
		Inherits Button

		' x-coordinate of upper-left corner
		' y-coordinate of upper-left corner
		' x-coordinate of lower-right corner
		' y-coordinate of lower-right corner
		' height of ellipse
		<DllImport("Gdi32.dll", EntryPoint := "CreateRoundRectRgn")> _
		Private Shared Function CreateRoundRectRgn(nLeftRect As Integer, nTopRect As Integer, nRightRect As Integer, nBottomRect As Integer, nWidthEllipse As Integer, nHeightEllipse As Integer) As IntPtr
			' width of ellipse
		End Function

		Public Sub DrawRoundRect(g As Graphics, p As Pen, X As Single, Y As Single, width As Single, height As Single, _
			radius As Single)
			Dim gp As New GraphicsPath()
			gp.AddLine(X + radius, Y, X + width - (radius * 2), Y)
			gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90)
			gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2))
			gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90)
			gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height)
			gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90)
			gp.AddLine(X, Y + height - (radius * 2), X, Y + radius)
			gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90)
			gp.CloseFigure()
			g.DrawPath(p, gp)
			gp.Dispose()
		End Sub

		Private Enum MouseState
			None
			Over
			Down
		End Enum

		Private state As MouseState = MouseState.None

		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			state = MouseState.Over
			MyBase.OnMouseEnter(e)
		End Sub

		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			state = MouseState.None
			MyBase.OnMouseLeave(e)
		End Sub

		Protected Overrides Sub OnMouseDown(mevent As MouseEventArgs)
			state = MouseState.Down
			MyBase.OnMouseDown(mevent)
		End Sub

		Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
			state = MouseState.Over
			MyBase.OnMouseUp(mevent)
		End Sub

		Protected Overrides Sub OnClick(e As EventArgs)
			MyBase.OnClick(e)
			Environment.[Exit](0)
		End Sub

		Private font As New Font("Marlett", 11F)

		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			Me.Region = Region.FromHrgn(CreateRoundRectRgn(-5, -5, Me.Width - 1, Me.Height - 1, 12, 12))
		End Sub

		Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
			Dim g As Graphics = pevent.Graphics
			g.SmoothingMode = SmoothingMode.AntiAlias
			g.Clear(Color.White)

			g.FillRectangle(New SolidBrush(Color.FromArgb(160, 46, 37)), Me.ClientRectangle)
			g.FillRectangle(New SolidBrush(Color.FromArgb(20, Color.White)), New Rectangle(0, 0, Me.Width, Me.Height \ 2))

			Select Case state
				Case MouseState.Over
					g.FillRectangle(New SolidBrush(Color.FromArgb(40, Color.White)), Me.ClientRectangle)
					Exit Select

				Case MouseState.Down
					g.FillRectangle(New SolidBrush(Color.FromArgb(40, Color.Black)), Me.ClientRectangle)
					Exit Select
			End Select

			TextRenderer.DrawText(g, "r", font, Me.ClientRectangle, Color.WhiteSmoke, TextFormatFlags.VerticalCenter Or TextFormatFlags.HorizontalCenter)

			DrawRoundRect(g, New Pen(Color.DarkRed), -5, -5, Me.Width + 2, Me.Height + 2, _
				8)
		End Sub

	End Class

	Class Kaspersky2014MinimizeButton
		Inherits Button

		' x-coordinate of upper-left corner
		' y-coordinate of upper-left corner
		' x-coordinate of lower-right corner
		' y-coordinate of lower-right corner
		' height of ellipse
		<DllImport("Gdi32.dll", EntryPoint := "CreateRoundRectRgn")> _
		Private Shared Function CreateRoundRectRgn(nLeftRect As Integer, nTopRect As Integer, nRightRect As Integer, nBottomRect As Integer, nWidthEllipse As Integer, nHeightEllipse As Integer) As IntPtr
			' width of ellipse
		End Function

		Public Sub DrawRoundRect(g As Graphics, p As Pen, X As Single, Y As Single, width As Single, height As Single, _
			radius As Single)
			Dim gp As New GraphicsPath()
			gp.AddLine(X + radius, Y, X + width - (radius * 2), Y)
			gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90)
			gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2))
			gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90)
			gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height)
			gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90)
			gp.AddLine(X, Y + height - (radius * 2), X, Y + radius)
			gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90)
			gp.CloseFigure()
			g.DrawPath(p, gp)
			gp.Dispose()
		End Sub

		Private Enum MouseState
			None
			Over
			Down
		End Enum

		Private state As MouseState = MouseState.None

		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			state = MouseState.Over
			MyBase.OnMouseEnter(e)
		End Sub

		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			state = MouseState.None
			MyBase.OnMouseLeave(e)
		End Sub

		Protected Overrides Sub OnMouseDown(mevent As MouseEventArgs)
			state = MouseState.Down
			MyBase.OnMouseDown(mevent)
		End Sub

		Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
			state = MouseState.Over
			MyBase.OnMouseUp(mevent)
		End Sub

		Protected Overrides Sub OnMouseClick(e As MouseEventArgs)
			MyBase.OnMouseClick(e)
			DirectCast(Me.Parent, Form).WindowState = FormWindowState.Minimized
		End Sub

		Private font As New Font("Marlett", 11F)

		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			Me.Region = Region.FromHrgn(CreateRoundRectRgn(1, -5, Me.Width + 5, Me.Height - 1, 12, 12))
		End Sub

		Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
			Dim g As Graphics = pevent.Graphics
			g.SmoothingMode = SmoothingMode.AntiAlias
			g.Clear(Color.White)

			g.FillRectangle(New SolidBrush(Color.FromArgb(56, 143, 133)), Me.ClientRectangle)
			g.FillRectangle(New SolidBrush(Color.FromArgb(20, Color.White)), New Rectangle(0, 0, Me.Width, Me.Height \ 2))

			Select Case state
				Case MouseState.Over
					g.FillRectangle(New SolidBrush(Color.FromArgb(40, Color.White)), Me.ClientRectangle)
					Exit Select

				Case MouseState.Down
					g.FillRectangle(New SolidBrush(Color.FromArgb(40, Color.Black)), Me.ClientRectangle)
					Exit Select
			End Select

			TextRenderer.DrawText(g, "0", font, Me.ClientRectangle, Color.WhiteSmoke, TextFormatFlags.VerticalCenter Or TextFormatFlags.HorizontalCenter)

			DrawRoundRect(g, New Pen(Color.Teal), 1, -5, Me.Width + 5, Me.Height + 2, _
				8)
		End Sub

	End Class

	Class Kaspersky2014GreenButton
		Inherits Button

		Private Enum MouseState
			None
			Over
			Down
		End Enum

		Private state As MouseState = MouseState.None

		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			state = MouseState.Over
			MyBase.OnMouseEnter(e)
		End Sub

		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			state = MouseState.None
			MyBase.OnMouseLeave(e)
		End Sub

		Protected Overrides Sub OnMouseDown(mevent As MouseEventArgs)
			state = MouseState.Down
			MyBase.OnMouseDown(mevent)
		End Sub

		Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
			state = MouseState.Over
			MyBase.OnMouseUp(mevent)
		End Sub

		Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
			Dim g As Graphics = pevent.Graphics
			g.Clear(Color.White)

			Dim bg As New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(0, 161, 137), Color.FromArgb(0, 130, 110), LinearGradientMode.Vertical)

			g.FillRectangle(bg, Me.ClientRectangle)

			Select Case state
				Case MouseState.Over
					g.FillRectangle(New SolidBrush(Color.FromArgb(40, Color.White)), Me.ClientRectangle)
					Exit Select

				Case MouseState.Down
					g.FillRectangle(New SolidBrush(Color.FromArgb(40, Color.Black)), Me.ClientRectangle)
					Exit Select
			End Select

			g.DrawLine(New Pen(Color.FromArgb(0, 191, 167)), 1, 1, Me.Width, 1)

			g.DrawRectangle(New Pen(Color.FromArgb(0, 141, 117)), New Rectangle(0, 0, Me.Width - 1, Me.Height - 1))

			TextRenderer.DrawText(g, Me.Text, Me.Font, Me.ClientRectangle, Me.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
		End Sub

	End Class

	Class Kaspersky2014CheckBox
		Inherits Button

		Public Sub DrawRoundRect(g As Graphics, p As Pen, X As Single, Y As Single, width As Single, height As Single, _
			radius As Single)
			Dim gp As New GraphicsPath()
			gp.AddLine(X + radius, Y, X + width - (radius * 2), Y)
			gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90)
			gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2))
			gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90)
			gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height)
			gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90)
			gp.AddLine(X, Y + height - (radius * 2), X, Y + radius)
			gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90)
			gp.CloseFigure()
			g.DrawPath(p, gp)
			gp.Dispose()
		End Sub

		Private mChecked As Boolean = False
		Public Property Checked() As Boolean
			Get
				Return mChecked
			End Get
			Set
				mChecked = value
				Me.Invalidate()
			End Set
		End Property

		Protected Overrides Sub OnClick(e As EventArgs)
			Me.Checked = Not Me.Checked
			MyBase.OnClick(e)
		End Sub

		Private font As New Font("Marlett", 15F)

		Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
			Dim g As Graphics = pevent.Graphics
			g.Clear(Me.BackColor)

			DrawRoundRect(g, New Pen(Color.FromArgb(172, 182, 181)), 0, 0, 17, 17, _
				3)

			Select Case mChecked
				Case True
					g.DrawString("b", font, Brushes.DarkSlateGray, New PointF(-2, -1))
					Exit Select
			End Select

			g.DrawString(Me.Text, Me.Font, Brushes.Black, New PointF(20, 2))
		End Sub

	End Class

	Class Kaspersky2014WhiteButton
		Inherits Button

		Public Sub DrawRoundRect(g As Graphics, p As Pen, X As Single, Y As Single, width As Single, height As Single, _
			radius As Single)
			Dim gp As New GraphicsPath()
			gp.AddLine(X + radius, Y, X + width - (radius * 2), Y)
			gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90)
			gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2))
			gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90)
			gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height)
			gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90)
			gp.AddLine(X, Y + height - (radius * 2), X, Y + radius)
			gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90)
			gp.CloseFigure()
			g.DrawPath(p, gp)
			gp.Dispose()
		End Sub

		Private Enum MouseState
			None
			Over
			Down
		End Enum

		Private state As MouseState = MouseState.None

		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			state = MouseState.Over
			MyBase.OnMouseEnter(e)
		End Sub

		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			state = MouseState.None
			MyBase.OnMouseLeave(e)
		End Sub

		Protected Overrides Sub OnMouseDown(mevent As MouseEventArgs)
			state = MouseState.Down
			MyBase.OnMouseDown(mevent)
		End Sub

		Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
			state = MouseState.Over
			MyBase.OnMouseUp(mevent)
		End Sub

		Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
			Dim g As Graphics = pevent.Graphics
			g.Clear(Color.White)

			Dim bg As New LinearGradientBrush(Me.ClientRectangle, Color.White, Color.FromArgb(220, 220, 220), LinearGradientMode.Vertical)
			g.FillRectangle(bg, Me.ClientRectangle)

			Select Case state
				Case MouseState.Over
					g.FillRectangle(New SolidBrush(Color.FromArgb(10, Color.Black)), Me.ClientRectangle)
					Exit Select

				Case MouseState.Down
					g.FillRectangle(New SolidBrush(Color.FromArgb(40, Color.Black)), Me.ClientRectangle)
					Exit Select
			End Select

			DrawRoundRect(g, Pens.Gray, 0, 0, Me.Width - 1, Me.Height - 1, _
				3)

			TextRenderer.DrawText(g, Me.Text, Me.Font, Me.ClientRectangle, Me.ForeColor, TextFormatFlags.VerticalCenter Or TextFormatFlags.HorizontalCenter)
		End Sub

	End Class
End Namespace
