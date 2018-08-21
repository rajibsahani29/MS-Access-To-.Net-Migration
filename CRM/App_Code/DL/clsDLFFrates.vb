Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLFFrates
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddFFratesDetails(ByVal objBEFFrates As clsBEFFrates) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFratesDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddFFratesDetails")
                cmd.Parameters.AddWithValue("RateName", objBEFFrates.RateName)
                cmd.Parameters.AddWithValue("HourlyRate", objBEFFrates.HourlyRate)
                Dim intRateId As Integer = ExecuteNoneQueryByCommand(cmd, "AddFFratesDetails", "Y")
                Return intRateId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetFFratesFillInDD() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFratesDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetFFratesFillInDD")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetFFratesFillInDD")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetFFratesDetails() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFratesDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetFFratesDetails")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetFFratesDetails")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBEFFrates As clsBEFFrates) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFratesDetails"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdateFFratesDetails")
                    cmd.Parameters.AddWithValue("rateID", objBEFFrates.rateID)
                    cmd.Parameters.AddWithValue("RateName", objBEFFrates.RateName)
                    cmd.Parameters.AddWithValue("HourlyRate", objBEFFrates.HourlyRate)

                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeleteFFratesDetails")
                    cmd.Parameters.AddWithValue("rateID", objBEFFrates.rateID)
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
