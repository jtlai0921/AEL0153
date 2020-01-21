Public Class Form1
    Function Checkid(ByVal PerID As String) As Boolean
        REM 檢查身份證號碼是否正確
        Dim EngArray As String     '定義身份證使用到的英文字串
        Dim PerIdTemp As Integer
        Dim PerIdChk1, PerIdChk2, PerIdChkSum As Integer
        Dim Loops As Integer

        REM 算出英文字母值
        EngArray = "ABCDEFGHJKLMNPQRSTUVXYWZIO"
        PerIdTemp = InStr(1, EngArray, Microsoft.VisualBasic.Left(PerID, 1)) + 9
        PerIdChk1 = (PerIdTemp \ 10) + (PerIdTemp Mod 10) * 9
        REM 取出數字，並計算數值部份加權值
        For Loops = 2 To 9
            PerIdChk2 = PerIdChk2 + Val(Mid(PerID, loops, 1)) * (10 - loops)
        Next
        PerIdChkSum = Val(Microsoft.VisualBasic.Right(PerID, 1))
        REM 全部值除以看是否整除
        If (PerIdChk1 + PerIdChk2 + PerIdChkSum) Mod 10 = 0 Then
            Checkid = True
        Else
            Checkid = False
        End If
    End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Len(TextBox1.Text) = 10 Then
            If Checkid(UCase(TextBox1.Text)) Then
                Label2.Text = "正確身份證號碼"
            Else
                Label2.Text = "錯誤身份證號碼"
            End If
        Else
            Label2.Text = "身份證號碼要 10 碼"
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
