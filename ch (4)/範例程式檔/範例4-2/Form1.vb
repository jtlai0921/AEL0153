Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s As Char
        Dim countA As Integer
        Dim strA As String
        s = TextBox2.Text

        strA = TextBox1.Text
        For i As Integer = 1 To strA.Length
            If Mid(strA, i, 1) = s Then
                countA = countA + 1
            End If
        Next
        Label2.Text = "¥X²{" & countA & "¦¸"
    End Sub
End Class
