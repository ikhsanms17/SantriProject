Imports MySql.Data.MySqlClient

Public Class AddTransaksi
    Private Sub AddTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight

        ResizeControls(Me, scaleX, scaleY)
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        ' Ambil data dari form
        Dim petugas_id As String = cmbPetugas.SelectedValue.ToString()
        Dim pengguna_id As String = cmbUser.SelectedValue.ToString()
        Dim tanggal_transaksi As String = dtpTanggalTransaksi.ToString("yyyy-MM-dd")
        Dim type_transaksi As String = cmbMetode.Text.Trim()
        Dim jumlah As String = txtJumlah.Text.Trim()
        Dim type As String = cmbJenisTr.Text.Trim()
        Dim image_bukti As String = txtFilename.Text.ToString()
        Dim keterangan As String = txtKeterangan.Text.ToString()

        Dim conn = Database.GetConnection()
        Dim no_transaksi As String = ""

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Ambil ID terakhir + 1 untuk format no_izin
            Dim idQuery As String = "SELECT IFNULL(MAX(id), 0) + 1 FROM perizinan"
            Dim idCmd As New MySqlCommand(idQuery, conn)
            Dim nextId As Integer = Convert.ToInt32(idCmd.ExecuteScalar())
            Dim tanggalSekarang As String = DateTime.Now.ToString("yyyyMMdd")
            no_transaksi = "TR/" & nextId.ToString() & "/" & tanggalSekarang

            ' Konfirmasi data
            Dim konfirmasi As String = "Apakah Anda yakin ingin menyimpan data berikut?" & vbCrLf & vbCrLf &
                "No Transaksi: " & no_transaksi & vbCrLf &
                "Petugas ID: " & petugas_id & " (" & cmbPetugas.Text & ")" & vbCrLf &
                "Pengguna ID: " & pengguna_id & " (" & cmbUser.Text & ")" & vbCrLf &
                "Tanggal Transaksi: " & tanggal_transaksi & vbCrLf &
                "Metode Transaksi: " & type_transaksi & vbCrLf &
                "Jumlah: " & jumlah & vbCrLf &
                "Jenis Transaksi: " & type & vbCrLf &
                "Gambar Bukti: " & image_bukti & vbCrLf &
                "Keterangan: " & keterangan

            Dim result As DialogResult = MessageBox.Show(konfirmasi, "Konfirmasi Simpan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then Exit Sub

            ' Simpan ke tabel perizinan
            Dim queryTransaksi As String = "
            INSERT INTO perizinan (
                no_transaksi, tanggal_transaksi, type_pembayaran,
                petugas_id, pengguna_id, created_at, updated_at
            ) VALUES (
                @no_transaksi, @tanggal_transaksi, @type_transaksi, 
                @petugas_id, @pegguna_id, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP
            )"
            Dim cmd1 As New MySqlCommand(queryTransaksi, conn)
            cmd1.Parameters.AddWithValue("@no_transaksi", no_transaksi)
            cmd1.Parameters.AddWithValue("@tanggal_transaksi", tanggal_transaksi)
            cmd1.Parameters.AddWithValue("@type_transaksi", type_transaksi)
            cmd1.Parameters.AddWithValue("@pengguna_id", pengguna_id)
            cmd1.Parameters.AddWithValue("@petugas_id", petugas_id)
            cmd1.ExecuteNonQuery()

            ' Simpan ke tabel detail_perizinan
            Dim queryDetail As String = "
            INSERT INTO detail_perizinan (
                no_transaksi, jumlah, type, image_bukti, keterangan, created_at, updated_at
            ) VALUES (
                @no_transaksi, @jumlah, @type, @image_bukti, @keterangan, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP
            )"
            Dim cmd2 As New MySqlCommand(queryDetail, conn)
            cmd2.Parameters.AddWithValue("@no_transaksi", no_transaksi)
            cmd2.Parameters.AddWithValue("@jumlah", jumlah)
            cmd2.Parameters.AddWithValue("@type", type)
            cmd2.Parameters.AddWithValue("@image_bukti", image_bukti)
            cmd2.Parameters.AddWithValue("@keterangan", keterangan)
            cmd2.ExecuteNonQuery()

            MessageBox.Show("Data transaksi dan detail berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Database.CloseConnection(conn)
        End Try

        Dim parentForm = CType(MdiParent, Form1)
        parentForm.OpenChildForm(New TransaksiAdmin)
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        UploadGambar(txtFilename)
    End Sub

    Private Sub LoadUser(cmbUser As ComboBox)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim cmd As New MySqlCommand("SELECT id, nama FROM kelas ORDER BY id ASC", conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            adapter.Fill(dt)

            cmbUser.DataSource = dt
            cmbUser.DisplayMember = "nama"
            cmbUser.ValueMember = "id"

        Catch ex As Exception
            MsgBox("Gagal load data kelas: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Private Sub LoadPetugas()

    End Sub

    Private Sub LoadJenisTransaksi(cmbJenisTransaksi As ComboBox)
        cmbJenisTransaksi.Items.Clear()
        cmbJenisTransaksi.Items.Add("Pemasukan")
        cmbJenisTransaksi.Items.Add("Pengeluaran")
    End Sub

    Private Sub LoadMetode(cmdMetode As ComboBox)
        cmdMetode.Items.Clear()
        cmdMetode.Items.Add("Cash")
        cmdMetode.Items.Add("Bank")
    End Sub
End Class