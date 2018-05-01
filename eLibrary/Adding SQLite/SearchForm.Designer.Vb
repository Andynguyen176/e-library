<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchForm))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckOutBtn = New System.Windows.Forms.Button()
        Me.LogOutBtn = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ResID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BookTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AuthorFirst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ALast = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PublicationDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CheckOutPeriod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Genre1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Availability30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TestRandBtn = New System.Windows.Forms.Button()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.SearchTxt = New System.Windows.Forms.TextBox()
        Me.AccountOverViewBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(163, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(312, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "(By Title, Author, Genre, Publication Date, or Series)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.Black
        Me.ClearBtn.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.Color.Gold
        Me.ClearBtn.Location = New System.Drawing.Point(6, 209)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(120, 35)
        Me.ClearBtn.TabIndex = 24
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(278, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(458, 45)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "eLibrary of Wonders Search Page"
        '
        'CheckOutBtn
        '
        Me.CheckOutBtn.BackColor = System.Drawing.Color.Black
        Me.CheckOutBtn.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckOutBtn.ForeColor = System.Drawing.Color.Gold
        Me.CheckOutBtn.Location = New System.Drawing.Point(953, 102)
        Me.CheckOutBtn.Name = "CheckOutBtn"
        Me.CheckOutBtn.Size = New System.Drawing.Size(120, 43)
        Me.CheckOutBtn.TabIndex = 22
        Me.CheckOutBtn.Text = "Check-Out"
        Me.CheckOutBtn.UseVisualStyleBackColor = False
        '
        'LogOutBtn
        '
        Me.LogOutBtn.Location = New System.Drawing.Point(968, 19)
        Me.LogOutBtn.Name = "LogOutBtn"
        Me.LogOutBtn.Size = New System.Drawing.Size(105, 51)
        Me.LogOutBtn.TabIndex = 21
        Me.LogOutBtn.Text = "Log Out"
        Me.LogOutBtn.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ResID, Me.BookTitle, Me.AuthorFirst, Me.ALast, Me.PublicationDate, Me.CheckOutPeriod, Me.Genre1, Me.Availability30})
        Me.ListView1.ForeColor = System.Drawing.Color.Black
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(133, 177)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(954, 439)
        Me.ListView1.TabIndex = 20
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ResID
        '
        Me.ResID.Text = "Resource ID"
        Me.ResID.Width = 90
        '
        'BookTitle
        '
        Me.BookTitle.Text = "Book Title"
        Me.BookTitle.Width = 236
        '
        'AuthorFirst
        '
        Me.AuthorFirst.Text = "Author's First Name"
        Me.AuthorFirst.Width = 106
        '
        'ALast
        '
        Me.ALast.Text = "Author's Last Name"
        Me.ALast.Width = 108
        '
        'PublicationDate
        '
        Me.PublicationDate.Text = "Publication Date"
        Me.PublicationDate.Width = 105
        '
        'CheckOutPeriod
        '
        Me.CheckOutPeriod.Text = "Check-Out Period"
        Me.CheckOutPeriod.Width = 96
        '
        'Genre1
        '
        Me.Genre1.Text = "Genre"
        Me.Genre1.Width = 98
        '
        'Availability30
        '
        Me.Availability30.Text = "Availability"
        Me.Availability30.Width = 92
        '
        'TestRandBtn
        '
        Me.TestRandBtn.Location = New System.Drawing.Point(-95, -22)
        Me.TestRandBtn.Name = "TestRandBtn"
        Me.TestRandBtn.Size = New System.Drawing.Size(138, 23)
        Me.TestRandBtn.TabIndex = 19
        Me.TestRandBtn.Text = "Test Random Number"
        Me.TestRandBtn.UseVisualStyleBackColor = True
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.Black
        Me.SearchBtn.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.ForeColor = System.Drawing.Color.Gold
        Me.SearchBtn.Location = New System.Drawing.Point(626, 94)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(88, 46)
        Me.SearchBtn.TabIndex = 18
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'SearchTxt
        '
        Me.SearchTxt.Location = New System.Drawing.Point(166, 110)
        Me.SearchTxt.Multiline = True
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.Size = New System.Drawing.Size(440, 25)
        Me.SearchTxt.TabIndex = 17
        '
        'AccountOverViewBtn
        '
        Me.AccountOverViewBtn.BackColor = System.Drawing.Color.Black
        Me.AccountOverViewBtn.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountOverViewBtn.ForeColor = System.Drawing.Color.Gold
        Me.AccountOverViewBtn.Location = New System.Drawing.Point(7, 266)
        Me.AccountOverViewBtn.Name = "AccountOverViewBtn"
        Me.AccountOverViewBtn.Size = New System.Drawing.Size(120, 60)
        Me.AccountOverViewBtn.TabIndex = 27
        Me.AccountOverViewBtn.Text = "Account OverView"
        Me.AccountOverViewBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 25)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Search book:"
        '
        'SearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1117, 638)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AccountOverViewBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckOutBtn)
        Me.Controls.Add(Me.LogOutBtn)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TestRandBtn)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.SearchTxt)
        Me.Name = "SearchForm"
        Me.Text = "Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents ClearBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckOutBtn As Button
    Friend WithEvents LogOutBtn As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ResID As ColumnHeader
    Friend WithEvents BookTitle As ColumnHeader
    Friend WithEvents AuthorFirst As ColumnHeader
    Friend WithEvents ALast As ColumnHeader
    Friend WithEvents PublicationDate As ColumnHeader
    Friend WithEvents CheckOutPeriod As ColumnHeader
    Friend WithEvents TestRandBtn As Button
    Friend WithEvents SearchBtn As Button
    Friend WithEvents SearchTxt As TextBox
    Friend WithEvents AccountOverViewBtn As Button
    Friend WithEvents Genre1 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Availability30 As ColumnHeader
End Class
