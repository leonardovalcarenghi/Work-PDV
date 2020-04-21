<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeaderPointOfSaleControlItem
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
        Me.Price_Panel = New System.Windows.Forms.Panel()
        Me.Price_Label = New System.Windows.Forms.Label()
        Me.TitleAndText_Panel = New System.Windows.Forms.Panel()
        Me.Title_Label = New System.Windows.Forms.Label()
        Me.Text_Label = New System.Windows.Forms.Label()
        Me.Price_Panel.SuspendLayout()
        Me.TitleAndText_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Price_Panel
        '
        Me.Price_Panel.Controls.Add(Me.Price_Label)
        Me.Price_Panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.Price_Panel.Location = New System.Drawing.Point(770, 0)
        Me.Price_Panel.Name = "Price_Panel"
        Me.Price_Panel.Size = New System.Drawing.Size(230, 120)
        Me.Price_Panel.TabIndex = 0
        '
        'Price_Label
        '
        Me.Price_Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Price_Label.BackColor = System.Drawing.Color.Transparent
        Me.Price_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price_Label.Location = New System.Drawing.Point(15, 20)
        Me.Price_Label.Name = "Price_Label"
        Me.Price_Label.Size = New System.Drawing.Size(200, 80)
        Me.Price_Label.TabIndex = 2
        Me.Price_Label.Text = "R$ 9.999,99"
        Me.Price_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TitleAndText_Panel
        '
        Me.TitleAndText_Panel.Controls.Add(Me.Title_Label)
        Me.TitleAndText_Panel.Controls.Add(Me.Text_Label)
        Me.TitleAndText_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleAndText_Panel.Location = New System.Drawing.Point(0, 0)
        Me.TitleAndText_Panel.Name = "TitleAndText_Panel"
        Me.TitleAndText_Panel.Padding = New System.Windows.Forms.Padding(30, 30, 0, 30)
        Me.TitleAndText_Panel.Size = New System.Drawing.Size(770, 120)
        Me.TitleAndText_Panel.TabIndex = 8
        '
        'Title_Label
        '
        Me.Title_Label.AutoSize = True
        Me.Title_Label.BackColor = System.Drawing.Color.Transparent
        Me.Title_Label.Font = New System.Drawing.Font("Segoe UI Light", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Title_Label.Location = New System.Drawing.Point(37, 13)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Size = New System.Drawing.Size(138, 20)
        Me.Title_Label.TabIndex = 9
        Me.Title_Label.Text = "Descrição do Item"
        '
        'Text_Label
        '
        Me.Text_Label.AutoEllipsis = True
        Me.Text_Label.BackColor = System.Drawing.Color.Transparent
        Me.Text_Label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Text_Label.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Label.Location = New System.Drawing.Point(30, 30)
        Me.Text_Label.Name = "Text_Label"
        Me.Text_Label.Size = New System.Drawing.Size(740, 60)
        Me.Text_Label.TabIndex = 8
        Me.Text_Label.Text = "ARROZ NAMORADO 1KG TP1"
        Me.Text_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HeaderPointOfSaleControlItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.TitleAndText_Panel)
        Me.Controls.Add(Me.Price_Panel)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "HeaderPointOfSaleControlItem"
        Me.Size = New System.Drawing.Size(1000, 120)
        Me.Price_Panel.ResumeLayout(False)
        Me.TitleAndText_Panel.ResumeLayout(False)
        Me.TitleAndText_Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Price_Panel As System.Windows.Forms.Panel
    Friend WithEvents Price_Label As System.Windows.Forms.Label
    Friend WithEvents TitleAndText_Panel As System.Windows.Forms.Panel
    Friend WithEvents Text_Label As System.Windows.Forms.Label
    Friend WithEvents Title_Label As System.Windows.Forms.Label

End Class
