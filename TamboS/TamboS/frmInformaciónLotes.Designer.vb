<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformaciónLotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformaciónLotes))
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.txtIdLoteBuscar = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.lblIdLote = New System.Windows.Forms.Label()
        Me.TablaVaca = New System.Windows.Forms.DataGridView()
        Me.IdVaca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Raza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LitrosDia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblInfoVacas = New System.Windows.Forms.Label()
        CType(Me.TablaVaca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAtras
        '
        Me.cmdAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAtras.FlatAppearance.BorderSize = 0
        Me.cmdAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAtras.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdAtras.Image = CType(resources.GetObject("cmdAtras.Image"), System.Drawing.Image)
        Me.cmdAtras.Location = New System.Drawing.Point(12, 12)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(75, 27)
        Me.cmdAtras.TabIndex = 18
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = True
        '
        'txtIdLoteBuscar
        '
        Me.txtIdLoteBuscar.Location = New System.Drawing.Point(133, 85)
        Me.txtIdLoteBuscar.Name = "txtIdLoteBuscar"
        Me.txtIdLoteBuscar.Size = New System.Drawing.Size(120, 20)
        Me.txtIdLoteBuscar.TabIndex = 15
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
        Me.cmdBuscar.Location = New System.Drawing.Point(351, 79)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 31)
        Me.cmdBuscar.TabIndex = 14
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'lblIdLote
        '
        Me.lblIdLote.AutoSize = True
        Me.lblIdLote.Location = New System.Drawing.Point(76, 88)
        Me.lblIdLote.Name = "lblIdLote"
        Me.lblIdLote.Size = New System.Drawing.Size(40, 13)
        Me.lblIdLote.TabIndex = 12
        Me.lblIdLote.Text = "Id Lote"
        '
        'TablaVaca
        '
        Me.TablaVaca.AllowUserToAddRows = False
        Me.TablaVaca.AllowUserToDeleteRows = False
        Me.TablaVaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaVaca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdVaca, Me.Edad, Me.Raza, Me.LitrosDia, Me.Estado})
        Me.TablaVaca.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TablaVaca.Location = New System.Drawing.Point(0, 283)
        Me.TablaVaca.Name = "TablaVaca"
        Me.TablaVaca.ReadOnly = True
        Me.TablaVaca.Size = New System.Drawing.Size(534, 206)
        Me.TablaVaca.TabIndex = 19
        Me.TablaVaca.Visible = False
        '
        'IdVaca
        '
        Me.IdVaca.HeaderText = "Id de Vaca"
        Me.IdVaca.Name = "IdVaca"
        Me.IdVaca.ReadOnly = True
        '
        'Edad
        '
        Me.Edad.HeaderText = "Edad"
        Me.Edad.Name = "Edad"
        Me.Edad.ReadOnly = True
        '
        'Raza
        '
        Me.Raza.HeaderText = "Raza"
        Me.Raza.Name = "Raza"
        Me.Raza.ReadOnly = True
        '
        'LitrosDia
        '
        Me.LitrosDia.HeaderText = "Litros Día"
        Me.LitrosDia.Name = "LitrosDia"
        Me.LitrosDia.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'lblInfoVacas
        '
        Me.lblInfoVacas.AutoSize = True
        Me.lblInfoVacas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoVacas.Location = New System.Drawing.Point(183, 256)
        Me.lblInfoVacas.Name = "lblInfoVacas"
        Me.lblInfoVacas.Size = New System.Drawing.Size(142, 24)
        Me.lblInfoVacas.TabIndex = 20
        Me.lblInfoVacas.Text = "Vacas del lote"
        Me.lblInfoVacas.Visible = False
        '
        'frmInformaciónLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(534, 489)
        Me.Controls.Add(Me.lblInfoVacas)
        Me.Controls.Add(Me.TablaVaca)
        Me.Controls.Add(Me.cmdAtras)
        Me.Controls.Add(Me.txtIdLoteBuscar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.lblIdLote)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInformaciónLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Información lotes"
        CType(Me.TablaVaca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
    Friend WithEvents txtIdLoteBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents lblIdLote As System.Windows.Forms.Label
    Friend WithEvents TablaVaca As System.Windows.Forms.DataGridView
    Friend WithEvents IdVaca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Edad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Raza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LitrosDia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblInfoVacas As System.Windows.Forms.Label
End Class
