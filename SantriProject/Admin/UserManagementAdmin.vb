Imports MySql.Data.MySqlClient

Public Class UserManagementAdmin

    Private Sub UserManagementAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form agar bisa di-resize
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight

        ResizeControls(Me, scaleX, scaleY)

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            DGView1.Rows.Clear()
            DGView1.Columns.Clear()
            DGView1.AutoGenerateColumns = False

            DGView1.Columns.Add("nama", "Nama")
            DGView1.Columns("nama").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            DGView1.Columns.Add("nama_pengguna", "Nama Pengguna")
            DGView1.Columns("nama_pengguna").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            DGView1.Columns.Add("email", "Email")
            DGView1.Columns("email").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ' Contoh: email panjang, jadi pakai Fill

            DGView1.Columns.Add("nis", "NIS")
            DGView1.Columns("nis").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            DGView1.Columns.Add("kelas_id", "Kelas")
            DGView1.Columns("kelas_id").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            DGView1.Columns.Add("jenis_kelamin", "Jenis Kelamin")
            DGView1.Columns("jenis_kelamin").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            DGView1.Columns.Add("tanggal_lahir", "Tanggal Lahir")
            DGView1.Columns("tanggal_lahir").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            DGView1.Columns.Add("nama_ayah", "Ayah")
            DGView1.Columns("nama_ayah").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            DGView1.Columns.Add("nama_ibu", "Ibu")
            DGView1.Columns("nama_ibu").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            DGView1.Columns.Add("alamat", "Alamat")
            DGView1.Columns("alamat").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ' Biar alamat bisa lebih lebar

            DGView1.Columns.Add("saldo", "Saldo")
            DGView1.Columns("saldo").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ' Biar alamat bisa lebih lebar
            ' Tambah tombol Edit
            Dim btnEditUser As New DataGridViewButtonColumn()
            btnEditUser.Name = "btnEditUser"
            btnEditUser.HeaderText = "Edit"
            btnEditUser.Text = "Edit"
            btnEditUser.UseColumnTextForButtonValue = True
            DGView1.Columns.Add(btnEditUser)

            ' Tambah tombol Delete
            Dim btnDeleteUser As New DataGridViewButtonColumn()
            btnDeleteUser.Name = "btnHapusUser"
            btnDeleteUser.HeaderText = "Hapus"
            btnDeleteUser.Text = "hapus"
            btnDeleteUser.UseColumnTextForButtonValue = True
            DGView1.Columns.Add(btnDeleteUser)

            DGView1.DefaultCellStyle.Font = New Font("Segoe UI", 10)
            DGView1.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)

            DGView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ShowUser(DGView1)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Private Sub DGView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim columnName = DGView1.Columns(e.ColumnIndex).Name

            Select Case columnName

                Case "btnEditUser"
                    If e.RowIndex >= 0 Then
                        Dim colName = DGView1.Columns(e.ColumnIndex).Name

                        ' Periksa apakah tombol yang ditekan adalah tombol Editd
                        If colName = "btnEditUser" Then
                            ' Ambil nama dari baris yang ditekan
                            Dim nama = DGView1.Rows(e.RowIndex).Cells("nama").Value.ToString

                            ' Tampilkan nama untuk konfirmasi
                            Dim result = MessageBox.Show("Apakah Anda ingin mengedit data untuk " & nama & "?", "Konfirmasi Edit", MessageBoxButtons.YesNo)

                            If result = DialogResult.Yes Then
                                Dim row = DGView1.Rows(e.RowIndex)

                                ' Simpan semua nilai ke variable
                                Dim userData As New Dictionary(Of String, String)
                                userData("nama") = DGView1.Rows(e.RowIndex).Cells("nama").Value.ToString
                                userData("nama_pengguna") = DGView1.Rows(e.RowIndex).Cells("nama_pengguna").Value.ToString
                                userData("email") = DGView1.Rows(e.RowIndex).Cells("email").Value.ToString
                                userData("nis") = DGView1.Rows(e.RowIndex).Cells("nis").Value.ToString
                                userData("kelas_id") = DGView1.Rows(e.RowIndex).Cells("kelas_id").Value.ToString
                                userData("jenis_kelamin") = DGView1.Rows(e.RowIndex).Cells("jenis_kelamin").Value.ToString
                                userData("tanggal_lahir") = DGView1.Rows(e.RowIndex).Cells("tanggal_lahir").Value.ToString
                                userData("nama_ayah") = DGView1.Rows(e.RowIndex).Cells("nama_ayah").Value.ToString
                                userData("nama_ibu") = DGView1.Rows(e.RowIndex).Cells("nama_ibu").Value.ToString
                                userData("alamat") = DGView1.Rows(e.RowIndex).Cells("alamat").Value.ToString
                                userData("saldo") = DGView1.Rows(e.RowIndex).Cells("saldo").Value.ToString


                                ' Buka form sebagai MDI child
                                Dim formUpdate As New UpdateUser()
                                formUpdate.LoadUserData(userData)

                                Dim parentForm = CType(Me.MdiParent, Form1)
                                parentForm.OpenChildForm(formUpdate)
                            End If
                        End If
                    End If

                Case "btnHapusUser"
                    ' Cek apakah tombol Delete diklik
                    If e.ColumnIndex = DGView1.Columns("btnHapusUser").Index AndAlso e.RowIndex >= 0 Then
                        ' Ambil nilai nama_pengguna dari baris yang diklik
                        Dim nama = DGView1.Rows(e.RowIndex).Cells("Nama").Value.ToString

                        Dim result = MessageBox.Show("Hapus pengguna '" & nama & "'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If result = DialogResult.Yes Then
                            DeleteUser(nama)
                        End If
                    End If

                    ShowUser(DGView1) ' Refresh DataGridView
            End Select
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim keyword As String = txtSearch.Text.Trim()

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            If String.IsNullOrWhiteSpace(keyword) Then
                ShowUser(DGView1)
                Return
            End If

            Dim query As String = "
                        SELECT u.*, k.nama AS kelas_nama
                        FROM users u
                        JOIN user_role ur ON u.id = ur.user_id
                        JOIN roles r ON ur.role_id = r.id
                        LEFT JOIN kelas k ON u.kelas_id = k.id
                        WHERE r.nama = 'santri' AND u.deleted_at IS NULL
                        AND (u.nama LIKE @keyword OR u.nama_pengguna LIKE @keyword)
                    "

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            DGView1.Rows.Clear()

            While dr.Read
                DGView1.Rows.Add(
                        dr("nama"),
                        dr("nama_pengguna"),
                        dr("email"),
                        dr("nis"),
                        dr("kelas_nama"),
                        dr("jenis_kelamin"),
                        dr("tanggal_lahir"),
                        dr("nama_ayah"),
                        dr("nama_ibu"),
                        dr("alamat"),
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


    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim parentForm = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(MenuAdmin)
    End Sub

    Private Sub btnTambahUser_Click(sender As Object, e As EventArgs) Handles btnTambahUser.Click
        Dim parentForm = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(AddUser)
    End Sub

    Private Sub ShowUser(dgv As DataGridView)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            dgv.Rows.Clear()

            Dim query As String = "
                   SELECT 
                        u.id,
                        u.nama,
                        u.nama_pengguna,
                        u.email,
                        u.nis,
                        u.kelas_id,
                        k.nama AS kelas_nama,
                        u.jenis_kelamin,
                        u.tanggal_lahir,
                        u.nama_ayah,
                        u.nama_ibu,
                        u.alamat,
                        COALESCE(SUM(CASE WHEN dt.type = 'pemasukan' THEN dt.jumlah ELSE -dt.jumlah END), 0) AS saldo
                    FROM 
                        users u
                    JOIN 
                        user_role ur ON u.id = ur.user_id
                    JOIN 
                        roles r ON ur.role_id = r.id
                    LEFT JOIN 
                        kelas k ON u.kelas_id = k.id
                    LEFT JOIN 
                        transaksi t ON u.id = t.pengguna_id
                    LEFT JOIN 
                        detail_transaksi dt ON t.id = dt.transaksi_id
                    WHERE 
                        r.nama = 'santri' 
                        AND u.deleted_at IS NULL
                    GROUP BY  
                        u.id
    
                "

            Dim cmd As New MySqlCommand(query, conn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            While dr.Read
                dgv.Rows.Add(
                        dr("nama"),
                        dr("nama_pengguna"),
                        dr("email"),
                        dr("nis"),
                        dr("kelas_nama"),
                        dr("jenis_kelamin"),
                        dr("tanggal_lahir"),
                        dr("nama_ayah"),
                        dr("nama_ibu"),
                        dr("alamat"),
                        dr("saldo"),
                        Nothing, Nothing
                    )
            End While

            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data user: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Private Sub DeleteUser(nama As String)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Cek apakah user adalah santri
            Dim checkQuery As String = "
                    SELECT u.id 
                    FROM users u
                    JOIN user_role ur ON u.id = ur.user_id
                    JOIN roles r ON ur.role_id = r.id
                    WHERE u.nama = @nama AND r.nama = 'santri' AND u.deleted_at IS NULL
                "

            Dim checkCmd As New MySqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@nama", nama)

            Dim userIdObj = checkCmd.ExecuteScalar()

            If userIdObj Is Nothing Then
                MessageBox.Show("User bukan santri atau sudah dihapus.", "Tidak Dapat Dihapus", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Soft delete user dengan update deleted_at
            Dim deleteQuery As String = "UPDATE users SET deleted_at = NOW() WHERE nama = @nama"
            Dim deleteCmd As New MySqlCommand(deleteQuery, conn)
            deleteCmd.Parameters.AddWithValue("@nama", nama)

            Dim result As Integer = deleteCmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("User berhasil dihapus (soft delete).", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ShowUser(DGView1) ' Refresh tampilan
            Else
                MessageBox.Show("User gagal dihapus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menghapus user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub
End Class