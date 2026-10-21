
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class Form1

    Private txtKode As TextBox
    Private txtJudul As TextBox
    Private cboKategori As ComboBox
    Private txtNama As TextBox
    Private txtLamaPinjam As TextBox

    Private btnPinjam As Button
    Private btnBersihkan As Button
    Private btnEkspor As Button

    Private lstPeminjaman As ListBox
    Private lblStatus As Label
    Private errInput As ErrorProvider

    Private ReadOnly daftarPeminjaman As New List(Of DataPeminjaman)
    Private ReadOnly kodeSedangDipinjam As New HashSet(Of String)(
        StringComparer.OrdinalIgnoreCase
    )

    Public Sub New()
        InitializeComponent()
        BuildInterface()
    End Sub

    Private Sub BuildInterface()

        Me.Text = "Sistem Peminjaman Buku"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.ClientSize = New Size(900, 680)
        Me.MinimumSize = New Size(820, 650)
        Me.BackColor = Color.FromArgb(245, 247, 250)
        Me.Font = New Font("Segoe UI", 10)
        Me.AutoScaleMode = AutoScaleMode.Font

        errInput = New ErrorProvider()
        errInput.ContainerControl = Me
        errInput.BlinkStyle = ErrorBlinkStyle.NeverBlink

        Dim mainPanel As New TableLayoutPanel With {
            .Dock = DockStyle.Fill,
            .Padding = New Padding(20),
            .ColumnCount = 1,
            .RowCount = 4
        }

        mainPanel.ColumnStyles.Add(
            New ColumnStyle(SizeType.Percent, 100)
        )
        mainPanel.RowStyles.Add(
            New RowStyle(SizeType.Absolute, 70)
        )
        mainPanel.RowStyles.Add(
            New RowStyle(SizeType.Absolute, 275)
        )
        mainPanel.RowStyles.Add(
            New RowStyle(SizeType.Percent, 100)
        )
        mainPanel.RowStyles.Add(
            New RowStyle(SizeType.Absolute, 35)
        )

        Me.Controls.Add(mainPanel)

        Dim header As New Panel With {
            .Dock = DockStyle.Fill,
            .BackColor = Color.FromArgb(26, 54, 93),
            .Padding = New Padding(16, 5, 10, 5)
        }

        Dim lblHeader As New Label With {
            .Text = "SISTEM PEMINJAMAN BUKU",
            .Dock = DockStyle.Fill,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 17, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleLeft
        }

        header.Controls.Add(lblHeader)
        mainPanel.Controls.Add(header, 0, 0)

        Dim groupInput As New GroupBox With {
            .Text = "Form Data Peminjaman",
            .Dock = DockStyle.Fill,
            .Padding = New Padding(12),
            .ForeColor = Color.FromArgb(26, 54, 93)
        }

        mainPanel.Controls.Add(groupInput, 0, 1)

        Dim inputLayout As New TableLayoutPanel With {
            .Dock = DockStyle.Fill,
            .ColumnCount = 4,
            .RowCount = 4,
            .Padding = New Padding(5)
        }

        inputLayout.ColumnStyles.Add(
            New ColumnStyle(SizeType.Absolute, 125)
        )
        inputLayout.ColumnStyles.Add(
            New ColumnStyle(SizeType.Percent, 50)
        )
        inputLayout.ColumnStyles.Add(
            New ColumnStyle(SizeType.Absolute, 135)
        )
        inputLayout.ColumnStyles.Add(
            New ColumnStyle(SizeType.Percent, 50)
        )

        For i As Integer = 0 To 2
            inputLayout.RowStyles.Add(
                New RowStyle(SizeType.Percent, 25)
            )
        Next

        inputLayout.RowStyles.Add(
            New RowStyle(SizeType.Absolute, 55)
        )

        groupInput.Controls.Add(inputLayout)

        txtKode = New TextBox()
        txtJudul = New TextBox()

        cboKategori = New ComboBox With {
            .DropDownStyle = ComboBoxStyle.DropDownList
        }

        cboKategori.Items.AddRange(New Object() {
            "Novel",
            "Pendidikan",
            "Teknologi",
            "Sejarah",
            "Kesehatan",
            "Agama",
            "Lainnya"
        })

        txtNama = New TextBox()
        txtLamaPinjam = New TextBox()

        AddField(
            inputLayout, "Kode Buku:", txtKode, 0, 0
        )

        AddField(
            inputLayout, "Judul Buku:", txtJudul, 0, 1
        )

        AddField(
            inputLayout, "Kategori:", cboKategori, 1, 0
        )

        AddField(
            inputLayout, "Nama Peminjam:", txtNama, 1, 1
        )

        AddField(
            inputLayout, "Lama Pinjam (hari):",
            txtLamaPinjam, 2, 0
        )

        Dim panelTombol As New TableLayoutPanel With {
            .Dock = DockStyle.Fill,
            .ColumnCount = 3,
            .RowCount = 1,
            .Padding = New Padding(0, 5, 0, 0),
            .Margin = New Padding(0)
        }

        For i As Integer = 0 To 2
            panelTombol.ColumnStyles.Add(
                New ColumnStyle(SizeType.Percent, 33.3333F)
            )
        Next

        panelTombol.RowStyles.Add(
            New RowStyle(SizeType.Percent, 100)
        )

        btnPinjam = CreateButton(
            "Pinjam Buku",
            Color.FromArgb(37, 99, 160)
        )

        btnBersihkan = CreateButton(
            "Bersihkan",
            Color.FromArgb(100, 116, 139)
        )

        btnEkspor = CreateButton(
            "Ekspor CSV",
            Color.FromArgb(22, 130, 90)
        )

        AddHandler btnPinjam.Click, AddressOf btnPinjam_Click
        AddHandler btnBersihkan.Click, AddressOf btnBersihkan_Click
        AddHandler btnEkspor.Click, AddressOf btnEkspor_Click

        panelTombol.Controls.Add(btnPinjam, 0, 0)
        panelTombol.Controls.Add(btnBersihkan, 1, 0)
        panelTombol.Controls.Add(btnEkspor, 2, 0)

        inputLayout.Controls.Add(panelTombol, 0, 3)
        inputLayout.SetColumnSpan(panelTombol, 4)

        Dim groupDaftar As New GroupBox With {
            .Text = "Daftar Peminjaman",
            .Dock = DockStyle.Fill,
            .Padding = New Padding(10),
            .ForeColor = Color.FromArgb(26, 54, 93)
        }

        mainPanel.Controls.Add(groupDaftar, 0, 2)

        lstPeminjaman = New ListBox With {
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10),
            .HorizontalScrollbar = True,
            .IntegralHeight = False,
            .BackColor = Color.White,
            .BorderStyle = BorderStyle.FixedSingle
        }

        groupDaftar.Controls.Add(lstPeminjaman)

        lblStatus = New Label With {
            .Dock = DockStyle.Fill,
            .Text = "Siap digunakan. Silakan isi data peminjaman.",
            .ForeColor = Color.FromArgb(55, 65, 81),
            .TextAlign = ContentAlignment.MiddleLeft
        }

        mainPanel.Controls.Add(lblStatus, 0, 3)

    End Sub

    Private Sub AddField(
        layout As TableLayoutPanel,
        labelText As String,
        control As Control,
        row As Integer,
        columnPair As Integer
    )

        Dim labelColumn As Integer =
            If(columnPair = 0, 0, 2)

        Dim controlColumn As Integer =
            labelColumn + 1

        Dim lbl As New Label With {
            .Text = labelText,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleLeft,
            .ForeColor = Color.FromArgb(55, 65, 81),
            .Margin = New Padding(3, 5, 5, 5)
        }

        control.Dock = DockStyle.Fill
        control.Margin = New Padding(3, 7, 10, 7)
        control.Font = New Font("Segoe UI", 10)

        layout.Controls.Add(lbl, labelColumn, row)
        layout.Controls.Add(control, controlColumn, row)

    End Sub
    Private Function CreateButton(
        buttonText As String,
        buttonColor As Color
    ) As Button

        Return New Button With {
            .Text = buttonText,
            .Dock = DockStyle.Fill,
            .Margin = New Padding(5, 3, 5, 3),
            .BackColor = buttonColor,
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold),
            .Cursor = Cursors.Hand,
            .UseVisualStyleBackColor = False
        }

    End Function

    Private Function ValidasiInput() As Boolean

        errInput.Clear()
        Dim valid As Boolean = True

        If String.IsNullOrWhiteSpace(txtKode.Text) Then
            errInput.SetError(txtKode, "Kode buku wajib diisi.")
            valid = False

        ElseIf Not Regex.IsMatch(
            txtKode.Text.Trim(), "^BK[0-9]{4}$"
        ) Then
            errInput.SetError(
                txtKode, "Format harus BK diikuti 4 angka."
            )
            valid = False

        ElseIf kodeSedangDipinjam.Contains(txtKode.Text.Trim()) Then
            errInput.SetError(
                txtKode, "Buku ini masih sedang dipinjam."
            )
            valid = False
        End If

        If String.IsNullOrWhiteSpace(txtJudul.Text) Then
            errInput.SetError(txtJudul, "Judul buku wajib diisi.")
            valid = False
        End If

        If cboKategori.SelectedIndex = -1 Then
            errInput.SetError(cboKategori, "Pilih kategori buku.")
            valid = False
        End If

        If String.IsNullOrWhiteSpace(txtNama.Text) OrElse
           txtNama.Text.Trim().Length < 3 Then

            errInput.SetError(txtNama, "Nama minimal 3 karakter.")
            valid = False
        End If

        Dim lama As Integer

        If Not Integer.TryParse(txtLamaPinjam.Text.Trim(), lama) Then
            errInput.SetError(
                txtLamaPinjam, "Durasi harus berupa angka bulat."
            )
            valid = False

        ElseIf lama < 1 OrElse lama > 14 Then
            errInput.SetError(
                txtLamaPinjam, "Durasi harus antara 1–14 hari."
            )
            valid = False
        End If

        If Not valid Then
            lblStatus.Text = "Periksa kembali data yang ditandai."
            lblStatus.ForeColor = Color.Firebrick
        End If

        Return valid

    End Function

    Private Sub btnPinjam_Click(
        sender As Object,
        e As EventArgs
    )

        If Not ValidasiInput() Then
            MessageBox.Show(
                "Data belum valid. Periksa kembali input Anda.",
                "Validasi Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        Dim lama As Integer
        Integer.TryParse(txtLamaPinjam.Text.Trim(), lama)

        Dim tanggalPinjam As Date = Date.Today
        Dim tanggalKembali As Date = tanggalPinjam.AddDays(lama)

        Dim data As New DataPeminjaman With {
            .Kode = txtKode.Text.Trim().ToUpperInvariant(),
            .Judul = txtJudul.Text.Trim(),
            .Kategori = cboKategori.Text,
            .NamaPeminjam = txtNama.Text.Trim(),
            .LamaPinjam = lama,
            .TanggalPinjam = tanggalPinjam,
            .TanggalKembali = tanggalKembali
        }

        daftarPeminjaman.Add(data)
        kodeSedangDipinjam.Add(data.Kode)
        lstPeminjaman.Items.Add(data)

        lblStatus.Text =
            "Peminjaman berhasil. Tanggal kembali: " &
            tanggalKembali.ToString("dd-MM-yyyy")

        lblStatus.ForeColor = Color.DarkGreen

        MessageBox.Show(
            "Data peminjaman berhasil disimpan.",
            "Berhasil",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

        BersihkanForm()

    End Sub

    Private Sub btnBersihkan_Click(
        sender As Object,
        e As EventArgs
    )

        BersihkanForm()

        lblStatus.Text = "Form berhasil dibersihkan."
        lblStatus.ForeColor = Color.FromArgb(55, 65, 81)

    End Sub

    Private Sub BersihkanForm()

        txtKode.Clear()
        txtJudul.Clear()
        cboKategori.SelectedIndex = -1
        txtNama.Clear()
        txtLamaPinjam.Clear()

        errInput.Clear()
        txtKode.Focus()

    End Sub

    Private Sub btnEkspor_Click(
        sender As Object,
        e As EventArgs
    )

        If daftarPeminjaman.Count = 0 Then
            MessageBox.Show(
                "Belum ada data peminjaman untuk diekspor.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            Return
        End If

        Dim lokasiFile As String

        Using dialog As New SaveFileDialog()

            dialog.Title = "Simpan Data Peminjaman"
            dialog.Filter = "CSV File (*.csv)|*.csv"
            dialog.FileName = "DataPeminjaman.csv"
            dialog.DefaultExt = "csv"
            dialog.AddExtension = True

            If dialog.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            lokasiFile = dialog.FileName

        End Using

        Dim writer As StreamWriter = Nothing

        Try

            writer = New StreamWriter(
                lokasiFile, False, New UTF8Encoding(True)
            )

            writer.WriteLine(
                "Kode Buku,Judul Buku,Kategori,Nama Peminjam," &
                "Lama Pinjam,Tanggal Pinjam,Tanggal Kembali"
            )

            For Each data As DataPeminjaman In daftarPeminjaman

                writer.WriteLine(
                    CsvField(data.Kode) & "," &
                    CsvField(data.Judul) & "," &
                    CsvField(data.Kategori) & "," &
                    CsvField(data.NamaPeminjam) & "," &
                    data.LamaPinjam.ToString(
                        CultureInfo.InvariantCulture
                    ) & "," &
                    CsvField(
                        data.TanggalPinjam.ToString("dd-MM-yyyy")
                    ) & "," &
                    CsvField(
                        data.TanggalKembali.ToString("dd-MM-yyyy")
                    )
                )

            Next

            writer.Flush()

            MessageBox.Show(
                "Data berhasil diekspor ke:" &
                Environment.NewLine & lokasiFile,
                "Ekspor Berhasil",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        Catch ex As IOException

            MessageBox.Show(
                "Terjadi kesalahan file: " & ex.Message,
                "Kesalahan File",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Catch ex As UnauthorizedAccessException

            MessageBox.Show(
                "Akses ditolak. Pilih folder penyimpanan lain.",
                "Akses Ditolak",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Catch ex As Exception

            MessageBox.Show(
                "Ekspor gagal: " & ex.Message,
                "Kesalahan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Finally

            If writer IsNot Nothing Then
                Try
                    writer.Dispose()

                Catch ex As IOException
                    MessageBox.Show(
                        "File gagal ditutup: " & ex.Message,
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    )
                End Try
            End If

        End Try

    End Sub

    Private Function CsvField(nilai As String) As String

        If nilai Is Nothing Then
            nilai = ""
        End If

        Return """" & nilai.Replace("""", """""") & """"

    End Function

End Class

Public Class DataPeminjaman

    Public Property Kode As String
    Public Property Judul As String
    Public Property Kategori As String
    Public Property NamaPeminjam As String
    Public Property LamaPinjam As Integer
    Public Property TanggalPinjam As Date
    Public Property TanggalKembali As Date

    Public Overrides Function ToString() As String

        Return Kode &
            " | " & Judul &
            " | Peminjam: " & NamaPeminjam &
            " | " & LamaPinjam & " hari" &
            " | Kembali: " &
            TanggalKembali.ToString("dd-MM-yyyy")

    End Function

End Class
