Public Class Form1
    Public CItem(23, 4) As String
    Sub READFILE()
        Dim S_File As String
        Dim lineData() As String
        Dim fieldData() As String
        Dim Loop_I, Loop_J As Integer

        '讀入文字檔案
        Dim filePath As String = My.Computer.FileSystem.CurrentDirectory & "\24.TXT"
        S_File = My.Computer.FileSystem.ReadAllText(filePath)

        ' 處理讀入每一行資料
        lineData = Split(S_File, vbNewLine)

        Loop_I = 0
        For Each lineOfText As String In lineData
            ' 處理讀入每個欄位資料
            fieldData = lineOfText.Split(",")
            Loop_J = 0
            For Each wordOfText As String In fieldData
                If wordOfText.Length > 0 Then
                    CItem(Loop_I, Loop_J) = Trim(wordOfText)
                    If Loop_J = 0 Then
                        ListBox1.Items.Add(CItem(Loop_I, Loop_J))
                    End If
                End If
                Loop_J = Loop_J + 1
            Next wordOfText
            Loop_I = Loop_I + 1
        Next lineOfText
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call READFILE()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        '顯示對應項目節氣內容
        TextBox1.Text = ""
        TextBox1.SelectedText = CItem(ListBox1.SelectedIndex, 0) + vbNewLine
        TextBox1.SelectedText = CItem(ListBox1.SelectedIndex, 1) + vbNewLine
        TextBox1.SelectedText = CItem(ListBox1.SelectedIndex, 2) + vbNewLine
        TextBox1.SelectedText = CItem(ListBox1.SelectedIndex, 3) + vbNewLine
        TextBox1.SelectedText = CItem(ListBox1.SelectedIndex, 4) + vbNewLine

        '設定選定日期
        Dim Y As Integer = Year(Now())
        Dim Temp() As String = CItem(ListBox1.SelectedIndex, 2).Split("/")
        Dim M As Integer = Val(Temp(0))
        Dim d1 As Integer = Val(Temp(1))
        Dim d2 As Integer = d1 + 1

        Select Case CItem(ListBox1.SelectedIndex, 1)
            Case "春天"
                MonthCalendar1.BackColor = Color.Yellow
            Case "夏天"
                MonthCalendar1.BackColor = Color.Green
            Case "秋天"
                MonthCalendar1.BackColor = Color.Olive
            Case "冬天"
                MonthCalendar1.BackColor = Color.Gray
        End Select

        Dim myVacation1 As Date = New DateTime(Y, M, d1)
        Dim myVacation2 As Date = New DateTime(Y, M, d2)

        MonthCalendar1.AddBoldedDate(myVacation1)
        MonthCalendar1.AddBoldedDate(myVacation2)

        MonthCalendar1.SetDate(myVacation1)
    End Sub
End Class
