Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLPartPrices
        Inherits BaseDB
        Dim objFunction As New clsCommon()

        Public Function GetPriceDetailsByPartID(ByVal objBEPartsPrice As clsBEPartPrices) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsPricesDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPriceDetailsByPartID")
                cmd.Parameters.AddWithValue("PartID", objBEPartsPrice.PartID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPriceDetailsByPartID")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function UpdatePartsPriceDetails(ByVal objBEPartsPrice As clsBEPartPrices) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsPricesDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdatePartsPriceDetails")
                cmd.Parameters.AddWithValue("PartID", objBEPartsPrice.PartID)
                cmd.Parameters.AddWithValue("DeliveryCost", objBEPartsPrice.DeliveryCost)


                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdatePartsPriceDetails")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBEPartsPrice As clsBEPartPrices) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsPricesDetails"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdatPartsPricesByID")
                    cmd.Parameters.AddWithValue("Notes", objBEPartsPrice.Notes)
                    cmd.Parameters.AddWithValue("Price", objBEPartsPrice.Price)
                    cmd.Parameters.AddWithValue("SupplierID", objBEPartsPrice.SupplierID)
                    cmd.Parameters.AddWithValue("PartPriceID", objBEPartsPrice.PartPriceID)
                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeletePartsPrices")
                    cmd.Parameters.AddWithValue("PartPriceID", objBEPartsPrice.PartPriceID)
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
