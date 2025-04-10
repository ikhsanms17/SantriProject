Imports Mysqlx.Datatypes

Public Class Login
    Dim baseWidth As Integer = 800 ' Resolusi desain awal
    Dim baseHeight As Integer = 450
    Dim scaleX As Double
    Dim scaleY As Double

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized ' Fullscreen

        ' Hitung faktor skala berdasarkan resolusi layar
        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight

        ResizeControls(Me)
    End Sub

    Private Sub ResizeControls(ByVal container As Control)
        ' Iterasi semua kontrol dalam form
        For Each ctrl As Control In container.Controls
            ctrl.Left = CInt(ctrl.Left * scaleX)
            ctrl.Top = CInt(ctrl.Top * scaleY)
            ctrl.Width = CInt(ctrl.Width * scaleX)
            ctrl.Height = CInt(ctrl.Height * scaleY)

            ' Sesuaikan ukuran font jika ada teks
            If TypeOf ctrl Is Label Or TypeOf ctrl Is Button Or TypeOf ctrl Is TextBox Then
                Dim ctrlFont As Font = ctrl.Font
                Dim newSize As Single = ctrlFont.Size * CSng(Math.Min(scaleX, scaleY))
                ctrl.Font = New Font(ctrlFont.FontFamily, newSize, ctrlFont.Style)
            End If

            ' Jika ada kontrol dalam Panel atau GroupBox, rekursif
            If ctrl.HasChildren Then
                ResizeControls(ctrl)
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TxtUsername.Text = "admin" And TxtPassword.Text = "1234" Then
            MessageBox.Show("Login Berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Ganti ke Form Menu Admin
            Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
            parentForm.OpenChildForm(New MenuAdmin)

        ElseIf TxtUsername.Text = "user" And TxtPassword.Text = "user123" Then
            MessageBox.Show("Login Berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Ganti ke Form Menu User
            Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
            parentForm.OpenChildForm(New MenuUser)

        Else
            MessageBox.Show("Login Gagal!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class