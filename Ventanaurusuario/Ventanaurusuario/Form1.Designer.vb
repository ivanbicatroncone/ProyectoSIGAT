<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblContrasenia = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.cmdCooperativa = New System.Windows.Forms.Button()
        Me.cmdTambo = New System.Windows.Forms.Button()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(286, 262)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(101, 143)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Usuario"
        '
        'lblContrasenia
        '
        Me.lblContrasenia.AutoSize = True
        Me.lblContrasenia.Location = New System.Drawing.Point(96, 187)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(61, 13)
        Me.lblContrasenia.TabIndex = 2
        Me.lblContrasenia.Text = "Contraseña"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(200, 143)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(231, 20)
        Me.txtUsuario.TabIndex = 3
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(200, 184)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(231, 20)
        Me.txtContraseña.TabIndex = 4
        '
        'cmdCooperativa
        '
        Me.cmdCooperativa.BackColor = System.Drawing.Color.Transparent
        Me.cmdCooperativa.FlatAppearance.BorderSize = 0
        Me.cmdCooperativa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdCooperativa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdCooperativa.Image = CType(resources.GetObject("cmdCooperativa.Image"), System.Drawing.Image)
        Me.cmdCooperativa.Location = New System.Drawing.Point(324, 12)
        Me.cmdCooperativa.Name = "cmdCooperativa"
        Me.cmdCooperativa.Size = New System.Drawing.Size(100, 89)
        Me.cmdCooperativa.TabIndex = 7
        Me.cmdCooperativa.Text = "Cooperativa"
        Me.cmdCooperativa.UseVisualStyleBackColor = False
        '
        'cmdTambo
        '
        Me.cmdTambo.BackColor = System.Drawing.Color.Transparent
        Me.cmdTambo.BackgroundImage = CType(resources.GetObject("cmdTambo.BackgroundImage"), System.Drawing.Image)
        Me.cmdTambo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdTambo.FlatAppearance.BorderSize = 0
        Me.cmdTambo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdTambo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdTambo.Image = CType(resources.GetObject("cmdTambo.Image"), System.Drawing.Image)
        Me.cmdTambo.Location = New System.Drawing.Point(205, 12)
        Me.cmdTambo.Name = "cmdTambo"
        Me.cmdTambo.Size = New System.Drawing.Size(100, 89)
        Me.cmdTambo.TabIndex = 7
        Me.cmdTambo.Text = "Tambo"
        Me.cmdTambo.UseVisualStyleBackColor = False
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(551, 328)
        Me.Controls.Add(Me.cmdTambo)
        Me.Controls.Add(Me.cmdCooperativa)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblContrasenia)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblContrasenia As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents cmdCooperativa As System.Windows.Forms.Button
    Friend WithEvents cmdTambo As System.Windows.Forms.Button
    Friend WithEvents DirectorySearcher1 As System.DirectoryServices.DirectorySearcher

End Class
