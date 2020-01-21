Public Class Form1
    Dim A(3, 3) As TextBox
    Dim suval(,) As Integer = {{0, 2, 4, 0}, {3, 0, 0, 0}, {0, 0, 0, 1}, {0, 0, 0, 0}}

    Sub MyCheck(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t1, t2 As Integer  '宣告檢查行或列變數
        Dim ckstr As String    '宣告存放已經輸入的行值及列值
        t1 = Val(Microsoft.VisualBasic.Left(sender.name, 1))
        t2 = Val(Microsoft.VisualBasic.Right(sender.name, 1))
        '檢查水平和垂直是否相同
        ckstr = ""
        For i As Integer = 0 To 3         '將己填入水平值記錄到檢查字串
            If i <> t2 And A(t1, i).Text <> "" Then
                ckstr = ckstr & A(t1, i).Text
            End If
        Next
        For i As Integer = 0 To 3        '將己填入垂直值記錄到檢查字串
            If i <> t1 And A(i, t2).Text <> "" Then
                ckstr = ckstr & A(i, t2).Text
            End If
        Next
        If Val(A(t1, t2).Text) > 0 And Val(A(t1, t2).Text) < 5 Then '檢查是否重複
            If InStr(ckstr, A(t1, t2).Text) <> 0 Then
                A(t1, t2).Text = ""
                Label1.Text = "數字重複不可填入"
                A(t1, t2).BackColor = Color.Blue
            Else
                A(t1, t2).BackColor = Color.White
            End If
        Else
            A(t1, t2).Text = ""
            A(t1, t2).BackColor = Color.White
        End If
        '檢查是否完成工作
        t1 = 0
        For I As Integer = 0 To 3
            For J As Integer = 0 To 3
                If A(I, J).Text <> "" Then
                    t1 = t1 + 1
                End If
            Next
        Next
        If t1 = 16 Then
            Label1.Text = "完成了　真是厲害"
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim I, J As Integer
        For I = 0 To 3
            For J = 0 To 3
                A(I, J) = New TextBox()

                With A(I, J)
                    .Font = New Font(FontFamily.GenericSerif, 14.0F, FontStyle.Regular)
                    .Width = 40
                    .Height = 30
                    .Left = 40 + J * .Width + 5
                    .Top = 50 + I * .Height + 5
                    .BorderStyle = BorderStyle.FixedSingle
                    .AutoSize = False
                    .Name = I.ToString & J.ToString
                    .TextAlign = HorizontalAlignment.Center
                    .MaxLength = 1
                    If suval(I, J) <> 0 Then
                        .Text = suval(I, J).ToString
                        .Enabled = False
                    Else
                        .Text = ""
                    End If
                End With
                Me.Controls.Add(A(I, J))
                AddHandler A(I, J).TextChanged, AddressOf MyCheck
            Next
        Next

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        For I As Integer = 0 To 3
            For J As Integer = 0 To 3
                If suval(I, J) <> 0 Then
                    A(I, J).Text = suval(I, J).ToString
                Else
                    A(I, J).Text = ""
                End If
            Next
        Next

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
