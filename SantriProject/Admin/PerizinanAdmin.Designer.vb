<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PerizinanAdmin
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
        Button1 = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        DGView1 = New DataGridView()
        DataGridViewTextBoxColumn51 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn52 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn54 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn55 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn56 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn57 = New DataGridViewTextBoxColumn()
        statusCombo = New DataGridViewComboBoxColumn()
        DataGridViewButtonColumn11 = New DataGridViewButtonColumn()
        DataGridViewButtonColumn12 = New DataGridViewButtonColumn()
        TableLayoutPanel4 = New TableLayoutPanel()
        btnTambahIzin = New Button()
        btnKembali = New Button()
        Label2 = New Label()
        TextBox1 = New TextBox()
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
        TableLayoutPanel1.Controls.Add(Button1, 0, 0)
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
        ' Button1
        ' 
        Button1.Dock = DockStyle.Bottom
        Button1.Location = New Point(3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(18, 7)
        Button1.TabIndex = 11
        Button1.Text = "Tambah"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 75F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.Controls.Add(TextBox1, 1, 0)
        TableLayoutPanel2.Controls.Add(Label2, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(27, 16)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(746, 48)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(DGView1, 0, 0)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel4, 0, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(27, 70)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 90F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel3.Size = New Size(746, 363)
        TableLayoutPanel3.TabIndex = 10
        ' 
        ' DGView1
        ' 
        DGView1.AllowUserToAddRows = False
        DGView1.AllowUserToDeleteRows = False
        DGView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGView1.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn51, DataGridViewTextBoxColumn52, DataGridViewTextBoxColumn54, DataGridViewTextBoxColumn55, DataGridViewTextBoxColumn56, DataGridViewTextBoxColumn57, statusCombo, DataGridViewButtonColumn11, DataGridViewButtonColumn12})
        DGView1.Dock = DockStyle.Fill
        DGView1.Location = New Point(3, 3)
        DGView1.Name = "DGView1"
        DGView1.ReadOnly = True
        DGView1.RowHeadersVisible = False
        DGView1.Size = New Size(740, 320)
        DGView1.TabIndex = 10
        ' 
        ' DataGridViewTextBoxColumn51
        ' 
        DataGridViewTextBoxColumn51.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn51.HeaderText = "No Surat"
        DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        DataGridViewTextBoxColumn51.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn52
        ' 
        DataGridViewTextBoxColumn52.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn52.HeaderText = "Nama Pengguna"
        DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        DataGridViewTextBoxColumn52.ReadOnly = True
        DataGridViewTextBoxColumn52.Width = 111
        ' 
        ' DataGridViewTextBoxColumn54
        ' 
        DataGridViewTextBoxColumn54.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn54.HeaderText = "Nama Penjemput"
        DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        DataGridViewTextBoxColumn54.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn55
        ' 
        DataGridViewTextBoxColumn55.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn55.HeaderText = "Tanggal Izin"
        DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        DataGridViewTextBoxColumn55.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn56
        ' 
        DataGridViewTextBoxColumn56.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn56.HeaderText = "Tanggal Batas Izin"
        DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        DataGridViewTextBoxColumn56.ReadOnly = True
        DataGridViewTextBoxColumn56.Width = 99
        ' 
        ' DataGridViewTextBoxColumn57
        ' 
        DataGridViewTextBoxColumn57.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn57.HeaderText = "Tanggal Kembali"
        DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        DataGridViewTextBoxColumn57.ReadOnly = True
        DataGridViewTextBoxColumn57.Width = 110
        ' 
        ' statusCombo
        ' 
        statusCombo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        statusCombo.HeaderText = "Status Izin"
        statusCombo.Name = "statusCombo"
        statusCombo.ReadOnly = True
        statusCombo.Resizable = DataGridViewTriState.True
        statusCombo.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' DataGridViewButtonColumn11
        ' 
        DataGridViewButtonColumn11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewButtonColumn11.HeaderText = "Edit"
        DataGridViewButtonColumn11.Name = "DataGridViewButtonColumn11"
        DataGridViewButtonColumn11.ReadOnly = True
        DataGridViewButtonColumn11.Text = ""
        DataGridViewButtonColumn11.UseColumnTextForButtonValue = True
        DataGridViewButtonColumn11.Width = 33
        ' 
        ' DataGridViewButtonColumn12
        ' 
        DataGridViewButtonColumn12.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewButtonColumn12.HeaderText = "Hapus"
        DataGridViewButtonColumn12.Name = "DataGridViewButtonColumn12"
        DataGridViewButtonColumn12.ReadOnly = True
        DataGridViewButtonColumn12.Text = ""
        DataGridViewButtonColumn12.UseColumnTextForButtonValue = True
        DataGridViewButtonColumn12.Width = 47
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 3
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15F))
        TableLayoutPanel4.Controls.Add(btnTambahIzin, 2, 0)
        TableLayoutPanel4.Controls.Add(btnKembali, 0, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 329)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Size = New Size(740, 31)
        TableLayoutPanel4.TabIndex = 11
        ' 
        ' btnTambahIzin
        ' 
        btnTambahIzin.Dock = DockStyle.Fill
        btnTambahIzin.Location = New Point(632, 3)
        btnTambahIzin.Name = "btnTambahIzin"
        btnTambahIzin.Size = New Size(105, 25)
        btnTambahIzin.TabIndex = 10
        btnTambahIzin.Text = "Tambah"
        btnTambahIzin.UseVisualStyleBackColor = True
        ' 
        ' btnKembali
        ' 
        btnKembali.Dock = DockStyle.Fill
        btnKembali.FlatStyle = FlatStyle.System
        btnKembali.Location = New Point(3, 3)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(105, 25)
        btnKembali.TabIndex = 7
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(553, 48)
        Label2.TabIndex = 14
        Label2.Text = "DAFTAR PERIZINAN"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Bottom
        TextBox1.Location = New Point(562, 22)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Cari Perizinan"
        TextBox1.Size = New Size(181, 23)
        TextBox1.TabIndex = 15
        ' 
        ' PerizinanAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "PerizinanAdmin"
        Text = "PerizinanAdmin"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        CType(DGView1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents DGView1 As DataGridView
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnTambahIzin As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents statusCombo As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewButtonColumn11 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewButtonColumn12 As DataGridViewButtonColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
End Class
