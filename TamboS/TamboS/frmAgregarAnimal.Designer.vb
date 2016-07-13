<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarAnimal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarAnimal))
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.lblIdAnimal = New System.Windows.Forms.Label()
        Me.lblIdPais = New System.Windows.Forms.Label()
        Me.lblIdPadre = New System.Windows.Forms.Label()
        Me.lblIdMadre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblNombreAnimal = New System.Windows.Forms.Label()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cbRaza = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdIngresar
        '
        Me.cmdIngresar.BackColor = System.Drawing.Color.Transparent
        Me.cmdIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdIngresar.FlatAppearance.BorderSize = 0
        Me.cmdIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIngresar.ForeColor = System.Drawing.Color.White
        Me.cmdIngresar.Image = CType(resources.GetObject("cmdIngresar.Image"), System.Drawing.Image)
        Me.cmdIngresar.Location = New System.Drawing.Point(236, 445)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(75, 23)
        Me.cmdIngresar.TabIndex = 0
        Me.cmdIngresar.Text = "Ingresar"
        Me.cmdIngresar.UseVisualStyleBackColor = False
        '
        'lblIdAnimal
        '
        Me.lblIdAnimal.AutoSize = True
        Me.lblIdAnimal.Location = New System.Drawing.Point(74, 60)
        Me.lblIdAnimal.Name = "lblIdAnimal"
        Me.lblIdAnimal.Size = New System.Drawing.Size(50, 13)
        Me.lblIdAnimal.TabIndex = 1
        Me.lblIdAnimal.Text = "Id Animal"
        '
        'lblIdPais
        '
        Me.lblIdPais.AutoSize = True
        Me.lblIdPais.Location = New System.Drawing.Point(71, 294)
        Me.lblIdPais.Name = "lblIdPais"
        Me.lblIdPais.Size = New System.Drawing.Size(41, 13)
        Me.lblIdPais.TabIndex = 2
        Me.lblIdPais.Text = "Id País"
        '
        'lblIdPadre
        '
        Me.lblIdPadre.AutoSize = True
        Me.lblIdPadre.Location = New System.Drawing.Point(71, 333)
        Me.lblIdPadre.Name = "lblIdPadre"
        Me.lblIdPadre.Size = New System.Drawing.Size(96, 13)
        Me.lblIdPadre.TabIndex = 3
        Me.lblIdPadre.Text = "Id Padre (opcional)"
        '
        'lblIdMadre
        '
        Me.lblIdMadre.AutoSize = True
        Me.lblIdMadre.Location = New System.Drawing.Point(71, 379)
        Me.lblIdMadre.Name = "lblIdMadre"
        Me.lblIdMadre.Size = New System.Drawing.Size(98, 13)
        Me.lblIdMadre.TabIndex = 4
        Me.lblIdMadre.Text = "Id Madre (opcional)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha de Nacimiento"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(252, 242)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(197, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'lblNombreAnimal
        '
        Me.lblNombreAnimal.AutoSize = True
        Me.lblNombreAnimal.Location = New System.Drawing.Point(73, 130)
        Me.lblNombreAnimal.Name = "lblNombreAnimal"
        Me.lblNombreAnimal.Size = New System.Drawing.Size(93, 13)
        Me.lblNombreAnimal.TabIndex = 7
        Me.lblNombreAnimal.Text = "Nombre (opcional)"
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Location = New System.Drawing.Point(72, 167)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(32, 13)
        Me.lblRaza.TabIndex = 8
        Me.lblRaza.Text = "Raza"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(72, 202)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(32, 13)
        Me.lblEdad.TabIndex = 9
        Me.lblEdad.Text = "Edad"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(252, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(252, 123)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 11
        '
        'cbRaza
        '
        Me.cbRaza.FormattingEnabled = True
        Me.cbRaza.Items.AddRange(New Object() {"Holando", "Jersey", "Primer Show"})
        Me.cbRaza.Location = New System.Drawing.Point(252, 159)
        Me.cbRaza.Name = "cbRaza"
        Me.cbRaza.Size = New System.Drawing.Size(102, 21)
        Me.cbRaza.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(252, 199)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(102, 20)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(252, 287)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(102, 20)
        Me.TextBox4.TabIndex = 14
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(252, 326)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(102, 20)
        Me.TextBox5.TabIndex = 15
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(252, 372)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(102, 20)
        Me.TextBox6.TabIndex = 16
        '
        'cbSexo
        '
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"Vaca", "Toro"})
        Me.cbSexo.Location = New System.Drawing.Point(252, 81)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(102, 21)
        Me.cbSexo.TabIndex = 17
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(73, 89)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(31, 13)
        Me.lblSexo.TabIndex = 18
        Me.lblSexo.Text = "Sexo"
        '
        'cmdAtras
        '
        Me.cmdAtras.BackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAtras.FlatAppearance.BorderSize = 0
        Me.cmdAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAtras.ForeColor = System.Drawing.Color.White
        Me.cmdAtras.Image = CType(resources.GetObject("cmdAtras.Image"), System.Drawing.Image)
        Me.cmdAtras.Location = New System.Drawing.Point(7, 7)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(75, 23)
        Me.cmdAtras.TabIndex = 19
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'frmAgregarAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(544, 502)
        Me.Controls.Add(Me.cmdAtras)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.cbSexo)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.cbRaza)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.lblRaza)
        Me.Controls.Add(Me.lblNombreAnimal)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblIdMadre)
        Me.Controls.Add(Me.lblIdPadre)
        Me.Controls.Add(Me.lblIdPais)
        Me.Controls.Add(Me.lblIdAnimal)
        Me.Controls.Add(Me.cmdIngresar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAgregarAnimal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Agregar Animal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdIngresar As System.Windows.Forms.Button
    Friend WithEvents lblIdAnimal As System.Windows.Forms.Label
    Friend WithEvents lblIdPais As System.Windows.Forms.Label
    Friend WithEvents lblIdPadre As System.Windows.Forms.Label
    Friend WithEvents lblIdMadre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNombreAnimal As System.Windows.Forms.Label
    Friend WithEvents lblRaza As System.Windows.Forms.Label
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents cbRaza As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents cbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents cmdAtras As Button
End Class
