<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLotes))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdIngresarLote = New System.Windows.Forms.Button()
        Me.cmdTambo2 = New System.Windows.Forms.Button()
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdIngresarLote, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdTambo2, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdAtras, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.81481!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.18519!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 235.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(794, 575)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'cmdIngresarLote
        '
        Me.cmdIngresarLote.BackColor = System.Drawing.Color.Transparent
        Me.cmdIngresarLote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdIngresarLote.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdIngresarLote.FlatAppearance.BorderSize = 0
        Me.cmdIngresarLote.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdIngresarLote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdIngresarLote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdIngresarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIngresarLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmdIngresarLote.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdIngresarLote.Image = CType(resources.GetObject("cmdIngresarLote.Image"), System.Drawing.Image)
        Me.cmdIngresarLote.Location = New System.Drawing.Point(204, 176)
        Me.cmdIngresarLote.Name = "cmdIngresarLote"
        Me.cmdIngresarLote.Size = New System.Drawing.Size(190, 160)
        Me.cmdIngresarLote.TabIndex = 0
        Me.cmdIngresarLote.Text = "Ingresar nuevo lote"
        Me.cmdIngresarLote.UseVisualStyleBackColor = False
        '
        'cmdTambo2
        '
        Me.cmdTambo2.BackColor = System.Drawing.Color.Transparent
        Me.cmdTambo2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdTambo2.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdTambo2.FlatAppearance.BorderSize = 0
        Me.cmdTambo2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdTambo2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdTambo2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdTambo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTambo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmdTambo2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdTambo2.Image = CType(resources.GetObject("cmdTambo2.Image"), System.Drawing.Image)
        Me.cmdTambo2.Location = New System.Drawing.Point(400, 176)
        Me.cmdTambo2.Name = "cmdTambo2"
        Me.cmdTambo2.Size = New System.Drawing.Size(190, 160)
        Me.cmdTambo2.TabIndex = 1
        Me.cmdTambo2.Text = "Información de lotes"
        Me.cmdTambo2.UseVisualStyleBackColor = False
        '
        'cmdAtras
        '
        Me.cmdAtras.BackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAtras.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdAtras.FlatAppearance.BorderSize = 0
        Me.cmdAtras.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAtras.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdAtras.Image = CType(resources.GetObject("cmdAtras.Image"), System.Drawing.Image)
        Me.cmdAtras.Location = New System.Drawing.Point(3, 9)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(81, 30)
        Me.cmdAtras.TabIndex = 2
        Me.cmdAtras.Text = "Atras"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'frmLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(794, 575)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Lotes"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdIngresarLote As System.Windows.Forms.Button
    Friend WithEvents cmdTambo2 As System.Windows.Forms.Button
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
End Class
