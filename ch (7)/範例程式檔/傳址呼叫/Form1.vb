Public Class Form1
    Sub Swap(ByRef InVarX As VariantType, ByRef InVarY As VariantType)
        '將二個值交換過來
        InVarX = InVarX Xor InVarY
        InVarY = InVarX Xor InVarY
        InVarX = InVarX Xor InVarY
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim X, y As Integer
        X = 5555
        y = 65232
        TextBox1.Text = "呼叫前" & vbNewLine
        TextBox1.Text = TextBox1.Text & "X :" & X.ToString & vbNewLine & "Y :" & y.ToString & vbNewLine
        Call Swap(X, y)
        TextBox1.Text = TextBox1.Text & "呼叫後" & vbNewLine
        TextBox1.Text = TextBox1.Text & "X :" & X.ToString & vbNewLine & "Y :" & y.ToString & vbNewLine

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
