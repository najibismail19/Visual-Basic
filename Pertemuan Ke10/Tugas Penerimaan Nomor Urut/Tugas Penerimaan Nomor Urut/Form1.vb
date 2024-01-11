Public Class Form1
    Dim q As Queue = New Queue()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As String
        n = TextBox1.Text
        Console.WriteLine("Masuk Antrian : " + n)
        q.Enqueue(n)
        TextBox1.Text = ""
        Label3.Text = " Ada" + q.Count.ToString + "antrian"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ch As String
        Dim jumAntrian As Integer
        jumAntrian = q.Count
        Console.WriteLine("Jumlah Antrian:" + jumAntrian.ToString)
        If jumAntrian = 0 Then
            Label2.Text = "Belum Ada Antrian"
            Console.WriteLine("Belum Ada Antrian")
        Else
            ch = q.Dequeue()
            Label2.Text = ch
            Console.WriteLine("Keluar Antrian:" + ch)
        End If
    End Sub
End Class
