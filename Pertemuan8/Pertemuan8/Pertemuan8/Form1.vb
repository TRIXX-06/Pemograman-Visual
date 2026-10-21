
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Text

Public Class Form1

    Private tabelBuku As DataTable
    Private bsBuku As New BindingSource()

    Private txtKode As TextBox
    Private txtJudul As TextBox
    Private txtPenulis As TextBox
    Private txtTahun As TextBox
    Private txtStok As TextBox
    Private txtCari As TextBox

    Private cmbKategori As ComboBox
    Private cmbFilterKategori As ComboBox

    Private dgvBuku As DataGridView
    Private lblJumlah As Label
    Private lblTotalStok As Label

    Public Sub New()
        InitializeComponent()

        ' Tampilan dibuat langsung melalui kode
        Me.Controls.Clear()

        BuatTampilan()
        BuatTabelBuku()
        IsiDataAwal()
        AturGrid()
        PerbaruiRingkasan()
    End Sub

    Private Sub BuatTampilan()

        Me.Text = "Sistem Inventaris Buku Perpustakaan"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Size = New Size(1150, 720)
        Me.MinimumSize = New Size(950, 650)
        Me.BackColor = Color.WhiteSmoke
        Me.Font = New Font("Segoe UI", 10)

        Dim panelUtama As New TableLayoutPanel()
        panelUtama.Dock = DockStyle.Fill
        panelUtama.ColumnCount = 1
        panelUtama.RowCount = 4
        panelUtama.Padding = New Padding(15)

        panelUtama.RowStyles.Add(
            New RowStyle(SizeType.Absolute, 50))
        panelUtama.RowStyles.Add(
            New RowStyle(SizeType.Absolute, 210))
        panelUtama.RowStyles.Add(
            New RowStyle(SizeType.Absolute, 50))
        panelUtama.RowStyles.Add(
            New RowStyle(SizeType.Percent, 100))

        Me.Controls.Add(panelUtama)

        Dim lblJudulForm As New Label()
        lblJudulForm.Text = "INVENTARIS BUKU PERPUSTAKAAN"
        lblJudulForm.Dock = DockStyle.Fill
        lblJudulForm.Font = New Font(
            "Segoe UI", 17, FontStyle.Bold)
        lblJudulForm.ForeColor = Color.DarkSlateBlue
        lblJudulForm.TextAlign = ContentAlignment.MiddleCenter

        panelUtama.Controls.Add(lblJudulForm, 0, 0)

        Dim panelInput As New TableLayoutPanel()
        panelInput.Dock = DockStyle.Fill
        panelInput.ColumnCount = 4
        panelInput.RowCount = 4
        panelInput.Padding = New Padding(5)
        panelInput.BackColor = Color.White

        panelInput.ColumnStyles.Add(
            New ColumnStyle(SizeType.Percent, 17))
        panelInput.ColumnStyles.Add(
            New ColumnStyle(SizeType.Percent, 33))
        panelInput.ColumnStyles.Add(
            New ColumnStyle(SizeType.Percent, 17))
        panelInput.ColumnStyles.Add(
            New ColumnStyle(SizeType.Percent, 33))

        panelInput.RowStyles.Add(
            New RowStyle(SizeType.Percent, 25))
        panelInput.RowStyles.Add(
            New RowStyle(SizeType.Percent, 25))
        panelInput.RowStyles.Add(
            New RowStyle(SizeType.Percent, 25))
        panelInput.RowStyles.Add(
            New RowStyle(SizeType.Percent, 25))

        panelUtama.Controls.Add(panelInput, 0, 1)

        txtKode = New TextBox()
        txtJudul = New TextBox()
        txtPenulis = New TextBox()
        txtTahun = New TextBox()
        txtStok = New TextBox()

        cmbKategori = New ComboBox()
        cmbKategori.DropDownStyle =
            ComboBoxStyle.DropDownList
        cmbKategori.Dock = DockStyle.Fill

        cmbKategori.Items.AddRange(New Object() {
            "Novel",
            "Pendidikan",
            "Teknologi",
            "Sejarah",
            "Kesehatan",
            "Agama",
            "Lainnya"
        })

        cmbKategori.SelectedIndex = 0

        TambahInput(
            panelInput, "Kode Buku",
            txtKode, 0, 0)

        TambahInput(
            panelInput, "Judul Buku",
            txtJudul, 1, 0)

        TambahInput(
            panelInput, "Penulis",
            txtPenulis, 0, 1)

        TambahInput(
            panelInput, "Kategori",
            cmbKategori, 1, 1)

        TambahInput(
            panelInput, "Tahun Terbit",
            txtTahun, 0, 2)

        TambahInput(
            panelInput, "Stok Buku",
            txtStok, 1, 2)

        Dim panelTombol As New FlowLayoutPanel()
        panelTombol.Dock = DockStyle.Fill
        panelTombol.FlowDirection =
            FlowDirection.LeftToRight
        panelTombol.WrapContents = False
        panelTombol.Padding = New Padding(0, 3, 0, 0)

        Dim btnTambah As New Button()
        btnTambah.Text = "Tambah Buku"
        btnTambah.Size = New Size(125, 34)
        btnTambah.BackColor = Color.DarkSlateBlue
        btnTambah.ForeColor = Color.White
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Margin = New Padding(3, 2, 10, 2)

        AddHandler btnTambah.Click, AddressOf TambahBuku

        Dim btnReset As New Button()
        btnReset.Text = "Reset Input"
        btnReset.Size = New Size(105, 34)
        btnReset.Margin = New Padding(3, 2, 3, 2)

        AddHandler btnReset.Click, AddressOf ResetInput

        panelTombol.Controls.Add(btnTambah)
        panelTombol.Controls.Add(btnReset)

        panelInput.Controls.Add(panelTombol, 0, 3)
        panelInput.SetColumnSpan(panelTombol, 4)

        Dim panelCari As New FlowLayoutPanel()
        panelCari.Dock = DockStyle.Fill
        panelCari.WrapContents = False
        panelCari.Padding = New Padding(0, 10, 0, 0)

        Dim lblCari As New Label()
        lblCari.Text = "Cari judul/penulis:"
        lblCari.AutoSize = True
        lblCari.Margin = New Padding(0, 7, 5, 0)

        txtCari = New TextBox()
        txtCari.Width = 220
        txtCari.Margin = New Padding(0, 3, 15, 0)

        AddHandler txtCari.TextChanged,
            AddressOf TerapkanFilter

        Dim lblKategoriFilter As New Label()
        lblKategoriFilter.Text = "Kategori:"
        lblKategoriFilter.AutoSize = True
        lblKategoriFilter.Margin = New Padding(0, 7, 5, 0)

        cmbFilterKategori = New ComboBox()
        cmbFilterKategori.Width = 155
        cmbFilterKategori.DropDownStyle =
            ComboBoxStyle.DropDownList

        cmbFilterKategori.Items.Add("Semua Kategori")
        cmbFilterKategori.Items.AddRange(New Object() {
            "Novel",
            "Pendidikan",
            "Teknologi",
            "Sejarah",
            "Kesehatan",
            "Agama",
            "Lainnya"
        })

        cmbFilterKategori.SelectedIndex = 0
        cmbFilterKategori.Margin = New Padding(0, 3, 10, 0)

        AddHandler cmbFilterKategori.SelectedIndexChanged,
            AddressOf TerapkanFilter

        Dim btnBersihkan As New Button()
        btnBersihkan.Text = "Bersihkan Filter"
        btnBersihkan.AutoSize = True
        btnBersihkan.Margin = New Padding(0, 1, 0, 0)

        AddHandler btnBersihkan.Click,
            AddressOf BersihkanFilter

        panelCari.Controls.Add(lblCari)
        panelCari.Controls.Add(txtCari)
        panelCari.Controls.Add(lblKategoriFilter)
        panelCari.Controls.Add(cmbFilterKategori)
        panelCari.Controls.Add(btnBersihkan)

        panelUtama.Controls.Add(panelCari, 0, 2)

        Dim panelData As New TableLayoutPanel()
        panelData.Dock = DockStyle.Fill
        panelData.ColumnCount = 1
        panelData.RowCount = 2

        panelData.RowStyles.Add(
            New RowStyle(SizeType.Absolute, 35))
        panelData.RowStyles.Add(
            New RowStyle(SizeType.Percent, 100))

        panelUtama.Controls.Add(panelData, 0, 3)

        Dim panelRingkasan As New FlowLayoutPanel()
        panelRingkasan.Dock = DockStyle.Fill
        panelRingkasan.WrapContents = False

        lblJumlah = New Label()
        lblJumlah.AutoSize = True
        lblJumlah.Font = New Font(
            "Segoe UI", 10, FontStyle.Bold)
        lblJumlah.Margin = New Padding(0, 5, 30, 0)

        lblTotalStok = New Label()
        lblTotalStok.AutoSize = True
        lblTotalStok.Font = New Font(
            "Segoe UI", 10, FontStyle.Bold)
        lblTotalStok.Margin = New Padding(0, 5, 0, 0)

        panelRingkasan.Controls.Add(lblJumlah)
        panelRingkasan.Controls.Add(lblTotalStok)

        panelData.Controls.Add(panelRingkasan, 0, 0)

        dgvBuku = New DataGridView()
        dgvBuku.Dock = DockStyle.Fill
        dgvBuku.BackgroundColor = Color.White
        dgvBuku.BorderStyle = BorderStyle.Fixed3D
        dgvBuku.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.AllowUserToDeleteRows = False
        dgvBuku.ReadOnly = True
        dgvBuku.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect
        dgvBuku.MultiSelect = False
        dgvBuku.RowHeadersVisible = False

        panelData.Controls.Add(dgvBuku, 0, 1)

    End Sub

    Private Sub TambahInput(
        panel As TableLayoutPanel,
        teks As String,
        kontrol As Control,
        kolom As Integer,
        baris As Integer)

        Dim lbl As New Label()
        lbl.Text = teks
        lbl.Dock = DockStyle.Fill
        lbl.TextAlign = ContentAlignment.MiddleLeft
        lbl.Padding = New Padding(5, 0, 0, 0)

        kontrol.Dock = DockStyle.Fill
        kontrol.Margin = New Padding(3, 5, 8, 5)

        panel.Controls.Add(lbl, kolom * 2, baris)
        panel.Controls.Add(kontrol, kolom * 2 + 1, baris)

    End Sub

    Private Sub BuatTabelBuku()

        tabelBuku = New DataTable("InventarisBuku")

        tabelBuku.Columns.Add("KodeBuku", GetType(String))
        tabelBuku.Columns.Add("Judul", GetType(String))
        tabelBuku.Columns.Add("Penulis", GetType(String))
        tabelBuku.Columns.Add("Kategori", GetType(String))
        tabelBuku.Columns.Add("TahunTerbit", GetType(Integer))
        tabelBuku.Columns.Add("Stok", GetType(Integer))

        bsBuku.DataSource = tabelBuku
        dgvBuku.DataSource = bsBuku

    End Sub

    Private Sub IsiDataAwal()

        tabelBuku.Rows.Add(
            "BK001", "Laskar Pelangi",
            "Andrea Hirata", "Novel", 2005, 8)

        tabelBuku.Rows.Add(
            "BK002", "Bumi Manusia",
            "Pramoedya Ananta Toer", "Sejarah", 1980, 5)

        tabelBuku.Rows.Add(
            "BK003", "Algoritma dan Pemrograman",
            "Rinaldi Munir", "Teknologi", 2016, 7)

        tabelBuku.Rows.Add(
            "BK004", "Dasar-Dasar Keperawatan",
            "Asmadi", "Kesehatan", 2008, 6)

        tabelBuku.Rows.Add(
            "BK005", "Negeri 5 Menara",
            "Ahmad Fuadi", "Novel", 2009, 9)

        tabelBuku.Rows.Add(
            "BK006", "Pengantar Teknologi Informasi",
            "Abdul Kadir", "Teknologi", 2014, 4)

        tabelBuku.Rows.Add(
            "BK007", "Sejarah Indonesia",
            "Ricklefs", "Sejarah", 2008, 3)

        tabelBuku.Rows.Add(
            "BK008", "Pendidikan Pancasila",
            "Kaelan", "Pendidikan", 2013, 10)

        tabelBuku.Rows.Add(
            "BK009", "Etika Keperawatan",
            "Haryanto", "Kesehatan", 2012, 6)

        tabelBuku.Rows.Add(
            "BK010", "Pendidikan Agama",
            "Tim Penulis", "Agama", 2020, 5)

    End Sub

    Private Sub AturGrid()

        With dgvBuku
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode =
                DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill

            .AlternatingRowsDefaultCellStyle.BackColor =
                Color.AliceBlue

            .ColumnHeadersDefaultCellStyle.BackColor =
                Color.DarkSlateBlue

            .ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White

            .EnableHeadersVisualStyles = False
            .ColumnHeadersHeight = 35
            .RowTemplate.Height = 28
        End With

        dgvBuku.Columns("KodeBuku").HeaderText = "Kode Buku"
        dgvBuku.Columns("Judul").HeaderText = "Judul Buku"
        dgvBuku.Columns("Penulis").HeaderText = "Penulis"
        dgvBuku.Columns("Kategori").HeaderText = "Kategori"
        dgvBuku.Columns("TahunTerbit").HeaderText = "Tahun Terbit"
        dgvBuku.Columns("Stok").HeaderText = "Stok"

        dgvBuku.Columns("KodeBuku").FillWeight = 65
        dgvBuku.Columns("Judul").FillWeight = 150
        dgvBuku.Columns("Penulis").FillWeight = 130
        dgvBuku.Columns("Kategori").FillWeight = 80
        dgvBuku.Columns("TahunTerbit").FillWeight = 65
        dgvBuku.Columns("Stok").FillWeight = 45

    End Sub

    Private Sub TambahBuku(
        sender As Object,
        e As EventArgs)

        Dim kode As String = txtKode.Text.Trim()
        Dim judul As String = txtJudul.Text.Trim()
        Dim penulis As String = txtPenulis.Text.Trim()
        Dim kategori As String =
            Convert.ToString(cmbKategori.SelectedItem)

        Dim tahun As Integer
        Dim stok As Integer

        If kode = "" OrElse
           judul = "" OrElse
           penulis = "" OrElse
           txtTahun.Text.Trim() = "" OrElse
           txtStok.Text.Trim() = "" OrElse
           kategori = "" Then

            MessageBox.Show(
                "Semua data buku wajib diisi.",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            Return
        End If

        If Not Integer.TryParse(
            txtTahun.Text.Trim(), tahun) OrElse
            tahun < 1 OrElse
            tahun > DateTime.Now.Year Then

            MessageBox.Show(
                "Tahun terbit tidak valid.",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtTahun.Focus()
            Return
        End If

        ' Validasi stok
        If Not Integer.TryParse(
            txtStok.Text.Trim(), stok) OrElse
            stok < 0 Then

            MessageBox.Show(
                "Stok harus berupa bilangan bulat minimal 0.",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtStok.Focus()
            Return
        End If

        For Each baris As DataRow In tabelBuku.Rows

            If String.Equals(
                Convert.ToString(baris("KodeBuku")),
                kode,
                StringComparison.OrdinalIgnoreCase) Then

                MessageBox.Show(
                    "Kode buku sudah digunakan. Gunakan kode lain.",
                    "Kode Duplikat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)

                txtKode.Focus()
                Return
            End If

        Next

        ' Memasukkan data ke DataTable
        tabelBuku.Rows.Add(
            kode, judul, penulis, kategori, tahun, stok)

        ' Perbarui tampilan dan ringkasan
        ResetInput(Nothing, EventArgs.Empty)
        TerapkanFilter(Nothing, EventArgs.Empty)

        MessageBox.Show(
            "Buku berhasil ditambahkan.",
            "Berhasil",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

    End Sub

    Private Sub TerapkanFilter(
        sender As Object,
        e As EventArgs)

        If bsBuku Is Nothing OrElse
           txtCari Is Nothing OrElse
           cmbFilterKategori Is Nothing Then
            Return
        End If

        Dim teks As String = txtCari.Text.Trim()
        Dim kategori As String = ""

        If cmbFilterKategori.SelectedIndex > 0 Then
            kategori = Convert.ToString(
                cmbFilterKategori.SelectedItem)
        End If

        Dim kondisi As New List(Of String)

        If teks <> "" Then

            Dim teksAman As String = AmankanTeksFilter(teks)

            kondisi.Add(
                "([Judul] LIKE '%" & teksAman &
                "%' OR [Penulis] LIKE '%" & teksAman & "%')")

        End If

        If kategori <> "" Then

            Dim kategoriAman As String =
                kategori.Replace("'", "''")

            kondisi.Add(
                "[Kategori] = '" & kategoriAman & "'")

        End If

        If kondisi.Count > 0 Then
            bsBuku.Filter = String.Join(" AND ", kondisi)
        Else
            bsBuku.RemoveFilter()
        End If

        PerbaruiRingkasan()

    End Sub

    Private Function AmankanTeksFilter(
        teks As String) As String

        Dim hasil As New StringBuilder()

        For Each karakter As Char In teks

            Select Case karakter
                Case "'"
                    hasil.Append("''")
                Case "["
                    hasil.Append("[[]")
                Case "]"
                    hasil.Append("[]]")
                Case "%"
                    hasil.Append("[%]")
                Case "*"
                    hasil.Append("[*]")
                Case Else
                    hasil.Append(karakter)
            End Select

        Next

        Return hasil.ToString()

    End Function

    Private Sub BersihkanFilter(
        sender As Object,
        e As EventArgs)

        txtCari.Clear()
        cmbFilterKategori.SelectedIndex = 0

        bsBuku.RemoveFilter()
        PerbaruiRingkasan()

    End Sub

    Private Sub ResetInput(
        sender As Object,
        e As EventArgs)

        txtKode.Clear()
        txtJudul.Clear()
        txtPenulis.Clear()
        txtTahun.Clear()
        txtStok.Clear()

        cmbKategori.SelectedIndex = 0
        txtKode.Focus()

    End Sub

    Private Sub PerbaruiRingkasan()

        If bsBuku Is Nothing OrElse
           lblJumlah Is Nothing OrElse
           lblTotalStok Is Nothing Then
            Return
        End If

        Dim jumlah As Integer = 0
        Dim totalStok As Integer = 0

        For Each item As Object In bsBuku

            Dim baris As DataRowView =
                TryCast(item, DataRowView)

            If baris IsNot Nothing Then
                jumlah += 1
                totalStok += Convert.ToInt32(baris("Stok"))
            End If

        Next

        lblJumlah.Text = "Jumlah buku: " & jumlah.ToString()
        lblTotalStok.Text = "Total stok: " & totalStok.ToString()

    End Sub

End Class
