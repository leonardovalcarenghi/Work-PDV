Imports System.Windows.Forms

Public Class FunctionsPdvDialog

    Private Sub Functions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top += 30
        TitleDialog_Label.Select() : TitleDialog_Label.Focus()
    End Sub

    Private Sub KeyNuberFunction_KeyDown(sender As Object, e As KeyEventArgs) Handles TitleDialog_Label.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.SuppressKeyPress = True
                Me.DialogResult = Windows.Forms.DialogResult.Cancel : Me.Close()

            Case Keys.NumPad1 'Parâmentros do PDV
                e.SuppressKeyPress = True
                If Functions_ParâmetrosDoPdv.ShowDialog() = Windows.Forms.DialogResult.OK Then Me.Close()

            Case Keys.NumPad2 'POS
                e.SuppressKeyPress = True
                If Functions_POS.ShowDialog() = Windows.Forms.DialogResult.OK Then Me.Close()

            Case Keys.NumPad3 'Rotinas Diarías
                e.SuppressKeyPress = True
                If Functions_RotinasDiárias.ShowDialog() = Windows.Forms.DialogResult.OK Then Me.Close()

            Case Keys.NumPad4 'NFCe
                e.SuppressKeyPress = True
                If Functions_NFCe.ShowDialog() = Windows.Forms.DialogResult.OK Then Me.Close()

            Case Keys.NumPad5
                e.SuppressKeyPress = True

            Case Keys.NumPad6
                e.SuppressKeyPress = True

            Case Keys.NumPad7
                e.SuppressKeyPress = True

            Case Keys.NumPad8
                e.SuppressKeyPress = True

            Case Keys.NumPad9 'Mais Funções...
                e.SuppressKeyPress = True
                If Functions_MoreFunctions.ShowDialog() = Windows.Forms.DialogResult.OK Then Me.Close()

            Case Else
                ShowMessage("Opção Inválida!")
        End Select
    End Sub

    Private Sub FunctionsPdvDialog_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        PointOfSaleForm.HeaderPointOfSaleControlItem1.H_Text = "Funções Gerais"
    End Sub
End Class
