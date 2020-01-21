Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.Show()
        NUpDownYear.Value = Now.Year
        NUpDownMonth.Value = Now.Month
        NUpDownDay.Value = Now.Day
        NUpDownHour.Value = Now.Hour
        NUpDownMinute.Value = Now.Minute
        NUpDownSecond.Value = Now.Second
    End Sub

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        temTime = New DateTime(NUpDownYear.Value, CInt(NUpDownMonth.Value), CInt(NUpDownDay.Value), CInt(NUpDownHour.Value), CInt(NUpDownMinute.Value), CInt(NUpDownSecond.Value))
        Form1.ListBox1.Items.Add(Format(temTime, "F"))
    End Sub
End Class