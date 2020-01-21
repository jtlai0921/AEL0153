Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim Stu_Name(10) As String
        Dim Stu_Eng() As Integer = {100, 80, 89, 78, 98}
        Stu_Name(1) = "王大明"
        Stu_Name(4) = "李昇平"
        Stu_Name(10) = "何長春"
        Console.WriteLine(Stu_Name(1))
        Console.WriteLine(Stu_Name(2))
        Console.WriteLine(Stu_Name(4))

        For Each score As Integer In Stu_Eng
            MsgBox(score)
        Next score

    End Sub
End Class
