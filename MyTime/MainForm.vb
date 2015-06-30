
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


        'ResultListView.Columns.Add(" ", 80, HorizontalAlignment.Left)

        'Dim resultListView As ListView
        'resultListView.GridLines = True
        ' Sort the items in the list in ascending order.
        'resultListView.Sorting = SortOrder.Ascending

        Dim resultData(,) As Object = New Object(,) {}

        'select edit
        'set the current 

        'set fields to read only.
        'Save the info to database


       


        'make the fields modifiable
        'retrieves items

    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.fnameTxtBox.Text = "Type your First Name"
        Me.lnameTxtBox.Text = "Type your Last Name"

        Me.salute.Text = "Ms."
    End Sub

   

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        'ItemDescTxtBox
        'QuantityTxtBox
        'UnitPriceTxtBox
        'UnitCombo

        'gstChkBtn
        'pstChkBtn
        'hstChkBtn
        'gstTxtBox
        'pstTxtBox
        'hstTxtBox

        'ProductCodeTxtBox
        'clientCCTxtBox
        'clientWBSTxtBox
        'clientGLTxtBox
        'clientFACombo


        'ItemTotalTxtBox
        '
        Dim fundingSourcesList As String() = {"Operating", "Capital"}
        Dim taxCodeList As String() = {"R0", "R1", "R2", "R3", "R8", "R9"}

        fundingSourcesCombo.Items.AddRange(fundingSourcesList)

        If fundingSourcesCombo.SelectedValue = fundingSourcesList(0) Then

            costCentreTxtBox.Enabled = True
            costCentreSrchBtn.Enabled = True


            wbsNoTxtBox.Enabled = False

            'get the sql
            serviceElemGroupCombo.Enabled = False
            businessUnitCombo.Enabled = False
            funcAreaCombo.Enabled = False
        Else
            costCentreTxtBox.Enabled = False
            costCentreSrchBtn.Enabled = False
            wbsNoTxtBox.Enabled = True

            'get the sql
            serviceElemGroupCombo.Enabled = True
            businessUnitCombo.Enabled = True
            funcAreaCombo.Enabled = True
        End If

        'mainGLTxtBox
        'subGLTxtBox
        'recoveryBasisCombo  'dropdown
        'costRecoveryTxtBox

        'Save 

        'Save and Continue
        '


        Dim sqlDictionary As New Dictionary(Of String, String)

        '-----------------------------
        sqlDictionary.Add("LocCodeTxtBox", "Office_Loc_code")
        sqlDictionary.Add("BldgTxtBox", "Building_Name")

        sqlDictionary.Add("CityTxtBox", "City")
        sqlDictionary.Add("ProvTxtBox", "Prov")
        sqlDictionary.Add("PostalTxtBox", "Postal_Code")
        sqlDictionary.Add("CntryTxtBox", "Country")

        resultListView.Columns.Add(" ", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add(" ", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add(" ", 80, HorizontalAlignment.Left)

        resultListView.Columns.Add("Item Description", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("Qty", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Unit", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("GST", 40, HorizontalAlignment.Left)
        resultListView.Columns.Add("PST", 40, HorizontalAlignment.Left)
        resultListView.Columns.Add("HST", 40, HorizontalAlignment.Left)
        resultListView.Columns.Add("Item Total($)", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Product", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("FRE", 80, HorizontalAlignment.Left)

        resultListView.Columns.Add("Payment #", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Payment Type", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Amount($)", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Pay Date", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("SAP Doc.#", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Explanation", 200, HorizontalAlignment.Left)

        resultListView.Columns.Add("Amount($) ", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Client CC", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Client WBS", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Client GL", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Client FA", 160, HorizontalAlignment.Left)


        sqlDictionary.Add("LocCodeTxtBox", "Office_Loc_code")
        sqlDictionary.Add("BldgTxtBox", "Building_Name")

        sqlDictionary.Add("CityTxtBox", "City")
        sqlDictionary.Add("ProvTxtBox", "Prov")
        sqlDictionary.Add("PostalTxtBox", "Postal_Code")
        sqlDictionary.Add("CntryTxtBox", "Country")


        'Product Search
        resultListView.Columns.Add("Product code", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Product Description", 300, HorizontalAlignment.Left)

        sqlDictionary.Add("codeTxtBox", "prod_code")
        sqlDictionary.Add("descTxtBox", "prod_desc")


        '-M client
        resultListView.Columns.Add("Client code", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Client Org Name", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Company Name", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Client F. Name", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Client L. Name", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("SAP Code", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Client Type", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Str Num.", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Str Num Suffix", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Str. Name", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Str. Unit", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("City", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Prov", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Country", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Postal code", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Phone Number", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Phone Extension", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Fax Number", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Email", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Input By ", 80, HorizontalAlignment.Left)


        '-M client sql


        '-M CC 
        resultListView.Columns.Add("CC Code", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("CC Description", 150, HorizontalAlignment.Left)
        resultListView.Columns.Add("CC Short Description", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("B. Unit code ", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("B. Unit Description ", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("Service Elem Group code", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("Service Elem Group Desc", 150, HorizontalAlignment.Left)

        '-M Client CC
        resultListView.Columns.Add("CL CC ID", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("CL code", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Client F. Name", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Client L. Name", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Org Name", 120, HorizontalAlignment.Left)
        resultListView.Columns.Add("CC Code", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("CC Description", 150, HorizontalAlignment.Left)
        resultListView.Columns.Add("CC Short Description", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("WBS Num", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Active ", 80, HorizontalAlignment.Left)

        '-M GL
        resultListView.Columns.Add("GL Description", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("GL Category", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("GL Group", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("GL Subgroup", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("FRE Approved", 80, HorizontalAlignment.Left)

        '-- CC Search 
        resultListView.Columns.Add("CC Code", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Cost Centre Description", 150, HorizontalAlignment.Left)
        resultListView.Columns.Add("Business Unit Code", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("Business Unit Desc ", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("Service Elem Group", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("Service Elem Group Desc", 150, HorizontalAlignment.Left)
        resultListView.Columns.Add("Str Num.", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Str Num Suffix", 80, HorizontalAlignment.Left)

        sqlDictionary.Add("orgNameTxtBox", "client_org_name")
        sqlDictionary.Add("FnameTxtBox", "client_fname")
        sqlDictionary.Add("LnameTxtBox", "client_lname")
        sqlDictionary.Add("clientTypeTxtBox", "client_type")

        sqlDictionary.Add("StrtSufTxtBox", "str_num_suffix")
        sqlDictionary.Add("StrtNameTxtBox", "str_name")
        sqlDictionary.Add("StrtUnitTxtBox", "str_unit")
        sqlDictionary.Add("cityTxtBox", "city")
        sqlDictionary.Add("provTxtBox", "prov")
        sqlDictionary.Add("cntyTxtBox", "country")
        sqlDictionary.Add("postalTxtBox", "postal_code")
        sqlDictionary.Add("phoneTxtBox", "phone_num")
        sqlDictionary.Add("faxTxtBox", "fax_num")
        sqlDictionary.Add("emailTxtBox", "email")

        sqlDictionary.Add("SAPTxtBox", "client_sap_code")
        sqlDictionary.Add("inputbyTxtBox", "input_by")
        sqlDictionary.Add("phoneExtTxtBox", "phone_extension")

        'select, insert, edit, delete sql for the entry

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fundingSourcesCombo.SelectedIndexChanged



    End Sub
End Class
