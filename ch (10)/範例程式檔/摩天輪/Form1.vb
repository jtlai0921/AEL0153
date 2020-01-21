Public Class Form1
    Dim angle(6) As Integer, anglePi(6) As Single
    Dim pic(6) As PictureBox
    Dim x1, y1, x2(6), y2(6), oldx2(6), oldy2(6) As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pic(1) = PictureBox1
        pic(2) = PictureBox2
        pic(3) = PictureBox3
        pic(4) = PictureBox4
        pic(5) = PictureBox5
        pic(6) = PictureBox6
        Timer1.Interval = 100
        Timer1.Enabled = True
        angle(0) = 0
        Dim i As Integer
        For i = 1 To 6
            pic(i).Height = 50
            pic(i).Width = 25
            pic(i).SizeMode = PictureBoxSizeMode.StretchImage
        Next i
        x1 = Me.Width / 2
        y1 = (Me.Height - pic(1).Height) / 2

        'For i = 1 To 6
        '    x2(i) = Me.Width / 2 + 50 * Math.Cos(anglePi(1))
        '    y2(i) = (Me.Height - pic(1).Height) / 2 + 70 * Math.Sin(anglePi(1))
        'Next i
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim i As Integer
        angle(0) = angle(0) + 3
        For i = 1 To 6
            oldx2(i) = x2(i)
            oldy2(i) = y2(i)
        Next i

        Dim g As Graphics = Me.CreateGraphics

        For i = 1 To 6
            angle(i) = angle(0) + 60 * i
            anglePi(i) = angle(i) * 3.14 / 180
            Dim temStr As String = "..\..\Resources\seat(" & i & ").gif"
            pic(i).Image = New Bitmap(temStr)
            pic(i).Left = Me.Width / 2 + 50 * Math.Cos(anglePi(i))
            pic(i).Top = (Me.Height - pic(i).Height) / 2 + 70 * Math.Sin(anglePi(i))

            x2(i) = pic(i).Left
            y2(i) = pic(i).Top

            g.DrawLine(New Pen(Color.White), New Point(x1, y1), New Point(oldx2(i), oldy2(i)))
            g.DrawLine(New Pen(Color.Black), New Point(x1, y1), New Point(x2(i), y2(i)))
        Next i
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = Me.CreateGraphics
        g.DrawLine(New Pen(Color.Black, 15), New Point(x1, y1), New Point(CInt(Me.Width / 2), Me.Height - 50))
    End Sub
End Class