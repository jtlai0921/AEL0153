Imports System.IO
Public Class Form1
    Dim sum As Long
    Dim outStr As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each drive As DriveInfo In My.Computer.FileSystem.Drives
            If drive.IsReady Then
                Dim str1 = drive.Name & " " & FormatNumber(drive.TotalSize, 0)
                sum = sum + drive.TotalSize
                outStr = outStr & str1 & vbNewLine
            End If
        Next
        outStr = outStr & "Total:" & FormatNumber(sum, 0)
        MsgBox(outStr)
    End Sub
End Class