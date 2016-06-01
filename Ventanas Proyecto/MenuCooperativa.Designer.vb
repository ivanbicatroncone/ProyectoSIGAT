<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuCooperativa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuCooperativa))
        Me.cmdNuevoTambo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tambo1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdNuevoTambo
        '
        Me.cmdNuevoTambo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNuevoTambo.BackgroundImage = CType(resources.GetObject("cmdNuevoTambo.BackgroundImage"), System.Drawing.Image)
        Me.cmdNuevoTambo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdNuevoTambo.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevoTambo.ForeColor = System.Drawing.Color.White
        Me.cmdNuevoTambo.Location = New System.Drawing.Point(519, 110)
        Me.cmdNuevoTambo.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdNuevoTambo.Name = "cmdNuevoTambo"
        Me.cmdNuevoTambo.Size = New System.Drawing.Size(190, 160)
        Me.cmdNuevoTambo.TabIndex = 2
        Me.cmdNuevoTambo.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TAMBO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+"
        Me.cmdNuevoTambo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.cmdNuevoTambo.UseCompatibleTextRendering = True
        Me.cmdNuevoTambo.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(295, 110)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 160)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "TAMBO 2"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Tambo1
        '
        Me.Tambo1.BackColor = System.Drawing.SystemColors.Control
        Me.Tambo1.BackgroundImage = CType(resources.GetObject("Tambo1.BackgroundImage"), System.Drawing.Image)
        Me.Tambo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Tambo1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tambo1.ForeColor = System.Drawing.Color.White
        Me.Tambo1.Location = New System.Drawing.Point(70, 110)
        Me.Tambo1.Margin = New System.Windows.Forms.Padding(0)
        Me.Tambo1.Name = "Tambo1"
        Me.Tambo1.Size = New System.Drawing.Size(190, 160)
        Me.Tambo1.TabIndex = 0
        Me.Tambo1.Text = "TAMBO 1"
        Me.Tambo1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Tambo1.UseCompatibleTextRendering = True
        Me.Tambo1.UseVisualStyleBackColor = False
        '
        'MenuCooperativa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 565)
        Me.Controls.Add(Me.cmdNuevoTambo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tambo1)
        Me.Name = "MenuCooperativa"
        Me.Text = "Menu Cooperativa"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tambo1 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdNuevoTambo As Button
End Class
