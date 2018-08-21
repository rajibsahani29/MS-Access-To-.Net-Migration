Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE

Namespace DL
    Public Class clsDLCateringSafety
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddCateringSafetyDetails(ByVal objBECateringSafe As clsBECateringSafety) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spCateringSafetyDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddCateringSafetyDetails")
                cmd.Parameters.AddWithValue("CateringId", objBECateringSafe.CateringId)
                cmd.Parameters.AddWithValue("Exstinguisher", objBECateringSafe.Exstinguisher)
                cmd.Parameters.AddWithValue("Blanket", objBECateringSafe.Blanket)
                cmd.Parameters.AddWithValue("CurrentSafety", objBECateringSafe.CurrentSafety)
                cmd.Parameters.AddWithValue("LPGSafety", objBECateringSafe.LPGSafety)
                Dim intCateringSafetyId As Integer = ExecuteNoneQueryByCommand(cmd, "AddCateringSafetyDetails", "Y")
                Return intCateringSafetyId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function



        Public Function GetCateringSafetyDetails(ByVal objBECateringSafe As clsBECateringSafety) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spCateringSafetyDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetCateringSafetyDetails")
                cmd.Parameters.AddWithValue("CateringId", objBECateringSafe.CateringId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetCateringSafetyDetails")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBECateringSafe As clsBECateringSafety) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spCateringSafetyDetails"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdateCateringSafetyDetails")
                    cmd.Parameters.AddWithValue("CateringSafetyId", objBECateringSafe.CateringSafetyId)
                    cmd.Parameters.AddWithValue("Exstinguisher", objBECateringSafe.Exstinguisher)
                    cmd.Parameters.AddWithValue("Blanket", objBECateringSafe.Blanket)
                    cmd.Parameters.AddWithValue("CurrentSafety", objBECateringSafe.CurrentSafety)
                    cmd.Parameters.AddWithValue("LPGSafety", objBECateringSafe.LPGSafety)
                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeleteCateringSafetyDetails")
                    cmd.Parameters.AddWithValue("CateringSafetyId", objBECateringSafe.CateringSafetyId)
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
