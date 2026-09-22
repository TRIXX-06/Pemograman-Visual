Public Class Form1
    Private Const V As Boolean = True
    Private dgvMahasiswa As Object
    Private txtNIM As Object
    Private txtNama As Object
    Private txtJurusan As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        'DatabaseKoneksi()
        dgvMahasiswa.AutoGenerateColumns = V
        dgvMahasiswa.DataSource = ModQuery.TampilkanData()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnTambah.Click
        If ModQuery.TambahData(
            txtNIM.Text,
            txtNama.Text,
            txtJurusan.Text
        ) Then
            MessageBox.Show("Data berhasil ditambahkan")
            dgvMahasiswa.DataSource = ModQuery.TampilkanData()
        Else
            MessageBox.Show("Data gagal ditambahkan")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class
