Public Class frmParametros

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

        If dtSegundoOrdeñe.Value < dtPrimerOrdeñe.Value Then

            MsgBox("El segundo ordeñe no puede realizarse antes del primero")

        Else
            MsgBox("Parámetro guardado")
            Me.Close()

        End If




    End Sub

    Private Sub cmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click
        Me.Close()
    End Sub

    Private Sub dtPrimerOrdeñe_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtPrimerOrdeñe.ValueChanged

    End Sub
End Class