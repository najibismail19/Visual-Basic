Public Class Form1
    Dim q As Queue = New Queue()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As String
        n = TextBox1.Text
        Console.WriteLine("Masuk Antrian : " + n)
        q.Enqueue(n)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ch As String
        Dim jumAntrian As Integer
        jumAntrian = q.Count
        Console.WriteLine("Jumlah Antrian: " + jumAntrian.ToString)
        If jumAntrian = 0 Then
            Label2.Text = "Belum Ada Antrian"
            Console.WriteLine("Belum Ada Antrian")
        Else
            ch = q.Dequeue()
            Label2.Text = ch
            Console.WriteLine("Keluar Antrian:" + ch)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
