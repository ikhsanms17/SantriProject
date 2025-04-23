Imports MySql.Data.MySqlClient

Public Class UpdatePerizinan
    'Private selectedNoIzin As String = ""
    Public selectedNoIzin As String

    Private Sub UpdatePerizinan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form agar bisa di-resize
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight

        ResizeControls(Me, scaleX, scaleY)

        LoadUser(cmbUser)
    End Sub

    Public Sub LoadIzinData(userData As Dictionary(Of String, String))
        ' Load data ke form
        dtpIzin.Value = Convert.ToDateTime(userData("tanggal_izin"))
        txt_nama_penjemput.Text = userData("nama_penjemput")
        txtHubungan.Text = userData("hubungan")
        txtKeperluan.Text = userData("keperluan")
        txtAlamatTujuan.Text = userData("alamat_tujuan")
        dtpBatasIzin.Value = Convert.ToDateTime(userData("tanggal_batas_izin"))
        dtpDatang.Value = Convert.ToDateTime(userData("tanggal_datang"))

        ' Load user dan pilih pengguna_id ke ComboBox
        LoadUser(cmbUser) ' Pastikan ini sudah set DisplayMember dan ValueMember
        Application.DoEvents()

        Dim penggunaId As String = userData("pengguna_id")

        If cmbUser.Items.Count > 0 Then
            cmbUser.SelectedValue = penggunaId ' Ini akan cari dan tampilkan nama pengguna dengan ID tsb
        End If

        selectedNoIzin = userData("no_izin")
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Dim result = MessageBox.Show("Yakin untuk kembali? Data saat ini tidak akan disimpan.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim parentForm = CType(MdiParent, Form1)
            parentForm.OpenChildForm(New PerizinanAdmin)
            Close()
        End If
    End Sub

    'Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
    '    ' Ambil data dari form
    '    Dim pengguna_id As String = cmbUser.SelectedValue.ToString()
    '    Dim tanggal_izin As String = dtpIzin.Value.ToString("yyyy-MM-dd")
    '    Dim nama_penjemput As String = txt_nama_penjemput.Text.Trim()
    '    Dim hubungan As String = txtHubungan.Text.Trim()
    '    Dim keperluan As String = txtKeperluan.Text.Trim()
    '    Dim alamat_tujuan As String = txtAlamatTujuan.Text.Trim()
    '    Dim tanggal_batas_izin As String = dtpBatasIzin.Value.ToString("yyyy-MM-dd")
    '    Dim tanggal_datang As String = dtpDatang.Value.ToString("yyyy-MM-dd")
    '    'Dim status As String = cmbStatusIzin.SelectedItem.ToString()

    '    ' Konfirmasi
    '    Dim konfirmasi As String = "Apakah Anda yakin ingin menyimpan perubahan data berikut?" & vbCrLf & vbCrLf &
    '    "No Izin: " & selectedNoIzin & vbCrLf &
    '    "Pengguna ID: " & pengguna_id & " (" & cmbUser.Text & ")" & vbCrLf &
    '    "Tanggal Izin: " & tanggal_izin & vbCrLf &
    '    "Nama Penjemput: " & nama_penjemput & vbCrLf &
    '    "Hubungan: " & hubungan & vbCrLf &
    '    "Keperluan: " & keperluan & vbCrLf &
    '    "Alamat Tujuan: " & alamat_tujuan & vbCrLf &
    '    "Tanggal Batas Izin: " & tanggal_batas_izin & vbCrLf &
    '    "Tanggal Datang: " & tanggal_datang
    '    '"Status Izin: " & status

    '    Dim result As DialogResult = MessageBox.Show(konfirmasi, "Konfirmasi Simpan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '    If result = DialogResult.No Then Exit Sub

    '    ' Update ke database
    '    Try
    '        If conn.State = ConnectionState.Closed Then
    '            conn.Open()
    '        End If

    '        ' Simpan ke tabel perizinan
    '        Dim queryPerizinan As String = "
    '            UPDATE perizinan SET 
    '                pengguna_id = @pengguna_id, 
    '                tanggal_izin = @tanggal_izin, 
    '                nama_penjemput = @nama_penjemput,
    '                tanggal_batas_izin = @tanggal_batas_izin, 
    '                tanggal_datang = @tanggal_datang, 
    '                status = @status, 
    '                updated_at = CURRENT_TIMESTAMP
    '            WHERE no_izin = @no_izin;
    '        "
    '        Dim cmd1 As New MySqlCommand(queryPerizinan, conn)
    '        cmd1.Parameters.AddWithValue("@no_izin", selectedNoIzin)
    '        cmd1.Parameters.AddWithValue("@pengguna_id", pengguna_id)
    '        cmd1.Parameters.AddWithValue("@tanggal_izin", tanggal_izin)
    '        cmd1.Parameters.AddWithValue("@nama_penjemput", nama_penjemput)
    '        cmd1.Parameters.AddWithValue("@tanggal_batas_izin", tanggal_batas_izin)
    '        cmd1.Parameters.AddWithValue("@tanggal_datang", tanggal_datang)
    '        cmd1.ExecuteNonQuery()

    '        ' Simpan ke tabel detail_perizinan
    '        Dim queryDetail As String = "
    '            UPDATE detail_perizinan SET 
    '                hubungan = @hubungan, 
    '                keperluan = @keperluan, 
    '                alamat_tujuan = @alamat_tujuan,
    '                updated_at = CURRENT_TIMESTAMP
    '            WHERE no_izin = @no_izin           
    '        "
    '        Dim cmd2 As New MySqlCommand(queryDetail, conn)
    '        cmd2.Parameters.AddWithValue("@no_izin", selectedNoIzin)
    '        cmd2.Parameters.AddWithValue("@hubungan", hubungan)
    '        cmd2.Parameters.AddWithValue("@keperluan", keperluan)
    '        cmd2.Parameters.AddWithValue("@alamat_tujuan", alamat_tujuan)
    '        cmd2.ExecuteNonQuery()

    '        MessageBox.Show("Data perizinan berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '    Catch ex As Exception
    '        MessageBox.Show("Gagal memperbarui data perizinan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        Database.CloseConnection(conn)
    '    End Try

    '    Dim parentForm = CType(MdiParent, Form1)
    '    parentForm.OpenChildForm(New PerizinanAdmin)
    'End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        ' Ambil data dari form
        Dim pengguna_id As String = If(cmbUser.SelectedValue IsNot Nothing, cmbUser.SelectedValue.ToString(), "")
        Dim tanggal_izin As String = dtpIzin.Value.ToString("yyyy-MM-dd")
        Dim nama_penjemput As String = txt_nama_penjemput.Text.Trim()
        Dim hubungan As String = txtHubungan.Text.Trim()
        Dim keperluan As String = txtKeperluan.Text.Trim()
        Dim alamat_tujuan As String = txtAlamatTujuan.Text.Trim()
        Dim tanggal_batas_izin As String = dtpBatasIzin.Value.ToString("yyyy-MM-dd")
        Dim tanggal_datang As String = dtpDatang.Value.ToString("yyyy-MM-dd")

        ' Validasi dasar
        If pengguna_id = "" Then
            MessageBox.Show("Pengguna belum dipilih.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Konfirmasi
        Dim konfirmasi As String = "Apakah Anda yakin ingin menyimpan perubahan data berikut?" & vbCrLf & vbCrLf &
        "No Izin: " & selectedNoIzin & vbCrLf &
        "Pengguna ID: " & pengguna_id & " (" & cmbUser.Text & ")" & vbCrLf &
        "Tanggal Izin: " & tanggal_izin & vbCrLf &
        "Nama Penjemput: " & nama_penjemput & vbCrLf &
        "Hubungan: " & hubungan & vbCrLf &
        "Keperluan: " & keperluan & vbCrLf &
        "Alamat Tujuan: " & alamat_tujuan & vbCrLf &
        "Tanggal Batas Izin: " & tanggal_batas_izin & vbCrLf &
        "Tanggal Datang: " & tanggal_datang

        Dim result As DialogResult = MessageBox.Show(konfirmasi, "Konfirmasi Simpan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then Exit Sub

        ' Update ke database
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Simpan ke tabel perizinan
            Dim queryPerizinan As String = "
            UPDATE perizinan SET 
                pengguna_id = @pengguna_id, 
                tanggal_izin = @tanggal_izin, 
                nama_penjemput = @nama_penjemput,
                tanggal_batas_izin = @tanggal_batas_izin, 
                tanggal_datang = @tanggal_datang, 
                updated_at = CURRENT_TIMESTAMP
            WHERE no_izin = @no_izin AND deleted_at IS NULL;
        "
            Using cmd1 As New MySqlCommand(queryPerizinan, conn)
                cmd1.Parameters.AddWithValue("@no_izin", selectedNoIzin)
                cmd1.Parameters.AddWithValue("@pengguna_id", pengguna_id)
                cmd1.Parameters.AddWithValue("@tanggal_izin", tanggal_izin)
                cmd1.Parameters.AddWithValue("@nama_penjemput", nama_penjemput)
                cmd1.Parameters.AddWithValue("@tanggal_batas_izin", tanggal_batas_izin)
                cmd1.Parameters.AddWithValue("@tanggal_datang", tanggal_datang)
                cmd1.ExecuteNonQuery()
            End Using

            ' Simpan ke tabel detail_perizinan
            Dim queryDetail As String = "
            UPDATE detail_perizinan SET 
                hubungan = @hubungan, 
                keperluan = @keperluan, 
                alamat_tujuan = @alamat_tujuan,
                updated_at = CURRENT_TIMESTAMP
            WHERE no_izin = @no_izin AND deleted_at IS NULL;
        "
            Using cmd2 As New MySqlCommand(queryDetail, conn)
                cmd2.Parameters.AddWithValue("@no_izin", selectedNoIzin)
                cmd2.Parameters.AddWithValue("@hubungan", hubungan)
                cmd2.Parameters.AddWithValue("@keperluan", keperluan)
                cmd2.Parameters.AddWithValue("@alamat_tujuan", alamat_tujuan)
                cmd2.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data perizinan berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh form
            Dim parentForm = CType(MdiParent, Form1)
            parentForm.OpenChildForm(New PerizinanAdmin)

        Catch ex As Exception
            MessageBox.Show("Gagal memperbarui data perizinan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub


End Class