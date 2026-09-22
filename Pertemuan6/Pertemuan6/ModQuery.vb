Imports System.Data
Module ModQuery
    Public Function TambahData(
        nim As String,
        nama As String,
        jurusan As String
    ) As Boolean
        Dim query As String =
            "INSERT INTO mahasiswa (nim, nama, jurusan) " &
            "VALUES (@nim, @nama, @jurusan)"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@nim", nim},
            {"@nama", nama},
            {"@jurusan", jurusan}
        }
        Return ModFunction.EksekusiData(query, parameters)
    End Function

    Public Function TampilkanData() As DataTable
        Return ModFunction.AmbilData(
            "SELECT * FROM mahasiswa ORDER BY id ASC"
        )
    End Function

End Module