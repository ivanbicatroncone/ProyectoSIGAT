<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduccion))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdIngresarLote = New System.Windows.Forms.Button()
        Me.cmdLeche = New System.Windows.Forms.Button()
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.cmdOrdeñe = New System.Windows.Forms.Button()
        Me.cmdControlLechero = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.79824!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.20176!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdIngresarLote, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdLeche, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdAtras, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdOrdeñe, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdControlLechero, 1, 4)
        Me.TableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.51678!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.48322!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 565)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'cmdIngresarLote
        '
        Me.cmdIngresarLote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdIngresarLote.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdIngresarLote.FlatAppearance.BorderSize = 0
        Me.cmdIngresarLote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdIngresarLote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdIngresarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIngresarLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmdIngresarLote.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdIngresarLote.Image = CType(resources.GetObject("cmdIngresarLote.Image"), System.Drawing.Image)
        Me.cmdIngresarLote.Location = New System.Drawing.Point(205, 97)
        Me.cmdIngresarLote.Name = "cmdIngresarLote"
        Me.cmdIngresarLote.Size = New System.Drawing.Size(190, 169)
        Me.cmdIngresarLote.TabIndex = 0
        Me.cmdIngresarLote.Text = "Lotes"
        Me.cmdIngresarLote.UseVisualStyleBackColor = True
        '
        'cmdLeche
        '
        Me.cmdLeche.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLeche.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdLeche.FlatAppearance.BorderSize = 0
        Me.cmdLeche.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdLeche.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdLeche.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdLeche.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLeche.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmdLeche.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdLeche.Image = CType(resources.GetObject("cmdLeche.Image"), System.Drawing.Image)
        Me.cmdLeche.Location = New System.Drawing.Point(401, 97)
        Me.cmdLeche.Name = "cmdLeche"
        Me.cmdLeche.Size = New System.Drawing.Size(191, 169)
        Me.cmdLeche.TabIndex = 1
        Me.cmdLeche.Text = "Leche"
        Me.cmdLeche.UseVisualStyleBackColor = True
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
        Me.cmdAtras.Location = New System.Drawing.Point(3, 17)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(81, 32)
        Me.cmdAtras.TabIndex = 2
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'cmdOrdeñe
        '
        Me.cmdOrdeñe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdOrdeñe.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdOrdeñe.FlatAppearance.BorderSize = 0
        Me.cmdOrdeñe.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdOrdeñe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdOrdeñe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdOrdeñe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOrdeñe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmdOrdeñe.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdOrdeñe.Image = CType(resources.GetObject("cmdOrdeñe.Image"), System.Drawing.Image)
        Me.cmdOrdeñe.Location = New System.Drawing.Point(206, 272)
        Me.cmdOrdeñe.Name = "cmdOrdeñe"
        Me.cmdOrdeñe.Size = New System.Drawing.Size(189, 165)
        Me.cmdOrdeñe.TabIndex = 3
        Me.cmdOrdeñe.Text = "Ordeñe"
        Me.cmdOrdeñe.UseVisualStyleBackColor = True
        '
        'cmdControlLechero
        '
        Me.cmdControlLechero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdControlLechero.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdControlLechero.FlatAppearance.BorderSize = 0
        Me.cmdControlLechero.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdControlLechero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdControlLechero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdControlLechero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdControlLechero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmdControlLechero.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdControlLechero.Image = CType(resources.GetObject("cmdControlLechero.Image"), System.Drawing.Image)
        Me.cmdControlLechero.Location = New System.Drawing.Point(401, 272)
        Me.cmdControlLechero.Name = "cmdControlLechero"
        Me.cmdControlLechero.Size = New System.Drawing.Size(189, 165)
        Me.cmdControlLechero.TabIndex = 4
        Me.cmdControlLechero.Text = "Control Lechero"
        Me.cmdControlLechero.UseVisualStyleBackColor = True
        '
        'frmProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 565)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Producción"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdIngresarLote As System.Windows.Forms.Button
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
    Friend WithEvents cmdOrdeñe As System.Windows.Forms.Button
    Friend WithEvents cmdLeche As System.Windows.Forms.Button
    Friend WithEvents cmdControlLechero As System.Windows.Forms.Button
End Class
