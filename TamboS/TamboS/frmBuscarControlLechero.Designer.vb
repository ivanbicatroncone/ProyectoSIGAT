<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarControlLechero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarControlLechero))
        Me.lblBusqueda = New System.Windows.Forms.Label()
        Me.cbBusqueda = New System.Windows.Forms.ComboBox()
        Me.tablaPorVaca = New System.Windows.Forms.DataGridView()
        Me.FechaControl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grasas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proteinas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelulasSomaticas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaControlLechero = New System.Windows.Forms.DateTimePicker()
        Me.txtIdVaca = New System.Windows.Forms.TextBox()
        Me.lblIdVaca = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.tablaPorFecha = New System.Windows.Forms.DataGridView()
        Me.IdVaca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrasasPorFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProteinasPorFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelulasSomaticasPorFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdAtras = New System.Windows.Forms.Button()
        CType(Me.tablaPorVaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaPorFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBusqueda
        '
        Me.lblBusqueda.AutoSize = True
        Me.lblBusqueda.Location = New System.Drawing.Point(60, 59)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Size = New System.Drawing.Size(55, 13)
        Me.lblBusqueda.TabIndex = 0
        Me.lblBusqueda.Text = "Busqueda"
        '
        'cbBusqueda
        '
        Me.cbBusqueda.FormattingEnabled = True
        Me.cbBusqueda.Items.AddRange(New Object() {"Por vaca", "Por fecha"})
        Me.cbBusqueda.Location = New System.Drawing.Point(158, 51)
        Me.cbBusqueda.Name = "cbBusqueda"
        Me.cbBusqueda.Size = New System.Drawing.Size(254, 21)
        Me.cbBusqueda.TabIndex = 1
        '
        'tablaPorVaca
        '
        Me.tablaPorVaca.AllowUserToAddRows = False
        Me.tablaPorVaca.AllowUserToDeleteRows = False
        Me.tablaPorVaca.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tablaPorVaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaPorVaca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaControl, Me.Grasas, Me.Proteinas, Me.CelulasSomaticas})
        Me.tablaPorVaca.Location = New System.Drawing.Point(-1, 169)
        Me.tablaPorVaca.Name = "tablaPorVaca"
        Me.tablaPorVaca.ReadOnly = True
        Me.tablaPorVaca.Size = New System.Drawing.Size(535, 322)
        Me.tablaPorVaca.TabIndex = 2
        Me.tablaPorVaca.Visible = False
        '
        'FechaControl
        '
        Me.FechaControl.HeaderText = "Fecha"
        Me.FechaControl.Name = "FechaControl"
        Me.FechaControl.ReadOnly = True
        '
        'Grasas
        '
        Me.Grasas.HeaderText = "Grasas"
        Me.Grasas.Name = "Grasas"
        Me.Grasas.ReadOnly = True
        '
        'Proteinas
        '
        Me.Proteinas.HeaderText = "Proteinas"
        Me.Proteinas.Name = "Proteinas"
        Me.Proteinas.ReadOnly = True
        '
        'CelulasSomaticas
        '
        Me.CelulasSomaticas.HeaderText = "Células Somáticas"
        Me.CelulasSomaticas.Name = "CelulasSomaticas"
        Me.CelulasSomaticas.ReadOnly = True
        '
        'FechaControlLechero
        '
        Me.FechaControlLechero.Location = New System.Drawing.Point(212, 111)
        Me.FechaControlLechero.Name = "FechaControlLechero"
        Me.FechaControlLechero.Size = New System.Drawing.Size(200, 20)
        Me.FechaControlLechero.TabIndex = 12
        Me.FechaControlLechero.Visible = False
        '
        'txtIdVaca
        '
        Me.txtIdVaca.Location = New System.Drawing.Point(212, 83)
        Me.txtIdVaca.Name = "txtIdVaca"
        Me.txtIdVaca.Size = New System.Drawing.Size(200, 20)
        Me.txtIdVaca.TabIndex = 11
        Me.txtIdVaca.Visible = False
        '
        'lblIdVaca
        '
        Me.lblIdVaca.AutoSize = True
        Me.lblIdVaca.Location = New System.Drawing.Point(60, 90)
        Me.lblIdVaca.Name = "lblIdVaca"
        Me.lblIdVaca.Size = New System.Drawing.Size(44, 13)
        Me.lblIdVaca.TabIndex = 10
        Me.lblIdVaca.Text = "Id Vaca"
        Me.lblIdVaca.Visible = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(60, 118)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 9
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.Visible = False
        '
        'tablaPorFecha
        '
        Me.tablaPorFecha.AllowUserToAddRows = False
        Me.tablaPorFecha.AllowUserToDeleteRows = False
        Me.tablaPorFecha.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tablaPorFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaPorFecha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdVaca, Me.GrasasPorFecha, Me.ProteinasPorFecha, Me.CelulasSomaticasPorFecha})
        Me.tablaPorFecha.Location = New System.Drawing.Point(-1, 169)
        Me.tablaPorFecha.Name = "tablaPorFecha"
        Me.tablaPorFecha.ReadOnly = True
        Me.tablaPorFecha.Size = New System.Drawing.Size(469, 322)
        Me.tablaPorFecha.TabIndex = 13
        Me.tablaPorFecha.Visible = False
        '
        'IdVaca
        '
        Me.IdVaca.HeaderText = "Id Vaca"
        Me.IdVaca.Name = "IdVaca"
        Me.IdVaca.ReadOnly = True
        '
        'GrasasPorFecha
        '
        Me.GrasasPorFecha.HeaderText = "Grasas"
        Me.GrasasPorFecha.Name = "GrasasPorFecha"
        Me.GrasasPorFecha.ReadOnly = True
        '
        'ProteinasPorFecha
        '
        Me.ProteinasPorFecha.HeaderText = "Proteinas"
        Me.ProteinasPorFecha.Name = "ProteinasPorFecha"
        Me.ProteinasPorFecha.ReadOnly = True
        '
        'CelulasSomaticasPorFecha
        '
        Me.CelulasSomaticasPorFecha.HeaderText = "Células Somáticas"
        Me.CelulasSomaticasPorFecha.Name = "CelulasSomaticasPorFecha"
        Me.CelulasSomaticasPorFecha.ReadOnly = True
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
        Me.cmdAtras.Size = New System.Drawing.Size(75, 26)
        Me.cmdAtras.TabIndex = 14
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'frmBuscarControlLechero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(467, 489)
        Me.Controls.Add(Me.cmdAtras)
        Me.Controls.Add(Me.tablaPorFecha)
        Me.Controls.Add(Me.FechaControlLechero)
        Me.Controls.Add(Me.txtIdVaca)
        Me.Controls.Add(Me.lblIdVaca)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.tablaPorVaca)
        Me.Controls.Add(Me.cbBusqueda)
        Me.Controls.Add(Me.lblBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmBuscarControlLechero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Buscar control lechero"
        CType(Me.tablaPorVaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaPorFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBusqueda As System.Windows.Forms.Label
    Friend WithEvents cbBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents tablaPorVaca As System.Windows.Forms.DataGridView
    Friend WithEvents FechaControl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grasas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proteinas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CelulasSomaticas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaControlLechero As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtIdVaca As System.Windows.Forms.TextBox
    Friend WithEvents lblIdVaca As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents tablaPorFecha As System.Windows.Forms.DataGridView
    Friend WithEvents IdVaca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrasasPorFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProteinasPorFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CelulasSomaticasPorFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
End Class
