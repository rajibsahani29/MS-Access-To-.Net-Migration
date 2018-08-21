Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE


Namespace DL
    Public Class clsDLToastUser
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddToastUserDetails(ByVal objBEToast As clsBEToastUser) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spToastUserDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddToastUserDetails")
                cmd.Parameters.AddWithValue("userid", objBEToast.userid)
                cmd.Parameters.AddWithValue("Engineer", objBEToast.Engineer)
                cmd.Parameters.AddWithValue("ClientName", objBEToast.ClientName)
                cmd.Parameters.AddWithValue("job_id", objBEToast.job_id)
                cmd.Parameters.AddWithValue("Whenx", objBEToast.Whenx)
                cmd.Parameters.AddWithValue("Flag", objBEToast.Flag)

                Dim intJobSheetId As Integer = ExecuteNoneQueryByCommand(cmd, "AddToastUserDetails", "Y")
                Return intJobSheetId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function



        Public Function GetToastUserDetails() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spToastUserDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetToastUserDetails")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetToastUserDetails")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function UpdateToastUserDetails(ByVal objBEToast As clsBEToastUser) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spToastUserDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateToastUserDetails")
                cmd.Parameters.AddWithValue("ToastId", objBEToast.ToastId)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateToastUserDetails")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function DeleteToastUserDetails() As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spToastUserDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "DeleteToastUserDetails")
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "DeleteToastUserDetails")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
    End Class
End Namespace

