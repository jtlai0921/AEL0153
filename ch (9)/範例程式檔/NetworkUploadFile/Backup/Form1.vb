Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Network.UploadFile("C:\301g1.swf", "ftp://59.126.161.241/301g2.swf", "abcd", "1234")
    End Sub
End Class
