Public Class Form1
    Dim str1 = ""
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        str1 = "是否為系統管理員：" & _
        IIf(My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator), "是", "否") & vbNewLine
        MsgBox(str1)
        End
    End Sub
End Class

