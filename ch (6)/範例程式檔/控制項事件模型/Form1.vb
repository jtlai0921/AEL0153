Public Class Form1
    Private Sub MyChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, CheckBox1.CheckedChanged
        Select Case sender.name
            Case TextBox1.Name
                MsgBox("第一個TextBox 值更變為：" & vbNewLine & sender.TEXT, 64, "訊息提示")
            Case TextBox2.Name
                MsgBox("第二個TextBox 值更變為：" & vbNewLine & sender.TEXT, 64, "訊息提示")
            Case TextBox3.Name
                MsgBox("第三個TextBox 值更變為：" & vbNewLine & sender.TEXT, 64, "訊息提示")
            Case CheckBox1.Name
                MsgBox("這是CheckBox 值更變為：" & vbNewLine & sender.TEXT, 64, "訊息提示")
        End Select
    End Sub


End Class
