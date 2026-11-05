Module ModInventaris

    Public DaftarNamaAlat As String() = {
        "Multimeter",
        "Solder",
        "Obeng",
        "Tang"
    }

    Public Function StokAwal(namaAlat As String) As Integer

        Select Case namaAlat

            Case "Multimeter"
                Return 10

            Case "Solder"
                Return 8

            Case "Obeng"
                Return 15

            Case "Tang"
                Return 12

            Case Else
                Return 0

        End Select

    End Function

End Module