Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLPartsOrder
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddPartsOrderDetails(ByVal objBEPartsOrder As clsBEPartsOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsOrderDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddPartsOrderDetails")
                cmd.Parameters.AddWithValue("SupplierID", objBEPartsOrder.SupplierID)
                cmd.Parameters.AddWithValue("DateOrderCreated", objBEPartsOrder.DateOrderCreated)
                cmd.Parameters.AddWithValue("OrderNumber", objBEPartsOrder.OrderNumber)
                cmd.Parameters.AddWithValue("DeliveryCost", objBEPartsOrder.DeliveryCost)

                Dim intPartId As Integer = ExecuteNoneQueryByCommand(cmd, "AddPartsOrderDetails", "Y")
                Return intPartId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetMaxPartOrderID() As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsOrderDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetMaxPartOrderID")
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "GetMaxPartOrderID")
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetAllPartsOrderDetail() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsOrderDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetAllPartsOrderDetail")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetAllPartsOrderDetail")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetAllPartsOrderByAwaiting() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsOrderDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetAllPartsOrderByAwaiting")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetAllPartsOrderByAwaiting")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetPartsOrderDetailBySearch(ByVal strSearchByOrderNumber As String, ByVal strSearchByDescription As String, ByVal strSearchBySupplier As String) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsOrderDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPartsOrderDetailBySearch")
                cmd.Parameters.AddWithValue("SearchByOrderNo", strSearchByOrderNumber)
                cmd.Parameters.AddWithValue("SearchByFF", strSearchByDescription)
                cmd.Parameters.AddWithValue("SearchBySupplier", strSearchBySupplier)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPartsOrderDetailBySearch")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetPartsOrderDetailsByID(ByVal objBEPartsOrder As clsBEPartsOrder) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsOrderDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPartsOrderDetailsByID")
                cmd.Parameters.AddWithValue("PartsOrderID", objBEPartsOrder.PartsOrderID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPartsOrderDetailsByID")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function



        Public Function PartsOnOrder(ByVal objBEPartsOrder As clsBEPartsOrder) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsOrderDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "PartsOnOrder")
                cmd.Parameters.AddWithValue("OrderNumber", objBEPartsOrder.OrderNumber)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "PartsOnOrder")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function PartsToBeOrder() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsOrderDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "PartsToBeOrder")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "PartsToBeOrder")
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
