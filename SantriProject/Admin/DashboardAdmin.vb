Imports LiveChartsCore
Imports LiveChartsCore.SkiaSharpView
Imports LiveChartsCore.SkiaSharpView.WinForms
Imports LiveChartsCore.SkiaSharpView.Painting
Imports SkiaSharp

Public Class DashboardAdmin
    Private Sub DashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Data keuangan tahunan
        Dim tahunList As String() = {"2020", "2021", "2022", "2023", "2024", "2025"}
        Dim nilaiKeuangan As Double() = {200, 250, 300, 275, 320, 400}

        ' Konfigurasi Chart Kolom Keuangan
        ChartKeuangan.Series = New ISeries() {
            New ColumnSeries(Of Double) With {
                .Values = nilaiKeuangan.ToList(),
                .Name = "Keuangan"
            }
        }

        ChartKeuangan.XAxes = New Axis() {
            New Axis With {
                .Labels = tahunList.ToList(),
                .Name = "Tahun"
            }
        }

        ChartKeuangan.YAxes = New Axis() {
            New Axis With {
                .Name = "Jumlah (juta)",
                .Labeler = Function(value) value.ToString("N0") & " jt"
            }
        }

        ' Konfigurasi PieChart Saldo
        Dim pieSeries As New List(Of PieSeries(Of Double)) From {
            New PieSeries(Of Double) With {
                .Values = New List(Of Double) From {500},
                .Name = "Total Saldo",
                .Pushout = 5
            },
            New PieSeries(Of Double) With {
                .Values = New List(Of Double) From {150},
                .Name = "Pengeluaran"
            },
            New PieSeries(Of Double) With {
                .Values = New List(Of Double) From {350},
                .Name = "Pemasukan"
            }
        }

        PieChartSaldo.Series = pieSeries
        PieChartSaldo.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right
    End Sub
End Class
