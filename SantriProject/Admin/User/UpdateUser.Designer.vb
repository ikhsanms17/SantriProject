<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateUser
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox12 = New TextBox()
        TextBox13 = New TextBox()
        BtnSimpan = New Button()
        BtnKembali = New Button()
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
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(TextBox1, 0, 0)
        TableLayoutPanel2.Controls.Add(TextBox2, 1, 0)
        TableLayoutPanel2.Controls.Add(TextBox3, 0, 2)
        TableLayoutPanel2.Controls.Add(TextBox4, 1, 2)
        TableLayoutPanel2.Controls.Add(TextBox5, 0, 4)
        TableLayoutPanel2.Controls.Add(TextBox6, 1, 4)
        TableLayoutPanel2.Controls.Add(TextBox7, 0, 6)
        TableLayoutPanel2.Controls.Add(TextBox8, 0, 8)
        TableLayoutPanel2.Controls.Add(TextBox9, 0, 10)
        TableLayoutPanel2.Controls.Add(TextBox12, 1, 6)
        TableLayoutPanel2.Controls.Add(TextBox13, 1, 8)
        TableLayoutPanel2.Controls.Add(BtnSimpan, 1, 11)
        TableLayoutPanel2.Controls.Add(BtnKembali, 0, 11)
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
        ' TextBox1
        ' 
        TextBox1.Location = New Point(3, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Nama Lengkap"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(376, 3)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Username"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(3, 65)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Email"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(376, 65)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Password"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(3, 127)
        TextBox5.Name = "TextBox5"
        TextBox5.PlaceholderText = "NIS"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 4
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(376, 127)
        TextBox6.Name = "TextBox6"
        TextBox6.PlaceholderText = "Kelas"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 5
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(3, 189)
        TextBox7.Name = "TextBox7"
        TextBox7.PlaceholderText = "Jenis Kelamin"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 6
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(3, 251)
        TextBox8.Name = "TextBox8"
        TextBox8.PlaceholderText = "Ayah"
        TextBox8.Size = New Size(100, 23)
        TextBox8.TabIndex = 7
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(3, 313)
        TextBox9.Name = "TextBox9"
        TextBox9.PlaceholderText = "Alamat"
        TextBox9.Size = New Size(100, 23)
        TextBox9.TabIndex = 8
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(376, 189)
        TextBox12.Name = "TextBox12"
        TextBox12.PlaceholderText = "Tanggal Lahir"
        TextBox12.Size = New Size(100, 23)
        TextBox12.TabIndex = 11
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(376, 251)
        TextBox13.Name = "TextBox13"
        TextBox13.PlaceholderText = "Ibu"
        TextBox13.Size = New Size(100, 23)
        TextBox13.TabIndex = 12
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
        ' UpdateUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "UpdateUser"
        Text = "UpdateUser"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnKembali As Button
End Class
