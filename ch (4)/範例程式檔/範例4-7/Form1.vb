Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim icount As Integer = 0
        Dim pwd As String = ""
        Do
            icount = icount + 1
            pwd = InputBox("第" & icount & "次輸入：", "密碼檢查")
        Loop While (pwd <> "411063" And icount < 3)
        If icount = 3 Then
            MsgBox("輸入錯誤超過三次，停止使用!")
        Else
            MsgBox("歡迎進人本系統")
        End If
    End Sub
End Class
