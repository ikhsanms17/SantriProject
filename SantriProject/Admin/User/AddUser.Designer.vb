<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        txt_nama = New TextBox()
        txt_username = New TextBox()
        txt_email = New TextBox()
        txt_nis = New TextBox()
        txt_nama_ayah = New TextBox()
        txt_alamat = New TextBox()
        txt_nama_ibu = New TextBox()
        BtnSimpan = New Button()
        BtnKembali = New Button()
        cmb_kelas = New ComboBox()
        cmb_jenis_kelamin = New ComboBox()
        txt_tgl_lahir = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label15 = New Label()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 94F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3F))
        TableLayoutPanel1.Controls.Add(Label15, 1, 1)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 1, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 3F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 85F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 3F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(Label10, 1, 8)
        TableLayoutPanel2.Controls.Add(Label9, 0, 8)
        TableLayoutPanel2.Controls.Add(Label8, 1, 6)
        TableLayoutPanel2.Controls.Add(Label7, 0, 6)
        TableLayoutPanel2.Controls.Add(Label6, 1, 4)
        TableLayoutPanel2.Controls.Add(Label5, 0, 4)
        TableLayoutPanel2.Controls.Add(Label4, 1, 2)
        TableLayoutPanel2.Controls.Add(Label3, 0, 2)
        TableLayoutPanel2.Controls.Add(Label2, 1, 0)
        TableLayoutPanel2.Controls.Add(BtnSimpan, 1, 11)
        TableLayoutPanel2.Controls.Add(BtnKembali, 0, 11)
        TableLayoutPanel2.Controls.Add(cmb_jenis_kelamin, 0, 5)
        TableLayoutPanel2.Controls.Add(cmb_kelas, 1, 5)
        TableLayoutPanel2.Controls.Add(txt_nama, 0, 1)
        TableLayoutPanel2.Controls.Add(txt_username, 1, 1)
        TableLayoutPanel2.Controls.Add(txt_email, 0, 3)
        TableLayoutPanel2.Controls.Add(txt_nis, 1, 3)
        TableLayoutPanel2.Controls.Add(txt_nama_ayah, 1, 7)
        TableLayoutPanel2.Controls.Add(txt_tgl_lahir, 0, 7)
        TableLayoutPanel2.Controls.Add(txt_nama_ibu, 1, 9)
        TableLayoutPanel2.Controls.Add(txt_alamat, 0, 9)
        TableLayoutPanel2.Controls.Add(Label1, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(27, 56)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 12
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 6.25F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 6.25F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 6.25F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 6.25F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 6.25F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 6.25F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 6.25F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 6.25F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 6.25F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 6.25F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 6.25F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 6.25F))
        TableLayoutPanel2.Size = New Size(746, 376)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' txt_nama
        ' 
        txt_nama.Location = New Point(3, 34)
        txt_nama.Name = "txt_nama"
        txt_nama.PlaceholderText = "Nama Lengkap"
        txt_nama.Size = New Size(200, 23)
        txt_nama.TabIndex = 0
        ' 
        ' txt_username
        ' 
        txt_username.Location = New Point(376, 34)
        txt_username.Name = "txt_username"
        txt_username.PlaceholderText = "Username"
        txt_username.Size = New Size(200, 23)
        txt_username.TabIndex = 1
        ' 
        ' txt_email
        ' 
        txt_email.Location = New Point(3, 96)
        txt_email.Name = "txt_email"
        txt_email.PlaceholderText = "Email"
        txt_email.Size = New Size(200, 23)
        txt_email.TabIndex = 2
        ' 
        ' txt_nis
        ' 
        txt_nis.Location = New Point(376, 96)
        txt_nis.Name = "txt_nis"
        txt_nis.PlaceholderText = "NIS"
        txt_nis.Size = New Size(200, 23)
        txt_nis.TabIndex = 4
        ' 
        ' txt_nama_ayah
        ' 
        txt_nama_ayah.Location = New Point(376, 220)
        txt_nama_ayah.Name = "txt_nama_ayah"
        txt_nama_ayah.PlaceholderText = "Ayah"
        txt_nama_ayah.Size = New Size(200, 23)
        txt_nama_ayah.TabIndex = 7
        ' 
        ' txt_alamat
        ' 
        txt_alamat.Location = New Point(3, 282)
        txt_alamat.Name = "txt_alamat"
        txt_alamat.PlaceholderText = "Alamat"
        txt_alamat.Size = New Size(200, 23)
        txt_alamat.TabIndex = 8
        ' 
        ' txt_nama_ibu
        ' 
        txt_nama_ibu.Location = New Point(376, 282)
        txt_nama_ibu.Name = "txt_nama_ibu"
        txt_nama_ibu.PlaceholderText = "Ibu"
        txt_nama_ibu.Size = New Size(200, 23)
        txt_nama_ibu.TabIndex = 12
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.Location = New Point(376, 344)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(75, 23)
        BtnSimpan.TabIndex = 14
        BtnSimpan.Text = "Simpan"
        BtnSimpan.UseVisualStyleBackColor = True
        ' 
        ' BtnKembali
        ' 
        BtnKembali.Location = New Point(3, 344)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(75, 23)
        BtnKembali.TabIndex = 15
        BtnKembali.Text = "Kembali"
        BtnKembali.UseVisualStyleBackColor = True
        ' 
        ' cmb_kelas
        ' 
        cmb_kelas.FormattingEnabled = True
        cmb_kelas.Location = New Point(376, 158)
        cmb_kelas.Name = "cmb_kelas"
        cmb_kelas.Size = New Size(200, 23)
        cmb_kelas.TabIndex = 17
        ' 
        ' cmb_jenis_kelamin
        ' 
        cmb_jenis_kelamin.FormattingEnabled = True
        cmb_jenis_kelamin.Location = New Point(3, 158)
        cmb_jenis_kelamin.Name = "cmb_jenis_kelamin"
        cmb_jenis_kelamin.Size = New Size(200, 23)
        cmb_jenis_kelamin.TabIndex = 18
        ' 
        ' txt_tgl_lahir
        ' 
        txt_tgl_lahir.Location = New Point(3, 220)
        txt_tgl_lahir.Name = "txt_tgl_lahir"
        txt_tgl_lahir.Size = New Size(200, 23)
        txt_tgl_lahir.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Bottom
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(3, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(367, 15)
        Label1.TabIndex = 20
        Label1.Text = "Nama Lengkap"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Bottom
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(376, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(367, 15)
        Label2.TabIndex = 21
        Label2.Text = "Nama Pengguna"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Bottom
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(3, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(367, 15)
        Label3.TabIndex = 22
        Label3.Text = "Email Pengguna"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Bottom
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(376, 78)
        Label4.Name = "Label4"
        Label4.Size = New Size(367, 15)
        Label4.TabIndex = 23
        Label4.Text = "Nomor Induk Siswa"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Bottom
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(3, 140)
        Label5.Name = "Label5"
        Label5.Size = New Size(367, 15)
        Label5.TabIndex = 24
        Label5.Text = "Jenis Kelamin"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Bottom
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(376, 140)
        Label6.Name = "Label6"
        Label6.Size = New Size(367, 15)
        Label6.TabIndex = 25
        Label6.Text = "Kelas"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Dock = DockStyle.Bottom
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(3, 202)
        Label7.Name = "Label7"
        Label7.Size = New Size(367, 15)
        Label7.TabIndex = 26
        Label7.Text = "Tanggal Lahir"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Dock = DockStyle.Bottom
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(376, 202)
        Label8.Name = "Label8"
        Label8.Size = New Size(367, 15)
        Label8.TabIndex = 27
        Label8.Text = "Nama Ayah"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Dock = DockStyle.Bottom
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label9.Location = New Point(3, 264)
        Label9.Name = "Label9"
        Label9.Size = New Size(367, 15)
        Label9.TabIndex = 28
        Label9.Text = "Alamat Rumah"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Dock = DockStyle.Bottom
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label10.Location = New Point(376, 264)
        Label10.Name = "Label10"
        Label10.Size = New Size(367, 15)
        Label10.TabIndex = 29
        Label10.Text = "Nama Ibu"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Dock = DockStyle.Fill
        Label15.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(27, 13)
        Label15.Name = "Label15"
        Label15.Size = New Size(746, 40)
        Label15.TabIndex = 6
        Label15.Text = "TAMBAH PENGGUNA"
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' AddUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.PapayaWhip
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddUser"
        Text = "AddUser"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_nis As TextBox
    Friend WithEvents txt_nama_ayah As TextBox
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents txt_nama_ibu As TextBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnKembali As Button
    Friend WithEvents cmb_kelas As ComboBox
    Friend WithEvents cmb_jenis_kelamin As ComboBox
    Friend WithEvents txt_tgl_lahir As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
End Class
