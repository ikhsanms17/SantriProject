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
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        ChartKeuangan = New LiveChartsCore.SkiaSharpView.WinForms.CartesianChart()
        PieChartSaldo = New LiveChartsCore.SkiaSharpView.WinForms.PieChart()
        Label1 = New Label()
        BtnKembali = New Button()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
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
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 2F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 96F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 2F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 1)
        TableLayoutPanel2.Controls.Add(Label1, 0, 0)
        TableLayoutPanel2.Controls.Add(BtnKembali, 0, 2)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(27, 12)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 60F))
        TableLayoutPanel2.Size = New Size(746, 426)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(ChartKeuangan, 0, 0)
        TableLayoutPanel3.Controls.Add(PieChartSaldo, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 45)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(740, 121)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' ChartKeuangan
        ' 
        ChartKeuangan.Dock = DockStyle.Fill
        ChartKeuangan.Location = New Point(3, 3)
        ChartKeuangan.Name = "ChartKeuangan"
        ChartKeuangan.Size = New Size(364, 95)
        ChartKeuangan.TabIndex = 0
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
        PieChartSaldo.Size = New Size(364, 95)
        PieChartSaldo.TabIndex = 1
        PieChartSaldo.Total = Nothing
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(740, 42)
        Label1.TabIndex = 1
        Label1.Text = "DASHBOARD ADMIN"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnKembali
        ' 
        BtnKembali.Location = New Point(3, 172)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(75, 23)
        BtnKembali.TabIndex = 2
        BtnKembali.Text = "Kembali"
        BtnKembali.UseVisualStyleBackColor = True
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
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents ChartKeuangan As LiveChartsCore.SkiaSharpView.WinForms.CartesianChart
    Friend WithEvents PieChartSaldo As LiveChartsCore.SkiaSharpView.WinForms.PieChart
    Friend WithEvents BtnKembali As Button
End Class
