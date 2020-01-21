Public Class Form1
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox1.BackColor = Color.Silver
        TextBox2.BackColor = Color.Yellow
        Timer2.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.BackColor = Color.Green
        Timer1.Enabled = True
        Button2.Enabled = True
        Button1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        TextBox3.BackColor = Color.Red
        TextBox2.BackColor = Color.Silver
        Timer3.Enabled = True
        Timer2.Enabled = False
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        TextBox1.BackColor = Color.Green
        TextBox3.BackColor = Color.Silver
        Timer1.Enabled = True
        Timer3.Enabled = False
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
