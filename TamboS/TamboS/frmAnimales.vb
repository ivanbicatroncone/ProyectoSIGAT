Public Class frmAnimales

    Private Sub cmdCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click

        Me.Hide()
        frmMenuTambo.Show()

    End Sub

    Private Sub cmdTambo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIngresar.Click
        frmAgregarAnimal.Show()
    End Sub

    Private Sub cmdTambo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        frmModificarAnimal.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlimentos.Click
        frmAlimentos.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMedicamentos.Click
        frmMedicamentos.Show()
    End Sub

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Tabla.Paint

    End Sub

    Private Sub lblBuscarAnimalId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdBuscarAnimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblIdAnimalBuscar.Click

    End Sub

    Private Sub cmdBuscarAnimal_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarAnimal.Click

        If txtIdAnimalBuscar.Text = "" Then
            MsgBox("Debe ingresar un id para buscar")

        Else
            frmInformacionAnimales.Show()
        End If
    End Sub
End Class