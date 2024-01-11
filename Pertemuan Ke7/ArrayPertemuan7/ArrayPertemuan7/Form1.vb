Public Class Form1

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("NIM")
        ListView1.Columns.Add("NAMA", 115)
        ListView1.Columns.Add("PRODI", 110)
        txtNIM.Text = 1
        TxtNama.Focus()
    End Sub

    Private Sub bTambah_Click(sender As Object, e As EventArgs) Handles bTambah.Click
        Dim Arr(2) As String
        Arr(0) = txtNIM.Text
        Arr(1) = TxtNama.Text
        Arr(2) = txtProdi.Text
        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))
        txtNIM.Text = txtNIM.Text + 1
        TxtNama.Text = ""
        txtProdi.Text = ""
        TxtNama.Focus()
    End Sub

    Private Sub bKeluar_Click(sender As Object, e As EventArgs) Handles bKeluar.Click
        End
    End Sub
End Class
