Public Class Form1
    Dim str1 = ""
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        str1 = str1 & "CapsLock鍵 目前狀況：" & _
        IIf(My.Computer.Keyboard.CapsLock, "按下", "未按下") & vbNewLine
        str1 = str1 & "Alt鍵 目前狀況：" & _
        IIf(My.Computer.Keyboard.AltKeyDown, "按下", "未按下") & vbNewLine
        str1 = str1 & "Ctrl鍵 目前狀況：" & _
        IIf(My.Computer.Keyboard.CtrlKeyDown, "按下", "未按下") & vbNewLine
        str1 = str1 & "NUmLock鍵 目前狀況：" & _
        IIf(My.Computer.Keyboard.NumLock, "按下", "未按下") & vbNewLine
        str1 = str1 & "ScrollLock鍵 目前狀況：" & _
        IIf(My.Computer.Keyboard.ScrollLock, "按下", "未按下") & vbNewLine
        str1 = str1 & "ShiftKeyDown鍵 目前狀況：" & _
        IIf(My.Computer.Keyboard.ShiftKeyDown, "按下", "未按下") & vbNewLine

        MsgBox(str1)
        End
    End Sub
End Class
