Public Class Form1
    Dim str1 = ""
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        str1 = "軟體版本：" & _
        My.Application.Info.Version.ToString & vbNewLine
        str1 = str1 & "軟體名稱：" & _
        My.Application.Info.Title & vbNewLine

        MsgBox(str1)
        End
    End Sub
End Class
