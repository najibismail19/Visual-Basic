Public Class OrderMakanan
    Public hrgmakanan, hrgminuman As Integer

    Public Sub New()
        InitializeComponent()
        ' Tetapkan properti Visible di sini jika diperlukan
        ComboBox2.Visible = False
        Label6.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Kode inisialisasi formulir di sini
        ' Menambahkan item ke ComboBox1
        ComboBox1.Items.Add("Mie Ayam Bakso")
        ComboBox1.Items.Add("Bakso")
        ComboBox1.Items.Add("Mie Ayam")

        ' Menetapkan properti Visible menjadi True
        ComboBox2.Visible = True
        Label6.Visible = True

        ' Menetapkan properti Visible menjadi True
        ComboBox1.Visible = True
        Label5.Visible = True

        ' Menetapkan properti Visible menjadi True
        Hitung.Visible = True
        Label3.Visible = True

        ' Menetapkan properti Visible menjadi True
        TextBox1.Visible = True
        TextBox2.Visible = True

        ' Menetapkan properti Visible menjadi True
        GroupBox1.Visible = True
    End Sub

    ' Metode ini dipanggil ketika pengguna memilih item dalam ComboBox1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Logika untuk menetapkan harga makanan berdasarkan pilihan ComboBox1
        Select Case ComboBox1.Text
            Case "Mie Ayam Bakso"
                Label3.Text = "Rp. 15000"
                hrgmakanan = 15000
            Case "Bakso"
                Label3.Text = "Rp. 12000"
                hrgmakanan = 12000
            Case "Mie Ayam"
                Label3.Text = "Rp. 10000"
                hrgmakanan = 10000
        End Select
    End Sub

    ' Metode ini dipanggil ketika pengguna memilih item dalam ComboBox2
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ' Logika untuk menetapkan harga minuman berdasarkan pilihan ComboBox2
        Select Case ComboBox2.Text
            Case "Es Jeruk"
                Label5.Text = "Rp. 5000"
                hrgminuman = 5000
            Case "Jus Alpukat"
                Label5.Text = "Rp. 10000"
                hrgminuman = 10000
            Case "Teh Manis"
                Label5.Text = "Rp. 7000"
                hrgminuman = 7000
        End Select
    End Sub

    ' Metode ini akan dipanggil saat tombol Hitung diklik
    Private Sub Hitung_Click(sender As Object, e As EventArgs) Handles Hitung.Click
        Dim porsimkn, porsimnm, jumlah As Integer
        porsimkn = TextBox1.Text
        porsimnm = TextBox2.Text
        jumlah = (hrgmakanan * porsimkn) + (hrgminuman * porsimnm)
        Label.Text = "Rp. " & jumlah.ToString
    End Sub

    ' Metode ini akan dipanggil saat grup kotak (GroupBox1) diaktifkan
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        ' Kode yang ingin Anda eksekusi saat grup kotak diaktifkan
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Hitung.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles Label.Click

    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles Keluar.Click
        End
    End Sub
End Class ' Akhir dari kelas OrderMakanan
