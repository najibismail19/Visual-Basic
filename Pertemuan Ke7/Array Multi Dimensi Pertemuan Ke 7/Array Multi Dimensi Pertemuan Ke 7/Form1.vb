Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr(4, 1) As String
        arr(0, 0) = "NIM"
        arr(0, 1) = "NAMA"
        arr(1, 0) = "JENIS KELAMIN"
        arr(1, 1) = "PRODI"
        arr(2, 0) = "LAKI-LAKI"
        arr(2, 1) = "PEREMPUAN"
        arr(3, 0) = "SI"
        arr(3, 1) = "TI"
        arr(4, 0) = "RPL"
        arr(4, 1) = "SIA"
        ListView1.GridLines = True
        ListView1.View = View.Details
        For baris = 0 To 1
            For kolom = 0 To 1
                ListView1.Columns.Add(arr(baris, kolom), 100)
            Next kolom
        Next baris
        For baris = 2 To 2
            For kolom = 0 To 1
                cbKelamin.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris
        For baris = 3 To 3
            For kolom = 0 To 1
                cbProdi.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris
        For baris = 4 To 4
            For kolom = 0 To 1
                cbProdi.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris
    End Sub

    Private Sub bProses_Click(sender As Object, e As EventArgs) Handles bProses.Click
        Dim arr(4) As String
        arr(0) = txtNIM.Text
        arr(1) = TxtNama.Text
        arr(2) = cbKelamin.Text
        arr(3) = cbProdi.Text
        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(arr(0))
        listitem.SubItems.Add(arr(1))
        listitem.SubItems.Add(arr(2))
        listitem.SubItems.Add(arr(3))
        txtNIM.Text = txtNIM.Text + 1
        TxtNama.Text = ""
        cbKelamin.Text = ""
        cbProdi.Text = ""
        TxtNama.Focus()
    End Sub

    Private Sub bKeluar_Click(sender As Object, e As EventArgs) Handles bKeluar.Click
        End
    End Sub
End Class
