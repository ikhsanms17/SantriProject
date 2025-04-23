Imports MySql.Data.MySqlClient
Imports System.IO

Public Class AddTransaksi
    Private Sub AddTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form agar bisa di-resize
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight

        ResizeControls(Me, scaleX, scaleY)

        ' Load Petugas and Santri data into ComboBoxes
        LoadPetugas(cmbPetugas)
        LoadSantri(cmbSantri)
        LoadMetode(cmbMetode)
        LoadJenisTransaksi(cmbJenisTr)
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Dim result = MessageBox.Show("Yakin untuk kembali? Data saat ini tidak akan disimpan.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim parentForm = CType(MdiParent, Form1)
            parentForm.OpenChildForm(New TransaksiAdmin)
            Close()
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        ' Ambil data dari form
        Dim petugas_id As String = cmbPetugas.SelectedValue.ToString()
        Dim pengguna_id As String = cmbSantri.SelectedValue.ToString()
        Dim tanggal_transaksi As String = dtpTanggalTransaksi.Value.ToString("yyyy-MM-dd")
        Dim type_pembayaran As String = cmbMetode.Text.Trim()
        Dim jumlah As String = txtJumlah.Text.Trim()
        Dim type As String = cmbJenisTr.Text.Trim()
        Dim image_bukti As String = txtFilename.Text.ToString()
        Dim keterangan As String = txtKeterangan.Text.ToString()

        ' Tentukan folder tujuan untuk menyimpan file
        Dim folderPath As String = Path.Combine(Application.StartupPath, "BuktiTransaksi")

        ' Periksa apakah folder "BuktiTransaksi" ada, jika belum buat foldernya
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If

        ' Pastikan ada file yang dipilih
        If Not String.IsNullOrEmpty(image_bukti) Then
            ' Tentukan path file tujuan untuk disalin ke folder "BuktiTransaksi"
            Dim fileName As String = Path.GetFileName(image_bukti)
            Dim destinationPath As String = Path.Combine(folderPath, fileName)

            ' Pindahkan file ke folder tujuan
            Try
                ' Salin file ke folder tujuan jika file belum ada di folder tersebut
                If Not File.Exists(destinationPath) Then
                    File.Copy(image_bukti, destinationPath)
                End If

                ' Setelah file dipindahkan, simpan path file yang disalin ke database
                image_bukti = Path.Combine("BuktiTransaksi", fileName)
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Else
            ' Jika tidak ada file yang dipilih, beri pesan kesalahan
            MessageBox.Show("Harap pilih file bukti transaksi terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Koneksi database
        Dim conn = Database.GetConnection()
        Dim no_transaksi As String = ""

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Ambil ID terakhir + 1 untuk format no_transaksi
            Dim idQuery As String = "SELECT IFNULL(MAX(id), 0) + 1 FROM transaksi"
            Dim idCmd As New MySqlCommand(idQuery, conn)
            Dim nextId As Integer = Convert.ToInt32(idCmd.ExecuteScalar())
            Dim tanggalSekarang As String = DateTime.Now.ToString("yyyyMMdd")
            no_transaksi = "TR/" & nextId.ToString() & "/" & tanggalSekarang

            ' Konfirmasi data
            Dim konfirmasi As String = "Apakah Anda yakin ingin menyimpan data berikut?" & vbCrLf & vbCrLf &
            "No Transaksi: " & no_transaksi & vbCrLf &
            "Petugas ID: " & petugas_id & " (" & cmbPetugas.Text & ")" & vbCrLf &
            "Santri ID: " & pengguna_id & " (" & cmbSantri.Text & ")" & vbCrLf &
            "Tanggal Transaksi: " & tanggal_transaksi & vbCrLf &
            "Metode Transaksi: " & type_pembayaran & vbCrLf &
            "Jumlah: " & jumlah & vbCrLf &
            "Jenis Transaksi: " & type & vbCrLf &
            "Gambar Bukti: " & image_bukti & vbCrLf &
            "Keterangan: " & keterangan

            Dim result As DialogResult = MessageBox.Show(konfirmasi, "Konfirmasi Simpan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then Exit Sub

            ' Simpan ke tabel transaksi
            Dim queryTransaksi As String = "
            INSERT INTO transaksi (
                no_transaksi, tanggal_transaksi, type_pembayaran,
                petugas_id, pengguna_id, created_at, updated_at
            ) VALUES (
                @no_transaksi, @tanggal_transaksi, @type_pembayaran, 
                @petugas_id, @pengguna_id, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP
            )"
            Dim cmd1 As New MySqlCommand(queryTransaksi, conn)
            cmd1.Parameters.AddWithValue("@no_transaksi", no_transaksi)
            cmd1.Parameters.AddWithValue("@tanggal_transaksi", tanggal_transaksi)
            cmd1.Parameters.AddWithValue("@type_pembayaran", type_pembayaran)
            cmd1.Parameters.AddWithValue("@petugas_id", petugas_id)
            cmd1.Parameters.AddWithValue("@pengguna_id", pengguna_id)
            cmd1.ExecuteNonQuery()

            ' Ambil transaksi_id yang baru saja dimasukkan
            Dim queryGetTransaksiId As String = "SELECT LAST_INSERT_ID()"
            Dim cmdGetTransaksiId As New MySqlCommand(queryGetTransaksiId, conn)
            Dim transaksi_id As Integer = Convert.ToInt32(cmdGetTransaksiId.ExecuteScalar())

            ' Simpan ke tabel detail_transaksi
            Dim queryDetail As String = "
            INSERT INTO detail_transaksi (
                transaksi_id, jumlah, type, image_bukti, keterangan, created_at, updated_at
            ) VALUES (
                @transaksi_id, @jumlah, @type, @image_bukti, @keterangan, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP
            )"
            Dim cmd2 As New MySqlCommand(queryDetail, conn)
            cmd2.Parameters.AddWithValue("@transaksi_id", transaksi_id)
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

    Private Sub LoadPetugas(cmbPetugas As ComboBox)
        ' Load petugas from database
        Dim conn = Database.GetConnection()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "
                SELECT u.id, u.nama
                FROM users u
                JOIN user_role ru ON u.id = ru.user_id
                JOIN roles r ON ru.role_id = r.id
                WHERE r.id = 1 AND u.deleted_at IS NULL AND ru.deleted_at IS NULL AND r.deleted_at IS NULL"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            cmbPetugas.DataSource = dt
            cmbPetugas.DisplayMember = "nama"
            cmbPetugas.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("Error loading petugas: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Private Sub LoadSantri(cmbSantri As ComboBox)
        ' Load santri from database
        Dim conn = Database.GetConnection()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "
            SELECT u.id, u.nama
                FROM users u
                JOIN user_role ru ON u.id = ru.user_id
                JOIN roles r ON ru.role_id = r.id
                WHERE r.id = 3 AND u.deleted_at IS NULL AND ru.deleted_at IS NULL AND r.deleted_at IS NULL"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            cmbSantri.DataSource = dt
            cmbSantri.DisplayMember = "nama"
            cmbSantri.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("Error loading santri: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Private Sub LoadMetode(cmbMetode As ComboBox)
        cmbMetode.Items.Clear()
        cmbMetode.Items.Add("Cash")
        cmbMetode.Items.Add("Bank")
        cmbMetode.SelectedIndex = 0 ' Pilih default "Cash"
    End Sub

    Private Sub LoadJenisTransaksi(cmbJenisTransaksi As ComboBox)
        cmbJenisTransaksi.Items.Clear()
        cmbJenisTransaksi.Items.Add("Pemasukan")
        cmbJenisTransaksi.Items.Add("Pengeluaran")
        cmbJenisTransaksi.SelectedIndex = 0 ' Pilih default "Pemasukan"
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        ' Membuka dialog file untuk memilih file
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif|All Files|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Ambil nama file
            Dim fileName As String = Path.GetFileName(openFileDialog.FileName)

            ' Tentukan folder tujuan secara dinamis
            Dim folderPath As String = Path.Combine(Application.StartupPath, "BuktiTransaksi")

            ' Periksa apakah folder tujuan ada, jika belum buat foldernya
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If

            ' Tentukan path tujuan di folder tujuan
            Dim destinationPath As String = Path.Combine(folderPath, fileName)

            ' Pastikan file tidak ada sebelumnya di folder tujuan
            If Not File.Exists(destinationPath) Then
                Try
                    ' Salin file ke folder tujuan
                    File.Copy(openFileDialog.FileName, destinationPath)
                    ' Simpan path relatif atau absolut sesuai kebutuhan
                    txtFilename.Text = destinationPath ' Atau fileName jika hanya nama yang ingin disimpan
                    MessageBox.Show("File berhasil diunggah ke: " & destinationPath, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Gagal menyimpan file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                ' Jika file sudah ada, beri pesan peringatan
                MessageBox.Show("File sudah ada di folder tujuan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
End Class
