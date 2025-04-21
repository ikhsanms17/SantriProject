<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardAdmin
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
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        TableLayoutPanel7 = New TableLayoutPanel()
        btnKembali = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        PieChartSaldo = New LiveChartsCore.SkiaSharpView.WinForms.PieChart()
        ChartKeuangan = New LiveChartsCore.SkiaSharpView.WinForms.CartesianChart()
        TableLayoutPanel6 = New TableLayoutPanel()
        Label3 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        labelTotalSantri = New Label()
        labelTotalSaldo = New Label()
        labelTotalPetugas = New Label()
        Label1 = New Label()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Location = New Point(0, 0)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.Size = New Size(200, 100)
        TableLayoutPanel4.TabIndex = 0
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.Location = New Point(0, 0)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.Size = New Size(200, 100)
        TableLayoutPanel5.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 94F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 1, 2)
        TableLayoutPanel1.Controls.Add(Label1, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 3F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 82F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 3F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(TableLayoutPanel7, 0, 2)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel2, 0, 1)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel6, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(27, 70)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 3
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 60F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel3.Size = New Size(746, 363)
        TableLayoutPanel3.TabIndex = 10
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 3
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.9189186F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70.9459457F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15F))
        TableLayoutPanel7.Controls.Add(btnKembali, 0, 0)
        TableLayoutPanel7.Dock = DockStyle.Fill
        TableLayoutPanel7.Location = New Point(3, 328)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 1
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel7.Size = New Size(740, 32)
        TableLayoutPanel7.TabIndex = 14
        ' 
        ' btnKembali
        ' 
        btnKembali.Dock = DockStyle.Fill
        btnKembali.FlatStyle = FlatStyle.System
        btnKembali.Location = New Point(3, 3)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(97, 26)
        btnKembali.TabIndex = 7
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackgroundImageLayout = ImageLayout.Zoom
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(PieChartSaldo, 1, 0)
        TableLayoutPanel2.Controls.Add(ChartKeuangan, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 111)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(740, 211)
        TableLayoutPanel2.TabIndex = 15
        ' 
        ' PieChartSaldo
        ' 
        PieChartSaldo.Dock = DockStyle.Fill
        PieChartSaldo.InitialRotation = 0R
        PieChartSaldo.IsClockwise = True
        PieChartSaldo.Location = New Point(373, 3)
        PieChartSaldo.MaxAngle = 360R
        PieChartSaldo.MaxValue = Nothing
        PieChartSaldo.MinValue = 0R
        PieChartSaldo.Name = "PieChartSaldo"
        PieChartSaldo.Size = New Size(364, 205)
        PieChartSaldo.TabIndex = 0
        PieChartSaldo.Total = Nothing
        ' 
        ' ChartKeuangan
        ' 
        ChartKeuangan.Dock = DockStyle.Fill
        ChartKeuangan.Location = New Point(3, 3)
        ChartKeuangan.Name = "ChartKeuangan"
        ChartKeuangan.Size = New Size(364, 205)
        ChartKeuangan.TabIndex = 1
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 7
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 2.777901F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 29.6294651F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 2.77790117F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 29.6294651F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 2.77790117F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 29.6294651F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 2.77790117F))
        TableLayoutPanel6.Controls.Add(Label3, 1, 0)
        TableLayoutPanel6.Controls.Add(Label7, 5, 0)
        TableLayoutPanel6.Controls.Add(Label5, 3, 0)
        TableLayoutPanel6.Controls.Add(labelTotalSantri, 1, 1)
        TableLayoutPanel6.Controls.Add(labelTotalSaldo, 3, 1)
        TableLayoutPanel6.Controls.Add(labelTotalPetugas, 5, 1)
        TableLayoutPanel6.Dock = DockStyle.Fill
        TableLayoutPanel6.Location = New Point(3, 3)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 3
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 17F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 3F))
        TableLayoutPanel6.Size = New Size(740, 102)
        TableLayoutPanel6.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(23, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 15)
        Label3.TabIndex = 22
        Label3.Text = "TOTAL SANTRI"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(501, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 15)
        Label7.TabIndex = 21
        Label7.Text = "TOTAL PETUGAS"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(262, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 15)
        Label5.TabIndex = 17
        Label5.Text = "TOTAL SALDO"
        ' 
        ' labelTotalSantri
        ' 
        labelTotalSantri.AutoSize = True
        labelTotalSantri.BackColor = Color.FloralWhite
        labelTotalSantri.Dock = DockStyle.Fill
        labelTotalSantri.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        labelTotalSantri.Location = New Point(23, 17)
        labelTotalSantri.Name = "labelTotalSantri"
        labelTotalSantri.Size = New Size(213, 81)
        labelTotalSantri.TabIndex = 23
        labelTotalSantri.Text = "TEST"
        labelTotalSantri.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' labelTotalSaldo
        ' 
        labelTotalSaldo.AutoSize = True
        labelTotalSaldo.BackColor = Color.FloralWhite
        labelTotalSaldo.Dock = DockStyle.Fill
        labelTotalSaldo.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        labelTotalSaldo.Location = New Point(262, 17)
        labelTotalSaldo.Name = "labelTotalSaldo"
        labelTotalSaldo.Size = New Size(213, 81)
        labelTotalSaldo.TabIndex = 24
        labelTotalSaldo.Text = "TEST"
        labelTotalSaldo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' labelTotalPetugas
        ' 
        labelTotalPetugas.AutoSize = True
        labelTotalPetugas.BackColor = Color.FloralWhite
        labelTotalPetugas.Dock = DockStyle.Fill
        labelTotalPetugas.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        labelTotalPetugas.Location = New Point(501, 17)
        labelTotalPetugas.Name = "labelTotalPetugas"
        labelTotalPetugas.Size = New Size(213, 81)
        labelTotalPetugas.TabIndex = 25
        labelTotalPetugas.Text = "TEST"
        labelTotalPetugas.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(27, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(746, 54)
        Label1.TabIndex = 12
        Label1.Text = "DASHBOARD ADMIN"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' DashboardAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "DashboardAdmin"
        Text = "DashboardAdmin"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents btnKembali As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PieChartSaldo As LiveChartsCore.SkiaSharpView.WinForms.PieChart
    Friend WithEvents ChartKeuangan As LiveChartsCore.SkiaSharpView.WinForms.CartesianChart
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents labelTotalSantri As Label
    Friend WithEvents labelTotalSaldo As Label
    Friend WithEvents labelTotalPetugas As Label
End Class
