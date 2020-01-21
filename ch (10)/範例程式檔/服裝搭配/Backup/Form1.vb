Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RBtnRedHat.Checked = True
        RBtnBlueBlouse.Checked = True
        RBtnWhiteShoes.Checked = True
        Me.BackgroundImage = My.Resources.initial
    End Sub

    Private Sub RBtnGreenBlouse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnGreenBlouse.CheckedChanged
        PBoxBlouse.Image = My.Resources.greenBlouse
    End Sub

    Private Sub RBtnYellowBlouse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnYellowBlouse.CheckedChanged
        PBoxBlouse.Image = My.Resources.yellowBlouse
    End Sub

    Private Sub RBtnBlueBlouse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnBlueBlouse.CheckedChanged
        PBoxBlouse.Image = My.Resources.blueBlouse
    End Sub

    Private Sub RBtnBlueShoes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnBlueShoes.CheckedChanged
        PBoxShoes.Image = My.Resources.blueShoes
    End Sub

    Private Sub RBtnRedShoes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnRedShoes.CheckedChanged
        PBoxShoes.Image = My.Resources.redShoes
    End Sub

    Private Sub RBtnWhiteShoes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnWhiteShoes.CheckedChanged
        PBoxShoes.Image = My.Resources.whiteShoes
    End Sub

    Private Sub RBtnYellowHat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnYellowHat.CheckedChanged
        PBoxHat.Image = My.Resources.yellowHat
    End Sub

    Private Sub RBtnRedHat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnRedHat.CheckedChanged
        PBoxHat.Image = My.Resources.redHat
    End Sub

    Private Sub RBtnBlueHat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnBlueHat.CheckedChanged
        PBoxHat.Image = My.Resources.BlueHat
    End Sub
End Class
