Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE

Namespace DL
    Public Class clsDLTaskManagement
        Inherits BaseDB
        Dim objFunction As New clsCommon()

        Public Function GetTaskManagementList() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spTaskManagementDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetTaskManagementList")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetTaskManagementList")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetTaskManagementListBySearch(ByVal SearchByStaffFor As String, ByVal SearchByStaffBy As String, ByVal SearchByStatus As String) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spTaskManagementDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetTaskManagementListBySearch")
                cmd.Parameters.AddWithValue("SearchByStaffFor", SearchByStaffFor)
                cmd.Parameters.AddWithValue("SearchByStaffBy", SearchByStaffBy)
                cmd.Parameters.AddWithValue("SearchByStatus", SearchByStatus)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetTaskManagementListBySearch")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function StaffTasksAndStatusCRossTab() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spTaskManagementDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "StaffTasksAndStatusCRossTab")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "StaffTasksAndStatusCRossTab")
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
