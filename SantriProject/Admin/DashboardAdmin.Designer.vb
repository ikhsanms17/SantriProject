<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardAdmin))
        TableLayoutPanel1 = New TableLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        Panel1 = New Panel()
        Panel3 = New Panel()
        TableLayoutPanel3 = New TableLayoutPanel()
        Panel2 = New Panel()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.ColumnCount = 7
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 28F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 28F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 28F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5F))
        TableLayoutPanel1.Controls.Add(Label1, 1, 1)
        TableLayoutPanel1.Controls.Add(Label2, 3, 1)
        TableLayoutPanel1.Controls.Add(Label3, 5, 1)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 75F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(800, 167)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.Location = New Point(43, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(218, 125)
        Label1.TabIndex = 0
        Label1.Text = "80"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.Location = New Point(291, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(218, 125)
        Label2.TabIndex = 1
        Label2.Text = "Rp. 55.000.000"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 36F)
        Label3.Image = CType(resources.GetObject("Label3.Image"), Image)
        Label3.Location = New Point(539, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(218, 125)
        Label3.TabIndex = 2
        Label3.Text = "15"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 85F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5F))
        TableLayoutPanel2.Controls.Add(Panel1, 1, 1)
        TableLayoutPanel2.Controls.Add(Panel3, 1, 2)
        TableLayoutPanel2.Dock = DockStyle.Left
        TableLayoutPanel2.Location = New Point(0, 167)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 4
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 42.5F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 42.5F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.Size = New Size(400, 283)
        TableLayoutPanel2.TabIndex = 6
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.AutoSize = True
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Location = New Point(43, 17)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(334, 114)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.AutoSize = True
        Panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.Location = New Point(43, 137)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(334, 114)
        Panel3.TabIndex = 1
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 85F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel3.Controls.Add(Panel2, 1, 1)
        TableLayoutPanel3.Dock = DockStyle.Right
        TableLayoutPanel3.Location = New Point(400, 167)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 3
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 5F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 85F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel3.Size = New Size(400, 283)
        TableLayoutPanel3.TabIndex = 7
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.AutoSize = True
        Panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.Location = New Point(23, 17)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(334, 234)
        Panel2.TabIndex = 0
        ' 
        ' DashboardAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "DashboardAdmin"
        Text = "DashboardAdmin"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
End Class
