Public Class Form1
    Dim str1 = ""

    Sub p1(infile)
        Dim fileContents As String
        fileContents = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & infile)
        Dim line() = Split(fileContents, vbNewLine)

        Dim i = 1
        While Mid(line(1), i, 1) <= "9"
            i = i + 1
        End While
        Dim bSign = Mid(line(1), i, 1)

        Dim lineN = CInt(line(0))
        For i = 1 To lineN
            '算點數
            Dim lineTem() = Split(line(i), bSign)

            While InStr(lineTem(0), "  ") <> 0
                lineTem(0) = Replace(lineTem(0), "  ", " ")
            End While

            Dim data() = Split(lineTem(0), " ")
            Dim s = 0
            For j = 0 To data.Length - 1 - 1
                Dim tn = CInt(data(j)) Mod 13
                If tn = 0 Then tn = 10
                If tn > 10 Then tn = 10
                If tn = 1 Then tn = 11
                s = s + tn
                'If s > 21 And tn = 11 And CInt(data(j)) = 1 Then s = s - 10
            Next

            Dim k = 0
            While s > 21 And k < 3
                If CInt(data(k)) Mod 13 = 1 Then s = s - 10
                k = k + 1
            End While

            '判斷是什麼牌
            line(i) = Replace(line(i), bSign, " ")
            line(i) = Replace(line(i), "V", " ")

            While InStr(line(i), "  ") <> 0
                line(i) = Replace(line(i), "  ", " ")
            End While

            Dim data1() = Split(line(i), " ")
            Dim flower(4) As Integer
            Dim num(4) As Integer
            For j = 0 To 4
                flower(j) = (CInt(data1(j)) - 1) \ 13
                num(j) = CInt(data1(j)) Mod 13
                If num(j) = 0 Then num(j) = 13
            Next

            Array.Sort(num)

            '判斷是什麼牌-- 統計個數
            Dim c(4) As Integer
            For j = 0 To 4
                c(j) = 0
                For k = 0 To 4
                    If num(j) = num(k) Then c(j) = c(j) + 1
                Next
            Next

            Array.Sort(c)
            Array.Reverse(c)

            Dim s1 = "雜牌"
            If c(0) = 2 Then s1 = "一對"
            If c(0) = 2 And c(2) = 2 Then s1 = "兩對"

            If c(0) = 3 Then s1 = "三條"
            If c(0) = 3 And c(3) = 2 Then s1 = "葫蘆"
            If c(0) = 4 Then s1 = "四條"
            If (num(1) - num(0) = 1 And num(2) - num(1) = 1 And num(3) - num(2) = 1 And num(4) - num(3) = 1) Or (num(1) - num(0) = 9 And num(2) - num(1) = 1 And num(3) - num(2) = 1 And num(4) - num(3) = 1) Then
                s1 = "順子"
                If flower(0) = flower(1) And flower(0) = flower(2) And flower(0) = flower(3) And flower(0) = flower(4) Then s1 = "同花順"
            End If

            str1 = str1 & IIf(s <= 21, s, "F") & ", " & s1 & vbNewLine
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call p1("in1.txt")
        str1 = str1 & vbNewLine
        Call p1("in2.txt")
        MsgBox(str1)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\out.txt", str1, False)
        End
    End Sub
End Class

