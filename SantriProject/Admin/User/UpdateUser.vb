Imports MySql.Data.MySqlClient

Public Class UpdateUser
    Private selectedUsername As String = ""

    Private Sub UpdateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form agar bisa di-resize
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight

        ResizeControls(Me, scaleX, scaleY)

        cmb_jenis_kelamin.Items.Clear()
        cmb_jenis_kelamin.Items.Add("Laki-laki")
        cmb_jenis_kelamin.Items.Add("Perempuan")

        LoadKelas(cmb_kelas)
    End Sub

    Private Sub LoadKelas(cmb_kelas As ComboBox)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim cmd As New MySqlCommand("SELECT id, nama FROM kelas ORDER BY id ASC", conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            adapter.Fill(dt)

            cmb_kelas.DataSource = dt
            cmb_kelas.DisplayMember = "nama"
            cmb_kelas.ValueMember = "id"

        Catch ex As Exception
            MsgBox("Gagal load data kelas: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Dim result = MessageBox.Show("Yakin untuk kembali? Perubahan data saat ini tidak akan disimpan.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim parentForm = CType(MdiParent, Form1)
            parentForm.OpenChildForm(New UserManagementAdmin)
            Close()
        End If
    End Sub

    Public Sub LoadUserData(userData As Dictionary(Of String, String))
        txt_nama.Text = userData("nama")
        txt_username.Text = userData("nama_pengguna")
        txt_email.Text = userData("email")
        txt_nis.Text = userData("nis")
        cmb_kelas.Text = userData("kelas_id")
        cmb_jenis_kelamin.Text = userData("jenis_kelamin")
        txt_tgl_lahir.Text = userData("tanggal_lahir")
        txt_nama_ayah.Text = userData("nama_ayah")
        txt_nama_ibu.Text = userData("nama_ibu")
        txt_alamat.Text = userData("alamat")

        ' Simpan ID atau username lama sebagai referensi update
        selectedUsername = userData("nama_pengguna")
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Try
            conn.Open()
            Dim query As String = "
                UPDATE users 
                INNER JOIN user_role ON users.id = user_role.user_id
                INNER JOIN roles ON user_role.role_id = roles.id
                SET 
                    users.nama = @nama,
                    users.nama_pengguna = @username,
                    users.email = @email,
                    users.nis = @nis,
                    users.kelas_id = @kelas_id,
                    users.jenis_kelamin = @jenis_kelamin,
                    users.tanggal_lahir = @tgl_lahir,
                    users.nama_ayah = @nama_ayah,
                    users.nama_ibu = @nama_ibu,
                    users.alamat = @alamat,
                    users.updated_at = CURRENT_TIMESTAMP
                WHERE users.nama_pengguna = @old_username
                AND roles.nama = 'santri'
                AND roles.deleted_at IS NULL;
            "

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nama", txt_nama.Text.Trim())
            cmd.Parameters.AddWithValue("@username", txt_username.Text.Trim())
            cmd.Parameters.AddWithValue("@email", txt_email.Text.Trim())
            cmd.Parameters.AddWithValue("@nis", txt_nis.Text.Trim())
            cmd.Parameters.AddWithValue("@kelas_id", cmb_kelas.SelectedValue)
            cmd.Parameters.AddWithValue("@jenis_kelamin", cmb_jenis_kelamin.Text.Trim())
            cmd.Parameters.AddWithValue("@tgl_lahir", txt_tgl_lahir.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@nama_ayah", txt_nama_ayah.Text.Trim())
            cmd.Parameters.AddWithValue("@nama_ibu", txt_nama_ibu.Text.Trim())
            cmd.Parameters.AddWithValue("@alamat", txt_alamat.Text.Trim())
            cmd.Parameters.AddWithValue("@old_username", selectedUsername)

            Dim affectedRows As Integer = cmd.ExecuteNonQuery()

            If affectedRows > 0 Then
                MessageBox.Show("Data pengguna berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Tidak ada data yang diperbarui. Mungkin user bukan 'santri'.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox("Gagal memperbarui user: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try

        Dim parentForm = CType(MdiParent, Form1)
        parentForm.OpenChildForm(New UserManagementAdmin)
    End Sub

End Class