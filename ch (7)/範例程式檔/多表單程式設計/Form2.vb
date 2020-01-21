Public Class Form2
    Public demotext As String
    Public PageText(4) As String
    Public PageNo As Integer
    Sub cutchar(ByVal InChar As String)
        Dim Loc As Integer
        Static Ok_char As Integer = 1
        Loc = InStr(demotext, InChar)
        If Loc > 0 And InChar <> "●" Then
            demotext = Microsoft.VisualBasic.Left(demotext, Loc - 1) & "●" & Microsoft.VisualBasic.Right(demotext, Len(demotext) - Loc)
            Me.TextBox1.Text = demotext
            Label1.Text = ""
            Ok_char += Ok_char
            If Ok_char = 405 Then
                PageNo += PageNo
                demotext = PageText(PageNo)
                TextBox1.Text = demotext
            End If
        Else
            Label1.Text = "錯誤輸入，未發現所輸入字"
        End If
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim S_File As String
        Dim lineData() As String


        Dim loopj As Integer

        '讀入一個文字檔案
        '一個textBox 1344 字
        Dim filePath As String = My.Computer.FileSystem.CurrentDirectory & "\TypeROOT2.txt"
        S_File = My.Computer.FileSystem.ReadAllText(filePath)
        lineData = Split(S_File, vbNewLine)
        For Each lineText As String In lineData
            demotext = demotext & lineText
        Next lineText

        loopj = 0
        PageNo = 0
        For i As Integer = 1 To Len(demotext) Step 1344
            PageText(loopj) = Mid(demotext, i, 1344)
            loopj = loopj + 1
        Next

        demotext = PageText(PageNo)
        TextBox1.Text = demotext

    End Sub



    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        If Len(TextBox2.Text) = 1 Then
            Call cutchar(TextBox2.Text)
        End If
        TextBox2.Clear()

    End Sub
End Class