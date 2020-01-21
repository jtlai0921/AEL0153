Public Class Form1
    Dim AccSS, ss, mm, hh As Integer
    Dim xSS, ySS, xMM, yMM, xHH, yHH As Integer
    Dim SSangle As Single = -90
    Dim MMangle As Single = -90
    Dim HHangle As Single = -90
    Dim xCenter As Integer = CInt(Me.Width / 2) - 10
    Dim yCenter As Integer = CInt(Me.Height / 2) - 5

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Timer1.Interval = 1000
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Refresh()
        SSangle = SSangle + 6
        MMangle = MMangle + 6 / 60
        HHangle = HHangle + 6 * 5 / 3600
        Dim g As Graphics = Me.CreateGraphics

        xSS = xCenter + 115 * Math.Cos(SSangle * 3.14 / 180)
        ySS = yCenter + 115 * Math.Sin(SSangle * 3.14 / 180)

        xMM = xCenter + 90 * Math.Cos(MMangle * 3.14 / 180)
        yMM = yCenter + 90 * Math.Sin(MMangle * 3.14 / 180)

        xHH = xCenter + 70 * Math.Cos(HHangle * 3.14 / 180)
        yHH = yCenter + 70 * Math.Sin(HHangle * 3.14 / 180)

        g.DrawLine(New Pen(Color.Black, 8), xCenter, yCenter, xHH, yHH)
        g.DrawLine(New Pen(Color.Black, 4), xCenter, yCenter, xMM, yMM)
        g.DrawLine(New Pen(Color.Red, 1), xCenter, yCenter, xSS, ySS)

        AccSS = AccSS + 1
        ss = AccSS - Math.Floor(AccSS / 60) * 60
        mm = Math.Floor((AccSS - Math.Floor(AccSS / 3600) * 3600) / 60)
        hh = Math.Floor(AccSS / 3600)

        Dim f1 As New Font("arial", 18, FontStyle.Regular)
        Dim timeStr As String = Format(hh, "00") & ":" & Format(mm, "00") & ":" & Format(ss, "00")
        g.DrawString(timeStr, f1, Brushes.Black, Me.Width / 3, Me.Height * 3 / 5)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AccSS = Second(Now) + 60 * Minute(Now) + 3600 * Hour(Now)
        SSangle = SSangle + 6 * Second(Now)
        MMangle = MMangle + 6 / 60 * AccSS
        HHangle = HHangle + 6 * 5 / 3600 * AccSS
    End Sub
End Class
