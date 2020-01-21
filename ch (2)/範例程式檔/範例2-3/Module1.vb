Module Module1

    Sub Main()
        Dim a As Single = 32
        Dim b As Single = 24
        Dim strA As String = "32"
        Dim strB As String = "24"
        Console.WriteLine("a + b= {0}", a + b)
        Console.WriteLine("a & b= {0}", a & b)
        Console.WriteLine("strA + strB= {0}", strA + strB)
        Console.WriteLine("strA & strB= {0}", strA & strB)
        Console.WriteLine("a + strB= {0}", a + strB)
        Console.WriteLine("a & strB= {0}", a & strB)
        Console.ReadLine()
    End Sub

End Module
