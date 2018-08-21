Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE

Namespace DL
    Public Class ClsDLClientRate
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddFFClientratesDetails(ByVal objBEFFClientrates As ClsBEClientRate) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFClientratesDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddFFClientratesDetails")
                cmd.Parameters.AddWithValue("ClientId", objBEFFClientrates.ClientId)
                cmd.Parameters.AddWithValue("rateID", objBEFFClientrates.rateID)
                Dim intRateId As Integer = ExecuteNoneQueryByCommand(cmd, "AddFFClientratesDetails", "Y")
                Return intRateId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetFFClientratesDetails(ByVal objBEFFClientrates As ClsBEClientRate) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFClientratesDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetFFClientratesDetails")
                cmd.Parameters.AddWithValue("ClientId", objBEFFClientrates.ClientId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetFFClientratesDetails")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetFFratesDetailsByClientId(ByVal objBEFFClientrates As ClsBEClientRate) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFClientratesDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetFFratesDetailsByClientId")
                cmd.Parameters.AddWithValue("ClientId", objBEFFClientrates.ClientId)
                cmd.Parameters.AddWithValue("rateID", objBEFFClientrates.rateID)
                Dim intId As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "GetFFratesDetailsByClientId")
                Return intId
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function DeleteFFClientratesDetails(ByVal objBEFFClientrates As ClsBEClientRate) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFClientratesDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "DeleteFFClientratesDetails")
                cmd.Parameters.AddWithValue("Id", objBEFFClientrates.Id)
                Dim intId As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "DeleteFFClientratesDetails")
                Return intId
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
    End Class
End Namespace
