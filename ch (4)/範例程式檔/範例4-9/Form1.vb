Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cnt, tmp, sum As Integer
        cnt = 0
        sum = 0
        Do
            tmp = InputBox("��J��" & cnt + 1 & "��", "��J��ܮ�")
            If tmp <> 0 Then
                sum = sum + tmp
                cnt = cnt + 1
            End If
        Loop Until tmp = 0
        TextBox1.Text = cnt
        TextBox2.Text = (sum / cnt)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
