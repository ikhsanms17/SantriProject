Imports MySql.Data.MySqlClient

Public Class UpdatePetugas

    Private selectedUsername As String = ""

    Private Sub UpdatePetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form agar bisa di-resize
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight

        ResizeControls(Me, scaleX, scaleY)

        cmbJenisKelamin.Items.Clear()
        cmbJenisKelamin.Items.Add("Laki-laki")
        cmbJenisKelamin.Items.Add("Perempuan")

        LoadRoles(cmbRole)
    End Sub

    Public Sub LoadPetugasData(userData As Dictionary(Of String, String))
        txtNama.Text = userData("nama")
        txtNamaPengguna.Text = userData("nama_pengguna")
        txtEmail.Text = userData("email")
        cmbJenisKelamin.Text = userData("jenis_kelamin")
        dtpTanggalLahir.Text = userData("tanggal_lahir")
        txtAlamat.Text = userData("alamat")
        cmbRole.Text = userData("role")

        ' Simpan ID atau username lama sebagai referensi update
        selectedUsername = userData("nama_pengguna")
    End Sub

    Private Sub LoadRoles(cmbRoles As ComboBox)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim cmd As New MySqlCommand("SELECT id, nama FROM roles ORDER BY id ASC", conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            adapter.Fill(dt)

            cmbRoles.DataSource = dt
            cmbRoles.DisplayMember = "nama"
            cmbRoles.ValueMember = "id"

        Catch ex As Exception
            MsgBox("Gagal load data kelas: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim parentForm = CType(MdiParent, Form1)
        parentForm.OpenChildForm(Petugas)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Ambil role_id dari nama role yang dipilih
            Dim roleIdQuery As String = "SELECT id FROM roles WHERE nama = @role AND deleted_at IS NULL"
            Dim cmdRole As New MySqlCommand(roleIdQuery, conn)
            cmdRole.Parameters.AddWithValue("@role", cmbRole.Text.Trim())
            Dim selectedRoleId As Object = cmdRole.ExecuteScalar()

            If selectedRoleId Is Nothing Then
                MessageBox.Show("Role tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Update data user
            Dim updateUserQuery As String = "
                UPDATE users 
                INNER JOIN user_role ON users.id = user_role.user_id
                INNER JOIN roles ON user_role.role_id = roles.id
                SET 
                    users.nama = @nama,
                    users.nama_pengguna = @username,
                    users.email = @email,
                    users.kata_sandi = SHA2(@password, 256),
                    users.jenis_kelamin = @jenis_kelamin,
                    users.tanggal_lahir = @tgl_lahir,
                    users.alamat = @alamat,
                    users.nis = NULL,
                    users.kelas_id = NULL,
                    users.nama_ayah = NULL,
                    users.nama_ibu = NULL,
                    users.updated_at = CURRENT_TIMESTAMP
                WHERE users.nama_pengguna = @old_username
                AND roles.deleted_at IS NULL;
            "

            Dim cmd As New MySqlCommand(updateUserQuery, conn)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim())
            cmd.Parameters.AddWithValue("@username", txtNamaPengguna.Text.Trim())
            cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
            cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())
            cmd.Parameters.AddWithValue("@jenis_kelamin", cmbJenisKelamin.Text.Trim())
            cmd.Parameters.AddWithValue("@tgl_lahir", dtpTanggalLahir.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text.Trim())
            cmd.Parameters.AddWithValue("@old_username", selectedUsername)

            Dim affectedRows As Integer = cmd.ExecuteNonQuery()

            ' Update role di user_role
            Dim updateRoleQuery As String = "
                UPDATE user_role 
                SET role_id = @new_role_id 
                WHERE user_id = (SELECT id FROM users WHERE nama_pengguna = @old_username LIMIT 1)
            "
            Dim cmdUpdateRole As New MySqlCommand(updateRoleQuery, conn)
            cmdUpdateRole.Parameters.AddWithValue("@new_role_id", selectedRoleId)
            cmdUpdateRole.Parameters.AddWithValue("@old_username", selectedUsername)
            cmdUpdateRole.ExecuteNonQuery()

            If affectedRows > 0 Then
                MessageBox.Show("Data pengguna dan role berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Tidak ada data yang diperbarui.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Gagal memperbarui user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Database.CloseConnection(conn)
        End Try

        ' Refresh ke form sebelumnya
        Dim parentForm = CType(MdiParent, Form1)
        parentForm.OpenChildForm(New Petugas)
    End Sub
End Class