Public Class Form1
    Dim str1 = ""

    Sub p1(ByVal infile)
        Dim fileContents As String
        fileContents = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & infile)
        Dim line() = Split(fileContents, vbNewLine)
        Dim recN = CInt(line(0))

        For j = 1 To recN
            Dim tStr = line(j)
            Dim s = ""
            For i = 1 To tStr.Length
                If Mid(tStr, i, 1) <= "9" And Mid(tStr, i, 1) >= "0" Then
                    s = s & Mid(tStr, i, 1)
                End If
            Next
            str1 = str1 & IIf(s = "", "N", s) & vbNewLine
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call p1("in1.txt")
        str1 = str1 & vbNewLine
        Call p1("in2.txt")
        ' MsgBox(str1)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\out.txt", str1, False)
        End
    End Sub
End Class

