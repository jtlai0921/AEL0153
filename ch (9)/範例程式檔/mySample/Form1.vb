Public Class Form1
    Dim str1 = ""
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        str1 = str1 & "作業系統全名：" & _
        My.Computer.Info.OSFullName & vbNewLine
        str1 = str1 & "作業系統平台：" & _
        My.Computer.Info.OSPlatform & vbNewLine
        str1 = str1 & "作業系統版本：" & _
        My.Computer.Info.OSVersion & vbNewLine

        str1 = str1 & "是否為系統管理員：" & _
        IIf(My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator), "是", "否") & vbNewLine
        str1 = str1 & "現在時間：" & _
        My.Computer.Clock.LocalTime & vbNewLine

        str1 = str1 & "軟體版本：" & _
        My.Application.Info.Version.ToString & vbNewLine
        str1 = str1 & "軟體名稱：" & _
        My.Application.Info.Title & vbNewLine

        str1 = str1 & "全部的實體記憶空間：" & _
        Format(My.Computer.Info.TotalPhysicalMemory, "N0") & vbNewLine
        str1 = str1 & "可用的實體記憶空間：" & _
        Format(My.Computer.Info.AvailablePhysicalMemory, "N0") & vbNewLine
        str1 = str1 & "全部虛擬記憶空間：" & _
        Format(My.Computer.Info.TotalVirtualMemory, "N0") & vbNewLine
        str1 = str1 & "可用虛擬記憶空間：" & _
        Format(My.Computer.Info.AvailableVirtualMemory, "N0") & vbNewLine


        str1 = str1 & "我的文件路徑：" & _
        My.Computer.FileSystem.SpecialDirectories.MyDocuments & vbNewLine
        str1 = str1 & "我的音樂路徑：" & _
        My.Computer.FileSystem.SpecialDirectories.MyMusic & vbNewLine
        str1 = str1 & "我的圖片路徑：" & _
        My.Computer.FileSystem.SpecialDirectories.MyPictures & vbNewLine

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

        str1 = str1 & "Mouse 滾輪狀況：" & _
        IIf(My.Computer.Mouse.WheelExists, "有滾輪，每次滾：" & _
            My.Computer.Mouse.WheelScrollLines & "列", "無滾輪") & vbNewLine
        str1 = str1 & "Mouse 左右鍵交換狀況：" & _
        IIf(My.Computer.Mouse.ButtonsSwapped, "已交換", "未交換") & vbNewLine

        MsgBox(str1)
        End
    End Sub
End Class
