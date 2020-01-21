Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox1.Text = Hour(Now)
        TextBox2.Text = Minute(Now)
        TextBox3.Text = Second(Now)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
            Button1.Text = "°±¤î"
        Else
            Timer1.Enabled = False
            Button1.Text = "Ä~Äò"
        End If
    End Sub
End Class
