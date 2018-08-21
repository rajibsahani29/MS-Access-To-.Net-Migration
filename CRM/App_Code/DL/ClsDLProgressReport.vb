Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE

Namespace DL
    Public Class ClsDLProgressReport
        Inherits BaseDB
        Dim objFunction As New clsCommon()

        Public Function GetWeekendingFillInDD() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spProgressReportDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetWeekendingFillInDD")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetWeekendingFillInDD")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetProgressReprotByJobStatus(ByVal SearchByFromDate As String, ByVal strSerchByToDate As String, ByVal strByMonth As String, ByVal strByYear As String) As DataTable
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spProgressReportDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetProgressReprotByJobStatus")
                cmd.Parameters.AddWithValue("SerchByFromDate", SearchByFromDate)
                cmd.Parameters.AddWithValue("SerchByToDate", strSerchByToDate)
                cmd.Parameters.AddWithValue("month", strByMonth)
                cmd.Parameters.AddWithValue("year", strByYear)

                Dim dstData As DataTable = FillDataSetByCommandTable(cmd, "GetProgressReprotByJobStatus")
                If objFunction.CheckDataTable(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetProgressReprotByJobType(ByVal SearchByFromDate As String, ByVal strSerchByToDate As String, ByVal strByMonth As String, ByVal strByYear As String) As DataTable
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spProgressReportDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetProgressReprotByJobType")
                cmd.Parameters.AddWithValue("SerchByFromDate", SearchByFromDate)
                cmd.Parameters.AddWithValue("SerchByToDate", strSerchByToDate)
                cmd.Parameters.AddWithValue("month", strByMonth)
                cmd.Parameters.AddWithValue("year", strByYear)
                Dim dstData As DataTable = FillDataSetByCommandTable(cmd, "GetProgressReprotByJobType")
                If objFunction.CheckDataTable(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetProgressReprotByInvoiceStatus(ByVal SearchByFromDate As String, ByVal strSerchByToDate As String, ByVal strByMonth As String, ByVal strByYear As String) As DataTable
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spProgressReportDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetProgressReprotByInvoiceStatus")
                cmd.Parameters.AddWithValue("SerchByFromDate", SearchByFromDate)
                cmd.Parameters.AddWithValue("SerchByToDate", strSerchByToDate)
                cmd.Parameters.AddWithValue("month", strByMonth)
                cmd.Parameters.AddWithValue("year", strByYear)

                Dim dstData As DataTable = FillDataSetByCommandTable(cmd, "GetProgressReprotByInvoiceStatus")
                If objFunction.CheckDataTable(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetJobList(ByVal SearchByFromDate As String, ByVal strSerchByToDate As String, ByVal strByMonth As String, ByVal strByYear As String, ByVal strSearchByEngineer As String, ByVal strSearchByInvoice As String, ByVal strSearchByStatus As String) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spProgressReportDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobList")
                cmd.Parameters.AddWithValue("SerchByFromDate", SearchByFromDate)
                cmd.Parameters.AddWithValue("SerchByToDate", strSerchByToDate)
                cmd.Parameters.AddWithValue("month", strByMonth)
                cmd.Parameters.AddWithValue("year", strByYear)
                cmd.Parameters.AddWithValue("strSearchByEngineer", strSearchByEngineer)
                cmd.Parameters.AddWithValue("strSearchByInvoice", strSearchByInvoice)
                cmd.Parameters.AddWithValue("strSearchByStatus", strSearchByStatus)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobList")
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
