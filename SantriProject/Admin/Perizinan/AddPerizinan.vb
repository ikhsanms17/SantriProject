Imports MySql.Data.MySqlClient

Public Class AddPerizinan
    Private Sub AddPerizinan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form agar bisa di-resize
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight

        ResizeControls(Me, scaleX, scaleY)

        LoadUser(cmbUser)
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Dim result = MessageBox.Show("Yakin untuk kembali? Data saat ini tidak akan disimpan.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim parentForm = CType(MdiParent, Form1)
            parentForm.OpenChildForm(New PerizinanAdmin)
            Close()
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        ' Ambil data dari form
        Dim pengguna_id As String = cmbUser.SelectedValue.ToString()
        Dim nama_penjemput As String = txt_nama_penjemput.Text.Trim()
        Dim hubungan As String = txtHubungan.Text.Trim()
        Dim keperluan As String = txtKeperluan.Text.Trim()
        Dim alamat_tujuan As String = txtAlamatTujuan.Text.Trim()
        Dim tanggal_izin As String = dtpIzin.Value.ToString("yyyy-MM-dd")
        Dim tanggal_batas_izin As String = dtpBatasIzin.Value.ToString("yyyy-MM-dd")
        Dim tanggal_datang As String = dtpDatang.Value.ToString("yyyy-MM-dd")

        Dim conn = Database.GetConnection()
        Dim no_izin As String = ""

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Ambil ID terakhir + 1 untuk format no_izin
            Dim idQuery As String = "SELECT IFNULL(MAX(id), 0) + 1 FROM perizinan"
            Dim idCmd As New MySqlCommand(idQuery, conn)
            Dim nextId As Integer = Convert.ToInt32(idCmd.ExecuteScalar())
            Dim tanggalSekarang As String = DateTime.Now.ToString("yyyyMMdd")
            no_izin = nextId.ToString() & "/IZN/PS/" & tanggalSekarang

            ' Konfirmasi data
            Dim konfirmasi As String = "Apakah Anda yakin ingin menyimpan data berikut?" & vbCrLf & vbCrLf &
                "No Izin: " & no_izin & vbCrLf &
                "Pengguna ID: " & pengguna_id & " (" & cmbUser.Text & ")" & vbCrLf &
                "Nama Penjemput: " & nama_penjemput & vbCrLf &
                "Tanggal Izin: " & tanggal_izin & vbCrLf &
                "Tanggal Batas Izin: " & tanggal_batas_izin & vbCrLf &
                "Tanggal Datang: " & tanggal_datang & vbCrLf &
                "Hubungan: " & hubungan & vbCrLf &
                "Keperluan: " & keperluan & vbCrLf &
                "Alamat Tujuan: " & alamat_tujuan

            Dim result As DialogResult = MessageBox.Show(konfirmasi, "Konfirmasi Simpan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then Exit Sub

            ' Simpan ke tabel perizinan
            Dim queryPerizinan As String = "
            INSERT INTO perizinan (
                no_izin, pengguna_id, tanggal_izin, nama_penjemput,
                tanggal_batas_izin, tanggal_datang, status,
                created_at, updated_at
            ) VALUES (
                @no_izin, @pengguna_id, @tanggal_izin, @nama_penjemput,
                @tanggal_batas_izin, @tanggal_datang, 'Menunggu',
                CURRENT_TIMESTAMP, CURRENT_TIMESTAMP
            )"
            Dim cmd1 As New MySqlCommand(queryPerizinan, conn)
            cmd1.Parameters.AddWithValue("@no_izin", no_izin)
            cmd1.Parameters.AddWithValue("@pengguna_id", pengguna_id)
            cmd1.Parameters.AddWithValue("@tanggal_izin", tanggal_izin)
            cmd1.Parameters.AddWithValue("@nama_penjemput", nama_penjemput)
            cmd1.Parameters.AddWithValue("@tanggal_batas_izin", tanggal_batas_izin)
            cmd1.Parameters.AddWithValue("@tanggal_datang", tanggal_datang)
            cmd1.ExecuteNonQuery()

            ' Simpan ke tabel detail_perizinan
            Dim queryDetail As String = "
            INSERT INTO detail_perizinan (
                no_izin, hubungan, keperluan, alamat_tujuan,
                created_at, updated_at
            ) VALUES (
                @no_izin, @hubungan, @keperluan, @alamat_tujuan,
                CURRENT_TIMESTAMP, CURRENT_TIMESTAMP
            )"
            Dim cmd2 As New MySqlCommand(queryDetail, conn)
            cmd2.Parameters.AddWithValue("@no_izin", no_izin)
            cmd2.Parameters.AddWithValue("@hubungan", hubungan)
            cmd2.Parameters.AddWithValue("@keperluan", keperluan)
            cmd2.Parameters.AddWithValue("@alamat_tujuan", alamat_tujuan)
            cmd2.ExecuteNonQuery()

            MessageBox.Show("Data perizinan dan detail berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Database.CloseConnection(conn)
        End Try

        Dim parentForm = CType(MdiParent, Form1)
        parentForm.OpenChildForm(New PerizinanAdmin)
    End Sub

End Class