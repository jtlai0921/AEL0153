Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim siteResponds As Boolean = False
        Dim url1 = "www.google.com.tw"
        siteResponds = My.Computer.Network.Ping(url1)
        Dim str1 = url1 & IIf(siteResponds, "目前可用", "現在不通")
        MsgBox(str1)
    End Sub
End Class
