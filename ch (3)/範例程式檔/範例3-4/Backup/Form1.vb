Public Class Form1
    Dim op1, op2 As Single
    Dim op As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        op1 = Val(TextBox1.Text)
        op2 = Val(TextBox2.Text)
        If op2 = 0 And op = 4 Then
            TextBox2.Text = "除數不得為0"
            TextBox2.Select()
        Else
            If op = 1 Then
                TextBox3.Text = op1 + op2
            ElseIf op = 2 Then
                TextBox3.Text = op1 - op2
            ElseIf op = 3 Then
                TextBox3.Text = op1 * op2
            Else
                TextBox3.Text = op1 / op2
            End If
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        op = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        op = 2
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        op = 3
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged

            op = 4

    End Sub
End Class
