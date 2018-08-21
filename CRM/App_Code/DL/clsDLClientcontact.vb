Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLClientcontact
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddClientContactDetails(ByVal objBEClientContact As clsBEClientcontact) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientContactDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddClientContactDetails")
                cmd.Parameters.AddWithValue("ClientId", objBEClientContact.ClientId)
                cmd.Parameters.AddWithValue("Forename", objBEClientContact.Forename)
                cmd.Parameters.AddWithValue("Surname", objBEClientContact.Surname)
                cmd.Parameters.AddWithValue("Email", objBEClientContact.Email)
                cmd.Parameters.AddWithValue("DirectLine", objBEClientContact.DirectLine)
                cmd.Parameters.AddWithValue("Notes", objBEClientContact.Notes)

                Dim intClientId As Integer = ExecuteNoneQueryByCommand(cmd, "AddClientContactDetails", "Y")
                Return intClientId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetClientContactByClientId(ByVal objBEClientContact As clsBEClientcontact) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientContactDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetClientContactByClientId")
                cmd.Parameters.AddWithValue("ClientId", objBEClientContact.ClientId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetClientContactByClientId")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetClientContactEmail(ByVal objBEClientContact As clsBEClientcontact) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientContactDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetClientContactEmail")
                cmd.Parameters.AddWithValue("ClientId", objBEClientContact.ClientId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetClientContactEmail")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBEClientcontact As clsBEClientcontact) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientContactDetails"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdateClientContactDetails")
                    cmd.Parameters.AddWithValue("ClientContactId", objBEClientcontact.ClientContactId)
                    cmd.Parameters.AddWithValue("Forename", objBEClientcontact.Forename)
                    cmd.Parameters.AddWithValue("Surname", objBEClientcontact.Surname)
                    cmd.Parameters.AddWithValue("Notes", objBEClientcontact.Notes)
                    cmd.Parameters.AddWithValue("DirectLine", objBEClientcontact.DirectLine)
                    cmd.Parameters.AddWithValue("Email", objBEClientcontact.Email)

                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeleteClientContactDetails")
                    cmd.Parameters.AddWithValue("ClientContactId", objBEClientcontact.ClientContactId)
                End If
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "PerformGridViewOpertaion")
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetClientEmailFillinDD(ByVal objBEClientContact As clsBEClientcontact) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientContactDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetClientEmailFillinDD")
                cmd.Parameters.AddWithValue("ClientId", objBEClientContact.ClientId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetClientEmailFillinDD")
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
