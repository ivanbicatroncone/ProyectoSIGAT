Public Class frmAlimentos

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub cmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click

        Me.Hide()
        frmAnimales.Show()

    End Sub

    Private Sub cmdIngresarAlimentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIngresarAlimentos.Click
        MsgBox("Alimentos ingresados con éxito")
        Me.Hide()
        frmAnimales.Show()
    End Sub
End Class