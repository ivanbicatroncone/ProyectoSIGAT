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
        Me.Tambo1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Tambo1
        '
        Me.Tambo1.BackColor = System.Drawing.SystemColors.Control
        Me.Tambo1.BackgroundImage = CType(resources.GetObject("Tambo1.BackgroundImage"), System.Drawing.Image)
        Me.Tambo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Tambo1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tambo1.ForeColor = System.Drawing.Color.White
        Me.Tambo1.Location = New System.Drawing.Point(57, 61)
        Me.Tambo1.Margin = New System.Windows.Forms.Padding(0)
        Me.Tambo1.Name = "Tambo1"
        Me.Tambo1.Size = New System.Drawing.Size(190, 160)
        Me.Tambo1.TabIndex = 1
        Me.Tambo1.Text = "Animales"
        Me.Tambo1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Tambo1.UseCompatibleTextRendering = True
        Me.Tambo1.UseVisualStyleBackColor = False
        '
        'MenuTambo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 565)
        Me.Controls.Add(Me.Tambo1)
        Me.Name = "MenuTambo"
        Me.Text = "MenuTambo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tambo1 As Button
End Class
