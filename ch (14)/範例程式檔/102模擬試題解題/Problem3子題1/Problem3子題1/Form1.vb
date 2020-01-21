Public Class Form1
    Dim str1 = ""

    Sub p1(ByVal infile)
        Dim fileContents As String
        fileContents = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & infile)
        Dim line() = Split(fileContents, vbNewLine)
        Dim recN = CInt(line(0))
        For i = 1 To recN
            Dim data() = Split(line(i), ",")

            Dim n1 = CInt(data(0))
            Dim n2 = CInt(data(1))
            Dim s = ""
            Dim j = 2
            While n1 <> 1
                Dim jb As Integer
                Dim c = 1
                While n1 Mod j = 0
                    If j = jb Then
                        c = c + 1
                    Else
                        If c = 1 Then
                            s = s & j
                        End If
                    End If

                    jb = j

                    n1 = n1 / j
                End While
                If n1 = 1 Then
                    s = s & "^" & c
                Else
                    s = s & "^" & c & "*"
                End If
                j = j + 1
            End While

            n1 = CInt(data(0))
            While n1 <> n2
                If n1 > n2 Then
                    n1 = n1 - n2
                Else
                    n2 = n2 - n1
                End If
            End While

            s = Replace(s, "^1*", "")
            s = Replace(s, "^1", "")
            s = s & ", " & n1
            str1 = str1 & s & vbNewLine
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call p1("in1.txt")
        str1 = str1 & vbNewLine
        Call p1("in2.txt")
        MsgBox(str1)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\out.txt", str1, False)
        End
    End Sub
End Class
