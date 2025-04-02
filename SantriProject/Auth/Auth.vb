Namespace Auth
    Public Module Auth
        Public Sub Login()

        End Sub

        Public Sub Logout()
            Dim confirmLogout As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmLogout = DialogResult.Yes Then
                Application.Exit()
            End If
        End Sub
    End Module
End Namespace
