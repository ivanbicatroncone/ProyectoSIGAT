Public Class frmOrdeñe

    Private Sub cmdGuardarCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardarCambios.Click

        If cbHora.SelectedItem = "" Then
            MsgBox("Debe ingresar una hora de ordeñe")

        Else

            MsgBox("Guardado con éxito")

        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbHora.SelectedIndexChanged, cbHoraBusqueda.SelectedIndexChanged

    End Sub

    Private Sub cmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFechaOrdeñe.ValueChanged, DateOrdeñeBusqueda.ValueChanged

    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If cbHoraBusqueda.SelectedItem = "" Then
            MsgBox("Debe seleccionar una hora para buscar")

        ElseIf cbHoraBusqueda.SelectedItem = "Mañana" Then
            TablaOrdeñes.Visible = True
        ElseIf cbHoraBusqueda.SelectedItem = "Tarde" Then
            TablaOrdeñes.Visible = True



        End If
    End Sub
End Class