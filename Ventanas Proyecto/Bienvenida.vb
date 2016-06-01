Public Class Bienvenida

    Dim contador As Byte = 4
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Me.Opacity -= 0.07
            If Me.Opacity = 0.0 Then
                Me.Hide()
                Usuario.Show()
                Timer1.Enabled = False

            End If
        Else
            ProgressBar1.Value += 4
            If ProgressBar1.Value = contador Then
                ' Label1.Text = "Iniciando"
            Else
                If ProgressBar1.Value = contador + 16 Then
                    Label1.Text = ""
                    contador += 20
                End If
                If ProgressBar1.Value = 28 Then
                    Label2.Text = "Distribuido por eXore"
                End If
            End If


        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ' Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.BackColor = Color.Transparent
    End Sub
End Class