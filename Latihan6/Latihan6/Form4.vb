Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <= 21 Then
            TextBox2.Text = "Pelajar"
        ElseIf TextBox1.Text <= 55 Then
            TextBox2.Text = "Pekerja"
        Else
            TextBox2.Text = "Pensiun"
        End If
    End Sub
End Class