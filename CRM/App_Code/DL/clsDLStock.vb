Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLStock
        Inherits BaseDB
        Dim objFunction As New clsCommon()

        Public Function AddStockDetails(ByVal objBEStock As clsBEStock) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_sptblStockAdjustments"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddStockDetails")
                cmd.Parameters.AddWithValue("LocationID", objBEStock.LocationID)
                cmd.Parameters.AddWithValue("StockDate", objBEStock.StockDate)
                cmd.Parameters.AddWithValue("PartID", objBEStock.PartID)
                cmd.Parameters.AddWithValue("DepositAmount", objBEStock.DepositAmount)
                cmd.Parameters.AddWithValue("WithdrawalAmount", objBEStock.WithdrawalAmount)
                cmd.Parameters.AddWithValue("JOBID", objBEStock.JOBID)
                cmd.Parameters.AddWithValue("EngineersNumber", objBEStock.EngineersNumber)

                Dim intInvoiceId As Integer = ExecuteNoneQueryByCommand(cmd, "AddStockDetails", "Y")
                Return intInvoiceId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function



        Public Function AddStockTransferDetails(ByVal objBEStock As clsBEStock) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_sptblStockAdjustments"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddStockTransferDetails")
                cmd.Parameters.AddWithValue("LocationID", objBEStock.LocationID)
                cmd.Parameters.AddWithValue("StockDate", objBEStock.StockDate)
                cmd.Parameters.AddWithValue("PartID", objBEStock.PartID)
                cmd.Parameters.AddWithValue("DepositAmount", objBEStock.DepositAmount)
                cmd.Parameters.AddWithValue("WithdrawalAmount", objBEStock.WithdrawalAmount)


                Dim intInvoiceId As Integer = ExecuteNoneQueryByCommand(cmd, "AddStockTransferDetails", "Y")
                Return intInvoiceId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetStockDetailsByJobID(ByVal objBEStock As clsBEStock) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_sptblStockAdjustments"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetStockDetailsByJobID")
                cmd.Parameters.AddWithValue("JOBID", objBEStock.JOBID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetStockDetailsByJobID")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetStockDetailsByPartIdToday(ByVal objBEStock As clsBEStock) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_sptblStockAdjustments"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetStockDetailsByPartIdToday")
                cmd.Parameters.AddWithValue("PartID", objBEStock.PartID)
                cmd.Parameters.AddWithValue("StockDate", objBEStock.StockDate)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetStockDetailsByPartIdToday")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetStockDetailsByPartId(ByVal objBEStock As clsBEStock) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_sptblStockAdjustments"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetStockDetailsByPartId")
                cmd.Parameters.AddWithValue("PartID", objBEStock.PartID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetStockDetailsByPartId")
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
