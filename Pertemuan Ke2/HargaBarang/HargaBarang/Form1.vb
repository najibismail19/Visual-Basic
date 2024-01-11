Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtnama.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
        txttotal.Text = ""
        txtdiskon.Text = ""
        txtbayar.Text = ""
        txtnama.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim harga, jumlah As Integer
        Dim total, diskon, bayar As Double
        'Input Harga dan Jumlah
        harga = txtharga.Text
        jumlah = txtjumlah.Text
        'Perhitungan Total Harga
        total = harga * jumlah
        'Penentuan diskon 
        diskon = 0.05 * total
        'Perhitungan total Bayar
        bayar = total - diskon
        'Set keluaran total Harga, diskon,total bayar, dan bonus
        txttotal.Text = total
        txtdiskon.Text = diskon
        txtbayar.Text = bayar
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
