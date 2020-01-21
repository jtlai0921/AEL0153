Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim MyDialog As New ColorDialog()
        ' 開啟顏色選取框
        MyDialog.AllowFullOpen = False
        ' 設定顏色選取框的說明按鈕是開啟　預設是關閉
        MyDialog.ShowHelp = True
        ' 設定對話框為目前顏色
        MyDialog.Color = PictureBox1.BackColor

        ' 更新為選取的顏色
        If (MyDialog.ShowDialog() = DialogResult.OK) Then
            PictureBox1.BackColor = MyDialog.Color
        End If
        ProgressBar1.Value = PictureBox1.BackColor.R
        ProgressBar2.Value = PictureBox1.BackColor.G
        ProgressBar3.Value = PictureBox1.BackColor.B

        If Microsoft.VisualBasic.Left(PictureBox1.BackColor.Name, 2) <> "ff" Then
            TextBox1.Text = PictureBox1.BackColor.Name
        Else
            TextBox1.Text = "色彩碼 : " & Microsoft.VisualBasic.Right(PictureBox1.BackColor.Name.ToUpper, 6)
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
