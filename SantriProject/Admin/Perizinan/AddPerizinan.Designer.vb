<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPerizinan
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
        Label9 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label3 = New Label()
        dtpBatasIzin = New DateTimePicker()
        txt_nama_penjemput = New TextBox()
        dtpIzin = New DateTimePicker()
        dtpDatang = New DateTimePicker()
        BtnKembali = New Button()
        BtnSimpan = New Button()
        cmbUser = New ComboBox()
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
        Label15.Text = "TAMBAH PERIZINAN"
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(Label6, 0, 6)
        TableLayoutPanel2.Controls.Add(Label9, 0, 4)
        TableLayoutPanel2.Controls.Add(Label5, 1, 2)
        TableLayoutPanel2.Controls.Add(Label7, 1, 4)
        TableLayoutPanel2.Controls.Add(Label3, 0, 2)
        TableLayoutPanel2.Controls.Add(dtpBatasIzin, 1, 5)
        TableLayoutPanel2.Controls.Add(txt_nama_penjemput, 1, 3)
        TableLayoutPanel2.Controls.Add(dtpIzin, 0, 5)
        TableLayoutPanel2.Controls.Add(dtpDatang, 0, 7)
        TableLayoutPanel2.Controls.Add(BtnKembali, 0, 9)
        TableLayoutPanel2.Controls.Add(BtnSimpan, 1, 9)
        TableLayoutPanel2.Controls.Add(cmbUser, 0, 3)
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
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Bottom
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(3, 202)
        Label6.Name = "Label6"
        Label6.Size = New Size(367, 15)
        Label6.TabIndex = 74
        Label6.Text = "Tanggal Datang Kembali"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Dock = DockStyle.Bottom
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label9.Location = New Point(3, 140)
        Label9.Name = "Label9"
        Label9.Size = New Size(367, 15)
        Label9.TabIndex = 73
        Label9.Text = "Tanggal Izin"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Bottom
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(376, 78)
        Label5.Name = "Label5"
        Label5.Size = New Size(367, 15)
        Label5.TabIndex = 68
        Label5.Text = "Nama Penjemput"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Dock = DockStyle.Bottom
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(376, 140)
        Label7.Name = "Label7"
        Label7.Size = New Size(367, 15)
        Label7.TabIndex = 67
        Label7.Text = "Tanggal Batas Izin"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Bottom
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(3, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(367, 15)
        Label3.TabIndex = 62
        Label3.Text = "Nama Lengkap"
        ' 
        ' dtpBatasIzin
        ' 
        dtpBatasIzin.Location = New Point(376, 158)
        dtpBatasIzin.Name = "dtpBatasIzin"
        dtpBatasIzin.Size = New Size(200, 23)
        dtpBatasIzin.TabIndex = 52
        ' 
        ' txt_nama_penjemput
        ' 
        txt_nama_penjemput.Location = New Point(376, 96)
        txt_nama_penjemput.Name = "txt_nama_penjemput"
        txt_nama_penjemput.PlaceholderText = "Nama Penjemput"
        txt_nama_penjemput.Size = New Size(200, 23)
        txt_nama_penjemput.TabIndex = 50
        ' 
        ' dtpIzin
        ' 
        dtpIzin.Location = New Point(3, 158)
        dtpIzin.Name = "dtpIzin"
        dtpIzin.Size = New Size(200, 23)
        dtpIzin.TabIndex = 30
        ' 
        ' dtpDatang
        ' 
        dtpDatang.Location = New Point(3, 220)
        dtpDatang.Name = "dtpDatang"
        dtpDatang.Size = New Size(200, 23)
        dtpDatang.TabIndex = 32
        ' 
        ' BtnKembali
        ' 
        BtnKembali.Location = New Point(3, 282)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(75, 23)
        BtnKembali.TabIndex = 15
        BtnKembali.Text = "Kembali"
        BtnKembali.UseVisualStyleBackColor = True
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.Location = New Point(376, 282)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(75, 23)
        BtnSimpan.TabIndex = 14
        BtnSimpan.Text = "Simpan"
        BtnSimpan.UseVisualStyleBackColor = True
        ' 
        ' cmbUser
        ' 
        cmbUser.FormattingEnabled = True
        cmbUser.Location = New Point(3, 96)
        cmbUser.Name = "cmbUser"
        cmbUser.Size = New Size(200, 23)
        cmbUser.TabIndex = 75
        ' 
        ' AddPerizinan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddPerizinan"
        Text = "AddPerizinan"
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
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpBatasIzin As DateTimePicker
    Friend WithEvents txt_nama_penjemput As TextBox
    Friend WithEvents dtpIzin As DateTimePicker
    Friend WithEvents dtpDatang As DateTimePicker
    Friend WithEvents BtnKembali As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents cmbUser As ComboBox
End Class
