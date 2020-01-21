Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '呼叫Word2003去掉doc檔中的空白
        Dim procId As Integer = Shell("C:\Program Files\Microsoft Office\OFFICE11\winword.exe d:\test1.doc", AppWinStyle.NormalFocus)
        AppActivate(procId)
        With My.Computer.Keyboard
            .SendKeys("^a")
            .SendKeys("^h")
            .SendKeys(" ")
            .SendKeys("{TAB 5}")
            .SendKeys("{ENTER}")
            .SendKeys("{TAB}")
            .SendKeys("{ENTER}")
            .SendKeys("{TAB 3}")
            .SendKeys("{ENTER}")
            .SendKeys("{LEFT}")
            .SendKeys("^s")
            .SendKeys("%{F4}")
        End With
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
