<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecibirAnimales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecibirAnimales))
        Me.contCantidadDeAnimales = New System.Windows.Forms.NumericUpDown()
        Me.dtFechaEnviarAnimales = New System.Windows.Forms.DateTimePicker()
        Me.lblCantAnimales = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.txtIdCampoDeRecria = New System.Windows.Forms.TextBox()
        Me.lblIdCampoDeRecria = New System.Windows.Forms.Label()
        Me.txtIdAnimal = New System.Windows.Forms.TextBox()
        Me.lblIdAnimal = New System.Windows.Forms.Label()
        CType(Me.contCantidadDeAnimales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'contCantidadDeAnimales
        '
        Me.contCantidadDeAnimales.Location = New System.Drawing.Point(222, 199)
        Me.contCantidadDeAnimales.Name = "contCantidadDeAnimales"
        Me.contCantidadDeAnimales.Size = New System.Drawing.Size(120, 20)
        Me.contCantidadDeAnimales.TabIndex = 11
        '
        'dtFechaEnviarAnimales
        '
        Me.dtFechaEnviarAnimales.Location = New System.Drawing.Point(142, 100)
        Me.dtFechaEnviarAnimales.Name = "dtFechaEnviarAnimales"
        Me.dtFechaEnviarAnimales.Size = New System.Drawing.Size(200, 20)
        Me.dtFechaEnviarAnimales.TabIndex = 10
        '
        'lblCantAnimales
        '
        Me.lblCantAnimales.AutoSize = True
        Me.lblCantAnimales.Location = New System.Drawing.Point(40, 200)
        Me.lblCantAnimales.Name = "lblCantAnimales"
        Me.lblCantAnimales.Size = New System.Drawing.Size(111, 13)
        Me.lblCantAnimales.TabIndex = 9
        Me.lblCantAnimales.Text = "Cantidad de animales:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(40, 100)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 8
        Me.lblFecha.Text = "Fecha"
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
        Me.cmdGuardar.Location = New System.Drawing.Point(150, 318)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 34)
        Me.cmdGuardar.TabIndex = 7
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
        Me.cmdAtras.Location = New System.Drawing.Point(10, 12)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(75, 28)
        Me.cmdAtras.TabIndex = 6
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'txtIdCampoDeRecria
        '
        Me.txtIdCampoDeRecria.Location = New System.Drawing.Point(222, 169)
        Me.txtIdCampoDeRecria.Name = "txtIdCampoDeRecria"
        Me.txtIdCampoDeRecria.Size = New System.Drawing.Size(120, 20)
        Me.txtIdCampoDeRecria.TabIndex = 13
        '
        'lblIdCampoDeRecria
        '
        Me.lblIdCampoDeRecria.AutoSize = True
        Me.lblIdCampoDeRecria.Location = New System.Drawing.Point(40, 172)
        Me.lblIdCampoDeRecria.Name = "lblIdCampoDeRecria"
        Me.lblIdCampoDeRecria.Size = New System.Drawing.Size(114, 13)
        Me.lblIdCampoDeRecria.TabIndex = 12
        Me.lblIdCampoDeRecria.Text = "Id del campo de recría"
        '
        'txtIdAnimal
        '
        Me.txtIdAnimal.Location = New System.Drawing.Point(222, 231)
        Me.txtIdAnimal.Name = "txtIdAnimal"
        Me.txtIdAnimal.Size = New System.Drawing.Size(120, 20)
        Me.txtIdAnimal.TabIndex = 15
        '
        'lblIdAnimal
        '
        Me.lblIdAnimal.AutoSize = True
        Me.lblIdAnimal.Location = New System.Drawing.Point(40, 234)
        Me.lblIdAnimal.Name = "lblIdAnimal"
        Me.lblIdAnimal.Size = New System.Drawing.Size(64, 13)
        Me.lblIdAnimal.TabIndex = 14
        Me.lblIdAnimal.Text = "Id de animal"
        '
        'frmRecibirAnimales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(382, 364)
        Me.Controls.Add(Me.txtIdAnimal)
        Me.Controls.Add(Me.lblIdAnimal)
        Me.Controls.Add(Me.txtIdCampoDeRecria)
        Me.Controls.Add(Me.lblIdCampoDeRecria)
        Me.Controls.Add(Me.contCantidadDeAnimales)
        Me.Controls.Add(Me.dtFechaEnviarAnimales)
        Me.Controls.Add(Me.lblCantAnimales)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.cmdAtras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRecibirAnimales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Recibir Animales"
        CType(Me.contCantidadDeAnimales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents contCantidadDeAnimales As System.Windows.Forms.NumericUpDown
    Friend WithEvents dtFechaEnviarAnimales As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCantAnimales As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
    Friend WithEvents txtIdCampoDeRecria As System.Windows.Forms.TextBox
    Friend WithEvents lblIdCampoDeRecria As System.Windows.Forms.Label
    Friend WithEvents txtIdAnimal As System.Windows.Forms.TextBox
    Friend WithEvents lblIdAnimal As System.Windows.Forms.Label
End Class
