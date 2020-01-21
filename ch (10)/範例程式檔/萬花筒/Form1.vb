Public Class Form1
    Dim g As Graphics
    Dim pen1 As Pen
    Dim sFlag As Boolean = True

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        Timer1.Interval = 50
        Timer1.Enabled = True
        g = Me.CreateGraphics
        Me.BackColor = Color.Black
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim drawType1 As String
        If sFlag = True Then
            drawType1 = "rect"
            sFlag = Not sFlag
        Else
            drawType1 = "ellicpse"
            sFlag = Not sFlag
        End If
        draw1(drawType1)
    End Sub

    Sub draw1(ByVal drawType1)
        Dim generator As New Random

        Dim x1, y1, w1, h1, t1 As Integer
        x1 = generator.Next(0, Me.Width)
        y1 = generator.Next(0, Me.Height)
        w1 = generator.Next(0, Me.Width / 3)
        h1 = generator.Next(0, Me.Height / 3)
        t1 = generator.Next(1, 7)

        pen1 = New Pen(Color.Black)
        Dim temBrush As Brush
        temBrush = Choose(t1, Brushes.Red, Brushes.Orange, Brushes.Yellow, Brushes.Green, Brushes.Blue, Brushes.Purple)

        If drawType1 = "rect" Then
            'g.DrawRectangle(pen1, x1, y1, w1, h1)
            g.FillRectangle(temBrush, x1, y1, w1, h1)
        End If
        If drawType1 = "ellicpse" Then
            'g.DrawEllipse(pen1, x1, y1, w1, h1)
            g.FillEllipse(temBrush, x1, y1, w1, h1)
        End If
    End Sub
End Class
