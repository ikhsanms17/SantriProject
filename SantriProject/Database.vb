Imports MySql.Data.MySqlClient

Public Class Database
    Public Shared connectionString As String = "server=localhost;database=vb_santri;user=root;password="

    ' Mengambil koneksi ke database MySQL
    Public Shared Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connectionString)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            Throw New Exception("Terjadi kesalahan saat membuka koneksi: " & ex.Message)
        End Try
        Return conn
    End Function

    ' Menutup koneksi MySQL
    Public Shared Sub CloseConnection(ByVal conn As MySqlConnection)
        Try
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            Throw New Exception("Terjadi kesalahan saat menutup koneksi: " & ex.Message)
        End Try
    End Sub


End Class
