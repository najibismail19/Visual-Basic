Public Class FormListBox

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Trim(TextBox1.Text) <> "" Then
            ListBox1.Items.Add(TextBox1.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnMoveSelected.Click
        If ListBox1.SelectedIndex >= 0 Then
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
    End Sub

    Private Sub BtnRemoveSelected_Click(sender As Object, e As EventArgs) Handles BtnRemoveSelected.Click
        If ListBox1.SelectedIndex >= 0 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Else
            MsgBox("Silakan pilih terlebih dulu")
        End If
    End Sub

    Private Sub BtnMoveAll_Click(sender As Object, e As EventArgs) Handles BtnMoveAll.Click
        For i = 0 To ListBox1.Items.Count - 1
            ListBox2.Items.Add(ListBox1.Items(0))
            ListBox1.Items.RemoveAt(0)
        Next
    End Sub

    Private Sub BtnUp_Click(sender As Object, e As EventArgs) Handles BtnUp.Click
        Dim currentIndex As Integer
        Dim tempValue As String
        currentIndex = ListBox1.SelectedIndex
        If ListBox1.SelectedIndex >= 0 Then
            If currentIndex >= 1 Then
                tempValue = ListBox1.Items(currentIndex)
                ListBox1.Items(currentIndex) = ListBox1.Items(currentIndex - 1)
                ListBox1.Items(currentIndex - 1) = tempValue
                ListBox1.SelectedIndex = currentIndex - 1
            End If
        Else
            MsgBox("Silakan pilih terlebih dulu")
        End If
    End Sub

    Private Sub BtnDown_Click(sender As Object, e As EventArgs) Handles BtnDown.Click
        Dim currentIndex As Integer
        Dim tempValue As String
        currentIndex = ListBox1.SelectedIndex
        If ListBox1.SelectedIndex >= 0 Then
            If currentIndex < ListBox1.Items.Count - 1 Then
                tempValue = ListBox1.Items(currentIndex)
                ListBox1.Items(currentIndex) = ListBox1.Items(currentIndex + 1)
                ListBox1.Items(currentIndex + 1) = tempValue
                ListBox1.SelectedIndex = currentIndex + 1
            End If
        Else
            MsgBox("Silakan pilih terlebih dulu")
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub
End Class
