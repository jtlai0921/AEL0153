Module Module1

    Sub Main()
        Dim opr As Integer
        Dim op1, op2, op3 As Single

        Console.WriteLine("－－－簡易四則運算－－－")
        Console.WriteLine("請輸入第１個數字：")
        op1 = Console.ReadLine()
        Console.WriteLine("請輸入第２個數字：")
        op2 = Console.ReadLine()
        Console.WriteLine("選擇那一種運算：1.＋ 2.－ 3.× 4.÷ ：")
        opr = Console.ReadLine()
        op3 = Choose(opr, op1 + op2, op1 - op2, op1 * op2, op1 / op2)
        Console.WriteLine("計算結果：{0}", op3)
        Console.ReadLine()
    End Sub

End Module
