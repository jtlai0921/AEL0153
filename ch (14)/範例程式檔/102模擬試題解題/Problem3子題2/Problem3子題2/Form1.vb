Public Class Form1
    Dim str1 = ""

    Sub p1(ByVal infile)
        Dim fileContents As String
        fileContents = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & infile)
        Dim line() = Split(fileContents, vbNewLine)
        Dim recN = CInt(line(0))
        For i = 1 To recN
            line(i) = Replace(line(i), "{", ",")
            line(i) = Replace(line(i), "}", ",")
            line(i) = Replace(line(i), " ", "")
            Dim data() = Split(line(i), ",,,")
            Dim set1() = Split(data(0), ",")
            Dim set2() = Split(data(1), ",")

            Dim a1 As ArrayList = New ArrayList
            Dim a2 As ArrayList = New ArrayList
            For j = 0 To set1.Length - 1
                If set1(j) <> "" Then
                    a1.Add(CInt(set1(j)))
                End If
            Next
            For j = 0 To set2.Length - 1
                If set2(j) <> "" Then
                    a2.Add(CInt(set2(j)))
                End If
            Next

            Dim unionList As ArrayList = New ArrayList
            Dim interList As ArrayList = New ArrayList
            Dim diffList As ArrayList = New ArrayList

            unionList.AddRange(a1)
            diffList.AddRange(a1)

            For Each e2 In a2
                If a1.IndexOf(e2) <> -1 Then
                    interList.Add(e2)
                    diffList.Remove(e2)
                Else
                    unionList.Add(e2)
                End If
            Next

            unionList.Sort()
            Dim str2 = ""
            If unionList.Count = 0 Then
                str2 = str2 & "N, "
            Else
                str2 = str2 & "{"
                For Each e0 In unionList
                    str2 = str2 & e0 & ", "
                Next
                str2 = str2 & "}"
            End If

            interList.Sort()
            If interList.Count = 0 Then
                str2 = str2 & "N, "
            Else
                str2 = str2 & "{"
                For Each e0 In interList
                    str2 = str2 & e0 & ", "
                Next
                str2 = str2 & "}"
            End If

            diffList.Sort()
            If diffList.Count = 0 Then
                str2 = str2 & "N, "
            Else
                str2 = str2 & "{"
                For k = 0 To diffList.Count - 1
                    If k = diffList.Count - 1 Then
                        str2 = str2 & diffList.Item(k)
                    Else
                        str2 = str2 & diffList.Item(k) & ", "
                    End If

                Next
                str2 = str2 & "}"
            End If
            str2 = Replace(str2, ", }", "}, ")

            ' MsgBox(str2)

            str1 = str1 & str2 & vbNewLine
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call p1("in1.txt")
        str1 = str1 & vbNewLine
        Call p1("in2.txt")
        MsgBox(str1)
        'My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\out.txt", str1, False)
        End
    End Sub
End Class
