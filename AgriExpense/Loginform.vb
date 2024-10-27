Imports System.Drawing.Drawing2D

Public Class Form1
    Private usernamePlaceholder As String = "Enter your username"
    Private passwordPlaceholder As String = "Enter your password"
    Private backgroundImage As Image

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            backgroundImage = Image.FromFile("C:\Users\noeme\source\repos\AgriExpense\images\bg1.jpg") ' Change to your image path
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message)
        End Try

        ' Set initial text and color for txtUsername
        txtUsername.Text = usernamePlaceholder
        txtUsername.ForeColor = Color.Gray

        ' Set initial text and color for txtPassword
        txtPassword.Text = passwordPlaceholder
        txtPassword.ForeColor = Color.Gray
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = usernamePlaceholder Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black ' Normal text color
        End If
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = usernamePlaceholder
            txtUsername.ForeColor = Color.Gray ' Placeholder text color
        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = passwordPlaceholder Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black ' Normal text color
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.Text = passwordPlaceholder
            txtPassword.ForeColor = Color.Gray ' Placeholder text color
        End If
    End Sub
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If backgroundImage IsNot Nothing Then
            e.Graphics.DrawImage(backgroundImage, 0, 0, Me.ClientSize.Width, Me.ClientSize.Height)
        End If
    End Sub
    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        If backgroundImage IsNot Nothing Then
            backgroundImage.Dispose()
        End If
        MyBase.OnFormClosed(e)
    End Sub
End Class
