Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUsuario.Click

    End Sub

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub txtContraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContraseña.TextChanged

    End Sub

    Private Sub lblContrasenia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblContrasenia.Click

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If cmdTambo.Enabled Then
            conectar()
            MsgBox("Bienvenido")
            MenuTambo.Show()

        ElseIf cmdCooperativa.Enabled Then
            conectar()
            MsgBox("Bienvenido")
            MenuCooperativa.Show()


            ' ElseIf cmdCooperativa.Enabled Then
            ' MsgBox("Bienvenido")

            'MenuCooperativa.Show()
        Else : Cerrar()

        End If

            Cerrar()

    End Sub
    Public Sub conectar()
        Dim conectar As String

        Try
            conectar = "FileDsn=C:\Users\Proyecto\Desktop\Ventanaurusuario\Ventanaurusuario\bin\Debug\conexion.dsn;UID=" & txtUsuario.Text & ";PWD=" & txtContraseña.Text & ""
            conexion.ConnectionString = conectar
            conexion.Open()

        Catch ex As Exception

            MsgBox("Usuario o contraseña incorrectos")
            conexion.Close()

        End Try

    End Sub
    Public Sub Cerrar()
        conexion.Close()

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Module1.conectar()
        Module1.Cerrar()


    End Sub

    Private Sub cmdCooperativa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCooperativa.Click
      
    End Sub
    Private Sub cmdTambo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTambo.Click
      
    End Sub

 
   

End Class
