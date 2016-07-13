Public Class frmMenuTambo

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Tabla.Paint

    End Sub

    Private Sub cmdCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrarSesion.Click
        Me.Hide()
        frmLogin.Show()

    End Sub

    Private Sub cmdAnimales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnimales.Click
        Me.Hide()
        frmAnimales.Show()

    End Sub

    Private Sub cmdProduccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProduccion.Click
        Me.Hide()
        frmProduccion.Show()
    End Sub

    Private Sub ParámetrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParámetrosToolStripMenuItem.Click
        frmParametros.Show()
    End Sub

    Private Sub cmdCampoDeRecria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCampoDeRecria.Click
        Me.Hide()
        frmCampoDeRecria.Show()

    End Sub

    Private Sub cmdReproducción_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReproducción.Click
        Me.Hide()
        frmReproduccion.Show()

    End Sub
End Class