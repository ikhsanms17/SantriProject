Imports MySql.Data.MySqlClient

Public Class PerizinanAdmin
    Dim conn As MySqlConnection = Database.GetConnection()
    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub PerizinanAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("Form loaded!")

        ' Set form agar bisa di-resize
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

    Private Sub searchIzin_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DGView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim columnName = DGView1.Columns(e.ColumnIndex).Name

            Select Case columnName

        ' === 🔄 COMBOBOX STATUS ===
                Case "cmbStatus"
                    Dim statusCell = CType(DGView1.Rows(e.RowIndex).Cells("cmbStatus"), DataGridViewComboBoxCell)
                    Dim newStatus As String = statusCell.Value.ToString()
                    Dim no_izin As String = DGView1.Rows(e.RowIndex).Cells("no_izin").Value.ToString()

                    ' Update status berdasarkan no_izin
                    Dim query = "UPDATE perizinan SET status = @status WHERE no_izin = @no_izin"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@status", newStatus)
                        cmd.Parameters.AddWithValue("@no_izin", no_izin)

                        Try
                            If conn.State = ConnectionState.Closed Then conn.Open()
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Status berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Catch ex As Exception
                            MessageBox.Show("Gagal mengubah status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            conn.Close()
                        End Try
                    End Using

                    ShowIzin(DGView1) ' Refresh status

        ' === ✅ TOMBOL EDIT ===
                Case "btnEdit"
                    ' Ambil no_izin dari baris yang dipilih
                    Dim no_izin As String = DGView1.Rows(e.RowIndex).Cells("no_izin").Value.ToString
                    ' Tanyakan konfirmasi edit
                    Dim result = MessageBox.Show("Apakah Anda ingin mengedit data dengan No Izin " & no_izin & "?", "Konfirmasi Edit", MessageBoxButtons.YesNo)

                    If result = DialogResult.Yes Then
                        ' Ambil seluruh data dari baris yang dipilih
                        Dim row = DGView1.Rows(e.RowIndex)

                        ' Ambil nama pengguna dari kolom (bukan ID)
                        Dim namaPengguna As String = row.Cells("pengguna_id").Value.ToString ' Kolom ini berisi NAMA pengguna
                        Dim penggunaId As String = ""

                        ' Ambil ID berdasarkan nama pengguna dari tabel users
                        Using cmd As New MySqlCommand("SELECT id FROM users WHERE nama = @nama", conn)
                            cmd.Parameters.AddWithValue("@nama", namaPengguna)

                            If conn.State = ConnectionState.Closed Then conn.Open()
                            Dim reader = cmd.ExecuteReader()
                            If reader.Read() Then
                                penggunaId = reader("id").ToString()
                            End If
                            reader.Close()
                        End Using

                        ' Buat dictionary untuk menyimpan data pengguna
                        Dim userData As New Dictionary(Of String, String)
                        userData("no_izin") = no_izin
                        userData("pengguna_id") = penggunaId ' Sekarang kita simpan ID, bukan nama
                        userData("nama_penjemput") = row.Cells("nama_penjemput").Value.ToString
                        userData("tanggal_izin") = row.Cells("tanggal_izin").Value.ToString
                        userData("tanggal_batas_izin") = row.Cells("tanggal_batas_izin").Value.ToString
                        userData("tanggal_datang") = row.Cells("tanggal_datang").Value.ToString
                        userData("status") = row.Cells("status").Value.ToString

                        ' Buka form update dan load data
                        Dim formUpdate As New UpdatePerizinan
                        formUpdate.LoadIzinData(userData)

                        ' Tampilkan form sebagai child MDI
                        Dim parentForm = CType(MdiParent, Form1)
                        parentForm.OpenChildForm(formUpdate)
                    End If



        ' === 🗑️ TOMBOL HAPUS ===
                Case "btnHapus"
                    Dim no_izin = DGView1.Rows(e.RowIndex).Cells("no_izin").Value.ToString

                    Dim result = MessageBox.Show("Hapus data izin dengan No: '" & no_izin & "'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        DeleteIzin(no_izin)
                    End If

                    ShowIzin(DGView1) ' Refresh

            End Select
        End If

    End Sub
End Class