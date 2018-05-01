Imports System.Data.SQLite

Public Class LoginForm
    Public sqlconn As New SQLiteConnection("Data Source = elibrary.db")

    Public Function Hasconnection() As Boolean
        Try
            'Opens connection to database
            sqlconn.Open()

            'Closes connection to database
            sqlconn.Close()
            Return True
        Catch ex As Exception
            Return False

        End Try
    End Function

    Public memberID As String
    Dim MemberName As String
    Dim MemberPassword As String

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click

        'SQL Command to pull the EMAIL from the database
        Dim sqlcmd1 As New SQLiteCommand("SELECT Email, Password, MemberID, FirstName FROM Member WHERE (Email = '" & EmailTxt.Text & "')", sqlconn)

        'Open SQL connection to database
        sqlconn.Open()
        Dim sqlreader As SQLiteDataReader = sqlcmd1.ExecuteReader()

        If sqlreader.Read() = True Then
            memberID = sqlreader("MemberID").ToString()
            MemberName = sqlreader("FirstName").ToString()
            MemberPassword = sqlreader("Password").ToString()

            'Checks if password is the same in the database
            If MemberPassword = PasswordTxt.Text Then
                Me.Hide()
                SearchForm.Show()
                MessageBox.Show("Login Successful.")
                MessageBox.Show("Welcome...." & MemberName & "-------Your MemberID is " & memberID & "--------")
            ElseIf PasswordTxt.Text = "" Then
                MessageBox.Show("Login unsuccessful. Please enter a password.")
            Else
                MessageBox.Show("Email or password is incorrect.")

            End If
        Else
            MessageBox.Show("Login unsuccessful - please enter an email.")
        End If

        sqlreader.Close()
        sqlconn.Close()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        'Clears e-mail and password
        EmailTxt.Clear()
        PasswordTxt.Clear()
    End Sub

End Class
