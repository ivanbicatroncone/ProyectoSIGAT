<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdeñe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdeñe))
        Me.lblFechaOrdeñe = New System.Windows.Forms.Label()
        Me.lblLitrosOrdeñe = New System.Windows.Forms.Label()
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.cmdGuardarCambios = New System.Windows.Forms.Button()
        Me.txtLitrosDia = New System.Windows.Forms.TextBox()
        Me.dtFechaOrdeñe = New System.Windows.Forms.DateTimePicker()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.cbHora = New System.Windows.Forms.ComboBox()
        Me.lblIdLote = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblFechaOrdeñeBusqueda = New System.Windows.Forms.Label()
        Me.DateOrdeñeBusqueda = New System.Windows.Forms.DateTimePicker()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.lblHoraBuscar = New System.Windows.Forms.Label()
        Me.cbHoraBusqueda = New System.Windows.Forms.ComboBox()
        Me.TablaOrdeñes = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LitrosDia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idLote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelulasSomaticas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proteinas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grasas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TablaOrdeñes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFechaOrdeñe
        '
        Me.lblFechaOrdeñe.AutoSize = True
        Me.lblFechaOrdeñe.Location = New System.Drawing.Point(60, 83)
        Me.lblFechaOrdeñe.Name = "lblFechaOrdeñe"
        Me.lblFechaOrdeñe.Size = New System.Drawing.Size(40, 13)
        Me.lblFechaOrdeñe.TabIndex = 0
        Me.lblFechaOrdeñe.Text = "Fecha:"
        '
        'lblLitrosOrdeñe
        '
        Me.lblLitrosOrdeñe.AutoSize = True
        Me.lblLitrosOrdeñe.Location = New System.Drawing.Point(354, 83)
        Me.lblLitrosOrdeñe.Name = "lblLitrosOrdeñe"
        Me.lblLitrosOrdeñe.Size = New System.Drawing.Size(88, 13)
        Me.lblLitrosOrdeñe.TabIndex = 1
        Me.lblLitrosOrdeñe.Text = "Litros del ordeñe:"
        '
        'cmdAtras
        '
        Me.cmdAtras.BackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAtras.FlatAppearance.BorderSize = 0
        Me.cmdAtras.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAtras.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdAtras.Image = CType(resources.GetObject("cmdAtras.Image"), System.Drawing.Image)
        Me.cmdAtras.Location = New System.Drawing.Point(7, 7)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(75, 27)
        Me.cmdAtras.TabIndex = 2
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'cmdGuardarCambios
        '
        Me.cmdGuardarCambios.BackColor = System.Drawing.Color.Transparent
        Me.cmdGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGuardarCambios.FlatAppearance.BorderSize = 0
        Me.cmdGuardarCambios.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdGuardarCambios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdGuardarCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGuardarCambios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardarCambios.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdGuardarCambios.Image = CType(resources.GetObject("cmdGuardarCambios.Image"), System.Drawing.Image)
        Me.cmdGuardarCambios.Location = New System.Drawing.Point(346, 195)
        Me.cmdGuardarCambios.Name = "cmdGuardarCambios"
        Me.cmdGuardarCambios.Size = New System.Drawing.Size(75, 31)
        Me.cmdGuardarCambios.TabIndex = 3
        Me.cmdGuardarCambios.Text = "Guardar"
        Me.cmdGuardarCambios.UseVisualStyleBackColor = False
        '
        'txtLitrosDia
        '
        Me.txtLitrosDia.Location = New System.Drawing.Point(496, 79)
        Me.txtLitrosDia.Name = "txtLitrosDia"
        Me.txtLitrosDia.Size = New System.Drawing.Size(200, 20)
        Me.txtLitrosDia.TabIndex = 5
        '
        'dtFechaOrdeñe
        '
        Me.dtFechaOrdeñe.Location = New System.Drawing.Point(131, 76)
        Me.dtFechaOrdeñe.Name = "dtFechaOrdeñe"
        Me.dtFechaOrdeñe.Size = New System.Drawing.Size(200, 20)
        Me.dtFechaOrdeñe.TabIndex = 6
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(60, 118)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(33, 13)
        Me.lblHora.TabIndex = 7
        Me.lblHora.Text = "Hora:"
        '
        'cbHora
        '
        Me.cbHora.FormattingEnabled = True
        Me.cbHora.Items.AddRange(New Object() {"Mañana", "Tarde"})
        Me.cbHora.Location = New System.Drawing.Point(131, 116)
        Me.cbHora.Name = "cbHora"
        Me.cbHora.Size = New System.Drawing.Size(200, 21)
        Me.cbHora.TabIndex = 8
        '
        'lblIdLote
        '
        Me.lblIdLote.AutoSize = True
        Me.lblIdLote.Location = New System.Drawing.Point(357, 120)
        Me.lblIdLote.Name = "lblIdLote"
        Me.lblIdLote.Size = New System.Drawing.Size(43, 13)
        Me.lblIdLote.TabIndex = 9
        Me.lblIdLote.Text = "Id Lote:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(496, 120)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 10
        '
        'lblFechaOrdeñeBusqueda
        '
        Me.lblFechaOrdeñeBusqueda.AutoSize = True
        Me.lblFechaOrdeñeBusqueda.Location = New System.Drawing.Point(60, 256)
        Me.lblFechaOrdeñeBusqueda.Name = "lblFechaOrdeñeBusqueda"
        Me.lblFechaOrdeñeBusqueda.Size = New System.Drawing.Size(40, 13)
        Me.lblFechaOrdeñeBusqueda.TabIndex = 7
        Me.lblFechaOrdeñeBusqueda.Text = "Fecha:"
        '
        'DateOrdeñeBusqueda
        '
        Me.DateOrdeñeBusqueda.Location = New System.Drawing.Point(131, 249)
        Me.DateOrdeñeBusqueda.Name = "DateOrdeñeBusqueda"
        Me.DateOrdeñeBusqueda.Size = New System.Drawing.Size(200, 20)
        Me.DateOrdeñeBusqueda.TabIndex = 6
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.Color.Transparent
        Me.cmdBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBuscar.FlatAppearance.BorderSize = 0
        Me.cmdBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.Location = New System.Drawing.Point(346, 299)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 30)
        Me.cmdBuscar.TabIndex = 3
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'lblHoraBuscar
        '
        Me.lblHoraBuscar.AutoSize = True
        Me.lblHoraBuscar.Location = New System.Drawing.Point(357, 256)
        Me.lblHoraBuscar.Name = "lblHoraBuscar"
        Me.lblHoraBuscar.Size = New System.Drawing.Size(33, 13)
        Me.lblHoraBuscar.TabIndex = 7
        Me.lblHoraBuscar.Text = "Hora:"
        '
        'cbHoraBusqueda
        '
        Me.cbHoraBusqueda.FormattingEnabled = True
        Me.cbHoraBusqueda.Items.AddRange(New Object() {"Mañana", "Tarde"})
        Me.cbHoraBusqueda.Location = New System.Drawing.Point(496, 248)
        Me.cbHoraBusqueda.Name = "cbHoraBusqueda"
        Me.cbHoraBusqueda.Size = New System.Drawing.Size(200, 21)
        Me.cbHoraBusqueda.TabIndex = 8
        '
        'TablaOrdeñes
        '
        Me.TablaOrdeñes.AllowUserToAddRows = False
        Me.TablaOrdeñes.AllowUserToDeleteRows = False
        Me.TablaOrdeñes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaOrdeñes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Hora, Me.LitrosDia, Me.idLote, Me.CelulasSomaticas, Me.Proteinas, Me.Grasas})
        Me.TablaOrdeñes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TablaOrdeñes.Location = New System.Drawing.Point(0, 352)
        Me.TablaOrdeñes.Name = "TablaOrdeñes"
        Me.TablaOrdeñes.ReadOnly = True
        Me.TablaOrdeñes.Size = New System.Drawing.Size(784, 213)
        Me.TablaOrdeñes.TabIndex = 11
        Me.TablaOrdeñes.Visible = False
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Hora
        '
        Me.Hora.HeaderText = "Hora"
        Me.Hora.Name = "Hora"
        Me.Hora.ReadOnly = True
        '
        'LitrosDia
        '
        Me.LitrosDia.HeaderText = "Litros día"
        Me.LitrosDia.Name = "LitrosDia"
        Me.LitrosDia.ReadOnly = True
        '
        'idLote
        '
        Me.idLote.HeaderText = "Id Lotes"
        Me.idLote.Name = "idLote"
        Me.idLote.ReadOnly = True
        '
        'CelulasSomaticas
        '
        Me.CelulasSomaticas.HeaderText = "Células somáticas"
        Me.CelulasSomaticas.Name = "CelulasSomaticas"
        Me.CelulasSomaticas.ReadOnly = True
        '
        'Proteinas
        '
        Me.Proteinas.HeaderText = "Proteínas"
        Me.Proteinas.Name = "Proteinas"
        Me.Proteinas.ReadOnly = True
        '
        'Grasas
        '
        Me.Grasas.HeaderText = "Grasas"
        Me.Grasas.Name = "Grasas"
        Me.Grasas.ReadOnly = True
        '
        'frmOrdeñe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 565)
        Me.Controls.Add(Me.TablaOrdeñes)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblIdLote)
        Me.Controls.Add(Me.cbHoraBusqueda)
        Me.Controls.Add(Me.cbHora)
        Me.Controls.Add(Me.lblHoraBuscar)
        Me.Controls.Add(Me.lblFechaOrdeñeBusqueda)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.DateOrdeñeBusqueda)
        Me.Controls.Add(Me.dtFechaOrdeñe)
        Me.Controls.Add(Me.txtLitrosDia)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdGuardarCambios)
        Me.Controls.Add(Me.cmdAtras)
        Me.Controls.Add(Me.lblLitrosOrdeñe)
        Me.Controls.Add(Me.lblFechaOrdeñe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOrdeñe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Ordeñe"
        CType(Me.TablaOrdeñes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFechaOrdeñe As System.Windows.Forms.Label
    Friend WithEvents lblLitrosOrdeñe As System.Windows.Forms.Label
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
    Friend WithEvents cmdGuardarCambios As System.Windows.Forms.Button
    Friend WithEvents txtLitrosDia As System.Windows.Forms.TextBox
    Friend WithEvents dtFechaOrdeñe As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents cbHora As System.Windows.Forms.ComboBox
    Friend WithEvents lblIdLote As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaOrdeñeBusqueda As System.Windows.Forms.Label
    Friend WithEvents DateOrdeñeBusqueda As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents lblHoraBuscar As System.Windows.Forms.Label
    Friend WithEvents cbHoraBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents TablaOrdeñes As System.Windows.Forms.DataGridView
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LitrosDia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idLote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CelulasSomaticas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proteinas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grasas As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
