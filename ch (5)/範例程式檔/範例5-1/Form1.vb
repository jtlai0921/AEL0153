Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mycar1 As New Car
        Dim mycar2 As New Car
        mycar1.Brand = "Nissan"
        mycar1.cc = 2400
        mycar1.Seats = 4
        mycar1.Model = "X Trail"
        TextBox1.Text = mycar1.Display()
        mycar2.Brand = "Ford"
        mycar2.cc = 2300
        mycar2.Model = "Escape"
        mycar2.Seats = 5
        TextBox2.Text = mycar2.Display

    End Sub
End Class
