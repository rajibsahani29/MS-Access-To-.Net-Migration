Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLSupplier
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddFFSupplierDetails(ByVal objBESupplier As clsBESupplier) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spSupplierDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddFFSupplierDetails")
                cmd.Parameters.AddWithValue("SupplierName", objBESupplier.SupplierName)
                cmd.Parameters.AddWithValue("address1", objBESupplier.address1)
                cmd.Parameters.AddWithValue("Address2", objBESupplier.Address2)
                cmd.Parameters.AddWithValue("postcode", objBESupplier.postcode)
                cmd.Parameters.AddWithValue("Town", objBESupplier.Town)
                cmd.Parameters.AddWithValue("phone", objBESupplier.phone)
                cmd.Parameters.AddWithValue("Notes", objBESupplier.Notes)
                cmd.Parameters.AddWithValue("Email", objBESupplier.Email)

                Dim intId As Integer = ExecuteNoneQueryByCommand(cmd, "AddFFSupplierDetails", "Y")
                Return intId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function UpdateSupplierDetails(ByVal objBESupplier As clsBESupplier) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spSupplierDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateSupplierDetails")
                cmd.Parameters.AddWithValue("SupplierID", objBESupplier.SupplierID)
                cmd.Parameters.AddWithValue("SupplierName", objBESupplier.SupplierName)
                cmd.Parameters.AddWithValue("address1", objBESupplier.address1)
                cmd.Parameters.AddWithValue("Address2", objBESupplier.Address2)
                cmd.Parameters.AddWithValue("postcode", objBESupplier.postcode)
                cmd.Parameters.AddWithValue("Town", objBESupplier.Town)
                cmd.Parameters.AddWithValue("phone", objBESupplier.phone)
                cmd.Parameters.AddWithValue("Notes", objBESupplier.Notes)
                cmd.Parameters.AddWithValue("Email", objBESupplier.Email)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateSupplierDetails")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetSupplierName(ByVal objBESupplier As clsBESupplier) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spSupplierDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetSupplierName")
                cmd.Parameters.AddWithValue("SupplierName", objBESupplier.SupplierName)
                Dim intId As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "GetSupplierName")
                Return intId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function





        Public Function GetSupplierFillInDD() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spSupplierDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetSupplierFillInDD")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetSupplierFillInDD")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetSupplierDetailsById(ByVal objBESupplier As clsBESupplier) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spSupplierDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetSupplierDetailsById")
                cmd.Parameters.AddWithValue("SupplierID", objBESupplier.SupplierID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetSupplierDetailsById")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetSupplierList() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spSupplierDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetSupplierList")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetSupplierList")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetSupplierListByName(ByVal objBESupplier As clsBESupplier) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spSupplierDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetSupplierListByName")
                cmd.Parameters.AddWithValue("SupplierName", objBESupplier.SupplierName)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetSupplierListByName")
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
