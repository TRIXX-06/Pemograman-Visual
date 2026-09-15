Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        'MessageBox.Show("Hasil: " & hitung(Val(txtLebar.Text), Val(txtPanjang.Text)).ToString())

        'For i As Integer = 0 To nilai.Length - 1
        'lstNilai.Items.Add("Nilai ke-" & (i + 1) & ": " & nilai(i).ToString())
        'Next

        MessageBox.Show(nilai2D(0, 1).ToString())
    End Sub
End Class