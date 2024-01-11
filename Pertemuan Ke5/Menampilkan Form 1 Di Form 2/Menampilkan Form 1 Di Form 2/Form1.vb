Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TampilanForm2.TextBox1.Text = (Me.TextBox1.Text)
        TampilanForm2.TextBox2.Text = (Me.TextBox2.Text)
        TampilanForm2.Show()
    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub
End Class
