Public Class Usuario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Me.Hide()
        MenuCooperativa.Show()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub

    Private Sub Tambo1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
    End Sub

    Private Sub Tambo1_Click_1(sender As Object, e As EventArgs) Handles Tambo1.Click
        If Tambo1_Click_1().checked Then
            frmUsuario.Visible
        Else
            frmUsuario.Visible = True

        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles frmUsuario.Enter

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
