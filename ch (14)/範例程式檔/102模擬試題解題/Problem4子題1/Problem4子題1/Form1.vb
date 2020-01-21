Public Class Form1
    Dim chTable = "ABCDEFGHIJKLMNOPQRESTUVWXYZ"
    Dim nTable() = {0, 10, 11, 12, 13, 14, 15, 16, 17, 34, 18, 19, 20, 21, 22, 35, 23, 24, 25, 26, 27, 28, 29, 32, 30, 31, 33}
    Dim str1 = ""

    Sub p1(infile)
        Dim fileContents As String
        fileContents = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & infile)
        Dim line() = Split(fileContents, vbNewLine)
        Dim lineN = CInt(line(0))
        For i = 1 To lineN
            Dim char1 = Mid(line(i), 1, 1)
            Dim j = 1
            While char1 <> Mid(chTable, j, 1)
                j = j + 1
            End While
            Dim n(11) As Integer
            n(1) = nTable(j) \ 10
            n(2) = nTable(j) Mod 10

            For j = 2 To 10
                n(j + 1) = Mid(line(i), j, 1)
            Next

            Dim s = n(1) * 1 + n(2) * 9 + n(3) * 8 + n(4) * 7 + n(5) * 6 + n(6) * 5 + n(7) * 4 + n(8) * 3 + n(9) * 2 + n(10) * 1 + n(11) * 1
            Dim tfResult = IIf(s Mod 10 = 0, "T", "F")

            str1 = str1 & tfResult & vbNewLine

        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call p1("in1.txt")
        str1 = str1 & vbNewLine
        Call p1("in2.txt")
        'MsgBox(str1)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\out.txt", str1, False)
        End
    End Sub
End Class
