Imports Npgsql
Imports System.Data
Module ModFunction

    Public Function AmbilData(query As String) As DataTable
        Dim dt As New DataTable

        Try
            Using conn As New NpgsqlConnection(ModDatabase.GetConnectionString())
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    Using adapter As New NpgsqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data" & vbCrLf & ex.Message, " database")
        End Try

        Return dt
    End Function
    Public Function EksekusiData(query As String, parameters As Dictionary(Of String, Object)) As Boolean
        Try
            Using conn As New NpgsqlConnection(ModDatabase.GetConnectionString())
                conn.Open()

                Using cmd As New NpgsqlCommand(query, conn)
                    For Each parameter In parameters
                        cmd.Parameters.AddWithValue(parameter.Key, parameter.Value)
                    Next
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(
            "Gagal mengeksekusi data:" & vbCrLf & ex.Message,
            "Error Database"
        )
            Return False
        End Try
    End Function

End Module