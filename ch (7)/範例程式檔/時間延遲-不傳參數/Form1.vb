Public Class Form1
    Sub sleep()
        Dim start, finish As Double
        start = Microsoft.VisualBasic.DateAndTime.Timer
        finish = start + 0.1
        Do While Microsoft.VisualBasic.DateAndTime.Timer < finish
            '空迴路 
        Loop
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim MyPen As New System.Drawing.Pen(Color.Blue, 20)
        Dim TextGraphics As System.Drawing.Graphics
        TextGraphics = Me.TextBox1.CreateGraphics()
        Dim x1, y1 As Integer
        x1 = Me.TextBox1.Width
        y1 = Me.TextBox1.Height
        TextGraphics.Clear(Color.White)
        For i As Integer = 0 To Me.Width Step 40

            TextGraphics.DrawLine(MyPen, i, 0, x1 - i, y1)
            Call sleep()
        Next
        MyPen.Dispose()
        TextGraphics.Dispose()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
