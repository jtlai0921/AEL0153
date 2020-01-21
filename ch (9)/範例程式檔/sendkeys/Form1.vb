Imports System.Threading
Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '呼叫Word2010去掉doc檔中的空白
        Dim procId As Integer = Shell("C:\Program Files (x86)\Microsoft Office\Office14\winword.exe d:\test1.doc", AppWinStyle.NormalFocus)
        AppActivate(procId)
        Thread.Sleep(1500)
        With My.Computer.Keyboard
            .SendKeys("^a")
            .SendKeys("^h")
            .SendKeys(" ")
            .SendKeys("{TAB 4}")
            .SendKeys("{ENTER}")
            .SendKeys("{TAB}")
            .SendKeys("{ENTER}")
            .SendKeys("{TAB 6}")
            .SendKeys("{ENTER}")
            .SendKeys("^s")
            .SendKeys("%{F4}")
        End With
    End Sub
End Class
