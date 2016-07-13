<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresarControlLechero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngresarControlLechero))
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblGrasas = New System.Windows.Forms.Label()
        Me.lblProteinas = New System.Windows.Forms.Label()
        Me.lblCelulasSomaticas = New System.Windows.Forms.Label()
        Me.lblIdVaca = New System.Windows.Forms.Label()
        Me.txtIdVaca = New System.Windows.Forms.TextBox()
        Me.FechaControlLechero = New System.Windows.Forms.DateTimePicker()
        Me.txtGrasas = New System.Windows.Forms.TextBox()
        Me.txtProteinas = New System.Windows.Forms.TextBox()
        Me.txCelulasSomaticas = New System.Windows.Forms.TextBox()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdAtras
        '
        Me.cmdAtras.BackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAtras.FlatAppearance.BorderSize = 0
        Me.cmdAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAtras.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdAtras.Image = CType(resources.GetObject("cmdAtras.Image"), System.Drawing.Image)
        Me.cmdAtras.Location = New System.Drawing.Point(7, 7)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(75, 35)
        Me.cmdAtras.TabIndex = 0
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(60, 140)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha"
        '
        'lblGrasas
        '
        Me.lblGrasas.AutoSize = True
        Me.lblGrasas.Location = New System.Drawing.Point(60, 190)
        Me.lblGrasas.Name = "lblGrasas"
        Me.lblGrasas.Size = New System.Drawing.Size(40, 13)
        Me.lblGrasas.TabIndex = 2
        Me.lblGrasas.Text = "Grasas"
        '
        'lblProteinas
        '
        Me.lblProteinas.AutoSize = True
        Me.lblProteinas.Location = New System.Drawing.Point(60, 246)
        Me.lblProteinas.Name = "lblProteinas"
        Me.lblProteinas.Size = New System.Drawing.Size(51, 13)
        Me.lblProteinas.TabIndex = 3
        Me.lblProteinas.Text = "Proteinas"
        '
        'lblCelulasSomaticas
        '
        Me.lblCelulasSomaticas.AutoSize = True
        Me.lblCelulasSomaticas.Location = New System.Drawing.Point(60, 295)
        Me.lblCelulasSomaticas.Name = "lblCelulasSomaticas"
        Me.lblCelulasSomaticas.Size = New System.Drawing.Size(93, 13)
        Me.lblCelulasSomaticas.TabIndex = 4
        Me.lblCelulasSomaticas.Text = "Células Somáticas"
        '
        'lblIdVaca
        '
        Me.lblIdVaca.AutoSize = True
        Me.lblIdVaca.Location = New System.Drawing.Point(60, 85)
        Me.lblIdVaca.Name = "lblIdVaca"
        Me.lblIdVaca.Size = New System.Drawing.Size(44, 13)
        Me.lblIdVaca.TabIndex = 6
        Me.lblIdVaca.Text = "Id Vaca"
        '
        'txtIdVaca
        '
        Me.txtIdVaca.Location = New System.Drawing.Point(212, 77)
        Me.txtIdVaca.Name = "txtIdVaca"
        Me.txtIdVaca.Size = New System.Drawing.Size(200, 20)
        Me.txtIdVaca.TabIndex = 7
        '
        'FechaControlLechero
        '
        Me.FechaControlLechero.Location = New System.Drawing.Point(212, 132)
        Me.FechaControlLechero.Name = "FechaControlLechero"
        Me.FechaControlLechero.Size = New System.Drawing.Size(200, 20)
        Me.FechaControlLechero.TabIndex = 8
        '
        'txtGrasas
        '
        Me.txtGrasas.Location = New System.Drawing.Point(212, 187)
        Me.txtGrasas.Name = "txtGrasas"
        Me.txtGrasas.Size = New System.Drawing.Size(200, 20)
        Me.txtGrasas.TabIndex = 9
        '
        'txtProteinas
        '
        Me.txtProteinas.Location = New System.Drawing.Point(212, 239)
        Me.txtProteinas.Name = "txtProteinas"
        Me.txtProteinas.Size = New System.Drawing.Size(200, 20)
        Me.txtProteinas.TabIndex = 10
        '
        'txCelulasSomaticas
        '
        Me.txCelulasSomaticas.Location = New System.Drawing.Point(212, 288)
        Me.txCelulasSomaticas.Name = "txCelulasSomaticas"
        Me.txCelulasSomaticas.Size = New System.Drawing.Size(200, 20)
        Me.txCelulasSomaticas.TabIndex = 11
        '
        'cmdGuardar
        '
        Me.cmdGuardar.BackColor = System.Drawing.Color.Transparent
        Me.cmdGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGuardar.FlatAppearance.BorderSize = 0
        Me.cmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.Location = New System.Drawing.Point(201, 372)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 36)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = False
        '
        'frmIngresarControlLechero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 420)
        Me.Controls.Add(Me.txCelulasSomaticas)
        Me.Controls.Add(Me.txtProteinas)
        Me.Controls.Add(Me.txtGrasas)
        Me.Controls.Add(Me.FechaControlLechero)
        Me.Controls.Add(Me.txtIdVaca)
        Me.Controls.Add(Me.lblIdVaca)
        Me.Controls.Add(Me.lblCelulasSomaticas)
        Me.Controls.Add(Me.lblProteinas)
        Me.Controls.Add(Me.lblGrasas)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.cmdAtras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmIngresarControlLechero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Ingresar Control Lechero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblGrasas As System.Windows.Forms.Label
    Friend WithEvents lblProteinas As System.Windows.Forms.Label
    Friend WithEvents lblCelulasSomaticas As System.Windows.Forms.Label
    Friend WithEvents lblIdVaca As System.Windows.Forms.Label
    Friend WithEvents txtIdVaca As System.Windows.Forms.TextBox
    Friend WithEvents FechaControlLechero As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtGrasas As System.Windows.Forms.TextBox
    Friend WithEvents txtProteinas As System.Windows.Forms.TextBox
    Friend WithEvents txCelulasSomaticas As System.Windows.Forms.TextBox
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
End Class
