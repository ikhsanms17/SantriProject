Imports MySql.Data.MySqlClient
Imports SkiaSharp

Module UserManage
    Dim conn As MySqlConnection = Database.GetConnection()
    Dim i As Integer
    Dim dr As MySqlDataReader

    'Public Sub TambahUser(txt_nama As TextBox,
    '    txt_username As TextBox,
    '    txt_email As TextBox,
    '    txt_nis As TextBox,
    '    cmb_kelas As ComboBox,
    '    cmb_jenis_kelamin As ComboBox,
    '    txt_tgl_lahir As DateTimePicker,
    '    txt_nama_ayah As TextBox,
    '    txt_nama_ibu As TextBox,
    '    txt_alamat As TextBox
    ')
    '    Try
    '        conn.Open()
    '        Dim cmd As New MySqlCommand("
    '        INSERT INTO users (
    '            nama, 
    '            nama_pengguna, 
    '            email, 
    '            kata_sandi, 
    '            nis, 
    '            kelas_id, 
    '            jenis_kelamin, 
    '            tanggal_lahir, 
    '            nama_ayah, 
    '            nama_ibu, 
    '            alamat, 
    '            created_at, 
    '            updated_at
    '        ) VALUES (
    '            @nama,
    '            @username,
    '            @email,
    '            SHA2(@username, 256),
    '            @nis,
    '            @kelas_id,
    '            @jenis_kelamin,
    '            @tgl_lahir,
    '            @nama_ayah,
    '            @nama_ibu,
    '            @alamat,
    '            CURRENT_TIMESTAMP,
    '            CURRENT_TIMESTAMP
    '        );
    '        ", conn)

    '        '' Tambahkan parameter
    '        cmd.Parameters.Clear()
    '        cmd.Parameters.AddWithValue("@nama", txt_nama.Text.Trim())
    '        cmd.Parameters.AddWithValue("@username", txt_username.Text.Trim())
    '        cmd.Parameters.AddWithValue("@email", txt_email.Text.Trim())
    '        'cmd.Parameters.AddWithValue("@password", txt_password.Text.Trim())
    '        cmd.Parameters.AddWithValue("@nis", txt_nis.Text.Trim())
    '        cmd.Parameters.AddWithValue("@kelas_id", cmb_kelas.Text.Trim())
    '        cmd.Parameters.AddWithValue("@jenis_kelamin", cmb_jenis_kelamin.Text.Trim())
    '        cmd.Parameters.AddWithValue("@tgl_lahir", Convert.ToDateTime(txt_tgl_lahir.Text))
    '        cmd.Parameters.AddWithValue("@nama_ayah", txt_nama_ayah.Text.Trim())
    '        cmd.Parameters.AddWithValue("@nama_ibu", txt_nama_ibu.Text.Trim())
    '        cmd.Parameters.AddWithValue("@alamat", txt_alamat.Text.Trim())

    '        ' Eksekusi
    '        cmd.ExecuteNonQuery()
    '        MessageBox.Show("Data pengguna berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        Database.CloseConnection(conn)
    '    End Try
    'End Sub

    Public Sub TambahUser(txt_nama As TextBox,
        txt_username As TextBox,
        txt_email As TextBox,
        txt_nis As TextBox,
        cmb_kelas As ComboBox,
        cmb_jenis_kelamin As ComboBox,
        txt_tgl_lahir As DateTimePicker,
        txt_nama_ayah As TextBox,
        txt_nama_ibu As TextBox,
        txt_alamat As TextBox
    )
        ' Ambil data dari form
        Dim nama As String = txt_nama.Text.Trim()
        Dim username As String = txt_username.Text.Trim()
        Dim email As String = txt_email.Text.Trim()
        'Dim password As String = txt_password.Text.Trim()
        Dim nis As String = txt_nis.Text.Trim()
        Dim kelas_id As String = cmb_kelas.SelectedValue.ToString()
        Dim jenis_kelamin As String = cmb_jenis_kelamin.Text
        Dim tgl_lahir As String = txt_tgl_lahir.Value.ToString("yyyy-MM-dd")
        Dim nama_ayah As String = txt_nama_ayah.Text.Trim()
        Dim nama_ibu As String = txt_nama_ibu.Text.Trim()
        Dim alamat As String = txt_alamat.Text.Trim()

        ' Buat ringkasan data
        Dim konfirmasi As String = "Apakah Anda yakin ingin menyimpan data berikut?" & vbCrLf & vbCrLf &
        "Nama: " & nama & vbCrLf &
        "Username: " & username & vbCrLf &
        "Email: " & email & vbCrLf &
        "NIS: " & nis & vbCrLf &
        "Kelas: " & cmb_kelas.Text & vbCrLf &
        "Jenis Kelamin: " & jenis_kelamin & vbCrLf &
        "Tanggal Lahir: " & tgl_lahir & vbCrLf &
        "Nama Ayah: " & nama_ayah & vbCrLf &
        "Nama Ibu: " & nama_ibu & vbCrLf &
        "Alamat: " & alamat

        Dim result As DialogResult = MessageBox.Show(konfirmasi, "Konfirmasi Simpan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            Exit Sub ' Batal menyimpan
        End If

        ' Simpan ke database
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd As New MySqlCommand("
            INSERT INTO users (
                nama, nama_pengguna, email, kata_sandi, nis, kelas_id,
                jenis_kelamin, tanggal_lahir, nama_ayah, nama_ibu, alamat,
                created_at, updated_at
            ) VALUES (
                @nama, @username, @email, SHA2(@username, 256), @nis, @kelas_id,
                @jenis_kelamin, @tgl_lahir, @nama_ayah, @nama_ibu, @alamat,
                CURRENT_TIMESTAMP, CURRENT_TIMESTAMP
            )", conn)

            ' Parameter
            cmd.Parameters.AddWithValue("@nama", nama)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@email", email)
            'cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@nis", nis)
            cmd.Parameters.AddWithValue("@kelas_id", kelas_id)
            cmd.Parameters.AddWithValue("@jenis_kelamin", jenis_kelamin)
            cmd.Parameters.AddWithValue("@tgl_lahir", tgl_lahir)
            cmd.Parameters.AddWithValue("@nama_ayah", nama_ayah)
            cmd.Parameters.AddWithValue("@nama_ibu", nama_ibu)
            cmd.Parameters.AddWithValue("@alamat", alamat)

            ' Eksekusi
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data pengguna berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox("Gagal menyimpan: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub


    Public Sub ShowUser(DGView1 As DataGridView)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            DGView1.Rows.Clear()
            DGView1.Columns.Clear()
            DGView1.AutoGenerateColumns = False

            'DGView1.Columns.Add("nama", "Nama")
            'DGView1.Columns.Add("nama_pengguna", "Nama Pengguna")
            'DGView1.Columns.Add("email", "Email")
            'DGView1.Columns.Add("nis", "NIS")
            'DGView1.Columns.Add("kelas_id", "Kelas")
            'DGView1.Columns.Add("jenis_kelamin", "Jenis Kelamin")
            'DGView1.Columns.Add("tanggal_lahir", "Tanggal Lahir")
            'DGView1.Columns.Add("nama_ayah", "Ayah")
            'DGView1.Columns.Add("nama_ibu", "Ibu")
            'DGView1.Columns.Add("alamat", "Alamat")
            'DGView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            DGView1.Columns.Add("nama", "Nama")
            DGView1.Columns("nama").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            DGView1.Columns.Add("nama_pengguna", "Nama Pengguna")
            DGView1.Columns("nama_pengguna").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            DGView1.Columns.Add("email", "Email")
            DGView1.Columns("email").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells ' Contoh: email panjang, jadi pakai Fill

            DGView1.Columns.Add("nis", "NIS")
            DGView1.Columns("nis").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            DGView1.Columns.Add("kelas_id", "Kelas")
            DGView1.Columns("kelas_id").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            DGView1.Columns.Add("jenis_kelamin", "Jenis Kelamin")
            DGView1.Columns("jenis_kelamin").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            DGView1.Columns.Add("tanggal_lahir", "Tanggal Lahir")
            DGView1.Columns("tanggal_lahir").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            DGView1.Columns.Add("nama_ayah", "Ayah")
            DGView1.Columns("nama_ayah").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            DGView1.Columns.Add("nama_ibu", "Ibu")
            DGView1.Columns("nama_ibu").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            DGView1.Columns.Add("alamat", "Alamat")
            DGView1.Columns("alamat").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ' Biar alamat bisa lebih lebar

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

            Dim cmd As New MySqlCommand("SELECT * FROM users WHERE deleted_at IS NULL", conn)

            dr = cmd.ExecuteReader
            While dr.Read
                DGView1.Rows.Add(
                    dr.Item("nama"),
                    dr.Item("nama_pengguna"),
                    dr.Item("email"),
                    dr.Item("nis"),
                    dr.Item("kelas_id"),
                    dr.Item("jenis_kelamin"),
                    dr.Item("tanggal_lahir"),
                    dr.Item("nama_ayah"),
                    dr.Item("nama_ibu"),
                    dr.Item("alamat"),
                    Nothing, Nothing
                )
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Public Sub EditUser(txt_nama As TextBox,
        txt_username As TextBox,
        txt_email As TextBox,
        txt_nis As TextBox,
        cmb_kelas As ComboBox,
        cmb_jenis_kelamin As ComboBox,
        txt_tgl_lahir As DateTimePicker,
        txt_nama_ayah As TextBox,
        txt_nama_ibu As TextBox,
        txt_alamat As TextBox,
        selectedUsername As String
    )
        Try
            conn.Open()
            Dim query As String = "
            UPDATE users SET 
                nama = @nama,
                nama_pengguna = @username,
                email = @email,
                nis = @nis,
                kelas_id = @kelas_id,
                jenis_kelamin = @jenis_kelamin,
                tanggal_lahir = @tgl_lahir,
                nama_ayah = @nama_ayah,
                nama_ibu = @nama_ibu,
                alamat = @alamat,
                updated_at = CURRENT_TIMESTAMP
            WHERE nama_pengguna = @old_username;
            "

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nama", txt_nama.Text.Trim())
            cmd.Parameters.AddWithValue("@username", txt_username.Text.Trim())
            cmd.Parameters.AddWithValue("@email", txt_email.Text.Trim())
            cmd.Parameters.AddWithValue("@nis", txt_nis.Text.Trim())
            cmd.Parameters.AddWithValue("@kelas_id", cmb_kelas.Text.Trim())
            cmd.Parameters.AddWithValue("@jenis_kelamin", cmb_jenis_kelamin.Text.Trim())
            cmd.Parameters.AddWithValue("@tgl_lahir", Convert.ToDateTime(txt_tgl_lahir.Text))
            cmd.Parameters.AddWithValue("@nama_ayah", txt_nama_ayah.Text.Trim())
            cmd.Parameters.AddWithValue("@nama_ibu", txt_nama_ibu.Text.Trim())
            cmd.Parameters.AddWithValue("@alamat", txt_alamat.Text.Trim())
            cmd.Parameters.AddWithValue("@old_username", selectedUsername)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data pengguna berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox("Gagal memperbarui user: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Public Sub DeleteUser(nama As String)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "UPDATE users SET deleted_at = CURRENT_TIMESTAMP WHERE nama = @nama"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama", nama)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Pengguna berhasil dihapus (soft delete).")

        Catch ex As Exception
            MessageBox.Show("Gagal menghapus user: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Public Sub LoadKelas(cmb_kelas As ComboBox)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim cmd As New MySqlCommand("SELECT id, nama FROM kelas ORDER BY nama ASC", conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            adapter.Fill(dt)

            cmb_kelas.DataSource = dt
            cmb_kelas.DisplayMember = "nama_kelas"
            cmb_kelas.ValueMember = "id"

        Catch ex As Exception
            MsgBox("Gagal load data kelas: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub
End Module
