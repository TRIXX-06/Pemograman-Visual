Imports Microsoft.Extensions.Configuration
Imports Npgsql

Module ModDatabase
    Public Function GetConnectionString() As String
        Dim config As IConfiguration =
            New ConfigurationBuilder() _
            .SetBasePath(AppContext.BaseDirectory) _
            .AddJsonFile("appsettings.json", optional:=False, reloadOnChange:=True) _
            .Build()

        Return config.GetConnectionString("DefaultConnection")
    End Function
    Public Sub DatabaseKoneksi()
        Try
            Using conn As New NpgsqlConnection(GetConnectionString)
                conn.Open()

                MessageBox.Show("Koneksi database berhasil")
            End Using
        Catch ex As Exception
            MessageBox.Show("Koneksi database gagal" & vbCrLf & ex.Message & "database")
        End Try
    End Sub
End Module