Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        OpenChildForm(New Login)

    End Sub

    'Private Sub OpenChildForm()
    '    Dim child As New Login
    '    child.MdiParent = Me ' Set Parent Form
    '    child.WindowState = FormWindowState.Maximized ' Child mengikuti Parent

    '    child.Show()
    'End Sub

    'Private Sub FormParent_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    '    OpenChildForm() ' Otomatis membuka Child saat Parent terbuka
    'End Sub

    Public Sub OpenChildForm(childForm As Form)
        ' Tutup child form yang sedang aktif
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next

        ' Set form baru sebagai child
        childForm.MdiParent = Me
        childForm.Dock = DockStyle.Fill ' Agar mengikuti ukuran Parent
        childForm.Show()
    End Sub

End Class
