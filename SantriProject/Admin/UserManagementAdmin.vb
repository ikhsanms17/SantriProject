Imports MySql.Data.MySqlClient

Public Class UserManagementAdmin

    'Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=vb_santri")
    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    Try
    '        conn.Open()
    '        Dim cmd As New MySqlCommand("", conn)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        conn.Close()
    '    End Try
    'End Sub

    Private Sub UserManagementAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("Form loaded!")

        ' Set form agar bisa di-resize
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight

        ResizeControls(Me, scaleX, scaleY)

        ShowUser(DGView1)
    End Sub

    Private Sub DGView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim columnName As String = DGView1.Columns(e.ColumnIndex).Name

            Select Case columnName

                Case "btnEdit"
                    If e.RowIndex >= 0 Then
                        Dim colName As String = DGView1.Columns(e.ColumnIndex).Name

                        ' Periksa apakah tombol yang ditekan adalah tombol Editd
                        If colName = "btnEdit" Then
                            ' Ambil nama dari baris yang ditekan
                            Dim nama As String = DGView1.Rows(e.RowIndex).Cells("nama").Value.ToString()

                            ' Tampilkan nama untuk konfirmasi
                            Dim result As DialogResult = MessageBox.Show("Apakah Anda ingin mengedit data untuk " & nama & "?", "Konfirmasi Edit", MessageBoxButtons.YesNo)

                            If result = DialogResult.Yes Then
                                Dim row As DataGridViewRow = DGView1.Rows(e.RowIndex)

                                ' Simpan semua nilai ke variable
                                Dim userData As New Dictionary(Of String, String)
                                userData("nama") = DGView1.Rows(e.RowIndex).Cells("nama").Value.ToString()
                                userData("nama_pengguna") = DGView1.Rows(e.RowIndex).Cells("nama_pengguna").Value.ToString()
                                userData("email") = DGView1.Rows(e.RowIndex).Cells("email").Value.ToString()
                                userData("nis") = DGView1.Rows(e.RowIndex).Cells("nis").Value.ToString()
                                userData("kelas_id") = DGView1.Rows(e.RowIndex).Cells("kelas_id").Value.ToString()
                                userData("jenis_kelamin") = DGView1.Rows(e.RowIndex).Cells("jenis_kelamin").Value.ToString()
                                userData("tanggal_lahir") = DGView1.Rows(e.RowIndex).Cells("tanggal_lahir").Value.ToString()
                                userData("nama_ayah") = DGView1.Rows(e.RowIndex).Cells("nama_ayah").Value.ToString()
                                userData("nama_ibu") = DGView1.Rows(e.RowIndex).Cells("nama_ibu").Value.ToString()
                                userData("alamat") = DGView1.Rows(e.RowIndex).Cells("alamat").Value.ToString()

                                ' Buka form sebagai MDI child
                                Dim formUpdate As New UpdateUser()
                                formUpdate.LoadUserData(userData) ' isi data
                                Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
                                parentForm.OpenChildForm(formUpdate)
                            End If
                        End If
                    End If

                Case "btnHapus"
                    ' Cek apakah tombol Delete diklik
                    If e.ColumnIndex = DGView1.Columns("btnHapus").Index AndAlso e.RowIndex >= 0 Then
                        ' Ambil nilai nama_pengguna dari baris yang diklik
                        Dim nama As String = DGView1.Rows(e.RowIndex).Cells("Nama").Value.ToString()

                        Dim result As DialogResult = MessageBox.Show("Hapus pengguna '" & nama & "'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If result = DialogResult.Yes Then
                            DeleteUser(nama)
                        End If
                    End If

                    ShowUser(DGView1) ' Refresh DataGridView
            End Select
        End If
    End Sub

    Private Sub btnTambahUser_Click(sender As Object, e As EventArgs) Handles btnTambahUser.Click
        Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(New AddUser)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchUser(txtSearch.Text.Trim(), DGView1)
    End Sub
End Class