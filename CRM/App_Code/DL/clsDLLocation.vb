Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLLocation
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function GetLocationFillInDD() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFLocationDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetLocationFillInDD")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetLocationFillInDD")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetStockControlVanByLocation(ByVal objBELocation As clsBELocation) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFLocationDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetStockControlVanByLocation")
                cmd.Parameters.AddWithValue("LocationID", objBELocation.LocationID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetStockControlVanByLocation")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function



        Public Function GetLocationById(ByVal objBELocation As clsBELocation) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFLocationDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetLocationById")
                cmd.Parameters.AddWithValue("LocationID", objBELocation.LocationID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetLocationById")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetLocationDetails() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFLocationDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetLocationDetails")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetLocationDetails")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBELocation As clsBELocation) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFLocationDetails"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdateLocationDetails")
                    cmd.Parameters.AddWithValue("LocationID", objBELocation.LocationID)
                    cmd.Parameters.AddWithValue("LocationType", objBELocation.LocationType)
                    cmd.Parameters.AddWithValue("Location", objBELocation.Location)
                    cmd.Parameters.AddWithValue("Notes", objBELocation.Notes)
                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeleteLocationDetails")
                    cmd.Parameters.AddWithValue("LocationID", objBELocation.LocationID)
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