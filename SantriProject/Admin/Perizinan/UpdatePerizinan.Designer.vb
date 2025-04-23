<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdatePerizinan
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
        Label6 = New Label()
        Label4 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        BtnKembali = New Button()
        BtnSimpan = New Button()
        txtKeperluan = New TextBox()
        txtAlamatTujuan = New TextBox()
        txt_nama_penjemput = New TextBox()
        txtHubungan = New TextBox()
        cmbUser = New ComboBox()
        dtpIzin = New DateTimePicker()
        dtpBatasIzin = New DateTimePicker()
        dtpDatang = New DateTimePicker()
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
        TableLayoutPanel1.TabIndex = 4
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
        Label15.Text = "UBAH DATA PERIZINAN"
        Label15.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(Label6, 1, 5)
        TableLayoutPanel2.Controls.Add(Label4, 0, 5)
        TableLayoutPanel2.Controls.Add(Label11, 0, 8)
        TableLayoutPanel2.Controls.Add(Label12, 1, 8)
        TableLayoutPanel2.Controls.Add(Label5, 1, 1)
        TableLayoutPanel2.Controls.Add(Label3, 0, 1)
        TableLayoutPanel2.Controls.Add(Label8, 1, 3)
        TableLayoutPanel2.Controls.Add(Label7, 0, 3)
        TableLayoutPanel2.Controls.Add(BtnKembali, 0, 11)
        TableLayoutPanel2.Controls.Add(BtnSimpan, 1, 11)
        TableLayoutPanel2.Controls.Add(txtKeperluan, 0, 7)
        TableLayoutPanel2.Controls.Add(txtAlamatTujuan, 1, 7)
        TableLayoutPanel2.Controls.Add(txt_nama_penjemput, 0, 4)
        TableLayoutPanel2.Controls.Add(txtHubungan, 1, 4)
        TableLayoutPanel2.Controls.Add(cmbUser, 0, 2)
        TableLayoutPanel2.Controls.Add(dtpIzin, 1, 2)
        TableLayoutPanel2.Controls.Add(dtpBatasIzin, 1, 9)
        TableLayoutPanel2.Controls.Add(dtpDatang, 0, 9)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(27, 56)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 14
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.14396429F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.14396524F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.14396524F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.14396524F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.14396524F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.14396524F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 0.100015514F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.1821995F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.14396524F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.14396524F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.14396524F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0009813F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.71056032F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.71056032F))
        TableLayoutPanel2.Size = New Size(746, 376)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Bottom
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(376, 141)
        Label6.Name = "Label6"
        Label6.Size = New Size(367, 15)
        Label6.TabIndex = 114
        Label6.Text = "Alamat Tujuan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Bottom
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(3, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(367, 15)
        Label4.TabIndex = 113
        Label4.Text = "Keperluan"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Dock = DockStyle.Bottom
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label11.Location = New Point(3, 220)
        Label11.Name = "Label11"
        Label11.Size = New Size(367, 15)
        Label11.TabIndex = 110
        Label11.Text = "Tanggal Batas Izin"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Dock = DockStyle.Bottom
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label12.Location = New Point(376, 220)
        Label12.Name = "Label12"
        Label12.Size = New Size(367, 15)
        Label12.TabIndex = 109
        Label12.Text = "Tanggal Datang Kembali"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Bottom
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(376, 37)
        Label5.Name = "Label5"
        Label5.Size = New Size(367, 15)
        Label5.TabIndex = 104
        Label5.Text = "Tanggal Izin"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Bottom
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(3, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(367, 15)
        Label3.TabIndex = 103
        Label3.Text = "Nama Lengkap"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Dock = DockStyle.Bottom
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(376, 89)
        Label8.Name = "Label8"
        Label8.Size = New Size(367, 15)
        Label8.TabIndex = 102
        Label8.Text = "Hubungan"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Dock = DockStyle.Bottom
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(3, 89)
        Label7.Name = "Label7"
        Label7.Size = New Size(367, 15)
        Label7.TabIndex = 101
        Label7.Text = "Nama Penjemput"
        ' 
        ' BtnKembali
        ' 
        BtnKembali.Location = New Point(3, 290)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(75, 20)
        BtnKembali.TabIndex = 15
        BtnKembali.Text = "Kembali"
        BtnKembali.UseVisualStyleBackColor = True
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.Location = New Point(376, 290)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(75, 20)
        BtnSimpan.TabIndex = 14
        BtnSimpan.Text = "Simpan"
        BtnSimpan.UseVisualStyleBackColor = True
        ' 
        ' txtKeperluan
        ' 
        txtKeperluan.Location = New Point(3, 159)
        txtKeperluan.Multiline = True
        txtKeperluan.Name = "txtKeperluan"
        txtKeperluan.ScrollBars = ScrollBars.Vertical
        txtKeperluan.Size = New Size(200, 47)
        txtKeperluan.TabIndex = 89
        ' 
        ' txtAlamatTujuan
        ' 
        txtAlamatTujuan.Location = New Point(376, 159)
        txtAlamatTujuan.Multiline = True
        txtAlamatTujuan.Name = "txtAlamatTujuan"
        txtAlamatTujuan.ScrollBars = ScrollBars.Vertical
        txtAlamatTujuan.Size = New Size(200, 47)
        txtAlamatTujuan.TabIndex = 87
        ' 
        ' txt_nama_penjemput
        ' 
        txt_nama_penjemput.Location = New Point(3, 107)
        txt_nama_penjemput.Name = "txt_nama_penjemput"
        txt_nama_penjemput.PlaceholderText = "Nama Penjemput"
        txt_nama_penjemput.Size = New Size(200, 23)
        txt_nama_penjemput.TabIndex = 50
        ' 
        ' txtHubungan
        ' 
        txtHubungan.Location = New Point(376, 107)
        txtHubungan.Name = "txtHubungan"
        txtHubungan.PlaceholderText = "Hubungan"
        txtHubungan.Size = New Size(200, 23)
        txtHubungan.TabIndex = 90
        ' 
        ' cmbUser
        ' 
        cmbUser.FormattingEnabled = True
        cmbUser.Location = New Point(3, 55)
        cmbUser.Name = "cmbUser"
        cmbUser.Size = New Size(200, 23)
        cmbUser.TabIndex = 75
        ' 
        ' dtpIzin
        ' 
        dtpIzin.Location = New Point(376, 55)
        dtpIzin.Name = "dtpIzin"
        dtpIzin.Size = New Size(200, 23)
        dtpIzin.TabIndex = 30
        ' 
        ' dtpBatasIzin
        ' 
        dtpBatasIzin.Location = New Point(376, 238)
        dtpBatasIzin.Name = "dtpBatasIzin"
        dtpBatasIzin.Size = New Size(200, 23)
        dtpBatasIzin.TabIndex = 52
        ' 
        ' dtpDatang
        ' 
        dtpDatang.Location = New Point(3, 238)
        dtpDatang.Name = "dtpDatang"
        dtpDatang.Size = New Size(200, 23)
        dtpDatang.TabIndex = 32
        ' 
        ' UpdatePerizinan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "UpdatePerizinan"
        Text = "UpdatePerizinan"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label15 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnKembali As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents txtKeperluan As TextBox
    Friend WithEvents txtAlamatTujuan As TextBox
    Friend WithEvents txt_nama_penjemput As TextBox
    Friend WithEvents txtHubungan As TextBox
    Friend WithEvents cmbUser As ComboBox
    Friend WithEvents dtpIzin As DateTimePicker
    Friend WithEvents dtpBatasIzin As DateTimePicker
    Friend WithEvents dtpDatang As DateTimePicker
End Class
