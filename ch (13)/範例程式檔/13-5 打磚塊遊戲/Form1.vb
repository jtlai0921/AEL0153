Public Class Form1
    Dim x, y As Integer
    Dim dx, dy As Integer
    Dim ballSize As Integer = 36
    Dim scoAcc, lossAcc As Integer
    Dim Ball As Image = Image.FromFile("..\..\soccerBall.gif")
    Dim pbox(40) As PictureBox
    Dim pFlag(40) As Boolean

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                If PBox1.Left < 20 Then
                    PBox1.Left = 0
                Else
                    PBox1.Left = PBox1.Left - 20
                End If
            Case Keys.Right
                If PBox1.Left > Me.Width - PBox1.Width - 20 Then
                    PBox1.Left = Me.Width - PBox1.Width
                Else
                    PBox1.Left = PBox1.Left + 20
                End If
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        Timer1.Enabled = True

        NewBallLocation()

        PBox1.Width = 55
        PBox1.Height = 25
        PBox1.Top = 400

        Dim i As Integer
        For i = 1 To 40
            pbox(i) = New PictureBox
            Dim r, g, b As Integer
            Dim N As Integer = (i Mod 8) + 1
            Select Case N
                Case 1
                    r = 255 : g = 0 : b = 0
                Case 2
                    r = 0 : g = 255 : b = 0
                Case 3
                    r = 0 : g = 0 : b = 255
                Case 4
                    r = 255 : g = 255 : b = 0
                Case 5
                    r = 0 : g = 255 : b = 255
                Case 6
                    r = 255 : g = 0 : b = 255
                Case 7
                    r = 127 : g = 0 : b = 255
                Case 8
                    r = 0 : g = 127 : b = 255
            End Select

            With pbox(i)
                .BackColor = Color.FromArgb(255, r, g, b)
                .Top = 50 + 20 * ((i - 1) \ 8)
                .Left = (i Mod 8) * 60 + 6
                .Width = 59
                .Height = 19
                .Visible = True
            End With
            Me.Controls.Add(pbox(i))
            pFlag(i) = True
        Next

        scoAcc = 0
        lossAcc = 0
        Label1.Text = "得分數：" & scoAcc
        Label2.Text = "失球數：" & lossAcc
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = e.Graphics
        g.DrawImage(Ball, x, y, ballSize, ballSize)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        x = x + 10 * dx
        y = y + 10 * dy
        If x >= Me.Width - ballSize Then dx = -1
        If x <= 1 Then dx = 1
        'If y >= Me.Height - ballSize Then dy = -1
        If y <= 1 Then dy = 1

        If y >= 400 - ballSize And y <= 400 And x > PBox1.Left - ballSize And x < PBox1.Left + PBox1.Width Then
            dy = -1
        Else
            If y >= 480 Then
                lossAcc = lossAcc + 1
                Label2.Text = "失球數：" & lossAcc
                NewBallLocation()
            End If
        End If

        Dim i As Integer
        For i = 1 To 40
            If x + ballSize > pbox(i).Left And x < pbox(i).Left + pbox(i).Width And y + ballSize > pbox(i).Top And y < pbox(i).Top + pbox(i).Height And pFlag(i) = True Then
                pbox(i).Visible = False
                scoAcc = scoAcc + 1
                Label1.Text = "得分數：" & scoAcc
                pFlag(i) = False
            End If
        Next

        Me.Refresh()
    End Sub

    Sub NewBallLocation()
        Dim generator As New Random
        x = generator.Next(10, Me.Width)
        y = 150
        dx = 1
        dy = 1
    End Sub
End Class
