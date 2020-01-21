Public Class Form1
    Dim Score As Single
    Dim over As Boolean
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) < 0 Or Val(TextBox1.Text) > 100 Then
            over = True
            TextBox1.ForeColor = Color.Red
        End If
        If Val(TextBox2.Text) < 0 Or Val(TextBox2.Text) > 100 Then
            over = True
            TextBox2.ForeColor = Color.Red
        End If
        If Val(TextBox3.Text) < 0 Or Val(TextBox3.Text) > 100 Then
            over = True
            TextBox3.ForeColor = Color.Red
        End If
        If over = True Then
            TextBox4.Text = "資料輸入錯誤，請重新輸入"
        Else
            Score = (Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text)) / 3
            TextBox4.Text = Score
            If Score < 60 Then
                TextBox4.BackColor = Color.Red
            End If
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox4.BackColor = Color.Empty
        over = False
        TextBox1.ForeColor = Color.Black
        TextBox2.ForeColor = Color.Black
        TextBox3.ForeColor = Color.Black
        TextBox1.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
