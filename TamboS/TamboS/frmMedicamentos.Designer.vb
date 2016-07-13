<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedicamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedicamentos))
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.cmdAtras = New System.Windows.Forms.Button()
        Me.lblTipoMedicamento = New System.Windows.Forms.Label()
        Me.lblNombreMedicamento = New System.Windows.Forms.Label()
        Me.txtNombreMedicamento = New System.Windows.Forms.TextBox()
        Me.cbTipoMedicamento = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
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
        Me.cmdIngresar.Location = New System.Drawing.Point(129, 267)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(75, 31)
        Me.cmdIngresar.TabIndex = 0
        Me.cmdIngresar.Text = "Ingresar"
        Me.cmdIngresar.UseVisualStyleBackColor = False
        '
        'cmdAtras
        '
        Me.cmdAtras.BackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAtras.FlatAppearance.BorderSize = 0
        Me.cmdAtras.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAtras.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdAtras.Image = CType(resources.GetObject("cmdAtras.Image"), System.Drawing.Image)
        Me.cmdAtras.Location = New System.Drawing.Point(13, 13)
        Me.cmdAtras.Name = "cmdAtras"
        Me.cmdAtras.Size = New System.Drawing.Size(75, 23)
        Me.cmdAtras.TabIndex = 1
        Me.cmdAtras.Text = "Atrás"
        Me.cmdAtras.UseVisualStyleBackColor = False
        '
        'lblTipoMedicamento
        '
        Me.lblTipoMedicamento.AutoSize = True
        Me.lblTipoMedicamento.Location = New System.Drawing.Point(60, 159)
        Me.lblTipoMedicamento.Name = "lblTipoMedicamento"
        Me.lblTipoMedicamento.Size = New System.Drawing.Size(28, 13)
        Me.lblTipoMedicamento.TabIndex = 2
        Me.lblTipoMedicamento.Text = "Tipo"
        '
        'lblNombreMedicamento
        '
        Me.lblNombreMedicamento.AutoSize = True
        Me.lblNombreMedicamento.Location = New System.Drawing.Point(59, 95)
        Me.lblNombreMedicamento.Name = "lblNombreMedicamento"
        Me.lblNombreMedicamento.Size = New System.Drawing.Size(44, 13)
        Me.lblNombreMedicamento.TabIndex = 3
        Me.lblNombreMedicamento.Text = "Nombre"
        '
        'txtNombreMedicamento
        '
        Me.txtNombreMedicamento.Location = New System.Drawing.Point(192, 88)
        Me.txtNombreMedicamento.Name = "txtNombreMedicamento"
        Me.txtNombreMedicamento.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreMedicamento.TabIndex = 4
        '
        'cbTipoMedicamento
        '
        Me.cbTipoMedicamento.FormattingEnabled = True
        Me.cbTipoMedicamento.Items.AddRange(New Object() {"Inyectable", "Infusión ", "Comprimido"})
        Me.cbTipoMedicamento.Location = New System.Drawing.Point(192, 156)
        Me.cbTipoMedicamento.Name = "cbTipoMedicamento"
        Me.cbTipoMedicamento.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoMedicamento.TabIndex = 5
        '
        'frmMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(345, 320)
        Me.Controls.Add(Me.cbTipoMedicamento)
        Me.Controls.Add(Me.txtNombreMedicamento)
        Me.Controls.Add(Me.lblNombreMedicamento)
        Me.Controls.Add(Me.lblTipoMedicamento)
        Me.Controls.Add(Me.cmdAtras)
        Me.Controls.Add(Me.cmdIngresar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMedicamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamboS - Medicamentos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdIngresar As System.Windows.Forms.Button
    Friend WithEvents cmdAtras As System.Windows.Forms.Button
    Friend WithEvents lblTipoMedicamento As System.Windows.Forms.Label
    Friend WithEvents lblNombreMedicamento As System.Windows.Forms.Label
    Friend WithEvents txtNombreMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents cbTipoMedicamento As System.Windows.Forms.ComboBox
End Class
