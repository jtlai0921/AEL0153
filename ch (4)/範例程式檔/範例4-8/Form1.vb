Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, old_a, old_b As Integer
        Dim max, min As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        old_a = a
        old_b = b
        Do While a <> 0 And b <> 0
            If a > b Then
                a = a Mod b
            Else
                b = b Mod a
            End If
        Loop
        max = Math.Abs(a - b)
        min = (old_a / max) * (old_b / max) * max
        Label3.Text = "�̤j���]�Ƭ�= " & max
        Label4.Text = "�O�p�����Ƭ�= " & min
    End Sub
End Class
