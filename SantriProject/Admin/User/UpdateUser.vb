Public Class UpdateUser
    Private selectedUsername As String = ""

    Private Sub UpdateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form agar bisa di-resize
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight

        ResizeControls(Me, scaleX, scaleY)

        cmb_jenis_kelamin.Items.Clear()
        cmb_jenis_kelamin.Items.Add("Laki-laki")
        cmb_jenis_kelamin.Items.Add("Perempuan")

        LoadKelas(cmb_kelas)
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Dim result As DialogResult = MessageBox.Show("Yakin untuk kembali? Perubahan data saat ini tidak akan disimpan.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
            parentForm.OpenChildForm(New UserManagementAdmin())
            Me.Close()
        End If
    End Sub

    Public Sub LoadUserData(userData As Dictionary(Of String, String))
        txt_nama.Text = userData("nama")
        txt_username.Text = userData("nama_pengguna")
        txt_email.Text = userData("email")
        txt_nis.Text = userData("nis")
        cmb_kelas.Text = userData("kelas_id")
        cmb_jenis_kelamin.Text = userData("jenis_kelamin")
        txt_tgl_lahir.Text = userData("tanggal_lahir")
        txt_nama_ayah.Text = userData("nama_ayah")
        txt_nama_ibu.Text = userData("nama_ibu")
        txt_alamat.Text = userData("alamat")

        ' Simpan ID atau username lama sebagai referensi update
        selectedUsername = userData("nama_pengguna")
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        EditUser(txt_nama,
            txt_username,
            txt_email,
            txt_nis,
            cmb_kelas,
            cmb_jenis_kelamin,
            txt_tgl_lahir,
            txt_nama_ayah,
            txt_nama_ibu,
            txt_alamat,
            selectedUsername)

        Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(New UserManagementAdmin)
    End Sub
End Class