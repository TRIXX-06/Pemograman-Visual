Public Class FrmPajak

    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        If String.IsNullOrWhiteSpace(txtPendapatan.Text) Then
            MessageBox.Show("Pendapatan tidak boleh kosong! Masukkan angka yang valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPendapatan.Focus()
            Return
        End If

        Dim pendapatan As Decimal
        If Not Decimal.TryParse(txtPendapatan.Text.Trim(), pendapatan) Then
            MessageBox.Show("Input harus berupa angka yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPendapatan.Focus()
            Return
        End If

        Dim persentasePajak As Decimal = 0D
        Dim statusTarif As String = "0%"

        If pendapatan > 100000000 Then
            persentasePajak = 0.3D
            statusTarif = "30%"
        ElseIf pendapatan > 30000000 Then
            persentasePajak = 0.2D
            statusTarif = "20%"
        ElseIf pendapatan > 5000000 Then
            persentasePajak = 0.1D
            statusTarif = "10%"
        Else
            persentasePajak = 0D
            statusTarif = "0%"
        End If

        Dim nominalPajak As Decimal = pendapatan * persentasePajak

        Dim formatRupiah As New Globalization.CultureInfo("id-ID")
        MessageBox.Show("Rincian Perhitungan Pajak:" & vbCrLf &
                        "Total Pendapatan : " & pendapatan.ToString("C0", formatRupiah) & vbCrLf &
                        "Tarif Pajak      : " & statusTarif & vbCrLf &
                        "Nominal Pajak    : " & nominalPajak.ToString("C0", formatRupiah),
                        "Hasil Perhitungan Pajak",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
        FrmLogin.Show()
    End Sub

End Class