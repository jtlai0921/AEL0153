Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim icount As Integer = 0
        Dim pwd As String = ""
        Do
            icount = icount + 1
            pwd = InputBox("��" & icount & "����J�G", "�K�X�ˬd")
        Loop While (pwd <> "411063" And icount < 3)
        If icount = 3 Then
            MsgBox("��J���~�W�L�T���A����ϥ�!")
        Else
            MsgBox("�w��i�H���t��")
        End If
    End Sub
End Class
