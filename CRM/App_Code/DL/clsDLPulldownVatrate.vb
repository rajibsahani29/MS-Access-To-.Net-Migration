Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLPulldownVatrate
        Inherits BaseDB
        Dim objFunction As New clsCommon()

        Public Function AddPulldownVatRate(ByVal objBEPulldownVat As ClsBEPulldownVatrate) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPullDownVatRatesDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddPulldownVatRate")
                cmd.Parameters.AddWithValue("VATRATE", objBEPulldownVat.VATRATE)
                Dim intPulldownId As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "AddPulldownVatRate")
                Return intPulldownId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetPullDownVatRatesFillInDD() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPullDownVatRatesDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPullDownVatRatesFillInDD")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPullDownVatRatesFillInDD")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBEPulldownVat As ClsBEPulldownVatrate) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPullDownVatRatesDetails"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdatePulldownVatRate")
                    cmd.Parameters.AddWithValue("VATRATEP", objBEPulldownVat.VATRATEP)
                    cmd.Parameters.AddWithValue("VATRATE", objBEPulldownVat.VATRATE)

                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeletePulldownVatRate")
                    cmd.Parameters.AddWithValue("VATRATE", objBEPulldownVat.VATRATE)
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
