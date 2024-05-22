Imports MySql.Data.MySqlClient

Public Class LoginDao
    Public Function loginDao(username As String, password As String) As Boolean
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim q As String = "select * from admin_creds where id =" + username
        con = New DBConnection().getConnection()
        cmd = New MySqlCommand(q, con)
        dr = cmd.ExecuteReader()

        If (dr.Read) Then
            Return True
        End If
        Return False
    End Function
End Class
