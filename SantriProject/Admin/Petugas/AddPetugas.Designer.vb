<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPetugas
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
        Label15 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label10 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        btnKembali = New Button()
        btnSimpan = New Button()
        txtAlamat = New TextBox()
        cmbRole = New ComboBox()
        cmbJenisKelamin = New ComboBox()
        dtpTanggalLahir = New DateTimePicker()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        txtNama = New TextBox()
        txtNamaPengguna = New TextBox()
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
        TableLayoutPanel1.TabIndex = 3
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
        Label15.Text = "TAMBAH DATA PETUGAS"
        Label15.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(Label3, 0, 1)
        TableLayoutPanel2.Controls.Add(Label4, 1, 1)
        TableLayoutPanel2.Controls.Add(Label6, 1, 3)
        TableLayoutPanel2.Controls.Add(Label5, 0, 3)
        TableLayoutPanel2.Controls.Add(Label10, 1, 5)
        TableLayoutPanel2.Controls.Add(Label7, 0, 5)
        TableLayoutPanel2.Controls.Add(Label8, 0, 7)
        TableLayoutPanel2.Controls.Add(Label9, 1, 7)
        TableLayoutPanel2.Controls.Add(btnKembali, 0, 10)
        TableLayoutPanel2.Controls.Add(btnSimpan, 1, 10)
        TableLayoutPanel2.Controls.Add(txtAlamat, 0, 8)
        TableLayoutPanel2.Controls.Add(cmbRole, 1, 8)
        TableLayoutPanel2.Controls.Add(cmbJenisKelamin, 0, 6)
        TableLayoutPanel2.Controls.Add(dtpTanggalLahir, 1, 6)
        TableLayoutPanel2.Controls.Add(txtEmail, 0, 4)
        TableLayoutPanel2.Controls.Add(txtPassword, 1, 4)
        TableLayoutPanel2.Controls.Add(txtNama, 0, 2)
        TableLayoutPanel2.Controls.Add(txtNamaPengguna, 1, 2)
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Bottom
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(3, 47)
        Label3.Name = "Label3"
        Label3.Size = New Size(367, 15)
        Label3.TabIndex = 46
        Label3.Text = "Nama Lengkap"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Bottom
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(376, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(367, 15)
        Label4.TabIndex = 45
        Label4.Text = "Nama Pengguna"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Bottom
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(376, 109)
        Label6.Name = "Label6"
        Label6.Size = New Size(367, 15)
        Label6.TabIndex = 43
        Label6.Text = "Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Bottom
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(3, 109)
        Label5.Name = "Label5"
        Label5.Size = New Size(367, 15)
        Label5.TabIndex = 42
        Label5.Text = "Email Pengguna"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Dock = DockStyle.Bottom
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label10.Location = New Point(376, 171)
        Label10.Name = "Label10"
        Label10.Size = New Size(367, 15)
        Label10.TabIndex = 41
        Label10.Text = "Tanggal Lahir"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Dock = DockStyle.Bottom
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(3, 171)
        Label7.Name = "Label7"
        Label7.Size = New Size(367, 15)
        Label7.TabIndex = 40
        Label7.Text = "Jenis Kelamin"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Dock = DockStyle.Bottom
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(3, 233)
        Label8.Name = "Label8"
        Label8.Size = New Size(367, 15)
        Label8.TabIndex = 39
        Label8.Text = "Alamat Rumah"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Dock = DockStyle.Bottom
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label9.Location = New Point(376, 233)
        Label9.Name = "Label9"
        Label9.Size = New Size(367, 15)
        Label9.TabIndex = 38
        Label9.Text = "Role"
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(3, 313)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(75, 23)
        btnKembali.TabIndex = 15
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(376, 313)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 14
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(3, 251)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat"
        txtAlamat.Size = New Size(200, 23)
        txtAlamat.TabIndex = 33
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Location = New Point(376, 251)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(200, 23)
        cmbRole.TabIndex = 35
        ' 
        ' cmbJenisKelamin
        ' 
        cmbJenisKelamin.FormattingEnabled = True
        cmbJenisKelamin.Location = New Point(3, 189)
        cmbJenisKelamin.Name = "cmbJenisKelamin"
        cmbJenisKelamin.Size = New Size(200, 23)
        cmbJenisKelamin.TabIndex = 18
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(376, 189)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(200, 23)
        dtpTanggalLahir.TabIndex = 31
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(3, 127)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(200, 23)
        txtEmail.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(376, 127)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(200, 23)
        txtPassword.TabIndex = 4
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(3, 65)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama Lengkap"
        txtNama.Size = New Size(200, 23)
        txtNama.TabIndex = 0
        ' 
        ' txtNamaPengguna
        ' 
        txtNamaPengguna.Location = New Point(376, 65)
        txtNamaPengguna.Name = "txtNamaPengguna"
        txtNamaPengguna.PlaceholderText = "Username"
        txtNamaPengguna.Size = New Size(200, 23)
        txtNamaPengguna.TabIndex = 1
        ' 
        ' AddPetugas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddPetugas"
        Text = "AddPetugas"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label15 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents cmbJenisKelamin As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNamaPengguna As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtAyah As TextBox
    Friend WithEvents txtIbu As TextBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
