Public Class Form1
    Dim rStr = ""
    Sub p1(ByVal infile As String)
        Dim dt(50, 3) As Integer
        Dim fileContents As String
        fileContents = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & infile)
        Dim line() = Split(fileContents, vbNewLine)

        Dim dataN = CInt(line(0))

        '  For n As Integer = 0 To dataN - 1

        For m As Integer = 1 To 2

            Dim dt1() = Split(line(m), " ")

            Dim i = 0
            Do
                Dim d() = Split(dt1(i), "-")
                dt(i, 0) = CInt(d(0))
                dt(i, 1) = CInt(d(1))
                i = i + 1
            Loop While (i < dt1.Length)

            '
            Dim str1 = ""

            Dim j
            For i = 0 To dt1.Length - 1
                dt(i, 2) = 0
                dt(i, 3) = 0
                For j = 0 To dt1.Length - 1
                    If dt(i, 0) = dt(j, 0) Then dt(i, 2) = dt(i, 2) + 1
                    If dt(i, 0) = dt(j, 1) Then dt(i, 2) = dt(i, 2) + 1

                    If dt(i, 1) = dt(j, 0) Then dt(i, 3) = dt(i, 3) + 1
                    If dt(i, 1) = dt(j, 1) Then dt(i, 3) = dt(i, 3) + 1
                Next
            Next

            Dim innerNode(50)
            j = 0

            For i = 0 To dt1.Length - 1
                If dt(i, 2) <> 1 Then
                    If Array.IndexOf(innerNode, dt(i, 0)) = -1 Then
                        innerNode(j) = dt(i, 0)
                        j = j + 1
                    End If

                End If

                If dt(i, 3) <> 1 Then
                    If Array.IndexOf(innerNode, dt(i, 1)) = -1 Then
                        innerNode(j) = dt(i, 1)
                        j = j + 1
                    End If
                End If
            Next

            Array.Sort(innerNode)
            Array.Reverse(innerNode)
            For i = j - 1 To 0 Step -1
                If i <> 0 Then
                    str1 = str1 & innerNode(i) & ", "
                Else
                    str1 = str1 & innerNode(i)
                End If

            Next

            rStr = rStr & str1
            rStr = rStr & vbNewLine
        Next
        ' Next
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

