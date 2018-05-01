Imports System.Data.SQLite
Public Class SearchForm
    Dim isValid As Boolean = False
    Dim connectionString As String = "Data Source = ELibrary.db"
    Dim conn As New SQLiteConnection(connectionString)
    Dim strSearch As String

    Private Sub SearchCheck()
        strSearch = SearchTxt.Text
        'CHECK BOOK NAME TITLE AND AUTHOR LAST NAME    
        If strSearch = Nothing Then               'Ensures there is no blank search field.                  
            isValid = False
        Else
            isValid = True
        End If
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Dim txtID As String
        Dim txtTitle As String
        Dim txtLast As String
        Dim txtFirst As String
        Dim txtPublication As String
        Dim txtCheckOut As String
        Dim txtGenre As String
        Dim txtAvailablity As String

        SearchCheck()

        If isValid = True Then

            'clear the list of any data before searching database
            ListView1.Items.Clear()

            'search database by title and author last name and return any data with title, author first, author last, resourceid, publication date, return date, checkout date
            Dim FindBookQuery As String = "SELECT ResourceID, Title, AuthorFirst, AuthorLast, PublicationDate, Series, Subject_1, CheckoutPeriod 
            FROM Resources  
            WHERE Title  LIKE'%" & SearchTxt.Text & "%' 
            OR AuthorLast LIKE '%" & SearchTxt.Text & "%' 
            OR Subject_1 LIKE'%" & SearchTxt.Text & "%'
            OR Series LIKE'%" & SearchTxt.Text & "%'
            OR PublicationDate LIKE'%" & SearchTxt.Text & "%'"

            'open the connection to database 
            conn.Open()

            'declare new sqlite command with the current query and connection 
            Dim SQLcmd As New SQLiteCommand(FindBookQuery, conn)

            'declare sqlite data reader 
            Dim SQLreader As SQLiteDataReader = SQLcmd.ExecuteReader(CommandBehavior.Default)
            Dim i As ListViewItem
            Dim BookFound As Boolean = True

            'looping sqlreader through all matching records 
            Do While SQLreader.Read()
                'Checks if books are within the database
                BookFound = False

                'convert whatever the reader finds from search into string 
                txtID = SQLreader("ResourceID").ToString()
                txtTitle = SQLreader("Title").ToString()
                txtLast = SQLreader("AuthorLast").ToString()
                txtFirst = SQLreader("AuthorFirst").ToString()
                txtPublication = SQLreader("PublicationDate").ToString()
                txtCheckOut = SQLreader("CheckOutPeriod").ToString()
                txtGenre = SQLreader("Subject_1").ToString()

                'will find the book based on resourceid and returndate 
                Dim IsBookAvailable As New SQLiteCommand("Select * FROM Checkout 
                WHERE (ResourceID ='" & txtID & "' AND ReturnDate IS NULL)", conn)

                'Reads information pulled
                Dim sqlreader2 As SQLiteDataReader = IsBookAvailable.ExecuteReader()

                If sqlreader2.Read() = True Then
                    txtAvailablity = "Unavailable"
                Else
                    txtAvailablity = "Available"
                End If

                'display data from converted strings on listview 
                i = ListView1.Items.Add(txtID)
                i.SubItems.Add(txtTitle)
                i.SubItems.Add(txtFirst)
                i.SubItems.Add(txtLast)
                i.SubItems.Add(txtPublication)
                i.SubItems.Add(txtCheckOut)
                i.SubItems.Add(txtGenre)
                i.SubItems.Add(txtAvailablity)

            Loop
            'Close SQLreader and connection to database
            SQLreader.Close()
            conn.Close()

            'Will display a message that the book is not in the database.
            If BookFound = True Then
                MessageBox.Show("Search does not match with criteria. Please try again.")
            End If

        ElseIf isValid = False Then
            MessageBox.Show("Please enter a book name or author's last name.")
        End If
    End Sub

    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        'Takes users back to the login page 
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        'Clears the search button and grid
        SearchTxt.Clear()
        ListView1.Items.Clear()
    End Sub

    Private Sub CheckOutBtn_Click(sender As Object, e As EventArgs) Handles CheckOutBtn.Click
        'declare variables 
        Dim resourceID As String

        'declare a local variable to hold the Public memberID declared on the Login Form
        Dim LocalMemID As String = LoginForm.memberID

        'checkoutID will be given a random number because we don't have an autonumber with SQLite
        Dim rand As New Random
        Dim checkoutID As String = CStr(rand.Next(0, 9999))

        'checkoutdate is the current date, converted to a string
        Dim checkoutdate As String = CStr(Today.Date.ToString("d"))

        If ListView1.SelectedItems.Count > 0 Then
            resourceID = ListView1.SelectedItems(0).Text
            conn.Open()

            'Inserts selected books into the database
            Dim sqlcmd As New SQLiteCommand("INSERT INTO Checkout (CheckoutID, ResourceID, MemberID, CheckOutDate, ReturnDate)
            VALUES ('" & checkoutID & "', '" & resourceID & "', '" & LocalMemID & "', '" & checkoutdate & "', NULL)", conn)

            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()

            MessageBox.Show("Successfully added and checked out!")
            conn.Close()
        Else
            MessageBox.Show("Please select a book.")
        End If
    End Sub

    Private Sub AccountOverViewBtn_Click(sender As Object, e As EventArgs) Handles AccountOverViewBtn.Click
        'Takes users to the account overview
        Me.Hide()
        AccountOverview.Show()
    End Sub


End Class
