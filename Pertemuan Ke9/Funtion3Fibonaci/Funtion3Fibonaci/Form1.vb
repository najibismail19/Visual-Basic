Imports System.Text
Public Class Form1
    Function Fibonacci(ByVal n As Integer) As Long
        If n < 2 Then
            Return 1
        Else
            Return Fibonacci(n - 1) + Fibonacci(n - 2)
        End If
    End Function
    Function GetFibonnaciSeries(ByVal n As Integer) As String
        'Buat String yang akan menampung daftar
        Dim series As New StringBuilder()
        'Mulai dengan menggabungkan 3 nilai pertama yang mana selalu konstan
        series.Append("0, 1, 1")
        ' Hitung Fibonacci setiap elemen dan tambahkan tambahkan ke daftar
        For i = 2 To n Step 1
            If i < n Then
                series.Append(", ")
            Else
                series.Append(" = ")
            End If
            series.Append(Fibonacci(i))
        Next
        ' return daftar sebagai string
        Return series.ToString()
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        n = Integer.Parse(TextBox1.Text)
        Label1.Text = GetFibonnaciSeries(n)
        Console.WriteLine(GetFibonnaciSeries(n))
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
