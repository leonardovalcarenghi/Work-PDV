Public Class Interface_LoadingGift

    Dim i As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i += 1
        Select Case i
            Case 1 : PictureBox1.Image = My.Resources.Loading_1
            Case 2 : PictureBox1.Image = My.Resources.Loading_2
            Case 3 : PictureBox1.Image = My.Resources.Loading_3
            Case 4 : PictureBox1.Image = My.Resources.Loading_4
            Case 5 : PictureBox1.Image = My.Resources.Loading_5
            Case 6 : PictureBox1.Image = My.Resources.Loading_6
            Case 7 : PictureBox1.Image = My.Resources.Loading_7
            Case 8 : PictureBox1.Image = My.Resources.Loading_8 : i = 0
        End Select
    End Sub
End Class
