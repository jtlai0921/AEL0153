Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim A() As Integer = {34, 67, 90, 87, 55, 62, 102, 23, 43, 53}
        Dim TempVal, loop1, loop2, loop3 As Integer

        TempVal = 0
        TextBox1.Text = "陣列傳統排序過程" & vbNewLine
        For loop1 = 0 To A.Length - 2
            For loop2 = 1 To A.Length - (loop1 + 2)
                If A(loop2) > A(loop2 + 1) Then  '交換陣列值
                    TempVal = A(loop2)
                    A(loop2) = A(loop2 + 1)
                    A(loop2 + 1) = TempVal
                End If
            Next
            TextBox1.Text = TextBox1.Text & "第" & loop1 + 1 & "回"
            For loop3 = 0 To A.Length - 1
                TextBox1.Text = TextBox1.Text & Format(A(loop3), " 00#")
            Next
            TextBox1.Text = TextBox1.Text & vbNewLine
        Next

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim B() As Integer = {34, 67, 90, 87, 55, 62, 102, 23, 43, 53}
        TextBox1.Text = "VB2010 排序前" & vbNewLine
        For Each I As Integer In B
            TextBox1.Text = TextBox1.Text & Format(I, " 00#")
        Next
        Array.Sort(B) '排序陣列值
        TextBox1.Text = TextBox1.Text & vbNewLine
        TextBox1.Text = TextBox1.Text & "VB2010 排序後" & vbNewLine
        For Each J As Integer In B
            TextBox1.Text = TextBox1.Text & Format(J, " 00#")
        Next
        Array.Reverse(B) '反轉陣列值
        TextBox1.Text = TextBox1.Text & vbNewLine
        TextBox1.Text = TextBox1.Text & "VB2010 降冪排序" & vbNewLine
        For Each I As Integer In B
            TextBox1.Text = TextBox1.Text & Format(I, " 00#")
        Next

    End Sub
End Class
