Public Class PointOfSaleForm

    Private Sub PointOfSaleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RenderBmp = My.Resources.Wallpaper_BackgroundPdvScreen
    End Sub

    Private Sub KeyLink_OpenFunctions_Click(sender As Object, e As EventArgs) Handles KeyLink_OpenFunctions.Click
        HeaderPointOfSaleControlItem1.H_Text = "Funções Gerais" : HeaderPointOfSaleControlItem1.ModeView = HeaderPointOfSaleControlItem.ModeViewEnum.OnlyText
        FunctionsPdvDialog.ShowDialog()
        HeaderPointOfSaleControlItem1.H_Text = ""
        HeaderPointOfSaleControlItem1.ModeView = HeaderPointOfSaleControlItem.ModeViewEnum.TitleAndText
    End Sub

#Region "Background"
    Dim RenderBmp
    Public Overrides Property BackgroundImage() As System.Drawing.Image
        Get
            Return Me.RenderBmp
        End Get
        Set(ByVal value As System.Drawing.Image)
            If Not value Is Nothing Then
                Me.RenderBmp = New Bitmap(Me.Width, Me.Height, _
                Imaging.PixelFormat.Format32bppPArgb)
                Dim g As Graphics = Graphics.FromImage(Me.RenderBmp)
                g.InterpolationMode = Drawing.Drawing2D.InterpolationMode.High
                g.DrawImage(value, New Rectangle(0, 0, Me.RenderBmp.Width, _
                Me.RenderBmp.Height))
                g.Dispose()
            End If
        End Set
    End Property

    Protected Overrides ReadOnly Property CreateParams() As Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
#End Region
End Class