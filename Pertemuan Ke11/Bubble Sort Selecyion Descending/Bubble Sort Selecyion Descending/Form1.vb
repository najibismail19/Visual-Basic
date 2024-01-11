Public Class Form1
    Dim data() As Integer = {95, 70, 75, 88, 90, 74, 83}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("Data sebelum diurutkan")
        For i = 0 To (data.Length - 1)
            Console.WriteLine(data(i))
        Next
        Console.WriteLine("=======================")
    End Sub

    Function BubbleSort(ByRef data As Integer()) As Integer()
        For i = 1 To (data.Length - 1)
            For j = 0 To ((data.Length - 1) - i)
                If data(j) > data(j + 1) Then
                    Swap(data, j, j + 1)
                End If
            Next
        Next
        Return data
    End Function

    Function BubbleSortDescending(ByRef data As Integer()) As Integer()
        For i = 1 To (data.Length - 1)
            For j = 0 To ((data.Length - 1) - i)
                If data(j) < data(j + 1) Then
                    Swap(data, j, j + 1)
                End If
            Next
        Next
        Return data
    End Function

    Function SelectionSort(ByRef data As Integer()) As Integer()
        Dim min As Integer
        For i As Integer = 0 To data.Length - 2
            min = i
            For j As Integer = i + 1 To data.Length - 1
                If data(j) < data(min) Then
                    min = j
                End If
            Next
            Swap(data, min, i)
        Next
        Return data
    End Function

    Private Sub Swap(ByRef data As Integer(), ByVal index1 As Integer, ByVal index2 As Integer)
        Dim temp As Integer = data(index1)
        data(index1) = data(index2)
        data(index2) = temp
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dataUrut = BubbleSort(data)
        DisplaySortedData(dataUrut)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dataUrut = SelectionSort(data)
        DisplaySortedData(dataUrut)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dataUrut = BubbleSortDescending(data)
        DisplaySortedData(dataUrut)
    End Sub

    Private Sub DisplaySortedData(ByVal sortedData As Integer())
        Console.WriteLine("Data setelah diurutkan")
        For i = 0 To (sortedData.Length - 1)
            Console.WriteLine(sortedData(i))
        Next
    End Sub
End Class
