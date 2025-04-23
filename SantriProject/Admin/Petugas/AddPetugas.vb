Imports MySql.Data.MySqlClient

Public Class AddPetugas
    Private Sub AddPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim nama As String = txtNama.Text.Trim()
        Dim username As String = txtNamaPengguna.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim jenis_kelamin As String = cmbJenisKelamin.Text
        Dim tgl_lahir As String = dtpTanggalLahir.Value.ToString("yyyy-MM-dd")
        Dim alamat As String = txtAlamat.Text.Trim()
        Dim role As String = cmbRole.SelectedValue.ToString()

        Dim konfirmasi As String = "Apakah Anda yakin ingin menyimpan data berikut?" & vbCrLf & vbCrLf &
        "Nama: " & nama & vbCrLf &
        "Username: " & username & vbCrLf &
        "Email: " & email & vbCrLf &
        "Jenis Kelamin: " & jenis_kelamin & vbCrLf &
        "Tanggal Lahir: " & tgl_lahir & vbCrLf &
        "Alamat: " & alamat & vbCrLf &
        "Role: " & cmbRole.Text

        Dim result As DialogResult = MessageBox.Show(konfirmasi, "Konfirmasi Simpan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            Exit Sub ' Batal menyimpan
        End If

        ' Simpan ke database
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Simpan data ke tabel users
            Dim queryUser As String = "
                INSERT INTO users 
                    (nama, nama_pengguna, email, kata_sandi, nis, kelas_id, jenis_kelamin, tanggal_lahir, nama_ayah, nama_ibu, alamat)
                VALUES 
                    (@nama, @nama_pengguna, @email, SHA2(@password, 256), NULL, NULL, @jenis_kelamin, @tanggal_lahir, null, null, @alamat)
            "

            Dim cmdUser As New MySqlCommand(queryUser, conn)
            cmdUser.Parameters.AddWithValue("@nama", txtNama.Text)
            cmdUser.Parameters.AddWithValue("@nama_pengguna", txtNamaPengguna.Text)
            cmdUser.Parameters.AddWithValue("@email", txtEmail.Text)
            cmdUser.Parameters.AddWithValue("@password", txtPassword.Text)
            cmdUser.Parameters.AddWithValue("@jenis_kelamin", cmbJenisKelamin.Text)
            cmdUser.Parameters.AddWithValue("@tanggal_lahir", dtpTanggalLahir.Value.ToString("yyyy-MM-dd"))
            cmdUser.Parameters.AddWithValue("@alamat", txtAlamat.Text)

            cmdUser.ExecuteNonQuery()

            ' Ambil ID user yang baru saja dimasukkan
            Dim userId As Integer
            Dim cmdLastId As New MySqlCommand("SELECT LAST_INSERT_ID()", conn)
            userId = Convert.ToInt32(cmdLastId.ExecuteScalar())

            ' Ambil role_id dari ComboBox
            Dim selectedRoleId As Integer = Convert.ToInt32(cmbRole.SelectedValue)

            ' Masukkan ke tabel user_role
            Dim cmdUserRole As New MySqlCommand("INSERT INTO user_role (user_id, role_id) VALUES (@user_id, @role_id)", conn)
            cmdUserRole.Parameters.AddWithValue("@user_id", userId)
            cmdUserRole.Parameters.AddWithValue("@role_id", selectedRoleId)
            cmdUserRole.ExecuteNonQuery()

            MessageBox.Show("User berhasil disimpan dengan role: " & cmbRole.Text)

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try

        ' Refresh form setelah berhasil menyimpan
        Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(New Petugas)

    End Sub
End Class