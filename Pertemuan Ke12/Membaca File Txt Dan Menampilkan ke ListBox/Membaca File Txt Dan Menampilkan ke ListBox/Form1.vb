Public Class Form1
    Dim strFileName As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Open file dialog to select a TXT file
        Dim AmbilFile As New OpenFileDialog
        AmbilFile.CheckFileExists = True
        AmbilFile.Filter = "TXT File (*.txt)|*.txt"
        AmbilFile.Title = "Pilih TXT File aja, jangan yg lain"
        AmbilFile.Multiselect = False

        If AmbilFile.ShowDialog() = DialogResult.OK Then
            strFileName = AmbilFile.FileName
            TextBox1.Text = strFileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Read and populate ListBox with file contents
        If String.IsNullOrEmpty(strFileName) Then
            MessageBox.Show("Please select a file first.")
            Return
        End If

        Try
            Dim mystream As New System.IO.StreamReader(strFileName)
            Dim BacaString As String
            Me.ListBox1.Items.Clear()

            While Not mystream.EndOfStream
                BacaString = mystream.ReadLine
                ListBox1.Items.Add(BacaString)
            End While

            mystream.Close()
        Catch ex As Exception
            MessageBox.Show("Error reading the file: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Clear ListBox
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Remove selected item from ListBox
        If ListBox1.SelectedIndex >= 0 Then
            ListBox1.Items.Remove(ListBox1.SelectedItem.ToString)
        Else
            MsgBox("Silakan pilih terlebih dulu")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Display the count of items in ListBox
        Label2.Text = ListBox1.Items.Count
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ' Only sort items in ascending order when the selection changes
        SortListAscendingWithoutClear()
    End Sub

    Private Sub ButtonAscending_Click(sender As Object, e As EventArgs) Handles ButtonAscending.Click
        ' Sort items in ascending order when the button is clicked
        SortListAscendingWithoutClear()
    End Sub

    Private Sub ButtonDescending_Click(sender As Object, e As EventArgs) Handles ButtonDescending.Click
        ' Sort items in descending order when the button is clicked
        SortListDescending()
    End Sub

    Private Sub SortListAscendingWithoutClear()
        ' Sort items in ascending order without clearing the ListBox
        Dim ar(ListBox1.Items.Count - 1) As Object
        ListBox1.Items.CopyTo(ar, 0)
        Array.Sort(ar)
        ListBox1.BeginUpdate() ' Suspend drawing to prevent flickering
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(ar)
        ListBox1.EndUpdate() ' Resume drawing
    End Sub

    Private Sub SortListDescending()
        ' Sort items in descending order
        Dim ar(ListBox1.Items.Count - 1) As Object
        ListBox1.Items.CopyTo(ar, 0)
        Array.Sort(ar)
        Array.Reverse(ar)
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(ar)
    End Sub
End Class
