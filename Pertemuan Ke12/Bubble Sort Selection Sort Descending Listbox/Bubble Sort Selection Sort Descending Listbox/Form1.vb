Public Class Form1

    Dim data() As Integer = {95, 70, 75, 88, 90, 74, 83}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayData("Data sebelum diurutkan", data, ListBox1)
        Console.WriteLine("=======================")
    End Sub

    Private Sub DisplayData(message As String, dataToDisplay As Integer(), listBox As ListBox)
        Console.WriteLine(message)
        listBox.Items.Clear()
        For i = 0 To (dataToDisplay.Length - 1)
            Console.WriteLine(dataToDisplay(i))
            listBox.Items.Add(dataToDisplay(i))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sortedData() As Integer = BubbleSort(data)
        DisplayData("Data setelah diurutkan dengan Bubble Sort", sortedData, ListBox2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sortedData() As Integer = SelectionSort(data)
        DisplayData("Data setelah diurutkan dengan Selection Sort", sortedData, ListBox2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sortedData() As Integer = BubbleSortDescending(data)
        DisplayData("Data setelah diurutkan secara descending", sortedData, ListBox2)
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

    Sub Swap(ByRef data As Integer(), index1 As Integer, index2 As Integer)
        Dim temp As Integer = data(index1)
        data(index1) = data(index2)
        data(index2) = temp
    End Sub

End Class
