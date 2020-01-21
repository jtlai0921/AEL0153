Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.TextBox1.Text = ""
        Me.TextBox1.Text += Me.TextBox2.Text + vbNewLine
        Me.TextBox1.Text += Me.MaskedTextBox1.Text + vbNewLine
        Me.TextBox1.Text += Me.MaskedTextBox2.Text + vbNewLine
        Me.TextBox1.Text += Me.ListBox1.SelectedItem + vbNewLine
        
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
