Public Class Form1
    Dim bX, bY As Integer
    Dim startX As Integer = 40
    Dim startY As Integer = 352
    Dim directFlag As Char = "R"
    Dim bImage As Image
    Dim accTurn As Integer
    Dim accSec As Single
    Dim firstFlag As Boolean = True
    Dim w1 As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        Timer1.Interval = 50

        accTurn = 0
        accSec = 0
        Label1.Text = "跑完" & accTurn & "圈"
        Label2.Text = "累計秒數：" & accSec

        ListBox1.Sorted = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Me.Refresh()

        If bX > 490 And bY > 330 Then
            directFlag = "U"
        End If
        If bX > 490 And bY < 30 Then
            directFlag = "L"
        End If
        If bX < 30 And bY < 30 Then
            directFlag = "D"
        End If
        If bX < 30 And bY > 330 Then
            directFlag = "R"
            accTurn = accTurn + 1
            Label1.Text = "跑完" & accTurn & "圈"
            bX = 30
            If accTurn >= 2 Then
                Button1.Visible = True
                ListBox1.Items.Add(accSec.ToString)
                Timer1.Enabled = False
            End If
        End If

        go1(directFlag)

        accSec = accSec + Timer1.Interval / 1000
        Label2.Text = "累計秒數：" & accSec
    End Sub
    Sub go1(ByVal directFlag)
        Dim generator As New Random
        Dim bRV As Integer
        bRV = generator.Next(1, 30)
        If directFlag = "R" Then
            bX = bX + bRV
            w1 = 236
        End If
        If directFlag = "U" Then
            bY = bY - bRV
            w1 = 136
        End If
        If directFlag = "L" Then
            bX = bX - bRV
            w1 = 236
        End If
        If directFlag = "D" Then
            bY = bY + bRV
            w1 = 136
        End If
        Dim temStr As String = "..\..\Car" & directFlag & ".gif"
        bImage = Image.FromFile(temStr)
        Dim g As Graphics = Me.CreateGraphics

        g.DrawImage(bImage, bX, bY, w1, 72)
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Me.Size = New Size(700, 500)
        Dim g As Graphics = e.Graphics
        g.DrawRectangle(New Pen(Color.Blue, 2), 20 + 140, 20 + 130, 580 - 260, 400 - 260)
        If firstFlag = True Then
            bImage = Image.FromFile("..\..\carR.gif")
            bX = startX
            bY = startY
            g.DrawImage(bImage, bX, bY, 236, 65)
            firstFlag = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Button1.Visible = False
        Me.Form1_Load(sender, e)
    End Sub
End Class
