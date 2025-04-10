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
    'Public Sub AddUser()
    '    Try
    '        conn.Open()
    '        Dim cmd As New MySqlCommand("
    '        INSERT INTO users (
    '            nama, 
    '            nama_pengguna, 
    '            email, 
    '            kata_sandi, 
    '            nis, 
    '            kelas_id, 
    '            jenis_kelamin, 
    '            tanggal_lahir, 
    '            nama_ayah, 
    '            nama_ibu, 
    '            alamat, 
    '            created_at, 
    '            updated_at
    '        ) VALUES (
    '            @nama,
    '            @username,
    '            @email,
    '            SHA2(@password, 256),
    '            @nis,
    '            @kelas_id,
    '            @jenis_kelamin,
    '            @tgl_lahir,
    '            @nama_ayah,
    '            @nama_ibu,
    '            @alamat,
    '            CURRENT_TIMESTAMP,
    '            CURRENT_TIMESTAMP
    '        );
    '        ", conn)

    '        cmd.Parameters.Clear()
    '        cmd.Parameters.AddWithValue("@nama", txt_nama.Text)
    '        cmd.Parameters.AddWithValue("@username", txt_username.Text)
    '        cmd.Parameters.AddWithValue("@email", txt_email.Text)
    '        cmd.Parameters.AddWithValue("@password", txt_password.Text)
    '        cmd.Parameters.AddWithValue("@nis", txt_nis.Text)
    '        cmd.Parameters.AddWithValue("@kelas_id", txt_kelas_id.Text)
    '        cmd.Parameters.AddWithValue("@jenis_kelamin", txt_jenis_kelamin.Text)
    '        cmd.Parameters.AddWithValue("@tgl_lahir", txt_tgl_lahir.Text)
    '        cmd.Parameters.AddWithValue("@nama_ayah", txt_nama_ayah.Text)
    '        cmd.Parameters.AddWithValue("@nama_ibu", txt_nama_ibu.Text)
    '        cmd.Parameters.AddWithValue("@alamat", txt_alamat.Text)

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        conn.Close()
    '    End Try
    'End Sub

    Private Sub UserManagementAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddUser_Click(sender As Object, e As EventArgs) Handles AddUserLabel.Click
        Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(New AddUser)
    End Sub
End Class