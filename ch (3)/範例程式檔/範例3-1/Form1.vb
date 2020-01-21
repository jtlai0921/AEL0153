Public Class Form1
    Dim Score As Single
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Score = (Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text)) / 3
        TextBox4.Text = Score
        If Score < 60 Then
            TextBox4.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class
