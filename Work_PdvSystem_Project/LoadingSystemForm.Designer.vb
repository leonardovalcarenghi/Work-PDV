<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingSystemForm
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
        Me.components = New System.ComponentModel.Container()
        Me.BordersPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ControlsForm = New System.Windows.Forms.Panel()
        Me.TitleDialogHeader_Panel = New System.Windows.Forms.Panel()
        Me.TitleDialog_Label = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Interface_LoadingGift1 = New Work_PdvSystem_Project.Interface_LoadingGift()
        Me.BorderRight = New Work_PdvSystem_Project.Border()
        Me.BorderLeft = New Work_PdvSystem_Project.Border()
        Me.BorderBottom = New Work_PdvSystem_Project.Border()
        Me.BorderTop = New Work_PdvSystem_Project.Border()
        Me.Timer_Loading = New System.Windows.Forms.Timer(Me.components)
        Me.BordersPanel.SuspendLayout()
        Me.ControlsForm.SuspendLayout()
        Me.TitleDialogHeader_Panel.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.BordersPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Inicializando o sistema do PDV"
        '
        'ControlsForm
        '
        Me.ControlsForm.Controls.Add(Me.Panel2)
        Me.ControlsForm.Controls.Add(Me.TitleDialogHeader_Panel)
        Me.ControlsForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlsForm.Location = New System.Drawing.Point(1, 1)
        Me.ControlsForm.Name = "ControlsForm"
        Me.ControlsForm.Size = New System.Drawing.Size(698, 198)
        Me.ControlsForm.TabIndex = 5
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
        Me.TitleDialog_Label.Text = "Work PDV"
        Me.TitleDialog_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Interface_LoadingGift1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(698, 148)
        Me.Panel2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Por favor, aguarde..."
        '
        'Interface_LoadingGift1
        '
        Me.Interface_LoadingGift1.BackColor = System.Drawing.Color.Transparent
        Me.Interface_LoadingGift1.Location = New System.Drawing.Point(50, 49)
        Me.Interface_LoadingGift1.Name = "Interface_LoadingGift1"
        Me.Interface_LoadingGift1.Size = New System.Drawing.Size(50, 50)
        Me.Interface_LoadingGift1.TabIndex = 7
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
        'Timer_Loading
        '
        Me.Timer_Loading.Interval = 1000
        '
        'LoadingSystemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 200)
        Me.Controls.Add(Me.BordersPanel)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoadingSystemForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Work PDV"
        Me.TopMost = True
        Me.BordersPanel.ResumeLayout(False)
        Me.ControlsForm.ResumeLayout(False)
        Me.TitleDialogHeader_Panel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BordersPanel As System.Windows.Forms.Panel
    Friend WithEvents BorderRight As Work_PdvSystem_Project.Border
    Friend WithEvents BorderLeft As Work_PdvSystem_Project.Border
    Friend WithEvents BorderBottom As Work_PdvSystem_Project.Border
    Friend WithEvents BorderTop As Work_PdvSystem_Project.Border
    Friend WithEvents ControlsForm As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TitleDialogHeader_Panel As System.Windows.Forms.Panel
    Friend WithEvents TitleDialog_Label As System.Windows.Forms.Label
    Friend WithEvents Interface_LoadingGift1 As Work_PdvSystem_Project.Interface_LoadingGift
    Friend WithEvents Timer_Loading As System.Windows.Forms.Timer

End Class
