<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministracionCooperativa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministracionCooperativa))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdPersonal = New System.Windows.Forms.Button()
        Me.cmdTambos = New System.Windows.Forms.Button()
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.2347!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.7653!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdPersonal, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdTambos, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdAtras, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(794, 575)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'cmdPersonal
        '
        Me.cmdPersonal.BackColor = System.Drawing.Color.Transparent
        Me.cmdPersonal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPersonal.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdPersonal.FlatAppearance.BorderSize = 0
        Me.cmdPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPersonal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdPersonal.Image = CType(resources.GetObject("cmdPersonal.Image"), System.Drawing.Image)
        Me.cmdPersonal.Location = New System.Drawing.Point(197, 176)
        Me.cmdPersonal.Name = "cmdPersonal"
        Me.cmdPersonal.Size = New System.Drawing.Size(190, 212)
        Me.cmdPersonal.TabIndex = 0
        Me.cmdPersonal.Text = "Personal"
        Me.cmdPersonal.UseVisualStyleBackColor = False
        '
        'cmdTambos
        '
        Me.cmdTambos.BackColor = System.Drawing.Color.Transparent
        Me.cmdTambos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdTambos.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdTambos.FlatAppearance.BorderSize = 0
        Me.cmdTambos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdTambos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdTambos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTambos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTambos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdTambos.Image = CType(resources.GetObject("cmdTambos.Image"), System.Drawing.Image)
        Me.cmdTambos.Location = New System.Drawing.Point(393, 176)
        Me.cmdTambos.Name = "cmdTambos"
        Me.cmdTambos.Size = New System.Drawing.Size(196, 212)
        Me.cmdTambos.TabIndex = 1
        Me.cmdTambos.Text = "Información de Tambos"
        Me.cmdTambos.UseVisualStyleBackColor = False
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
        Me.cmdAtras.Location = New System.Drawing.Point(3, 13)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(79, 43)
        Me.cmdAtras.TabIndex = 2
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'frmAdministracionCooperativa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(794, 575)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAdministracionCooperativa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Administración Cooperativa"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdPersonal As System.Windows.Forms.Button
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
    Friend WithEvents cmdTambos As System.Windows.Forms.Button
End Class
