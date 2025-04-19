<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Label1 = New Label()
        TxtUsername = New TextBox()
        TxtPassword = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AccessibleRole = AccessibleRole.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(188, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(424, 65)
        Label1.TabIndex = 0
        Label1.Text = "APLIKASI SANTRI"
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtUsername.Location = New Point(279, 165)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(243, 29)
        TxtUsername.TabIndex = 1
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtPassword.Location = New Point(279, 231)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"c
        TxtPassword.Size = New Size(243, 29)
        TxtPassword.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(357, 319)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 35)
        Button1.TabIndex = 3
        Button1.Text = "Masuk"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.PapayaWhip
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(TxtPassword)
        Controls.Add(TxtUsername)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Button1 As Button
End Class
