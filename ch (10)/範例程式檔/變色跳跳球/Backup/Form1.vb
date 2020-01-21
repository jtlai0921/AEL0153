Public Class Form1
    Dim x1, y1, dx, dy As Integer
    Dim nA, nR, nG, nB, nW As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 50
        Randomize()
        x1 = Int(Rnd() * Me.ClientSize.Width)
        y1 = Int(Rnd() * Me.ClientSize.Height)
        dx = 1
        dy = 1
        Me.BackColor = Color.Black
        changeBallStyle()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Refresh()
        x1 = x1 + 25 * dx
        y1 = y1 + 20 * dy

        Dim aBrush As New SolidBrush(Color.FromArgb(nA, nR, nG, nB))
        Dim formGraphics As Graphics = Me.CreateGraphics()
        formGraphics.FillEllipse(aBrush, New Rectangle(x1, y1, nW, nW))

        If x1 > Me.ClientSize.Width - 20 Then dx = -1
        If x1 < 20 Then dx = 1

        If y1 > Me.ClientSize.Height - 20 Then
            dy = -1
            changeBallStyle()
        End If

        If y1 < 20 Then dy = 1
    End Sub

    Sub changeBallStyle()
        nA = Int(Rnd() * 64) + 192
        nR = Int(Rnd() * 256)
        nG = Int(Rnd() * 256)
        nB = Int(Rnd() * 256)
        nW = Int(Rnd() * 20) + 30
    End Sub
End Class