<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccountOverview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountOverview))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txtresourceID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtBookTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtAuthorLast = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtCheckOutPeriod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtGenre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtReturnDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RenewBTN = New System.Windows.Forms.Button()
        Me.ReturnBTN = New System.Windows.Forms.Button()
        Me.LogOut1BTN = New System.Windows.Forms.Button()
        Me.Search1BTN = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ViewBTN = New System.Windows.Forms.Button()
        Me.CLEARBTNV2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.txtresourceID, Me.txtBookTitle, Me.txtAuthorLast, Me.txtCheckOutPeriod, Me.txtGenre, Me.txtReturnDate})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(144, 83)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(846, 420)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'txtresourceID
        '
        Me.txtresourceID.Text = "Resource ID"
        Me.txtresourceID.Width = 140
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Text = "Book Title"
        Me.txtBookTitle.Width = 234
        '
        'txtAuthorLast
        '
        Me.txtAuthorLast.Text = "Author Last Name"
        Me.txtAuthorLast.Width = 148
        '
        'txtCheckOutPeriod
        '
        Me.txtCheckOutPeriod.DisplayIndex = 4
        Me.txtCheckOutPeriod.Text = "Check Out Date"
        Me.txtCheckOutPeriod.Width = 97
        '
        'txtGenre
        '
        Me.txtGenre.DisplayIndex = 3
        Me.txtGenre.Text = "Genre"
        Me.txtGenre.Width = 122
        '
        'txtReturnDate
        '
        Me.txtReturnDate.Text = "Return Date"
        Me.txtReturnDate.Width = 102
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Account Overview"
        '
        'RenewBTN
        '
        Me.RenewBTN.BackColor = System.Drawing.Color.Black
        Me.RenewBTN.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RenewBTN.ForeColor = System.Drawing.Color.Gold
        Me.RenewBTN.Location = New System.Drawing.Point(20, 367)
        Me.RenewBTN.Name = "RenewBTN"
        Me.RenewBTN.Size = New System.Drawing.Size(107, 52)
        Me.RenewBTN.TabIndex = 2
        Me.RenewBTN.Text = "Renew"
        Me.RenewBTN.UseVisualStyleBackColor = False
        '
        'ReturnBTN
        '
        Me.ReturnBTN.BackColor = System.Drawing.Color.Black
        Me.ReturnBTN.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnBTN.ForeColor = System.Drawing.Color.Gold
        Me.ReturnBTN.Location = New System.Drawing.Point(20, 449)
        Me.ReturnBTN.Name = "ReturnBTN"
        Me.ReturnBTN.Size = New System.Drawing.Size(107, 54)
        Me.ReturnBTN.TabIndex = 3
        Me.ReturnBTN.Text = "Return"
        Me.ReturnBTN.UseVisualStyleBackColor = False
        '
        'LogOut1BTN
        '
        Me.LogOut1BTN.Location = New System.Drawing.Point(901, 5)
        Me.LogOut1BTN.Name = "LogOut1BTN"
        Me.LogOut1BTN.Size = New System.Drawing.Size(89, 51)
        Me.LogOut1BTN.TabIndex = 4
        Me.LogOut1BTN.Text = "Log Out"
        Me.LogOut1BTN.UseVisualStyleBackColor = True
        '
        'Search1BTN
        '
        Me.Search1BTN.BackColor = System.Drawing.Color.Black
        Me.Search1BTN.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search1BTN.ForeColor = System.Drawing.Color.Gold
        Me.Search1BTN.Location = New System.Drawing.Point(774, 5)
        Me.Search1BTN.Name = "Search1BTN"
        Me.Search1BTN.Size = New System.Drawing.Size(107, 52)
        Me.Search1BTN.TabIndex = 5
        Me.Search1BTN.Text = "Search"
        Me.Search1BTN.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(9, 422)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "(Option to Renew Book)"
        '
        'ViewBTN
        '
        Me.ViewBTN.BackColor = System.Drawing.Color.Black
        Me.ViewBTN.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewBTN.ForeColor = System.Drawing.Color.Gold
        Me.ViewBTN.Location = New System.Drawing.Point(13, 83)
        Me.ViewBTN.Name = "ViewBTN"
        Me.ViewBTN.Size = New System.Drawing.Size(107, 69)
        Me.ViewBTN.TabIndex = 8
        Me.ViewBTN.Text = "View Books"
        Me.ViewBTN.UseVisualStyleBackColor = False
        '
        'CLEARBTNV2
        '
        Me.CLEARBTNV2.BackColor = System.Drawing.Color.Black
        Me.CLEARBTNV2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLEARBTNV2.ForeColor = System.Drawing.Color.Gold
        Me.CLEARBTNV2.Location = New System.Drawing.Point(13, 208)
        Me.CLEARBTNV2.Name = "CLEARBTNV2"
        Me.CLEARBTNV2.Size = New System.Drawing.Size(106, 36)
        Me.CLEARBTNV2.TabIndex = 9
        Me.CLEARBTNV2.Text = "CLEAR"
        Me.CLEARBTNV2.UseVisualStyleBackColor = False
        '
        'AccountOverview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1002, 523)
        Me.Controls.Add(Me.CLEARBTNV2)
        Me.Controls.Add(Me.ViewBTN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Search1BTN)
        Me.Controls.Add(Me.LogOut1BTN)
        Me.Controls.Add(Me.ReturnBTN)
        Me.Controls.Add(Me.RenewBTN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "AccountOverview"
        Me.Text = "Account Overview Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBookTitle As ColumnHeader
    Friend WithEvents txtAuthorLast As ColumnHeader
    Friend WithEvents txtGenre As ColumnHeader
    Friend WithEvents RenewBTN As Button
    Friend WithEvents ReturnBTN As Button
    Friend WithEvents LogOut1BTN As Button
    Friend WithEvents Search1BTN As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCheckOutPeriod As ColumnHeader
    Friend WithEvents ViewBTN As Button
    Friend WithEvents txtReturnDate As ColumnHeader
    Friend WithEvents CLEARBTNV2 As Button
    Friend WithEvents txtresourceID As ColumnHeader
End Class
