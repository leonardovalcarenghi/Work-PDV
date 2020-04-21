Imports System.Windows.Forms

Public Class MessagePdv

    Private Sub MessagePdv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = 0
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        CloseLabel.Select() : CloseLabel.Focus()
    End Sub

    Private Sub CloseLabel_KeyDown(sender As Object, e As KeyEventArgs) Handles CloseLabel.KeyDown
        If e.KeyCode = Keys.Escape Then
            e.SuppressKeyPress = True
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class
