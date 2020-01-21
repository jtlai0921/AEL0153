Public Class Form1

    Dim btn(9) As Button
    Dim oxFlag As Boolean
    Dim sco(9) As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn(1) = Button1
        btn(2) = Button2
        btn(3) = Button3
        btn(4) = Button4
        btn(5) = Button5
        btn(6) = Button6
        btn(7) = Button7
        btn(8) = Button8
        btn(9) = Button9

        Dim i As Integer
        For i = 1 To 9
            With btn(i)
                .Height = btn(i).Width
                .Left = ((i - 1) Mod 3) * btn(1).Width + 30
                .Top = ((i - 1) \ 3) * btn(1).Height + 30
                .Text = ""
                .Font = New System.Drawing.Font("Arial", 36)
            End With
            sco(i) = 0
        Next
        oxFlag = True
        Label1.Text = ""
        Label1.Font = New System.Drawing.Font("新細明體", 20)

        Button10.Text = "重新開始"
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, _
    Button6.Click, Button7.Click, Button8.Click, Button9.Click

        Dim no As Integer = Microsoft.VisualBasic.Right((CType(sender, Button).Name), 1)
        If oxFlag = True Then
            btn(no).Text = "○"
            sco(no) = 1
        Else
            btn(no).Text = "×"
            sco(no) = 2
        End If
        oxFlag = Not oxFlag

        If sco(1) * sco(2) * sco(3) = 1 Then Label1.Text = "○贏！"
        If sco(4) * sco(5) * sco(6) = 1 Then Label1.Text = "○贏！"
        If sco(7) * sco(8) * sco(9) = 1 Then Label1.Text = "○贏！"

        If sco(1) * sco(4) * sco(7) = 1 Then Label1.Text = "○贏！"
        If sco(2) * sco(5) * sco(8) = 1 Then Label1.Text = "○贏！"
        If sco(3) * sco(6) * sco(9) = 1 Then Label1.Text = "○贏！"

        If sco(1) * sco(5) * sco(9) = 1 Then Label1.Text = "○贏！"
        If sco(3) * sco(5) * sco(7) = 1 Then Label1.Text = "○贏！"

        If sco(1) * sco(2) * sco(3) = 8 Then Label1.Text = "×贏！"
        If sco(4) * sco(5) * sco(6) = 8 Then Label1.Text = "×贏！"
        If sco(7) * sco(8) * sco(9) = 8 Then Label1.Text = "×贏！"

        If sco(1) * sco(4) * sco(7) = 8 Then Label1.Text = "×贏！"
        If sco(2) * sco(5) * sco(8) = 8 Then Label1.Text = "×贏！"
        If sco(3) * sco(6) * sco(9) = 8 Then Label1.Text = "×贏！"

        If sco(1) * sco(5) * sco(9) = 8 Then Label1.Text = "×贏！"
        If sco(3) * sco(5) * sco(7) = 8 Then Label1.Text = "×贏！"

        If Label1.Text <> "" Then
            Dim i As Integer
            For i = 1 To 9
                btn(i).Enabled = False
            Next
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim i As Integer
        For i = 1 To 9
            With btn(i)
                .Enabled = True
                .Text = ""
            End With
            sco(i) = 0
        Next
        Label1.Text = ""
    End Sub
End Class
