Public Class Form1
    Function factorial(ByVal n As Integer) As Integer
        If n = 0 Then
            factorial = 1
        Else
            factorial = n * factorial(n - 1)
        End If
    End Function
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        n = Integer.Parse(TextBox1.Text)
        Label2.Text = factorial(n).ToString()
    End Sub
End Class
