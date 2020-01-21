Public Class Form1
    Dim i1 As SByte             '你可以改變宣告後再測試
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        i1 = TextBox1.Text
        TextBox2.Text = i1
    End Sub
End Class
