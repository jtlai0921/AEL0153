Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim Mx(9, 9) As Integer
        Dim loop_I, loop_J As Integer
        Dim outstr As String
        For loop_I = 1 To 9
            For loop_J = 1 To 9
                Mx(loop_I, loop_J) = loop_I * loop_J
            Next
        Next
        For loop_I = 9 To 1 Step -1
            For loop_J = 9 To 1 Step -1
                outstr = Format(loop_I, "0#")
                outstr = outstr & "*"
                outstr = outstr & Format(loop_J, "0#")
                outstr = outstr & "="
                outstr = outstr & Format(Mx(loop_I, loop_J), "0#  ")
                TextBox1.Text = TextBox1.Text & outstr
            Next
            TextBox1.Text = TextBox1.Text & vbNewLine
        Next

    End Sub
End Class
