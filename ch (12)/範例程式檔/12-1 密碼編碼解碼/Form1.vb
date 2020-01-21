Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer = 1
        While i <= Len(TextBox1.Text)
            TextBox2.Text = TextBox2.Text + Chr(Asc(Mid(TextBox1.Text, i, 1)) + 2)
            i = i + 1
        End While
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer = 1
        While i <= Len(TextBox2.Text)
            TextBox1.Text = TextBox1.Text + Chr(Asc(Mid(TextBox2.Text, i, 1)) - 2)
            i = i + 1
        End While
    End Sub
End Class
