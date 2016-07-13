Public Class frmInformaciónLotes

    Private Sub frmInformaciónLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        lblInfoVacas.Visible = True

        TablaVaca.Visible = True
    End Sub

    Private Sub TablaVaca_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TablaVaca.CellContentClick

    End Sub

    Private Sub cmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click
        Me.Hide()
        frmLotes.Show()

    End Sub
End Class