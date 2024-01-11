Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim i As Double
        Static lctr As Integer
        For i = 1 To 100
            Label1.Text = ProgressBar1.Value
        Next
        If lctr <= 100 Then
            ProgressBar1.Value = lctr
            lctr = lctr + 1
        Else
            MenghitungJarak.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
