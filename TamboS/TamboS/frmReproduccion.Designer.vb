<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReproduccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReproduccion))
        Me.lblFechaReproduccion = New System.Windows.Forms.Label()
        Me.lblTipoReproduccion = New System.Windows.Forms.Label()
        Me.gbToro = New System.Windows.Forms.GroupBox()
        Me.txtIdToro = New System.Windows.Forms.TextBox()
        Me.lblIdToro = New System.Windows.Forms.Label()
        Me.cbTipoReproduccion = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.txtIdVaca = New System.Windows.Forms.TextBox()
        Me.lblVaca = New System.Windows.Forms.Label()
        Me.gbToro.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFechaReproduccion
        '
        Me.lblFechaReproduccion.AutoSize = True
        Me.lblFechaReproduccion.Location = New System.Drawing.Point(50, 101)
        Me.lblFechaReproduccion.Name = "lblFechaReproduccion"
        Me.lblFechaReproduccion.Size = New System.Drawing.Size(37, 13)
        Me.lblFechaReproduccion.TabIndex = 0
        Me.lblFechaReproduccion.Text = "Fecha"
        '
        'lblTipoReproduccion
        '
        Me.lblTipoReproduccion.AutoSize = True
        Me.lblTipoReproduccion.Location = New System.Drawing.Point(50, 173)
        Me.lblTipoReproduccion.Name = "lblTipoReproduccion"
        Me.lblTipoReproduccion.Size = New System.Drawing.Size(113, 13)
        Me.lblTipoReproduccion.TabIndex = 1
        Me.lblTipoReproduccion.Text = "Tipo de Reproducción"
        '
        'gbToro
        '
        Me.gbToro.Controls.Add(Me.txtIdToro)
        Me.gbToro.Controls.Add(Me.lblIdToro)
        Me.gbToro.Location = New System.Drawing.Point(39, 235)
        Me.gbToro.Name = "gbToro"
        Me.gbToro.Size = New System.Drawing.Size(424, 87)
        Me.gbToro.TabIndex = 2
        Me.gbToro.TabStop = False
        Me.gbToro.Visible = False
        '
        'txtIdToro
        '
        Me.txtIdToro.Location = New System.Drawing.Point(188, 33)
        Me.txtIdToro.Name = "txtIdToro"
        Me.txtIdToro.Size = New System.Drawing.Size(200, 20)
        Me.txtIdToro.TabIndex = 1
        '
        'lblIdToro
        '
        Me.lblIdToro.AutoSize = True
        Me.lblIdToro.Location = New System.Drawing.Point(46, 36)
        Me.lblIdToro.Name = "lblIdToro"
        Me.lblIdToro.Size = New System.Drawing.Size(41, 13)
        Me.lblIdToro.TabIndex = 0
        Me.lblIdToro.Text = "Id Toro"
        '
        'cbTipoReproduccion
        '
        Me.cbTipoReproduccion.FormattingEnabled = True
        Me.cbTipoReproduccion.Items.AddRange(New Object() {"Inseminación artificial", "Entore"})
        Me.cbTipoReproduccion.Location = New System.Drawing.Point(241, 165)
        Me.cbTipoReproduccion.Name = "cbTipoReproduccion"
        Me.cbTipoReproduccion.Size = New System.Drawing.Size(200, 21)
        Me.cbTipoReproduccion.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(241, 101)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'cmdGuardar
        '
        Me.cmdGuardar.BackColor = System.Drawing.Color.Transparent
        Me.cmdGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGuardar.FlatAppearance.BorderSize = 0
        Me.cmdGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.Location = New System.Drawing.Point(241, 428)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 27)
        Me.cmdGuardar.TabIndex = 5
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = False
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
        Me.cmdAtras.Location = New System.Drawing.Point(12, 12)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(75, 27)
        Me.cmdAtras.TabIndex = 6
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'txtIdVaca
        '
        Me.txtIdVaca.Location = New System.Drawing.Point(241, 71)
        Me.txtIdVaca.Name = "txtIdVaca"
        Me.txtIdVaca.Size = New System.Drawing.Size(200, 20)
        Me.txtIdVaca.TabIndex = 1
        '
        'lblVaca
        '
        Me.lblVaca.AutoSize = True
        Me.lblVaca.Location = New System.Drawing.Point(50, 74)
        Me.lblVaca.Name = "lblVaca"
        Me.lblVaca.Size = New System.Drawing.Size(44, 13)
        Me.lblVaca.TabIndex = 0
        Me.lblVaca.Text = "Id Vaca"
        '
        'frmReproduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(544, 500)
        Me.Controls.Add(Me.txtIdVaca)
        Me.Controls.Add(Me.lblVaca)
        Me.Controls.Add(Me.cmdAtras)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cbTipoReproduccion)
        Me.Controls.Add(Me.gbToro)
        Me.Controls.Add(Me.lblTipoReproduccion)
        Me.Controls.Add(Me.lblFechaReproduccion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReproduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Reproducción"
        Me.gbToro.ResumeLayout(False)
        Me.gbToro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFechaReproduccion As System.Windows.Forms.Label
    Friend WithEvents lblTipoReproduccion As System.Windows.Forms.Label
    Friend WithEvents gbToro As System.Windows.Forms.GroupBox
    Friend WithEvents txtIdToro As System.Windows.Forms.TextBox
    Friend WithEvents lblIdToro As System.Windows.Forms.Label
    Friend WithEvents cbTipoReproduccion As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
    Friend WithEvents txtIdVaca As System.Windows.Forms.TextBox
    Friend WithEvents lblVaca As System.Windows.Forms.Label
End Class
