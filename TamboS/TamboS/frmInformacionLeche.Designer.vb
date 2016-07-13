<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformacionLeche
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformacionLeche))
        Me.cmdIdVaca = New System.Windows.Forms.Button()
        Me.lblFechaOrdeñe = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.lblLitrosDia = New System.Windows.Forms.Label()
        Me.lblCelulasSomaticas = New System.Windows.Forms.Label()
        Me.lblGrasas = New System.Windows.Forms.Label()
        Me.lblProteinas = New System.Windows.Forms.Label()
        Me.txtLitrosDiaInfLeche = New System.Windows.Forms.TextBox()
        Me.txtGrasasInfLeche = New System.Windows.Forms.TextBox()
        Me.txtCelSomInfLeche = New System.Windows.Forms.TextBox()
        Me.txtProteInfLeche = New System.Windows.Forms.TextBox()
        Me.gbInformacionLeche = New System.Windows.Forms.GroupBox()
        Me.gbInformacionLeche.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdIdVaca
        '
        Me.cmdIdVaca.BackColor = System.Drawing.Color.Transparent
        Me.cmdIdVaca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdIdVaca.FlatAppearance.BorderSize = 0
        Me.cmdIdVaca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdIdVaca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdIdVaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIdVaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIdVaca.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdIdVaca.Image = CType(resources.GetObject("cmdIdVaca.Image"), System.Drawing.Image)
        Me.cmdIdVaca.Location = New System.Drawing.Point(383, 36)
        Me.cmdIdVaca.Name = "cmdIdVaca"
        Me.cmdIdVaca.Size = New System.Drawing.Size(75, 32)
        Me.cmdIdVaca.TabIndex = 0
        Me.cmdIdVaca.Text = "Buscar"
        Me.cmdIdVaca.UseVisualStyleBackColor = False
        '
        'lblFechaOrdeñe
        '
        Me.lblFechaOrdeñe.AutoSize = True
        Me.lblFechaOrdeñe.Location = New System.Drawing.Point(48, 46)
        Me.lblFechaOrdeñe.Name = "lblFechaOrdeñe"
        Me.lblFechaOrdeñe.Size = New System.Drawing.Size(91, 13)
        Me.lblFechaOrdeñe.TabIndex = 1
        Me.lblFechaOrdeñe.Text = "Fecha de ordeñe:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(159, 44)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.Transparent
        Me.cmdSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSalir.FlatAppearance.BorderSize = 0
        Me.cmdSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(228, 215)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 29)
        Me.cmdSalir.TabIndex = 5
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'lblLitrosDia
        '
        Me.lblLitrosDia.AutoSize = True
        Me.lblLitrosDia.Location = New System.Drawing.Point(17, 35)
        Me.lblLitrosDia.Name = "lblLitrosDia"
        Me.lblLitrosDia.Size = New System.Drawing.Size(54, 13)
        Me.lblLitrosDia.TabIndex = 0
        Me.lblLitrosDia.Text = "Litros día:"
        '
        'lblCelulasSomaticas
        '
        Me.lblCelulasSomaticas.AutoSize = True
        Me.lblCelulasSomaticas.Location = New System.Drawing.Point(208, 35)
        Me.lblCelulasSomaticas.Name = "lblCelulasSomaticas"
        Me.lblCelulasSomaticas.Size = New System.Drawing.Size(94, 13)
        Me.lblCelulasSomaticas.TabIndex = 1
        Me.lblCelulasSomaticas.Text = "Celulas somáticas:"
        '
        'lblGrasas
        '
        Me.lblGrasas.AutoSize = True
        Me.lblGrasas.Location = New System.Drawing.Point(17, 69)
        Me.lblGrasas.Name = "lblGrasas"
        Me.lblGrasas.Size = New System.Drawing.Size(43, 13)
        Me.lblGrasas.TabIndex = 2
        Me.lblGrasas.Text = "Grasas:"
        '
        'lblProteinas
        '
        Me.lblProteinas.AutoSize = True
        Me.lblProteinas.Location = New System.Drawing.Point(208, 69)
        Me.lblProteinas.Name = "lblProteinas"
        Me.lblProteinas.Size = New System.Drawing.Size(56, 13)
        Me.lblProteinas.TabIndex = 3
        Me.lblProteinas.Text = "Proteínas:"
        '
        'txtLitrosDiaInfLeche
        '
        Me.txtLitrosDiaInfLeche.BackColor = System.Drawing.Color.White
        Me.txtLitrosDiaInfLeche.Location = New System.Drawing.Point(77, 32)
        Me.txtLitrosDiaInfLeche.Name = "txtLitrosDiaInfLeche"
        Me.txtLitrosDiaInfLeche.ReadOnly = True
        Me.txtLitrosDiaInfLeche.Size = New System.Drawing.Size(100, 20)
        Me.txtLitrosDiaInfLeche.TabIndex = 4
        '
        'txtGrasasInfLeche
        '
        Me.txtGrasasInfLeche.BackColor = System.Drawing.Color.White
        Me.txtGrasasInfLeche.Location = New System.Drawing.Point(77, 58)
        Me.txtGrasasInfLeche.Name = "txtGrasasInfLeche"
        Me.txtGrasasInfLeche.ReadOnly = True
        Me.txtGrasasInfLeche.Size = New System.Drawing.Size(100, 20)
        Me.txtGrasasInfLeche.TabIndex = 4
        '
        'txtCelSomInfLeche
        '
        Me.txtCelSomInfLeche.BackColor = System.Drawing.Color.White
        Me.txtCelSomInfLeche.Location = New System.Drawing.Point(308, 32)
        Me.txtCelSomInfLeche.Name = "txtCelSomInfLeche"
        Me.txtCelSomInfLeche.ReadOnly = True
        Me.txtCelSomInfLeche.Size = New System.Drawing.Size(100, 20)
        Me.txtCelSomInfLeche.TabIndex = 4
        '
        'txtProteInfLeche
        '
        Me.txtProteInfLeche.BackColor = System.Drawing.Color.White
        Me.txtProteInfLeche.Location = New System.Drawing.Point(308, 62)
        Me.txtProteInfLeche.Name = "txtProteInfLeche"
        Me.txtProteInfLeche.ReadOnly = True
        Me.txtProteInfLeche.Size = New System.Drawing.Size(100, 20)
        Me.txtProteInfLeche.TabIndex = 4
        '
        'gbInformacionLeche
        '
        Me.gbInformacionLeche.Controls.Add(Me.txtProteInfLeche)
        Me.gbInformacionLeche.Controls.Add(Me.txtCelSomInfLeche)
        Me.gbInformacionLeche.Controls.Add(Me.txtGrasasInfLeche)
        Me.gbInformacionLeche.Controls.Add(Me.txtLitrosDiaInfLeche)
        Me.gbInformacionLeche.Controls.Add(Me.lblProteinas)
        Me.gbInformacionLeche.Controls.Add(Me.lblGrasas)
        Me.gbInformacionLeche.Controls.Add(Me.lblCelulasSomaticas)
        Me.gbInformacionLeche.Controls.Add(Me.lblLitrosDia)
        Me.gbInformacionLeche.Location = New System.Drawing.Point(39, 93)
        Me.gbInformacionLeche.Name = "gbInformacionLeche"
        Me.gbInformacionLeche.Size = New System.Drawing.Size(445, 107)
        Me.gbInformacionLeche.TabIndex = 3
        Me.gbInformacionLeche.TabStop = False
        Me.gbInformacionLeche.Visible = False
        '
        'frmInformacionLeche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(524, 285)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.gbInformacionLeche)
        Me.Controls.Add(Me.lblFechaOrdeñe)
        Me.Controls.Add(Me.cmdIdVaca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInformacionLeche"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Información de leche"
        Me.gbInformacionLeche.ResumeLayout(False)
        Me.gbInformacionLeche.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdIdVaca As System.Windows.Forms.Button
    Friend WithEvents lblFechaOrdeñe As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents lblLitrosDia As System.Windows.Forms.Label
    Friend WithEvents lblCelulasSomaticas As System.Windows.Forms.Label
    Friend WithEvents lblGrasas As System.Windows.Forms.Label
    Friend WithEvents lblProteinas As System.Windows.Forms.Label
    Friend WithEvents txtLitrosDiaInfLeche As System.Windows.Forms.TextBox
    Friend WithEvents txtGrasasInfLeche As System.Windows.Forms.TextBox
    Friend WithEvents txtCelSomInfLeche As System.Windows.Forms.TextBox
    Friend WithEvents txtProteInfLeche As System.Windows.Forms.TextBox
    Friend WithEvents gbInformacionLeche As System.Windows.Forms.GroupBox
End Class
