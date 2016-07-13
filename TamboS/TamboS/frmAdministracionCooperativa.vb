Public Class frmAdministracionCooperativa

    Private Sub cmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click
        Me.Hide()
        frmMenuCooperativa.Show()

    End Sub

    Private Sub cmdPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPersonal.Click
        Me.Hide()

        frmPersonal.Show()

    End Sub

    Private Sub cmdTambos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTambos.Click
        Me.Hide()
        frmTambosCooperativa.Show()

    End Sub
End Class