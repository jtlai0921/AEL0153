Public Class Form1
    Dim tot As Single
    Dim UseTime As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text) Then
            UseTime = Val(TextBox1.Text)
            If UseTime <= 30 Then
                tot = 200
            ElseIf UseTime <= 100 Then
                tot = 200 + (UseTime - 30) * 5
            ElseIf UseTime <= 300 Then
                tot = 200 + 70 * 5 + (UseTime - 100) * 4
            Else
                tot = 1350
            End If
            If CheckBox1.Checked = True Then
                tot = tot * 0.9
            End If
            If CheckBox2.Checked = True Then
                tot = tot * 0.9
            End If
            TextBox2.Text = tot
        Else
            TextBox2.Text = "¿é¤J¿ù»~"
            TextBox1.Focus()
        End If
    End Sub
End Class
