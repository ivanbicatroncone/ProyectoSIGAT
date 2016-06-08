Imports System.Data.Odbc
Module Module1
    Public comand As New Odbc.OdbcCommand
    Public conexion As New OdbcConnection

    Public Sub conectar()
        Dim conectar As String

        Try
            conectar = "FileDsn=C:\Users\Proyecto\Desktop\Ventanaurusuario\Ventanaurusuario\bin\Debug\conexion.dsn;UID=ibica;PWD=1234"
            conexion.ConnectionString = conectar
            conexion.Open()

        Catch ex As Exception
            MsgBox("Error al conectarse a la base de datos")
            conexion.Close()

        End Try
    End Sub
    Public Sub Cerrar()
        conexion.Close()

    End Sub


End Module
