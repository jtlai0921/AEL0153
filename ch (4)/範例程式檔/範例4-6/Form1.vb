Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For i As Integer = 0 To 23
            TextBox1.Text = i
            For j As Integer = 0 To 59
                TextBox2.Text = j
                For k As Integer = 0 To 59
                    TextBox3.Text = k
                    Me.Refresh()
                    For l As Integer = 1 To 100000000       'ªÅ°j°é

                    Next
                Next
            Next
        Next
    End Sub
End Class
