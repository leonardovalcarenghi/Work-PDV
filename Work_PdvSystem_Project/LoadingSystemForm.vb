Public Class LoadingSystemForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer_Loading.Start()

        Dim scc = Screen.AllScreens()
        Dim a = scc(0).WorkingArea.Left
        Dim b = scc(0).WorkingArea.Top


        '   KeyboardPdvForm.Show()
        KeyboardPdvForm.Left = a : KeyboardPdvForm.Top = b
        KeyboardPdvForm.WindowState = FormWindowState.Maximized
    End Sub

    Dim i As Integer = 0
    Private Sub Timer_Loading_Tick(sender As Object, e As EventArgs) Handles Timer_Loading.Tick
        i += 1
        Select Case i
            Case 4
                PointOfSaleForm.Show()

            Case 8
                Me.Hide()
                Timer_Loading.Stop()
        End Select
    End Sub
End Class
