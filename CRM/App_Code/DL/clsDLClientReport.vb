Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Namespace DL
    Public Class clsDLClientReport
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function GetClientReprotBySearchCriteria(ByVal SearchByFromDate As String, ByVal strSerchByToDate As String, ByVal strByClient As String, ByVal strSearchByRefrigeration As String, ByVal SearchByType As String) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientReportDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetClientReprotBySearchCriteria")
                cmd.Parameters.AddWithValue("SerchByFromDate", SearchByFromDate)
                cmd.Parameters.AddWithValue("SerchByToDate", strSerchByToDate)
                cmd.Parameters.AddWithValue("strSearchByClientID", strByClient)
                cmd.Parameters.AddWithValue("SearchByRefrigeration", strSearchByRefrigeration)
                cmd.Parameters.AddWithValue("SearchByType", SearchByType)

                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetClientReprotBySearchCriteria")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function ClientReportForFirstVisitFix(ByVal SearchByFromDate As String, ByVal strSerchByToDate As String, ByVal strByClient As String) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientReportDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "ClientReportForFirstVisitFix")
                cmd.Parameters.AddWithValue("SerchByFromDate", SearchByFromDate)
                cmd.Parameters.AddWithValue("SerchByToDate", strSerchByToDate)
                cmd.Parameters.AddWithValue("strSearchByClientID", strByClient)

                Dim dstData As DataSet = FillDataSetByCommand(cmd, "ClientReportForFirstVisitFix")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function ClientReportDetails(ByVal SearchByFromDate As String, ByVal strSerchByToDate As String, ByVal strByClient As String) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientReportDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "ClientReportDetails")
                cmd.Parameters.AddWithValue("SerchByFromDate", SearchByFromDate)
                cmd.Parameters.AddWithValue("SerchByToDate", strSerchByToDate)
                cmd.Parameters.AddWithValue("strSearchByClientID", strByClient)

                Dim dstData As DataSet = FillDataSetByCommand(cmd, "ClientReportDetails")
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
