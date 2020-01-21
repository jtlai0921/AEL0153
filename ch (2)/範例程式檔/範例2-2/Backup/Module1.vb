Module Module1

    Sub Main()
        Dim s1 As Single
        Dim s2 As Double
        s1 = 1.1234567 : s2 = 1.1234567
        Console.WriteLine("原始數值1.1234567")
        Console.WriteLine("Single: {0}", s1)
        Console.WriteLine("Double: {0}", s2)
        Console.WriteLine("=====================")
        s1 = 1234567890 : s2 = 1234567890
        Console.WriteLine("原始數值1234567890")
        Console.WriteLine("Single: {0}", s1)
        Console.WriteLine("Double: {0}", s2)
        Console.WriteLine("=====================")
        s1 = 0.123456789 : s2 = 0.123456789
        Console.WriteLine("原始數值0.123456789")
        Console.WriteLine("Single: {0}", s1)
        Console.WriteLine("Double: {0}", s2)
        Console.WriteLine("=====================")
        s1 = 0.000000001234567 : s2 = 0.000000001234567
        Console.WriteLine("原始數值0.000000001234567")
        Console.WriteLine("Single: {0}", s1)
        Console.WriteLine("Double: {0}", s2)
        Console.WriteLine("=====================")
        s1 = 123456789012 : s2 = 123456789012
        Console.WriteLine("原始數值123456789012")
        Console.WriteLine("Single: {0}", s1)
        Console.WriteLine("Double: {0}", s2)
        Console.ReadLine()
    End Sub

End Module
