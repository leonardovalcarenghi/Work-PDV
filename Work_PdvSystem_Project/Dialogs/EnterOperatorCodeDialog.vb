Imports System.Windows.Forms

Public Class EnterOperatorCodeDialog

    Private Sub EnterOperatorCodeDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleDialog_Label.Text = Me.Text
        EnterValue_TextBox.Focus() : EnterValue_TextBox.Select()
    End Sub
End Class
