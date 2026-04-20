Imports MySqlConnector

Module ConnectionModule
    Public ReadOnly ConnectionString As String =
        "Server=localhost;Port=3306;Database=dbpokemon;User ID=root;Password=;"

    Public ReadOnly ConnectionString2 As String =
        "Server=localhost;Port=3306;Database=db_pokemon;User ID=root;Password=;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function

    Public Function GetConnection2() As MySqlConnection
        Return New MySqlConnection(ConnectionString2)
    End Function
End Module