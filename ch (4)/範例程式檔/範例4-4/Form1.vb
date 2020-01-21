Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, j As Integer
        Dim s As String = ""
        For i = 1 To 9
            For j = 1 To 9
                s = s & i & "กั" & j & "=" & Format(i * j, "0#") & vbNewLine
            Next
        Next
        TextBox1.Text = s
    End Sub
End Class
