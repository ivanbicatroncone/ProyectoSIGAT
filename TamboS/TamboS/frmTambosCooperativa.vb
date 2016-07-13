Public Class frmTambosCooperativa

    Private Sub cmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click
        Me.Hide()
        frmAdministracionCooperativa.Show()

    End Sub

    Private Sub cmdTambo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInfoTambo1.Click


        frmInformacionTambos.Show()

    End Sub

    Private Sub cmdConfiguracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInfoTambo2.Click

        frmInformacionTambos.Show()

    End Sub
End Class