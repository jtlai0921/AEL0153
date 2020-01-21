Public Class Form1
    Dim dirN As Integer
    Dim accelerate As Integer
    Dim xMove, yMove As Integer

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                dirN = dirN - 1
            Case Keys.Right
                dirN = dirN + 1
            Case Keys.Up
                accelerate = accelerate + 1
            Case Keys.Down
                accelerate = accelerate - 1
        End Select
        If accelerate < 0 Then accelerate = 0
        If dirN < 0 Then dirN = dirN + 8
        If dirN > 7 Then dirN = dirN - 8
        flyPB.Image = ImageList1.Images.Item(dirN)
        Select Case dirN
            Case 0
                xMove = 0 : yMove = -1 : flyPB.Size = New Size(70, 80)
            Case 1
                xMove = 1 : yMove = -1 : flyPB.Size = New Size(84, 96)
            Case 2
                xMove = 1 : yMove = 0 : flyPB.Size = New Size(70, 80)
            Case 3
                xMove = 1 : yMove = 1 : flyPB.Size = New Size(84, 96)
            Case 4
                xMove = 0 : yMove = 1 : flyPB.Size = New Size(70, 80)
            Case 5
                xMove = -1 : yMove = 1 : flyPB.Size = New Size(84, 96)
            Case 6
                xMove = -1 : yMove = 0 : flyPB.Size = New Size(70, 80)
            Case 7
                xMove = -1 : yMove = -1 : flyPB.Size = New Size(84, 96)
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        Timer1.Enabled = True
        dirN = 0
        accelerate = 1
        Label1.Text = "說明：" & vbLf & vbLf & "↑加速" & vbLf & vbLf & "↓減速" & vbLf & vbLf & "←左轉" & vbLf & vbLf & "→右轉"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If flyPB.Left > Me.Width Then flyPB.Left = 0
        If flyPB.Left < 0 Then flyPB.Left = Me.Width
        If flyPB.Top < 0 Then flyPB.Top = Me.Height
        If flyPB.Top > Me.Height Then flyPB.Top = 0

        Dim temX, temY As Integer
        temX = flyPB.Left + xMove * accelerate
        temY = flyPB.Top + yMove * accelerate
        flyPB.Location = New Point(temX, temY)
    End Sub

    Private Sub flyPB_Click(sender As Object, e As EventArgs) Handles flyPB.Click

    End Sub
End Class
