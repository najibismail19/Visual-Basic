Public Class Form1

    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TextBox1.Text)
        angka2 = Val(TextBox2.Text)
        hasil = angka1 + angka2
        TextBox3.Text = hasil
    End Sub

    Private Sub Kurang_Click(sender As Object, e As EventArgs) Handles Kurang.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TextBox1.Text)
        angka2 = Val(TextBox2.Text)
        hasil = angka1 - angka2
        TextBox3.Text = hasil
    End Sub

    Private Sub Bagi_Click(sender As Object, e As EventArgs) Handles Bagi.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TextBox1.Text)
        angka2 = Val(TextBox2.Text)
        hasil = angka1 / angka2
        TextBox3.Text = hasil
    End Sub

    Private Sub Kali_Click(sender As Object, e As EventArgs) Handles Kali.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TextBox1.Text)
        angka2 = Val(TextBox2.Text)
        hasil = angka1 * angka2
        TextBox3.Text = hasil
    End Sub
End Class
