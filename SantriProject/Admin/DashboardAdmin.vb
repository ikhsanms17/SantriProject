Imports System.Globalization
Imports LiveChartsCore
Imports LiveChartsCore.SkiaSharpView
Imports LiveChartsCore.SkiaSharpView.Painting
Imports MySql.Data.MySqlClient

Public Class DashboardAdmin

    ' Format currency function (Rp.0, Rp.10 K, Rp.1.5 M)
    Private Function FormatCurrencyDynamic(amount As Decimal) As String
        If amount = 0D Then Return "Rp.0"
        If amount >= 1_000_000 Then
            Return "Rp." & (amount / 1_000_000).ToString("N2") & " M"
        ElseIf amount >= 1_000 Then
            Return "Rp." & (amount / 1_000).ToString("N0") & " K"
        Else
            Return "Rp." & amount.ToString("N0")
        End If
    End Function

    Private Sub DashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Resize, maximize, etc...
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        scaleX = Me.ClientSize.Width / baseWidth
        scaleY = Me.ClientSize.Height / baseHeight
        ResizeControls(Me, scaleX, scaleY)

        ' Set label text
        labelTotalSantri.Text = FormatNumber(Database.GetTotalSantri(), 0)
        labelTotalPetugas.Text = FormatNumber(Database.GetTotalPetugas(), 0)
        labelTotalSaldo.Text = FormatCurrencyDynamic(Database.GetTotalSaldo())


        Dim type_chart_santri_total As Boolean = False
        Dim result As New DataTable()

        ' SQL Query: jumlah user role ID 1 dalam 12 bulan terakhir
        Dim Query = "
    SELECT 
        CAST(YEAR(u.created_at) AS UNSIGNED) AS year,
        CAST(MONTH(u.created_at) AS UNSIGNED) AS month,
        COUNT(*) AS user_count
    FROM users u
    JOIN user_role ru ON u.id = ru.user_id
    JOIN roles r ON ru.role_id = r.id
    WHERE r.id = 1
      AND u.deleted_at IS NULL
      AND ru.deleted_at IS NULL
      AND r.deleted_at IS NULL
      AND u.created_at >= CURDATE() - INTERVAL 12 MONTH
    GROUP BY year, month
    ORDER BY year, month;
    "

        ' Ambil data dari database
        Using conn As MySqlConnection = GetConnection()
            Try
                Dim cmd As New MySqlCommand(Query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(result)
            Catch ex As Exception
                MessageBox.Show("Gagal mengambil data: " & ex.Message)
                Exit Sub
            Finally
                CloseConnection(conn)
            End Try
        End Using

        ' Cek jumlah tahun unik
        Dim distinctYears = result.AsEnumerable().
        Select(Function(r) Convert.ToInt32(r("year"))).
        Distinct().
        OrderBy(Function(y) y).
        ToList()

        If distinctYears.Count > 1 Then
            type_chart_santri_total = True
        End If

        ' Inisialisasi variabel chart
        Dim data_tahun_or_bulan As New List(Of String)()
        Dim value_tahun_or_bulan As New List(Of Double)()

        If type_chart_santri_total Then
            ' Chart Tahunan
            For Each yr In distinctYears
                data_tahun_or_bulan.Add(yr.ToString())
                Dim total = result.AsEnumerable().
                Where(Function(r) Convert.ToInt32(r("year")) = yr).
                Sum(Function(r) Convert.ToInt32(r("user_count")))
                value_tahun_or_bulan.Add(total)
            Next
        Else
            ' Chart Bulanan
            Dim bulanNames = New CultureInfo("id-ID").DateTimeFormat.MonthNames
            Dim tahun = distinctYears.FirstOrDefault()

            For i As Integer = 1 To 12
                data_tahun_or_bulan.Add(bulanNames(i - 1)) ' Nama bulan
                Dim bulanData = result.AsEnumerable().
                FirstOrDefault(Function(r) Convert.ToInt32(r("month")) = i AndAlso Convert.ToInt32(r("year")) = tahun)

                If bulanData IsNot Nothing Then
                    value_tahun_or_bulan.Add(Convert.ToDouble(bulanData("user_count")))
                Else
                    value_tahun_or_bulan.Add(0)
                End If
            Next
        End If

        ' Tampilkan ke chart
        ChartSantri.Series = {
        New ColumnSeries(Of Double) With {
            .Values = value_tahun_or_bulan,
            .Name = "Jumlah User"
        }
    }

        ChartSantri.XAxes = {
        New Axis With {
            .Labels = data_tahun_or_bulan,
            .Name = If(type_chart_santri_total, "Tahun", "Bulan")
        }
    }

        ChartSantri.YAxes = {
        New Axis With {
            .Name = "Jumlah",
            .Labeler = Function(value)
                           If value >= 1_000_000 Then
                               Return (value / 1_000_000).ToString("N0") & " Jt"
                           ElseIf value >= 1_000 Then
                               Return (value / 1_000).ToString("N0") & " Rb"
                           Else
                               Return value.ToString("N0")
                           End If
                       End Function,
            .MinLimit = 0,
            .MaxLimit = If(value_tahun_or_bulan.Count > 0, value_tahun_or_bulan.Max() * 1.2, 100)
        }
    }

        ' Data chart bulat (pie)
        Dim hasil = Database.GetChartSaldoBulat()
        Dim total_saldo As Decimal = hasil.total_saldo
        Dim total_pengeluaran As Decimal = hasil.total_pengeluaran
        Dim total_pemasukan As Decimal = hasil.total_pemasukan

        Dim pieSeries As New List(Of PieSeries(Of Double))

        ' Pie Chart - tetap muncul meski semua data 0
        pieSeries.Add(New PieSeries(Of Double) With {
            .Values = New List(Of Double) From {If(total_saldo = 0, 1, Convert.ToDouble(total_saldo))},
            .Name = "Total Saldo (" & FormatCurrencyDynamic(total_saldo) & ")"
        })

        pieSeries.Add(New PieSeries(Of Double) With {
            .Values = New List(Of Double) From {If(total_pengeluaran = 0, 1, Convert.ToDouble(total_pengeluaran))},
            .Name = "Pengeluaran (" & FormatCurrencyDynamic(total_pengeluaran) & ")"
        })

        pieSeries.Add(New PieSeries(Of Double) With {
            .Values = New List(Of Double) From {If(total_pemasukan = 0, 1, Convert.ToDouble(total_pemasukan))},
            .Name = "Pemasukan (" & FormatCurrencyDynamic(total_pemasukan) & ")"
        })

        ' Tampilkan pie chart
        PieChartSaldo.Series = pieSeries
        PieChartSaldo.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right
        PieChartSaldo.Visible = True
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim parentForm = CType(MdiParent, Form1)
        parentForm.OpenChildForm(New MenuAdmin)
    End Sub
End Class