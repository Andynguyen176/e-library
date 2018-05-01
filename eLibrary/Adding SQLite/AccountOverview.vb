Imports System.Data.SQLite
Public Class AccountOverview
    Dim isValid As Boolean = False
    Dim connectionString As String = "Data Source = ELibrary.db"
    Dim conn As New SQLiteConnection(connectionString)
    Dim memberBookID As String = LoginForm.memberID

    Private Sub Search1BTN_Click(sender As Object, e As EventArgs) Handles Search1BTN.Click
        Me.Hide()
        SearchForm.Show()
    End Sub

    Private Sub LogOut1BTN_Click(sender As Object, e As EventArgs) Handles LogOut1BTN.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub ViewBTN_Click(sender As Object, e As EventArgs) Handles ViewBTN.Click
        Dim txtResourceID1 As String
        Dim txtTitle1 As String
        Dim txtLast1 As String
        Dim txtGenre1 As String
        Dim txtCheckOutPeriod1 As String
        Dim txtCheckOutDate1 As String
        Dim txtReturnDate1 As Date
        Dim txtNewDate1 As Date


        ListView1.Items.Clear()

        'Search book to see which one is currently checked out based on return date and memberID
        Dim ShowBookQuery As String = "SELECT Resources.ResourceID, Resources.Title, Resources.AuthorLast, Resources.Subject_1, CheckOut.CheckOutDate
        FROM Resources  
        INNER JOIN CheckOut
        ON CheckOut.ResourceID = Resources.ResourceID
        WHERE CheckOut.ReturnDate is NULL 
        AND CheckOut.MemberID = '" & memberBookID & "'"

        'open the connection to database 
        conn.Open()

        'declare new sqlite command with the current query and connection 
        Dim SQLcmd As New SQLiteCommand(ShowBookQuery, conn)

        'declare sqlite data reader 
        Dim SQLreader As SQLiteDataReader = SQLcmd.ExecuteReader(CommandBehavior.Default)
        Dim i As ListViewItem
        Dim BookAvail As Boolean = False

        'looping sqlreader through all matching records 
        Do While SQLreader.Read()
            BookAvail = True

            'Convert fields from SQL database to strings
            txtResourceID1 = SQLreader("ResourceID").ToString()
            txtTitle1 = SQLreader("Title").ToString()
            txtLast1 = SQLreader("AuthorLast").ToString()
            txtGenre1 = SQLreader("Subject_1").ToString()
            txtCheckOutDate1 = SQLreader("CheckOutDate").ToString()

            txtNewDate1 = Date.ParseExact(txtCheckOutDate1, "M/dd/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)

            'New SQL command to read the checkoutperiod based on users resource ID
            Dim SQLcmd3 As New SQLiteCommand("SELECT Checkoutperiod FROM Resources 
            WHERE ResourceID = '" & txtresourceID1 & "'", conn)


            'Read checkoutperiod from database
            Dim SQLreader1 As SQLiteDataReader = SQLcmd3.ExecuteReader(CommandBehavior.Default)
            SQLreader1.Read()
            txtCheckOutPeriod1 = sqlreader1("CheckOutPeriod").ToString()

            txtReturnDate1 = txtNewDate1.AddDays(txtCheckOutPeriod1)

            'display data from converted strings on listview 
            i = ListView1.Items.Add(txtresourceID1)
            i.SubItems.Add(txtTitle1)
            i.SubItems.Add(txtLast1)
            i.SubItems.Add(txtCheckOutDate1)
            i.SubItems.Add(txtGenre1)
            i.SubItems.Add(txtReturnDate1)

            sqlreader1.Close()
        Loop

        If BookAvail = False Then
            MessageBox.Show("There is currently no books checked out. Please go back to the search page and checkout a book of your choice.")
        End If

        SQLreader.Close()
        conn.Close()

    End Sub

    Private Sub RenewBTN_Click(sender As Object, e As EventArgs) Handles RenewBTN.Click
        Try
            Dim ResourceID2 As String
            Dim CheckoutID2 As String
            Dim Availability2 As String
            Dim BookTitle2 As String
            Dim ReturnDate2 As String
            Dim Checkout2 As String
            Dim UniqueID2 As Boolean = False
            Dim Random2 As New Random

            'Set checkoutdate2 to todays date
            Dim checkoutdate2 As Date = CStr(Today.Date.ToString("d"))

            'Opens connection to database
            conn.Open()

            If ListView1.SelectedItems.Count > 0 Then
                ResourceID2 = ListView1.SelectedItems(0).Text
                BookTitle2 = ListView1.SelectedItems(0).SubItems(1).Text
                Availability2 = ListView1.SelectedItems(0).SubItems(4).Text

                'New SQL command to locate where ResourceID is selected with a NULL returndate 
                Dim locatecheckoutid As New SQLiteCommand("SELECT CheckOutID FROM CheckOut
                WHERE ResourceID = '" & resourceID2 & "' 
                AND ReturnDate is NULL", conn)

                'Reads data from database
                Dim sqlreader2 As SQLiteDataReader = locatecheckoutid.ExecuteReader()
                locatecheckoutid.Dispose()
                sqlreader2.Read()
                checkoutID2 = sqlreader2("CheckOutID").ToString()

                'Closes SQL reader
                sqlreader2.Close()

                'Update Elibrary with checkoutdate to TODAY
                Dim RenewButton As New SQLiteCommand("UPDATE Checkout 
                SET CheckOutDate = '" & checkoutdate2 & "' 
                WHERE CheckOutID = '" & checkoutID2 & "'", conn)

                RenewButton.ExecuteNonQuery()
                RenewButton.Dispose()

                'Command searches for checkoutperiod in the database
                Dim CheckOutPeriodCMD As New SQLiteCommand("SELECT CheckOutPeriod 
                FROM Resources 
                WHERE ResourceID = '" & resourceID2 & "'", conn)

                'Open SQLreader to read the CheckOutPeriod
                Dim sqlreader3 As SQLiteDataReader = CheckOutPeriodCMD.ExecuteReader(CommandBehavior.Default)
                sqlreader3.Read()

                Checkout2 = sqlreader3("CheckOutPeriod").ToString()
                ReturnDate2 = checkoutdate2.AddDays(checkout2)
                sqlreader3.Close()

                MessageBox.Show("Book has been successfully renewed.")

            Else
                MessageBox.Show("No selected field. Select a book to renew.")
            End If

            'Close connection to database
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Looks like something went wrong. Please try again.")
        End Try

    End Sub

    Private Sub ReturnBTN_Click(sender As Object, e As EventArgs) Handles ReturnBTN.Click
        Try
            Dim ResourceID3 As String
            Dim CheckoutID3 As String
            Dim BookTitle3 As String

            'Set string to todays date
            Dim ReturnDate3 As String = CStr(Today.Date.ToString("d"))

            'Opens connection to SQL 
            conn.Open()

            If ListView1.SelectedItems.Count > 0 Then
                ResourceID3 = ListView1.SelectedItems(0).Text
                BookTitle3 = ListView1.SelectedItems(0).SubItems(1).Text

                'New SQLCommand where it searches for resourceID with a NULL return date 
                Dim locatecheckoutid3 As New SQLiteCommand("SELECT CheckOutID FROM CheckOut
                WHERE ResourceID = '" & resourceid3 & "' 
                AND ReturnDate is NULL", conn)

                'Find SQLreader to pull checkoutID
                Dim SQLreader4 As SQLiteDataReader = locatecheckoutid3.ExecuteReader()
                SQLreader4.Read()
                checkoutid3 = SQLreader4("CheckoutID").ToString()

                locatecheckoutid3.Dispose()

                'Close SQL reader 
                SQLreader4.Close()

                'Return command where returnDate is set to today based on the checkoutID
                Dim CheckOutPeriod2 As New SQLiteCommand("UPDATE CheckOut 
                SET returnDate = '" & ReturnDate3 & "'
                WHERE checkoutID = '" & CheckoutID3 & "'", conn)

                CheckOutPeriod2.ExecuteNonQuery()
                CheckOutPeriod2.Dispose()

                MessageBox.Show("" & booktitle3 & " has been successfully returned in our eLibrary.")
                conn.Close()
            Else
                MessageBox.Show("No selected book. Please select one to return.")
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Something happened please try again. ")
        End Try
    End Sub

    Private Sub CLEARBTNV2_Click(sender As Object, e As EventArgs) Handles CLEARBTNV2.Click
        'Clears list of books
        ListView1.Items.Clear()
    End Sub


End Class

