Public Class Car
    '以下定義屬性
    Public Brand As String
    Public Model As String
    Public Seats As Integer
    Public cc As Integer

    '以下定義方法
    Public Overridable Function Display()
        Dim s As String = ""
        s = "本車為" & Brand & "廠牌，" & vbNewLine
        s = s & "車型為" & Model & "，" & vbNewLine
        s = s & Seats & "人座，" & cc & "CC"
        Return s
    End Function

End Class
