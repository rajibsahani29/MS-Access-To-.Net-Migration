Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLRequestParts
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddRequestedPart(ByVal objBERequestpart As clsBERequestpart) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFRequestPartDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddRequestedPart")
                cmd.Parameters.AddWithValue("JOBID", objBERequestpart.JOBID)
                cmd.Parameters.AddWithValue("Quantity", objBERequestpart.Quantity)
                cmd.Parameters.AddWithValue("PartID", objBERequestpart.PartID)
                cmd.Parameters.AddWithValue("SystemDatex", objBERequestpart.SystemDatex)
                cmd.Parameters.AddWithValue("EngineersNos", objBERequestpart.EngineersNos)
                cmd.Parameters.AddWithValue("deletex", objBERequestpart.deletex)

                Dim intInvoiceId As Integer = ExecuteNoneQueryByCommand(cmd, "AddRequestedPart", "Y")
                Return intInvoiceId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function



        Public Function AddRequestedPartOnPartOrder(ByVal objBERequestpart As clsBERequestpart) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFRequestPartDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddRequestedPartOnPartOrder")
                cmd.Parameters.AddWithValue("JOBID", objBERequestpart.JOBID)
                cmd.Parameters.AddWithValue("Quantity", objBERequestpart.Quantity)
                cmd.Parameters.AddWithValue("PartID", objBERequestpart.PartID)
                cmd.Parameters.AddWithValue("PartsOrderID", objBERequestpart.PartsOrderID)
                cmd.Parameters.AddWithValue("SystemDatex", objBERequestpart.SystemDatex)
                cmd.Parameters.AddWithValue("EngineersNos", objBERequestpart.EngineersNos)
                cmd.Parameters.AddWithValue("deletex", objBERequestpart.deletex)

                Dim intInvoiceId As Integer = ExecuteNoneQueryByCommand(cmd, "AddRequestedPartOnPartOrder", "Y")
                Return intInvoiceId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function UpdateRequestPartsForPartOrder(ByVal objBERequestpart As clsBERequestpart) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFRequestPartDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateRequestPartsForPartOrder")
                cmd.Parameters.AddWithValue("Notes", objBERequestpart.Notes)
                cmd.Parameters.AddWithValue("cost", objBERequestpart.cost)
                cmd.Parameters.AddWithValue("Quantity", objBERequestpart.Quantity)
                cmd.Parameters.AddWithValue("RequestID", objBERequestpart.RequestID)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateRequestPartsForPartOrder")
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function UpdateRequestPartsCostByID(ByVal objBERequestpart As clsBERequestpart) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFRequestPartDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateRequestPartsCostByID")
                cmd.Parameters.AddWithValue("cost", objBERequestpart.cost)
                cmd.Parameters.AddWithValue("RequestID", objBERequestpart.RequestID)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateRequestPartsCostByID")
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function UpdateRequestPartOrderId(ByVal objBERequestpart As clsBERequestpart) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFRequestPartDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateRequestPartOrderId")
                cmd.Parameters.AddWithValue("PartsOrderID", objBERequestpart.PartsOrderID)
                cmd.Parameters.AddWithValue("RequestID", objBERequestpart.RequestID)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateRequestPartOrderId")
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function



        Public Function AddPartAgainstPartsEditor(ByVal objBERequestpart As clsBERequestpart) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFRequestPartDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddPartAgainstPartsEditor")
                cmd.Parameters.AddWithValue("Quantity", objBERequestpart.Quantity)
                cmd.Parameters.AddWithValue("PartID", objBERequestpart.PartID)
                cmd.Parameters.AddWithValue("SystemDatex", objBERequestpart.SystemDatex)
                cmd.Parameters.AddWithValue("EngineersNos", objBERequestpart.EngineersNos)
                cmd.Parameters.AddWithValue("deletex", objBERequestpart.deletex)

                Dim intInvoiceId As Integer = ExecuteNoneQueryByCommand(cmd, "AddPartAgainstPartsEditor", "Y")
                Return intInvoiceId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetRequestedPartsOrderByJobID(ByVal objBERequestpart As clsBERequestpart) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFRequestPartDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetRequestedPartsOrderByJobID")
                cmd.Parameters.AddWithValue("JOBID", objBERequestpart.JOBID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetRequestedPartsOrderByJobID")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetRequestedPartsUsedByJobID(ByVal objBERequestpart As clsBERequestpart) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFRequestPartDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetRequestedPartsUsedByJobID")
                cmd.Parameters.AddWithValue("JOBID", objBERequestpart.JOBID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetRequestedPartsUsedByJobID")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBERequestpart As clsBERequestpart) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFRequestPartDetails"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdateRequestPartsByID")
                    cmd.Parameters.AddWithValue("RequestID", objBERequestpart.RequestID)
                    cmd.Parameters.AddWithValue("Notes", objBERequestpart.Notes)
                    cmd.Parameters.AddWithValue("EngineersNos", objBERequestpart.EngineersNos)
                    cmd.Parameters.AddWithValue("Quantity", objBERequestpart.Quantity)

                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeleteRequestPartsByID")
                    cmd.Parameters.AddWithValue("RequestID", objBERequestpart.RequestID)
                End If
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "PerformGridViewOpertaion")
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetPurchaseHistoryByPartID(ByVal objBERequestpart As clsBERequestpart) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFRequestPartDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPurchaseHistoryByPartID")
                cmd.Parameters.AddWithValue("PartID", objBERequestpart.PartID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPurchaseHistoryByPartID")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetCostByPartOrderId(ByVal objBERequestpart As clsBERequestpart) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFRequestPartDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetCostByPartOrderId")
                cmd.Parameters.AddWithValue("PartsOrderID", objBERequestpart.PartsOrderID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetCostByPartOrderId")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetStockRequestAginstPartIdToday(ByVal objBERequestpart As clsBERequestpart) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFRequestPartDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetStockRequestAginstPartIdToday")
                cmd.Parameters.AddWithValue("PartID", objBERequestpart.PartID)
                cmd.Parameters.AddWithValue("SystemDatex", objBERequestpart.SystemDatex)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetStockRequestAginstPartIdToday")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetPriceCheck() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFRequestPartDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPriceCheck")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPriceCheck")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetRequestedPartstoBookIn(ByVal objBERequestpart As clsBERequestpart) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFRequestPartDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetRequestedPartstoBookIn")
                cmd.Parameters.AddWithValue("PartsOrderID", objBERequestpart.PartsOrderID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetRequestedPartstoBookIn")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetRequestedPartsReceived(ByVal objBERequestpart As clsBERequestpart) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFRequestPartDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetRequestedPartsReceived")
                cmd.Parameters.AddWithValue("PartsOrderID", objBERequestpart.PartsOrderID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetRequestedPartsReceived")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetJobSheet(ByVal objBERequestpart As clsBERequestpart) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFRequestPartDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobSheet")
                cmd.Parameters.AddWithValue("PartsOrderID", objBERequestpart.PartsOrderID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobSheet")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function



        Public Function GetJobSheetDetailsByJobid(ByVal objBERequestpart As clsBERequestpart) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFRequestPartDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobSheetDetailsByJobid")
                cmd.Parameters.AddWithValue("JOBID", objBERequestpart.JOBID)
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



        Public Function PartDetailsByRequestID(ByVal objBERequestpart As clsBERequestpart) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFRequestPartDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "PartDetailsByRequestID")
                cmd.Parameters.AddWithValue("RequestID", objBERequestpart.RequestID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "PartDetailsByRequestID")
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
