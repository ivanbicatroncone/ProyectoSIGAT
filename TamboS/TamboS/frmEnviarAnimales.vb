Public Class frmEnviarAnimales

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnviar.Click
        MsgBox("Guardado")
        Me.Hide()


    End Sub

    Private Sub cmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click
        Me.Hide()

    End Sub
End Class