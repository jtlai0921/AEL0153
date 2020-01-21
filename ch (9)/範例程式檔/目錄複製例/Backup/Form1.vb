Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.CopyDirectory("C:\testDir", "D:\testDir1", False)
    End Sub
End Class

