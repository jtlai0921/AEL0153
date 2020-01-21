Public Class Form1
    Dim str1 = ""
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        str1 = str1 & "我的文件路徑：" & _
        My.Computer.FileSystem.SpecialDirectories.MyDocuments & vbNewLine
        str1 = str1 & "我的音樂路徑：" & _
        My.Computer.FileSystem.SpecialDirectories.MyMusic & vbNewLine
        str1 = str1 & "我的圖片路徑：" & _
        My.Computer.FileSystem.SpecialDirectories.MyPictures & vbNewLine

        MsgBox(str1)
        End
    End Sub
End Class
