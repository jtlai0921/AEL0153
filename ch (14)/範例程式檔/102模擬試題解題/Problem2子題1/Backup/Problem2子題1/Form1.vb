Public Class Form1
    Dim rStr = ""
    Sub p1(ByVal infile As String)
        Dim dt(50, 2) As Integer
        Dim fileContents As String
        fileContents = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & infile)
        Dim line() = Split(fileContents, vbNewLine)


        Dim gIndex = 0
        For m As Integer = 1 To CInt(line(0))

            Dim dataN = CInt(line(1 + gIndex))
            Dim i = 1
            While i <= dataN
                Dim d() = Split(line(1 + gIndex + i), ",")
                dt(i, 0) = CInt(d(0))
                dt(i, 1) = CInt(d(1))
                i = i + 1
            End While

            '
            Dim str1 = ""
            If dataN <= 2 Then
                str1 = str1 & dt(1, 0) & ":N"
                rStr = rStr & str1 & vbNewLine
            Else

                For i = 1 To dataN
                    dt(i, 2) = 1
                    For j As Integer = 1 To dataN
                        If dt(i, 0) = dt(j, 1) Then dt(i, 2) = dt(i, 2) + 1
                    Next


                    If dt(i, 2) = 1 Then

                        'find the path
                        str1 = "{"

                        'get first 
                        Dim j = i
                        str1 = str1 & dt(j, 1)

                        'get next
                        While dt(j, 1) <> 99
                            Dim k
                            k = 1
                            While dt(k, 0) <> dt(j, 1) And k < 50
                                k = k + 1
                            End While

                            If k = 50 Then
                                str1 = str1 & "N"
                                Exit While
                            End If

                            If dt(k, 1) <> 99 Then
                                str1 = str1 & ", "
                                str1 = str1 & dt(k, 1)
                            End If

                            j = k
                        End While

                        str1 = str1 & "}"

                        If Len(str1) >= 4 Then
                            str1 = Microsoft.VisualBasic.Left(str1, Len(str1) - 4) & "}"
                        Else
                            str1 = Microsoft.VisualBasic.Left(str1, Len(str1) - 3) & "N"
                        End If


                        rStr = rStr & dt(i, 0) & ":" & str1 & vbNewLine
                    End If
                Next

            End If


            rStr = rStr & vbNewLine
            gIndex = gIndex + dataN + 2

        Next

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call p1("in1.txt")
        rStr = rStr & vbNewLine
        Call p1("in2.txt")
        MsgBox(rStr)
        ' My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\out.txt", rStr, False)
        End
    End Sub
End Class
