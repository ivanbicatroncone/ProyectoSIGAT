Public Class frmControlLechero

    Private Sub cmdNuevoControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevoControl.Click
        frmIngresarControlLechero.Show()

    End Sub

    Private Sub cmdBuscarControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarControl.Click
        frmBuscarControlLechero.Show()


    End Sub

    Private Sub cmdAtras_Click(sender As Object, e As EventArgs) Handles cmdAtras.Click
        Me.Hide()
        frmProduccion.Show()

    End Sub
End Class