Public Class Form1
    Private Sub Hitung()
        Dim angka1 As Double
        Dim angka2 As Double
        Dim hasil As Double

        If Double.TryParse(TextBox1.Text, angka1) AndAlso Double.TryParse(TextBox2.Text, angka2) Then
            If RadioButton1.Checked Then
                ' Akar Kuadrat
                hasil = Math.Sqrt(angka1)
            ElseIf RadioButton2.Checked Then
                ' Pangkat
                hasil = Math.Pow(angka1, angka2)
            ElseIf RadioButton3.Checked Then
                ' Pembagian
                If angka2 <> 0 Then
                    hasil = angka1 / angka2
                Else
                    MessageBox.Show("Error: Pembagian oleh nol tidak diizinkan.")
                    Exit Sub
                End If
            ElseIf RadioButton4.Checked Then
                ' Penjumlahan
                hasil = angka1 + angka2
            ElseIf RadioButton5.Checked Then
                ' Pengurangan
                hasil = angka1 - angka2
            ElseIf RadioButton6.Checked Then
                ' Perkalian
                hasil = angka1 * angka2
            Else
                MessageBox.Show("Pilih operasi terlebih dahulu.")
                Exit Sub
            End If

            TextBox3.Text = hasil.ToString()
        Else
            MessageBox.Show("Masukkan angka yang valid.")
        End If
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hitung()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
