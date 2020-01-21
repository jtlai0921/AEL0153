Public Class truck
    Inherits Car
    Public loading As Long

    Public Overrides Function display()
        Dim s As String = ""
        s = "本卡車為" & Brand & "廠牌，" & vbNewLine
        s = s & cc & "CC" & vbNewLine
        s = s & "目前載重量為" & loading & "噸" & vbNewLine
        If loading > 10 Then
            s = s & "已經超重"
        Else
            s = s & "載重符合規定"
        End If
        Return s
    End Function
End Class
