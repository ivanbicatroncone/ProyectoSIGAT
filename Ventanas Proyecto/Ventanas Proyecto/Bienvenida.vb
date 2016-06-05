Public Class Bienvenida

    Dim contador As Byte = 4
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDistribuidoPorExore.Parent = PictureBox1

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
                    lblDistribuidoPorExore.Text = "Distribuido por eXore"
                End If
            End If


        End If
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class