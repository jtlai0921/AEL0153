Public Class Form1
    Dim price1 As Integer
    Dim price2 As Integer
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        price1 = 0
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        price1 = 40
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        price1 = 160
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        price1 = 290
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        price1 = 700
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        price1 = 1080
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        price1 = 1350
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        price1 = 1490
    End Sub

    Private Sub RadioButton21_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton21.CheckedChanged
        price2 = 0
    End Sub

    Private Sub RadioButton22_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton22.CheckedChanged
        price2 = 40
    End Sub

    Private Sub RadioButton23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton23.CheckedChanged
        price2 = 160
    End Sub

    Private Sub RadioButton24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton24.CheckedChanged
        price2 = 290
    End Sub

    Private Sub RadioButton25_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton25.CheckedChanged
        price2 = 700
    End Sub

    Private Sub RadioButton26_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton26.CheckedChanged
        price2 = 1080
    End Sub

    Private Sub RadioButton27_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton27.CheckedChanged
        price2 = 1350
    End Sub

    Private Sub RadioButton28_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton28.CheckedChanged
        price2 = 1490
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = Math.Abs(price1 - price2)
    End Sub
End Class
