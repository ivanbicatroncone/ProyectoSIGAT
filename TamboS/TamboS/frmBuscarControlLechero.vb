Public Class frmBuscarControlLechero

    Private Sub cbBusqueda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBusqueda.SelectedIndexChanged
        If cbBusqueda.SelectedItem = "Por vaca" Then
            lblFecha.Visible = False
            FechaControlLechero.Visible = False
            tablaPorFecha.Visible = False
            lblIdVaca.Visible = True
            txtIdVaca.Visible = True
            tablaPorVaca.Visible = True

        ElseIf cbBusqueda.SelectedItem = "Por fecha" Then
            lblIdVaca.Visible = False
            txtIdVaca.Visible = False
            tablaPorVaca.Visible = False
            lblFecha.Visible = True
            FechaControlLechero.Visible = True
            tablaPorFecha.Visible = True
        End If
    End Sub

    Private Sub cmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click
        Me.Hide()
    End Sub
End Class