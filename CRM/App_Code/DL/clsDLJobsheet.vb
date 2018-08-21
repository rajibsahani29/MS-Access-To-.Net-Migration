Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE

Namespace DL
    Public Class clsDLJobsheet
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddJobSheetDetails(ByVal objBEJobsheet As clsBEJobsheet) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobsheetDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddJobSheetDetails")
                cmd.Parameters.AddWithValue("JOBID", objBEJobsheet.JOBID)
                cmd.Parameters.AddWithValue("clientId", objBEJobsheet.clientId)
                cmd.Parameters.AddWithValue("Customername", objBEJobsheet.Customername)
                cmd.Parameters.AddWithValue("address", objBEJobsheet.address)
                cmd.Parameters.AddWithValue("OrderNumber", objBEJobsheet.OrderNumber)
                cmd.Parameters.AddWithValue("JobNumber", objBEJobsheet.JobNumber)
                cmd.Parameters.AddWithValue("InvoiceNumber", objBEJobsheet.InvoiceNumber)
                cmd.Parameters.AddWithValue("InvoiceTo", objBEJobsheet.InvoiceTo)
                cmd.Parameters.AddWithValue("ServiceType", objBEJobsheet.ServiceType)
                cmd.Parameters.AddWithValue("PlannedMaintenance", objBEJobsheet.PlannedMaintenance)
                cmd.Parameters.AddWithValue("EquipmentIdentification", objBEJobsheet.EquipmentIdentification)
                cmd.Parameters.AddWithValue("EquipmentInstallation", objBEJobsheet.EquipmentInstallation)
                cmd.Parameters.AddWithValue("Appliance", objBEJobsheet.Appliance)
                cmd.Parameters.AddWithValue("Manufacturer", objBEJobsheet.Manufacturer)
                cmd.Parameters.AddWithValue("Model", objBEJobsheet.Model)
                cmd.Parameters.AddWithValue("SerialNo", objBEJobsheet.SerialNo)
                cmd.Parameters.AddWithValue("AssetNumber", objBEJobsheet.AssetNumber)
                cmd.Parameters.AddWithValue("TotalTime", objBEJobsheet.TotalTime)
                cmd.Parameters.AddWithValue("GasLeakTest", objBEJobsheet.GasLeakTest)
                cmd.Parameters.AddWithValue("EarthLeakageTest", objBEJobsheet.EarthLeakageTest)
                cmd.Parameters.AddWithValue("LoadTest", objBEJobsheet.LoadTest)
                cmd.Parameters.AddWithValue("flashTest", objBEJobsheet.flashTest)
                cmd.Parameters.AddWithValue("InsRes", objBEJobsheet.InsRes)
                cmd.Parameters.AddWithValue("EC", objBEJobsheet.EC)
                cmd.Parameters.AddWithValue("MicrowaveLeakage", objBEJobsheet.MicrowaveLeakage)
                cmd.Parameters.AddWithValue("PowerOutput", objBEJobsheet.PowerOutput)
                cmd.Parameters.AddWithValue("Fault", objBEJobsheet.fault)
                cmd.Parameters.AddWithValue("workDetails", objBEJobsheet.workDetails)
                cmd.Parameters.AddWithValue("TotalParts", objBEJobsheet.TotalParts)
                cmd.Parameters.AddWithValue("TotalLabour", objBEJobsheet.TotalLabour)
                cmd.Parameters.AddWithValue("charges", objBEJobsheet.charges)
                cmd.Parameters.AddWithValue("SubTotal", objBEJobsheet.SubTotal)
                cmd.Parameters.AddWithValue("Vat", objBEJobsheet.Vat)
                cmd.Parameters.AddWithValue("TotalIncVat", objBEJobsheet.TotalIncVat)
                cmd.Parameters.AddWithValue("ChargeableStatus", objBEJobsheet.ChargeableStatus)
                cmd.Parameters.AddWithValue("warrantyStatus", objBEJobsheet.warrantyStatus)
                cmd.Parameters.AddWithValue("JobCompleteStatus", objBEJobsheet.JobCompleteStatus)
                cmd.Parameters.AddWithValue("Reason", objBEJobsheet.Reason)
                cmd.Parameters.AddWithValue("PrintName", objBEJobsheet.PrintName)
                cmd.Parameters.AddWithValue("JobTitle", objBEJobsheet.JobTitle)
                cmd.Parameters.AddWithValue("Engineerid", objBEJobsheet.Engineerid)
                cmd.Parameters.AddWithValue("Whenx", objBEJobsheet.Whenx)

                Dim intJobSheetId As Integer = ExecuteNoneQueryByCommand(cmd, "AddJobSheetDetails", "Y")
                Return intJobSheetId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function UpdateJobSheetDetails(ByVal objBEJobsheet As clsBEJobsheet) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobsheetDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateJobSheetDetails")
                cmd.Parameters.AddWithValue("Id", objBEJobsheet.Id)
                cmd.Parameters.AddWithValue("Customername", objBEJobsheet.Customername)
                cmd.Parameters.AddWithValue("address", objBEJobsheet.address)
                cmd.Parameters.AddWithValue("OrderNumber", objBEJobsheet.OrderNumber)
                cmd.Parameters.AddWithValue("JobNumber", objBEJobsheet.JobNumber)
                cmd.Parameters.AddWithValue("InvoiceNumber", objBEJobsheet.InvoiceNumber)
                cmd.Parameters.AddWithValue("InvoiceTo", objBEJobsheet.InvoiceTo)
                cmd.Parameters.AddWithValue("ServiceType", objBEJobsheet.ServiceType)
                cmd.Parameters.AddWithValue("PlannedMaintenance", objBEJobsheet.PlannedMaintenance)
                cmd.Parameters.AddWithValue("EquipmentIdentification", objBEJobsheet.EquipmentIdentification)
                cmd.Parameters.AddWithValue("EquipmentInstallation", objBEJobsheet.EquipmentInstallation)
                cmd.Parameters.AddWithValue("Appliance", objBEJobsheet.Appliance)
                cmd.Parameters.AddWithValue("Manufacturer", objBEJobsheet.Manufacturer)
                cmd.Parameters.AddWithValue("Model", objBEJobsheet.Model)
                cmd.Parameters.AddWithValue("SerialNo", objBEJobsheet.SerialNo)
                cmd.Parameters.AddWithValue("AssetNumber", objBEJobsheet.AssetNumber)
                cmd.Parameters.AddWithValue("TotalTime", objBEJobsheet.TotalTime)
                cmd.Parameters.AddWithValue("GasLeakTest", objBEJobsheet.GasLeakTest)
                cmd.Parameters.AddWithValue("EarthLeakageTest", objBEJobsheet.EarthLeakageTest)
                cmd.Parameters.AddWithValue("LoadTest", objBEJobsheet.LoadTest)
                cmd.Parameters.AddWithValue("flashTest", objBEJobsheet.flashTest)
                cmd.Parameters.AddWithValue("InsRes", objBEJobsheet.InsRes)
                cmd.Parameters.AddWithValue("EC", objBEJobsheet.EC)
                cmd.Parameters.AddWithValue("MicrowaveLeakage", objBEJobsheet.MicrowaveLeakage)
                cmd.Parameters.AddWithValue("PowerOutput", objBEJobsheet.PowerOutput)
                cmd.Parameters.AddWithValue("Fault", objBEJobsheet.fault)
                cmd.Parameters.AddWithValue("workDetails", objBEJobsheet.workDetails)
                cmd.Parameters.AddWithValue("TotalParts", objBEJobsheet.TotalParts)
                cmd.Parameters.AddWithValue("TotalLabour", objBEJobsheet.TotalLabour)
                cmd.Parameters.AddWithValue("charges", objBEJobsheet.charges)
                cmd.Parameters.AddWithValue("SubTotal", objBEJobsheet.SubTotal)
                cmd.Parameters.AddWithValue("Vat", objBEJobsheet.Vat)
                cmd.Parameters.AddWithValue("TotalIncVat", objBEJobsheet.TotalIncVat)
                cmd.Parameters.AddWithValue("ChargeableStatus", objBEJobsheet.ChargeableStatus)
                cmd.Parameters.AddWithValue("warrantyStatus", objBEJobsheet.warrantyStatus)
                cmd.Parameters.AddWithValue("JobCompleteStatus", objBEJobsheet.JobCompleteStatus)
                cmd.Parameters.AddWithValue("Reason", objBEJobsheet.Reason)
                cmd.Parameters.AddWithValue("PrintName", objBEJobsheet.PrintName)
                cmd.Parameters.AddWithValue("JobTitle", objBEJobsheet.JobTitle)
                cmd.Parameters.AddWithValue("Whenxupdate", objBEJobsheet.Whenxupdate)

                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateJobSheetDetails")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetJobSheetDetailsByClientId(ByVal objBEJobsheet As clsBEJobsheet) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobsheetDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobSheetDetailsByClientId")
                cmd.Parameters.AddWithValue("clientId", objBEJobsheet.clientId)
                cmd.Parameters.AddWithValue("Engineerid", objBEJobsheet.Engineerid)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobSheetDetailsByClientId")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetJobSheetDetailsById(ByVal objBEJobsheet As clsBEJobsheet) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobsheetDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobSheetDetailsById")
                cmd.Parameters.AddWithValue("Id", objBEJobsheet.Id)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobSheetDetailsById")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetJobSheetDetailsByJobid(ByVal objBEJobsheet As clsBEJobsheet) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobsheetDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobSheetDetailsByJobid")
                cmd.Parameters.AddWithValue("JOBID", objBEJobsheet.JOBID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobSheetDetailsByJobid")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetJobSheetDetail(ByVal strSearchByEngineer As String, ByVal strSearchByCompany As String, ByVal strSearchByJobnumber As String, ByVal SearchByFromDate As String, ByVal strSerchByToDate As String) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobsheetDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobSheetDetail")
                cmd.Parameters.AddWithValue("SearchByEngineer", strSearchByEngineer)
                cmd.Parameters.AddWithValue("SearchByCompany", strSearchByCompany)
                cmd.Parameters.AddWithValue("SerchByJobnumber", strSearchByJobnumber)
                cmd.Parameters.AddWithValue("SerchByFromDate", SearchByFromDate)
                cmd.Parameters.AddWithValue("SerchByToDate", strSerchByToDate)

                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobSheetDetail")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

    End Class
End Namespace
