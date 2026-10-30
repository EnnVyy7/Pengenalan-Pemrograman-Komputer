Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text >= 17 Then
            TextBox2.Text = "Dewasa"
        Else
            TextBox2.Text = "Anak-Anak"
        End If
    End Sub
End Class