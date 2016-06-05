<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuTambo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuTambo))
        Me.cmdAtrasTambo = New System.Windows.Forms.Button()
        Me.cmdRodeoTambo = New System.Windows.Forms.Button()
        Me.FondoMenuTambo = New System.Windows.Forms.PictureBox()
        Me.cmdAnimalesMenuTambo = New System.Windows.Forms.Button()
        CType(Me.FondoMenuTambo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAtrasTambo
        '
        Me.cmdAtrasTambo.BackColor = System.Drawing.Color.Transparent
        Me.cmdAtrasTambo.FlatAppearance.BorderSize = 0
        Me.cmdAtrasTambo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAtrasTambo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdAtrasTambo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAtrasTambo.ForeColor = System.Drawing.Color.Transparent
        Me.cmdAtrasTambo.Image = CType(resources.GetObject("cmdAtrasTambo.Image"), System.Drawing.Image)
        Me.cmdAtrasTambo.Location = New System.Drawing.Point(12, 12)
        Me.cmdAtrasTambo.Name = "cmdAtrasTambo"
        Me.cmdAtrasTambo.Size = New System.Drawing.Size(75, 30)
        Me.cmdAtrasTambo.TabIndex = 2
        Me.cmdAtrasTambo.Text = "Atrás"
        Me.cmdAtrasTambo.UseVisualStyleBackColor = False
        '
        'cmdRodeoTambo
        '
        Me.cmdRodeoTambo.BackColor = System.Drawing.Color.Transparent
        Me.cmdRodeoTambo.BackgroundImage = CType(resources.GetObject("cmdRodeoTambo.BackgroundImage"), System.Drawing.Image)
        Me.cmdRodeoTambo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdRodeoTambo.FlatAppearance.BorderSize = 0
        Me.cmdRodeoTambo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdRodeoTambo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdRodeoTambo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRodeoTambo.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRodeoTambo.ForeColor = System.Drawing.Color.White
        Me.cmdRodeoTambo.Location = New System.Drawing.Point(298, 88)
        Me.cmdRodeoTambo.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdRodeoTambo.Name = "cmdRodeoTambo"
        Me.cmdRodeoTambo.Size = New System.Drawing.Size(197, 166)
        Me.cmdRodeoTambo.TabIndex = 3
        Me.cmdRodeoTambo.Text = "Rodeo"
        Me.cmdRodeoTambo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.cmdRodeoTambo.UseCompatibleTextRendering = True
        Me.cmdRodeoTambo.UseVisualStyleBackColor = False
        '
        'FondoMenuTambo
        '
        Me.FondoMenuTambo.BackgroundImage = CType(resources.GetObject("FondoMenuTambo.BackgroundImage"), System.Drawing.Image)
        Me.FondoMenuTambo.Location = New System.Drawing.Point(-3, 0)
        Me.FondoMenuTambo.Name = "FondoMenuTambo"
        Me.FondoMenuTambo.Size = New System.Drawing.Size(787, 569)
        Me.FondoMenuTambo.TabIndex = 4
        Me.FondoMenuTambo.TabStop = False
        '
        'cmdAnimalesMenuTambo
        '
        Me.cmdAnimalesMenuTambo.BackColor = System.Drawing.Color.Transparent
        Me.cmdAnimalesMenuTambo.BackgroundImage = CType(resources.GetObject("cmdAnimalesMenuTambo.BackgroundImage"), System.Drawing.Image)
        Me.cmdAnimalesMenuTambo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdAnimalesMenuTambo.FlatAppearance.BorderSize = 0
        Me.cmdAnimalesMenuTambo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdAnimalesMenuTambo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdAnimalesMenuTambo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAnimalesMenuTambo.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnimalesMenuTambo.ForeColor = System.Drawing.Color.White
        Me.cmdAnimalesMenuTambo.ImageKey = "(none)"
        Me.cmdAnimalesMenuTambo.Location = New System.Drawing.Point(86, 88)
        Me.cmdAnimalesMenuTambo.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdAnimalesMenuTambo.Name = "cmdAnimalesMenuTambo"
        Me.cmdAnimalesMenuTambo.Size = New System.Drawing.Size(190, 160)
        Me.cmdAnimalesMenuTambo.TabIndex = 5
        Me.cmdAnimalesMenuTambo.Text = "Animales"
        Me.cmdAnimalesMenuTambo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.cmdAnimalesMenuTambo.UseCompatibleTextRendering = True
        Me.cmdAnimalesMenuTambo.UseVisualStyleBackColor = False
        '
        'MenuTambo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 565)
        Me.Controls.Add(Me.cmdAnimalesMenuTambo)
        Me.Controls.Add(Me.cmdRodeoTambo)
        Me.Controls.Add(Me.cmdAtrasTambo)
        Me.Controls.Add(Me.FondoMenuTambo)
        Me.Name = "MenuTambo"
        Me.Text = "MenuTambo"
        CType(Me.FondoMenuTambo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAtrasTambo As Button
    Friend WithEvents cmdRodeoTambo As Button
    Friend WithEvents FondoMenuTambo As PictureBox
    Friend WithEvents cmdAnimalesMenuTambo As Button
End Class
