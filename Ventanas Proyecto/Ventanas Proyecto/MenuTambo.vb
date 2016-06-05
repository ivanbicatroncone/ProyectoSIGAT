Public Class MenuTambo

    Private Sub cmdAtrás_Click(sender As Object, e As EventArgs) Handles cmdAtrasTambo.Click
        Me.Hide()
        Usuario.Show()
    End Sub

    Private Sub MenuTambo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdRodeoTambo.Parent = FondoMenuTambo
        cmdAnimalesMenuTambo.Parent = FondoMenuTambo
        cmdAtrasTambo.Parent = FondoMenuTambo

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles FondoMenuTambo.Click

    End Sub
    Private Sub cmdAnimalesMenuTambo_Click(sender As Object, e As EventArgs)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub

    Private Sub cmdRodeoTambo_Click(sender As Object, e As EventArgs) Handles cmdRodeoTambo.Click
    End Sub

    Private Sub cmdAnimalesMenuTambo_Click_1(sender As Object, e As EventArgs) Handles cmdAnimalesMenuTambo.Click
        If cmdAnimalesMenuTambo.Enabled Then


            cmdAnimalesMenuTambo.BackColor = Color.GreenYellow

        End If



    End Sub
End Class