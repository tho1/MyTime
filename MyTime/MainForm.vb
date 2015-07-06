
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlServerCe.SqlCeDataAdapter
Imports System.Data.SqlServerCe.SqlCeConnection
Imports System.Text.StringBuilder

Public Class MainForm

    Private m_cn As New System.Data.SqlServerCe.SqlCeConnection
    Private m_DA As New System.Data.SqlServerCe.SqlCeDataAdapter
    Private m_CB As New System.Data.SqlServerCe.SqlCeCommandBuilder
    Private m_DataTable As New DataTable
    Private m_rowPosition As Integer = 0
    Private WithEvents m_DataGrid As New DataGridView
    Private mydataSet As DataSet
    Public actionPerformed As String

    Public Const defaultaction As String = "default"
    Public Const add = "Add"
    Public Const edit = "Edit"
    Public Const delete = "Delete"
    Public Const save = "Save"
    Public Const cancel = "Cancel"


    Public sqlDictionary As New Dictionary(Of String, String)


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Console.Beep()
        Me.Close()

    End Sub


    Private Sub setupGrid()
        resultListView.Columns.Add("OrderId", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("OrderItemId", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("ItemName", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("ItemDesc", 80, HorizontalAlignment.Left)

        resultListView.GridLines = True
        resultListView.Sorting = Windows.Forms.SortOrder.Ascending

        resultListView.Show()
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

        resultListView.Columns.Add("OrderID", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("CusotmerID", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("Title", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("Artist", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("ShipDate", 100, HorizontalAlignment.Left)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBtn.Click

        ' Set some connection string properties e.g.:
        ' 
        m_cn.ConnectionString = _
            "Persist Security Info = False; Data Source = 'C:\work\thomas\db\MyWork.sdf';" & _
            "Password = '123456'; File Mode = 'shared read'; " & _
            "Max Database Size = 256; Max Buffer Size = 1024"

        m_cn.Open()

        'MsgBox(m_cn.ServerVersion)

        m_DA = New SqlCeDataAdapter("SELECT OrderId, OrderItemID, itemName, ItemDesc FROM OrderItem", m_cn)

        'Using reader As SqlDataReader = Command.ExecuteReader()
        Dim reader As SqlDataReader
        While reader.Read()

            Dim Str(5) As String
            For i = 0 To 4
                If reader(i).ToString.Length > 0 Then
                    Str(i) = Trim(reader(i))
                End If
            Next

        End While
        'End Using

        m_cn.Close()

        'System.Data.SqlServerCe.SqlCeDataAdapter(dataAdapter = New SqlCeDataAdapter(Command))

        'm_DA.Fill(m_DataTable)
        'm_DataGrid.DataSource = m_DataTable

        'm_DataGrid.Location = New Point(41, 167)
        'm_DataGrid.Size = New Size(300, 300)

        'm_DataGrid.Show()

        m_cn.Close()
        'm_cn.Dispose()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fnameTxtBox.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBtn.Click


        Dim connection As New System.Data.SqlServerCe.SqlCeConnection
        Dim cmdStr As String = "SELECT OrderId, OrderItemID, itemName, ItemDesc FROM OrderItem"

        Dim conStr = "Persist Security Info = False; Data Source = 'C:\work\thomas\db\MyWork.sdf';" & _
            "Password = '123456'; File Mode = 'shared read'; " & _
            "Max Database Size = 256; Max Buffer Size = 1024"

        Dim row As ListViewItem

        Try
            connection.ConnectionString = conStr
            Using cmd As New SqlCeCommand(cmdStr, connection)

                connection.Open()

                'MsgBox(connection.ServerVersion)
                Using Reader As SqlCeDataReader = cmd.ExecuteReader()
                    While Reader.Read()
                        row = New ListViewItem

                        Dim Str(4) As String
                        For i = 0 To 3
                            If Reader(i).ToString.Length > 0 Then
                                Str(i) = Trim(Reader(i))
                            End If
                        Next

                        row = New ListViewItem(Str)
                        resultListView.Items.Add(row)
                    End While
                End Using
            End Using

            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, Me.Text)
        End Try

        resultListView.Show()


        'ResultListView.Columns.Add(" ", 80, HorizontalAlignment.Left)
        'Dim resultListView As ListView
        'resultListView.GridLines = True
        ' Sort the items in the list in ascending order.
        'resultListView.Sorting = SortOrder.Ascending

        'Dim resultData(,) As Object = New Object(,) {}

        'select edit
        'set the current 

        'set fields to read only.
        'Save the info to database

        'make the fields modifiable
        'retrieves items

    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MsgBox("inside load")

        Me.fnameTxtBox.Text = "Type your First Name"
        Me.lnameTxtBox.Text = "Type your Last Name"
        Me.salute.Text = "Ms."
    End Sub

    Private Sub configButtons(ByVal action As String)

        If action = defaultaction Or action = cancel Then
            
            saveBtn.Enabled = False
            AddBtn.Enabled = True
            EditBtn.Enabled = False
            delBtn.Enabled = False

            closeBtn.Text = "Close"
        ElseIf action = add Or action = edit Then

            saveBtn.Enabled = True
            AddBtn.Enabled = False
            EditBtn.Enabled = False
            delBtn.Enabled = False
            closeBtn.Text = "Cancel"

        ElseIf action = save Then
            saveBtn.Enabled = False
            AddBtn.Enabled = True
            EditBtn.Enabled = False
            delBtn.Enabled = False
            closeBtn.Text = "Close"

        End If

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        setupGrid()

        configButtons(defaultaction)

        'set to Client CC for now
        ccCodeTxtBox.Enabled = True
        ccDescTxtBox.Enabled = True
        ccShortDescTxtBox.Enabled = True
        wbsTxtbox.Enabled = False

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

        'MsgBox("inside new")

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
        '-----------------------------
        sqlDictionary.Add("LocCodeTxtBox", "Office_Loc_code")
        sqlDictionary.Add("BldgTxtBox", "Building_Name")

        sqlDictionary.Add("CityTxtBox", "City")
        sqlDictionary.Add("ProvTxtBox", "Prov")
        sqlDictionary.Add("PostalTxtBox", "Postal_Code")
        sqlDictionary.Add("CntryTxtBox", "Country")

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fundingSourcesCombo.SelectedIndexChanged






    End Sub

    Private Sub DataValidation()

        Dim whereClauseBuilder As New StringBuilder

        'Client CC 
        sqlDictionary.Add("yearUseTxtBox", "clcc.cc_year_use")

        sqlDictionary.Add("clientcodeTxtBox", "clcc.client_code")
        sqlDictionary.Add("fnameTxtBox", "cl.client_fname")
        sqlDictionary.Add("lnameTxtBox", "cl.client_lname")
        sqlDictionary.Add("orgTxtBox", "cl.client_org_name")

        sqlDictionary.Add("ccCodeTxtBox", "clcc.cc_code")
        sqlDictionary.Add("ccDescTxtBox", "clcc.cc_desc")
        sqlDictionary.Add("ccShortDescTxtBox", "clcc.cc_short_desc")
        sqlDictionary.Add("wbsTxtBox", "clcc.wbs_num")

        'active
        'If activeCombo.selectedValue = 'Yes' Then
        whereClauseBuilder.append(" clcc.cc_status = 'A'")
        'End If


        'Clients
        sqlDictionary.Add("clientcodeTxtBox", "clcc.client_code")
        sqlDictionary.Add("orgTxtBox", "clcc.client_org_name")
        sqlDictionary.Add("companyNameTxtBox", "c.company_na,me")
        sqlDictionary.Add("orgTxtBox", "c.client_fname")



    End Sub


    Private Sub getGridData()


    End Sub

    Private Sub costCentreSrchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles costCentreSrchBtn.Click
        getGridData()

    End Sub

    Private Sub saveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveBtn.Click
        MsgBox("Save clicked")
        configButtons(save)

        If actionPerformed = add Then
            'call the sql to add the new entry

            Dim insertSql = "insert into "tbls_client_cc("")

            'main client
            Dim insertSql = "insert into_tblsi"
        End If

        If actionPerformed = edit Then
            'call the sql to update the entry

            Dim updateSql = "update tbls_client_cc set "




        End If

    End Sub

    Private Sub resultListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resultListView.ItemSelectionChanged
        Me.EditBtn.Enabled = True
        Me.delBtn.Enabled = True
        Me.cancelBtn.Text = "Cancel"


        Dim newindex = resultListView.FocusedItem.Index

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        'radio button checked.
        ccCodeTxtBox.Enabled = True
        ccDescTxtBox.Enabled = True
        ccShortDescTxtBox.Enabled = True
        wbsTxtbox.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        ccCodeTxtBox.Enabled = False
        ccDescTxtBox.Enabled = False
        ccShortDescTxtBox.Enabled = False
        wbsTxtbox.Enabled = True
    End Sub

    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        MsgBox("Add clicked")
        actionPerformed = add
        configButtons(add)
    End Sub

    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        MsgBox("Edit clicked")
        actionPerformed = edit
        configButtons(edit)

        'fill in the value into the text box
        idTxtBox.Text = resultListView.FocusedItem.SubItems(0).Text
        YearUseTxtBox.Text = resultListView.FocusedItem.SubItems(?).Text

        '
        If resultListView.FocusedItem.SubItems(9).Text = "A" Then
            activeCombo.selectedItem = "Yes"
        End If

        clientCodeTxtBox.Text = resultListView.FocusedItem.SubItems(1).Text
        fnameTxtBox.Text = resultListView.FocusedItem.SubItems(2).Text
        lnameTxtBox.Text = resultListView.FocusedItem.SubItems(3).Text

        If resultListView.FocusedItem.SubItems(8).Text.Length > 0 Then
            wbsTxtNum.Text = resultListView.FocusedItem.SubItems(8).Text
        Else
            ccCodeTxtBox.Text = resultListView.FocusedItem.SubItems(5).Text
            ccDescTxtBox.Text = resultListView.FocusedItem.SubItems(6).Text
            ccShortDescTxtBox.Text = resultListView.FocusedItem.SubItems(7).Text
        End If



    End Sub

    Private Sub delBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delBtn.Click
        MsgBox("del clicked")
        actionPerformed = delete

        Dim a = MsgBox("Are you sure you want to delete?", MsgBoxStyle.OkCancel)
        If a = MsgBoxResult.Ok Then
            MsgBox("entry deleted")

            'remove the entry in the list? or call the resultList again.
            Dim delId = resultListView.FocusedItem.SubItems(0).Text
            MsgBox("delID is " + delId)

            Dim delSql = "delete from tbls_client_cc where client_cc_id = " + delId

            'call sql

        End If
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        MsgBox("close/cancel clicked")

        If closeBtn.Text = "Close" Then
            actionPerformed = defaultaction
            Me.Close()
        Else
            'cancel current edit/add action
            Dim a = MsgBox("Are you sure you want to cancel", MsgBoxStyle.OkCancel)
            If a = MsgBoxResult.Ok Then
                configButtons(defaultaction)
            End If
        End If

    End Sub

    Private Sub resultListView_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resultListView.SelectedIndexChanged

    End Sub
End Class
