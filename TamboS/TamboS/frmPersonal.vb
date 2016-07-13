Public Class frmPersonal

    Private Sub cmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click
        Me.Hide()
        frmAdministracionCooperativa.Show()

    End Sub

    Private Sub cmdInformaciónPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInformaciónPersonal.Click
        frmInformaciónPersonal.Show()

    End Sub

    Private Sub cmdIngresarPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIngresarPersonal.Click
        frmIngresarPersonal.Show()

    End Sub
End Class