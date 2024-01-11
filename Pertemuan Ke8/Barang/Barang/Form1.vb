Public Class Form1
    Sub Bersih()
        TxtKodeBrg.Text = ""
        TxtNamaBrg.Text = ""
        TxtSatuan.Text = ""
        TxtHrgSatuan.Text = ""
        TxtJumlah.Text = ""
        TxtTotalHarga.Text = ""
        TxtKodeBrg.Focus()
        TxtTotalHarga.Enabled = False
    End Sub
    Sub CekDataKosong()
        If TxtKodeBrg.Text = "" Then
            MessageBox.Show("Kode Barang harus diisi", "Konfirmasi",
           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtKodeBrg.Focus()
        ElseIf TxtNamaBrg.Text = "" Then
            MessageBox.Show("Nama Barang harus diisi", "Konfirmasi",
           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNamaBrg.Focus()
        ElseIf TxtSatuan.Text = "" Then
            MessageBox.Show("Satuan Barang harus diisi", "Konfirmasi",
           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtSatuan.Focus()
        ElseIf TxtHrgSatuan.Text = "" Then
            MessageBox.Show("Harga Barang harus diisi", "Konfirmasi",
           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtHrgSatuan.Focus()
        ElseIf TxtJumlah.Text = "" Then
            MessageBox.Show("Jumlah Barang harus diisi", "Konfirmasi",
           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtJumlah.Focus()
        Else
            Call Hitung()
        End If
    End Sub

    Private Function Hitung()
        Dim Harga, Jumlah, Total As Integer
        Harga = TxtHrgSatuan.Text
        Jumlah = TxtJumlah.Text
        Total = Harga * Jumlah
        TxtTotalHarga.Text = Total
        Return Total
    End Function
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TxtHrgSatuan.TextChanged

    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TxtSatuan.TextChanged

    End Sub
    Private Sub TxtNama_TextChanged(sender As Object, e As EventArgs) Handles TxtNamaBrg.TextChanged

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Bersih()
    End Sub
    Private Sub txtNIM_TextChanged(sender As Object, e As EventArgs) Handles TxtKodeBrg.TextChanged

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Call Bersih()
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        Call CekDataKosong()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim Tutup As String
        Tutup = MessageBox.Show("Yakin tutup form ini ?", "Konfirmasi",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class
