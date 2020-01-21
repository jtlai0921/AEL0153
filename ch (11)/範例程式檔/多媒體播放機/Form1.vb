Public Class Form1
    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        Dim urlStr As String = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            urlStr = OpenFileDialog1.FileName
            Me.AxWindowsMediaPlayer1.URL = urlStr
        End If
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        End
    End Sub
End Class
