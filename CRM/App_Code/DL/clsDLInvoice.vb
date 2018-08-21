Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL

    Public Class clsDLInvoice
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddInvoiceItemDetails(ByVal objBEInvoice As clsBEInvoice) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spInvoiceItemDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddInvoiceItemDetails")
                cmd.Parameters.AddWithValue("JOBID", objBEInvoice.JOBID)
                cmd.Parameters.AddWithValue("Line", objBEInvoice.Line)
                cmd.Parameters.AddWithValue("Nos", objBEInvoice.Nos)
                cmd.Parameters.AddWithValue("ItemDesctiption", objBEInvoice.ItemDesctiption)
                cmd.Parameters.AddWithValue("UNIT", objBEInvoice.UNIT)
                cmd.Parameters.AddWithValue("Cost", objBEInvoice.Cost)
                'cmd.Parameters.AddWithValue("DateFrom", objBEInvoice.DateFrom)
                'cmd.Parameters.AddWithValue("DateTo", objBEInvoice.DateTo)

                Dim intInvoiceId As Integer = ExecuteNoneQueryByCommand(cmd, "AddInvoiceItemDetails", "Y")
                Return intInvoiceId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetInvoiceItemDetailsById(ByVal objBEInvoice As clsBEInvoice) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spInvoiceItemDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetInvoiceItemDetailsById")
                cmd.Parameters.AddWithValue("JOBID", objBEInvoice.JOBID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetInvoiceItemDetailsById")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function CurrentInvoiceLinNumbers(ByVal jobid As Integer) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spInvoiceItemDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "CurrentInvoiceLinNumbers")
                cmd.Parameters.AddWithValue("JOBID", jobid)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "CurrentInvoiceLinNumbers")
                If (intAffectedRow > 0) Then
                    intAffectedRow = intAffectedRow + 1
                Else
                    intAffectedRow = 1
                End If
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBEInvoice As clsBEInvoice) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spInvoiceItemDetails"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdateInvoiceItemDetails")
                    cmd.Parameters.AddWithValue("InvoiceItemlID", objBEInvoice.InvoiceItemlID)
                    cmd.Parameters.AddWithValue("ItemDesctiption", objBEInvoice.ItemDesctiption)
                    cmd.Parameters.AddWithValue("UNIT", objBEInvoice.UNIT)
                    cmd.Parameters.AddWithValue("Nos", objBEInvoice.Nos)
                    cmd.Parameters.AddWithValue("Line", objBEInvoice.Line)
                    cmd.Parameters.AddWithValue("Cost", objBEInvoice.Cost)

                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeleteInvoiceItemDetails")
                    cmd.Parameters.AddWithValue("InvoiceItemlID", objBEInvoice.InvoiceItemlID)
                End If
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "PerformGridViewOpertaion")
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
    End Class
End Namespace
