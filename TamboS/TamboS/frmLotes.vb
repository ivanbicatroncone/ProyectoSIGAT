Public Class frmLotes

    Private Sub cmdIngresarLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIngresarLote.Click

        frmIngresarLote.Show()

    End Sub

    Private Sub cmdTambo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTambo2.Click
        Me.Hide()
        frmInformaciónLotes.Show()

    End Sub

    Private Sub cmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click
        Me.Hide()
        frmProduccion.Show()

    End Sub
End Class