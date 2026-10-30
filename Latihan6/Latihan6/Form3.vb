Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text >= 26 Then
            If TextBox1.Text <= 45 Then
                TextBox2.Text = "Dewasa Akhir"
            Else
                TextBox2.Text = "Lansia"
            End If
        End If
    End Sub
End Class