<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformationsPointOfSaleControlItem
    Inherits System.Windows.Forms.UserControl

    'Descartar substituições de UserControl para limpar lista de componentes.
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
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Border2 = New Work_PdvSystem_Project.Border()
        Me.Border3 = New Work_PdvSystem_Project.Border()
        Me.Border4 = New Work_PdvSystem_Project.Border()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Title_Label = New System.Windows.Forms.Label()
        Me.Text_Label = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Panel2)
        Me.Panel6.Controls.Add(Me.Panel1)
        Me.Panel6.Controls.Add(Me.Border4)
        Me.Panel6.Controls.Add(Me.Border3)
        Me.Panel6.Controls.Add(Me.Border2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(500, 80)
        Me.Panel6.TabIndex = 1
        '
        'Border2
        '
        Me.Border2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Border2.BorderPosition = Work_PdvSystem_Project.Border.BorderPositionEnum.Bottom
        Me.Border2.BorderSize = 1
        Me.Border2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Border2.Location = New System.Drawing.Point(0, 79)
        Me.Border2.Name = "Border2"
        Me.Border2.Size = New System.Drawing.Size(500, 1)
        Me.Border2.TabIndex = 1
        '
        'Border3
        '
        Me.Border3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Border3.BorderPosition = Work_PdvSystem_Project.Border.BorderPositionEnum.Right
        Me.Border3.BorderSize = 1
        Me.Border3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Border3.Location = New System.Drawing.Point(499, 0)
        Me.Border3.Name = "Border3"
        Me.Border3.Size = New System.Drawing.Size(1, 79)
        Me.Border3.TabIndex = 2
        '
        'Border4
        '
        Me.Border4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Border4.BorderPosition = Work_PdvSystem_Project.Border.BorderPositionEnum.Left
        Me.Border4.BorderSize = 1
        Me.Border4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Border4.Location = New System.Drawing.Point(0, 0)
        Me.Border4.Name = "Border4"
        Me.Border4.Size = New System.Drawing.Size(1, 79)
        Me.Border4.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Title_Label)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(498, 30)
        Me.Panel1.TabIndex = 4
        '
        'Title_Label
        '
        Me.Title_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Title_Label.AutoSize = True
        Me.Title_Label.BackColor = System.Drawing.Color.Transparent
        Me.Title_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_Label.Location = New System.Drawing.Point(10, 6)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Size = New System.Drawing.Size(34, 19)
        Me.Title_Label.TabIndex = 1
        Me.Title_Label.Text = "title"
        '
        'Text_Label
        '
        Me.Text_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Text_Label.AutoSize = True
        Me.Text_Label.BackColor = System.Drawing.Color.Transparent
        Me.Text_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Label.Location = New System.Drawing.Point(7, 4)
        Me.Text_Label.Name = "Text_Label"
        Me.Text_Label.Size = New System.Drawing.Size(66, 41)
        Me.Text_Label.TabIndex = 6
        Me.Text_Label.Text = "text"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Text_Label)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(1, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(498, 49)
        Me.Panel2.TabIndex = 7
        '
        'InformationsPointOfSaleControlItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.Panel6)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "InformationsPointOfSaleControlItem"
        Me.Size = New System.Drawing.Size(500, 100)
        Me.Panel6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Border4 As Work_PdvSystem_Project.Border
    Friend WithEvents Border3 As Work_PdvSystem_Project.Border
    Friend WithEvents Border2 As Work_PdvSystem_Project.Border
    Friend WithEvents Title_Label As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Text_Label As System.Windows.Forms.Label

End Class
