Public Class Form3

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub 檔案情大白FToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 檔案FToolStripMenuItem.Click

    End Sub

    Private Sub 文章測驗ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 文章測驗ToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub 字根歸類ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 字根歸類ToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub 結束XToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 結束XToolStripMenuItem.Click
        End
    End Sub
End Class