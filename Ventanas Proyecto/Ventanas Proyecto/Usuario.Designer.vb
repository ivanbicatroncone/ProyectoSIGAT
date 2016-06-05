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
        Me.rbTambo = New System.Windows.Forms.RadioButton()
        Me.rbCooperativa = New System.Windows.Forms.RadioButton()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.ForeColor = System.Drawing.Color.Transparent
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(296, 274)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 32)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'rbTambo
        '
        Me.rbTambo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbTambo.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbTambo.AutoSize = True
        Me.rbTambo.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbTambo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbTambo.FlatAppearance.BorderSize = 0
        Me.rbTambo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.rbTambo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.rbTambo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.rbTambo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbTambo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTambo.ForeColor = System.Drawing.Color.Transparent
        Me.rbTambo.Image = CType(resources.GetObject("rbTambo.Image"), System.Drawing.Image)
        Me.rbTambo.Location = New System.Drawing.Point(215, 50)
        Me.rbTambo.Margin = New System.Windows.Forms.Padding(0)
        Me.rbTambo.Name = "rbTambo"
        Me.rbTambo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rbTambo.Size = New System.Drawing.Size(96, 96)
        Me.rbTambo.TabIndex = 12
        Me.rbTambo.Text = "TAMBO"
        Me.rbTambo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbTambo.UseCompatibleTextRendering = True
        Me.rbTambo.UseVisualStyleBackColor = True
        '
        'rbCooperativa
        '
        Me.rbCooperativa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbCooperativa.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbCooperativa.AutoSize = True
        Me.rbCooperativa.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbCooperativa.FlatAppearance.BorderSize = 0
        Me.rbCooperativa.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.rbCooperativa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.rbCooperativa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.rbCooperativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbCooperativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCooperativa.ForeColor = System.Drawing.Color.Transparent
        Me.rbCooperativa.Image = CType(resources.GetObject("rbCooperativa.Image"), System.Drawing.Image)
        Me.rbCooperativa.Location = New System.Drawing.Point(356, 50)
        Me.rbCooperativa.Margin = New System.Windows.Forms.Padding(0)
        Me.rbCooperativa.Name = "rbCooperativa"
        Me.rbCooperativa.Size = New System.Drawing.Size(96, 96)
        Me.rbCooperativa.TabIndex = 12
        Me.rbCooperativa.Text = "COOPERATIVA"
        Me.rbCooperativa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbCooperativa.UseCompatibleTextRendering = True
        Me.rbCooperativa.UseVisualStyleBackColor = True
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(118, 220)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(61, 13)
        Me.lblContraseña.TabIndex = 4
        Me.lblContraseña.Text = "Contraseña"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(125, 194)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Usuario"
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(183, 217)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(325, 20)
        Me.txtContraseña.TabIndex = 2
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(183, 191)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(325, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(665, 369)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.rbCooperativa)
        Me.Controls.Add(Me.rbTambo)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Usuario"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdAceptar As Button
    Friend WithEvents rbCooperativa As RadioButton
    Friend WithEvents lblContraseña As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtUsuario As TextBox
    Public WithEvents rbTambo As RadioButton
End Class
