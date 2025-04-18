Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Login
    'Private Const baseWidth As Integer = 800
    'Private Const baseHeight As Integer = 450
    'Private scaleX As Double
    'Private scaleY As Double

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form agar bisa di-resize
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight

        ResizeControls(Me, scaleX, scaleY)
    End Sub

    'Private Sub ResizeControls(ByVal container As Control)
    '    For Each ctrl As Control In container.Controls
    '        ' Resize posisi dan ukuran kontrol berdasarkan scale
    '        ctrl.Left = CInt(ctrl.Left * scaleX)
    '        ctrl.Top = CInt(ctrl.Top * scaleY)
    '        ctrl.Width = CInt(ctrl.Width * scaleX)
    '        ctrl.Height = CInt(ctrl.Height * scaleY)

    '        ' Menyesuaikan ukuran font kontrol tertentu
    '        If TypeOf ctrl Is Label Or TypeOf ctrl Is Button Or TypeOf ctrl Is TextBox Then
    '            Dim ctrlFont As Font = ctrl.Font
    '            Dim newSize As Single = ctrlFont.Size * CSng(Math.Min(scaleX, scaleY))
    '            ctrl.Font = New Font(ctrlFont.FontFamily, newSize, ctrlFont.Style)
    '        End If

    '        ' Periksa jika kontrol memiliki children dan lakukan resize rekursif
    '        If ctrl.HasChildren Then
    '            ResizeControls(ctrl)
    '        End If
    '    Next
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Ambil input dari pengguna
        Dim userInput As String = TxtUsername.Text.Trim()
        Dim password As String = TxtPassword.Text.Trim()
        Dim userRole As String = ""
        Dim displayName As String = ""

        ' Autentikasi pengguna
        If AuthenticateUser(userInput, password, userRole, displayName) Then
            MessageBox.Show("Login Berhasil!" & vbCrLf & "User: " & displayName & vbCrLf & "Role: " & userRole,
                            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Dapatkan Form1 sebagai MdiParent dan buka child form sesuai role
            Dim parentForm As Form1 = CType(Me.MdiParent, Form1)

            ' Pastikan parentForm tidak null sebelum digunakan
            If parentForm Is Nothing Then
                ' Jika parentForm null, inisialisasi ulang Form1
                parentForm = New Form1()
                parentForm.MdiParent = Me.MdiParent
            End If

            ' Buka child form sesuai role pengguna
            Select Case userRole.ToLower()
                Case "admin"
                    parentForm.OpenChildForm(New MenuAdmin)
                Case "user"
                    parentForm.OpenChildForm(New MenuUser)
                Case Else
                    MessageBox.Show("Role tidak dikenal: " & userRole, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select
        Else
            MessageBox.Show("Login Gagal!" & vbCrLf & "Periksa kembali email/nama pengguna dan kata sandi.",
                            "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function AuthenticateUser(ByVal input As String, ByVal password As String, ByRef userRole As String, ByRef displayName As String) As Boolean
        ' Membuat koneksi ke database
        Dim conn As MySqlConnection = Database.GetConnection()
        Dim hashedPassword As String = HashPassword(password)

        ' Query untuk autentikasi pengguna
        Dim query As String = "
        SELECT users.nama_pengguna, roles.nama AS role_name 
        FROM users 
        JOIN user_role ON users.id = user_role.user_id 
        JOIN roles ON user_role.role_id = roles.id 
        WHERE (users.email = @input OR users.nama_pengguna = @input) 
        AND users.kata_sandi = @password"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@input", input)
        cmd.Parameters.AddWithValue("@password", hashedPassword)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                ' Menyimpan data pengguna ke session
                displayName = reader.GetString("nama_pengguna")
                userRole = reader.GetString("role_name")

                ' Menyimpan informasi session
                Auth.IsLoggedIn = True
                Auth.Username = input ' Bisa menggunakan email/nama pengguna
                Auth.UserRole = userRole
                Auth.DisplayName = displayName

                Return True
            End If
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        Finally
            Database.CloseConnection(conn)
        End Try

        Return False
    End Function

    ' Hash password menggunakan SHA256 agar cocok dengan SHA2 MySQL
    Private Function HashPassword(ByVal password As String) As String
        ' Menggunakan SHA256.HashData yang lebih efisien
        Dim hash As Byte() = SHA256.HashData(Encoding.UTF8.GetBytes(password))
        Return BitConverter.ToString(hash).Replace("-", "").ToLower()
    End Function
End Class
