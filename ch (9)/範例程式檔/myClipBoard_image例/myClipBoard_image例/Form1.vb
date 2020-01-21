Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Clipboard.ContainsImage() Then
            PictureBox1.Image = My.Computer.Clipboard.GetImage()
        End If
    End Sub
End Class
