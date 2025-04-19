<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagementAdmin
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
        DGView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        btnEdit = New DataGridViewButtonColumn()
        btnHapus = New DataGridViewButtonColumn()
        TableLayoutPanel2 = New TableLayoutPanel()
        btnTambahUser = New Button()
        txtSearch = New TextBox()
        Label1 = New Label()
        TableLayoutPanel1.SuspendLayout()
        CType(DGView1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 94F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3F))
        TableLayoutPanel1.Controls.Add(DGView1, 1, 2)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 3F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 82F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 3F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' DGView1
        ' 
        DGView1.AllowUserToAddRows = False
        DGView1.AllowUserToDeleteRows = False
        DGView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column3, Column2, Column4, Column5, Column6, Column7, Column8, Column9, Column10, btnEdit, btnHapus})
        DGView1.Dock = DockStyle.Fill
        DGView1.Location = New Point(27, 70)
        DGView1.Name = "DGView1"
        DGView1.ReadOnly = True
        DGView1.RowHeadersVisible = False
        DGView1.Size = New Size(746, 363)
        DGView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Nama"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Nama Pengguna"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 111
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Email"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "NIS"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column5.HeaderText = "Kelas"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Jenis Kelamin"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 95
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "Tanggal Lahir"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 95
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column8.HeaderText = "Ayah"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column9.HeaderText = "Ibu"
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        ' 
        ' Column10
        ' 
        Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column10.HeaderText = "Alamat"
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        ' 
        ' btnEdit
        ' 
        btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        btnEdit.HeaderText = "Edit"
        btnEdit.Name = "btnEdit"
        btnEdit.ReadOnly = True
        btnEdit.Text = ""
        btnEdit.UseColumnTextForButtonValue = True
        btnEdit.Width = 33
        ' 
        ' btnHapus
        ' 
        btnHapus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        btnHapus.HeaderText = "Hapus"
        btnHapus.Name = "btnHapus"
        btnHapus.ReadOnly = True
        btnHapus.Text = ""
        btnHapus.UseColumnTextForButtonValue = True
        btnHapus.Width = 47
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel2.Controls.Add(btnTambahUser, 0, 0)
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
        ' btnTambahUser
        ' 
        btnTambahUser.Dock = DockStyle.Bottom
        btnTambahUser.Location = New Point(3, 22)
        btnTambahUser.Name = "btnTambahUser"
        btnTambahUser.Size = New Size(68, 23)
        btnTambahUser.TabIndex = 4
        btnTambahUser.Text = "Tambah"
        btnTambahUser.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Dock = DockStyle.Bottom
        txtSearch.Location = New Point(524, 22)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari Santri"
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
        Label1.Text = "USER MANAGEMENT"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' UserManagementAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.PapayaWhip
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "UserManagementAdmin"
        Text = "UserManagementAdmin"
        TableLayoutPanel1.ResumeLayout(False)
        CType(DGView1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DGView1 As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnTambahUser As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents btnEdit As DataGridViewButtonColumn
    Friend WithEvents btnHapus As DataGridViewButtonColumn
End Class
