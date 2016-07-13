Public Class frmInformaciónPersonal

    Private Sub frmInformaciónPersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If txtLogin.Text = "" Then
            MsgBox("Debe ingresar un login para bsucar")

        Else
            lblCalle.Visible = True
            lblCI.Visible = True
            lblEsquina.Visible = True
            lblLogin.Visible = True
            lblNroPuert.Visible = True
            lblPrimApe.Visible = True
            lblPrimNombr.Visible = True
            lblRol.Visible = True
            lblSegApe.Visible = True
            lblSegNombr.Visible = True
            lblTel.Visible = True
            txtCalle.Visible = True
            txtCi.Visible = True
            txtEsquina.Visible = True
            txtLogin.Visible = True
            txtNroPuert.Visible = True
            txtPrimApe.Visible = True
            txtPrimNombr.Visible = True
            txtRol.Visible = True
            txtSegApe.Visible = True
            txtSegNombr.Visible = True
            txtTel.Visible = True

        End If
    End Sub

    Private Sub cmdAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtras.Click
        Me.Hide()

    End Sub
End Class