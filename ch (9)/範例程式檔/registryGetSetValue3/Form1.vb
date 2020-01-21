
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        '讀出顯示原設定值
        Dim readValue As Object
        readValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Notepad\DefaultFonts", "lfFaceName", Nothing)
        MsgBox("目前字體為: " & CStr(readValue))

        '更改設定值        
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Notepad\DefaultFonts", "lfFaceName", "微軟正黑體")
       

        '讀出顯示更改後的設定值
        readValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Notepad\DefaultFonts", "lfFaceName", Nothing)
        MsgBox("目前字體更改為: " & CStr(readValue))

        '改回設定值        
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Notepad\DefaultFonts", "lfFaceName", "新細明體")

        '讀出顯示更改後的設定值
        readValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Notepad\DefaultFonts", "lfFaceName", Nothing)
        MsgBox("目前字體再改為: " & CStr(readValue))

        End
    End Sub
End Class

