Public Class Form1

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.WebBrowser1.Navigate(LinkLabel1.Text)
        LinkLabel1.LinkVisited = True
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.WebBrowser1.Navigate(LinkLabel2.Text)
        LinkLabel2.LinkVisited = True

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.WebBrowser1.Navigate(LinkLabel3.Text)
        LinkLabel3.LinkVisited = True

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.WebBrowser1.Navigate("www.google.com")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If (TextBox1.Text.Length > 0) Then WebBrowser1.Navigate(TextBox1.Text)
    End Sub
End Class
