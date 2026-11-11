Imports System.Data.OleDb
Imports System.Data

Module koneksi
    Public strconn As String = "Provider=microsoft.ace.oledb.12.0; Data Source=" & Application.StartupPath & "\2677500004.accdb"

    Public conn As OleDbConnection
    Sub BukaKoneksi()
        conn = New OleDbConnection(strconn)
        If conn.State <> ConnectionState.Closed Then conn.Close()
        conn.Open()
    End Sub
End Module
