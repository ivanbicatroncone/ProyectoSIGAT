<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresarLote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngresarLote))
        Me.lblIdLote = New System.Windows.Forms.Label()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.lblVacasPertenecientes = New System.Windows.Forms.Label()
        Me.txtVacasLote = New System.Windows.Forms.Label()
        Me.cmdComenzar = New System.Windows.Forms.Button()
        Me.txtIdLote = New System.Windows.Forms.TextBox()
        Me.contVacasCant = New System.Windows.Forms.NumericUpDown()
        Me.gbVacasLote = New System.Windows.Forms.GroupBox()
        Me.txtIdVaca = New System.Windows.Forms.TextBox()
        Me.lblIdVaca = New System.Windows.Forms.Label()
        Me.cmdFinalizar = New System.Windows.Forms.Button()
        CType(Me.contVacasCant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbVacasLote.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIdLote
        '
        Me.lblIdLote.AutoSize = True
        Me.lblIdLote.Location = New System.Drawing.Point(65, 73)
        Me.lblIdLote.Name = "lblIdLote"
        Me.lblIdLote.Size = New System.Drawing.Size(40, 13)
        Me.lblIdLote.TabIndex = 1
        Me.lblIdLote.Text = "Id Lote"
        '
        'cmdIngresar
        '
        Me.cmdIngresar.BackColor = System.Drawing.Color.Transparent
        Me.cmdIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdIngresar.FlatAppearance.BorderSize = 0
        Me.cmdIngresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIngresar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdIngresar.Image = CType(resources.GetObject("cmdIngresar.Image"), System.Drawing.Image)
        Me.cmdIngresar.Location = New System.Drawing.Point(94, 110)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(75, 30)
        Me.cmdIngresar.TabIndex = 2
        Me.cmdIngresar.Text = "Ingresar"
        Me.cmdIngresar.UseVisualStyleBackColor = False
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
        Me.cmdAtras.Location = New System.Drawing.Point(12, 12)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(75, 28)
        Me.cmdAtras.TabIndex = 3
        Me.cmdAtras.Text = "Atras"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'lblVacasPertenecientes
        '
        Me.lblVacasPertenecientes.AutoSize = True
        Me.lblVacasPertenecientes.Location = New System.Drawing.Point(66, 93)
        Me.lblVacasPertenecientes.Name = "lblVacasPertenecientes"
        Me.lblVacasPertenecientes.Size = New System.Drawing.Size(0, 13)
        Me.lblVacasPertenecientes.TabIndex = 4
        '
        'txtVacasLote
        '
        Me.txtVacasLote.AutoSize = True
        Me.txtVacasLote.Location = New System.Drawing.Point(67, 108)
        Me.txtVacasLote.Name = "txtVacasLote"
        Me.txtVacasLote.Size = New System.Drawing.Size(37, 13)
        Me.txtVacasLote.TabIndex = 5
        Me.txtVacasLote.Text = "Vacas"
        '
        'cmdComenzar
        '
        Me.cmdComenzar.BackColor = System.Drawing.Color.Transparent
        Me.cmdComenzar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdComenzar.FlatAppearance.BorderSize = 0
        Me.cmdComenzar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdComenzar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdComenzar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdComenzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdComenzar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdComenzar.Image = CType(resources.GetObject("cmdComenzar.Image"), System.Drawing.Image)
        Me.cmdComenzar.Location = New System.Drawing.Point(366, 106)
        Me.cmdComenzar.Name = "cmdComenzar"
        Me.cmdComenzar.Size = New System.Drawing.Size(84, 31)
        Me.cmdComenzar.TabIndex = 6
        Me.cmdComenzar.Text = "Comenzar"
        Me.cmdComenzar.UseVisualStyleBackColor = False
        '
        'txtIdLote
        '
        Me.txtIdLote.Location = New System.Drawing.Point(195, 66)
        Me.txtIdLote.Name = "txtIdLote"
        Me.txtIdLote.Size = New System.Drawing.Size(120, 20)
        Me.txtIdLote.TabIndex = 8
        '
        'contVacasCant
        '
        Me.contVacasCant.Location = New System.Drawing.Point(195, 106)
        Me.contVacasCant.Name = "contVacasCant"
        Me.contVacasCant.Size = New System.Drawing.Size(120, 20)
        Me.contVacasCant.TabIndex = 9
        '
        'gbVacasLote
        '
        Me.gbVacasLote.Controls.Add(Me.txtIdVaca)
        Me.gbVacasLote.Controls.Add(Me.lblIdVaca)
        Me.gbVacasLote.Controls.Add(Me.cmdIngresar)
        Me.gbVacasLote.Location = New System.Drawing.Point(101, 171)
        Me.gbVacasLote.Name = "gbVacasLote"
        Me.gbVacasLote.Size = New System.Drawing.Size(266, 167)
        Me.gbVacasLote.TabIndex = 10
        Me.gbVacasLote.TabStop = False
        Me.gbVacasLote.Visible = False
        '
        'txtIdVaca
        '
        Me.txtIdVaca.Location = New System.Drawing.Point(147, 44)
        Me.txtIdVaca.Name = "txtIdVaca"
        Me.txtIdVaca.Size = New System.Drawing.Size(100, 20)
        Me.txtIdVaca.TabIndex = 1
        '
        'lblIdVaca
        '
        Me.lblIdVaca.AutoSize = True
        Me.lblIdVaca.Location = New System.Drawing.Point(6, 44)
        Me.lblIdVaca.Name = "lblIdVaca"
        Me.lblIdVaca.Size = New System.Drawing.Size(110, 13)
        Me.lblIdVaca.TabIndex = 0
        Me.lblIdVaca.Text = "Ingresar Id de la vaca"
        '
        'cmdFinalizar
        '
        Me.cmdFinalizar.BackColor = System.Drawing.Color.Transparent
        Me.cmdFinalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdFinalizar.FlatAppearance.BorderSize = 0
        Me.cmdFinalizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFinalizar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdFinalizar.Image = CType(resources.GetObject("cmdFinalizar.Image"), System.Drawing.Image)
        Me.cmdFinalizar.Location = New System.Drawing.Point(195, 383)
        Me.cmdFinalizar.Name = "cmdFinalizar"
        Me.cmdFinalizar.Size = New System.Drawing.Size(75, 31)
        Me.cmdFinalizar.TabIndex = 11
        Me.cmdFinalizar.Text = "Finalizar"
        Me.cmdFinalizar.UseVisualStyleBackColor = False
        '
        'frmIngresarLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(483, 426)
        Me.Controls.Add(Me.cmdFinalizar)
        Me.Controls.Add(Me.gbVacasLote)
        Me.Controls.Add(Me.contVacasCant)
        Me.Controls.Add(Me.txtIdLote)
        Me.Controls.Add(Me.cmdComenzar)
        Me.Controls.Add(Me.txtVacasLote)
        Me.Controls.Add(Me.lblVacasPertenecientes)
        Me.Controls.Add(Me.cmdAtras)
        Me.Controls.Add(Me.lblIdLote)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmIngresarLote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Ingresar Lote"
        CType(Me.contVacasCant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbVacasLote.ResumeLayout(False)
        Me.gbVacasLote.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIdLote As System.Windows.Forms.Label
    Friend WithEvents cmdIngresar As System.Windows.Forms.Button
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
    Friend WithEvents lblVacasPertenecientes As System.Windows.Forms.Label
    Friend WithEvents txtVacasLote As System.Windows.Forms.Label
    Friend WithEvents cmdComenzar As System.Windows.Forms.Button
    Friend WithEvents txtIdLote As System.Windows.Forms.TextBox
    Friend WithEvents contVacasCant As System.Windows.Forms.NumericUpDown
    Friend WithEvents gbVacasLote As System.Windows.Forms.GroupBox
    Friend WithEvents txtIdVaca As System.Windows.Forms.TextBox
    Friend WithEvents lblIdVaca As System.Windows.Forms.Label
    Friend WithEvents cmdFinalizar As System.Windows.Forms.Button
End Class
