Imports System.Windows.Forms

Public Class Functions_POS
    Private Sub Functions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = FunctionsPdvDialog.Location
        PointOfSaleForm.HeaderPointOfSaleControlItem1.H_Text = "Menu POS"
        TitleDialog_Label.Select() : TitleDialog_Label.Focus()
    End Sub

    Private Sub KeyNuberFunction_KeyDown(sender As Object, e As KeyEventArgs) Handles TitleDialog_Label.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.SuppressKeyPress = True
                Me.DialogResult = Windows.Forms.DialogResult.Cancel : Me.Close()

            Case Keys.NumPad1
                e.SuppressKeyPress = True

            Case Keys.NumPad2
                e.SuppressKeyPress = True

            Case Keys.NumPad3
                e.SuppressKeyPress = True

            Case Keys.NumPad4
                e.SuppressKeyPress = True

            Case Keys.NumPad5
                e.SuppressKeyPress = True

            Case Keys.NumPad6
                e.SuppressKeyPress = True

            Case Keys.NumPad7
                e.SuppressKeyPress = True

            Case Keys.NumPad8
                e.SuppressKeyPress = True

            Case Keys.NumPad9
                e.SuppressKeyPress = True

            Case Else
                ShowMessage("Opção Inválida!")
        End Select
    End Sub

End Class
