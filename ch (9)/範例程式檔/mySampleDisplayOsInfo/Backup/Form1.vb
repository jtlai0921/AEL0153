Public Class Form1
    Dim str1 = ""
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        str1 = str1 & "作業系統全名：" & _
        My.Computer.Info.OSFullName & vbNewLine
        str1 = str1 & "作業系統平台：" & _
        My.Computer.Info.OSPlatform & vbNewLine
        str1 = str1 & "作業系統版本：" & _
        My.Computer.Info.OSVersion & vbNewLine

        MsgBox(str1)
        End
    End Sub
End Class
