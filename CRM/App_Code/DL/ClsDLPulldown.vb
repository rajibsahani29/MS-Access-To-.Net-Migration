Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE

Namespace DL
    Public Class ClsDLPulldown
        Inherits BaseDB
        Dim objFunction As New clsCommon()

        Public Function AddPulldown(ByVal objBEPulldown As clsBEPulldown) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPulldown"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddPulldown")
                cmd.Parameters.AddWithValue("Lable", objBEPulldown.Lable)
                cmd.Parameters.AddWithValue("Group", objBEPulldown.Group)
                cmd.Parameters.AddWithValue("Display", objBEPulldown.Display)

                Dim intPulldownId As Integer = ExecuteNoneQueryByCommand(cmd, "AddPulldown", "Y")
                Return intPulldownId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetPulldownEngineerFillInDD(ByVal objBEPulldown As clsBEPulldown) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPulldown"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPulldownEngineerFillInDD")
                cmd.Parameters.AddWithValue("Group", objBEPulldown.Group)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetOrderDetailFillInDD")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBEPulldown As clsBEPulldown) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPulldown"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdatePulldown")
                    cmd.Parameters.AddWithValue("PullDownID", objBEPulldown.PullDownID)
                    cmd.Parameters.AddWithValue("Lable", objBEPulldown.Lable)
                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeletePulldown")
                    cmd.Parameters.AddWithValue("PullDownID", objBEPulldown.PullDownID)
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
