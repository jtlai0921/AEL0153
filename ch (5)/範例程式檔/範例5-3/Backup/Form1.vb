Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim math1 As New mymath
        Dim m1, m2 As Single
        m1 = Val(TextBox1.Text)
        m2 = Val(TextBox2.Text)
        If m2 = 0 Then
            TextBox3.Text = math1.area(m1)
        Else
            TextBox3.Text = math1.area(m1, m2)
        End If
    End Sub
End Class
