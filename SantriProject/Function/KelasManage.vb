Imports MySql.Data.MySqlClient

Module KelasManage
    Dim conn As MySqlConnection = Database.GetConnection()
    Dim i As Integer
    Dim dr As MySqlDataReader

    Public Sub TambahKelas()

    End Sub

    Public Sub ShowKelas(DGView1 As DataGridView)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            DGView1.Rows.Clear()
            DGView1.Columns.Clear()
            DGView1.AutoGenerateColumns = False

            DGView1.Columns.Add("id", "ID")
            DGView1.Columns("id").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            DGView1.Columns.Add("nama", "Nama Kelas")
            DGView1.Columns("nama").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            DGView1.Columns.Add("deskripsi", "Deskripsi")
            DGView1.Columns("deskripsi").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells ' Contoh: email panjang, jadi pakai Fill

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

            Dim cmd As New MySqlCommand("SELECT * FROM kelas WHERE deleted_at IS NULL", conn)

            dr = cmd.ExecuteReader
            While dr.Read
                DGView1.Rows.Add(
                    dr.Item("id"),
                    dr.Item("nama"),
                    dr.Item("deskripsi"),
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

    Public Sub EditKelas(txt_nama As TextBox, txt_deskripsi As TextBox, selectedNamaKelas As String)
        Try
            conn.Open()
            Dim query As String = "
            UPDATE users SET 
                nama = @nama,
                deskripsi = @deskripsi,
                updated_at = CURRENT_TIMESTAMP
            WHERE nama = @old_nama;
            "

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nama", txt_nama.Text.Trim())
            cmd.Parameters.AddWithValue("@deskripsi", txt_deskripsi.Text)
            cmd.Parameters.AddWithValue("@old_nama", selectedNamaKelas)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data pengguna berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox("Gagal memperbarui user: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Public Sub DeleteKelas(id As Integer)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "UPDATE kelas SET deleted_at = CURRENT_TIMESTAMP WHERE id = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Kelas berhasil dihapus (soft delete).", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Gagal menghapus kelas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Public Sub SearchKelas(keyword As String, dgv As DataGridView)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Jika keyword kosong, tampilkan semua user
            If String.IsNullOrWhiteSpace(keyword) Then
                ShowKelas(dgv)
                Return
            End If

            Dim query As String = "SELECT * FROM kelas WHERE deleted_at IS NULL AND (nama LIKE @keyword)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            ' Bersihkan baris sebelumnya
            dgv.Rows.Clear()

            ' Tambahkan baris hasil pencarian
            While dr.Read
                dgv.Rows.Add(
                    dr.Item("id"),
                    dr.Item("nama"),
                    dr.Item("deskripsi"),
                    Nothing, Nothing
                )
            End While

            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat mencari user: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Public Sub LoadKelas(cmb_kelas As ComboBox)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim cmd As New MySqlCommand("SELECT nama FROM kelas ORDER BY nama ASC", conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            adapter.Fill(dt)

            cmb_kelas.DataSource = dt
            cmb_kelas.DisplayMember = "nama"
            cmb_kelas.ValueMember = "nama"

        Catch ex As Exception
            MsgBox("Gagal load data kelas: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub
End Module
