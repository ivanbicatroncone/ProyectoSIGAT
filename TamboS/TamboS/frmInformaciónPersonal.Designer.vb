<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformaciónPersonal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformaciónPersonal))
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.lblPrimNombr = New System.Windows.Forms.Label()
        Me.lblSegNombr = New System.Windows.Forms.Label()
        Me.lblPrimApe = New System.Windows.Forms.Label()
        Me.lblSegApe = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblEsquina = New System.Windows.Forms.Label()
        Me.lblNroPuert = New System.Windows.Forms.Label()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtPrimNombr = New System.Windows.Forms.TextBox()
        Me.txtSegNombr = New System.Windows.Forms.TextBox()
        Me.txtPrimApe = New System.Windows.Forms.TextBox()
        Me.txtSegApe = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtEsquina = New System.Windows.Forms.TextBox()
        Me.txtNroPuert = New System.Windows.Forms.TextBox()
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdAtras
        '
        Me.cmdAtras.BackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAtras.FlatAppearance.BorderSize = 0
        Me.cmdAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAtras.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdAtras.Image = CType(resources.GetObject("cmdAtras.Image"), System.Drawing.Image)
        Me.cmdAtras.Location = New System.Drawing.Point(13, 13)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(75, 24)
        Me.cmdAtras.TabIndex = 0
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.Color.Transparent
        Me.cmdBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBuscar.FlatAppearance.BorderSize = 0
        Me.cmdBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.Location = New System.Drawing.Point(346, 92)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 29)
        Me.cmdBuscar.TabIndex = 1
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Location = New System.Drawing.Point(293, 169)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(23, 13)
        Me.lblCI.TabIndex = 2
        Me.lblCI.Text = "C.I."
        Me.lblCI.Visible = False
        '
        'lblPrimNombr
        '
        Me.lblPrimNombr.AutoSize = True
        Me.lblPrimNombr.Location = New System.Drawing.Point(50, 170)
        Me.lblPrimNombr.Name = "lblPrimNombr"
        Me.lblPrimNombr.Size = New System.Drawing.Size(74, 13)
        Me.lblPrimNombr.TabIndex = 3
        Me.lblPrimNombr.Text = "Primer nombre"
        Me.lblPrimNombr.Visible = False
        '
        'lblSegNombr
        '
        Me.lblSegNombr.AutoSize = True
        Me.lblSegNombr.Location = New System.Drawing.Point(50, 206)
        Me.lblSegNombr.Name = "lblSegNombr"
        Me.lblSegNombr.Size = New System.Drawing.Size(88, 13)
        Me.lblSegNombr.TabIndex = 4
        Me.lblSegNombr.Text = "Segundo nombre"
        Me.lblSegNombr.Visible = False
        '
        'lblPrimApe
        '
        Me.lblPrimApe.AutoSize = True
        Me.lblPrimApe.Location = New System.Drawing.Point(50, 238)
        Me.lblPrimApe.Name = "lblPrimApe"
        Me.lblPrimApe.Size = New System.Drawing.Size(75, 13)
        Me.lblPrimApe.TabIndex = 5
        Me.lblPrimApe.Text = "Primer apellido"
        Me.lblPrimApe.Visible = False
        '
        'lblSegApe
        '
        Me.lblSegApe.AutoSize = True
        Me.lblSegApe.Location = New System.Drawing.Point(49, 270)
        Me.lblSegApe.Name = "lblSegApe"
        Me.lblSegApe.Size = New System.Drawing.Size(89, 13)
        Me.lblSegApe.TabIndex = 6
        Me.lblSegApe.Text = "Segundo apellido"
        Me.lblSegApe.Visible = False
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Location = New System.Drawing.Point(49, 302)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(22, 13)
        Me.lblTel.TabIndex = 7
        Me.lblTel.Text = "Tel"
        Me.lblTel.Visible = False
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(293, 209)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(30, 13)
        Me.lblCalle.TabIndex = 8
        Me.lblCalle.Text = "Calle"
        Me.lblCalle.Visible = False
        '
        'lblEsquina
        '
        Me.lblEsquina.AutoSize = True
        Me.lblEsquina.Location = New System.Drawing.Point(293, 245)
        Me.lblEsquina.Name = "lblEsquina"
        Me.lblEsquina.Size = New System.Drawing.Size(45, 13)
        Me.lblEsquina.TabIndex = 9
        Me.lblEsquina.Text = "Esquina"
        Me.lblEsquina.Visible = False
        '
        'lblNroPuert
        '
        Me.lblNroPuert.AutoSize = True
        Me.lblNroPuert.Location = New System.Drawing.Point(293, 277)
        Me.lblNroPuert.Name = "lblNroPuert"
        Me.lblNroPuert.Size = New System.Drawing.Size(52, 13)
        Me.lblNroPuert.TabIndex = 10
        Me.lblNroPuert.Text = "Nº puerta"
        Me.lblNroPuert.Visible = False
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Location = New System.Drawing.Point(293, 309)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(23, 13)
        Me.lblRol.TabIndex = 10
        Me.lblRol.Text = "Rol"
        Me.lblRol.Visible = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Location = New System.Drawing.Point(75, 104)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(33, 13)
        Me.lblLogin.TabIndex = 10
        Me.lblLogin.Text = "Login"
        '
        'txtPrimNombr
        '
        Me.txtPrimNombr.BackColor = System.Drawing.Color.White
        Me.txtPrimNombr.Location = New System.Drawing.Point(155, 162)
        Me.txtPrimNombr.Name = "txtPrimNombr"
        Me.txtPrimNombr.ReadOnly = True
        Me.txtPrimNombr.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimNombr.TabIndex = 11
        Me.txtPrimNombr.Visible = False
        '
        'txtSegNombr
        '
        Me.txtSegNombr.BackColor = System.Drawing.Color.White
        Me.txtSegNombr.Location = New System.Drawing.Point(155, 199)
        Me.txtSegNombr.Name = "txtSegNombr"
        Me.txtSegNombr.ReadOnly = True
        Me.txtSegNombr.Size = New System.Drawing.Size(100, 20)
        Me.txtSegNombr.TabIndex = 11
        Me.txtSegNombr.Visible = False
        '
        'txtPrimApe
        '
        Me.txtPrimApe.BackColor = System.Drawing.Color.White
        Me.txtPrimApe.Location = New System.Drawing.Point(155, 231)
        Me.txtPrimApe.Name = "txtPrimApe"
        Me.txtPrimApe.ReadOnly = True
        Me.txtPrimApe.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimApe.TabIndex = 11
        Me.txtPrimApe.Visible = False
        '
        'txtSegApe
        '
        Me.txtSegApe.BackColor = System.Drawing.Color.White
        Me.txtSegApe.Location = New System.Drawing.Point(155, 263)
        Me.txtSegApe.Name = "txtSegApe"
        Me.txtSegApe.ReadOnly = True
        Me.txtSegApe.Size = New System.Drawing.Size(100, 20)
        Me.txtSegApe.TabIndex = 11
        Me.txtSegApe.Visible = False
        '
        'txtCalle
        '
        Me.txtCalle.BackColor = System.Drawing.Color.White
        Me.txtCalle.Location = New System.Drawing.Point(367, 202)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.ReadOnly = True
        Me.txtCalle.Size = New System.Drawing.Size(100, 20)
        Me.txtCalle.TabIndex = 11
        Me.txtCalle.Visible = False
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(181, 101)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(100, 20)
        Me.txtLogin.TabIndex = 11
        '
        'txtCi
        '
        Me.txtCi.BackColor = System.Drawing.Color.White
        Me.txtCi.Location = New System.Drawing.Point(367, 166)
        Me.txtCi.Name = "txtCi"
        Me.txtCi.ReadOnly = True
        Me.txtCi.Size = New System.Drawing.Size(100, 20)
        Me.txtCi.TabIndex = 11
        Me.txtCi.Visible = False
        '
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.Color.White
        Me.txtTel.Location = New System.Drawing.Point(155, 295)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.ReadOnly = True
        Me.txtTel.Size = New System.Drawing.Size(100, 20)
        Me.txtTel.TabIndex = 11
        Me.txtTel.Visible = False
        '
        'txtEsquina
        '
        Me.txtEsquina.BackColor = System.Drawing.Color.White
        Me.txtEsquina.Location = New System.Drawing.Point(367, 237)
        Me.txtEsquina.Name = "txtEsquina"
        Me.txtEsquina.ReadOnly = True
        Me.txtEsquina.Size = New System.Drawing.Size(100, 20)
        Me.txtEsquina.TabIndex = 11
        Me.txtEsquina.Visible = False
        '
        'txtNroPuert
        '
        Me.txtNroPuert.BackColor = System.Drawing.Color.White
        Me.txtNroPuert.Location = New System.Drawing.Point(367, 270)
        Me.txtNroPuert.Name = "txtNroPuert"
        Me.txtNroPuert.ReadOnly = True
        Me.txtNroPuert.Size = New System.Drawing.Size(100, 20)
        Me.txtNroPuert.TabIndex = 11
        Me.txtNroPuert.Visible = False
        '
        'txtRol
        '
        Me.txtRol.BackColor = System.Drawing.Color.White
        Me.txtRol.Location = New System.Drawing.Point(367, 302)
        Me.txtRol.Name = "txtRol"
        Me.txtRol.ReadOnly = True
        Me.txtRol.Size = New System.Drawing.Size(100, 20)
        Me.txtRol.TabIndex = 11
        Me.txtRol.Visible = False
        '
        'frmInformaciónPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(534, 411)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.txtEsquina)
        Me.Controls.Add(Me.txtNroPuert)
        Me.Controls.Add(Me.txtRol)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.txtSegApe)
        Me.Controls.Add(Me.txtPrimApe)
        Me.Controls.Add(Me.txtSegNombr)
        Me.Controls.Add(Me.txtPrimNombr)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.lblRol)
        Me.Controls.Add(Me.lblNroPuert)
        Me.Controls.Add(Me.lblEsquina)
        Me.Controls.Add(Me.lblCalle)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblSegApe)
        Me.Controls.Add(Me.lblPrimApe)
        Me.Controls.Add(Me.lblSegNombr)
        Me.Controls.Add(Me.lblPrimNombr)
        Me.Controls.Add(Me.lblCI)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdAtras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInformaciónPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Información personal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents lblCI As System.Windows.Forms.Label
    Friend WithEvents lblPrimNombr As System.Windows.Forms.Label
    Friend WithEvents lblSegNombr As System.Windows.Forms.Label
    Friend WithEvents lblPrimApe As System.Windows.Forms.Label
    Friend WithEvents lblSegApe As System.Windows.Forms.Label
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents lblEsquina As System.Windows.Forms.Label
    Friend WithEvents lblNroPuert As System.Windows.Forms.Label
    Friend WithEvents lblRol As System.Windows.Forms.Label
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents txtPrimNombr As System.Windows.Forms.TextBox
    Friend WithEvents txtSegNombr As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimApe As System.Windows.Forms.TextBox
    Friend WithEvents txtSegApe As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtCi As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtEsquina As System.Windows.Forms.TextBox
    Friend WithEvents txtNroPuert As System.Windows.Forms.TextBox
    Friend WithEvents txtRol As System.Windows.Forms.TextBox
End Class
