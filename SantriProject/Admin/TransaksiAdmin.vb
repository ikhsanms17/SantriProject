Imports MySql.Data.MySqlClient

Public Class TransaksiAdmin
    Dim isLoading As Boolean = False
    Private Sub TransaksiAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight

        ResizeControls(Me, scaleX, scaleY)

        ShowTransaksi(DGView1)
    End Sub

    Private Sub DGView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGView1.CellContentClick

    End Sub

    Private Sub ShowTransaksi(DGView1 As DataGridView)
        isLoading = True ' ✅ Mulai loading
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            DGView1.Rows.Clear()
            DGView1.Columns.Clear()
            DGView1.AutoGenerateColumns = False

            DGView1.Columns.Add("petugas_id", "Nama Petugas")
            DGView1.Columns.Add("pengguna_id", "Nama Pengguna")
            DGView1.Columns.Add("tanggal_Transaksi", "Tanggal Transaksi")
            DGView1.Columns.Add("type_pembayaran", "Metode Pembayaran")
            DGView1.Columns.Add("jumlah", "Jumlah Transaksi")
            DGView1.Columns.Add("type", "Status Transaksi")
            DGView1.Columns.Add("keterangan", "Keterangan")

            For Each col As DataGridViewColumn In DGView1.Columns
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

            Dim btnBukti As New DataGridViewButtonColumn()
            btnBukti.Name = "btnBukti"
            btnBukti.HeaderText = ""
            btnBukti.Text = "Lihat Bukti"
            btnBukti.UseColumnTextForButtonValue = True
            DGView1.Columns.Add(btnBukti)

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

            Dim cmd As New MySqlCommand(
            "SELECT " &
            "    t.no_transaksi, " &
            "    u1.nama AS nama_pengguna, " &
            "    u2.nama AS nama_petugas, " &
            "    t.tanggal_transaksi, " &
            "    t.type_pembayaran, " &
            "    dt.jumlah, " &
            "    dt.keterangan " &
            "FROM " &
            "    transaksi t " &
            "JOIN " &
            "    users u1 ON t.pengguna_id = u1.id " &
            "JOIN " &
            "    users u2 ON t.petugas_id = u2.id " &
            "JOIN " &
            "    detail_transaksi dt ON t.id = dt.transaksi_id " &
            "WHERE " &
            "    t.deleted_at IS NULL " &
            "ORDER BY " &
            "    t.tanggal_transaksi DESC;", conn)

            dr = cmd.ExecuteReader

            While dr.Read
                Dim index As Integer = DGView1.Rows.Add()
                DGView1.Rows(index).Cells("no_transaksi").Value = dr("no_izin")
                DGView1.Rows(index).Cells("petugas_id").Value = dr("nama_petugas")
                DGView1.Rows(index).Cells("pengguna_id").Value = dr("nama_pengguna")
                DGView1.Rows(index).Cells("tanggal_transaksi").Value = dr("tanggal_transaksi")
                DGView1.Rows(index).Cells("type_pembayaran").Value = dr("type_pembayaran")
                DGView1.Rows(index).Cells("jumlah").Value = dr("jumlah")
                DGView1.Rows(index).Cells("keterangan").Value = dr("keterangan")
            End While

            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            isLoading = False ' ✅ Selesai loading
            Database.CloseConnection(conn)
        End Try
    End Sub

    Private Sub btnTambahIzin_Click(sender As Object, e As EventArgs) Handles btnTambahIzin.Click
        Dim ParentForm = CType(MdiParent, Form1)
        ParentForm.OpenChildForm(AddTransaksi)
    End Sub
End Class