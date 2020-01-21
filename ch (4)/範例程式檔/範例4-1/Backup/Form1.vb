Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sum As Integer
        Dim N As Integer
        N = InputBox("½Ð¿é¤JN­È:")
        For i As Integer = 1 To N
            sum = sum + i
        Next
        Label3.Text = sum
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
