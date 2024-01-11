Imports System.Text
Public Class Form1
    Private Sub ButtonFaktorial_Click(sender As Object, e As EventArgs) Handles ButtonFaktorial.Click
        HitungFaktorial()
    End Sub

    Private Sub HitungFaktorial()
        Dim angka As Integer

        If Integer.TryParse(TextBox1.Text, angka) Then
            If angka >= 0 Then
                Dim faktorial As String = GetFactorialSeries(angka)
                Label1.Text = faktorial
            Else
                MessageBox.Show("Masukkan bilangan bulat non-negatif.")
            End If
        Else
            MessageBox.Show("Masukkan bilangan bulat.")
        End If
    End Sub

    Private Function GetFactorialSeries(ByVal n As Integer) As String
        'Buat StringBuilder yang akan menampung daftar
        Dim series As New StringBuilder()

        'Tambahkan n! dan hasil akhir ke dalam daftar
        series.Append("!" & n.ToString() & " = " & FaktorialExpression(n))

        'return daftar sebagai string
        Return series.ToString()
    End Function

    Private Function FaktorialExpression(ByVal x As Integer) As String
        Dim result As Long = Factorial(x)
        Dim expression As New StringBuilder()

        'Tambahkan ekspresi faktorial ke dalam daftar
        For i = x To 1 Step -1
            expression.Append(i.ToString())
            If i > 1 Then
                expression.Append("*")
            End If
        Next

        'Tambahkan hasil akhir ke dalam daftar
        expression.Append(" = " & result.ToString())

        Return expression.ToString()
    End Function

    Private Function Factorial(ByVal x As Integer) As Long
        'Base case
        If x = 0 Then
            Return 1
        Else
            'Recursive case
            Return x * Factorial(x - 1)
        End If
    End Function
End Class
