Imports MySql.Data.MySqlClient

Public Class PerizinanAdmin
    Dim isLoading As Boolean = False ' 🔒 Untuk menghindari trigger CellValueChanged saat load data

    Private Sub PerizinanAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight

        ResizeControls(Me, scaleX, scaleY)

        ShowIzin(DGView1)
    End Sub

    Private Sub btnTambahIzin_Click(sender As Object, e As EventArgs) Handles btnTambahIzin.Click
        Dim parentForm = CType(MdiParent, Form1)
        parentForm.OpenChildForm(New AddPerizinan)
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(New MenuAdmin())
        Me.Close()
    End Sub

    Private Sub DGView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim columnName = DGView1.Columns(e.ColumnIndex).Name

            Select Case columnName
                Case "btnIzinkan" ' Button Izinkan
                    Dim no_izin As String = DGView1.Rows(e.RowIndex).Cells("no_izin").Value.ToString
                    Dim result = MessageBox.Show("Apakah Anda ingin mengizinkan data dengan No Izin " & no_izin & "?", "Konfirmasi Izinkan", MessageBoxButtons.YesNo)

                    If result = DialogResult.Yes Then
                        Dim row = DGView1.Rows(e.RowIndex)
                        Dim namaPengguna As String = row.Cells("pengguna_id").Value.ToString
                        Dim penggunaId As String = ""

                        Using cmd As New MySqlCommand("SELECT id FROM users WHERE nama = @nama", conn)
                            cmd.Parameters.AddWithValue("@nama", namaPengguna)

                            If conn.State = ConnectionState.Closed Then conn.Open()
                            Dim reader = cmd.ExecuteReader()
                            If reader.Read() Then
                                penggunaId = reader("id").ToString()
                            End If
                            reader.Close()
                        End Using

                        ' Update status to "Izinkan"
                        Dim userData As New Dictionary(Of String, String)
                        userData("no_izin") = no_izin
                        userData("pengguna_id") = penggunaId
                        userData("nama_penjemput") = row.Cells("nama_penjemput").Value.ToString
                        userData("tanggal_izin") = row.Cells("tanggal_izin").Value.ToString
                        userData("tanggal_batas_izin") = row.Cells("tanggal_batas_izin").Value.ToString
                        userData("tanggal_datang") = row.Cells("tanggal_datang").Value.ToString
                        userData("status") = "Izinkan" ' Update status ke "Izinkan"

                        ' Update database status
                        Using cmdUpdate As New MySqlCommand("UPDATE perizinan SET status = @status WHERE no_izin = @no_izin", conn)
                            cmdUpdate.Parameters.AddWithValue("@status", "Diizinkan")
                            cmdUpdate.Parameters.AddWithValue("@no_izin", no_izin)
                            If conn.State = ConnectionState.Closed Then conn.Open()
                            cmdUpdate.ExecuteNonQuery()
                        End Using

                        ShowIzin(DGView1)
                    End If

                Case "btnTolak" ' Button Tidak Diizinkan
                    Dim no_izin As String = DGView1.Rows(e.RowIndex).Cells("no_izin").Value.ToString
                    Dim result = MessageBox.Show("Apakah Anda ingin menolak data dengan No Izin " & no_izin & "?", "Konfirmasi Tidak Diizinkan", MessageBoxButtons.YesNo)

                    If result = DialogResult.Yes Then
                        Dim row = DGView1.Rows(e.RowIndex)
                        Dim namaPengguna As String = row.Cells("pengguna_id").Value.ToString
                        Dim penggunaId As String = ""

                        Using cmd As New MySqlCommand("SELECT id FROM users WHERE nama = @nama", conn)
                            cmd.Parameters.AddWithValue("@nama", namaPengguna)

                            If conn.State = ConnectionState.Closed Then conn.Open()
                            Dim reader = cmd.ExecuteReader()
                            If reader.Read() Then
                                penggunaId = reader("id").ToString()
                            End If
                            reader.Close()
                        End Using

                        ' Update status to "Tidak Diizinkan"
                        Dim userData As New Dictionary(Of String, String)
                        userData("no_izin") = no_izin
                        userData("pengguna_id") = penggunaId
                        userData("nama_penjemput") = row.Cells("nama_penjemput").Value.ToString
                        userData("tanggal_izin") = row.Cells("tanggal_izin").Value.ToString
                        userData("tanggal_batas_izin") = row.Cells("tanggal_batas_izin").Value.ToString
                        userData("tanggal_datang") = row.Cells("tanggal_datang").Value.ToString
                        userData("status") = "Tidak Diizinkan" ' Update status ke "Tidak Diizinkan"

                        ' Update database status
                        Using cmdUpdate As New MySqlCommand("UPDATE perizinan SET status = @status WHERE no_izin = @no_izin", conn)
                            cmdUpdate.Parameters.AddWithValue("@status", "Tidak Diizinkan")
                            cmdUpdate.Parameters.AddWithValue("@no_izin", no_izin)
                            If conn.State = ConnectionState.Closed Then conn.Open()
                            cmdUpdate.ExecuteNonQuery()
                        End Using

                        ShowIzin(DGView1)
                    End If

                Case "btnEdit"
                    Dim no_izin As String = DGView1.Rows(e.RowIndex).Cells("no_izin").Value.ToString
                    Dim row = DGView1.Rows(e.RowIndex)
                    Dim namaPengguna As String = row.Cells("pengguna_id").Value.ToString
                    Dim penggunaId As String = ""
                    Dim result = MessageBox.Show("Apakah Anda ingin mengedit data dengan No Izin " & no_izin & " atas nama " & namaPengguna & "?", "Konfirmasi Edit", MessageBoxButtons.YesNo)

                    If result = DialogResult.Yes Then
                        'Dim row = DGView1.Rows(e.RowIndex)
                        'Dim namaPengguna As String = row.Cells("pengguna_id").Value.ToString
                        'Dim penggunaId As String = ""

                        Using cmd As New MySqlCommand("SELECT id FROM users WHERE nama = @nama", conn)
                            cmd.Parameters.AddWithValue("@nama", namaPengguna)

                            If conn.State = ConnectionState.Closed Then conn.Open()
                            Dim reader = cmd.ExecuteReader()
                            If reader.Read() Then
                                penggunaId = reader("id").ToString()
                            End If
                            reader.Close()
                        End Using

                        Dim userData As New Dictionary(Of String, String)
                        userData("no_izin") = no_izin
                        userData("pengguna_id") = penggunaId
                        userData("tanggal_izin") = row.Cells("tanggal_izin").Value.ToString()
                        userData("nama_penjemput") = row.Cells("nama_penjemput").Value.ToString()
                        userData("hubungan") = row.Cells("hubungan").Value.ToString()
                        userData("keperluan") = row.Cells("keperluan").Value.ToString()
                        userData("alamat_tujuan") = row.Cells("alamat_tujuan").Value.ToString()
                        userData("tanggal_batas_izin") = row.Cells("tanggal_batas_izin").Value.ToString()
                        userData("tanggal_datang") = row.Cells("tanggal_datang").Value.ToString()

                        Dim formUpdate As New UpdatePerizinan
                        formUpdate.LoadIzinData(userData)

                        Dim parentForm = CType(MdiParent, Form1)
                        parentForm.OpenChildForm(formUpdate)
                    End If

                Case "btnHapus"
                    Dim no_izin = DGView1.Rows(e.RowIndex).Cells("no_izin").Value.ToString
                    Dim result = MessageBox.Show("Hapus data izin dengan No: '" & no_izin & "'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If result = DialogResult.Yes Then
                        DeleteIzin(no_izin)
                    End If

                    ShowIzin(DGView1)
            End Select
        End If
    End Sub

    Private Sub DGView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGView1.CellValueChanged
        If isLoading Then Return ' ✅ Skip jika sedang load data

        If DGView1.Columns(e.ColumnIndex).Name = "cmbStatus" AndAlso e.RowIndex >= 0 Then
            Dim selectedStatus As String = DGView1.Rows(e.RowIndex).Cells("cmbStatus").Value.ToString()
            Dim noIzin As String = DGView1.Rows(e.RowIndex).Cells("no_izin").Value.ToString()

            Dim conn = Database.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                Dim query As String = "UPDATE perizinan SET status = @status, updated_at = CURRENT_TIMESTAMP WHERE no_izin = @no_izin"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@status", selectedStatus)
                cmd.Parameters.AddWithValue("@no_izin", noIzin)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Status izin berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal update status: " & ex.Message)
            Finally
                Database.CloseConnection(conn)
            End Try

            ShowIzin(DGView1)
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim keyword As String = txtSearch.Text.Trim()

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Jika keyword kosong, tampilkan semua data
            If String.IsNullOrWhiteSpace(keyword) Then
                ShowIzin(DGView1) ' Fungsi untuk menampilkan semua data
                Return
            End If

            Dim query As String = "
        SELECT 
            p.no_izin,
            p.nama_penjemput,
            p.tanggal_izin,
            p.tanggal_batas_izin,
            p.tanggal_datang,
            p.status,
            u.nama AS nama_pengguna,
            dp.hubungan,
            dp.keperluan,
            dp.alamat_tujuan
        FROM perizinan p
        LEFT JOIN users u ON u.id = p.pengguna_id
        LEFT JOIN detail_perizinan dp ON dp.no_izin = p.no_izin
        WHERE 
            p.deleted_at IS NULL AND (
                p.nama_penjemput LIKE @keyword OR
                p.status LIKE @keyword OR
                u.nama LIKE @keyword
            )
    "

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            DGView1.Rows.Clear()

            While dr.Read()
                DGView1.Rows.Add(
                dr("no_izin"),
                dr("nama_pengguna"),
                dr("nama_penjemput"),
                dr("hubungan"),
                dr("keperluan"),
                dr("alamat_tujuan"),
                Convert.ToDateTime(dr("tanggal_izin")).ToString("yyyy-MM-dd"),
                Convert.ToDateTime(dr("tanggal_batas_izin")).ToString("yyyy-MM-dd"),
                Convert.ToDateTime(dr("tanggal_datang")).ToString("yyyy-MM-dd"),
                dr("status"),
                Nothing, Nothing ' kolom untuk tombol Edit & Delete jika ada
            )
            End While

            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat mencari perizinan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Private Sub ShowIzin(DGView1 As DataGridView)
        isLoading = True ' ✅ Mulai loading
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            DGView1.Rows.Clear()
            DGView1.Columns.Clear()
            DGView1.AutoGenerateColumns = False

            DGView1.Columns.Add("no_izin", "No Izin")
            DGView1.Columns.Add("pengguna_id", "Nama Pengguna")
            DGView1.Columns.Add("nama_penjemput", "Nama Penjemput")
            DGView1.Columns.Add("hubungan", "Hubungan")
            DGView1.Columns.Add("keperluan", "Keperluan")
            DGView1.Columns.Add("alamat_tujuan", "Alamat Tujuan")
            DGView1.Columns.Add("tanggal_izin", "Tanggal Izin")
            DGView1.Columns.Add("tanggal_batas_izin", "Tanggal Batas Izin")
            DGView1.Columns.Add("tanggal_datang", "Tanggal Kembali")
            DGView1.Columns.Add("status", "Status Izin")

            For Each col As DataGridViewColumn In DGView1.Columns
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next

            Dim btnIzinkan As New DataGridViewButtonColumn()
            btnIzinkan.Name = "btnIzinkan"
            btnIzinkan.HeaderText = ""
            btnIzinkan.Text = "Diizinkan"
            btnIzinkan.UseColumnTextForButtonValue = True
            DGView1.Columns.Add(btnIzinkan)

            Dim btnTolak As New DataGridViewButtonColumn()
            btnTolak.Name = "btnTolak"
            btnTolak.HeaderText = ""
            btnTolak.Text = "Tidak Diizinkan"
            btnTolak.UseColumnTextForButtonValue = True
            DGView1.Columns.Add(btnTolak)

            Dim btnEdit As New DataGridViewButtonColumn()
            btnEdit.Name = "btnEdit"
            btnEdit.HeaderText = ""
            btnEdit.Text = "Edit"
            btnEdit.UseColumnTextForButtonValue = True
            DGView1.Columns.Add(btnEdit)

            Dim btnDelete As New DataGridViewButtonColumn()
            btnDelete.Name = "btnHapus"
            btnDelete.HeaderText = ""
            btnDelete.Text = "Delete"
            btnDelete.UseColumnTextForButtonValue = True
            DGView1.Columns.Add(btnDelete)

            DGView1.DefaultCellStyle.Font = New Font("Segoe UI", 10)
            DGView1.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)

            Dim cmd As New MySqlCommand("
                SELECT 
                    p.no_izin,
                    u.nama AS nama_pengguna,
                    p.nama_penjemput,
                    d.hubungan,
                    d.keperluan,
                    d.alamat_tujuan,
                    p.tanggal_izin,
                    p.tanggal_batas_izin,
                    p.tanggal_datang,
                    p.status
                FROM perizinan p
                JOIN users u ON p.pengguna_id = u.id
                JOIN detail_perizinan d ON d.no_izin = p.no_izin
                WHERE p.deleted_at IS NULL", conn)

            dr = cmd.ExecuteReader

            While dr.Read
                Dim index As Integer = DGView1.Rows.Add()
                DGView1.Rows(index).Cells("no_izin").Value = dr("no_izin")
                DGView1.Rows(index).Cells("pengguna_id").Value = dr("nama_pengguna")
                DGView1.Rows(index).Cells("nama_penjemput").Value = dr("nama_penjemput")
                DGView1.Rows(index).Cells("hubungan").Value = dr("hubungan")
                DGView1.Rows(index).Cells("keperluan").Value = dr("keperluan")
                DGView1.Rows(index).Cells("alamat_tujuan").Value = dr("alamat_tujuan")
                DGView1.Rows(index).Cells("tanggal_izin").Value = dr("tanggal_izin")
                DGView1.Rows(index).Cells("tanggal_batas_izin").Value = dr("tanggal_batas_izin")
                DGView1.Rows(index).Cells("tanggal_datang").Value = dr("tanggal_datang")
                DGView1.Rows(index).Cells("status").Value = dr("status")
            End While

            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            isLoading = False ' ✅ Selesai loading
            Database.CloseConnection(conn)
        End Try
    End Sub
End Class
