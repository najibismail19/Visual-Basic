Public Class Form1
    Dim data() As Integer = {95, 70, 75, 88, 90, 74, 83}
    Function SelectionSort(ByRef data As Integer())
        Dim min As Integer
        For i As Integer = 0 To data.Length - 2
            min = i
            For j As Integer = i + 1 To data.Length - 1
                If data(j) < data(min) Then
                    min = j
                End If
            Next
            Dim temp As Integer = data(min)
            data(min) = data(i)
            data(i) = temp
        Next
        Return data
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dataUrut = SelectionSort(data)
        Console.WriteLine("Data setelah diurutkan")
        For i = 0 To (dataUrut.Length - 1)
            Console.WriteLine(dataUrut(i))
        Next
    End Sub
End Class
