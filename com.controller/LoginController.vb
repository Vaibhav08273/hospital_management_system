Public Class LoginController
    Public Function loginController(username As String, password As String) As Boolean
        Dim res As Boolean = New loginService().loginService(username, password)
        Return res
    End Function
End Class
