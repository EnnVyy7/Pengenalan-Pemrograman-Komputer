Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Kode Barang : " & TextBox1.Text & vbCrLf &
               "Nama Barang : " & TextBox2.Text & vbCrLf &
               "Keterangan : " & ComboBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class