Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLPartsReceived
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddPartsReceiveDetails(ByVal objBEPartReceive As clsBEPartsReceived) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsRecievedDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddPartsReceiveDetails")
                cmd.Parameters.AddWithValue("RequestID", objBEPartReceive.RequestID)
                cmd.Parameters.AddWithValue("DateRecieved", objBEPartReceive.DateRecieved)
                cmd.Parameters.AddWithValue("Quantity", objBEPartReceive.Quantity)
                cmd.Parameters.AddWithValue("Notes", objBEPartReceive.Notes)
                cmd.Parameters.AddWithValue("DEL", objBEPartReceive.DEL)

                Dim intPartReceiveId As Integer = ExecuteNoneQueryByCommand(cmd, "AddPartsReceiveDetails", "Y")
                Return intPartReceiveId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function DeletePartsReceiveDetailsByID(ByVal objBEPartReceive As clsBEPartsReceived) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsRecievedDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "DeletePartsReceiveDetailsByID")
                cmd.Parameters.AddWithValue("PartRecievedID", objBEPartReceive.PartRecievedID)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "DeletePartsReceiveDetailsByID")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
    End Class
End Namespace
