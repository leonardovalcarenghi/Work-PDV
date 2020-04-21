Public Class InformationsPointOfSaleControlItem

    Private Sub InformationsPointOfSaleControlItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Top
        Me.BackColor = Color.Transparent
    End Sub


    Public VAR_Mode As ModeEnum
    Public Property Mode As ModeEnum
        Get
            Return VAR_Mode
        End Get

        Set(value As ModeEnum)

            Select Case value
                Case ModeEnum.StringText : Text_Label.Text = VAR_Info_Text

                Case ModeEnum.Money : Text_Label.Text = VAR_Info_Money.ToString("R$ #,###.00")

            End Select

        End Set
    End Property

    Public Property Info_Title As String
        Get
            Return Title_Label.Text
        End Get
        Set(value As String)
            Title_Label.Text = value
        End Set
    End Property

    Dim VAR_Info_Text As String = "text"
    Public Property Info_Text As String
        Get
            Return VAR_Info_Text
        End Get
        Set(value As String)
            VAR_Info_Text = value
            Select Case VAR_Mode : Case ModeEnum.StringText : Text_Label.Text = VAR_Info_Text : End Select
        End Set
    End Property

    Dim VAR_Info_Money As Decimal = 0
    Public Property Info_Money As Decimal
        Get
            Return VAR_Info_Money
        End Get
        Set(value As Decimal)
            VAR_Info_Money = value
            Select Case VAR_Mode : Case ModeEnum.Money : Text_Label.Text = VAR_Info_Money.ToString("R$ #,###.00") : End Select
        End Set
    End Property








    Enum ModeEnum
        StringText
        Money
    End Enum
End Class
