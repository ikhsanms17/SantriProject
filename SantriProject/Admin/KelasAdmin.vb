Imports MySql.Data.MySqlClient

Public Class KelasAdmin
    Private selectedKelasId As String = ""

    Private Sub KelasAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("Form loaded!")

        ' Set form agar bisa di-resize
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight

        ResizeControls(Me, scaleX, scaleY)

        ShowKelas(DGView1)

        If selectedKelasId = "" Then
            btnTambahKelas.Text = "Tambah Data"
        Else
            btnTambahKelas.Text = "Simpan Perubahan"
        End If
    End Sub

    Public Sub LoadUserData(userData As Dictionary(Of String, String))
        txt_nama.Text = userData("nama")
        txt_deskripsi.Text = userData("deskripsi")

        ' Simpan ID atau username lama sebagai referensi update
        selectedKelasId = userData("id")
    End Sub

    Private Sub btnTambahKelas_Click(sender As Object, e As EventArgs) Handles btnTambahKelas.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String
            Dim cmd As New MySqlCommand()

            If selectedKelasId = "" Then
                ' Mode Tambah
                query = "INSERT INTO kelas (nama, deskripsi) VALUES (@nama, @deskripsi)"
            Else
                ' Mode Edit
                query = "UPDATE kelas SET nama = @nama, deskripsi = @deskripsi WHERE id = @id"
                cmd.Parameters.AddWithValue("@id", selectedKelasId)
            End If

            cmd.Connection = conn
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@nama", txt_nama.Text)
            cmd.Parameters.AddWithValue("@deskripsi", txt_deskripsi.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil disimpan!")

            ResetFormInput()

            ShowKelas(DGView1) ' Refresh DataGridView

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetFormInput()
    End Sub

    Private Sub ResetFormInput()
        txt_nama.Clear()
        txt_deskripsi.Clear()
        selectedKelasId = ""
        btnTambahKelas.Text = "Tambah Data"
        txt_nama.BackColor = SystemColors.Window
        txt_deskripsi.BackColor = SystemColors.Window
    End Sub

    Private Sub DGView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DGView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim columnName = DGView1.Columns(e.ColumnIndex).Name

            Select Case columnName

                Case "btnEdit"
                    If e.RowIndex >= 0 Then
                        Dim colName = DGView1.Columns(e.ColumnIndex).Name

                        ' Periksa apakah tombol yang ditekan adalah tombol Editd
                        If colName = "btnEdit" Then
                            ' Ambil data dari baris yang diklik
                            Dim row = DGView1.Rows(e.RowIndex)

                            ' Masukkan data ke TextBox / RichTextBox
                            txt_nama.Text = row.Cells("nama").Value.ToString()
                            txt_deskripsi.Text = row.Cells("deskripsi").Value.ToString()

                            ' Simpan ID ke variabel global untuk kebutuhan update nanti
                            selectedKelasId = row.Cells("id").Value.ToString()

                            If selectedKelasId = "" Then
                                btnTambahKelas.Text = "Tambah Data"
                            Else
                                btnTambahKelas.Text = "Simpan Perubahan"
                            End If
                        End If
                    End If

                Case "btnHapus"
                    ' Cek apakah tombol Delete diklik
                    If e.ColumnIndex = DGView1.Columns("btnHapus").Index AndAlso e.RowIndex >= 0 Then
                        Dim row = DGView1.Rows(e.RowIndex)

                        ' Ambil nilai ID dan Nama Kelas
                        Dim id As Integer = Convert.ToInt32(row.Cells("id").Value)
                        Dim nama As String = row.Cells("nama").Value.ToString()

                        Dim result = MessageBox.Show("Hapus kelas dengan ID '" & id & "' dan nama '" & nama & "'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If result = DialogResult.Yes Then
                            DeleteKelas(id) ' Hapus berdasarkan ID
                            ShowKelas(DGView1) ' Refresh setelah berhasil
                        End If
                    End If

            End Select
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchKelas(txtSearch.Text.Trim(), DGView1)
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim result As DialogResult = MessageBox.Show("Yakin untuk kembali? Jika ada perubahan data saat ini tidak akan disimpan.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
            parentForm.OpenChildForm(New MenuAdmin())
            Me.Close()
        End If
    End Sub

    Private Sub ShowKelas(DGView1 As DataGridView)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            DGView1.Rows.Clear()
            DGView1.Columns.Clear()
            DGView1.AutoGenerateColumns = False

            ' Change column headers
            DGView1.Columns.Add("nama", "Nama Kelas")
            DGView1.Columns("nama").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            DGView1.Columns.Add("deskripsi", "Deskripsi")
            DGView1.Columns("deskripsi").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ' Using Fill for better control over width

            ' Add Edit button column
            Dim btnEdit As New DataGridViewButtonColumn()
            btnEdit.Name = "btnEdit"
            btnEdit.HeaderText = "Edit"
            btnEdit.Text = "Edit"
            btnEdit.UseColumnTextForButtonValue = True
            DGView1.Columns.Add(btnEdit)

            ' Add Delete button column
            Dim btnDelete As New DataGridViewButtonColumn()
            btnDelete.Name = "btnHapus"
            btnDelete.HeaderText = "Hapus"
            btnDelete.Text = "Hapus"
            btnDelete.UseColumnTextForButtonValue = True
            DGView1.Columns.Add(btnDelete)

            ' Set font styles
            DGView1.DefaultCellStyle.Font = New Font("Segoe UI", 10)
            DGView1.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)

            DGView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Fetch data from the database
            Dim cmd As New MySqlCommand("SELECT * FROM kelas WHERE deleted_at IS NULL", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DGView1.Rows.Add(
            dr.Item("nama"),
            dr.Item("deskripsi"),
            Nothing, Nothing
        )
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub


    Private Sub DeleteKelas(id As Integer)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "UPDATE kelas SET deleted_at = CURRENT_TIMESTAMP WHERE id = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Kelas berhasil dihapus (soft delete).", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Gagal menghapus kelas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Private Sub SearchKelas(keyword As String, dgv As DataGridView)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Jika keyword kosong, tampilkan semua user
            If String.IsNullOrWhiteSpace(keyword) Then
                ShowKelas(dgv)
                Return
            End If

            Dim query As String = "SELECT * FROM kelas WHERE deleted_at IS NULL AND (nama LIKE @keyword)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            ' Bersihkan baris sebelumnya
            dgv.Rows.Clear()

            ' Tambahkan baris hasil pencarian
            While dr.Read
                dgv.Rows.Add(
                    dr.Item("id"),
                    dr.Item("nama"),
                    dr.Item("deskripsi"),
                    Nothing, Nothing
                )
            End While

            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat mencari user: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub

    Private Sub LoadKelas(cmb_kelas As ComboBox)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim cmd As New MySqlCommand("SELECT id, nama FROM kelas ORDER BY id ASC", conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            adapter.Fill(dt)

            cmb_kelas.DataSource = dt
            cmb_kelas.DisplayMember = "nama"
            cmb_kelas.ValueMember = "id"

        Catch ex As Exception
            MsgBox("Gagal load data kelas: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub
End Class