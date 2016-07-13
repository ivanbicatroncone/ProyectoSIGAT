Public Class frmModificarAnimal

    Private Sub cmdBuscarModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarModificar.Click
        gbModificar.Visible = True

    End Sub

   

    Private Sub cmdGuardarCambios_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardarCambios.Click
        MsgBox("Cambios guardados con éxito")
        Me.Hide()
    End Sub

    Private Sub cmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click
        Me.Hide()

    End Sub

    Private Sub cbSecado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSecado.SelectedIndexChanged
        If cbSecado.SelectedItem = "Si" Then

            gbSecado.Visible = True
        End If

    End Sub
End Class