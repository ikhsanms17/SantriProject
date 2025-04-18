Module reponsive
    Public Const baseWidth As Integer = 800
    Public Const baseHeight As Integer = 450
    Public scaleX As Double
    Public scaleY As Double

    Public Sub ResizeControls(ByVal container As Control, ByVal scaleX As Double, ByVal scaleY As Double)
        For Each ctrl As Control In container.Controls
            ' Resize posisi dan ukuran kontrol
            ctrl.Left = CInt(ctrl.Left * scaleX)
            ctrl.Top = CInt(ctrl.Top * scaleY)
            ctrl.Width = CInt(ctrl.Width * scaleX)
            ctrl.Height = CInt(ctrl.Height * scaleY)

            ' Penyesuaian font untuk kontrol tertentu
            If TypeOf ctrl Is Label OrElse
               TypeOf ctrl Is Button OrElse
               TypeOf ctrl Is TextBox OrElse
               TypeOf ctrl Is ComboBox OrElse
               TypeOf ctrl Is DateTimePicker OrElse
               TypeOf ctrl Is DataGridView Then
                'TypeOf ctrl Is DataVisualization.Charting.Chart Then

                Dim ctrlFont As Font = ctrl.Font
                Dim newSize As Single = ctrlFont.Size * CSng(Math.Min(scaleX, scaleY))
                ctrl.Font = New Font(ctrlFont.FontFamily, newSize, ctrlFont.Style)
            End If

            ' Resize kolom DataGridView
            If TypeOf ctrl Is DataGridView Then
                Dim dgv As DataGridView = CType(ctrl, DataGridView)
                For Each column As DataGridViewColumn In dgv.Columns
                    column.Width = CInt(column.Width * scaleX)

                    ' Cek apakah Font-nya Nothing
                    If column.DefaultCellStyle.Font IsNot Nothing Then
                        column.DefaultCellStyle.Font = New Font(
                column.DefaultCellStyle.Font.FontFamily,
                column.DefaultCellStyle.Font.Size * CSng(Math.Min(scaleX, scaleY))
            )
                    Else
                        ' Jika font belum diatur, beri font default
                        column.DefaultCellStyle.Font = New Font("Segoe UI", 9 * CSng(Math.Min(scaleX, scaleY)))
                    End If
                Next
            End If

            ' Resize Chart jika diperlukan
            'If TypeOf ctrl Is DataVisualization.Charting.Chart Then
            '    Dim chartCtrl As DataVisualization.Charting.Chart = CType(ctrl, DataVisualization.Charting.Chart)
            '    chartCtrl.ChartAreas(0).AxisX.LabelStyle.Font = New Font(chartCtrl.ChartAreas(0).AxisX.LabelStyle.Font.FontFamily, chartCtrl.ChartAreas(0).AxisX.LabelStyle.Font.Size * CSng(Math.Min(scaleX, scaleY)))
            '    chartCtrl.ChartAreas(0).AxisY.LabelStyle.Font = New Font(chartCtrl.ChartAreas(0).AxisY.LabelStyle.Font.FontFamily, chartCtrl.ChartAreas(0).AxisY.LabelStyle.Font.Size * CSng(Math.Min(scaleX, scaleY)))
            'End If

            ' Rekursif ke children
            If ctrl.HasChildren Then
                ResizeControls(ctrl, scaleX, scaleY)
            End If
        Next
    End Sub

End Module
