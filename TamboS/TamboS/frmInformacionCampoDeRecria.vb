Public Class frmInformacionCampoDeRecria

    Private Sub cmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click
        Me.Close()


    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        MsgBox("Información del Campo de Recria guardada")
        Me.Hide()

    End Sub
End Class