Public Class Form1
    Function C_triangle(ByVal A As Integer, ByVal B As Integer, ByVal C As Integer) As Single
        Dim P, S As Single
        P = (A + B + C) / 2
        S = Math.Sqrt(P * (P - A) * (P - B) * (P - C))
        C_triangle = S
    End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim temp_1, temp_2, temp_3 As Integer
        Dim angle_v As Single
        temp_1 = Val(TextBox1.Text)
        temp_2 = Val(TextBox2.Text)
        temp_3 = Val(TextBox3.Text)
        If temp_1 > 0 And temp_2 > 0 And temp_3 > 0 Then
            angle_v = C_triangle(temp_1, temp_2, temp_3)
            If angle_v > 0 Then
                TextBox4.Text = angle_v
            Else
                TextBox4.Text = "錯誤的三邊長"
            End If
        Else
            MsgBox("三邊長的值一定要輸入不可為0", MsgBoxStyle.OkOnly)
        End If

    End Sub
End Class
