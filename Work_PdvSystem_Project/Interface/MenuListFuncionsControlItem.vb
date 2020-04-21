Public Class MenuListFuncionsControlItem

    Private Sub MenuItemListControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Transparent
        Me.Dock = DockStyle.Top
        ' Me.Height = 60
    End Sub

    Public Property FunctionNumber As Integer
        Get
            Return NumberOfFunction_Label.Text
        End Get
        Set(value As Integer)
            NumberOfFunction_Label.Text = value
        End Set
    End Property

    Public Property MenuTitle As String
        Get
            Return MenuTitle_Label.Text
        End Get
        Set(value As String)
            MenuTitle_Label.Text = value
        End Set
    End Property
    Public Property MenuDescription As String
        Get
            Return MenuDescription_Label.Text
        End Get
        Set(value As String)
            MenuDescription_Label.Text = value
        End Set
    End Property
    Public Property MenuIcon As Image
        Get
            Return MenuIcon_PictureBox.Image
        End Get
        Set(value As Image)
            MenuIcon_PictureBox.Image = value
        End Set
    End Property

    Dim VAR_MenuListMode As MenuListModeEnum = MenuListModeEnum.TitleAndDescription
    Public Property MenuListMode As MenuListModeEnum
        Get
            Return VAR_MenuListMode
        End Get
        Set(value As MenuListModeEnum)
            VAR_MenuListMode = value
            Select Case value
                Case MenuListModeEnum.OnlyTitle
                    If VAR_ShowIcon = False Then Me.Height = 36 Else Me.Height = 60
                    MenuTitle_Label.Top = (Panel1.Height - MenuTitle_Label.Height) / 2
                    MenuDescription_Label.Hide()

                Case MenuListModeEnum.TitleAndDescription
                    Me.Height = 60
                    MenuTitle_Label.Top = 9
                    MenuDescription_Label.Show()
            End Select
        End Set
    End Property

    Dim VAR_ShowIcon As Boolean = True
    Public Property ShowIcon As Boolean
        Get
            Return VAR_ShowIcon
        End Get
        Set(value As Boolean)
            VAR_ShowIcon = value
            MenuIcon_PictureBox.Visible = value

            Select Case value

                Case False
                    MenuTitle_Label.Left = 30
                    MenuDescription_Label.Left = 30
                    If VAR_MenuListMode = MenuListModeEnum.OnlyTitle Then Me.Height = 36 Else Me.Height = 60

                Case True
                    Me.Height = 60
                    MenuTitle_Label.Left = 74
                    MenuDescription_Label.Left = 74
            End Select
        End Set
    End Property

    Enum MenuListModeEnum
        OnlyTitle
        TitleAndDescription
    End Enum
End Class
