<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuCooperativa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuCooperativa))
        Me.cmdTambo1 = New System.Windows.Forms.Button()
        Me.cmdTambo2 = New System.Windows.Forms.Button()
        Me.cmdCerrarSesion = New System.Windows.Forms.Button()
        Me.Grilla = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdAdministracion = New System.Windows.Forms.Button()
        Me.Grilla.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdTambo1
        '
        Me.cmdTambo1.BackColor = System.Drawing.Color.Transparent
        Me.cmdTambo1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdTambo1.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdTambo1.FlatAppearance.BorderSize = 0
        Me.cmdTambo1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdTambo1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdTambo1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdTambo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTambo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTambo1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdTambo1.Image = CType(resources.GetObject("cmdTambo1.Image"), System.Drawing.Image)
        Me.cmdTambo1.Location = New System.Drawing.Point(94, 176)
        Me.cmdTambo1.Name = "cmdTambo1"
        Me.cmdTambo1.Size = New System.Drawing.Size(190, 239)
        Me.cmdTambo1.TabIndex = 0
        Me.cmdTambo1.Text = "Tambo1"
        Me.cmdTambo1.UseVisualStyleBackColor = False
        '
        'cmdTambo2
        '
        Me.cmdTambo2.BackColor = System.Drawing.Color.Transparent
        Me.cmdTambo2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdTambo2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdTambo2.FlatAppearance.BorderSize = 0
        Me.cmdTambo2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdTambo2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdTambo2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdTambo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTambo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTambo2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdTambo2.Image = CType(resources.GetObject("cmdTambo2.Image"), System.Drawing.Image)
        Me.cmdTambo2.Location = New System.Drawing.Point(290, 176)
        Me.cmdTambo2.Name = "cmdTambo2"
        Me.cmdTambo2.Size = New System.Drawing.Size(203, 239)
        Me.cmdTambo2.TabIndex = 1
        Me.cmdTambo2.Text = "Tambo2"
        Me.cmdTambo2.UseVisualStyleBackColor = False
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
        Me.cmdCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrarSesion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdCerrarSesion.Image = CType(resources.GetObject("cmdCerrarSesion.Image"), System.Drawing.Image)
        Me.cmdCerrarSesion.Location = New System.Drawing.Point(3, 11)
        Me.cmdCerrarSesion.Name = "cmdCerrarSesion"
        Me.cmdCerrarSesion.Size = New System.Drawing.Size(80, 37)
        Me.cmdCerrarSesion.TabIndex = 2
        Me.cmdCerrarSesion.Text = "Cerrar Sesión"
        Me.cmdCerrarSesion.UseVisualStyleBackColor = False
        '
        'Grilla
        '
        Me.Grilla.AutoSize = True
        Me.Grilla.BackColor = System.Drawing.Color.White
        Me.Grilla.ColumnCount = 3
        Me.Grilla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.78252!))
        Me.Grilla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.21748!))
        Me.Grilla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 297.0!))
        Me.Grilla.Controls.Add(Me.cmdTambo1, 0, 3)
        Me.Grilla.Controls.Add(Me.cmdTambo2, 1, 3)
        Me.Grilla.Controls.Add(Me.cmdCerrarSesion, 0, 1)
        Me.Grilla.Controls.Add(Me.cmdAdministracion, 2, 3)
        Me.Grilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grilla.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.Grilla.Location = New System.Drawing.Point(0, 0)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.RowCount = 5
        Me.Grilla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.Grilla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334!))
        Me.Grilla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.Grilla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 245.0!))
        Me.Grilla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156.0!))
        Me.Grilla.Size = New System.Drawing.Size(794, 575)
        Me.Grilla.TabIndex = 3
        '
        'cmdAdministracion
        '
        Me.cmdAdministracion.BackColor = System.Drawing.Color.Transparent
        Me.cmdAdministracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdministracion.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdAdministracion.FlatAppearance.BorderSize = 0
        Me.cmdAdministracion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdAdministracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAdministracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdministracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmdAdministracion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdAdministracion.Image = CType(resources.GetObject("cmdAdministracion.Image"), System.Drawing.Image)
        Me.cmdAdministracion.Location = New System.Drawing.Point(499, 176)
        Me.cmdAdministracion.Name = "cmdAdministracion"
        Me.cmdAdministracion.Size = New System.Drawing.Size(194, 239)
        Me.cmdAdministracion.TabIndex = 3
        Me.cmdAdministracion.Text = "Administración"
        Me.cmdAdministracion.UseVisualStyleBackColor = False
        '
        'frmMenuCooperativa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 575)
        Me.Controls.Add(Me.Grilla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMenuCooperativa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Menu Cooperativa"
        Me.Grilla.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdTambo1 As System.Windows.Forms.Button
    Friend WithEvents cmdTambo2 As System.Windows.Forms.Button
    Friend WithEvents cmdCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents Grilla As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdAdministracion As System.Windows.Forms.Button
End Class
