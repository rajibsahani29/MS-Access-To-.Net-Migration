Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE

Namespace DL

    Public Class clsDLNextPONumber
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function UpdateNextPONumber(ByVal objBENextPONumber As clsBENextPONumber) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spNextPONumber"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateNextPONumber")
                cmd.Parameters.AddWithValue("NextNo", objBENextPONumber.NextNo)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateNextPONumber")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetPONumber() As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spNextPONumber"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPONumber")
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "GetPONumber")
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
    End Class
End Namespace
