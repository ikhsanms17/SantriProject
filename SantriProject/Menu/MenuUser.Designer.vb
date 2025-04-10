<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUser))
        TableLayoutPanel1 = New TableLayoutPanel()
        BtnDashboard = New PictureBox()
        BtnUser = New PictureBox()
        BtnKelas = New PictureBox()
        BtnHistory = New PictureBox()
        BtnPower = New PictureBox()
        TableLayoutPanel1.SuspendLayout()
        CType(BtnDashboard, ComponentModel.ISupportInitialize).BeginInit()
        CType(BtnUser, ComponentModel.ISupportInitialize).BeginInit()
        CType(BtnKelas, ComponentModel.ISupportInitialize).BeginInit()
        CType(BtnHistory, ComponentModel.ISupportInitialize).BeginInit()
        CType(BtnPower, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 6
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Controls.Add(BtnPower, 5, 3)
        TableLayoutPanel1.Controls.Add(BtnUser, 3, 1)
        TableLayoutPanel1.Controls.Add(BtnDashboard, 2, 1)
        TableLayoutPanel1.Controls.Add(BtnHistory, 3, 2)
        TableLayoutPanel1.Controls.Add(BtnKelas, 2, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 35F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 35F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' BtnDashboard
        ' 
        BtnDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnDashboard.Image = CType(resources.GetObject("BtnDashboard.Image"), Image)
        BtnDashboard.Location = New Point(243, 70)
        BtnDashboard.Name = "BtnDashboard"
        BtnDashboard.Size = New Size(154, 151)
        BtnDashboard.SizeMode = PictureBoxSizeMode.StretchImage
        BtnDashboard.TabIndex = 0
        BtnDashboard.TabStop = False
        ' 
        ' BtnUser
        ' 
        BtnUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnUser.Image = CType(resources.GetObject("BtnUser.Image"), Image)
        BtnUser.Location = New Point(403, 70)
        BtnUser.Name = "BtnUser"
        BtnUser.Size = New Size(154, 151)
        BtnUser.SizeMode = PictureBoxSizeMode.StretchImage
        BtnUser.TabIndex = 1
        BtnUser.TabStop = False
        ' 
        ' BtnKelas
        ' 
        BtnKelas.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnKelas.Image = CType(resources.GetObject("BtnKelas.Image"), Image)
        BtnKelas.Location = New Point(243, 227)
        BtnKelas.Name = "BtnKelas"
        BtnKelas.Size = New Size(154, 151)
        BtnKelas.SizeMode = PictureBoxSizeMode.StretchImage
        BtnKelas.TabIndex = 2
        BtnKelas.TabStop = False
        ' 
        ' BtnHistory
        ' 
        BtnHistory.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnHistory.Image = CType(resources.GetObject("BtnHistory.Image"), Image)
        BtnHistory.Location = New Point(403, 227)
        BtnHistory.Name = "BtnHistory"
        BtnHistory.Size = New Size(154, 151)
        BtnHistory.SizeMode = PictureBoxSizeMode.StretchImage
        BtnHistory.TabIndex = 7
        BtnHistory.TabStop = False
        ' 
        ' BtnPower
        ' 
        BtnPower.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BtnPower.Image = CType(resources.GetObject("BtnPower.Image"), Image)
        BtnPower.Location = New Point(723, 384)
        BtnPower.Name = "BtnPower"
        BtnPower.Size = New Size(74, 63)
        BtnPower.SizeMode = PictureBoxSizeMode.StretchImage
        BtnPower.TabIndex = 8
        BtnPower.TabStop = False
        ' 
        ' MenuUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "MenuUser"
        Text = "MenuUser"
        TableLayoutPanel1.ResumeLayout(False)
        CType(BtnDashboard, ComponentModel.ISupportInitialize).EndInit()
        CType(BtnUser, ComponentModel.ISupportInitialize).EndInit()
        CType(BtnKelas, ComponentModel.ISupportInitialize).EndInit()
        CType(BtnHistory, ComponentModel.ISupportInitialize).EndInit()
        CType(BtnPower, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnDashboard As PictureBox
    Friend WithEvents BtnUser As PictureBox
    Friend WithEvents BtnKelas As PictureBox
    Friend WithEvents BtnHistory As PictureBox
    Friend WithEvents BtnPower As PictureBox
End Class
