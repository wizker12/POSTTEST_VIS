Imports MySqlConnector

Module DataModule

    Public Function GetAllData() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM tbtrainer"

        Using conn = GetConnection()
            Using da As New MySqlDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function

    Public Function InsertData(id As String, nama As String, region As String, kontak As String, hobi As String, peran As String, foto As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbtrainer VALUES (@id,@nama,@region,@kontak,@hobi,@peran,@foto)"

            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@region", region)
                    cmd.Parameters.AddWithValue("@kontak", kontak)
                    cmd.Parameters.AddWithValue("@hobi", hobi)
                    cmd.Parameters.AddWithValue("@peran", peran)
                    cmd.Parameters.AddWithValue("@foto", foto)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UpdateData(id As String, nama As String, region As String, kontak As String, hobi As String, peran As String, foto As String) As Boolean
        Try
            Dim query As String = "UPDATE tbtrainer SET nama=@nama, region=@region, kontak=@kontak, hobi=@hobi, peran=@peran, foto=@foto WHERE id=@id"

            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@region", region)
                    cmd.Parameters.AddWithValue("@kontak", kontak)
                    cmd.Parameters.AddWithValue("@hobi", hobi)
                    cmd.Parameters.AddWithValue("@peran", peran)
                    cmd.Parameters.AddWithValue("@foto", foto)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal update: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function DeleteData(id As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbtrainer WHERE id=@id"

            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal hapus: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function SearchData(keyword As String) As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM tbtrainer 
    WHERE id LIKE @key 
    OR nama LIKE @key 
    OR region LIKE @key 
    OR kontak LIKE @key 
    OR hobi LIKE @key 
    OR peran LIKE @key"

        Using conn = GetConnection()
            Using da As New MySqlConnector.MySqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function

End Module