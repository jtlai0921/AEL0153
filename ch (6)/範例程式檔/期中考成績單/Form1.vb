Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim outstr As String
        Dim S_File As String
        Dim lineData() As String
        Dim fieldData() As String
        Dim stu_score(10, 6) As String
        Dim Loop_I, Loop_J, tot_score As Integer

        '讀入一個文字檔案
        Dim filePath As String = Application.StartupPath & "\score.TXT"
        S_File = My.Computer.FileSystem.ReadAllText(filePath)

        '處理讀入每一行資料  分割欄位資料以 vbNewLine 來表示
        lineData = Split(S_File, vbNewLine)
        Loop_I = 0
        For Each lineText As String In lineData
            '處理讀入每個欄位資料
            fieldData = lineText.Split(",") '分割欄位資料以 , 來表示
            Loop_J = 0
            For Each wordText As String In fieldData
                If wordText.Length > 0 Then
                    stu_score(Loop_I, Loop_J) = wordText
                    Loop_J = Loop_J + 1
                End If
            Next wordText
            Loop_I = Loop_I + 1
        Next lineText
        TextBox1.Text = "和平高中二年甲班第二次期中考試" & vbNewLine
        For Loop_I = 0 To 10
            outstr = ""
            tot_score = 0
            For Loop_J = 0 To 6
                If IsNumeric(stu_score(Loop_I, Loop_J)) Then
                    outstr = outstr & Format(Val(stu_score(Loop_I, Loop_J)), "0## ")
                    tot_score += Val(stu_score(Loop_I, Loop_J))
                Else
                    outstr = outstr & Trim(stu_score(Loop_I, Loop_J)) & "  "
                End If
            Next
            TextBox1.Text = TextBox1.Text & outstr & "平均:" & Format(tot_score / 5, "0#.#0")
            TextBox1.Text = TextBox1.Text & vbNewLine
        Next

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
