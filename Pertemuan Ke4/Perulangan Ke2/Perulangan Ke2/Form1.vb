Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        For I = 1 To 10
            ListBox1.Items.Add("For Next : " & I)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        Dim i As Integer = 0
        Do While i <= 10
            ListBox1.Items.Add("Do While : " & i)
            i = i + 1
        Loop
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        Dim i As Integer = 0
        Do Until i > 10
            ListBox1.Items.Add("Do Until : " & i)
            i = i + 1
        Loop
    End Sub
End Class
