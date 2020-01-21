Public Class Form1
    Dim varform As Integer = 1 '定義表單變數

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim varForm As Integer = 1  '定義一個和表單變數相同變數
        varForm = varForm + 100
        var_module = var_module + 100
        TextBox1.Text = varForm.ToString
        TextBox3.Text = var_module.ToString
        TextBox2.Clear()  '將用不到TextBox 清除

    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Static varloc As Integer = 1 '定義一個靜態變數
        varform = varform - 1
        varloc = varloc - 1
        var_module = var_module - 1
        TextBox1.Text = varform.ToString
        TextBox2.Text = varloc.ToString
        TextBox3.Text = var_module.ToString

    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        End
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim varloc As Integer = 1
        varform = varform + 1
        varloc = varloc + 1
        var_module = var_module + 1
        TextBox1.Text = varform.ToString
        TextBox2.Text = varloc.ToString
        TextBox3.Text = var_module.ToString

    End Sub
End Class
