Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UpdateTabCtrl.Show()
        TabPage3.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Hide the update tab control
        UpdateTabCtrl.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        UpdateTabCtrl.Show()
        TabPage4.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        UpdateTabCtrl.Show()
        TabPage5.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        UpdateTabCtrl.Show()
        TabPage6.Show()
    End Sub

    Private Sub OKBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click

        UpdateTabCtrl.Hide()
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click


        UpdateTabCtrl.Hide()
    End Sub

    Private Sub SetupSearchGrid()
        -M client
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


        -M client sql


        -M CC 
        resultListView.Columns.Add("CC Code", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("CC Description", 150, HorizontalAlignment.Left)
        resultListView.Columns.Add("CC Short Description", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("B. Unit code ", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("B. Unit Description ", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("Service Elem Group code", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("Service Elem Group Desc", 150, HorizontalAlignment.Left)

        -M Client CC
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

        -M GL
        resultListView.Columns.Add("GL Description", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("GL Category", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("GL Group", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("GL Subgroup", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("FRE Approved", 80, HorizontalAlignment.Left)

        -- CC Search 
        resultListView.Columns.Add("CC Code", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Cost Centre Description", 150, HorizontalAlignment.Left)
        resultListView.Columns.Add("Business Unit Code", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("Business Unit Desc ", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("Service Elem Group", 100, HorizontalAlignment.Left)
        resultListView.Columns.Add("Service Elem Group Desc", 150, HorizontalAlignment.Left)
        resultListView.Columns.Add("Str Num.", 80, HorizontalAlignment.Left)
        resultListView.Columns.Add("Str Num Suffix", 80, HorizontalAlignment.Left)



        Dim sqlDictionary As New Dictionary(Of String, String)
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


End Class
