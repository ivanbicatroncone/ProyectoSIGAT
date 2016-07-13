Public Class frmLogin

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIngresar.Click
        If txtUsuario.Text = "ibica" And txtContrasena.Text = "1234" Then
            Me.Hide()
            frmMenuCooperativa.Show()

        ElseIf txtUsuario.Text = "atrias" And txtContrasena.Text = "1234" Then
            Me.Hide()
            frmMenuTambo.Show()
        ElseIf txtUsuario.Text = "" And txtContrasena.Text = "" Then

            MsgBox("Debe ingresar un usuario y una contraseña")
        Else
            MsgBox("Usuario o contraseña incorrectos")
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub cmdX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdX.Click
        Me.Close()
    End Sub
End Class
