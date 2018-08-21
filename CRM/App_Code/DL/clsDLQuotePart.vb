Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLQuotePart
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddQuotePartsDetails(ByVal objBEQuotePart As clsBEQuotePart) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spQuotePartsDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddQuotePartsDetails")
                cmd.Parameters.AddWithValue("JOBID", objBEQuotePart.JOBID)
                cmd.Parameters.AddWithValue("Quantity", objBEQuotePart.Quantity)
                cmd.Parameters.AddWithValue("SellPrice", objBEQuotePart.SellPrice)
                cmd.Parameters.AddWithValue("Supplier", objBEQuotePart.Supplier)
                cmd.Parameters.AddWithValue("UnitPrice", objBEQuotePart.UnitPrice)
                cmd.Parameters.AddWithValue("PartNumber", objBEQuotePart.PartNumber)
                cmd.Parameters.AddWithValue("Description", objBEQuotePart.Description)
                Dim intClientId As Integer = ExecuteNoneQueryByCommand(cmd, "AddQuotePartsDetails", "Y")
                Return intClientId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetQuotePartsDetailsByJOBID(ByVal objBEQuotePart As clsBEQuotePart) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spQuotePartsDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetQuotePartsDetailsByJOBID")
                cmd.Parameters.AddWithValue("JOBID", objBEQuotePart.JOBID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetQuotePartsDetailsByJOBID")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function DeleteQuotePartsDetails(ByVal objBEQuotePart As clsBEQuotePart) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spQuotePartsDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "DeleteQuotePartsDetails")
                cmd.Parameters.AddWithValue("JobPartID", objBEQuotePart.JobPartID)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "DeleteQuotePartsDetails")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function UpdateQuotePartsDetails(ByVal objBEQuotePart As clsBEQuotePart) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spQuotePartsDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateQuotePartsDetails")
                cmd.Parameters.AddWithValue("JobPartID", objBEQuotePart.JobPartID)
                cmd.Parameters.AddWithValue("PartNumber", objBEQuotePart.PartNumber)
                cmd.Parameters.AddWithValue("SellPrice", objBEQuotePart.SellPrice)
                cmd.Parameters.AddWithValue("UnitPrice", objBEQuotePart.UnitPrice)

                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateQuotePartsDetails")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
    End Class
End Namespace
