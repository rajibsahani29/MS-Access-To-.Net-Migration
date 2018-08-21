Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE


Namespace DL
    Public Class clsDLlocOrder
        Inherits BaseDB
        Dim objFunction As New clsCommon()

        Public Function AddlocOrderDetails(ByVal objBElocOrder As clsBElocOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_splocOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddlocOrderDetails")
                cmd.Parameters.AddWithValue("JOBID", objBElocOrder.JOBID)
                cmd.Parameters.AddWithValue("ID", objBElocOrder.ID)
                cmd.Parameters.AddWithValue("Status", objBElocOrder.Status)
                cmd.Parameters.AddWithValue("EnquiryDate", objBElocOrder.EnquiryDate)
                cmd.Parameters.AddWithValue("Appliance", objBElocOrder.Appliance)
                cmd.Parameters.AddWithValue("Fault", objBElocOrder.Fault)
                cmd.Parameters.AddWithValue("Premises", objBElocOrder.Premises)
                cmd.Parameters.AddWithValue("JobNumber", objBElocOrder.JobNumber)
                'cmd.Parameters.AddWithValue("Engineer", objBElocOrder.Engineer)
                'cmd.Parameters.AddWithValue("Qty", objBElocOrder.Qty)
                'cmd.Parameters.AddWithValue("Received", objBElocOrder.Received)
                'cmd.Parameters.AddWithValue("await", objBElocOrder.await)
                cmd.Parameters.AddWithValue("OrderNumber", objBElocOrder.OrderNumber)
                'cmd.Parameters.AddWithValue("EnqDate", objBElocOrder.EnqDate)
                'cmd.Parameters.AddWithValue("SheetDate", objBElocOrder.SheetDate)
                'cmd.Parameters.AddWithValue("QuoteNumber", objBElocOrder.QuoteNumber)
                'cmd.Parameters.AddWithValue("InvoiceStatus", objBElocOrder.InvoiceStatus)
                cmd.Parameters.AddWithValue("JobType", objBElocOrder.JobType)
                Dim intJobId As Integer = ExecuteNoneQueryByCommand(cmd, "AddlocOrderDetails", "Y")
                Return intJobId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function UpdatelocOrderDetails(ByVal objBElocOrder As clsBElocOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_splocOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdatelocOrderDetails")
                cmd.Parameters.AddWithValue("JOBID", objBElocOrder.JOBID)
                cmd.Parameters.AddWithValue("Status", objBElocOrder.Status)
                cmd.Parameters.AddWithValue("JobNumber", objBElocOrder.JobNumber)
                cmd.Parameters.AddWithValue("OrderNumber", objBElocOrder.OrderNumber)
                cmd.Parameters.AddWithValue("Engineer", objBElocOrder.Engineer)
                cmd.Parameters.AddWithValue("Premises", objBElocOrder.Premises)
                cmd.Parameters.AddWithValue("Appliance", objBElocOrder.Appliance)
                cmd.Parameters.AddWithValue("Fault", objBElocOrder.Fault)
                cmd.Parameters.AddWithValue("SheetDate", objBElocOrder.SheetDate)
                cmd.Parameters.AddWithValue("QuoteNumber", objBElocOrder.QuoteNumber)
                cmd.Parameters.AddWithValue("InvoiceStatus", objBElocOrder.InvoiceStatus)
                cmd.Parameters.AddWithValue("JobType", objBElocOrder.JobType)

                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdatelocOrderDetails")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function DeletelocOrderDetailsByJobId(ByVal objBElocOrder As clsBElocOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_splocOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "DeletelocOrderDetailsByJobId")
                cmd.Parameters.AddWithValue("JOBID", objBElocOrder.JOBID)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "DeletelocOrderDetailsByJobId")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetAllJobOrders() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_splocOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetAllJobOrders")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetAllJobOrders")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetOrderDetail(ByVal strSearchByEngineer As String, ByVal strSearchByStatus As String, ByVal strSearchByCompany As String, ByVal strSearchByFFNos As String, ByVal strSearchByPermises As String, ByVal strSearchByAppliance As String, ByVal strSearchByFault As String, strSearchByOrder As String, strSearchByQuote As String) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_splocOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetOrderDetail")
                cmd.Parameters.AddWithValue("SearchByEngineer", strSearchByEngineer)
                cmd.Parameters.AddWithValue("SearchByStatus", strSearchByStatus)
                cmd.Parameters.AddWithValue("SearchByCompany", strSearchByCompany)
                cmd.Parameters.AddWithValue("SearchByFFNos", strSearchByFFNos)
                cmd.Parameters.AddWithValue("SearchByPermises", strSearchByPermises)
                cmd.Parameters.AddWithValue("SearchByAppliance", strSearchByAppliance)
                cmd.Parameters.AddWithValue("SearchByFault", strSearchByFault)
                cmd.Parameters.AddWithValue("SearchByOrder", strSearchByOrder)
                cmd.Parameters.AddWithValue("SearchByQuote", strSearchByQuote)
                'cmd.Parameters.AddWithValue("StaffID", intUserId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetOrderDetail")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetJobDetailsByJobNumber(ByVal objBEOrder As clsBEOrder) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_splocOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobDetailsByJobNumber")
                cmd.Parameters.AddWithValue("JobNumber", objBEOrder.JobNumber)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobDetailsByJobNumber")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function UpdatelocOrderDetailsByJobAllocation(ByVal objBElocOrder As clsBElocOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_splocOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdatelocOrderDetailsByJobAllocation")
                cmd.Parameters.AddWithValue("JOBID", objBElocOrder.JOBID)
                cmd.Parameters.AddWithValue("SheetDate", objBElocOrder.SheetDate)
                cmd.Parameters.AddWithValue("Engineer", objBElocOrder.Engineer)
                cmd.Parameters.AddWithValue("Status", objBElocOrder.Status)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdatelocOrderDetailsByJobAllocation")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
    End Class
End Namespace
