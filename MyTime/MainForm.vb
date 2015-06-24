
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlServerCe.SqlCeDataAdapter
Imports System.Data.SqlServerCe.SqlCeConnection

Public Class MainForm

    Private m_cn As New System.Data.SqlServerCe.SqlCeConnection
    Private m_DA As New System.Data.SqlServerCe.SqlCeDataAdapter
    Private m_CB As New System.Data.SqlServerCe.SqlCeCommandBuilder
    Private m_DataTable As New DataTable
    Private m_rowPosition As Integer = 0
    Private WithEvents m_DataGrid As New DataGridView
    Private mydataSet As DataSet

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Console.Beep()
        Me.Close()
    End Sub


    Private Sub SetupDataGridView()
        Me.Controls.Add(m_DataGrid)

        m_DataGrid.ColumnCount = 5
        With m_DataGrid.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(m_DataGrid.Font, FontStyle.Bold)
        End With

        With m_DataGrid
            .Name = "m_DataGrid"
            .Location = New Point(8, 8)
            .Size = New Size(500, 250)
            .AutoSizeRowsMode = _
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            .RowHeadersVisible = False

            .Columns(0).Name = "OrderId"
            .Columns(1).Name = "CusotmerID"
            .Columns(2).Name = "Title"
            .Columns(3).Name = "Artist"
            .Columns(4).Name = "ShipDate"
            .Columns(4).DefaultCellStyle.Font = _
                New Font(Me.m_DataGrid.DefaultCellStyle.Font, FontStyle.Italic)

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .Dock = DockStyle.Fill
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' Set some connection string properties e.g.:
        ' 
        m_cn.ConnectionString = _
            "Persist Security Info = False; Data Source = 'C:\work\thomas\db\MyWork.sdf';" & _
            "Password = '123456'; File Mode = 'shared read'; " & _
            "Max Database Size = 256; Max Buffer Size = 1024"

        m_cn.Open()

        MsgBox(m_cn.ServerVersion)

        m_DA = New SqlCeDataAdapter("SELECT * FROM Orders", m_cn)
        'System.Data.SqlServerCe.SqlCeDataAdapter(dataAdapter = New SqlCeDataAdapter(Command))

        m_DA.Fill(m_DataTable)
        m_DataGrid.DataSource = m_DataTable

        m_DataGrid.Location = New Point(41, 167)
        m_DataGrid.Size = New Size(300, 300)

        m_DataGrid.Show()

        m_cn.Close()
        m_cn.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a As New Airplane(1, "Boeing 747", 800)


        'bs.DataMember = "Passengers";
        'bs.DataSource = a;
        'bs.Add(new Passenger("Joe Shmuck"));
        'bs.Add(new Passenger("Jane Doe"));
        'bs.Add(new Passenger("John Smith"));

        'grid.DataSource = bs;
        'grid.AutoGenerateColumns = true;
        'txtModel.DataBindings.Add("Text", bs, "Name");
        'label1.Text = "Name:";
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fnameTxtBox.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        'ResultListView.Columns.Add(" ", 80, HorizontalAlignments.Left)

        Dim sqlDictionary As New Dictionary(Of String, String)
        sqlDictionary.Add("LocCodeTxtBox", "Office_Loc_code")
        sqlDictionary.Add("BldgTxtBox", "Building_Name")

        sqlDictionary.Add("CityTxtBox", "City")
        sqlDictionary.Add("ProvTxtBox", "Prov")
        sqlDictionary.Add("PostalTxtBox", "Postal_Code")
        sqlDictionary.Add("CntryTxtBox", "Country")


        'Dim resultListView As ListView
        'resultListView.GridLines = True
        ' Sort the items in the list in ascending order.
        'resultListView.Sorting = SortOrder.Ascending

        Dim resultData(,) As Object = New Object(,) {}

        'select edit
        'set the current 

        'set fields to read only.
        'Save the info to database


        ResultListView.Columns.Add(" ", 80, HorizontalAlignments.Left)
        ResultListView.Columns.Add(" ", 80, HorizontalAlignments.Left)
        ResultListView.Columns.Add(" ", 80, HorizontalAlignments.Left)

        ResultListView.Columns.Add("Item Description", 100, HorizontalAlignments.Left)
        ResultListView.Columns.Add("Qty", 80, HorizontalAlignments.Left)
        ResultListView.Columns.Add("Unit", 80, HorizontalAlignments.Left)
        ResultListView.Columns.Add("GST", 40, HorizontalAlignments.Left)
        ResultListView.Columns.Add("PST", 40, HorizontalAlignments.Left)
        ResultListView.Columns.Add("HST", 40, HorizontalAlignments.Left)
        ResultListView.Columns.Add("Item Total($)", 80, HorizontalAlignments.Left)
        ResultListView.Columns.Add("Product", 80, HorizontalAlignments.Left)
        ResultListView.Columns.Add("FRE", 80, HorizontalAlignments.Left)

        ResultListView.Columns.Add("Payment #" 80, HorizontalAlignments.Left)
        ResultListView.Columns.Add("Payment Type", 80, HorizontalAlignments.Left)
        ResultListView.Columns.Add("Amount($)", 80, HorizontalAlignments.Left)
        ResultListView.Columns.Add("Pay Date", 80, HorizontalAlignments.Left)
        ResultListView.Columns.Add("SAP Doc.#", 80, HorizontalAlignments.Left)
        ResultListView.Columns.Add("Explanation", 200, HorizontalAlignments.Left)

        ResultListView.Columns.Add("Amount($) ", 80, HorizontalAlignments.Left)
        ResultListView.Columns.Add("Client CC" 80, HorizontalAlignments.Left)
        ResultListView.Columns.Add("Client WBS", 80, HorizontalAlignments.Left)
        ResultListView.Columns.Add("Client GL", 80, HorizontalAlignments.Left)
        ResultListView.Columns.Add("Client FA", 160, HorizontalAlignments.Left)


        Dim sqlDictionary As New Dictionary(Of String, String)
        sqlDictionary.Add("LocCodeTxtBox", "Office_Loc_code")
        sqlDictionary.Add("BldgTxtBox", "Building_Name")

        sqlDictionary.Add("CityTxtBox", "City")
        sqlDictionary.Add("ProvTxtBox", "Prov")
        sqlDictionary.Add("PostalTxtBox", "Postal_Code")
        sqlDictionary.Add("CntryTxtBox", "Country")

        InvoiceDetail.actionPerformed = MiscFn.display
        InvoiceDetail.fromPage = MiscFn.SearchInvoice

        InvoiceDetail.InvNumTxtBox.Text =  
        InvoiceDetail.InvStatusTxtBox.Text =
        InvoiceDetail.CreditLockTxtBox.Text =  
        InvoiceDetail.InvDatePicker = Format()
        InvoiceDetail.DueDatePicker.Text =

        InvoiceDetail.OrgTxtBox.Text =
        InvoiceDetail.ClientCodeTxtBox.Text =
        InvoiceDetail.SAPTxtBox.Text =

        InvoiceDetail.McsFnameTxtBox.Text =
        InvoiceDetail.McsLnameTxtBox.Text =
        InvoiceDetail.CntFnameTxtBox.Text =
        InvoiceDetail.CntLnameTxtBox.Text =
        InvoiceDetail.ClntTxtBox.Text = 

        InvoiceDetail.AddrTxtBox.Text =
		InvoiceDetail.PhoneTxtBox.Text =
		InvoiceDetail.FaxTxtBox.Text =
		InvoiceDetail.CityTxtBox.Text =
		InvoiceDetail.ProvTxtBox.Text =
		InvoiceDetail.CntyTxtBox.Text =
		InvoiceDetail.PostalTxtBox.Text =

		InvoiceDetail.MgrFname.Text =
		InvoiceDetail.MgrLname.Text =
		InvoiceDetail.MgrPhone.Text =
		InvoiceDetail.RqFname.Text =
		InvoiceDetail.RqLname.Text =
		InvoiceDetail.MgrPhone.Text = 

        'use other form for other fields

        InvoiceDetail.UnameTxtBox = "xxx"
        InvoiceDetail.UnameTxtBox.ReadOnly = True

        InvoiceDetail.CommentsTxtBox = ""

		InvoiceDetail.StrtLowTxtBox.Text =
		InvoiceDetail.StrtSufLowTxtBox.Text =
		InvoiceDetail.StrtTxtBox.Text =
		InvoiceDetail.StrtFloorTxtBox.Text =
		InvoiceDetail.StrtUnitTxtBox.Text =

		InvoiceDetail.InvFrqCombo.Text =
		InvoiceDetail.TranYearCombo.Text =
		InvoiceDetail.AuthTxtBox.Text =

		InvoiceDetail.InvAmtTxtBox.Text =
		InvoiceDetail.InvCrTxtBox.Text =
		InvoiceDetail.InTotalTxtBox.Text =
		InvoiceDetail.PayAmtTxtBox.Text =
		InvoiceDetail.PayCrTxtBox.Text =
		InvoiceDetail.PayTtlTxtBox.Text =
		InvoiceDetail.BalanceTxtBox.Text =

        'Select Add
        InvoiceDetail.actionPerformed = MiscFn.add
        InvoiceDetail.fromPage = MiscFn.
        InvoiceDetail.fromControl = MiscFn.AddInvoice

        'Set the field to locked

        'Select Clone
        InvoiceDetail.actionPerformed = MiscFn.clone

        'make the fields modifiable
        'retrieves items

    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.fnameTxtBox.Text = "Type your First Name"
        Me.lnameTxtBox.Text = "Type your Last Name"

        Me.salute.Text = "Ms."



    End Sub
End Class
