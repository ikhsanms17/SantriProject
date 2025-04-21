Imports MySql.Data.MySqlClient

Public Class UpdatePerizinan
    'Private selectedNoIzin As String = ""
    Public selectedNoIzin As String
    Dim conn As MySqlConnection = Database.GetConnection()
    Dim i As Integer
    Dim dr As MySqlDataReader


    Private Sub UpdatePerizinan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form agar bisa di-resize
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight

        ResizeControls(Me, scaleX, scaleY)

        'cmbStatusIzin.Items.Clear()
        'cmbStatusIzin.Items.Add("Dizinkan")
        'cmbStatusIzin.Items.Add("Tidak Dizinkan")

        'LoadUser(cmbUser)
    End Sub

    Public Sub LoadIzinData(userData As Dictionary(Of String, String))
        ' Load data ke form
        txt_nama_penjemput.Text = userData("nama_penjemput")
        dtpIzin.Value = Convert.ToDateTime(userData("tanggal_izin"))
        dtpBatasIzin.Value = Convert.ToDateTime(userData("tanggal_batas_izin"))
        dtpDatang.Value = Convert.ToDateTime(userData("tanggal_datang"))

        ' Muat ulang data user ke comboBox
        LoadUser(cmbUser)

        ' Tunggu sampai data user benar-benar termuat
        Application.DoEvents()

        ' Pastikan DisplayMember dan ValueMember sudah di-set di LoadUser()

        ' Set pengguna_id ke ComboBox berdasarkan ID
        If cmbUser.Items.Count > 0 Then
            cmbUser.SelectedValue = userData("pengguna_id")
        End If

        ' Kosongkan dan isi kembali daftar status izin
        cmbStatusIzin.Items.Clear()
        cmbStatusIzin.Items.Add("Dizinkan")
        cmbStatusIzin.Items.Add("Tidak Dizinkan")

        ' Set status (izin) ke ComboBox
        cmbStatusIzin.SelectedItem = userData("status")

        ' Simpan no_izin ke dalam variabel/global jika diperlukan
        selectedNoIzin = userData("no_izin")
    End Sub




    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Dim result As DialogResult = MessageBox.Show("Yakin untuk kembali? Data saat ini tidak akan disimpan.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
            parentForm.OpenChildForm(New PerizinanAdmin())
            Me.Close()
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        EditIzin(txt_nama_penjemput, dtpIzin, dtpBatasIzin, dtpDatang, cmbUser, cmbStatusIzin, selectedNoIzin)

        Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(New PerizinanAdmin)
    End Sub
End Class