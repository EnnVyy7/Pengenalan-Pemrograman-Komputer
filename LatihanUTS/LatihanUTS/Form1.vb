Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Terima Kasih telah berbelanja")
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Select Case ComboBox1.Text
            Case "Ayam Goreng"
                TextBox2.Text = "20.000"
        End Select
    End Sub
End Class
