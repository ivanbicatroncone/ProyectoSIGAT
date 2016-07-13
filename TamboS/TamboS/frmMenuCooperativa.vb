Public Class frmMenuCooperativa

    Private Sub cmdTambo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTambo1.Click
        Me.Hide()

        frmMenuTambo.Show()

    End Sub

    Private Sub cmdTambo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTambo2.Click
        Me.Hide()
        frmMenuTambo.Show()

    End Sub

    Private Sub cmdAdministracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdministracion.Click
        Me.Hide()

        frmAdministracionCooperativa.Show()

    End Sub

    Private Sub cmdCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrarSesion.Click
        Me.Hide()
        frmLogin.Show()

    End Sub
End Class