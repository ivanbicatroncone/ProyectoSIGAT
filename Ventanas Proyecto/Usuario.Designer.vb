<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usuario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuario))
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tambo1 = New System.Windows.Forms.Button()
        Me.frmUsuario = New System.Windows.Forms.GroupBox()
        Me.frmUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(308, 263)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(66, 7)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(325, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(66, 33)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(325, 20)
        Me.txtContraseña.TabIndex = 2
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(8, 9)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Usuario"
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(1, 35)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(61, 13)
        Me.lblContraseña.TabIndex = 4
        Me.lblContraseña.Text = "Contraseña"
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(383, 39)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 80)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "COOPERATIVA"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Tambo1
        '
        Me.Tambo1.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.Tambo1.BackColor = System.Drawing.SystemColors.Control
        Me.Tambo1.BackgroundImage = CType(resources.GetObject("Tambo1.BackgroundImage"), System.Drawing.Image)
        Me.Tambo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Tambo1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tambo1.ForeColor = System.Drawing.Color.White
        Me.Tambo1.Location = New System.Drawing.Point(214, 39)
        Me.Tambo1.Margin = New System.Windows.Forms.Padding(0)
        Me.Tambo1.Name = "Tambo1"
        Me.Tambo1.Size = New System.Drawing.Size(90, 80)
        Me.Tambo1.TabIndex = 6
        Me.Tambo1.Text = "TAMBO"
        Me.Tambo1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Tambo1.UseCompatibleTextRendering = True
        Me.Tambo1.UseVisualStyleBackColor = False
        '
        'frmUsuario
        '
        Me.frmUsuario.Controls.Add(Me.txtUsuario)
        Me.frmUsuario.Controls.Add(Me.txtContraseña)
        Me.frmUsuario.Controls.Add(Me.lblUsuario)
        Me.frmUsuario.Controls.Add(Me.lblContraseña)
        Me.frmUsuario.Location = New System.Drawing.Point(106, 163)
        Me.frmUsuario.Name = "frmUsuario"
        Me.frmUsuario.Size = New System.Drawing.Size(391, 54)
        Me.frmUsuario.TabIndex = 8
        Me.frmUsuario.TabStop = False
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(665, 369)
        Me.Controls.Add(Me.frmUsuario)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tambo1)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Name = "Usuario"
        Me.Text = "Inicio"
        Me.frmUsuario.ResumeLayout(False)
        Me.frmUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdAceptar As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblContraseña As Label
    Friend WithEvents Tambo1 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents frmUsuario As GroupBox
End Class
