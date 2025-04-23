<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTransaksi
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
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        BtnKembali = New Button()
        BtnSimpan = New Button()
        txtKeterangan = New TextBox()
        txtJumlah = New TextBox()
        cmbJenisTr = New ComboBox()
        dtpTanggalTransaksi = New DateTimePicker()
        cmbMetode = New ComboBox()
        cmbPetugas = New ComboBox()
        cmbUser = New ComboBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        btnUpload = New Button()
        txtFilename = New TextBox()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
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
        Label15.Text = "TAMBAH TRANSAKSI"
        Label15.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(Label8, 1, 2)
        TableLayoutPanel2.Controls.Add(Label7, 0, 2)
        TableLayoutPanel2.Controls.Add(Label6, 1, 4)
        TableLayoutPanel2.Controls.Add(Label4, 0, 4)
        TableLayoutPanel2.Controls.Add(Label10, 1, 6)
        TableLayoutPanel2.Controls.Add(Label9, 0, 6)
        TableLayoutPanel2.Controls.Add(Label11, 0, 8)
        TableLayoutPanel2.Controls.Add(Label12, 1, 8)
        TableLayoutPanel2.Controls.Add(BtnKembali, 0, 11)
        TableLayoutPanel2.Controls.Add(BtnSimpan, 1, 11)
        TableLayoutPanel2.Controls.Add(txtKeterangan, 1, 9)
        TableLayoutPanel2.Controls.Add(txtJumlah, 0, 7)
        TableLayoutPanel2.Controls.Add(cmbJenisTr, 1, 7)
        TableLayoutPanel2.Controls.Add(dtpTanggalTransaksi, 0, 5)
        TableLayoutPanel2.Controls.Add(cmbMetode, 1, 5)
        TableLayoutPanel2.Controls.Add(cmbPetugas, 0, 3)
        TableLayoutPanel2.Controls.Add(cmbUser, 1, 3)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 9)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(27, 56)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 14
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.142857F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.142857F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.142857F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.142857F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.142857F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.142857F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.142857F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.142857F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.142857F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.142857F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.142857F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.142857F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.142857F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.142857F))
        TableLayoutPanel2.Size = New Size(746, 376)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Dock = DockStyle.Bottom
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(376, 63)
        Label8.Name = "Label8"
        Label8.Size = New Size(367, 15)
        Label8.TabIndex = 126
        Label8.Text = "Nama Santri"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Dock = DockStyle.Bottom
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(3, 63)
        Label7.Name = "Label7"
        Label7.Size = New Size(367, 15)
        Label7.TabIndex = 125
        Label7.Text = "Nama Petugas"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Bottom
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(376, 115)
        Label6.Name = "Label6"
        Label6.Size = New Size(367, 15)
        Label6.TabIndex = 124
        Label6.Text = "Metode Transaksi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Bottom
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(3, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(367, 15)
        Label4.TabIndex = 123
        Label4.Text = "Tanggal Transaksi"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Dock = DockStyle.Bottom
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label10.Location = New Point(376, 167)
        Label10.Name = "Label10"
        Label10.Size = New Size(367, 15)
        Label10.TabIndex = 122
        Label10.Text = "Jenis Transaksi"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Dock = DockStyle.Bottom
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label9.Location = New Point(3, 167)
        Label9.Name = "Label9"
        Label9.Size = New Size(367, 15)
        Label9.TabIndex = 121
        Label9.Text = "Jumlah Transaksi"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Dock = DockStyle.Bottom
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label11.Location = New Point(3, 219)
        Label11.Name = "Label11"
        Label11.Size = New Size(367, 15)
        Label11.TabIndex = 110
        Label11.Text = "Upload Bukti"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Dock = DockStyle.Bottom
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label12.Location = New Point(376, 219)
        Label12.Name = "Label12"
        Label12.Size = New Size(367, 15)
        Label12.TabIndex = 109
        Label12.Text = "Keterangan"
        ' 
        ' BtnKembali
        ' 
        BtnKembali.Location = New Point(3, 289)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(75, 20)
        BtnKembali.TabIndex = 15
        BtnKembali.Text = "Kembali"
        BtnKembali.UseVisualStyleBackColor = True
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.Location = New Point(376, 289)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(75, 20)
        BtnSimpan.TabIndex = 14
        BtnSimpan.Text = "Simpan"
        BtnSimpan.UseVisualStyleBackColor = True
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.Location = New Point(376, 237)
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.PlaceholderText = "Keterangan"
        txtKeterangan.Size = New Size(200, 23)
        txtKeterangan.TabIndex = 118
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Location = New Point(3, 185)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.PlaceholderText = "Jumlah Transaksi"
        txtJumlah.Size = New Size(200, 23)
        txtJumlah.TabIndex = 50
        ' 
        ' cmbJenisTr
        ' 
        cmbJenisTr.FormattingEnabled = True
        cmbJenisTr.Location = New Point(376, 185)
        cmbJenisTr.Name = "cmbJenisTr"
        cmbJenisTr.Size = New Size(200, 23)
        cmbJenisTr.TabIndex = 117
        ' 
        ' dtpTanggalTransaksi
        ' 
        dtpTanggalTransaksi.Location = New Point(3, 133)
        dtpTanggalTransaksi.Name = "dtpTanggalTransaksi"
        dtpTanggalTransaksi.Size = New Size(200, 23)
        dtpTanggalTransaksi.TabIndex = 30
        ' 
        ' cmbMetode
        ' 
        cmbMetode.FormattingEnabled = True
        cmbMetode.Location = New Point(376, 133)
        cmbMetode.Name = "cmbMetode"
        cmbMetode.Size = New Size(200, 23)
        cmbMetode.TabIndex = 116
        ' 
        ' cmbPetugas
        ' 
        cmbPetugas.FormattingEnabled = True
        cmbPetugas.Location = New Point(3, 81)
        cmbPetugas.Name = "cmbPetugas"
        cmbPetugas.Size = New Size(200, 23)
        cmbPetugas.TabIndex = 75
        ' 
        ' cmbUser
        ' 
        cmbUser.FormattingEnabled = True
        cmbUser.Location = New Point(376, 81)
        cmbUser.Name = "cmbUser"
        cmbUser.Size = New Size(200, 23)
        cmbUser.TabIndex = 115
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60.5898132F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 39.4101868F))
        TableLayoutPanel3.Controls.Add(btnUpload, 1, 0)
        TableLayoutPanel3.Controls.Add(txtFilename, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 234)
        TableLayoutPanel3.Margin = New Padding(0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(373, 26)
        TableLayoutPanel3.TabIndex = 127
        ' 
        ' btnUpload
        ' 
        btnUpload.Location = New Point(229, 3)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(75, 20)
        btnUpload.TabIndex = 0
        btnUpload.Text = "Upload"
        btnUpload.UseVisualStyleBackColor = True
        ' 
        ' txtFilename
        ' 
        txtFilename.Location = New Point(3, 3)
        txtFilename.Name = "txtFilename"
        txtFilename.PlaceholderText = "Filename"
        txtFilename.Size = New Size(200, 23)
        txtFilename.TabIndex = 1
        ' 
        ' AddTransaksi
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddTransaksi"
        Text = "AddTransaksi"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label15 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents cmbJenisTr As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnKembali As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents cmbPetugas As ComboBox
    Friend WithEvents cmbUser As ComboBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents dtpTanggalTransaksi As DateTimePicker
    Friend WithEvents cmbMetode As ComboBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnUpload As Button
    Friend WithEvents txtFilename As TextBox
End Class
