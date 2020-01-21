Public Class Form1
    Sub AddVal(ByVal InVarX As Integer, ByVal InVarY As Integer)
        InVarX = InVarX + 2000
        InVarY = InVarY + InVarX + 1956

        TextBox1.Text = TextBox1.Text & "副程式變數值" + vbNewLine
        TextBox1.Text = TextBox1.Text & "InVarX=" & InVarX.ToString & vbNewLine
        TextBox1.Text = TextBox1.Text & "InVarY=" & InVarY.ToString & vbNewLine
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim VarX, VarY As Integer
        VarX = 100
        VarY = 210
        TextBox1.Clear()
        TextBox1.Text = TextBox1.Text & "主程式呼叫前變數值" + vbNewLine
        TextBox1.Text = TextBox1.Text & "VarX=" & VarX.ToString & vbNewLine
        TextBox1.Text = TextBox1.Text & "VarY=" & VarY.ToString & vbNewLine
        TextBox1.Text = TextBox1.Text & vbNewLine

        Call AddVal(VarX, VarY)

        TextBox1.Text = TextBox1.Text & vbNewLine
        TextBox1.Text = TextBox1.Text & "主程式呼叫後變數值" & vbNewLine
        TextBox1.Text = TextBox1.Text & "VarX=" & VarX.ToString & vbNewLine
        TextBox1.Text = TextBox1.Text & "VarY=" & VarY.ToString & vbNewLine

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
