Public Class Bienvenida


    Dim contador As Byte = 4

    Private Sub Bienvenida_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value = 100 Then
            Me.Opacity -= 0.07
            If Me.Opacity = 0.0 Then
                Me.Hide()
                frmLogin.Show()
                Timer1.Enabled = False

            End If
        Else
            ProgressBar1.Value += 4
            If ProgressBar1.Value = contador Then
                ' Label1.Text = "Iniciando"
            Else
                If ProgressBar1.Value = contador + 16 Then
                    lblCopyright.Visible = True
                    contador += 20
                End If
                If ProgressBar1.Value = 28 Then
                    lblVersion.Visible = True
                End If
            End If


        End If
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub
End Class