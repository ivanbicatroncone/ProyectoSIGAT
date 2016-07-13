<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarAnimal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarAnimal))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblIdAnimal = New System.Windows.Forms.Label()
        Me.cmdBuscarModificar = New System.Windows.Forms.Button()
        Me.gbModificar = New System.Windows.Forms.GroupBox()
        Me.cbSecado = New System.Windows.Forms.ComboBox()
        Me.gbSecado = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCausasSecado = New System.Windows.Forms.Label()
        Me.lblSecadoId = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.cmdGuardarCambios = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.cbRaza = New System.Windows.Forms.ComboBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.lblNombreAnimal = New System.Windows.Forms.Label()
        Me.dtFechaDeNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblIdMadre = New System.Windows.Forms.Label()
        Me.lblIdPadre = New System.Windows.Forms.Label()
        Me.lblSecado = New System.Windows.Forms.Label()
        Me.lblIdPais = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.gbModificar.SuspendLayout()
        Me.gbSecado.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(227, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 12
        '
        'lblIdAnimal
        '
        Me.lblIdAnimal.AutoSize = True
        Me.lblIdAnimal.Location = New System.Drawing.Point(49, 77)
        Me.lblIdAnimal.Name = "lblIdAnimal"
        Me.lblIdAnimal.Size = New System.Drawing.Size(50, 13)
        Me.lblIdAnimal.TabIndex = 11
        Me.lblIdAnimal.Text = "Id Animal"
        '
        'cmdBuscarModificar
        '
        Me.cmdBuscarModificar.BackColor = System.Drawing.Color.Transparent
        Me.cmdBuscarModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBuscarModificar.FlatAppearance.BorderSize = 0
        Me.cmdBuscarModificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdBuscarModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdBuscarModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdBuscarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBuscarModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscarModificar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdBuscarModificar.Image = CType(resources.GetObject("cmdBuscarModificar.Image"), System.Drawing.Image)
        Me.cmdBuscarModificar.Location = New System.Drawing.Point(379, 71)
        Me.cmdBuscarModificar.Name = "cmdBuscarModificar"
        Me.cmdBuscarModificar.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscarModificar.TabIndex = 13
        Me.cmdBuscarModificar.Text = "Buscar"
        Me.cmdBuscarModificar.UseVisualStyleBackColor = False
        '
        'gbModificar
        '
        Me.gbModificar.Controls.Add(Me.cbSecado)
        Me.gbModificar.Controls.Add(Me.gbSecado)
        Me.gbModificar.Controls.Add(Me.cmdGuardarCambios)
        Me.gbModificar.Controls.Add(Me.ComboBox1)
        Me.gbModificar.Controls.Add(Me.Label3)
        Me.gbModificar.Controls.Add(Me.lblSexo)
        Me.gbModificar.Controls.Add(Me.cbSexo)
        Me.gbModificar.Controls.Add(Me.TextBox6)
        Me.gbModificar.Controls.Add(Me.TextBox5)
        Me.gbModificar.Controls.Add(Me.TextBox4)
        Me.gbModificar.Controls.Add(Me.TextBox3)
        Me.gbModificar.Controls.Add(Me.cbRaza)
        Me.gbModificar.Controls.Add(Me.TextBox7)
        Me.gbModificar.Controls.Add(Me.lblEdad)
        Me.gbModificar.Controls.Add(Me.lblRaza)
        Me.gbModificar.Controls.Add(Me.lblNombreAnimal)
        Me.gbModificar.Controls.Add(Me.dtFechaDeNacimiento)
        Me.gbModificar.Controls.Add(Me.Label2)
        Me.gbModificar.Controls.Add(Me.lblIdMadre)
        Me.gbModificar.Controls.Add(Me.lblIdPadre)
        Me.gbModificar.Controls.Add(Me.lblSecado)
        Me.gbModificar.Controls.Add(Me.lblIdPais)
        Me.gbModificar.Controls.Add(Me.TextBox2)
        Me.gbModificar.Controls.Add(Me.Label1)
        Me.gbModificar.Location = New System.Drawing.Point(44, 127)
        Me.gbModificar.Name = "gbModificar"
        Me.gbModificar.Size = New System.Drawing.Size(457, 363)
        Me.gbModificar.TabIndex = 14
        Me.gbModificar.TabStop = False
        Me.gbModificar.Visible = False
        '
        'cbSecado
        '
        Me.cbSecado.FormattingEnabled = True
        Me.cbSecado.Items.AddRange(New Object() {"No", "Si"})
        Me.cbSecado.Location = New System.Drawing.Point(339, 175)
        Me.cbSecado.Name = "cbSecado"
        Me.cbSecado.Size = New System.Drawing.Size(102, 21)
        Me.cbSecado.TabIndex = 43
        '
        'gbSecado
        '
        Me.gbSecado.Controls.Add(Me.DateTimePicker1)
        Me.gbSecado.Controls.Add(Me.Label4)
        Me.gbSecado.Controls.Add(Me.lblCausasSecado)
        Me.gbSecado.Controls.Add(Me.lblSecadoId)
        Me.gbSecado.Controls.Add(Me.TextBox9)
        Me.gbSecado.Controls.Add(Me.TextBox8)
        Me.gbSecado.Location = New System.Drawing.Point(240, 199)
        Me.gbSecado.Name = "gbSecado"
        Me.gbSecado.Size = New System.Drawing.Size(211, 110)
        Me.gbSecado.TabIndex = 42
        Me.gbSecado.TabStop = False
        Me.gbSecado.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(99, 83)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker1.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Causas Secado"
        '
        'lblCausasSecado
        '
        Me.lblCausasSecado.AutoSize = True
        Me.lblCausasSecado.Location = New System.Drawing.Point(2, 50)
        Me.lblCausasSecado.Name = "lblCausasSecado"
        Me.lblCausasSecado.Size = New System.Drawing.Size(82, 13)
        Me.lblCausasSecado.TabIndex = 20
        Me.lblCausasSecado.Text = "Causas Secado"
        '
        'lblSecadoId
        '
        Me.lblSecadoId.AutoSize = True
        Me.lblSecadoId.Location = New System.Drawing.Point(2, 18)
        Me.lblSecadoId.Name = "lblSecadoId"
        Me.lblSecadoId.Size = New System.Drawing.Size(56, 13)
        Me.lblSecadoId.TabIndex = 20
        Me.lblSecadoId.Text = "Id Secado"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(99, 47)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(102, 20)
        Me.TextBox9.TabIndex = 31
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(99, 14)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(102, 20)
        Me.TextBox8.TabIndex = 31
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
        Me.cmdGuardarCambios.Location = New System.Drawing.Point(199, 325)
        Me.cmdGuardarCambios.Name = "cmdGuardarCambios"
        Me.cmdGuardarCambios.Size = New System.Drawing.Size(84, 23)
        Me.cmdGuardarCambios.TabIndex = 15
        Me.cmdGuardarCambios.Text = "Guardar"
        Me.cmdGuardarCambios.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Preñada y seca", "Preñada y en producción", "Producción y vacía", "Seca"})
        Me.ComboBox1.Location = New System.Drawing.Point(120, 269)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(102, 21)
        Me.ComboBox1.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Estado"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(264, 38)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(31, 13)
        Me.lblSexo.TabIndex = 34
        Me.lblSexo.Text = "Sexo"
        '
        'cbSexo
        '
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"Vaca", "Toro"})
        Me.cbSexo.Location = New System.Drawing.Point(339, 30)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(102, 21)
        Me.cbSexo.TabIndex = 33
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(120, 228)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(102, 20)
        Me.TextBox6.TabIndex = 32
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(120, 191)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(102, 20)
        Me.TextBox5.TabIndex = 31
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(339, 107)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(102, 20)
        Me.TextBox4.TabIndex = 30
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(117, 103)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(102, 20)
        Me.TextBox3.TabIndex = 29
        '
        'cbRaza
        '
        Me.cbRaza.FormattingEnabled = True
        Me.cbRaza.Items.AddRange(New Object() {"Holando", "Jersey", "Primer Show"})
        Me.cbRaza.Location = New System.Drawing.Point(339, 66)
        Me.cbRaza.Name = "cbRaza"
        Me.cbRaza.Size = New System.Drawing.Size(102, 21)
        Me.cbRaza.TabIndex = 28
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(117, 67)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 27
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(6, 110)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(32, 13)
        Me.lblEdad.TabIndex = 26
        Me.lblEdad.Text = "Edad"
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Location = New System.Drawing.Point(264, 70)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(32, 13)
        Me.lblRaza.TabIndex = 25
        Me.lblRaza.Text = "Raza"
        '
        'lblNombreAnimal
        '
        Me.lblNombreAnimal.AutoSize = True
        Me.lblNombreAnimal.Location = New System.Drawing.Point(6, 70)
        Me.lblNombreAnimal.Name = "lblNombreAnimal"
        Me.lblNombreAnimal.Size = New System.Drawing.Size(93, 13)
        Me.lblNombreAnimal.TabIndex = 24
        Me.lblNombreAnimal.Text = "Nombre (opcional)"
        '
        'dtFechaDeNacimiento
        '
        Me.dtFechaDeNacimiento.Location = New System.Drawing.Point(120, 149)
        Me.dtFechaDeNacimiento.Name = "dtFechaDeNacimiento"
        Me.dtFechaDeNacimiento.Size = New System.Drawing.Size(291, 20)
        Me.dtFechaDeNacimiento.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Fecha de Nacimiento"
        '
        'lblIdMadre
        '
        Me.lblIdMadre.AutoSize = True
        Me.lblIdMadre.Location = New System.Drawing.Point(6, 235)
        Me.lblIdMadre.Name = "lblIdMadre"
        Me.lblIdMadre.Size = New System.Drawing.Size(98, 13)
        Me.lblIdMadre.TabIndex = 21
        Me.lblIdMadre.Text = "Id Madre (opcional)"
        '
        'lblIdPadre
        '
        Me.lblIdPadre.AutoSize = True
        Me.lblIdPadre.Location = New System.Drawing.Point(6, 194)
        Me.lblIdPadre.Name = "lblIdPadre"
        Me.lblIdPadre.Size = New System.Drawing.Size(96, 13)
        Me.lblIdPadre.TabIndex = 20
        Me.lblIdPadre.Text = "Id Padre (opcional)"
        '
        'lblSecado
        '
        Me.lblSecado.AutoSize = True
        Me.lblSecado.Location = New System.Drawing.Point(264, 178)
        Me.lblSecado.Name = "lblSecado"
        Me.lblSecado.Size = New System.Drawing.Size(44, 13)
        Me.lblSecado.TabIndex = 19
        Me.lblSecado.Text = "Secado"
        '
        'lblIdPais
        '
        Me.lblIdPais.AutoSize = True
        Me.lblIdPais.Location = New System.Drawing.Point(264, 110)
        Me.lblIdPais.Name = "lblIdPais"
        Me.lblIdPais.Size = New System.Drawing.Size(41, 13)
        Me.lblIdPais.TabIndex = 19
        Me.lblIdPais.Text = "Id País"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(117, 31)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Id Animal"
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
        Me.cmdAtras.Size = New System.Drawing.Size(75, 23)
        Me.cmdAtras.TabIndex = 15
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'frmModificarAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(544, 501)
        Me.Controls.Add(Me.cmdAtras)
        Me.Controls.Add(Me.gbModificar)
        Me.Controls.Add(Me.cmdBuscarModificar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblIdAnimal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmModificarAnimal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Modificar Animal"
        Me.gbModificar.ResumeLayout(False)
        Me.gbModificar.PerformLayout()
        Me.gbSecado.ResumeLayout(False)
        Me.gbSecado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblIdAnimal As System.Windows.Forms.Label
    Friend WithEvents cmdBuscarModificar As System.Windows.Forms.Button
    Friend WithEvents gbModificar As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents cbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents cbRaza As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents lblRaza As System.Windows.Forms.Label
    Friend WithEvents lblNombreAnimal As System.Windows.Forms.Label
    Friend WithEvents dtFechaDeNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblIdMadre As System.Windows.Forms.Label
    Friend WithEvents lblIdPadre As System.Windows.Forms.Label
    Friend WithEvents lblIdPais As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdGuardarCambios As System.Windows.Forms.Button
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
    Friend WithEvents cbSecado As System.Windows.Forms.ComboBox
    Friend WithEvents gbSecado As System.Windows.Forms.GroupBox
    Friend WithEvents lblSecado As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCausasSecado As System.Windows.Forms.Label
    Friend WithEvents lblSecadoId As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
End Class
