<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonal))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdInformaciónPersonal = New System.Windows.Forms.Button()
        Me.cmdIngresarPersonal = New System.Windows.Forms.Button()
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.2347!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.7653!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdInformaciónPersonal, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdIngresarPersonal, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdAtras, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 237.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 565)
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'cmdInformaciónPersonal
        '
        Me.cmdInformaciónPersonal.BackColor = System.Drawing.Color.Transparent
        Me.cmdInformaciónPersonal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdInformaciónPersonal.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdInformaciónPersonal.FlatAppearance.BorderSize = 0
        Me.cmdInformaciónPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdInformaciónPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdInformaciónPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdInformaciónPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInformaciónPersonal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdInformaciónPersonal.Image = CType(resources.GetObject("cmdInformaciónPersonal.Image"), System.Drawing.Image)
        Me.cmdInformaciónPersonal.Location = New System.Drawing.Point(193, 166)
        Me.cmdInformaciónPersonal.Name = "cmdInformaciónPersonal"
        Me.cmdInformaciónPersonal.Size = New System.Drawing.Size(190, 231)
        Me.cmdInformaciónPersonal.TabIndex = 0
        Me.cmdInformaciónPersonal.Text = "Información del Personal"
        Me.cmdInformaciónPersonal.UseVisualStyleBackColor = False
        '
        'cmdIngresarPersonal
        '
        Me.cmdIngresarPersonal.BackColor = System.Drawing.Color.Transparent
        Me.cmdIngresarPersonal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdIngresarPersonal.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdIngresarPersonal.FlatAppearance.BorderSize = 0
        Me.cmdIngresarPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdIngresarPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdIngresarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIngresarPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIngresarPersonal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdIngresarPersonal.Image = CType(resources.GetObject("cmdIngresarPersonal.Image"), System.Drawing.Image)
        Me.cmdIngresarPersonal.Location = New System.Drawing.Point(389, 166)
        Me.cmdIngresarPersonal.Name = "cmdIngresarPersonal"
        Me.cmdIngresarPersonal.Size = New System.Drawing.Size(196, 231)
        Me.cmdIngresarPersonal.TabIndex = 1
        Me.cmdIngresarPersonal.Text = "Ingresar personal"
        Me.cmdIngresarPersonal.UseVisualStyleBackColor = False
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
        Me.cmdAtras.Location = New System.Drawing.Point(3, 10)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(81, 28)
        Me.cmdAtras.TabIndex = 2
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'frmPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 565)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Personal Cooperativa"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdInformaciónPersonal As System.Windows.Forms.Button
    Friend WithEvents cmdIngresarPersonal As System.Windows.Forms.Button
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
End Class
