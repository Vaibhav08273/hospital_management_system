Imports MySql.Data.MySqlClient

Public Class DBConnection
    Public Function getConnection() As MySqlConnection
        Dim con As New MySqlConnection()
        con.ConnectionString = "server = localhost; user = root; password = tiger ;database = hospital_mgmt_systm"
        Try
            con.Open()
            'MessageBox.Show("Connected to database.")
        Catch ex As Exception
            'MessageBox.Show("Connection to database failed.")
        End Try



        Return con

    End Function
End Class
