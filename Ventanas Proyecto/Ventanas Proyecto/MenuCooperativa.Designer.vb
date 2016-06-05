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
        Me.cmdTambo1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdTambo1
        '
        Me.cmdTambo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTambo1.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdTambo1.Image = CType(resources.GetObject("cmdTambo1.Image"), System.Drawing.Image)
        Me.cmdTambo1.Location = New System.Drawing.Point(141, 74)
        Me.cmdTambo1.Name = "cmdTambo1"
        Me.cmdTambo1.Size = New System.Drawing.Size(93, 94)
        Me.cmdTambo1.TabIndex = 0
        Me.cmdTambo1.Text = "Button1"
        Me.cmdTambo1.UseVisualStyleBackColor = True
        '
        'MenuCooperativa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 565)
        Me.Controls.Add(Me.cmdTambo1)
        Me.Name = "MenuCooperativa"
        Me.Text = "Menu Cooperativa"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdTambo1 As Button
End Class
