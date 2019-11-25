Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.SqlClient.SqlParameter
Imports System.Data.SqlClient.SqlConnectionStringBuilder
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public crystalServer As String = "dbhost"
Public crystaldb As String = "mydb"
Public crystalUsername As String = "app_rim"
Public crystalPassword As String = ""


    Public Sub CRRemap(ByVal CR As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        For Each DSC As CrystalDecisions.Shared.IConnectionInfo In CR.DataSourceConnections
            DSC.SetLogon(crystalUsername, crystalPassword)
            DSC.SetConnection(crystalServer, crystaldb, False)
        Next

        CR.SetDatabaseLogon(crystalUsername, crystalPassword)

        For Each Table As CrystalDecisions.CrystalReports.Engine.Table In CR.Database.Tables
            Table.LogOnInfo.ConnectionInfo.UserID = crystalUsername
            Table.LogOnInfo.ConnectionInfo.Password = crystalPassword
        Next

        If Not CR.IsSubreport Then
            For Each SR As CrystalDecisions.CrystalReports.Engine.ReportDocument In CR.Subreports
                RecurseAndRemap(SR)
            Next
        End If
    End Sub
