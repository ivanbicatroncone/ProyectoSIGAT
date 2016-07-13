<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnimales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnimales))
        Me.Tabla = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdMedicamentos = New System.Windows.Forms.Button()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.cmdAlimentos = New System.Windows.Forms.Button()
        Me.cmdBuscarAnimal = New System.Windows.Forms.Button()
        Me.txtIdAnimalBuscar = New System.Windows.Forms.TextBox()
        Me.lblIdAnimalBuscar = New System.Windows.Forms.Label()
        Me.Tabla.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabla
        '
        Me.Tabla.BackColor = System.Drawing.Color.White
        Me.Tabla.ColumnCount = 3
        Me.Tabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.25743!))
        Me.Tabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.74257!))
        Me.Tabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 384.0!))
        Me.Tabla.Controls.Add(Me.cmdAtras, 0, 1)
        Me.Tabla.Controls.Add(Me.cmdModificar, 2, 3)
        Me.Tabla.Controls.Add(Me.cmdMedicamentos, 2, 4)
        Me.Tabla.Controls.Add(Me.cmdIngresar, 1, 3)
        Me.Tabla.Controls.Add(Me.cmdAlimentos, 1, 4)
        Me.Tabla.Controls.Add(Me.cmdBuscarAnimal, 2, 6)
        Me.Tabla.Controls.Add(Me.txtIdAnimalBuscar, 1, 6)
        Me.Tabla.Controls.Add(Me.lblIdAnimalBuscar, 0, 6)
        Me.Tabla.Location = New System.Drawing.Point(0, 0)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.RowCount = 8
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.51678!))
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.48322!))
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173.0!))
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171.0!))
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.Tabla.Size = New System.Drawing.Size(784, 562)
        Me.Tabla.TabIndex = 4
        '
        'cmdAtras
        '
        Me.cmdAtras.BackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAtras.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdAtras.FlatAppearance.BorderSize = 0
        Me.cmdAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAtras.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdAtras.Image = CType(resources.GetObject("cmdAtras.Image"), System.Drawing.Image)
        Me.cmdAtras.Location = New System.Drawing.Point(3, 15)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(81, 26)
        Me.cmdAtras.TabIndex = 2
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'cmdModificar
        '
        Me.cmdModificar.BackColor = System.Drawing.Color.Transparent
        Me.cmdModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdModificar.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdModificar.FlatAppearance.BorderSize = 0
        Me.cmdModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmdModificar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdModificar.Image = CType(resources.GetObject("cmdModificar.Image"), System.Drawing.Image)
        Me.cmdModificar.Location = New System.Drawing.Point(402, 102)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(190, 167)
        Me.cmdModificar.TabIndex = 1
        Me.cmdModificar.Text = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = False
        '
        'cmdMedicamentos
        '
        Me.cmdMedicamentos.BackColor = System.Drawing.Color.Transparent
        Me.cmdMedicamentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdMedicamentos.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdMedicamentos.FlatAppearance.BorderSize = 0
        Me.cmdMedicamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdMedicamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMedicamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmdMedicamentos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdMedicamentos.Image = CType(resources.GetObject("cmdMedicamentos.Image"), System.Drawing.Image)
        Me.cmdMedicamentos.Location = New System.Drawing.Point(402, 275)
        Me.cmdMedicamentos.Name = "cmdMedicamentos"
        Me.cmdMedicamentos.Size = New System.Drawing.Size(190, 165)
        Me.cmdMedicamentos.TabIndex = 4
        Me.cmdMedicamentos.Text = "Medicamentos"
        Me.cmdMedicamentos.UseVisualStyleBackColor = False
        '
        'cmdIngresar
        '
        Me.cmdIngresar.BackColor = System.Drawing.Color.Transparent
        Me.cmdIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdIngresar.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdIngresar.FlatAppearance.BorderSize = 0
        Me.cmdIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmdIngresar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdIngresar.Image = CType(resources.GetObject("cmdIngresar.Image"), System.Drawing.Image)
        Me.cmdIngresar.Location = New System.Drawing.Point(200, 102)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(190, 167)
        Me.cmdIngresar.TabIndex = 1
        Me.cmdIngresar.Text = "Ingresar"
        Me.cmdIngresar.UseVisualStyleBackColor = False
        '
        'cmdAlimentos
        '
        Me.cmdAlimentos.BackColor = System.Drawing.Color.Transparent
        Me.cmdAlimentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAlimentos.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdAlimentos.FlatAppearance.BorderSize = 0
        Me.cmdAlimentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAlimentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdAlimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAlimentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmdAlimentos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdAlimentos.Image = CType(resources.GetObject("cmdAlimentos.Image"), System.Drawing.Image)
        Me.cmdAlimentos.Location = New System.Drawing.Point(200, 275)
        Me.cmdAlimentos.Name = "cmdAlimentos"
        Me.cmdAlimentos.Size = New System.Drawing.Size(190, 165)
        Me.cmdAlimentos.TabIndex = 3
        Me.cmdAlimentos.Text = "Alimentos"
        Me.cmdAlimentos.UseVisualStyleBackColor = False
        '
        'cmdBuscarAnimal
        '
        Me.cmdBuscarAnimal.BackColor = System.Drawing.Color.Transparent
        Me.cmdBuscarAnimal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBuscarAnimal.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdBuscarAnimal.FlatAppearance.BorderSize = 0
        Me.cmdBuscarAnimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdBuscarAnimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdBuscarAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBuscarAnimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscarAnimal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdBuscarAnimal.Image = CType(resources.GetObject("cmdBuscarAnimal.Image"), System.Drawing.Image)
        Me.cmdBuscarAnimal.Location = New System.Drawing.Point(402, 465)
        Me.cmdBuscarAnimal.Name = "cmdBuscarAnimal"
        Me.cmdBuscarAnimal.Size = New System.Drawing.Size(74, 24)
        Me.cmdBuscarAnimal.TabIndex = 7
        Me.cmdBuscarAnimal.Text = "Buscar"
        Me.cmdBuscarAnimal.UseVisualStyleBackColor = False
        '
        'txtIdAnimalBuscar
        '
        Me.txtIdAnimalBuscar.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtIdAnimalBuscar.Location = New System.Drawing.Point(200, 465)
        Me.txtIdAnimalBuscar.Name = "txtIdAnimalBuscar"
        Me.txtIdAnimalBuscar.Size = New System.Drawing.Size(190, 20)
        Me.txtIdAnimalBuscar.TabIndex = 6
        '
        'lblIdAnimalBuscar
        '
        Me.lblIdAnimalBuscar.AutoSize = True
        Me.lblIdAnimalBuscar.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblIdAnimalBuscar.Location = New System.Drawing.Point(83, 462)
        Me.lblIdAnimalBuscar.Name = "lblIdAnimalBuscar"
        Me.lblIdAnimalBuscar.Size = New System.Drawing.Size(111, 30)
        Me.lblIdAnimalBuscar.TabIndex = 5
        Me.lblIdAnimalBuscar.Text = "Id de animal a buscar:"
        '
        'frmAnimales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Tabla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAnimales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Animales"
        Me.Tabla.ResumeLayout(False)
        Me.Tabla.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tabla As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdIngresar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
    Friend WithEvents cmdAlimentos As System.Windows.Forms.Button
    Friend WithEvents cmdMedicamentos As System.Windows.Forms.Button
    Friend WithEvents lblIdAnimalBuscar As System.Windows.Forms.Label
    Friend WithEvents txtIdAnimalBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscarAnimal As System.Windows.Forms.Button
End Class
