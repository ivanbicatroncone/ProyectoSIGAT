<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuTambo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuTambo))
        Me.Tabla = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdProduccion = New System.Windows.Forms.Button()
        Me.cmdAnimales = New System.Windows.Forms.Button()
        Me.cmdCampoDeRecria = New System.Windows.Forms.Button()
        Me.cmdReproducción = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuConfiguracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParámetrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCerrarSesion = New System.Windows.Forms.Button()
        Me.Tabla.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabla
        '
        Me.Tabla.BackColor = System.Drawing.Color.White
        Me.Tabla.ColumnCount = 2
        Me.Tabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.43959!))
        Me.Tabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 394.0!))
        Me.Tabla.Controls.Add(Me.cmdProduccion, 1, 2)
        Me.Tabla.Controls.Add(Me.cmdAnimales, 0, 2)
        Me.Tabla.Controls.Add(Me.cmdCampoDeRecria, 0, 4)
        Me.Tabla.Controls.Add(Me.cmdReproducción, 1, 4)
        Me.Tabla.Controls.Add(Me.MenuStrip1, 0, 0)
        Me.Tabla.Controls.Add(Me.cmdCerrarSesion, 0, 1)
        Me.Tabla.Dock = System.Windows.Forms.DockStyle.Top
        Me.Tabla.Location = New System.Drawing.Point(0, 0)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.RowCount = 6
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.5814!))
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.4186!))
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183.0!))
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.Tabla.Size = New System.Drawing.Size(784, 562)
        Me.Tabla.TabIndex = 4
        '
        'cmdProduccion
        '
        Me.cmdProduccion.BackColor = System.Drawing.Color.Transparent
        Me.cmdProduccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdProduccion.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdProduccion.FlatAppearance.BorderSize = 0
        Me.cmdProduccion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdProduccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdProduccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdProduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdProduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProduccion.ForeColor = System.Drawing.SystemColors.Window
        Me.cmdProduccion.Image = CType(resources.GetObject("cmdProduccion.Image"), System.Drawing.Image)
        Me.cmdProduccion.Location = New System.Drawing.Point(393, 89)
        Me.cmdProduccion.Name = "cmdProduccion"
        Me.cmdProduccion.Size = New System.Drawing.Size(190, 159)
        Me.cmdProduccion.TabIndex = 1
        Me.cmdProduccion.Text = "Producción"
        Me.cmdProduccion.UseVisualStyleBackColor = False
        '
        'cmdAnimales
        '
        Me.cmdAnimales.BackColor = System.Drawing.Color.Transparent
        Me.cmdAnimales.BackgroundImage = CType(resources.GetObject("cmdAnimales.BackgroundImage"), System.Drawing.Image)
        Me.cmdAnimales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAnimales.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdAnimales.FlatAppearance.BorderSize = 0
        Me.cmdAnimales.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdAnimales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAnimales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdAnimales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAnimales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnimales.ForeColor = System.Drawing.SystemColors.Window
        Me.cmdAnimales.Location = New System.Drawing.Point(197, 89)
        Me.cmdAnimales.Name = "cmdAnimales"
        Me.cmdAnimales.Size = New System.Drawing.Size(190, 159)
        Me.cmdAnimales.TabIndex = 0
        Me.cmdAnimales.Text = "Animales"
        Me.cmdAnimales.UseVisualStyleBackColor = False
        '
        'cmdCampoDeRecria
        '
        Me.cmdCampoDeRecria.BackColor = System.Drawing.Color.Transparent
        Me.cmdCampoDeRecria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCampoDeRecria.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdCampoDeRecria.FlatAppearance.BorderSize = 0
        Me.cmdCampoDeRecria.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdCampoDeRecria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdCampoDeRecria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdCampoDeRecria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCampoDeRecria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCampoDeRecria.ForeColor = System.Drawing.SystemColors.Window
        Me.cmdCampoDeRecria.Image = CType(resources.GetObject("cmdCampoDeRecria.Image"), System.Drawing.Image)
        Me.cmdCampoDeRecria.Location = New System.Drawing.Point(197, 262)
        Me.cmdCampoDeRecria.Name = "cmdCampoDeRecria"
        Me.cmdCampoDeRecria.Size = New System.Drawing.Size(190, 177)
        Me.cmdCampoDeRecria.TabIndex = 5
        Me.cmdCampoDeRecria.Text = "Campo de Recría"
        Me.cmdCampoDeRecria.UseVisualStyleBackColor = False
        '
        'cmdReproducción
        '
        Me.cmdReproducción.BackColor = System.Drawing.Color.Transparent
        Me.cmdReproducción.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdReproducción.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdReproducción.FlatAppearance.BorderSize = 0
        Me.cmdReproducción.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdReproducción.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdReproducción.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdReproducción.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReproducción.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReproducción.ForeColor = System.Drawing.SystemColors.Window
        Me.cmdReproducción.Image = CType(resources.GetObject("cmdReproducción.Image"), System.Drawing.Image)
        Me.cmdReproducción.Location = New System.Drawing.Point(393, 262)
        Me.cmdReproducción.Name = "cmdReproducción"
        Me.cmdReproducción.Size = New System.Drawing.Size(190, 177)
        Me.cmdReproducción.TabIndex = 6
        Me.cmdReproducción.Text = "Reproducción"
        Me.cmdReproducción.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuConfiguracion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(78, 22)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuConfiguracion
        '
        Me.MenuConfiguracion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParámetrosToolStripMenuItem})
        Me.MenuConfiguracion.Name = "MenuConfiguracion"
        Me.MenuConfiguracion.Size = New System.Drawing.Size(65, 16)
        Me.MenuConfiguracion.Text = "Configuración"
        '
        'ParámetrosToolStripMenuItem
        '
        Me.ParámetrosToolStripMenuItem.Name = "ParámetrosToolStripMenuItem"
        Me.ParámetrosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ParámetrosToolStripMenuItem.Text = "Parámetros"
        '
        'cmdCerrarSesion
        '
        Me.cmdCerrarSesion.BackColor = System.Drawing.Color.Transparent
        Me.cmdCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCerrarSesion.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdCerrarSesion.FlatAppearance.BorderSize = 0
        Me.cmdCerrarSesion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.cmdCerrarSesion.Image = CType(resources.GetObject("cmdCerrarSesion.Image"), System.Drawing.Image)
        Me.cmdCerrarSesion.Location = New System.Drawing.Point(3, 25)
        Me.cmdCerrarSesion.Name = "cmdCerrarSesion"
        Me.cmdCerrarSesion.Size = New System.Drawing.Size(82, 58)
        Me.cmdCerrarSesion.TabIndex = 2
        Me.cmdCerrarSesion.Text = "Cerrar Sesión"
        Me.cmdCerrarSesion.UseVisualStyleBackColor = False
        '
        'frmMenuTambo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Tabla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMenuTambo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Menu Tambo"
        Me.Tabla.ResumeLayout(False)
        Me.Tabla.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tabla As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdProduccion As System.Windows.Forms.Button
    Friend WithEvents cmdAnimales As System.Windows.Forms.Button
    Friend WithEvents cmdCampoDeRecria As System.Windows.Forms.Button
    Friend WithEvents cmdReproducción As System.Windows.Forms.Button
    Friend WithEvents cmdCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuConfiguracion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParámetrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
