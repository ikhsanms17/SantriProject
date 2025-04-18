Public Class AddUser
    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim result As DialogResult = MessageBox.Show("Yakin untuk kembali? Data saat ini tidak akan disimpan.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
            parentForm.OpenChildForm(New UserManagementAdmin())
            Me.Close()
        End If
    End Sub


    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        TambahUser(txt_nama,
            txt_username,
            txt_email,
            txt_nis,
            cmb_kelas,
            cmb_jenis_kelamin,
            txt_tgl_lahir,
            txt_nama_ayah,
            txt_nama_ibu,
            txt_alamat)

        Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(New UserManagementAdmin)
    End Sub

    Private Sub txt_nama_ayah_TextChanged(sender As Object, e As EventArgs) Handles txt_nama_ayah.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub
End Class