<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductListItemControl
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
        Me.ProductName_Label = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NumberOfItem_Label = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TotalItemPrice_Label = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UnitPrice_Label = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.AmoutItems_Label = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductName_Label
        '
        Me.ProductName_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductName_Label.AutoEllipsis = True
        Me.ProductName_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductName_Label.Location = New System.Drawing.Point(6, 5)
        Me.ProductName_Label.Name = "ProductName_Label"
        Me.ProductName_Label.Size = New System.Drawing.Size(385, 20)
        Me.ProductName_Label.TabIndex = 0
        Me.ProductName_Label.Text = "Meu Produto Registrado Nome de Aqui"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.NumberOfItem_Label)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Panel1.Size = New System.Drawing.Size(34, 30)
        Me.Panel1.TabIndex = 1
        '
        'NumberOfItem_Label
        '
        Me.NumberOfItem_Label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumberOfItem_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.NumberOfItem_Label.Location = New System.Drawing.Point(2, 0)
        Me.NumberOfItem_Label.Name = "NumberOfItem_Label"
        Me.NumberOfItem_Label.Size = New System.Drawing.Size(30, 30)
        Me.NumberOfItem_Label.TabIndex = 1
        Me.NumberOfItem_Label.Text = "999"
        Me.NumberOfItem_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TotalItemPrice_Label)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(610, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Panel2.Size = New System.Drawing.Size(110, 30)
        Me.Panel2.TabIndex = 2
        '
        'TotalItemPrice_Label
        '
        Me.TotalItemPrice_Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TotalItemPrice_Label.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalItemPrice_Label.Location = New System.Drawing.Point(5, 5)
        Me.TotalItemPrice_Label.Name = "TotalItemPrice_Label"
        Me.TotalItemPrice_Label.Size = New System.Drawing.Size(100, 20)
        Me.TotalItemPrice_Label.TabIndex = 1
        Me.TotalItemPrice_Label.Text = "R$ 999999,99"
        Me.TotalItemPrice_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.UnitPrice_Label)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(500, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Panel3.Size = New System.Drawing.Size(110, 30)
        Me.Panel3.TabIndex = 3
        '
        'UnitPrice_Label
        '
        Me.UnitPrice_Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UnitPrice_Label.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitPrice_Label.Location = New System.Drawing.Point(5, 5)
        Me.UnitPrice_Label.Name = "UnitPrice_Label"
        Me.UnitPrice_Label.Size = New System.Drawing.Size(100, 20)
        Me.UnitPrice_Label.TabIndex = 1
        Me.UnitPrice_Label.Text = "R$ 999999,99"
        Me.UnitPrice_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ProductName_Label)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(34, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Panel4.Size = New System.Drawing.Size(396, 30)
        Me.Panel4.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.AmoutItems_Label)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(430, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Panel5.Size = New System.Drawing.Size(70, 30)
        Me.Panel5.TabIndex = 5
        '
        'AmoutItems_Label
        '
        Me.AmoutItems_Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AmoutItems_Label.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmoutItems_Label.Location = New System.Drawing.Point(5, 5)
        Me.AmoutItems_Label.Name = "AmoutItems_Label"
        Me.AmoutItems_Label.Size = New System.Drawing.Size(60, 20)
        Me.AmoutItems_Label.TabIndex = 1
        Me.AmoutItems_Label.Text = "999999"
        Me.AmoutItems_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProductListItemControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ProductListItemControl"
        Me.Size = New System.Drawing.Size(720, 30)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProductName_Label As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NumberOfItem_Label As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TotalItemPrice_Label As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UnitPrice_Label As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents AmoutItems_Label As System.Windows.Forms.Label

End Class
