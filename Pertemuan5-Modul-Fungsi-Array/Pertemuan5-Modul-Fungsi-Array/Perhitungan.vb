Module Perhitungan
    Public Sub tampilkanPesan(nama As String)
        MessageBox.Show("Halo, " & nama)
    End Sub

    Public Function hitung(panjang As Integer, lebar As Integer) As Integer
        If panjang > 20 Then
            Return panjang * lebar
        Else
            Return 2 * (panjang + lebar)
        End If
    End Function

    Public nilai() As Integer = {70, 80, 90, 100}

    Public nilai2D(,) As Integer = {
        {80, 85, 82},
        {70, 72, 78},
        {90, 92, 95}
     }
End Module