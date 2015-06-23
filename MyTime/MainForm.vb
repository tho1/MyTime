
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

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

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
    End Sub
End Class
