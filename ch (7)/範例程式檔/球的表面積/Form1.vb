Public Class Form1
    Function Compute(ByVal R As Single) As Double
        Dim tempV As Double
        tempV = 4 * Math.PI * R ^ 2
        Compute = tempV
    End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text) And Val(TextBox1.Text) > 0 Then
            Label2.Text = "球表面積: " & Compute(Val(TextBox1.Text)).ToString
        Else
            Label2.Text = "請輸入正的半徑值"
            TextBox1.Text = ""
        End If

    End Sub
End Class
