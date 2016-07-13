Public Class frmCampoDeRecria

    Private Sub cmdInformacionCR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInformacionCR.Click
        frmInformacionCampoDeRecria.Show()

    End Sub

    Private Sub cmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click
        Me.Hide()
        frmMenuTambo.Show()


    End Sub

    Private Sub cmdVinculacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVinculacion.Click
        FrmVinculacionCR.Show()

    End Sub
End Class