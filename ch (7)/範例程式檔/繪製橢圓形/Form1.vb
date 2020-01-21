Public Class Form1
    Sub sleep2(ByVal sleepTime As Double)
        Dim start, Finish As Double
        start = Microsoft.VisualBasic.DateAndTime.Timer
        Finish = start + sleepTime
        Do While Microsoft.VisualBasic.DateAndTime.Timer < Finish
            '空迴路
        Loop
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim MyPen As New System.Drawing.Pen(Color.Blue, 2)
        Dim TextGraphics As System.Drawing.Graphics
        TextGraphics = Me.TextBox1.CreateGraphics()
        Dim x1, y1, Temp As Single
        x1 = Me.TextBox1.Width / 2
        y1 = Me.TextBox1.Height / 2
        TextGraphics.Clear(Color.White)
        For i As Integer = 0 To Me.Width Step 40
            Temp = i / 2
            TextGraphics.DrawEllipse(MyPen, x1 - i, y1 - Temp, i * 2, i)
            Call sleep2(0.1)
        Next
        MyPen.Dispose()  '將各項資源釋放給作業系統
        TextGraphics.Dispose()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
