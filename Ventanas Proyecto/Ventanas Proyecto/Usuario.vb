Public Class Usuario


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub

    Private Sub Tambo1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
    End Sub

    Private Sub Tambo1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            cn.Open("exore", txtUsuario.Text, txtContraseña.Text)

            '   If rbTambo.Checked Then

            '   Me.Hide()
            '  MenuTambo.Show()
            'ElseIf rbCooperativa.Checked Then
            '   Me.Hide()
            '  MenuCooperativa.Show()

            'End If
        Catch ex As Exception
            MsgBox("Usuario o contraseña incorrecta")
            Exit Sub
        End Try

    End Sub
End Class
