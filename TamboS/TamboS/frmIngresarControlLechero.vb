Public Class frmIngresarControlLechero

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Me.Hide()
        If txtIdVaca.Text = "" Then
            MsgBox("Debe ingresar un id de vaca")
        End If

    End Sub

    Private Sub cmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click
        Me.Hide()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdVaca.TextChanged

    End Sub
End Class