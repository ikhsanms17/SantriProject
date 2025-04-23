Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Diagnostics

Module CetakSurat
    Public Sub CetakSuratIzinPDF(noIzin As String)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "
            SELECT 
                p.nama_penjemput,
                p.tanggal_izin,
                p.tanggal_batas_izin,
                p.status,
                dp.hubungan,
                dp.keperluan,
                dp.alamat_tujuan,
                u.nama AS nama_pengguna
            FROM perizinan p
            LEFT JOIN users u ON u.id = p.pengguna_id
            LEFT JOIN detail_perizinan dp ON dp.no_izin = p.no_izin
            WHERE p.no_izin = @noIzin AND p.status = 'Diizinkan'
            "

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@noIzin", noIzin)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                ' Ambil data dari database
                Dim penjemput = dr("nama_penjemput").ToString()
                Dim tanggalIzin = Convert.ToDateTime(dr("tanggal_izin")).ToString("dd MMMM yyyy")
                Dim tanggalBatas = Convert.ToDateTime(dr("tanggal_batas_izin")).ToString("dd MMMM yyyy")
                Dim hubungan = dr("hubungan").ToString()
                Dim keperluan = dr("keperluan").ToString()
                Dim alamat = dr("alamat_tujuan").ToString()
                Dim namaPengguna = dr("nama_pengguna").ToString()
                Dim tanggalSurat = DateTime.Now.ToString("dd MMMM yyyy")

                ' Dialog simpan file
                Dim saveDialog As New SaveFileDialog()
                saveDialog.Filter = "PDF files (*.pdf)|*.pdf"

                ' Ganti karakter '/' agar aman untuk nama file
                Dim safeNoIzin = noIzin.Replace("/", "_")
                saveDialog.FileName = "Surat_Izin_" & safeNoIzin & ".pdf"

                If saveDialog.ShowDialog() = DialogResult.OK Then
                    Dim filePath As String = saveDialog.FileName

                    ' Buat PDF
                    'Using stream As New FileStream(filePath, FileMode.Create)
                    '    Dim doc As New Document(PageSize.A4, 50, 50, 50, 50)
                    '    PdfWriter.GetInstance(doc, stream)
                    '    doc.Open()

                    '    ' Header surat
                    '    doc.Add(New Paragraph("Bandung, " & tanggalSurat, FontFactory.GetFont("Arial", 12)))
                    '    doc.Add(Chunk.NEWLINE)
                    '    doc.Add(New Paragraph("Kepada Yth." & vbCrLf & "Bapak/Ibu Orangtua/Wali" & vbCrLf & "Di Tempat", FontFactory.GetFont("Arial", 12)))
                    '    doc.Add(Chunk.NEWLINE)

                    '    ' Isi surat
                    '    Dim body As String =
                    '    "Dengan hormat," & vbCrLf & vbCrLf &
                    '    "Kami informasikan bahwa siswa yang dijemput:" & vbCrLf & vbCrLf &
                    '    $"Nama Penjemput  : {penjemput}" & vbCrLf &
                    '    $"Hubungan        : {hubungan}" & vbCrLf &
                    '    $"Keperluan       : {keperluan}" & vbCrLf &
                    '    $"Alamat Tujuan   : {alamat}" & vbCrLf & vbCrLf &
                    '    $"Telah diberikan izin pada tanggal: {tanggalIzin}" & vbCrLf &
                    '    $"Dengan batas waktu sampai: {tanggalBatas}" & vbCrLf & vbCrLf &
                    '    "Hormat kami," & vbCrLf & vbCrLf &
                    '    "Petugas Piket"

                    '    doc.Add(New Paragraph(body, FontFactory.GetFont("Arial", 12)))

                    '    doc.Close()
                    '    stream.Close()
                    'End Using

                    Using stream As New FileStream(filePath, FileMode.Create)
                        Dim doc As New Document(PageSize.A4, 50, 50, 60, 50)
                        PdfWriter.GetInstance(doc, stream)
                        doc.Open()

                        Dim fontJudul As Font = FontFactory.GetFont("Times-Bold", 14)
                        Dim fontNormal As Font = FontFactory.GetFont("Times-Roman", 12)
                        Dim fontBold As Font = FontFactory.GetFont("Times-Bold", 12)
                        Dim fontSmall As Font = FontFactory.GetFont("Times-Roman", 10)

                        ' Header logo + nama pesantren
                        Dim headerTable As New PdfPTable(2)
                        headerTable.WidthPercentage = 100
                        headerTable.SetWidths(New Single() {1.5F, 5.5F})

                        Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Assets", "santri.png"))
                        logo.ScaleToFit(60.0F, 60.0F)
                        logo.Alignment = Element.ALIGN_LEFT
                        Dim logoCell As New PdfPCell(logo)
                        logoCell.Border = Rectangle.NO_BORDER

                        Dim headerText As New Paragraph()
                        headerText.Add(New Phrase("PONDOK PESANTREN SALAFY" & vbCrLf, fontBold))
                        headerText.Add(New Phrase("MABDAUL HIDAYAH" & vbCrLf, fontBold))
                        headerText.Add(New Phrase("Jl. Salwagi Podjodjokan 1 Pasir Ono Rt. 01/01" & vbCrLf, fontSmall))
                        headerText.Add(New Phrase("Desa Rangkasbitung Timur, Kec. Rangkasbitung, Lebak - Banten 42313", fontSmall))

                        Dim textCell As New PdfPCell(headerText)
                        textCell.Border = Rectangle.NO_BORDER
                        textCell.HorizontalAlignment = Element.ALIGN_CENTER

                        headerTable.AddCell(logoCell)
                        headerTable.AddCell(textCell)
                        doc.Add(headerTable)

                        ' Garis pemisah
                        doc.Add(New Paragraph(New Chunk(New iTextSharp.text.pdf.draw.LineSeparator(1.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, -1))))
                        doc.Add(Chunk.NEWLINE)

                        ' Judul surat
                        Dim judul As New Paragraph("SURAT PERIZINAN PULANG SANTRI", fontBold)
                        judul.Alignment = Element.ALIGN_CENTER
                        doc.Add(judul)
                        doc.Add(Chunk.NEWLINE)

                        ' Tanggal dan pengantar
                        doc.Add(New Paragraph("Bandung, " & tanggalSurat, fontNormal))
                        doc.Add(Chunk.NEWLINE)
                        doc.Add(New Paragraph("No Surat " & noIzin))
                        doc.Add(Chunk.NEWLINE)
                        doc.Add(New Paragraph("Yang bertanda tangan di bawah ini, kami pengurus pondok pesantren salafy mabdaul hidayah menerangkan bahwa santri:", fontNormal))
                        doc.Add(Chunk.NEWLINE)

                        ' Tabel isi informasi
                        Dim isiTable As New PdfPTable(2)
                        isiTable.WidthPercentage = 100
                        isiTable.SetWidths(New Single() {3.0F, 6.0F})

                        isiTable.AddCell(New PdfPCell(New Phrase("Nama Penjemput", fontNormal)) With {.Border = Rectangle.NO_BORDER})
                        isiTable.AddCell(New PdfPCell(New Phrase(": " & penjemput, fontNormal)) With {.Border = Rectangle.NO_BORDER})

                        isiTable.AddCell(New PdfPCell(New Phrase("Hubungan", fontNormal)) With {.Border = Rectangle.NO_BORDER})
                        isiTable.AddCell(New PdfPCell(New Phrase(": " & hubungan, fontNormal)) With {.Border = Rectangle.NO_BORDER})

                        isiTable.AddCell(New PdfPCell(New Phrase("Keperluan", fontNormal)) With {.Border = Rectangle.NO_BORDER})
                        isiTable.AddCell(New PdfPCell(New Phrase(": " & keperluan, fontNormal)) With {.Border = Rectangle.NO_BORDER})

                        isiTable.AddCell(New PdfPCell(New Phrase("Alamat Tujuan", fontNormal)) With {.Border = Rectangle.NO_BORDER})
                        isiTable.AddCell(New PdfPCell(New Phrase(": " & alamat, fontNormal)) With {.Border = Rectangle.NO_BORDER})

                        isiTable.AddCell(New PdfPCell(New Phrase("Tanggal Izin", fontNormal)) With {.Border = Rectangle.NO_BORDER})
                        isiTable.AddCell(New PdfPCell(New Phrase(": " & tanggalIzin, fontNormal)) With {.Border = Rectangle.NO_BORDER})

                        isiTable.AddCell(New PdfPCell(New Phrase("Batas Waktu", fontNormal)) With {.Border = Rectangle.NO_BORDER})
                        isiTable.AddCell(New PdfPCell(New Phrase(": " & tanggalBatas, fontNormal)) With {.Border = Rectangle.NO_BORDER})

                        doc.Add(isiTable)
                        doc.Add(Chunk.NEWLINE)

                        ' Catatan
                        doc.Add(New Paragraph("Demikian surat ini kami buat dan dapat digunakan dengan sebagaimana mestinya.", fontNormal))
                        doc.Add(Chunk.NEWLINE)
                        doc.Add(New Paragraph("Ket:", fontBold))
                        doc.Add(New Paragraph("- Keterlambatan kembali ke pondok akan dikenakan denda Rp. 10.000/hari dan sanksi bersih-bersih.", fontSmall))
                        doc.Add(New Paragraph("- Contact Person Syaikhuna: 081218252700", fontSmall))
                        doc.Add(Chunk.NEWLINE)

                        ' Tanda tangan
                        Dim ttdTable As New PdfPTable(3)
                        ttdTable.WidthPercentage = 100
                        ttdTable.SetWidths(New Single() {3.0F, 3.0F, 3.0F})

                        ttdTable.AddCell(CreateTtdCell("Orang Tua / Wali", fontNormal))
                        ttdTable.AddCell(CreateTtdCell("Mengetahui", fontNormal))
                        ttdTable.AddCell(CreateTtdCell("Pimpinan Ponpes", fontNormal))

                        For i = 1 To 3
                            ttdTable.AddCell(CreateTtdCell("", fontNormal, 50))
                        Next

                        ttdTable.AddCell(CreateTtdCell("", fontNormal))
                        ttdTable.AddCell(CreateTtdCell("", fontNormal))
                        ttdTable.AddCell(CreateTtdCell("(KH. Dace Sofyan)", fontNormal))

                        doc.Add(ttdTable)
                        doc.Close()
                        stream.Close()
                    End Using


                    ' Buka PDF otomatis setelah selesai
                    'Process.Start(filePath)
                End If
            Else
                MessageBox.Show("Data tidak ditemukan untuk no izin: " & noIzin, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal membuat surat: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub
    Public Sub CetakSuratTransaksiPDF(noTransaksi As String, Optional isIzin As Boolean = False)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "
        SELECT 
            t.id AS transaksi_id,
            t.no_transaksi,
            u1.nama AS nama_pengguna,
            u2.nama AS nama_petugas,
            t.tanggal_transaksi,
            t.type_pembayaran,
            dt.id AS detail_transaksi_id,
            dt.jumlah,
            dt.type AS detail_type,
            dt.image_bukti,
            dt.keterangan AS detail_keterangan,
            dt.created_at AS detail_created_at,
            dt.updated_at AS detail_updated_at
        FROM 
            transaksi t
        JOIN 
            users u1 ON t.pengguna_id = u1.id  
        JOIN 
            users u2 ON t.petugas_id = u2.id  
        JOIN 
            detail_transaksi dt ON t.id = dt.transaksi_id  
        WHERE 
            t.deleted_at IS NULL"

            ' Menambahkan kondisi WHERE berdasarkan no_transaksi
            If Not String.IsNullOrEmpty(noTransaksi) Then
                query &= " AND t.no_transaksi = @noTransaksi"
            End If

            ' Eksekusi query berdasarkan kondisi
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@noTransaksi", noTransaksi)

            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                ' Ambil data dan lanjutkan seperti biasa...
            Else
                MessageBox.Show("Data tidak ditemukan untuk no transaksi: " & noTransaksi, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal membuat surat: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Database.CloseConnection(conn)
        End Try
    End Sub


    Private Function CreateTtdCell(text As String, font As Font, Optional height As Integer = 20) As PdfPCell
        Dim cell As New PdfPCell(New Phrase(text, font))
        cell.Border = Rectangle.NO_BORDER
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.FixedHeight = height
        Return cell
    End Function

End Module
