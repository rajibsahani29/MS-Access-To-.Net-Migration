Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE

Namespace DL
    Public Class clsDLCallLists
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddInvestigationToQuote(ByVal objBECallList As clsBECallList) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFCallsListDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddInvestigationToQuote")
                cmd.Parameters.AddWithValue("JobID", objBECallList.JobID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "AddInvestigationToQuote")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function DeleteCallslistDetails(ByVal objBECallList As clsBECallList) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFCallsListDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "DeleteCallslistDetails")
                cmd.Parameters.AddWithValue("enquireID", objBECallList.enquireID)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "DeleteCallslistDetails")
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function AddCallListDetails(ByVal objBECallList As clsBECallList) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFCallsListDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddCallListDetails")
                cmd.Parameters.AddWithValue("JobID", objBECallList.JobID)
                cmd.Parameters.AddWithValue("ReportDate", objBECallList.ReportDate)
                cmd.Parameters.AddWithValue("ReportedAs", objBECallList.ReportedAs)
                cmd.Parameters.AddWithValue("PartID", objBECallList.PartID)
                cmd.Parameters.AddWithValue("Quantity", objBECallList.Quantity)
                cmd.Parameters.AddWithValue("WhatFor", objBECallList.WhatFor)
                cmd.Parameters.AddWithValue("StaffTakenBy", objBECallList.StaffTakenBy)
                cmd.Parameters.AddWithValue("StaffFor", objBECallList.StaffFor)
                cmd.Parameters.AddWithValue("Type", objBECallList.Type)
                cmd.Parameters.AddWithValue("Status", objBECallList.Status)
                cmd.Parameters.AddWithValue("AddToQuote", objBECallList.AddToQuote)

                Dim intId As Integer = ExecuteNoneQueryByCommand(cmd, "AddCallListDetails", "Y")
                Return intId
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetCalllistDetails(ByVal objBECallList As clsBECallList) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFCallsListDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetCalllistDetails")
                cmd.Parameters.AddWithValue("JobID", objBECallList.JobID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetCalllistDetails")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetCalllistByEnquiryId(ByVal objBECallList As clsBECallList) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spFFCallsListDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetCalllistByEnquiryId")
                cmd.Parameters.AddWithValue("enquireID", objBECallList.enquireID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetCalllistByEnquiryId")
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
