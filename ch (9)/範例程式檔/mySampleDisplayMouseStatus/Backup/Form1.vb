Public Class Form1
    Dim str1 = ""
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        str1 = str1 & "Mouse 滾輪狀況：" & _
        IIf(My.Computer.Mouse.WheelExists, "有滾輪，每次滾：" & _
            My.Computer.Mouse.WheelScrollLines & "列", "無滾輪") & vbNewLine
        str1 = str1 & "Mouse 左右鍵交換狀況：" & _
        IIf(My.Computer.Mouse.ButtonsSwapped, "已交換", "未交換") & vbNewLine

        MsgBox(str1)
        End
    End Sub
End Class
