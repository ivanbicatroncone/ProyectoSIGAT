<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformacionTambos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformacionTambos))
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblEsquina = New System.Windows.Forms.Label()
        Me.lblNroPuert = New System.Windows.Forms.Label()
        Me.lblCantLotes = New System.Windows.Forms.Label()
        Me.lblLitrosDia = New System.Windows.Forms.Label()
        Me.lblCantidadVacas = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtCantidadLotes = New System.Windows.Forms.TextBox()
        Me.txtLitrosDia = New System.Windows.Forms.TextBox()
        Me.txtCantVacas = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtEsquina = New System.Windows.Forms.TextBox()
        Me.txtNroPuert = New System.Windows.Forms.TextBox()
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
        Me.cmdAtras.Size = New System.Drawing.Size(75, 28)
        Me.cmdAtras.TabIndex = 0
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(48, 83)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Location = New System.Drawing.Point(51, 122)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(22, 13)
        Me.lblTel.TabIndex = 2
        Me.lblTel.Text = "Tel"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(292, 86)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(30, 13)
        Me.lblCalle.TabIndex = 3
        Me.lblCalle.Text = "Calle"
        '
        'lblEsquina
        '
        Me.lblEsquina.AutoSize = True
        Me.lblEsquina.Location = New System.Drawing.Point(292, 118)
        Me.lblEsquina.Name = "lblEsquina"
        Me.lblEsquina.Size = New System.Drawing.Size(45, 13)
        Me.lblEsquina.TabIndex = 4
        Me.lblEsquina.Text = "Esquina"
        '
        'lblNroPuert
        '
        Me.lblNroPuert.AutoSize = True
        Me.lblNroPuert.Location = New System.Drawing.Point(291, 158)
        Me.lblNroPuert.Name = "lblNroPuert"
        Me.lblNroPuert.Size = New System.Drawing.Size(52, 13)
        Me.lblNroPuert.TabIndex = 5
        Me.lblNroPuert.Text = "Nº puerta"
        '
        'lblCantLotes
        '
        Me.lblCantLotes.AutoSize = True
        Me.lblCantLotes.Location = New System.Drawing.Point(51, 158)
        Me.lblCantLotes.Name = "lblCantLotes"
        Me.lblCantLotes.Size = New System.Drawing.Size(89, 13)
        Me.lblCantLotes.TabIndex = 6
        Me.lblCantLotes.Text = "Cantidad de lotes"
        '
        'lblLitrosDia
        '
        Me.lblLitrosDia.AutoSize = True
        Me.lblLitrosDia.Location = New System.Drawing.Point(51, 193)
        Me.lblLitrosDia.Name = "lblLitrosDia"
        Me.lblLitrosDia.Size = New System.Drawing.Size(69, 13)
        Me.lblLitrosDia.TabIndex = 7
        Me.lblLitrosDia.Text = "Litros por día"
        '
        'lblCantidadVacas
        '
        Me.lblCantidadVacas.AutoSize = True
        Me.lblCantidadVacas.Location = New System.Drawing.Point(51, 228)
        Me.lblCantidadVacas.Name = "lblCantidadVacas"
        Me.lblCantidadVacas.Size = New System.Drawing.Size(96, 13)
        Me.lblCantidadVacas.TabIndex = 8
        Me.lblCantidadVacas.Text = "Cantidad de vacas"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(152, 83)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 9
        '
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.Color.White
        Me.txtTel.Location = New System.Drawing.Point(152, 115)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.ReadOnly = True
        Me.txtTel.Size = New System.Drawing.Size(100, 20)
        Me.txtTel.TabIndex = 9
        '
        'txtCantidadLotes
        '
        Me.txtCantidadLotes.BackColor = System.Drawing.Color.White
        Me.txtCantidadLotes.Location = New System.Drawing.Point(152, 151)
        Me.txtCantidadLotes.Name = "txtCantidadLotes"
        Me.txtCantidadLotes.ReadOnly = True
        Me.txtCantidadLotes.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadLotes.TabIndex = 9
        '
        'txtLitrosDia
        '
        Me.txtLitrosDia.BackColor = System.Drawing.Color.White
        Me.txtLitrosDia.Location = New System.Drawing.Point(152, 186)
        Me.txtLitrosDia.Name = "txtLitrosDia"
        Me.txtLitrosDia.ReadOnly = True
        Me.txtLitrosDia.Size = New System.Drawing.Size(100, 20)
        Me.txtLitrosDia.TabIndex = 9
        '
        'txtCantVacas
        '
        Me.txtCantVacas.BackColor = System.Drawing.Color.White
        Me.txtCantVacas.Location = New System.Drawing.Point(152, 221)
        Me.txtCantVacas.Name = "txtCantVacas"
        Me.txtCantVacas.ReadOnly = True
        Me.txtCantVacas.Size = New System.Drawing.Size(100, 20)
        Me.txtCantVacas.TabIndex = 9
        '
        'txtCalle
        '
        Me.txtCalle.BackColor = System.Drawing.Color.White
        Me.txtCalle.Location = New System.Drawing.Point(349, 83)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.ReadOnly = True
        Me.txtCalle.Size = New System.Drawing.Size(100, 20)
        Me.txtCalle.TabIndex = 9
        '
        'txtEsquina
        '
        Me.txtEsquina.BackColor = System.Drawing.Color.White
        Me.txtEsquina.Location = New System.Drawing.Point(349, 114)
        Me.txtEsquina.Name = "txtEsquina"
        Me.txtEsquina.ReadOnly = True
        Me.txtEsquina.Size = New System.Drawing.Size(100, 20)
        Me.txtEsquina.TabIndex = 9
        '
        'txtNroPuert
        '
        Me.txtNroPuert.BackColor = System.Drawing.Color.White
        Me.txtNroPuert.Location = New System.Drawing.Point(349, 151)
        Me.txtNroPuert.Name = "txtNroPuert"
        Me.txtNroPuert.ReadOnly = True
        Me.txtNroPuert.Size = New System.Drawing.Size(100, 20)
        Me.txtNroPuert.TabIndex = 9
        '
        'frmInformacionTambos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(534, 312)
        Me.Controls.Add(Me.txtNroPuert)
        Me.Controls.Add(Me.txtEsquina)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.txtCantVacas)
        Me.Controls.Add(Me.txtLitrosDia)
        Me.Controls.Add(Me.txtCantidadLotes)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblCantidadVacas)
        Me.Controls.Add(Me.lblLitrosDia)
        Me.Controls.Add(Me.lblCantLotes)
        Me.Controls.Add(Me.lblNroPuert)
        Me.Controls.Add(Me.lblEsquina)
        Me.Controls.Add(Me.lblCalle)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.cmdAtras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInformacionTambos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Información de Tambos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents lblEsquina As System.Windows.Forms.Label
    Friend WithEvents lblNroPuert As System.Windows.Forms.Label
    Friend WithEvents lblCantLotes As System.Windows.Forms.Label
    Friend WithEvents lblLitrosDia As System.Windows.Forms.Label
    Friend WithEvents lblCantidadVacas As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidadLotes As System.Windows.Forms.TextBox
    Friend WithEvents txtLitrosDia As System.Windows.Forms.TextBox
    Friend WithEvents txtCantVacas As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtEsquina As System.Windows.Forms.TextBox
    Friend WithEvents txtNroPuert As System.Windows.Forms.TextBox
End Class
