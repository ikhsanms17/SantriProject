Imports SantriProject.Auth.Auth
Public Class MenuAdmin
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(New DashboardAdmin)
    End Sub

    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click
        Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(New UserManagementAdmin)
    End Sub

    Private Sub BtnKelas_Click(sender As Object, e As EventArgs) Handles BtnKelas.Click
        Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(New KelasAdmin)
    End Sub

    Private Sub BtnPetugas_Click(sender As Object, e As EventArgs) Handles BtnPetugas.Click
        Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(New Petugas)
    End Sub

    Private Sub BtnTransaksi_Click(sender As Object, e As EventArgs) Handles BtnTransaksi.Click
        Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(New TransaksiAdmin)
    End Sub

    Private Sub BtnLaporan_Click(sender As Object, e As EventArgs) Handles BtnLaporan.Click
        Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(New LaporanAdmin)
    End Sub

    Private Sub BtnPerizinan_Click(sender As Object, e As EventArgs) Handles BtnPerizinan.Click
        Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(New PerizinanAdmin)
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        Dim parentForm As Form1 = CType(Me.MdiParent, Form1)
        parentForm.OpenChildForm(New HistoryAdmin)
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnPower.Click
        ' Clear session data
        Auth.IsLoggedIn = False
        Auth.Username = ""
        Auth.UserRole = ""
        Auth.DisplayName = ""

        ' Hide the main form and show the login form again
        Me.Hide()

        Dim loginForm As New Login()
        loginForm.Show()

        ' Optionally, you can also clear any existing MdiParent if necessary
        loginForm.MdiParent = Nothing
    End Sub

End Class