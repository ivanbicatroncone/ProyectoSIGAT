<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVinculacionCR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVinculacionCR))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdEnviar = New System.Windows.Forms.Button()
        Me.cmdRecibirAnimales = New System.Windows.Forms.Button()
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
        Me.TableLayoutPanel1.Controls.Add(Me.cmdEnviar, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdRecibirAnimales, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdAtras, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.51678!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.48322!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 235.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 562)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'cmdEnviar
        '
        Me.cmdEnviar.BackColor = System.Drawing.Color.Transparent
        Me.cmdEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEnviar.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdEnviar.FlatAppearance.BorderSize = 0
        Me.cmdEnviar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmdEnviar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdEnviar.Image = CType(resources.GetObject("cmdEnviar.Image"), System.Drawing.Image)
        Me.cmdEnviar.Location = New System.Drawing.Point(199, 163)
        Me.cmdEnviar.Name = "cmdEnviar"
        Me.cmdEnviar.Size = New System.Drawing.Size(190, 160)
        Me.cmdEnviar.TabIndex = 0
        Me.cmdEnviar.Text = "Enviar Animales"
        Me.cmdEnviar.UseVisualStyleBackColor = False
        '
        'cmdRecibirAnimales
        '
        Me.cmdRecibirAnimales.BackColor = System.Drawing.Color.Transparent
        Me.cmdRecibirAnimales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdRecibirAnimales.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdRecibirAnimales.FlatAppearance.BorderSize = 0
        Me.cmdRecibirAnimales.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdRecibirAnimales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdRecibirAnimales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdRecibirAnimales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRecibirAnimales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmdRecibirAnimales.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdRecibirAnimales.Image = CType(resources.GetObject("cmdRecibirAnimales.Image"), System.Drawing.Image)
        Me.cmdRecibirAnimales.Location = New System.Drawing.Point(395, 163)
        Me.cmdRecibirAnimales.Name = "cmdRecibirAnimales"
        Me.cmdRecibirAnimales.Size = New System.Drawing.Size(190, 160)
        Me.cmdRecibirAnimales.TabIndex = 1
        Me.cmdRecibirAnimales.Text = "Recibir Animales"
        Me.cmdRecibirAnimales.UseVisualStyleBackColor = False
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
        Me.cmdAtras.Location = New System.Drawing.Point(3, 16)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(81, 29)
        Me.cmdAtras.TabIndex = 2
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'FrmVinculacionCR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmVinculacionCR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Vinculación Campo de recría"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdEnviar As System.Windows.Forms.Button
    Friend WithEvents cmdRecibirAnimales As System.Windows.Forms.Button
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
End Class
