Imports System.Data.OleDb
Imports System.Data


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn = New OleDbConnection(strconn)
            conn.Open()
            MsgBox("Koneksi Sukses")
        Catch ex As Exception
            MsgBox("Koneksi Gagal" & vbCrLf & "Kegagalan : " & ex.Message)
        End Try
    End Sub
End Class
