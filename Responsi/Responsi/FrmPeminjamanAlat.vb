
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class FrmPeminjamanAlat

    Inherits Form

    Private daftarAlat As New List(Of AlatLab)

    Private bsAlat As New BindingSource()

    Private errInput As New ErrorProvider()

    Private cboAlat As New ComboBox()
    Private txtJumlah As New TextBox()

    Private btnPinjam As New Button()
    Private btnKembalikan As New Button()
    Private btnReset As New Button()

    Private dgvAlat As New DataGridView()

    Private lblTotalDipinjam As New Label()

    Private lblJudul As New Label()
    Private lblAlat As New Label()
    Private lblJumlah As New Label()
    Private lblKeterangan As New Label()

    Public Sub New()

        MyBase.New()

        BuatTampilan()

        AddHandler Me.Load,
            AddressOf FrmPeminjamanAlat_Load

    End Sub



    Private Sub BuatTampilan()

        Me.Text = "Aplikasi Peminjaman Alat Laboratorium"

        Me.Size = New Size(850, 600)

        Me.StartPosition = FormStartPosition.CenterScreen

        Me.MinimumSize = New Size(750, 500)

        Me.BackColor = Color.WhiteSmoke

        ' Layout utama

        Dim layout As New TableLayoutPanel()

        layout.Dock = DockStyle.Fill

        layout.ColumnCount = 1

        layout.RowCount = 5

        layout.Padding = New Padding(15)

        layout.RowStyles.Add(
            New RowStyle(SizeType.Absolute, 65))

        layout.RowStyles.Add(
            New RowStyle(SizeType.Absolute, 105))

        layout.RowStyles.Add(
            New RowStyle(SizeType.Absolute, 55))

        layout.RowStyles.Add(
            New RowStyle(SizeType.Percent, 100))

        layout.RowStyles.Add(
            New RowStyle(SizeType.Absolute, 50))


        lblJudul.Name = "lblJudul"

        lblJudul.Text = "PEMINJAMAN ALAT LABORATORIUM"

        lblJudul.Font = New Font(
            "Segoe UI", 17, FontStyle.Bold)

        lblJudul.ForeColor = Color.DarkBlue

        lblJudul.Dock = DockStyle.Fill

        lblJudul.TextAlign =
            ContentAlignment.MiddleCenter

        layout.Controls.Add(lblJudul, 0, 0)

        ' =====================================
        ' PANEL INPUT
        ' =====================================

        Dim panelInput As New TableLayoutPanel()

        panelInput.Dock = DockStyle.Fill

        panelInput.ColumnCount = 2

        panelInput.RowCount = 2

        panelInput.ColumnStyles.Add(
            New ColumnStyle(SizeType.Percent, 50))

        panelInput.ColumnStyles.Add(
            New ColumnStyle(SizeType.Percent, 50))

        panelInput.RowStyles.Add(
            New RowStyle(SizeType.Absolute, 30))

        panelInput.RowStyles.Add(
            New RowStyle(SizeType.Percent, 100))


        lblAlat.Name = "lblAlat"

        lblAlat.Text = "Pilih Nama Alat"

        lblAlat.Dock = DockStyle.Fill

        lblAlat.TextAlign =
            ContentAlignment.MiddleLeft

        panelInput.Controls.Add(lblAlat, 0, 0)


        lblJumlah.Name = "lblJumlah"

        lblJumlah.Text = "Jumlah Unit"

        lblJumlah.Dock = DockStyle.Fill

        lblJumlah.TextAlign =
            ContentAlignment.MiddleLeft

        panelInput.Controls.Add(lblJumlah, 1, 0)


        cboAlat.Name = "cboAlat"

        cboAlat.Dock = DockStyle.Fill

        cboAlat.DropDownStyle =
            ComboBoxStyle.DropDownList

        cboAlat.Font = New Font("Segoe UI", 10)

        cboAlat.Margin = New Padding(3, 3, 15, 3)

        panelInput.Controls.Add(cboAlat, 0, 1)


        txtJumlah.Name = "txtJumlah"

        txtJumlah.Dock = DockStyle.Fill

        txtJumlah.Font = New Font("Segoe UI", 10)

        txtJumlah.Margin = New Padding(3, 3, 15, 3)

        panelInput.Controls.Add(txtJumlah, 1, 1)

        layout.Controls.Add(panelInput, 0, 1)

        Dim panelTombol As New FlowLayoutPanel()

        panelTombol.Dock = DockStyle.Fill

        panelTombol.FlowDirection =
            FlowDirection.LeftToRight

        panelTombol.WrapContents = False


        btnPinjam.Name = "btnPinjam"

        btnPinjam.Text = "PINJAM"

        btnPinjam.Size = New Size(130, 38)

        btnPinjam.BackColor = Color.SeaGreen

        btnPinjam.ForeColor = Color.White

        btnPinjam.FlatStyle = FlatStyle.Flat

        panelTombol.Controls.Add(btnPinjam)

        btnKembalikan.Name = "btnKembalikan"

        btnKembalikan.Text = "KEMBALIKAN"

        btnKembalikan.Size = New Size(150, 38)

        btnKembalikan.BackColor = Color.SteelBlue

        btnKembalikan.ForeColor = Color.White

        btnKembalikan.FlatStyle = FlatStyle.Flat

        panelTombol.Controls.Add(btnKembalikan)


        btnReset.Name = "btnReset"

        btnReset.Text = "RESET DATA"

        btnReset.Size = New Size(130, 38)

        btnReset.BackColor = Color.IndianRed

        btnReset.ForeColor = Color.White

        btnReset.FlatStyle = FlatStyle.Flat

        panelTombol.Controls.Add(btnReset)

        layout.Controls.Add(panelTombol, 0, 2)


        dgvAlat.Name = "dgvAlat"

        dgvAlat.Dock = DockStyle.Fill

        dgvAlat.BackgroundColor = Color.White

        dgvAlat.ReadOnly = True

        dgvAlat.AllowUserToAddRows = False

        dgvAlat.AllowUserToDeleteRows = False

        dgvAlat.AllowUserToResizeRows = False

        dgvAlat.EditMode =
            DataGridViewEditMode.EditProgrammatically

        dgvAlat.AutoGenerateColumns = False

        dgvAlat.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

        dgvAlat.MultiSelect = False

        dgvAlat.RowHeadersVisible = False

        dgvAlat.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        dgvAlat.ColumnHeadersHeight = 40

        dgvAlat.RowTemplate.Height = 35

        dgvAlat.Font = New Font("Segoe UI", 10)

        dgvAlat.Columns.Clear()

        dgvAlat.Columns.Add(
            New DataGridViewTextBoxColumn With {
                .Name = "colNama",
                .HeaderText = "Nama Alat",
                .DataPropertyName = "NamaAlat",
                .ReadOnly = True
            })


        dgvAlat.Columns.Add(
            New DataGridViewTextBoxColumn With {
                .Name = "colStokAwal",
                .HeaderText = "Stok Awal",
                .DataPropertyName = "StokAwal",
                .ReadOnly = True,
                .DefaultCellStyle =
                    New DataGridViewCellStyle With {
                        .Alignment =
                        DataGridViewContentAlignment.MiddleRight
                    }
            })


        dgvAlat.Columns.Add(
            New DataGridViewTextBoxColumn With {
                .Name = "colTersedia",
                .HeaderText = "Tersedia",
                .DataPropertyName = "Tersedia",
                .ReadOnly = True,
                .DefaultCellStyle =
                    New DataGridViewCellStyle With {
                        .Alignment =
                        DataGridViewContentAlignment.MiddleRight
                    }
            })


        dgvAlat.Columns.Add(
            New DataGridViewTextBoxColumn With {
                .Name = "colDipinjam",
                .HeaderText = "Dipinjam",
                .DataPropertyName = "Dipinjam",
                .ReadOnly = True,
                .DefaultCellStyle =
                    New DataGridViewCellStyle With {
                        .Alignment =
                        DataGridViewContentAlignment.MiddleRight
                    }
            })

        layout.Controls.Add(dgvAlat, 0, 3)


        lblTotalDipinjam.Name = "lblTotalDipinjam"

        lblTotalDipinjam.Text = "Total Dipinjam: 0 unit"

        lblTotalDipinjam.Dock = DockStyle.Fill

        lblTotalDipinjam.Font =
            New Font("Segoe UI", 12, FontStyle.Bold)

        lblTotalDipinjam.ForeColor = Color.DarkBlue

        lblTotalDipinjam.TextAlign =
            ContentAlignment.MiddleRight

        layout.Controls.Add(lblTotalDipinjam, 0, 4)

        Me.Controls.Add(layout)


        errInput.ContainerControl = Me

        errInput.BlinkStyle =
            ErrorBlinkStyle.NeverBlink


        AddHandler btnPinjam.Click,
            AddressOf btnPinjam_Click

        AddHandler btnKembalikan.Click,
            AddressOf btnKembalikan_Click

        AddHandler btnReset.Click,
            AddressOf btnReset_Click

    End Sub



    Private Sub FrmPeminjamanAlat_Load(
        sender As Object,
        e As EventArgs)

        Try


            For Each nama As String In DaftarNamaAlat

                cboAlat.Items.Add(nama)

                Dim stok As Integer = StokAwal(nama)

                Dim alat As New AlatLab With {
                    .NamaAlat = nama,
                    .StokAwal = stok,
                    .Tersedia = stok,
                    .Dipinjam = 0
                }

                daftarAlat.Add(alat)

            Next

            bsAlat.DataSource = daftarAlat

            dgvAlat.DataSource = bsAlat

            cboAlat.SelectedIndex = -1

            txtJumlah.Clear()

            HitungTotalDipinjam()

        Catch ex As Exception

            MessageBox.Show(
                "Gagal memuat data: " & ex.Message,
                "Kesalahan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub

    Private Function ValidasiInput(
        ByRef namaAlat As String,
        ByRef jumlah As Integer) As Boolean

        errInput.Clear()

        namaAlat = ""

        jumlah = 0

        Dim valid As Boolean = True

        If cboAlat.SelectedIndex = -1 Then

            errInput.SetError(
                cboAlat,
                "Silakan pilih alat terlebih dahulu.")

            valid = False

        Else

            namaAlat = cboAlat.SelectedItem.ToString()

        End If


        If Not Integer.TryParse(
            txtJumlah.Text.Trim(), jumlah) _
            OrElse jumlah <= 0 Then

            errInput.SetError(
                txtJumlah,
                "Jumlah harus berupa bilangan bulat positif.")

            valid = False

        End If

        Return valid

    End Function


    Private Function CariAlat(
        namaAlat As String) As AlatLab

        For Each alat As AlatLab In daftarAlat

            If alat.NamaAlat.Equals(
                namaAlat,
                StringComparison.OrdinalIgnoreCase) Then

                Return alat

            End If

        Next

        Return Nothing

    End Function

    Private Sub btnPinjam_Click(
        sender As Object,
        e As EventArgs)

        Try

            Dim nama As String = ""

            Dim jumlah As Integer = 0

            ' Validasi input

            If Not ValidasiInput(nama, jumlah) Then

                Return

            End If


            Dim alat As AlatLab = CariAlat(nama)

            If alat Is Nothing Then

                errInput.SetError(
                    cboAlat,
                    "Data alat tidak ditemukan.")

                Return

            End If

            If jumlah > alat.Tersedia Then

                errInput.SetError(
                    txtJumlah,
                    "Stok tidak mencukupi. Tersedia: " &
                    alat.Tersedia.ToString())

                Return

            End If

            alat.Tersedia -= jumlah

            alat.Dipinjam += jumlah

            ' Memperbarui tabel

            bsAlat.ResetBindings(False)


            HitungTotalDipinjam()


            BersihkanInput()

        Catch ex As Exception

            MessageBox.Show(
                "Terjadi kesalahan saat meminjam: " &
                ex.Message,
                "Kesalahan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnKembalikan_Click(
        sender As Object,
        e As EventArgs)

        Try

            Dim nama As String = ""

            Dim jumlah As Integer = 0


            If Not ValidasiInput(nama, jumlah) Then

                Return

            End If

            Dim alat As AlatLab = CariAlat(nama)

            If alat Is Nothing Then

                errInput.SetError(
                    cboAlat,
                    "Data alat tidak ditemukan.")

                Return

            End If

            If jumlah > alat.Dipinjam Then

                errInput.SetError(
                    txtJumlah,
                    "Jumlah pengembalian melebihi alat yang dipinjam. " &
                    "Dipinjam: " & alat.Dipinjam.ToString())

                Return

            End If


            alat.Tersedia += jumlah

            alat.Dipinjam -= jumlah



            bsAlat.ResetBindings(False)


            HitungTotalDipinjam()


            BersihkanInput()

        Catch ex As Exception

            MessageBox.Show(
                "Terjadi kesalahan saat mengembalikan: " &
                ex.Message,
                "Kesalahan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub


    Private Sub HitungTotalDipinjam()

        Dim total As Integer = 0

        For Each alat As AlatLab In daftarAlat

            total += alat.Dipinjam

        Next

        lblTotalDipinjam.Text =
            "Total Dipinjam: " & total.ToString() & " unit"

    End Sub


    Private Sub BersihkanInput()

        cboAlat.SelectedIndex = -1

        txtJumlah.Clear()

        errInput.Clear()

    End Sub


    Private Sub btnReset_Click(
        sender As Object,
        e As EventArgs)

        Dim konfirmasi As DialogResult

        konfirmasi = MessageBox.Show(
            "Apakah Anda yakin ingin mengembalikan " &
            "seluruh data ke kondisi awal?",
            "Konfirmasi Reset Data",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)


        If konfirmasi = DialogResult.No Then

            Return

        End If

        Try

            For Each alat As AlatLab In daftarAlat

                alat.Tersedia = alat.StokAwal

                alat.Dipinjam = 0

            Next


            bsAlat.ResetBindings(False)

            BersihkanInput()


            HitungTotalDipinjam()

            MessageBox.Show(
                "Data berhasil dikembalikan ke kondisi awal.",
                "Reset Berhasil",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show(
                "Terjadi kesalahan saat reset: " &
                ex.Message,
                "Kesalahan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub

End Class
