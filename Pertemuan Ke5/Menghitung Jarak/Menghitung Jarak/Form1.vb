Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kecepatan As Double
        Dim waktutempuh As Double
        Dim jarak As Double
        kecepatan = TextBox1.Text
        waktutempuh = TextBox2.Text
        jarak = kecepatan * waktutempuh
        TextBox3.Text = jarak
        ListBox1.Items.Add(jarak)
    End Sub
End Class
