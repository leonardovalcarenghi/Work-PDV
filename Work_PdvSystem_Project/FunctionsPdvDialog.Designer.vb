﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FunctionsPdvDialog
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CloseLabel = New System.Windows.Forms.Label()
        Me.BordersPanel = New System.Windows.Forms.Panel()
        Me.ControlsForm = New System.Windows.Forms.Panel()
        Me.TitleDialogHeader_Panel = New System.Windows.Forms.Panel()
        Me.TitleDialog_Label = New System.Windows.Forms.Label()
        Me.MenuListFuncionsControlItem4 = New Work_PdvSystem_Project.MenuListFuncionsControlItem()
        Me.MenuListFuncionsControlItem5 = New Work_PdvSystem_Project.MenuListFuncionsControlItem()
        Me.MenuListFuncionsControlItem3 = New Work_PdvSystem_Project.MenuListFuncionsControlItem()
        Me.MenuListFuncionsControlItem1 = New Work_PdvSystem_Project.MenuListFuncionsControlItem()
        Me.MenuListFuncionsControlItem2 = New Work_PdvSystem_Project.MenuListFuncionsControlItem()
        Me.BorderRight = New Work_PdvSystem_Project.Border()
        Me.BorderLeft = New Work_PdvSystem_Project.Border()
        Me.BorderBottom = New Work_PdvSystem_Project.Border()
        Me.BorderTop = New Work_PdvSystem_Project.Border()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.BordersPanel.SuspendLayout()
        Me.ControlsForm.SuspendLayout()
        Me.TitleDialogHeader_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MenuListFuncionsControlItem4)
        Me.Panel2.Controls.Add(Me.MenuListFuncionsControlItem5)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.MenuListFuncionsControlItem3)
        Me.Panel2.Controls.Add(Me.MenuListFuncionsControlItem1)
        Me.Panel2.Controls.Add(Me.MenuListFuncionsControlItem2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(418, 578)
        Me.Panel2.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CloseLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 538)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 40)
        Me.Panel1.TabIndex = 6
        '
        'CloseLabel
        '
        Me.CloseLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CloseLabel.AutoSize = True
        Me.CloseLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CloseLabel.Location = New System.Drawing.Point(13, 13)
        Me.CloseLabel.Name = "CloseLabel"
        Me.CloseLabel.Size = New System.Drawing.Size(145, 15)
        Me.CloseLabel.TabIndex = 8
        Me.CloseLabel.Text = "Pressione 'Esc' para fechar."
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
        Me.BordersPanel.Size = New System.Drawing.Size(420, 630)
        Me.BordersPanel.TabIndex = 1
        '
        'ControlsForm
        '
        Me.ControlsForm.Controls.Add(Me.Panel2)
        Me.ControlsForm.Controls.Add(Me.TitleDialogHeader_Panel)
        Me.ControlsForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlsForm.Location = New System.Drawing.Point(1, 1)
        Me.ControlsForm.Name = "ControlsForm"
        Me.ControlsForm.Size = New System.Drawing.Size(418, 628)
        Me.ControlsForm.TabIndex = 5
        '
        'TitleDialogHeader_Panel
        '
        Me.TitleDialogHeader_Panel.Controls.Add(Me.TitleDialog_Label)
        Me.TitleDialogHeader_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleDialogHeader_Panel.Location = New System.Drawing.Point(0, 0)
        Me.TitleDialogHeader_Panel.Name = "TitleDialogHeader_Panel"
        Me.TitleDialogHeader_Panel.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.TitleDialogHeader_Panel.Size = New System.Drawing.Size(418, 50)
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
        Me.TitleDialog_Label.Size = New System.Drawing.Size(418, 30)
        Me.TitleDialog_Label.TabIndex = 5
        Me.TitleDialog_Label.Text = "Funções Gerais"
        Me.TitleDialog_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuListFuncionsControlItem4
        '
        Me.MenuListFuncionsControlItem4.BackColor = System.Drawing.Color.Transparent
        Me.MenuListFuncionsControlItem4.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuListFuncionsControlItem4.FunctionNumber = 9
        Me.MenuListFuncionsControlItem4.Location = New System.Drawing.Point(0, 240)
        Me.MenuListFuncionsControlItem4.MenuDescription = "text"
        Me.MenuListFuncionsControlItem4.MenuIcon = Nothing
        Me.MenuListFuncionsControlItem4.MenuListMode = Work_PdvSystem_Project.MenuListFuncionsControlItem.MenuListModeEnum.OnlyTitle
        Me.MenuListFuncionsControlItem4.MenuTitle = "Mais funções..."
        Me.MenuListFuncionsControlItem4.Name = "MenuListFuncionsControlItem4"
        Me.MenuListFuncionsControlItem4.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.MenuListFuncionsControlItem4.ShowIcon = False
        Me.MenuListFuncionsControlItem4.Size = New System.Drawing.Size(418, 36)
        Me.MenuListFuncionsControlItem4.TabIndex = 5
        '
        'MenuListFuncionsControlItem5
        '
        Me.MenuListFuncionsControlItem5.BackColor = System.Drawing.Color.Transparent
        Me.MenuListFuncionsControlItem5.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuListFuncionsControlItem5.FunctionNumber = 4
        Me.MenuListFuncionsControlItem5.Location = New System.Drawing.Point(0, 180)
        Me.MenuListFuncionsControlItem5.MenuDescription = "Acesar menu NFC-e"
        Me.MenuListFuncionsControlItem5.MenuIcon = Global.Work_PdvSystem_Project.My.Resources.Resources.Icon_Functions_NFCe_32x32
        Me.MenuListFuncionsControlItem5.MenuListMode = Work_PdvSystem_Project.MenuListFuncionsControlItem.MenuListModeEnum.TitleAndDescription
        Me.MenuListFuncionsControlItem5.MenuTitle = "NFC-e"
        Me.MenuListFuncionsControlItem5.Name = "MenuListFuncionsControlItem5"
        Me.MenuListFuncionsControlItem5.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.MenuListFuncionsControlItem5.ShowIcon = True
        Me.MenuListFuncionsControlItem5.Size = New System.Drawing.Size(418, 60)
        Me.MenuListFuncionsControlItem5.TabIndex = 7
        '
        'MenuListFuncionsControlItem3
        '
        Me.MenuListFuncionsControlItem3.BackColor = System.Drawing.Color.Transparent
        Me.MenuListFuncionsControlItem3.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuListFuncionsControlItem3.FunctionNumber = 3
        Me.MenuListFuncionsControlItem3.Location = New System.Drawing.Point(0, 120)
        Me.MenuListFuncionsControlItem3.MenuDescription = "Acessar funções diárias do caixa"
        Me.MenuListFuncionsControlItem3.MenuIcon = Global.Work_PdvSystem_Project.My.Resources.Resources.Icon_Functions_PDV2_32x32
        Me.MenuListFuncionsControlItem3.MenuListMode = Work_PdvSystem_Project.MenuListFuncionsControlItem.MenuListModeEnum.TitleAndDescription
        Me.MenuListFuncionsControlItem3.MenuTitle = "Rotinas Diárias"
        Me.MenuListFuncionsControlItem3.Name = "MenuListFuncionsControlItem3"
        Me.MenuListFuncionsControlItem3.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.MenuListFuncionsControlItem3.ShowIcon = True
        Me.MenuListFuncionsControlItem3.Size = New System.Drawing.Size(418, 60)
        Me.MenuListFuncionsControlItem3.TabIndex = 4
        '
        'MenuListFuncionsControlItem1
        '
        Me.MenuListFuncionsControlItem1.BackColor = System.Drawing.Color.Transparent
        Me.MenuListFuncionsControlItem1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuListFuncionsControlItem1.FunctionNumber = 2
        Me.MenuListFuncionsControlItem1.Location = New System.Drawing.Point(0, 60)
        Me.MenuListFuncionsControlItem1.MenuDescription = "Consultar dados lançados dos cartões em Point of Sale"
        Me.MenuListFuncionsControlItem1.MenuIcon = Global.Work_PdvSystem_Project.My.Resources.Resources.Icon_Functions_POS_32x32
        Me.MenuListFuncionsControlItem1.MenuListMode = Work_PdvSystem_Project.MenuListFuncionsControlItem.MenuListModeEnum.TitleAndDescription
        Me.MenuListFuncionsControlItem1.MenuTitle = "POS"
        Me.MenuListFuncionsControlItem1.Name = "MenuListFuncionsControlItem1"
        Me.MenuListFuncionsControlItem1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.MenuListFuncionsControlItem1.ShowIcon = True
        Me.MenuListFuncionsControlItem1.Size = New System.Drawing.Size(418, 60)
        Me.MenuListFuncionsControlItem1.TabIndex = 3
        '
        'MenuListFuncionsControlItem2
        '
        Me.MenuListFuncionsControlItem2.BackColor = System.Drawing.Color.Transparent
        Me.MenuListFuncionsControlItem2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuListFuncionsControlItem2.FunctionNumber = 1
        Me.MenuListFuncionsControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.MenuListFuncionsControlItem2.MenuDescription = "Funções Administrativas do Caixa"
        Me.MenuListFuncionsControlItem2.MenuIcon = Global.Work_PdvSystem_Project.My.Resources.Resources.Icon_Functions_PDV_32x32
        Me.MenuListFuncionsControlItem2.MenuListMode = Work_PdvSystem_Project.MenuListFuncionsControlItem.MenuListModeEnum.TitleAndDescription
        Me.MenuListFuncionsControlItem2.MenuTitle = "Parâmetros do PDV"
        Me.MenuListFuncionsControlItem2.Name = "MenuListFuncionsControlItem2"
        Me.MenuListFuncionsControlItem2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.MenuListFuncionsControlItem2.ShowIcon = True
        Me.MenuListFuncionsControlItem2.Size = New System.Drawing.Size(418, 60)
        Me.MenuListFuncionsControlItem2.TabIndex = 2
        '
        'BorderRight
        '
        Me.BorderRight.BackColor = System.Drawing.Color.MidnightBlue
        Me.BorderRight.BorderPosition = Work_PdvSystem_Project.Border.BorderPositionEnum.Right
        Me.BorderRight.BorderSize = 1
        Me.BorderRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.BorderRight.Location = New System.Drawing.Point(419, 1)
        Me.BorderRight.Name = "BorderRight"
        Me.BorderRight.Size = New System.Drawing.Size(1, 628)
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
        Me.BorderLeft.Size = New System.Drawing.Size(1, 628)
        Me.BorderLeft.TabIndex = 2
        '
        'BorderBottom
        '
        Me.BorderBottom.BackColor = System.Drawing.Color.MidnightBlue
        Me.BorderBottom.BorderPosition = Work_PdvSystem_Project.Border.BorderPositionEnum.Bottom
        Me.BorderBottom.BorderSize = 1
        Me.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BorderBottom.Location = New System.Drawing.Point(0, 629)
        Me.BorderBottom.Name = "BorderBottom"
        Me.BorderBottom.Size = New System.Drawing.Size(420, 1)
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
        Me.BorderTop.Size = New System.Drawing.Size(420, 1)
        Me.BorderTop.TabIndex = 0
        '
        'FunctionsPdvDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(420, 630)
        Me.Controls.Add(Me.BordersPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FunctionsPdvDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funções Gerais"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BordersPanel.ResumeLayout(False)
        Me.ControlsForm.ResumeLayout(False)
        Me.TitleDialogHeader_Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BordersPanel As System.Windows.Forms.Panel
    Friend WithEvents ControlsForm As System.Windows.Forms.Panel
    Friend WithEvents TitleDialogHeader_Panel As System.Windows.Forms.Panel
    Friend WithEvents TitleDialog_Label As System.Windows.Forms.Label
    Friend WithEvents BorderRight As Work_PdvSystem_Project.Border
    Friend WithEvents BorderLeft As Work_PdvSystem_Project.Border
    Friend WithEvents BorderBottom As Work_PdvSystem_Project.Border
    Friend WithEvents BorderTop As Work_PdvSystem_Project.Border
    Friend WithEvents MenuListFuncionsControlItem2 As Work_PdvSystem_Project.MenuListFuncionsControlItem
    Friend WithEvents MenuListFuncionsControlItem1 As Work_PdvSystem_Project.MenuListFuncionsControlItem
    Friend WithEvents MenuListFuncionsControlItem3 As Work_PdvSystem_Project.MenuListFuncionsControlItem
    Friend WithEvents MenuListFuncionsControlItem4 As Work_PdvSystem_Project.MenuListFuncionsControlItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CloseLabel As System.Windows.Forms.Label
    Friend WithEvents MenuListFuncionsControlItem5 As Work_PdvSystem_Project.MenuListFuncionsControlItem

End Class
