Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mycar1 As New Car
        Dim mytruck1 As New truck
        mycar1.Brand = "Nissan"
        mycar1.cc = 2400
        mycar1.Seats = 4
        mycar1.Model = "X Trail"
        TextBox1.Text = mycar1.Display()
        mytruck1.Brand = "Ford"
        mytruck1.cc = 4600
        mytruck1.loading = 11
        TextBox2.Text = mytruck1.display
    End Sub
End Class
