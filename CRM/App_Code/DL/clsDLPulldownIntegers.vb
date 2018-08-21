Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLPulldownIntegers
        Inherits BaseDB
        Dim objFunction As New clsCommon()

        Public Function AddOrderDetails(ByVal objBEPulldownInt As clsBEPulldownIntegers) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPulldownIntegers"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddOrderDetails")
                cmd.Parameters.AddWithValue("Nos", objBEPulldownInt.Nos)
                Dim intClientId As Integer = ExecuteNoneQueryByCommand(cmd, "AddOrderDetails", "Y")
                Return intClientId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetPulldownIntegersFillInDD() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPulldownIntegers"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPulldownIntegersFillInDD")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPulldownIntegersFillInDD")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetPulldownQtyFillInDD() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPulldownIntegers"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPulldownQtyFillInDD")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPulldownQtyFillInDD")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetPulldownDaysFillInDD() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPulldownIntegers"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPulldownDaysFillInDD")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPulldownDaysFillInDD")
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
