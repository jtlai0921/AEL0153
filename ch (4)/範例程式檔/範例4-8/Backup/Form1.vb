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
        Label3.Text = "最大公因數為= " & max
        Label4.Text = "是小公倍數為= " & min
    End Sub
End Class
