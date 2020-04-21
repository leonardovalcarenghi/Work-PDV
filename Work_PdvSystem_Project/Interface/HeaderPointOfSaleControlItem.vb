Public Class HeaderPointOfSaleControlItem

    Private Sub HeaderPointOfSaleControlItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Me.BackColor = Color.Transparent
        Me.Dock = DockStyle.Top
    End Sub


    Public Property H_Title As String
        Get
            Return Title_Label.Text
        End Get
        Set(value As String)
            Title_Label.Text = value
        End Set
    End Property
    Public Property H_Text As String
        Get
            Return Text_Label.Text
        End Get
        Set(value As String)
            Text_Label.Text = value
        End Set
    End Property

    Dim VAR_H_Price As Decimal = 0
    Public Property H_Price As Decimal
        Get
            Return VAR_H_Price
        End Get
        Set(value As Decimal)
            VAR_H_Price = value
            Price_Label.Text = value.ToString("R$ #,###.00")
        End Set
    End Property

    Dim VAR_ModeView As ModeViewEnum = ModeViewEnum.TitleAndText
    Public Property ModeView As ModeViewEnum
        Get
            Return VAR_ModeView
        End Get
        Set(value As ModeViewEnum)
            VAR_ModeView = value
            Select Case value
                Case ModeViewEnum.TitleAndText
                    Text_Label.TextAlign = ContentAlignment.MiddleLeft
                    TitleAndText_Panel.Padding = New Padding(30, 30, 0, 30)
                    Title_Label.Show()

                Case ModeViewEnum.OnlyText
                    Text_Label.TextAlign = ContentAlignment.MiddleCenter
                    TitleAndText_Panel.Padding = New Padding(0, 30, 0, 30)
                    Title_Label.Hide()

            End Select
        End Set
    End Property

    Public Property ShowPrice As Boolean
        Get
            Return Price_Panel.Visible
        End Get
        Set(value As Boolean)
            Price_Panel.Visible = value
        End Set
    End Property


    Enum ModeViewEnum
        TitleAndText
        OnlyText
    End Enum
End Class
