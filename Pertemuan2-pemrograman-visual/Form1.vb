Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNAMA.Click

    End Sub

    Private Sub lblNIM_Click(sender As Object, e As EventArgs) Handles lblNIM.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTAMPILKAN.Click
        MessageBox.Show("Halo Dunia !" & vbCrLf &
                        "Nama    : " & txtNAMA.Text & vbCrLf &
                        "NIM     : " & txtNIM.Text & vbCrLf &
                        "KOM     : " & txtKOM.Text
        )
    End Sub

    Private Sub txtNAMA_TextChanged(sender As Object, e As EventArgs) Handles txtNAMA.TextChanged

    End Sub

    Private Sub btnHAPUS_Click(sender As Object, e As EventArgs) Handles btnHAPUS.Click
        txtNAMA.Clear()
        txtNIM.Clear()
        txtKOM.Clear()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKELUAR.Click
        Me.Close()
    End Sub
End Class
