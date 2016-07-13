<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresarPersonal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngresarPersonal))
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.txtEsquina = New System.Windows.Forms.TextBox()
        Me.txtNroPuert = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtSegApe = New System.Windows.Forms.TextBox()
        Me.txtPrimApe = New System.Windows.Forms.TextBox()
        Me.txtSegNombr = New System.Windows.Forms.TextBox()
        Me.txtPrimNombr = New System.Windows.Forms.TextBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.lblNroPuert = New System.Windows.Forms.Label()
        Me.lblEsquina = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblSegApe = New System.Windows.Forms.Label()
        Me.lblPrimApe = New System.Windows.Forms.Label()
        Me.lblSegNombr = New System.Windows.Forms.Label()
        Me.lblPrimNombr = New System.Windows.Forms.Label()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.cbRol = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(156, 101)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(100, 20)
        Me.txtLogin.TabIndex = 28
        '
        'txtCi
        '
        Me.txtCi.Location = New System.Drawing.Point(368, 102)
        Me.txtCi.Name = "txtCi"
        Me.txtCi.Size = New System.Drawing.Size(100, 20)
        Me.txtCi.TabIndex = 29
        '
        'txtEsquina
        '
        Me.txtEsquina.Location = New System.Drawing.Point(368, 173)
        Me.txtEsquina.Name = "txtEsquina"
        Me.txtEsquina.Size = New System.Drawing.Size(100, 20)
        Me.txtEsquina.TabIndex = 27
        '
        'txtNroPuert
        '
        Me.txtNroPuert.Location = New System.Drawing.Point(368, 206)
        Me.txtNroPuert.Name = "txtNroPuert"
        Me.txtNroPuert.Size = New System.Drawing.Size(100, 20)
        Me.txtNroPuert.TabIndex = 25
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(156, 270)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(100, 20)
        Me.txtTel.TabIndex = 30
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(368, 138)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(100, 20)
        Me.txtCalle.TabIndex = 34
        '
        'txtSegApe
        '
        Me.txtSegApe.Location = New System.Drawing.Point(156, 238)
        Me.txtSegApe.Name = "txtSegApe"
        Me.txtSegApe.Size = New System.Drawing.Size(100, 20)
        Me.txtSegApe.TabIndex = 35
        '
        'txtPrimApe
        '
        Me.txtPrimApe.Location = New System.Drawing.Point(156, 206)
        Me.txtPrimApe.Name = "txtPrimApe"
        Me.txtPrimApe.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimApe.TabIndex = 33
        '
        'txtSegNombr
        '
        Me.txtSegNombr.Location = New System.Drawing.Point(156, 174)
        Me.txtSegNombr.Name = "txtSegNombr"
        Me.txtSegNombr.Size = New System.Drawing.Size(100, 20)
        Me.txtSegNombr.TabIndex = 31
        '
        'txtPrimNombr
        '
        Me.txtPrimNombr.Location = New System.Drawing.Point(156, 137)
        Me.txtPrimNombr.Name = "txtPrimNombr"
        Me.txtPrimNombr.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimNombr.TabIndex = 32
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Location = New System.Drawing.Point(50, 104)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(33, 13)
        Me.lblLogin.TabIndex = 24
        Me.lblLogin.Text = "Login"
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Location = New System.Drawing.Point(294, 245)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(23, 13)
        Me.lblRol.TabIndex = 22
        Me.lblRol.Text = "Rol"
        '
        'lblNroPuert
        '
        Me.lblNroPuert.AutoSize = True
        Me.lblNroPuert.Location = New System.Drawing.Point(294, 213)
        Me.lblNroPuert.Name = "lblNroPuert"
        Me.lblNroPuert.Size = New System.Drawing.Size(52, 13)
        Me.lblNroPuert.TabIndex = 23
        Me.lblNroPuert.Text = "Nº puerta"
        '
        'lblEsquina
        '
        Me.lblEsquina.AutoSize = True
        Me.lblEsquina.Location = New System.Drawing.Point(294, 181)
        Me.lblEsquina.Name = "lblEsquina"
        Me.lblEsquina.Size = New System.Drawing.Size(45, 13)
        Me.lblEsquina.TabIndex = 21
        Me.lblEsquina.Text = "Esquina"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(294, 145)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(30, 13)
        Me.lblCalle.TabIndex = 20
        Me.lblCalle.Text = "Calle"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Location = New System.Drawing.Point(50, 277)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(22, 13)
        Me.lblTel.TabIndex = 19
        Me.lblTel.Text = "Tel"
        '
        'lblSegApe
        '
        Me.lblSegApe.AutoSize = True
        Me.lblSegApe.Location = New System.Drawing.Point(50, 245)
        Me.lblSegApe.Name = "lblSegApe"
        Me.lblSegApe.Size = New System.Drawing.Size(89, 13)
        Me.lblSegApe.TabIndex = 18
        Me.lblSegApe.Text = "Segundo apellido"
        '
        'lblPrimApe
        '
        Me.lblPrimApe.AutoSize = True
        Me.lblPrimApe.Location = New System.Drawing.Point(51, 213)
        Me.lblPrimApe.Name = "lblPrimApe"
        Me.lblPrimApe.Size = New System.Drawing.Size(75, 13)
        Me.lblPrimApe.TabIndex = 17
        Me.lblPrimApe.Text = "Primer apellido"
        '
        'lblSegNombr
        '
        Me.lblSegNombr.AutoSize = True
        Me.lblSegNombr.Location = New System.Drawing.Point(51, 181)
        Me.lblSegNombr.Name = "lblSegNombr"
        Me.lblSegNombr.Size = New System.Drawing.Size(88, 13)
        Me.lblSegNombr.TabIndex = 16
        Me.lblSegNombr.Text = "Segundo nombre"
        '
        'lblPrimNombr
        '
        Me.lblPrimNombr.AutoSize = True
        Me.lblPrimNombr.Location = New System.Drawing.Point(51, 145)
        Me.lblPrimNombr.Name = "lblPrimNombr"
        Me.lblPrimNombr.Size = New System.Drawing.Size(74, 13)
        Me.lblPrimNombr.TabIndex = 15
        Me.lblPrimNombr.Text = "Primer nombre"
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Location = New System.Drawing.Point(294, 105)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(23, 13)
        Me.lblCI.TabIndex = 14
        Me.lblCI.Text = "C.I."
        '
        'cmdIngresar
        '
        Me.cmdIngresar.BackColor = System.Drawing.Color.Transparent
        Me.cmdIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdIngresar.FlatAppearance.BorderSize = 0
        Me.cmdIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIngresar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdIngresar.Image = CType(resources.GetObject("cmdIngresar.Image"), System.Drawing.Image)
        Me.cmdIngresar.Location = New System.Drawing.Point(232, 388)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(75, 26)
        Me.cmdIngresar.TabIndex = 13
        Me.cmdIngresar.Text = "Ingresar"
        Me.cmdIngresar.UseVisualStyleBackColor = False
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
        Me.cmdAtras.Location = New System.Drawing.Point(7, 7)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(75, 28)
        Me.cmdAtras.TabIndex = 12
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'cbRol
        '
        Me.cbRol.FormattingEnabled = True
        Me.cbRol.Items.AddRange(New Object() {"Cooperativista", "Administrador de tambo", "Auxiliar"})
        Me.cbRol.Location = New System.Drawing.Point(368, 236)
        Me.cbRol.Name = "cbRol"
        Me.cbRol.Size = New System.Drawing.Size(100, 21)
        Me.cbRol.TabIndex = 36
        '
        'frmIngresarPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(534, 489)
        Me.Controls.Add(Me.cbRol)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.txtEsquina)
        Me.Controls.Add(Me.txtNroPuert)
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
        Me.Controls.Add(Me.cmdIngresar)
        Me.Controls.Add(Me.cmdAtras)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmIngresarPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Ingresar personal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtCi As System.Windows.Forms.TextBox
    Friend WithEvents txtEsquina As System.Windows.Forms.TextBox
    Friend WithEvents txtNroPuert As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtSegApe As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimApe As System.Windows.Forms.TextBox
    Friend WithEvents txtSegNombr As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimNombr As System.Windows.Forms.TextBox
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents lblRol As System.Windows.Forms.Label
    Friend WithEvents lblNroPuert As System.Windows.Forms.Label
    Friend WithEvents lblEsquina As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents lblSegApe As System.Windows.Forms.Label
    Friend WithEvents lblPrimApe As System.Windows.Forms.Label
    Friend WithEvents lblSegNombr As System.Windows.Forms.Label
    Friend WithEvents lblPrimNombr As System.Windows.Forms.Label
    Friend WithEvents lblCI As System.Windows.Forms.Label
    Friend WithEvents cmdIngresar As System.Windows.Forms.Button
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
    Friend WithEvents cbRol As System.Windows.Forms.ComboBox
End Class
