<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KelasAdmin
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
        txtSearch = New TextBox()
        Label1 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        DGView1 = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewButtonColumn1 = New DataGridViewButtonColumn()
        DataGridViewButtonColumn2 = New DataGridViewButtonColumn()
        TableLayoutPanel4 = New TableLayoutPanel()
        btnKembali = New Button()
        btnReset = New Button()
        btnTambahKelas = New Button()
        Label2 = New Label()
        Label3 = New Label()
        txt_nama = New TextBox()
        txt_deskripsi = New TextBox()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(DGView1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 94F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 1, 1)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 1, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 3F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 82F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 3F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel2.Controls.Add(txtSearch, 2, 0)
        TableLayoutPanel2.Controls.Add(Label1, 1, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(27, 16)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(746, 48)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' txtSearch
        ' 
        txtSearch.Dock = DockStyle.Bottom
        txtSearch.Location = New Point(524, 22)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari Kelas"
        txtSearch.Size = New Size(219, 23)
        txtSearch.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(77, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(441, 21)
        Label1.TabIndex = 6
        Label1.Text = "KELAS MANAGEMENT"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel3.Controls.Add(DGView1, 1, 0)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel4, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(27, 70)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(746, 363)
        TableLayoutPanel3.TabIndex = 2
        ' 
        ' DGView1
        ' 
        DGView1.AllowUserToAddRows = False
        DGView1.AllowUserToDeleteRows = False
        DGView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGView1.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewButtonColumn1, DataGridViewButtonColumn2})
        DGView1.Dock = DockStyle.Fill
        DGView1.Location = New Point(226, 3)
        DGView1.Name = "DGView1"
        DGView1.ReadOnly = True
        DGView1.RowHeadersVisible = False
        DGView1.Size = New Size(517, 357)
        DGView1.TabIndex = 2
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "ID"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "Nama Kelas"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.HeaderText = "Deskripsi Kelas"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        ' 
        ' DataGridViewButtonColumn1
        ' 
        DataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewButtonColumn1.HeaderText = "Edit"
        DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        DataGridViewButtonColumn1.ReadOnly = True
        DataGridViewButtonColumn1.Text = ""
        DataGridViewButtonColumn1.UseColumnTextForButtonValue = True
        DataGridViewButtonColumn1.Width = 33
        ' 
        ' DataGridViewButtonColumn2
        ' 
        DataGridViewButtonColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewButtonColumn2.HeaderText = "Hapus"
        DataGridViewButtonColumn2.Name = "DataGridViewButtonColumn2"
        DataGridViewButtonColumn2.ReadOnly = True
        DataGridViewButtonColumn2.Text = ""
        DataGridViewButtonColumn2.UseColumnTextForButtonValue = True
        DataGridViewButtonColumn2.Width = 47
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Controls.Add(btnKembali, 0, 6)
        TableLayoutPanel4.Controls.Add(btnReset, 0, 5)
        TableLayoutPanel4.Controls.Add(btnTambahKelas, 0, 4)
        TableLayoutPanel4.Controls.Add(Label2, 0, 0)
        TableLayoutPanel4.Controls.Add(Label3, 0, 2)
        TableLayoutPanel4.Controls.Add(txt_nama, 0, 1)
        TableLayoutPanel4.Controls.Add(txt_deskripsi, 0, 3)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 7
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel4.Size = New Size(217, 357)
        TableLayoutPanel4.TabIndex = 3
        ' 
        ' btnKembali
        ' 
        btnKembali.Dock = DockStyle.Bottom
        btnKembali.Location = New Point(3, 331)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(211, 23)
        btnKembali.TabIndex = 21
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Dock = DockStyle.Bottom
        btnReset.Location = New Point(3, 274)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(211, 23)
        btnReset.TabIndex = 20
        btnReset.Text = "Reset Data"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnTambahKelas
        ' 
        btnTambahKelas.Dock = DockStyle.Bottom
        btnTambahKelas.Location = New Point(3, 239)
        btnTambahKelas.Name = "btnTambahKelas"
        btnTambahKelas.Size = New Size(211, 23)
        btnTambahKelas.TabIndex = 19
        btnTambahKelas.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Bottom
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(3, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(211, 15)
        Label2.TabIndex = 15
        Label2.Text = "NAMA KELAS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Bottom
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(3, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(211, 15)
        Label3.TabIndex = 16
        Label3.Text = "DESKRIPSI KELAS"
        ' 
        ' txt_nama
        ' 
        txt_nama.Dock = DockStyle.Bottom
        txt_nama.Location = New Point(3, 62)
        txt_nama.Name = "txt_nama"
        txt_nama.Size = New Size(211, 23)
        txt_nama.TabIndex = 17
        ' 
        ' txt_deskripsi
        ' 
        txt_deskripsi.Dock = DockStyle.Fill
        txt_deskripsi.Location = New Point(3, 144)
        txt_deskripsi.Multiline = True
        txt_deskripsi.Name = "txt_deskripsi"
        txt_deskripsi.ScrollBars = ScrollBars.Vertical
        txt_deskripsi.Size = New Size(211, 47)
        txt_deskripsi.TabIndex = 18
        ' 
        ' KelasAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "KelasAdmin"
        Text = "KelasAdmin"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        CType(DGView1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DGView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewButtonColumn2 As DataGridViewButtonColumn
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_deskripsi As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnTambahKelas As Button
    Friend WithEvents btnKembali As Button
End Class
