Public Class Form1
    Public demotext As String
    Sub cutchar(ByVal InChar)
        Dim Loc As Integer
        Loc = InStr(demotext, InChar)
        If Loc > 0 Then
            demotext = Microsoft.VisualBasic.Left(demotext, Loc - 1) & "◎" & Microsoft.VisualBasic.Right(demotext, Len(demotext) - Loc)
            Me.TextBox1.Text = demotext
            Label1.Text = ""
        Else
            Label1.Text = "錯誤輸入，未發現所輸入字"
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        If Len(TextBox2.Text) = 1 Then
            Call cutchar(TextBox2.Text)
        End If
        TextBox2.Clear()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim S_File As String
        Dim lineData() As String

        '讀入一個文字檔案
        Dim filePath As String = My.Computer.FileSystem.CurrentDirectory & "\pageword.txt"

        S_File = My.Computer.FileSystem.ReadAllText(filePath)
        lineData = Split(S_File, vbNewLine)
        For Each lineText As String In lineData
            demotext = demotext & lineText
        Next lineText
        Me.TextBox1.Text = demotext

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
