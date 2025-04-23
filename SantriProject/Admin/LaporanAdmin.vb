Imports MySql.Data.MySqlClient

Public Class LaporanAdmin
    Dim isLoading As Boolean = False

    Private Sub LaporanAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight

        ResizeControls(Me, scaleX, scaleY)

        ShowLaporan(DGView1)
    End Sub

    Private Sub DGView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim columnName = DGView1.Columns(e.ColumnIndex).Name

            Select Case columnName
                Case "btnCetak"
                    Dim no_izin = DGView1.Rows(e.RowIndex).Cells("no_izin").Value.ToString
                    Dim result = MessageBox.Show("Cetak surat izin dengan No: '" & no_izin & "'?", "Konfirmasi Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If result = DialogResult.Yes Then
                        CetakSuratPDF(no_izin)
                    End If

                    ShowLaporan(DGView1)
            End Select
        End If
    End Sub

    Private Sub ShowLaporan(DGView1 As DataGridView)
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

            Dim btnCetak As New DataGridViewButtonColumn()
            btnCetak.Name = "btnCetak"
            btnCetak.HeaderText = ""
            btnCetak.Text = "Cetak Surat"
            DGView1.Columns.Add(btnCetak)

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
                WHERE p.status = 'Diizinkan' AND p.deleted_at IS NULL", conn)

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

    Private Sub btnKembali_Click_1(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim parentForm = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(MenuAdmin)
    End Sub
End Class