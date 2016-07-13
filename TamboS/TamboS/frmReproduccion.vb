Public Class frmReproduccion

    Private Sub cbTipoReproduccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoReproduccion.SelectedIndexChanged
        If cbTipoReproduccion.SelectedItem = "Entore" Then
            gbToro.Visible = True
        End If
    End Sub

    Private Sub cmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click
        Me.Hide()
        frmMenuTambo.Show()


    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        MsgBox("Guardado")
        Me.Hide()
        frmMenuTambo.Show()



    End Sub

    Private Sub txtIdToro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdToro.TextChanged, txtIdVaca.TextChanged

    End Sub

    Private Sub gbToro_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbToro.Enter

    End Sub
End Class