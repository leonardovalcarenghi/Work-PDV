Module ModuleSoftware

    Public Sub ShowMessage(ByVal msg As String)
        Dim MsgPDV As New MessagePdv
        MsgPDV = New MessagePdv
        MsgPDV.MessageText_Label.Text = msg
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        MsgPDV.ShowDialog()
    End Sub

End Module
