Public Class Form1
    Dim str1 = ""

    Function Check(ByVal refdata(), ByVal data())
        Dim c = 0
        For i = 0 To 4
            For j = 0 To 4
                If Trim(refdata(i)) = Trim(data(j)) Then
                    c = c + 1
                    Exit For
                End If
            Next
        Next
        Return c
    End Function

    Sub p1(ByVal infile)
        Dim fileContents As String
        fileContents = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & infile)
        Dim line() = Split(fileContents, vbNewLine)
        Dim data0() = Split(line(0), ":")
        Dim recN = CInt(data0(0))
        Dim refdata() = Split(data0(1), ",")

        For i = 1 To recN
            Dim data() = Split(line(i), ",")
            Dim rightN = Check(refdata, data)
            str1 = str1 & IIf(rightN < 2, "N", rightN.ToString) & vbNewLine
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
