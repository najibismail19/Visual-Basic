Public Class MenghitungJarak

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        If ProgressBar1.Value = 100 Then
            Label1.Text = ProgressBar1.Value
            Timer1.Enabled = False
            Me.Hide()
            Me.Show() ' Use Me instead of MenghitungJarak
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

End Class
