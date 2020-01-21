Public Class Form1
    Public showtext As String
    Public trans_v As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim items As Object
        items = ""
        showtext = "大家來學....." & vbNewLine
        For x As Integer = 0 To CheckedListBox1.CheckedItems.Count - 1
            items = items & CheckedListBox1.CheckedItems(x) & vbNewLine
        Next x

        showtext = showtext + items
        trans_v = NumericUpDown1.Value
        PictureBox1.Invalidate()
    End Sub



    Private Sub PictureBox1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        Dim mainFont As Font
        Dim textArea As Rectangle
        e.Graphics.Clear(Color.White)
        mainFont = New Font("Arial", 10, FontStyle.Bold)
        textArea = New Rectangle(0, 0, PictureBox1.Width, PictureBox1.Height)
        e.Graphics.TranslateTransform(PictureBox1.Width / 4, PictureBox1.Height / 2)
        If (NumericUpDown1.Value <> 0) Then
            e.Graphics.RotateTransform(trans_v)
        End If
        e.Graphics.DrawString(showtext, mainFont, Brushes.Red, textArea)
        mainFont.Dispose()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
