<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterOperatorCodeDialog
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
        Me.BordersPanel = New System.Windows.Forms.Panel()
        Me.ControlsForm = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.EnterValue_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TitleEnterValue_Label = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.CloseLabel = New System.Windows.Forms.Label()
        Me.Status_Label = New System.Windows.Forms.Label()
        Me.TitleDialogHeader_Panel = New System.Windows.Forms.Panel()
        Me.TitleDialog_Label = New System.Windows.Forms.Label()
        Me.BorderRight = New Work_PdvSystem_Project.Border()
        Me.BorderLeft = New Work_PdvSystem_Project.Border()
        Me.BorderBottom = New Work_PdvSystem_Project.Border()
        Me.BorderTop = New Work_PdvSystem_Project.Border()
        Me.BordersPanel.SuspendLayout()
        Me.ControlsForm.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TitleDialogHeader_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BordersPanel
        '
        Me.BordersPanel.Controls.Add(Me.ControlsForm)
        Me.BordersPanel.Controls.Add(Me.BorderRight)
        Me.BordersPanel.Controls.Add(Me.BorderLeft)
        Me.BordersPanel.Controls.Add(Me.BorderBottom)
        Me.BordersPanel.Controls.Add(Me.BorderTop)
        Me.BordersPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BordersPanel.Location = New System.Drawing.Point(0, 0)
        Me.BordersPanel.Name = "BordersPanel"
        Me.BordersPanel.Size = New System.Drawing.Size(700, 200)
        Me.BordersPanel.TabIndex = 1
        '
        'ControlsForm
        '
        Me.ControlsForm.Controls.Add(Me.Panel2)
        Me.ControlsForm.Controls.Add(Me.Panel5)
        Me.ControlsForm.Controls.Add(Me.TitleDialogHeader_Panel)
        Me.ControlsForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlsForm.Location = New System.Drawing.Point(1, 1)
        Me.ControlsForm.Name = "ControlsForm"
        Me.ControlsForm.Size = New System.Drawing.Size(698, 198)
        Me.ControlsForm.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(698, 118)
        Me.Panel2.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(149, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 32)
        Me.Panel1.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.Controls.Add(Me.EnterValue_TextBox)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(140, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(2, 3, 2, 0)
        Me.Panel4.Size = New System.Drawing.Size(260, 32)
        Me.Panel4.TabIndex = 8
        '
        'EnterValue_TextBox
        '
        Me.EnterValue_TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EnterValue_TextBox.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.EnterValue_TextBox.Location = New System.Drawing.Point(2, 3)
        Me.EnterValue_TextBox.Name = "EnterValue_TextBox"
        Me.EnterValue_TextBox.Size = New System.Drawing.Size(256, 27)
        Me.EnterValue_TextBox.TabIndex = 0
        Me.EnterValue_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.Controls.Add(Me.TitleEnterValue_Label)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.Panel3.Size = New System.Drawing.Size(140, 32)
        Me.Panel3.TabIndex = 7
        '
        'TitleEnterValue_Label
        '
        Me.TitleEnterValue_Label.AutoSize = True
        Me.TitleEnterValue_Label.Dock = System.Windows.Forms.DockStyle.Left
        Me.TitleEnterValue_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleEnterValue_Label.Location = New System.Drawing.Point(0, 6)
        Me.TitleEnterValue_Label.Name = "TitleEnterValue_Label"
        Me.TitleEnterValue_Label.Size = New System.Drawing.Size(140, 19)
        Me.TitleEnterValue_Label.TabIndex = 7
        Me.TitleEnterValue_Label.Text = "Código do Operador:"
        Me.TitleEnterValue_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.CloseLabel)
        Me.Panel5.Controls.Add(Me.Status_Label)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 168)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(698, 30)
        Me.Panel5.TabIndex = 8
        '
        'CloseLabel
        '
        Me.CloseLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CloseLabel.AutoSize = True
        Me.CloseLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CloseLabel.Location = New System.Drawing.Point(10, 8)
        Me.CloseLabel.Name = "CloseLabel"
        Me.CloseLabel.Size = New System.Drawing.Size(145, 15)
        Me.CloseLabel.TabIndex = 9
        Me.CloseLabel.Text = "Pressione 'Esc' para fechar."
        '
        'Status_Label
        '
        Me.Status_Label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Status_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status_Label.Location = New System.Drawing.Point(0, 0)
        Me.Status_Label.Name = "Status_Label"
        Me.Status_Label.Size = New System.Drawing.Size(698, 30)
        Me.Status_Label.TabIndex = 10
        Me.Status_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TitleDialogHeader_Panel
        '
        Me.TitleDialogHeader_Panel.Controls.Add(Me.TitleDialog_Label)
        Me.TitleDialogHeader_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleDialogHeader_Panel.Location = New System.Drawing.Point(0, 0)
        Me.TitleDialogHeader_Panel.Name = "TitleDialogHeader_Panel"
        Me.TitleDialogHeader_Panel.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.TitleDialogHeader_Panel.Size = New System.Drawing.Size(698, 50)
        Me.TitleDialogHeader_Panel.TabIndex = 5
        '
        'TitleDialog_Label
        '
        Me.TitleDialog_Label.BackColor = System.Drawing.Color.MidnightBlue
        Me.TitleDialog_Label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleDialog_Label.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleDialog_Label.ForeColor = System.Drawing.Color.White
        Me.TitleDialog_Label.Location = New System.Drawing.Point(0, 10)
        Me.TitleDialog_Label.Name = "TitleDialog_Label"
        Me.TitleDialog_Label.Size = New System.Drawing.Size(698, 30)
        Me.TitleDialog_Label.TabIndex = 5
        Me.TitleDialog_Label.Text = "operator"
        Me.TitleDialog_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BorderRight
        '
        Me.BorderRight.BackColor = System.Drawing.Color.MidnightBlue
        Me.BorderRight.BorderPosition = Work_PdvSystem_Project.Border.BorderPositionEnum.Right
        Me.BorderRight.BorderSize = 1
        Me.BorderRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.BorderRight.Location = New System.Drawing.Point(699, 1)
        Me.BorderRight.Name = "BorderRight"
        Me.BorderRight.Size = New System.Drawing.Size(1, 198)
        Me.BorderRight.TabIndex = 3
        '
        'BorderLeft
        '
        Me.BorderLeft.BackColor = System.Drawing.Color.MidnightBlue
        Me.BorderLeft.BorderPosition = Work_PdvSystem_Project.Border.BorderPositionEnum.Top
        Me.BorderLeft.BorderSize = 1
        Me.BorderLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.BorderLeft.Location = New System.Drawing.Point(0, 1)
        Me.BorderLeft.Name = "BorderLeft"
        Me.BorderLeft.Size = New System.Drawing.Size(1, 198)
        Me.BorderLeft.TabIndex = 2
        '
        'BorderBottom
        '
        Me.BorderBottom.BackColor = System.Drawing.Color.MidnightBlue
        Me.BorderBottom.BorderPosition = Work_PdvSystem_Project.Border.BorderPositionEnum.Bottom
        Me.BorderBottom.BorderSize = 1
        Me.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BorderBottom.Location = New System.Drawing.Point(0, 199)
        Me.BorderBottom.Name = "BorderBottom"
        Me.BorderBottom.Size = New System.Drawing.Size(700, 1)
        Me.BorderBottom.TabIndex = 1
        '
        'BorderTop
        '
        Me.BorderTop.BackColor = System.Drawing.Color.MidnightBlue
        Me.BorderTop.BorderPosition = Work_PdvSystem_Project.Border.BorderPositionEnum.Top
        Me.BorderTop.BorderSize = 1
        Me.BorderTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.BorderTop.Location = New System.Drawing.Point(0, 0)
        Me.BorderTop.Name = "BorderTop"
        Me.BorderTop.Size = New System.Drawing.Size(700, 1)
        Me.BorderTop.TabIndex = 0
        '
        'EnterOperatorCodeDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 200)
        Me.Controls.Add(Me.BordersPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EnterOperatorCodeDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.BordersPanel.ResumeLayout(False)
        Me.ControlsForm.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TitleDialogHeader_Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BordersPanel As System.Windows.Forms.Panel
    Friend WithEvents ControlsForm As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TitleDialogHeader_Panel As System.Windows.Forms.Panel
    Friend WithEvents TitleDialog_Label As System.Windows.Forms.Label
    Friend WithEvents BorderRight As Work_PdvSystem_Project.Border
    Friend WithEvents BorderLeft As Work_PdvSystem_Project.Border
    Friend WithEvents BorderBottom As Work_PdvSystem_Project.Border
    Friend WithEvents BorderTop As Work_PdvSystem_Project.Border
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EnterValue_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TitleEnterValue_Label As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents CloseLabel As System.Windows.Forms.Label
    Friend WithEvents Status_Label As System.Windows.Forms.Label

End Class
