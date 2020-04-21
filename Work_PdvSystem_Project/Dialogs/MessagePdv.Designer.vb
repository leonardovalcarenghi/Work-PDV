<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessagePdv
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CloseLabel = New System.Windows.Forms.Label()
        Me.MessageText_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CloseLabel
        '
        Me.CloseLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CloseLabel.AutoSize = True
        Me.CloseLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.CloseLabel.Location = New System.Drawing.Point(330, 176)
        Me.CloseLabel.Name = "CloseLabel"
        Me.CloseLabel.Size = New System.Drawing.Size(145, 15)
        Me.CloseLabel.TabIndex = 7
        Me.CloseLabel.Text = "Pressione 'Esc' para fechar."
        '
        'MessageText_Label
        '
        Me.MessageText_Label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageText_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageText_Label.Location = New System.Drawing.Point(0, 0)
        Me.MessageText_Label.Name = "MessageText_Label"
        Me.MessageText_Label.Size = New System.Drawing.Size(805, 200)
        Me.MessageText_Label.TabIndex = 6
        Me.MessageText_Label.Text = "message"
        Me.MessageText_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MessagePdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(805, 200)
        Me.Controls.Add(Me.CloseLabel)
        Me.Controls.Add(Me.MessageText_Label)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MessagePdv"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloseLabel As System.Windows.Forms.Label
    Friend WithEvents MessageText_Label As System.Windows.Forms.Label

End Class
