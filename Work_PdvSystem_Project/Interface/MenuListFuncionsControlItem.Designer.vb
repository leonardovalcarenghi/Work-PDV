<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuListFuncionsControlItem
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
        Me.MenuDescription_Label = New System.Windows.Forms.Label()
        Me.MenuTitle_Label = New System.Windows.Forms.Label()
        Me.MenuIcon_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NumberOfFunction_Label = New System.Windows.Forms.Label()
        Me.Border1 = New Work_PdvSystem_Project.Border()
        Me.Border2 = New Work_PdvSystem_Project.Border()
        CType(Me.MenuIcon_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuDescription_Label
        '
        Me.MenuDescription_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MenuDescription_Label.AutoSize = True
        Me.MenuDescription_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuDescription_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.MenuDescription_Label.Location = New System.Drawing.Point(74, 29)
        Me.MenuDescription_Label.Name = "MenuDescription_Label"
        Me.MenuDescription_Label.Size = New System.Drawing.Size(66, 15)
        Me.MenuDescription_Label.TabIndex = 11
        Me.MenuDescription_Label.Text = "Description"
        Me.MenuDescription_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuTitle_Label
        '
        Me.MenuTitle_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MenuTitle_Label.AutoSize = True
        Me.MenuTitle_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuTitle_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.MenuTitle_Label.Location = New System.Drawing.Point(74, 9)
        Me.MenuTitle_Label.Name = "MenuTitle_Label"
        Me.MenuTitle_Label.Size = New System.Drawing.Size(33, 17)
        Me.MenuTitle_Label.TabIndex = 10
        Me.MenuTitle_Label.Text = "Title"
        Me.MenuTitle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuIcon_PictureBox
        '
        Me.MenuIcon_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MenuIcon_PictureBox.Location = New System.Drawing.Point(30, 6)
        Me.MenuIcon_PictureBox.Name = "MenuIcon_PictureBox"
        Me.MenuIcon_PictureBox.Size = New System.Drawing.Size(40, 40)
        Me.MenuIcon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MenuIcon_PictureBox.TabIndex = 9
        Me.MenuIcon_PictureBox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Border2)
        Me.Panel1.Controls.Add(Me.Border1)
        Me.Panel1.Controls.Add(Me.MenuDescription_Label)
        Me.Panel1.Controls.Add(Me.MenuTitle_Label)
        Me.Panel1.Controls.Add(Me.MenuIcon_PictureBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(899, 52)
        Me.Panel1.TabIndex = 13
        '
        'NumberOfFunction_Label
        '
        Me.NumberOfFunction_Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.NumberOfFunction_Label.Dock = System.Windows.Forms.DockStyle.Right
        Me.NumberOfFunction_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfFunction_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.NumberOfFunction_Label.Location = New System.Drawing.Point(879, 4)
        Me.NumberOfFunction_Label.Name = "NumberOfFunction_Label"
        Me.NumberOfFunction_Label.Size = New System.Drawing.Size(20, 52)
        Me.NumberOfFunction_Label.TabIndex = 14
        Me.NumberOfFunction_Label.Text = "1"
        Me.NumberOfFunction_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Border1
        '
        Me.Border1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Border1.BorderPosition = Work_PdvSystem_Project.Border.BorderPositionEnum.Top
        Me.Border1.BorderSize = 1
        Me.Border1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Border1.Location = New System.Drawing.Point(0, 0)
        Me.Border1.Name = "Border1"
        Me.Border1.Size = New System.Drawing.Size(899, 1)
        Me.Border1.TabIndex = 12
        '
        'Border2
        '
        Me.Border2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Border2.BorderPosition = Work_PdvSystem_Project.Border.BorderPositionEnum.Top
        Me.Border2.BorderSize = 1
        Me.Border2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Border2.Location = New System.Drawing.Point(0, 51)
        Me.Border2.Name = "Border2"
        Me.Border2.Size = New System.Drawing.Size(899, 1)
        Me.Border2.TabIndex = 13
        '
        'MenuListFuncionsControlItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.NumberOfFunction_Label)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MenuListFuncionsControlItem"
        Me.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Size = New System.Drawing.Size(899, 60)
        CType(Me.MenuIcon_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuDescription_Label As System.Windows.Forms.Label
    Friend WithEvents MenuTitle_Label As System.Windows.Forms.Label
    Friend WithEvents MenuIcon_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NumberOfFunction_Label As System.Windows.Forms.Label
    Friend WithEvents Border2 As Work_PdvSystem_Project.Border
    Friend WithEvents Border1 As Work_PdvSystem_Project.Border

End Class
