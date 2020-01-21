Public Class Form1
    Dim windN As Integer = 1
    Dim windN2 As Integer = 1
    Dim bitmap1 As Bitmap
    Dim g As Graphics = Me.CreateGraphics

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ImageList1.ImageSize = New Size(240, 240)
        ImageList1.Images.Add(Image.FromFile("..\..\Resources\wind0.gif"))
        ImageList1.Images.Add(Image.FromFile("..\..\Resources\wind10.gif"))
        ImageList1.Images.Add(Image.FromFile("..\..\Resources\wind20.gif"))
        ImageList1.Images.Add(Image.FromFile("..\..\Resources\wind30.gif"))
        ImageList1.Images.Add(Image.FromFile("..\..\Resources\wind40.gif"))
        ImageList1.Images.Add(Image.FromFile("..\..\Resources\wind50.gif"))

        Timer1.Interval = 50
        Timer1.Enabled = True
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage

        bitmap1 = CType(Bitmap.FromFile("..\..\Resources\wind0.gif"), Bitmap)
        PictureBox2.Image = bitmap1
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Refresh()
        PictureBox1.Image = ImageList1.Images.Item(windN)
        windN = windN + 1
        windN = windN Mod 6
        windN2 = windN2 + 1
        windN2 = (windN2 Mod 4) + 1

        Select Case windN2
            Case 1
                bitmap1.RotateFlip(RotateFlipType.Rotate270FlipNone)
            Case 2
                bitmap1.RotateFlip(RotateFlipType.Rotate180FlipNone)
            Case 3
                bitmap1.RotateFlip(RotateFlipType.Rotate90FlipNone)
            Case 4
                bitmap1.RotateFlip(RotateFlipType.RotateNoneFlipNone)
        End Select
        PictureBox2.Image = bitmap1
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim blackPen As New Pen(Color.Black, 18)
        Dim points1 As Point() = {New Point(CInt(PictureBox1.Left + PictureBox1.Width / 2), (PictureBox1.Top + PictureBox1.Height) / 2), New Point(CInt(PictureBox1.Left + PictureBox1.Width / 2), 225)}
        Dim points2 As Point() = {New Point(CInt(PictureBox2.Left + PictureBox2.Width / 2), (PictureBox2.Top + PictureBox2.Height) / 2), New Point(CInt(PictureBox2.Left + PictureBox2.Width / 2), 225)}

        e.Graphics.DrawLines(blackPen, points1)
        e.Graphics.DrawLines(blackPen, points2)
    End Sub
End Class