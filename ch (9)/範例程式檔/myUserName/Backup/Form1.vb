Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim str1 = "使用者：" & My.User.Name & vbNewLine
        str1 = str1 & "已驗證否：" & IIf(My.User.IsAuthenticated, "是", "否")
        MsgBox(str1)
    End Sub
End Class
