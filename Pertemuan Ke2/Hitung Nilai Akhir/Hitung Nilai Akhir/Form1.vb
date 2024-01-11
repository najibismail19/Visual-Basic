Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NilaiAbs As Double
        Dim NilaiTugas As Double
        Dim NilaiUTS As Double
        Dim NilaiUAS As Double
        Dim NilaiAkhir As Double
        NilaiAbs = TxtAbsensi.Text
        NilaiAbs = (NilaiAbs * 10) / 100
        txtHasilAbs.Text = NilaiAbs
        NilaiTugas = TxtTugas.Text
        NilaiTugas = (NilaiTugas * 20) / 100
        txtHasilTugas.Text = NilaiTugas
        NilaiUTS = TxtUts.Text
        NilaiUTS = (NilaiUTS * 30) / 100
        txtHasilUts.Text = NilaiUTS
        NilaiUAS = TxtUas.Text
        NilaiUAS = (NilaiUAS * 40) / 100
        txtHasilUAS.Text = NilaiUAS
        NilaiAkhir = NilaiAbs + NilaiTugas + NilaiUTS + NilaiUAS
        TxtNilaiAkhir.Text = NilaiAkhir
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
