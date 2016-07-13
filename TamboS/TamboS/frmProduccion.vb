Public Class frmProduccion

    Private Sub cmdProduccionPorLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIngresarLote.Click
        Me.Hide()

        frmLotes.Show()


    End Sub

    Private Sub cmdTambo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLeche.Click
        frmInformacionLeche.Show()

    End Sub

    Private Sub cmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click
        Me.Hide()
        frmMenuTambo.Show()

    End Sub

    Private Sub cmdOrdeñe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOrdeñe.Click
        frmOrdeñe.Show()

    End Sub

    Private Sub cmdControlLechero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdControlLechero.Click
        Me.Hide()

        frmControlLechero.Show()

    End Sub
End Class