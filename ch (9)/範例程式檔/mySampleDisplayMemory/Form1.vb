Public Class Form1
    Dim str1 = ""
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        
        str1 = str1 & "全部的實體記憶空間：" & _
        Format(My.Computer.Info.TotalPhysicalMemory, "N0") & vbNewLine
        str1 = str1 & "可用的實體記憶空間：" & _
        Format(My.Computer.Info.AvailablePhysicalMemory, "N0") & vbNewLine
        str1 = str1 & "全部虛擬記憶空間：" & _
        Format(My.Computer.Info.TotalVirtualMemory, "N0") & vbNewLine
        str1 = str1 & "可用虛擬記憶空間：" & _
        Format(My.Computer.Info.AvailableVirtualMemory, "N0") & vbNewLine

        MsgBox(str1)
        End
    End Sub
End Class

