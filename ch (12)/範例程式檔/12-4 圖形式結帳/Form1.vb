Public Class Form1
    Dim pic As PictureBox
    Dim amount As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PictureBoxMouse.Image = System.Drawing.Image.FromFile("..\..\image\mouse.gif")
        PictureBoxSpeaker.Image = System.Drawing.Image.FromFile("..\..\image\speaker.gif")
        PictureBoxKeyboard.Image = System.Drawing.Image.FromFile("..\..\image\keyboard.gif")

        PictureBoxMouse.AllowDrop = True
        PictureBoxSpeaker.AllowDrop = True
        PictureBoxKeyboard.AllowDrop = True

        PictureBox4.AllowDrop = True
        PictureBox5.AllowDrop = True
        PictureBox6.AllowDrop = True
        PictureBox7.AllowDrop = True
        PictureBox8.AllowDrop = True

        Label1.Text = "$100"
        Label2.Text = "$200"
        Label3.Text = "$300"

        Label4.Text = ""
        amount = 0
        Label4.Font = New System.Drawing.Font("arial", 24)
        Label6.Text = "說明：以滑鼠拖曳物品" & vbLf & Space(11) & "至購物籃中即可" & vbLf & Space(11) & "完成結帳金額試" & vbLf & Space(11) & "算動作"
    End Sub

    Private Sub PictureBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxMouse.MouseDown, PictureBoxSpeaker.MouseDown, PictureBoxKeyboard.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            pic = CType(sender, PictureBox)
            pic.DoDragDrop(pic.Image, DragDropEffects.None)
        End If
    End Sub

    Private Sub PictureBox4_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox4.DragEnter
        If PictureBox4.Image Is Nothing Then
            PictureBox4.Image = pic.Image
            amount = amount + price(pic.Name)
            Label4.Text = "$" & amount
        End If

    End Sub

    Private Sub PictureBox5_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox5.DragEnter
        If PictureBox5.Image Is Nothing Then
            PictureBox5.Image = pic.Image
            amount = amount + price(pic.Name)
            Label4.Text = "$" & amount
        End If
    End Sub

    Private Sub PictureBox6_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox6.DragEnter
        If PictureBox6.Image Is Nothing Then
            PictureBox6.Image = pic.Image
            amount = amount + price(pic.Name)
            Label4.Text = "$" & amount
        End If
    End Sub

    Private Sub PictureBox7_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox7.DragEnter
        If PictureBox7.Image Is Nothing Then
            PictureBox7.Image = pic.Image
            amount = amount + price(pic.Name)
            Label4.Text = "$" & amount
        End If
    End Sub

    Private Sub PictureBox8_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox8.DragEnter
        If PictureBox8.Image Is Nothing Then
            PictureBox8.Image = pic.Image
            amount = amount + price(pic.Name)
            Label4.Text = "$" & amount
        End If
    End Sub

    Function price(ByVal x) As Integer
        If x = "PictureBoxMouse" Then price = 100
        If x = "PictureBoxSpeaker" Then price = 200
        If x = "PictureBoxKeyboard" Then price = 300
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class