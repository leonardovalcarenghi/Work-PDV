<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductWithDiscountListItemControl
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Title_Label = New System.Windows.Forms.Label()
        Me.ProductNameWithDiscount_Label = New System.Windows.Forms.Label()
        Me.DiscountValue_Label = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Panel1.Size = New System.Drawing.Size(34, 70)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(612, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Panel2.Size = New System.Drawing.Size(110, 70)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(502, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Panel3.Size = New System.Drawing.Size(110, 70)
        Me.Panel3.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(432, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Panel5.Size = New System.Drawing.Size(70, 70)
        Me.Panel5.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DiscountValue_Label)
        Me.Panel4.Controls.Add(Me.ProductNameWithDiscount_Label)
        Me.Panel4.Controls.Add(Me.Title_Label)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(34, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Panel4.Size = New System.Drawing.Size(398, 70)
        Me.Panel4.TabIndex = 7
        '
        'Title_Label
        '
        Me.Title_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Title_Label.AutoEllipsis = True
        Me.Title_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_Label.Location = New System.Drawing.Point(6, 5)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Size = New System.Drawing.Size(387, 20)
        Me.Title_Label.TabIndex = 0
        Me.Title_Label.Text = "Desconto no Item"
        '
        'ProductNameWithDiscount_Label
        '
        Me.ProductNameWithDiscount_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductNameWithDiscount_Label.AutoEllipsis = True
        Me.ProductNameWithDiscount_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameWithDiscount_Label.Location = New System.Drawing.Point(6, 25)
        Me.ProductNameWithDiscount_Label.Name = "ProductNameWithDiscount_Label"
        Me.ProductNameWithDiscount_Label.Size = New System.Drawing.Size(387, 20)
        Me.ProductNameWithDiscount_Label.TabIndex = 1
        Me.ProductNameWithDiscount_Label.Text = "Meu Produto Registrado Nome de Aqui"
        '
        'DiscountValue_Label
        '
        Me.DiscountValue_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiscountValue_Label.AutoEllipsis = True
        Me.DiscountValue_Label.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DiscountValue_Label.Location = New System.Drawing.Point(6, 45)
        Me.DiscountValue_Label.Name = "DiscountValue_Label"
        Me.DiscountValue_Label.Size = New System.Drawing.Size(387, 20)
        Me.DiscountValue_Label.TabIndex = 2
        Me.DiscountValue_Label.Text = "Valor do desconto: R$ 0,00"
        Me.DiscountValue_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProductWithDiscountListItemControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ProductWithDiscountListItemControl"
        Me.Size = New System.Drawing.Size(722, 70)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ProductNameWithDiscount_Label As System.Windows.Forms.Label
    Friend WithEvents Title_Label As System.Windows.Forms.Label
    Friend WithEvents DiscountValue_Label As System.Windows.Forms.Label

End Class
