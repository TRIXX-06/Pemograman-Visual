Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNilaiAwal.Click

    End Sub

    Private Sub txtNilaiAwal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilaiAwal.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNilaiAkhir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilaiAkhir.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim lblNilaiAwal As Integer
        Dim lblNilaiAkhir As Integer

        If Not Integer.TryParse(txtNilaiAwal.Text, lblNilaiAwal) Then
            MessageBox.Show("Masukkan nilai dalam bentuk angka.")
            Return
        End If

        If Not Integer.TryParse(txtNilaiAkhir.Text, lblNilaiAkhir) Then
            MessageBox.Show("Masukkan nilai dalam bentuk angka.")
            Return
        End If

        lstHasil.Items.Clear()
        For i As Integer = lblNilaiAwal To lblNilaiAkhir Step 2
            lstHasil.Items.Add(i)
        Next
    End Sub
End Class
