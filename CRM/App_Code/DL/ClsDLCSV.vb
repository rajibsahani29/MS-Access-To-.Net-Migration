Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE

Namespace DL
    Public Class ClsDLCSV
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function GetInvoiceForSage() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_CSVOutputDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetInvoiceForSage")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetInvoiceForSage")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetClientForSage() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_CSVOutputDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetClientForSage")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetClientForSage")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetClientForSage1() As DataTable
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_CSVOutputDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetClientForSage")
                Dim dstData As DataTable = FillDataSetByCommandTable(cmd, "GetClientForSage")
                If objFunction.CheckDataTable(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetInvoiceForSage1() As DataTable
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_CSVOutputDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetInvoiceForSage")
                Dim dstData As DataTable = FillDataSetByCommandTable(cmd, "GetInvoiceForSage")
                If objFunction.CheckDataTable(dstData) Then
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
