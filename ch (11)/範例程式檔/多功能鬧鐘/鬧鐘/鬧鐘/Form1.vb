Public Class Form1

    Dim temTime2 As Date
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Font = New System.Drawing.Font("Arial", 36, FontStyle.Bold)
        Timer1.Interval = 1000
        Timer1.Enabled = True
        Me.Size = New Size(316, 390)

        Label2.Font = New System.Drawing.Font("Arial", 20, FontStyle.Regular)
        ListBox1.Sorted = True
        playFlag = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = Format(Now(), "tt")
        Label1.Text = Format(Now(), "hh:mm:ss")

        If ListBox1.Items.Count <> 0 Then
            If Now() >= CDate(ListBox1.Items(0)) And Now() <= CDate(ListBox1.Items(0)).AddSeconds(10) And playFlag = False Then
                My.Computer.Audio.Play("..\..\Resources\test6.wav")
                playFlag = True
            End If
            If playFlag = True And Now() > CDate(ListBox1.Items(0)).AddSeconds(10) Then
                My.Computer.Audio.Stop()
                playFlag = False
                ListBox1.Items.RemoveAt(0)
                ListBox1.Refresh()
            End If
        End If
    End Sub
End Class
