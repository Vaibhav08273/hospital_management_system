Public Class loginService
    Public Function loginService(username As String, password As String) As Boolean
        Dim res As Boolean = New LoginDao().loginDao(username, password)
        Return res
    End Function
End Class
