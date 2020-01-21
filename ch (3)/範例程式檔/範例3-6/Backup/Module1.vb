Module Module1

    Sub Main()
        Dim a As Integer
        Dim str1 As String
        Console.WriteLine("請輸入客戶身份代碼：")
        a = Console.ReadLine()

        '    str1 = Switch(a = 1, "一般客戶", a = 2, "金卡客戶", a = 3, "白金卡客戶")
        str1 = Microsoft.VisualBasic.Switch(a = 1, "一般客戶", a = 2, "金卡客戶", a = 3, "白金卡客戶")
        Console.WriteLine(str1)
        Console.ReadLine()
    End Sub

End Module
