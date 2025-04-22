Imports MySql.Data.MySqlClient

Public Module Database
    Public connectionString As String = "server=localhost;database=vb_santri;user=root;password=root"
    Public conn As MySqlConnection = Database.GetConnection()
    Public i As Integer
    Public dr As MySqlDataReader

    ' Mengambil koneksi ke database MySQL
    Public Function GetConnection() As MySqlConnection
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
    Public Sub CloseConnection(ByVal conn As MySqlConnection)
        Try
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            Throw New Exception("Terjadi kesalahan saat menutup koneksi: " & ex.Message)
        End Try
    End Sub


End Module
