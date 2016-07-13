<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametros))
        Me.lblVacasLote = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lblHectareas = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.lblMaxVacas = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.lblMaxOrdeñe = New System.Windows.Forms.Label()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.lblHoraOrdeñe1 = New System.Windows.Forms.Label()
        Me.lblHoraOrdeñe2 = New System.Windows.Forms.Label()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.dtPrimerOrdeñe = New System.Windows.Forms.DateTimePicker()
        Me.dtSegundoOrdeñe = New System.Windows.Forms.DateTimePicker()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVacasLote
        '
        Me.lblVacasLote.AutoSize = True
        Me.lblVacasLote.Location = New System.Drawing.Point(75, 60)
        Me.lblVacasLote.Name = "lblVacasLote"
        Me.lblVacasLote.Size = New System.Drawing.Size(132, 13)
        Me.lblVacasLote.TabIndex = 0
        Me.lblVacasLote.Text = "Número de vacas por lote:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(299, 53)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(82, 20)
        Me.NumericUpDown1.TabIndex = 1
        '
        'lblHectareas
        '
        Me.lblHectareas.AutoSize = True
        Me.lblHectareas.Location = New System.Drawing.Point(70, 96)
        Me.lblHectareas.Name = "lblHectareas"
        Me.lblHectareas.Size = New System.Drawing.Size(152, 13)
        Me.lblHectareas.TabIndex = 2
        Me.lblHectareas.Text = "Hectáreas del establecimiento:"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(299, 89)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(82, 20)
        Me.NumericUpDown2.TabIndex = 3
        '
        'lblMaxVacas
        '
        Me.lblMaxVacas.AutoSize = True
        Me.lblMaxVacas.Location = New System.Drawing.Point(70, 134)
        Me.lblMaxVacas.Name = "lblMaxVacas"
        Me.lblMaxVacas.Size = New System.Drawing.Size(137, 13)
        Me.lblMaxVacas.TabIndex = 4
        Me.lblMaxVacas.Text = "Cantidad máxima de vacas:"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(299, 127)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(82, 20)
        Me.NumericUpDown3.TabIndex = 5
        '
        'lblMaxOrdeñe
        '
        Me.lblMaxOrdeñe.AutoSize = True
        Me.lblMaxOrdeñe.Location = New System.Drawing.Point(70, 175)
        Me.lblMaxOrdeñe.Name = "lblMaxOrdeñe"
        Me.lblMaxOrdeñe.Size = New System.Drawing.Size(199, 13)
        Me.lblMaxOrdeñe.TabIndex = 6
        Me.lblMaxOrdeñe.Text = "Cantidad máxima de vacas en el ordeñe:"
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(299, 168)
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(82, 20)
        Me.NumericUpDown4.TabIndex = 7
        '
        'lblHoraOrdeñe1
        '
        Me.lblHoraOrdeñe1.AutoSize = True
        Me.lblHoraOrdeñe1.Location = New System.Drawing.Point(70, 212)
        Me.lblHoraOrdeñe1.Name = "lblHoraOrdeñe1"
        Me.lblHoraOrdeñe1.Size = New System.Drawing.Size(117, 13)
        Me.lblHoraOrdeñe1.TabIndex = 8
        Me.lblHoraOrdeñe1.Text = "Hora del primer ordeñe:"
        '
        'lblHoraOrdeñe2
        '
        Me.lblHoraOrdeñe2.AutoSize = True
        Me.lblHoraOrdeñe2.Location = New System.Drawing.Point(70, 247)
        Me.lblHoraOrdeñe2.Name = "lblHoraOrdeñe2"
        Me.lblHoraOrdeñe2.Size = New System.Drawing.Size(130, 13)
        Me.lblHoraOrdeñe2.TabIndex = 9
        Me.lblHoraOrdeñe2.Text = "Hora del segundo ordeñe:"
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
        Me.cmdGuardar.Location = New System.Drawing.Point(161, 322)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 29)
        Me.cmdGuardar.TabIndex = 10
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
        Me.cmdAtras.Location = New System.Drawing.Point(25, 13)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(75, 28)
        Me.cmdAtras.TabIndex = 11
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'dtPrimerOrdeñe
        '
        Me.dtPrimerOrdeñe.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtPrimerOrdeñe.Location = New System.Drawing.Point(299, 205)
        Me.dtPrimerOrdeñe.Name = "dtPrimerOrdeñe"
        Me.dtPrimerOrdeñe.Size = New System.Drawing.Size(82, 20)
        Me.dtPrimerOrdeñe.TabIndex = 12
        '
        'dtSegundoOrdeñe
        '
        Me.dtSegundoOrdeñe.CustomFormat = ""
        Me.dtSegundoOrdeñe.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtSegundoOrdeñe.Location = New System.Drawing.Point(299, 247)
        Me.dtSegundoOrdeñe.Name = "dtSegundoOrdeñe"
        Me.dtSegundoOrdeñe.Size = New System.Drawing.Size(82, 20)
        Me.dtSegundoOrdeñe.TabIndex = 13
        '
        'frmParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(412, 373)
        Me.Controls.Add(Me.dtSegundoOrdeñe)
        Me.Controls.Add(Me.dtPrimerOrdeñe)
        Me.Controls.Add(Me.cmdAtras)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.lblHoraOrdeñe2)
        Me.Controls.Add(Me.lblHoraOrdeñe1)
        Me.Controls.Add(Me.NumericUpDown4)
        Me.Controls.Add(Me.lblMaxOrdeñe)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.lblMaxVacas)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.lblHectareas)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.lblVacasLote)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmParametros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Parámetros"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVacasLote As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblHectareas As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMaxVacas As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMaxOrdeñe As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblHoraOrdeñe1 As System.Windows.Forms.Label
    Friend WithEvents lblHoraOrdeñe2 As System.Windows.Forms.Label
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
    Friend WithEvents dtPrimerOrdeñe As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtSegundoOrdeñe As System.Windows.Forms.DateTimePicker
End Class
