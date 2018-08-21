Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class ClsDLStatusHistory
        Inherits BaseDB
        Dim objFunction As New clsCommon()

        Public Function AddStatusHistory(ByVal objBEStatusHistory As ClsBEStatusHistory) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spStatusHistoryDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddStatusHistory")
                cmd.Parameters.AddWithValue("JOBID", objBEStatusHistory.JOBID)
                cmd.Parameters.AddWithValue("From", objBEStatusHistory.From)
                cmd.Parameters.AddWithValue("ToStatus", objBEStatusHistory.ToStatus)
                cmd.Parameters.AddWithValue("TodayDate", objBEStatusHistory.TodayDate)
                cmd.Parameters.AddWithValue("Notes", objBEStatusHistory.Notes)

                Dim intInvoiceId As Integer = ExecuteNoneQueryByCommand(cmd, "AddStatusHistory", "Y")
                Return intInvoiceId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
    End Class
End Namespace
