
Imports MySql.Data.MySqlClient

Public Module Database
    Public connectionString As String = "server=localhost;database=vb_santri;user=root;password="
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
    ' Fungsi untuk menghitung total santri
    Public Function GetTotalSantri() As Integer
        Dim total As Integer = 0
        Dim query As String = "
        SELECT COUNT(*) AS total_santri
        FROM users u
        JOIN user_role ru ON u.id = ru.user_id
        JOIN roles r ON ru.role_id = r.id
        WHERE r.id = 1
          AND u.deleted_at IS NULL
          AND ru.deleted_at IS NULL
          AND r.deleted_at IS NULL;

    "

        Dim conn As MySqlConnection = GetConnection()
        Try
            Dim cmd As New MySqlCommand(query, conn)
            total = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            Console.WriteLine("Terjadi kesalahan saat mengambil data: " & ex.Message)
        Finally
            CloseConnection(conn)
        End Try

        Return total
    End Function
    Public Function GetTotalPetugas() As Integer
        Dim total As Integer = 0
        Dim query As String = "
          SELECT COUNT(*) AS total_petugas
            FROM users u
            JOIN user_role ru ON u.id = ru.user_id
            JOIN roles r ON ru.role_id = r.id
            WHERE r.id = '2'
              AND u.deleted_at IS NULL
              AND ru.deleted_at IS NULL
              AND r.deleted_at IS NULL;

    "

        Dim conn As MySqlConnection = GetConnection()
        Try
            Dim cmd As New MySqlCommand(query, conn)
            total = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            Console.WriteLine("Terjadi kesalahan saat mengambil data: " & ex.Message)
        Finally
            CloseConnection(conn)
        End Try

        Return total
    End Function

    Public Function GetTotalSaldo() As Decimal
        Dim total As Decimal = 0D
        Dim query As String = "
        SELECT
            COALESCE(SUM(CASE WHEN type = 'pemasukan' THEN jumlah ELSE 0 END), 0) -
            COALESCE(SUM(CASE WHEN type = 'pengeluaran' THEN jumlah ELSE 0 END), 0) AS total_saldo
        FROM detail_transaksi
        WHERE deleted_at IS NULL;
    "

        Dim conn As MySqlConnection = GetConnection()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            Dim result = cmd.ExecuteScalar()
            If result IsNot DBNull.Value Then
                total = Convert.ToDecimal(result)
            End If
        Catch ex As Exception
            Console.WriteLine("Terjadi kesalahan saat mengambil data: " & ex.Message)
        Finally
            CloseConnection(conn)
        End Try

        Return total
    End Function
    Public Function GetChartSaldoBulat() As (total_saldo As Decimal, total_pengeluaran As Decimal, total_pemasukan As Decimal)
        Dim total_saldo As Decimal = 0D
        Dim total_pengeluaran As Decimal = 0D
        Dim total_pemasukan As Decimal = 0D

        Dim query As String = "
        SELECT
            COALESCE(SUM(CASE WHEN type = 'pengeluaran' THEN jumlah ELSE 0 END), 0) AS total_pengeluaran,
            COALESCE(SUM(CASE WHEN type = 'pemasukan' THEN jumlah ELSE 0 END), 0) AS total_pemasukan,
            COALESCE(SUM(CASE WHEN type = 'pemasukan' THEN jumlah ELSE 0 END), 0) - 
            COALESCE(SUM(CASE WHEN type = 'pengeluaran' THEN jumlah ELSE 0 END), 0) AS total_saldo
        FROM detail_transaksi
        WHERE deleted_at IS NULL;
    "

        Dim conn As MySqlConnection = GetConnection()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                total_pengeluaran = Convert.ToDecimal(reader("total_pengeluaran"))
                total_pemasukan = Convert.ToDecimal(reader("total_pemasukan"))
                total_saldo = Convert.ToDecimal(reader("total_saldo"))
            End If
            reader.Close()
        Catch ex As Exception
            Console.WriteLine("Terjadi kesalahan saat mengambil data: " & ex.Message)
        Finally
            CloseConnection(conn)
        End Try

        Return (total_saldo, total_pengeluaran, total_pemasukan)
    End Function
    Public Function GetChartSantri() As (labels As List(Of String), values As List(Of Integer), isTahunan As Boolean)
        ' Hapus variabel total_saldo, total_pengeluaran, dan total_pemasukan
        Dim labels As New List(Of String)()
        Dim values As New List(Of Integer)()
        Dim isTahunan As Boolean = False ' Untuk menyatakan apakah data lebih dari satu tahun

        ' Query untuk mendapatkan jumlah santri berdasarkan tahun dan bulan
        Dim query As String = "
    SELECT 
        YEAR(u.created_at) AS tahun,
        MONTH(u.created_at) AS bulan,
        COUNT(DISTINCT u.id) AS jumlah_santri
    FROM users u
    JOIN user_role ru ON u.id = ru.user_id
    JOIN roles r ON ru.role_id = r.id
    WHERE 
        r.id = 1
        AND u.deleted_at IS NULL
        AND ru.deleted_at IS NULL
        AND r.deleted_at IS NULL
    GROUP BY YEAR(u.created_at), MONTH(u.created_at)
    ORDER BY tahun, bulan;
    "

        Dim conn As MySqlConnection = GetConnection()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Variabel untuk menyimpan tahun, bulan, dan jumlah santri
            Dim currentYear As String = ""
            Dim monthsData As New Dictionary(Of String, Integer)()

            ' Membaca hasil query dan memproses data
            While reader.Read()
                Dim year As String = reader("tahun").ToString()
                Dim month As String = reader("bulan").ToString("00") ' Format bulan menjadi 2 digit
                Dim santriCount As Integer = Convert.ToInt32(reader("jumlah_santri"))

                ' Menentukan apakah tahun berubah
                If currentYear <> year Then
                    ' Jika tahun berubah, reset bulan dan tambah tahun ke labels
                    If currentYear <> "" Then
                        ' Menambahkan bulan-bulan yang sudah terkumpul ke labels dan values
                        For Each monthLabel As KeyValuePair(Of String, Integer) In monthsData
                            labels.Add($"{currentYear}-{monthLabel.Key}")
                            values.Add(monthLabel.Value)
                        Next
                    End If
                    ' Menyimpan tahun baru dan reset bulan
                    currentYear = year
                    monthsData.Clear()
                End If

                ' Menyimpan jumlah santri berdasarkan bulan untuk tahun yang sama
                monthsData(month) = santriCount
            End While

            ' Tambahkan data terakhir ke label dan values
            If currentYear <> "" Then
                For Each monthLabel As KeyValuePair(Of String, Integer) In monthsData
                    labels.Add($"{currentYear}-{monthLabel.Key}")
                    values.Add(monthLabel.Value)
                Next
            End If

            reader.Close()

            ' Tentukan apakah data lebih dari satu tahun
            If labels.Count > 12 Then
                ' Lebih dari satu tahun, berarti isTahunan = True
                isTahunan = True
            Else
                ' Jika hanya satu tahun, gunakan bulan
                isTahunan = False
            End If

        Catch ex As Exception
            Console.WriteLine("Terjadi kesalahan saat mengambil data: " & ex.Message)
        Finally
            CloseConnection(conn)
        End Try

        ' Mengembalikan hasil: labels, values, dan isTahunan
        Return (labels, values, isTahunan)
    End Function


End Module
