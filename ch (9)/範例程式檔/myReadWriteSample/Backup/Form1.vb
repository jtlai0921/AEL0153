Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim temStr As String = "白日依山盡" & vbNewLine
        temStr &= "黃河入海流" & vbNewLine
        temStr &= "欲窮千里目" & vbNewLine
        temStr &= "更上一層樓" & vbNewLine
        My.Computer.FileSystem.WriteAllText("C:\Test.txt", temStr, False)

        Dim fileContents As String
        fileContents = My.Computer.FileSystem.ReadAllText("C:\Test.txt")
        MsgBox(fileContents)
    End Sub
End Class