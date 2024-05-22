Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = "Login Page"
        Label2.Text = "Username"
        Label3.Text = "Password"
        Button1.Text = "Log In"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username, password As String
        username = TextBox1.Text
        password = TextBox2.Text
        Dim lc As New LoginController()
        Dim res As Boolean = lc.loginController(username, password)
        If res = True Then
            Me.Visible = False
            AdminHomepage.Visible = True
        Else
            Me.BackColor = Color.Red
        End If
    End Sub
End Class
