Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLNextNumber
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function UpdateNextNumber(ByVal objBENextNumber As clsBENextNumber) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spNextNumber"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateNextNumber")
                cmd.Parameters.AddWithValue("NextNo", objBENextNumber.NextNo)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateNextNumber")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
    End Class
End Namespace
