Imports MySql.Data.MySqlClient

Public Class AddUser
    Dim conn As MySqlConnection = Database.GetConnection()
    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form agar bisa di-resize
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight

        ResizeControls(Me, scaleX, scaleY)

        cmbJenisKelamin.Items.Clear()
        cmbJenisKelamin.Items.Add("Laki-laki")
        cmbJenisKelamin.Items.Add("Perempuan")

        LoadKelas(cmbKelas)
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
    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim result As DialogResult = MessageBox.Show("Yakin untuk kembali? Data saat ini tidak akan disimpan.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
            parentForm.OpenChildForm(New UserManagementAdmin())
            Me.Close()
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim nama As String = txtNama.Text.Trim()
        Dim username As String = txtNamaPengguna.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim nis As String = txtNis.Text.Trim()
        Dim kelas_id As String = cmbKelas.SelectedValue.ToString()
        Dim jenis_kelamin As String = cmbJenisKelamin.Text
        Dim tgl_lahir As String = txtTanggalLahir.Value.ToString("yyyy-MM-dd")
        Dim nama_ayah As String = txtAyah.Text.Trim()
        Dim nama_ibu As String = txtIbu.Text.Trim()
        Dim alamat As String = txtAlamat.Text.Trim()

        Dim konfirmasi As String = "Apakah Anda yakin ingin menyimpan data berikut?" & vbCrLf & vbCrLf &
        "Nama: " & nama & vbCrLf &
        "Username: " & username & vbCrLf &
        "Email: " & email & vbCrLf &
        "NIS: " & nis & vbCrLf &
        "Kelas: " & cmbKelas.Text & vbCrLf &
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

            ' Simpan user
            Dim queryUser As String = "INSERT INTO users (nama, nama_pengguna, email, kata_sandi, nis, kelas_id, jenis_kelamin, tanggal_lahir, nama_ayah, nama_ibu, alamat) 
                                       VALUES (@nama, @nama_pengguna, @email, SHA2(@nama_pengguna, 256), @nis, @kelas_id, @jenis_kelamin, @tanggal_lahir, @nama_ayah, @nama_ibu, @alamat)"
            Dim cmdUser As New MySqlCommand(queryUser, conn)

            cmdUser.Parameters.AddWithValue("@nama", txtNama.Text)
            cmdUser.Parameters.AddWithValue("@nama_pengguna", txtNamaPengguna.Text)
            cmdUser.Parameters.AddWithValue("@email", txtEmail.Text)
            cmdUser.Parameters.AddWithValue("@nis", txtNis.Text)
            cmdUser.Parameters.AddWithValue("@kelas_id", Convert.ToInt32(cmbKelas.SelectedValue))
            cmdUser.Parameters.AddWithValue("@jenis_kelamin", cmbJenisKelamin.Text)
            cmdUser.Parameters.AddWithValue("@tanggal_lahir", txtTanggalLahir.Value.ToString("yyyy-MM-dd"))
            cmdUser.Parameters.AddWithValue("@nama_ayah", txtAyah.Text)
            cmdUser.Parameters.AddWithValue("@nama_ibu", txtIbu.Text)
            cmdUser.Parameters.AddWithValue("@alamat", txtAlamat.Text)

            cmdUser.ExecuteNonQuery()

            ' Ambil ID user terakhir
            Dim userId As Integer
            Dim cmdLastId As New MySqlCommand("SELECT LAST_INSERT_ID()", conn)
            userId = Convert.ToInt32(cmdLastId.ExecuteScalar())

            ' Cari role_id untuk 'santri'
            Dim roleId As Integer
            Dim cmdRole As New MySqlCommand("SELECT id FROM roles WHERE nama = 'santri' AND deleted_at IS NULL", conn)
            roleId = Convert.ToInt32(cmdRole.ExecuteScalar())

            ' Masukkan ke tabel user_role
            Dim cmdRoleInsert As New MySqlCommand("INSERT INTO user_role (user_id, role_id) VALUES (@user_id, @role_id)", conn)
            cmdRoleInsert.Parameters.AddWithValue("@user_id", userId)
            cmdRoleInsert.Parameters.AddWithValue("@role_id", roleId)
            cmdRoleInsert.ExecuteNonQuery()

            MessageBox.Show("User berhasil disimpan dengan role santri.")

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try

        Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(New UserManagementAdmin)
    End Sub
End Class