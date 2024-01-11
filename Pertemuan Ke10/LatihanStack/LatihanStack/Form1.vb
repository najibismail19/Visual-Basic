Public Class Form1
    Dim stk As Stack = New Stack()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As String
        n = TextBox1.Text
        Console.WriteLine("Masuk Antrian : " + n)
        stk.Push(n)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ch As String
        Dim jumAntrian As Integer
        jumAntrian = stk.Count
        Console.WriteLine("Jumlah Antrian: " + jumAntrian.ToString)
        If jumAntrian = 0 Then
            Label2.Text = "Belum Ada Antrian"
            Console.WriteLine("Belum Ada Antrian")
        Else
            ch = stk.Pop()
            Label2.Text = ch
            Console.WriteLine("Keluar Antrian:" + ch)
        End If
    End Sub
End Class
