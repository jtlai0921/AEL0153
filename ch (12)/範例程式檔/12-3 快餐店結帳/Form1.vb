Public Class Form1
    Dim total, accTotal As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label6.Text = "$" & total & "元"
        Label7.Text = "累計：$" & accTotal & "元"
        Label6.Font = New Font("新細明體", 24)
        Label6.ForeColor = Color.Red
        total = 0
        accTotal = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        total = Val(TBoxPrice1.Text) * Val(TBoxQty1.Text) + Val(TBoxPrice2.Text) * Val(TBoxQty2.Text) + Val(TBoxPrice3.Text) * Val(TBoxQty3.Text)

        If total > 2000 Then RadioButton3.Checked = True
        If RadioButton1.Checked = True Then total = total * 0.9
        If RadioButton2.Checked = True Then total = total * 0.8
        If RadioButton3.Checked = True Then total = total * 0.75
        Label6.Text = "$" & total & "元"
        accTotal = accTotal + total
        Label7.Text = "累計：$" & accTotal & "元"
        ListBox1.Items.Add(total & "-->" & "豬肉" & TBoxPrice1.Text & "*" & TBoxQty1.Text & "雞肉" & TBoxPrice2.Text & "*" & TBoxQty2.Text & "牛肉" & TBoxPrice3.Text & "*" & TBoxQty3.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TBoxQty1.Text = 0
        TBoxQty2.Text = 0
        TBoxQty3.Text = 0
        total = 0
        Label6.Text = "$" & total & "元"
    End Sub

    Private Sub ListBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseUp
        accTotal = accTotal - (Val(ListBox1.SelectedItem))
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Label7.Text = "累計：$" & accTotal & "元"
    End Sub
End Class
