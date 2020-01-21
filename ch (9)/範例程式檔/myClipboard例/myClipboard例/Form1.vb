Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Clipboard.ContainsText(System.Windows.Forms.TextDataFormat.Text) Then
            Dim clipText = My.Computer.Clipboard.GetText()
            MsgBox(clipText)
        End If
    End Sub
End Class