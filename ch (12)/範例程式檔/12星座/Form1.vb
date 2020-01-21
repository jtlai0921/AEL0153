Public Class Form1
    Public CItem(11, 7) As String
    Public A(4) As TextBox
    Sub READFILE()
        Dim S_File As String
        Dim lineData() As String
        Dim FieldData() As String
        Dim Loop_I, Loop_J As Integer

        '讀入文字檔案
        Dim FilePath As String = My.Computer.FileSystem.CurrentDirectory & "\12star.txt"
        S_File = My.Computer.FileSystem.ReadAllText(filePath)

        ' 處理讀入每一行資料
        lineData = Split(S_File, vbNewLine)

        Loop_I = 0
        For Each lineOfText As String In lineData
            ' 處理讀入每個欄位資料
            FieldData = lineOfText.Split(",")
            Loop_J = 0
            For Each wordOfText As String In FieldData
                If wordOfText.Length > 0 Then
                    CItem(Loop_I, Loop_J) = Trim(wordOfText)
                    If Loop_J = 0 Then
                        ListBox1.Items.Add(Trim(CItem(Loop_I, Loop_J)))
                    End If
                End If
                Loop_J = Loop_J + 1
            Next wordOfText
            Loop_I = Loop_I + 1
        Next lineOfText
    End Sub
    Sub CArray()
        '建立控制項陣列
        Dim I, J As Integer
        '建立前三個較小尺寸控制項陣列
        J = 50
        For I = 0 To 3
            A(I) = New TextBox()
            With A(I)
                .Font = New Font(FontFamily.GenericSansSerif, 14.0F, FontStyle.Regular)
                .Width = Me.Panel1.Width - 10
                .Height = 30
                .Left = Me.Panel1.Location.X
                .Top = J + (.Height + 5) * I
                .Name = I.ToString & J.ToString
                .Multiline = True
                .TextAlign = HorizontalAlignment.Center
            End With
            Me.Panel1.Controls.Add(A(I))
        Next

        '建立一個大尺寸控制項陣列
        I = 4
        A(I) = New TextBox()
        With A(I)
            .Font = New Font(FontFamily.GenericSansSerif, 14.0F, FontStyle.Regular)
            .Width = Me.Panel1.Width - 10
            .Height = 60
            .Left = Me.Panel1.Location.X
            .Top = A(I - 1).Height + A(I - 1).Top + 5
            .AutoSize = True
            .Name = I.ToString & J.ToString
            .Multiline = True
        End With
        Me.Panel1.Controls.Add(A(I))
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call READFILE()
        Call CArray()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim imgF As String

        Dim Y As Integer = Year(Now())
        Dim Temp1() As String = CItem(ListBox1.SelectedIndex, 3).Split("/")
        Dim M1 As Integer = Val(Temp1(0))
        Dim d1 As Integer = Val(Temp1(1))

        Dim Temp2() As String = CItem(ListBox1.SelectedIndex, 4).Split("/")
        Dim M2 As Integer = Val(Temp2(0))
        Dim d2 As Integer = Val(Temp2(1))

        Dim myVacation1 As Date = New DateTime(Y, M1, d1)
        If M1 = 12 Then
            Y = Y + 1
        End If

        Dim myVacation2 As Date = New DateTime(Y, M2, d2)

        MonthCalendar1.RemoveAllBoldedDates()
        MonthCalendar1.AddBoldedDate(myVacation1)
        MonthCalendar1.AddBoldedDate(myVacation2)



        MonthCalendar1.SetDate(myVacation1)
        MonthCalendar2.SetDate(myVacation2)

        If (ListBox1.SelectedIndex + 1) < 10 Then
            imgF = "0" & (ListBox1.SelectedIndex + 1).ToString & ".jpg"
        Else
            imgF = (ListBox1.SelectedIndex + 1).ToString & ".jpg"

        End If

        PictureBox1.Image = Image.FromFile(My.Computer.FileSystem.CurrentDirectory & "\" & imgF)

        A(0).Text = CItem(ListBox1.SelectedIndex, 1)
        A(1).Text = CItem(ListBox1.SelectedIndex, 2)

        A(2).Text = "守護神 : " & CItem(ListBox1.SelectedIndex, 6)
        A(3).Text = "守護星 : " & CItem(ListBox1.SelectedIndex, 7)

        A(4).Text = CItem(ListBox1.SelectedIndex, 5)
        Me.Text = "十二星座 ---" & A(1).Text
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        End
    End Sub
End Class
