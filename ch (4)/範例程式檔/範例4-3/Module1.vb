Module Module1

    Sub Main()
        Dim N As Integer
        Dim sum As Long
        Console.WriteLine("請輸入天數：")
        N = Val(Console.ReadLine)
        For i As Integer = 1 To N
            sum = sum + 2 ^ (i - 1)
        Next
        Console.WriteLine("共有 {0}個金幣", sum)
        Console.ReadLine()
    End Sub

End Module
