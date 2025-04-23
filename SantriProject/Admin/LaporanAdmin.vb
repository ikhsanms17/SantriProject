Imports MySql.Data.MySqlClient

Public Class LaporanAdmin
    Dim isLoading As Boolean = False

    ' Handles the form load event to initialize the form
    Private Sub LaporanAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight

        ResizeControls(Me, scaleX, scaleY)

        ShowLaporan(DGView1)

        ' Subscribe to the TextChanged event to trigger filtering
        AddHandler txtSearch.TextChanged, AddressOf txtSearch_TextChanged
    End Sub

    ' Handles the event when the text in txtSearch changes
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
        ' Get the search term
        Dim searchTerm As String = txtSearch.Text.ToLower()

        ' Filter the rows in the DataGridView based on the search term
        For Each row As DataGridViewRow In DGView1.Rows
            ' Check if any of the cell values match the search term
            If row.Cells("no_izin").Value.ToString().ToLower().Contains(searchTerm) OrElse
               row.Cells("pengguna_id").Value.ToString().ToLower().Contains(searchTerm) OrElse
               row.Cells("type_laporan").Value.ToString().ToLower().Contains(searchTerm) Then
                row.Visible = True
            Else
                row.Visible = False
            End If
        Next
    End Sub

    ' Handles the click event for the DataGridView cells
    Private Sub DGView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim columnName = DGView1.Columns(e.ColumnIndex).Name

            ' Only handle button clicks
            If columnName = "btnCetak" Then
                Dim no_izin = DGView1.Rows(e.RowIndex).Cells("no_izin").Value.ToString
                Dim type_laporan = DGView1.Rows(e.RowIndex).Cells("type_laporan").Value.ToString

                ' Show a confirmation message before printing
                Dim result = MessageBox.Show("Cetak laporan dengan No: '" & no_izin & "'?", "Konfirmasi Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Check the type of report and call the respective function
                    If type_laporan.ToLower() = "izin" Then
                        CetakSuratIzinPDF(no_izin)
                    ElseIf type_laporan.ToLower() = "transaksi" Then
                        CetakSuratTransaksiPDF(no_izin)
                    End If
                End If

                ' Reload the laporan data
                ShowLaporan(DGView1)
            End If
        End If
    End Sub


    ' Shows the laporan (report) in the DataGridView
    Private Sub ShowLaporan(DGView1 As DataGridView)
        isLoading = True ' ✅ Mulai loading
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            DGView1.Rows.Clear()
            DGView1.Columns.Clear()
            DGView1.AutoGenerateColumns = False

            ' Add only the necessary columns
            DGView1.Columns.Add("no_izin", "No Izin") ' no_izin column
            DGView1.Columns.Add("pengguna_id", "Nama Pengguna") ' nama column
            DGView1.Columns.Add("type_laporan", "Type Laporan") ' type_laporan column

            ' Resize columns to fit, and set larger width
            DGView1.Columns("no_izin").Width = 430 ' Set width for no_izin column
            DGView1.Columns("pengguna_id").Width = 430 ' Set width for pengguna_id column
            DGView1.Columns("type_laporan").Width = 308 ' Set width for type_laporan column

            ' Create button column for Cetak
            Dim btnCetak As New DataGridViewButtonColumn()
            btnCetak.Name = "btnCetak"
            btnCetak.HeaderText = "Aksi" ' Display header as "Aksi"
            btnCetak.Text = "Cetak Surat" ' Button text
            btnCetak.UseColumnTextForButtonValue = True ' Ensure button text appears
            DGView1.Columns.Add(btnCetak)

            ' Set row height to make it larger
            DGView1.RowTemplate.Height = 40 ' Set row height to make the rows taller

            DGView1.DefaultCellStyle.Font = New Font("Segoe UI", 12) ' Set font size larger for readability
            DGView1.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 13, FontStyle.Bold) ' Header font size

            ' Update the SQL query to select only the required columns
            Dim cmd As New MySqlCommand("SELECT 
                                            p.no_izin AS no,
                                            u.nama AS nama,
                                            'izin' AS type_laporan
                                        FROM perizinan p
                                        JOIN users u ON p.pengguna_id = u.id
                                        WHERE p.status = 'Diizinkan' AND p.deleted_at IS NULL

                                        UNION

                                        SELECT
                                            t.no_transaksi AS no,
                                            u.nama AS nama,
                                            'transaksi' AS type_laporan
                                        FROM transaksi t
                                        JOIN users u ON t.pengguna_id = u.id
                                        WHERE t.deleted_at IS NULL", conn)

            dr = cmd.ExecuteReader

            While dr.Read
                Dim index As Integer = DGView1.Rows.Add()
                DGView1.Rows(index).Cells("no_izin").Value = dr("no") ' Assign 'no' field to no_izin column
                DGView1.Rows(index).Cells("pengguna_id").Value = dr("nama") ' Assign 'nama' field to pengguna_id column
                DGView1.Rows(index).Cells("type_laporan").Value = dr("type_laporan") ' Assign 'type_laporan' field
            End While

            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            isLoading = False ' ✅ Selesai loading
            Database.CloseConnection(conn)
        End Try
    End Sub

    ' Handles the click event for the Kembali (Back) button
    Private Sub btnKembali_Click_1(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim parentForm = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(MenuAdmin)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
