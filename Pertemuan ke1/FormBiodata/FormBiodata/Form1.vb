Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btntampilkan_Click(sender As Object, e As EventArgs) Handles btntampilkan.Click
        MessageBox.Show(TextBox1.Text & vbCrLf & TextBox2.Text & vbCrLf &
 ComboBox1.Text & vbCrLf & ComboBox2.Text, "Hasil Pengisian",
MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
