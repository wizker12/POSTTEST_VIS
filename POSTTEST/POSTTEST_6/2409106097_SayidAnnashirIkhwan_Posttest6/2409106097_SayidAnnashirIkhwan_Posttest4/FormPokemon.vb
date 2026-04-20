Imports MySqlConnector

Public Class FormPokemon

    Sub TampilPokemon()
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM pokemon_terpilih"

        Using conn = GetConnection2()
            conn.Open()
            Using da As New MySqlDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        End Using

        dgvData.DataSource = dt

        If dgvData.Columns.Contains("id") Then
            dgvData.Columns("id").Visible = False
        End If
    End Sub

    Private Sub FormPokemon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilPokemon()
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.MultiSelect = False
        dgvData.ReadOnly = False
        dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub txtSearchPokemon_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPokemon.TextChanged
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM pokemon_terpilih WHERE nama_pengguna LIKE @key OR nama_pokemon LIKE @key"

        Using conn = GetConnection2()
            conn.Open()
            Using da As New MySqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@key", "%" & txtSearchPokemon.Text & "%")
                da.Fill(dt)
            End Using
        End Using

        dgvData.DataSource = dt
    End Sub

    Private Sub btnHapusPokemon_Click(sender As Object, e As EventArgs) Handles btnHapusPokemon.Click
        If dgvData.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih data dulu")
            Exit Sub
        End If

        Dim id As String = dgvData.CurrentRow.Cells("id").Value.ToString()
        Dim query As String = "DELETE FROM pokemon_terpilih WHERE id=@id"

        Using conn = GetConnection2()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Data berhasil dihapus")
        TampilPokemon()
    End Sub

    Private Sub btnUbahPokemon_Click(sender As Object, e As EventArgs) Handles btnUbahPokemon.Click
        If dgvData.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih data dulu")
            Exit Sub
        End If

        Dim id As String = dgvData.CurrentRow.Cells("id").Value.ToString()
        Dim nama As String = dgvData.CurrentRow.Cells("nama_pengguna").Value.ToString()
        Dim pokemon As String = dgvData.CurrentRow.Cells("nama_pokemon").Value.ToString()

        Dim query As String = "UPDATE pokemon_terpilih SET nama_pengguna=@nama, nama_pokemon=@pokemon WHERE id=@id"

        Using conn = GetConnection2()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@pokemon", pokemon)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Data berhasil diupdate")
        TampilPokemon()
    End Sub

End Class