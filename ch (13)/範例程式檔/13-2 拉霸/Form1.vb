Public Class Form1
    Dim lbl(3) As Label
    Dim n(3) As Integer
    Dim acc As Integer
    Dim s7 As Integer
    Dim flag10000 As Boolean = False
    Dim nRolling As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        acc = 1000
        lbl(1) = Label1
        lbl(2) = Label2
        lbl(3) = Label3
        Dim i As Integer
        For i = 1 To 3
            With lbl(i)
                .Text = i.ToString
                .Width = 30
                .Height = 50
                .Font = New System.Drawing.Font("arial", 60, FontStyle.Bold)
                .Left = 10 + (i - 1) * 80
                .Top = 10
                .BorderStyle = BorderStyle.FixedSingle
            End With
        Next
        With Label4
            .Text = "$" & acc
            .Font = New System.Drawing.Font("arial", 26, FontStyle.Bold)
            .ForeColor = Color.Red
        End With

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim generator As New Random
        Dim randomValue As Integer

        s7 = 0
        For i = 1 To 3
            randomValue = generator.Next(0, 9)
            n(i) = randomValue
            If n(i) = 7 Then s7 = s7 + 1
        Next
        acc = acc - 50
        If s7 = 1 Then acc = acc + 60
        If s7 = 2 Then acc = acc + 600
        If s7 = 3 Then acc = acc + 6000
        If flag10000 = False Then
            nRolling = 0
            roll()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer
        flag10000 = True
        For i = 1 To 9999
            Button1_Click(sender, e)
        Next
        flag10000 = False
        Button1_Click(sender, e)
    End Sub
    Sub roll()
        Label4.Text = Label4.Text & " 請稍候！"
        Timer1.Interval = 1000
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If nRolling >= n(1) And nRolling >= n(2) And nRolling >= n(3) Then
            Label4.Text = "$" & acc
            Timer1.Enabled = False
        End If

        Dim i As Integer
        For i = 1 To 3
            If n(i) >= nRolling Then lbl(i).Text = nRolling
        Next i
        nRolling = nRolling + 1
    End Sub
End Class
