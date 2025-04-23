Imports LiveChartsCore.Themes
Imports Microsoft
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Transactions
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
        If e.RowIndex >= 0 Then
            Dim columnName As String = DGView1.Columns(e.ColumnIndex).Name
            Dim noTransaksi As String = DGView1.Rows(e.RowIndex).Cells("no_transaksi").Value.ToString()

            Select Case columnName
                Case "btnDetail"
                    ShowTransactionDetail(noTransaksi)
                Case "btnEdit"
                    EditTransaction(noTransaksi)
                Case "btnHapus"
                    DeleteTransaction(noTransaksi)
            End Select
        End If
    End Sub

    Private Sub ShowTransactionDetail(noTransaksi As String)
        MessageBox.Show("Showing details for " & noTransaksi)
    End Sub

    Private Sub EditTransaction(noTransaksi As String)
        MessageBox.Show("Editing transaction " & noTransaksi)
    End Sub

    Private Sub DeleteTransaction(noTransaksi As String)
        If MessageBox.Show("Are you sure you want to delete transaction " & noTransaksi & "?", "Delete Transaction", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                ' Membuka koneksi database
                conn.Open()

                ' Hapus data dari tabel detail_transaksi berdasarkan no_transaksi yang relevan
                Dim cmdDetail As New MySqlCommand("DELETE FROM detail_transaksi WHERE transaksi_id = (SELECT id FROM transaksi WHERE no_transaksi = @no_transaksi)", conn)
                cmdDetail.Parameters.AddWithValue("@no_transaksi", noTransaksi)
                cmdDetail.ExecuteNonQuery()

                ' Hapus data dari tabel transaksi berdasarkan no_transaksi
                Dim cmdTransaksi As New MySqlCommand("DELETE FROM transaksi WHERE no_transaksi = @no_transaksi", conn)
                cmdTransaksi.Parameters.AddWithValue("@no_transaksi", noTransaksi)
                cmdTransaksi.ExecuteNonQuery()

                MessageBox.Show("Transaction deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Update tampilan DataGridView setelah penghapusan
                ShowTransaksi(DGView1)

            Catch ex As Exception
                MessageBox.Show("Error deleting transaction: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Menutup koneksi database
                Database.CloseConnection(conn)
            End Try
        End If
    End Sub

    Private Sub ShowTransaksi(DGView1 As DataGridView)
        isLoading = True
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            DGView1.Rows.Clear()
            DGView1.Columns.Clear()
            DGView1.AutoGenerateColumns = False

            DGView1.Columns.Add("no_transaksi", "No Transaksi")
            DGView1.Columns.Add("nama_pengguna", "Nama Pengguna")
            DGView1.Columns.Add("nama_petugas", "Nama Petugas")
            DGView1.Columns.Add("tanggal_transaksi", "Tanggal Transaksi")
            DGView1.Columns.Add("type_transaksi", "Type Transaksi")

            For Each col As DataGridViewColumn In DGView1.Columns
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

            ' Add buttons for actions (Detail, Edit, Delete)
            Dim btnDetail As New DataGridViewButtonColumn()
            btnDetail.Name = "btnDetail"
            btnDetail.HeaderText = "Detail"
            btnDetail.Text = "Detail"
            btnDetail.UseColumnTextForButtonValue = True
            DGView1.Columns.Add(btnDetail)

            Dim btnEdit As New DataGridViewButtonColumn()
            btnEdit.Name = "btnEdit"
            btnEdit.HeaderText = "Edit"
            btnEdit.Text = "Edit"
            btnEdit.UseColumnTextForButtonValue = True
            DGView1.Columns.Add(btnEdit)

            Dim btnDelete As New DataGridViewButtonColumn()
            btnDelete.Name = "btnHapus"
            btnDelete.HeaderText = "Delete"
            btnDelete.Text = "Delete"
            btnDelete.UseColumnTextForButtonValue = True
            DGView1.Columns.Add(btnDelete)

            ' Style settings for DataGridView
            DGView1.DefaultCellStyle.Font = New Font("Segoe UI", 10)
            DGView1.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)

            ' Query to fetch transaction data
            Dim query As String = "SELECT t.no_transaksi, u1.nama AS nama_pengguna, u2.nama AS nama_petugas, t.tanggal_transaksi, t.type_pembayaran FROM transaksi t JOIN users u1 ON t.pengguna_id = u1.id JOIN users u2 ON t.petugas_id = u2.id WHERE t.deleted_at IS NULL ORDER BY t.tanggal_transaksi DESC;"
            Dim cmd As New MySqlCommand(query, conn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            ' Populate DataGridView with transaction data
            While dr.Read()
                Dim index As Integer = DGView1.Rows.Add()
                DGView1.Rows(index).Cells("no_transaksi").Value = dr("no_transaksi")
                DGView1.Rows(index).Cells("nama_pengguna").Value = dr("nama_pengguna")
                DGView1.Rows(index).Cells("nama_petugas").Value = dr("nama_petugas")
                DGView1.Rows(index).Cells("tanggal_transaksi").Value = dr("tanggal_transaksi")
                DGView1.Rows(index).Cells("type_transaksi").Value = dr("type_pembayaran")
            End While

            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            isLoading = False
            Database.CloseConnection(conn)
        End Try
    End Sub

    Private Sub btnTambahTransaksi_Click(sender As Object, e As EventArgs) Handles btnTambahTransaksi.Click
        Dim ParentForm = CType(MdiParent, Form1)
        ParentForm.OpenChildForm(New AddTransaksi)
    End Sub
End Class
