<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnviarAnimales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnviarAnimales))
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.cmdEnviar = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCantAnimales = New System.Windows.Forms.Label()
        Me.dtFechaEnviarAnimales = New System.Windows.Forms.DateTimePicker()
        Me.contCantidadDeAnimales = New System.Windows.Forms.NumericUpDown()
        Me.lblIdCampoDeRecria = New System.Windows.Forms.Label()
        Me.txtIdCampoDeRecria = New System.Windows.Forms.TextBox()
        Me.txtIdAnimal = New System.Windows.Forms.TextBox()
        Me.lblIdAnimal = New System.Windows.Forms.Label()
        CType(Me.contCantidadDeAnimales, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cmdAtras.Location = New System.Drawing.Point(7, 7)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(75, 23)
        Me.cmdAtras.TabIndex = 0
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'cmdEnviar
        '
        Me.cmdEnviar.BackColor = System.Drawing.Color.Transparent
        Me.cmdEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEnviar.FlatAppearance.BorderSize = 0
        Me.cmdEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnviar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdEnviar.Image = CType(resources.GetObject("cmdEnviar.Image"), System.Drawing.Image)
        Me.cmdEnviar.Location = New System.Drawing.Point(165, 349)
        Me.cmdEnviar.Name = "cmdEnviar"
        Me.cmdEnviar.Size = New System.Drawing.Size(75, 33)
        Me.cmdEnviar.TabIndex = 1
        Me.cmdEnviar.Text = "Enviar"
        Me.cmdEnviar.UseVisualStyleBackColor = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(44, 87)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Fecha"
        '
        'lblCantAnimales
        '
        Me.lblCantAnimales.AutoSize = True
        Me.lblCantAnimales.Location = New System.Drawing.Point(44, 181)
        Me.lblCantAnimales.Name = "lblCantAnimales"
        Me.lblCantAnimales.Size = New System.Drawing.Size(108, 13)
        Me.lblCantAnimales.TabIndex = 3
        Me.lblCantAnimales.Text = "Cantidad de animales"
        '
        'dtFechaEnviarAnimales
        '
        Me.dtFechaEnviarAnimales.Location = New System.Drawing.Point(165, 87)
        Me.dtFechaEnviarAnimales.Name = "dtFechaEnviarAnimales"
        Me.dtFechaEnviarAnimales.Size = New System.Drawing.Size(200, 20)
        Me.dtFechaEnviarAnimales.TabIndex = 4
        '
        'contCantidadDeAnimales
        '
        Me.contCantidadDeAnimales.Location = New System.Drawing.Point(228, 181)
        Me.contCantidadDeAnimales.Name = "contCantidadDeAnimales"
        Me.contCantidadDeAnimales.Size = New System.Drawing.Size(120, 20)
        Me.contCantidadDeAnimales.TabIndex = 5
        '
        'lblIdCampoDeRecria
        '
        Me.lblIdCampoDeRecria.AutoSize = True
        Me.lblIdCampoDeRecria.Location = New System.Drawing.Point(44, 149)
        Me.lblIdCampoDeRecria.Name = "lblIdCampoDeRecria"
        Me.lblIdCampoDeRecria.Size = New System.Drawing.Size(114, 13)
        Me.lblIdCampoDeRecria.TabIndex = 6
        Me.lblIdCampoDeRecria.Text = "Id del campo de recría"
        '
        'txtIdCampoDeRecria
        '
        Me.txtIdCampoDeRecria.Location = New System.Drawing.Point(228, 149)
        Me.txtIdCampoDeRecria.Name = "txtIdCampoDeRecria"
        Me.txtIdCampoDeRecria.Size = New System.Drawing.Size(120, 20)
        Me.txtIdCampoDeRecria.TabIndex = 7
        '
        'txtIdAnimal
        '
        Me.txtIdAnimal.Location = New System.Drawing.Point(228, 217)
        Me.txtIdAnimal.Name = "txtIdAnimal"
        Me.txtIdAnimal.Size = New System.Drawing.Size(120, 20)
        Me.txtIdAnimal.TabIndex = 9
        '
        'lblIdAnimal
        '
        Me.lblIdAnimal.AutoSize = True
        Me.lblIdAnimal.Location = New System.Drawing.Point(44, 217)
        Me.lblIdAnimal.Name = "lblIdAnimal"
        Me.lblIdAnimal.Size = New System.Drawing.Size(64, 13)
        Me.lblIdAnimal.TabIndex = 8
        Me.lblIdAnimal.Text = "Id de animal"
        '
        'frmEnviarAnimales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(419, 394)
        Me.Controls.Add(Me.txtIdAnimal)
        Me.Controls.Add(Me.lblIdAnimal)
        Me.Controls.Add(Me.txtIdCampoDeRecria)
        Me.Controls.Add(Me.lblIdCampoDeRecria)
        Me.Controls.Add(Me.contCantidadDeAnimales)
        Me.Controls.Add(Me.dtFechaEnviarAnimales)
        Me.Controls.Add(Me.lblCantAnimales)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.cmdEnviar)
        Me.Controls.Add(Me.cmdAtras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEnviarAnimales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Enviar animales a campo de recría"
        CType(Me.contCantidadDeAnimales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
    Friend WithEvents cmdEnviar As System.Windows.Forms.Button
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblCantAnimales As System.Windows.Forms.Label
    Friend WithEvents dtFechaEnviarAnimales As System.Windows.Forms.DateTimePicker
    Friend WithEvents contCantidadDeAnimales As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblIdCampoDeRecria As System.Windows.Forms.Label
    Friend WithEvents txtIdCampoDeRecria As System.Windows.Forms.TextBox
    Friend WithEvents txtIdAnimal As System.Windows.Forms.TextBox
    Friend WithEvents lblIdAnimal As System.Windows.Forms.Label
End Class
