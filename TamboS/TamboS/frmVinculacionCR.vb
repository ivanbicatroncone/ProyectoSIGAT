Public Class FrmVinculacionCR

    Private Sub cmdEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnviar.Click
        frmEnviarAnimales.Show()


    End Sub

    Private Sub cmdRecibirAnimales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRecibirAnimales.Click
        frmRecibirAnimales.Show()

    End Sub

    Private Sub cmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click
        Me.Hide()
        frmCampoDeRecria.Show()

    End Sub
End Class