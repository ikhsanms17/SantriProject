Imports MySql.Data.MySqlClient

Module PerizinanManage
    Dim conn As MySqlConnection = Database.GetConnection()
    Dim i As Integer
    Dim dr As MySqlDataReader

    Public Sub TambahIzin(
        txt_nama_penjemput As TextBox,
        dtpIzin As DateTimePicker,
        dtpBatasIzin As DateTimePicker,
        dtpDatang As DateTimePicker,
        cmbPengguna As ComboBox
    )
        ' Generate no_izin dari timestamp
        Dim no_izin As String = "IZIN-" & DateTime.Now.ToString("yyyyMMddHHmmss")

        ' Ambil data dari form
        Dim pengguna_id As String = cmbPengguna.SelectedValue.ToString()
        Dim nama_penjemput As String = txt_nama_penjemput.Text.Trim()
        Dim tanggal_izin As String = dtpIzin.Value.ToString("yyyy-MM-dd")
        Dim tanggal_batas_izin As String = dtpBatasIzin.Value.ToString("yyyy-MM-dd")
        Dim tanggal_datang As String = dtpDatang.Value.ToString("yyyy-MM-dd")

        ' Konfirmasi data sebelum disimpan
        Dim konfirmasi As String = "Apakah Anda yakin ingin menyimpan data berikut?" & vbCrLf & vbCrLf &
        "No Izin: " & no_izin & vbCrLf &
        "Pengguna ID: " & pengguna_id & " (" & cmbPengguna.Text & ")" & vbCrLf &
        "Nama Penjemput: " & nama_penjemput & vbCrLf &
        "Tanggal Izin: " & tanggal_izin & vbCrLf &
        "Tanggal Batas Izin: " & tanggal_batas_izin & vbCrLf &
        "Tanggal Datang: " & tanggal_datang

        Dim result As DialogResult = MessageBox.Show(konfirmasi, "Konfirmasi Simpan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then Exit Sub

        ' Simpan ke database
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "
            INSERT INTO perizinan (
                no_izin, pengguna_id, tanggal_izin, nama_penjemput,
                tanggal_batas_izin, tanggal_datang, status,
                created_at, updated_at
            ) VALUES (
                @no_izin, @pengguna_id, @tanggal_izin, @nama_penjemput,
                @tanggal_batas_izin, @tanggal_datang, 'Tidak Dizinkan',
                CURRENT_TIMESTAMP, CURRENT_TIMESTAMP
            )"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@no_izin", no_izin)
            cmd.Parameters.AddWithValue("@pengguna_id", pengguna_id)
            cmd.Parameters.AddWithValue("@tanggal_izin", tanggal_izin)
            cmd.Parameters.AddWithValue("@nama_penjemput", nama_penjemput)
            cmd.Parameters.AddWithValue("@tanggal_batas_izin", tanggal_batas_izin)
            cmd.Parameters.AddWithValue("@tanggal_datang", tanggal_datang)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data perizinan berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Public Sub ShowIzin(DGView1 As DataGridView)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            DGView1.Rows.Clear()
            DGView1.Columns.Clear()
            DGView1.AutoGenerateColumns = False

            DGView1.Columns.Add("no_izin", "No Izin")
            DGView1.Columns("no_izin").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            DGView1.Columns.Add("pengguna_id", "Nama Pengguna")
            DGView1.Columns("pengguna_id").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            DGView1.Columns.Add("nama_penjemput", "Nama Penjemput")
            DGView1.Columns("nama_penjemput").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            DGView1.Columns.Add("tanggal_izin", "Tanggal Izin")
            DGView1.Columns("tanggal_izin").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            DGView1.Columns.Add("tanggal_batas_izin", "Tanggal Batas Izin")
            DGView1.Columns("tanggal_batas_izin").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            DGView1.Columns.Add("tanggal_datang", "Tanggal Kembali")
            DGView1.Columns("tanggal_datang").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            DGView1.Columns.Add("status", "Status Izin")
            DGView1.Columns("status").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            ' Tambah tombol Edit
            Dim btnEdit As New DataGridViewButtonColumn()
            btnEdit.Name = "btnEdit"
            btnEdit.HeaderText = ""
            btnEdit.Text = "Edit"
            btnEdit.UseColumnTextForButtonValue = True
            DGView1.Columns.Add(btnEdit)

            ' Tambah tombol Delete
            Dim btnDelete As New DataGridViewButtonColumn()
            btnDelete.Name = "btnHapus"
            btnDelete.HeaderText = ""
            btnDelete.Text = "Delete"
            btnDelete.UseColumnTextForButtonValue = True
            DGView1.Columns.Add(btnDelete)

            DGView1.DefaultCellStyle.Font = New Font("Segoe UI", 10)
            DGView1.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)

            DGView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dim cmd As New MySqlCommand("
            SELECT 
                p.no_izin,
                u.nama AS nama_pengguna,
                p.nama_penjemput,
                p.tanggal_izin,
                p.tanggal_batas_izin,
                p.tanggal_datang,
                p.status
            FROM perizinan p
            JOIN users u ON p.pengguna_id = u.id
            WHERE p.deleted_at IS NULL", conn)

            dr = cmd.ExecuteReader

            While dr.Read
                Dim index As Integer = DGView1.Rows.Add()

                DGView1.Rows(index).Cells("no_izin").Value = dr.Item("no_izin")
                DGView1.Rows(index).Cells("pengguna_id").Value = dr.Item("nama_pengguna")  ' Tampilkan nama pengguna
                DGView1.Rows(index).Cells("nama_penjemput").Value = dr.Item("nama_penjemput")
                DGView1.Rows(index).Cells("tanggal_izin").Value = dr.Item("tanggal_izin")
                DGView1.Rows(index).Cells("tanggal_batas_izin").Value = dr.Item("tanggal_batas_izin")
                DGView1.Rows(index).Cells("tanggal_datang").Value = dr.Item("tanggal_datang")
                DGView1.Rows(index).Cells("status").Value = dr.Item("status")

                ' Tambahkan tombol edit dan hapus (biarkan kosong karena ini button column)
                DGView1.Rows(index).Cells("btnEdit").Value = Nothing
                DGView1.Rows(index).Cells("btnHapus").Value = Nothing
            End While

            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Public Sub EditIzin(
        txt_nama_penjemput As TextBox,
        dtpIzin As DateTimePicker,
        dtpBatasIzin As DateTimePicker,
        dtpDatang As DateTimePicker,
        cmbUser As ComboBox,
        cmbStatusIzin As ComboBox,
        selectedNoIzin As String
    )
        ' Ambil data dari form
        Dim pengguna_id As String = cmbUser.SelectedValue.ToString()
        Dim nama_penjemput As String = txt_nama_penjemput.Text.Trim()
        Dim tanggal_izin As String = dtpIzin.Value.ToString("yyyy-MM-dd")
        Dim tanggal_batas_izin As String = dtpBatasIzin.Value.ToString("yyyy-MM-dd")
        Dim tanggal_datang As String = dtpDatang.Value.ToString("yyyy-MM-dd")
        Dim status As String = cmbStatusIzin.SelectedItem.ToString()

        ' Konfirmasi
        Dim konfirmasi As String = "Apakah Anda yakin ingin menyimpan perubahan data berikut?" & vbCrLf & vbCrLf &
        "No Izin: " & selectedNoIzin & vbCrLf &
        "Pengguna ID: " & pengguna_id & " (" & cmbUser.Text & ")" & vbCrLf &
        "Nama Penjemput: " & nama_penjemput & vbCrLf &
        "Tanggal Izin: " & tanggal_izin & vbCrLf &
        "Tanggal Batas Izin: " & tanggal_batas_izin & vbCrLf &
        "Tanggal Datang: " & tanggal_datang & vbCrLf &
        "Status Izin: " & status

        Dim result As DialogResult = MessageBox.Show(konfirmasi, "Konfirmasi Simpan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then Exit Sub

        ' Update ke database
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "
            UPDATE perizinan SET 
                nama_penjemput = @nama_penjemput,
                pengguna_id = @pengguna_id,
                tanggal_izin = @tanggal_izin,
                tanggal_batas_izin = @tanggal_batas_izin,
                tanggal_datang = @tanggal_datang,
                status = @status,
                updated_at = CURRENT_TIMESTAMP
            WHERE no_izin = @no_izin;"

            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@nama_penjemput", nama_penjemput)
            cmd.Parameters.AddWithValue("@pengguna_id", pengguna_id)
            cmd.Parameters.AddWithValue("@tanggal_izin", tanggal_izin)
            cmd.Parameters.AddWithValue("@tanggal_batas_izin", tanggal_batas_izin)
            cmd.Parameters.AddWithValue("@tanggal_datang", tanggal_datang)
            cmd.Parameters.AddWithValue("@status", status)
            cmd.Parameters.AddWithValue("@no_izin", selectedNoIzin)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data perizinan berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Gagal memperbarui data perizinan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Public Sub DeleteIzin(no_izin As String)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Ganti tabel dari users ke perizinan, karena kita sedang hapus data izin
            Dim query As String = "UPDATE perizinan SET deleted_at = CURRENT_TIMESTAMP WHERE no_izin = @no_izin"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@no_izin", no_izin)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data perizinan berhasil dihapus (soft delete).", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data perizinan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Public Sub SearchIzin(keyword As String, dgv As DataGridView)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Jika keyword kosong, tampilkan semua izin
            If String.IsNullOrWhiteSpace(keyword) Then
                ShowIzin(dgv) ' Fungsi untuk menampilkan semua data perizinan
                Return
            End If

            Dim query As String = "
            SELECT 
                p.no_izin,
                p.nama_penjemput,
                p.tanggal_izin,
                p.tanggal_batas_izin,
                p.tanggal_datang,
                p.status,
                u.nama AS nama_pengguna
            FROM perizinan p
            LEFT JOIN users u ON u.id = p.pengguna_id
            WHERE 
                p.deleted_at IS NULL
                AND (
                    p.nama_penjemput LIKE @keyword OR
                    p.status LIKE @keyword OR
                    u.nama LIKE @keyword
                )
        "

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            dgv.Rows.Clear()

            While dr.Read
                dgv.Rows.Add(
                dr("no_izin"),
                dr("nama_pengguna"),
                dr("nama_penjemput"),
                Convert.ToDateTime(dr("tanggal_izin")).ToString("yyyy-MM-dd"),
                Convert.ToDateTime(dr("tanggal_batas_izin")).ToString("yyyy-MM-dd"),
                Convert.ToDateTime(dr("tanggal_datang")).ToString("yyyy-MM-dd"),
                dr("status"),
                Nothing, Nothing ' kolom tombol edit & hapus jika ada
            )
            End While

            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat mencari perizinan: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub


    Public Sub LoadUser(cmb As ComboBox)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter("SELECT id, nama FROM users WHERE deleted_at IS NULL", conn)
        da.Fill(dt)

        cmb.DataSource = dt
        cmb.DisplayMember = "nama"       ' Yang ditampilkan di ComboBox
        cmb.ValueMember = "id"           ' Nilai sebenarnya yang digunakan
        conn.Close()
    End Sub

End Module
