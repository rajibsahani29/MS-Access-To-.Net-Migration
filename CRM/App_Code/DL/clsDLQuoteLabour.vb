Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLQuoteLabour
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddLabourQuoteDetails(ByVal objBEQuote As clsBEQuoteLabour) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spLabourQuoteDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddLabourQuoteDetails")
                cmd.Parameters.AddWithValue("Jobid", objBEQuote.JOBID)
                cmd.Parameters.AddWithValue("HoursCharged", objBEQuote.HoursCharged)
                cmd.Parameters.AddWithValue("HoursType", objBEQuote.HoursType)
                cmd.Parameters.AddWithValue("rate", objBEQuote.rate)
                cmd.Parameters.AddWithValue("Comment", objBEQuote.Comment)
                cmd.Parameters.AddWithValue("enquireID", objBEQuote.enquireID)

                Dim intClientId As Integer = ExecuteNoneQueryByCommand(cmd, "AddLabourQuoteDetails", "Y")
                Return intClientId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function UpdateLabourQuoteDetails(ByVal objBEQuote As clsBEQuoteLabour) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spLabourQuoteDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateLabourQuoteDetails")
                cmd.Parameters.AddWithValue("QuoteLabourID", objBEQuote.QuoteLabourID)
                cmd.Parameters.AddWithValue("HoursCharged", objBEQuote.HoursCharged)
                cmd.Parameters.AddWithValue("HoursType", objBEQuote.HoursType)
                cmd.Parameters.AddWithValue("rate", objBEQuote.rate)
                'cmd.Parameters.AddWithValue("Comment", objBEQuote.Comment)
                'cmd.Parameters.AddWithValue("enquireID", objBEQuote.enquireID)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateLabourQuoteDetails")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function DeleteLabourQuoteDetails(ByVal objBEQuote As clsBEQuoteLabour) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spLabourQuoteDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "DeleteLabourQuoteDetails")
                cmd.Parameters.AddWithValue("QuoteLabourID", objBEQuote.QuoteLabourID)
                'cmd.Parameters.AddWithValue("Comment", objBEQuote.Comment)
                'cmd.Parameters.AddWithValue("enquireID", objBEQuote.enquireID)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "DeleteLabourQuoteDetails")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetLabourQuoteByJOBID(ByVal objBELabour As clsBEQuoteLabour) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spLabourQuoteDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetLabourQuoteByJOBID")
                cmd.Parameters.AddWithValue("JOBID", objBELabour.JOBID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetLabourQuoteByJOBID")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetQuoteCostsByJobId(ByVal objBELabour As clsBEQuoteLabour) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spLabourQuoteDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetQuoteCostsByJobId")
                cmd.Parameters.AddWithValue("JOBID", objBELabour.JOBID)
                cmd.Parameters.AddWithValue("Type", objBELabour.Type)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetQuoteCostsByJobId")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetQuoteCostsForLabourByJobId(ByVal objBELabour As clsBEQuoteLabour) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spLabourQuoteDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetQuoteCostsForLabourByJobId")
                cmd.Parameters.AddWithValue("JOBID", objBELabour.JOBID)
                cmd.Parameters.AddWithValue("Type", objBELabour.Type)
                cmd.Parameters.AddWithValue("PID", objBELabour.PID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetQuoteCostsForLabourByJobId")
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
