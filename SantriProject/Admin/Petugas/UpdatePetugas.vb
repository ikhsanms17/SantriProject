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

    Public Sub LoadRoles(cmbRoles As ComboBox)
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
End Class