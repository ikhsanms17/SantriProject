<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LaporanAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        txtSearch = New TextBox()
        Label2 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        DGView1 = New DataGridView()
        TableLayoutPanel4 = New TableLayoutPanel()
        btnKembali = New Button()
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
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 94.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.0F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 1, 1)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 1, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 3.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 82.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 3.0F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 75.0F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel2.Controls.Add(txtSearch, 1, 0)
        TableLayoutPanel2.Controls.Add(Label2, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(27, 16)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel2.Size = New Size(746, 48)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' txtSearch
        ' 
        txtSearch.Dock = DockStyle.Bottom
        txtSearch.Location = New Point(562, 22)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari Perizinan"
        txtSearch.Size = New Size(181, 23)
        txtSearch.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(553, 48)
        Label2.TabIndex = 0
        Label2.Text = "CETAK SURAT LAPORAN"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel3.Controls.Add(DGView1, 0, 0)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel4, 0, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(27, 70)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 90.0F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel3.Size = New Size(746, 363)
        TableLayoutPanel3.TabIndex = 2
        ' 
        ' DGView1
        ' 
        DGView1.AllowUserToAddRows = False
        DGView1.AllowUserToDeleteRows = False
        DGView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGView1.Dock = DockStyle.Fill
        DGView1.Location = New Point(3, 3)
        DGView1.Name = "DGView1"
        DGView1.ReadOnly = True
        DGView1.RowHeadersVisible = False
        DGView1.Size = New Size(740, 320)
        DGView1.TabIndex = 0
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 3
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.0F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70.0F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.0F))
        TableLayoutPanel4.Controls.Add(btnKembali, 0, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 329)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel4.Size = New Size(740, 31)
        TableLayoutPanel4.TabIndex = 1
        ' 
        ' btnKembali
        ' 
        btnKembali.Dock = DockStyle.Fill
        btnKembali.FlatStyle = FlatStyle.System
        btnKembali.Location = New Point(3, 3)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(105, 25)
        btnKembali.TabIndex = 0
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' LaporanAdmin
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "LaporanAdmin"
        Text = "LaporanAdmin"
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
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DGView1 As DataGridView
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnKembali As Button
End Class
