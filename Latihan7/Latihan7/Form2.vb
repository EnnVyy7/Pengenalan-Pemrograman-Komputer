Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("NIM : " & TextBox1.Text & vbCrLf &
               "Nama : " & TextBox2.Text)
    End Sub
End Class