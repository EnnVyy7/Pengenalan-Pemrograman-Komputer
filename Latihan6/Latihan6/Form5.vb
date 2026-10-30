Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case TextBox1.Text
            Case 1
                TextBox2.Text = "Ahad"
            Case 2
                TextBox2.Text = "Senin"
            Case 3
                TextBox2.Text = "Selasa"
            Case 4
                TextBox2.Text = "Rabu"
            Case 5
                TextBox2.Text = "Kamis"
            Case 6
                TextBox2.Text = "Jumat"
            Case 7
                TextBox2.Text = "Sabtu"
        End Select
    End Sub
End Class