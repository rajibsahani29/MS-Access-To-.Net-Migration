Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE

Namespace DL
    Public Class clsDLJobVisit
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        ''' <summary>
        ''' This function is used to add Job Visit details.
        ''' </summary>
        Public Function AddVisitHistory(ByVal objBEJobVisit As clsBEJobVisit) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobVisitHistory"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddVisitHistory")
                cmd.Parameters.AddWithValue("Jobid", objBEJobVisit.Jobid)
                cmd.Parameters.AddWithValue("EngineerFrom", objBEJobVisit.EngineerFrom)
                cmd.Parameters.AddWithValue("EngineerTo", objBEJobVisit.EngineerTo)
                cmd.Parameters.AddWithValue("IssueType", objBEJobVisit.IssueType)
                cmd.Parameters.AddWithValue("IssueDate", objBEJobVisit.IssueDate)
                cmd.Parameters.AddWithValue("HoursSpent", objBEJobVisit.HoursSpent)
                cmd.Parameters.AddWithValue("IssueNotes", objBEJobVisit.IssueNotes)

                Dim intClientId As Integer = ExecuteNoneQueryByCommand(cmd, "AddVisitHistory", "Y")
                Return intClientId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        ''' <summary>
        ''' This function is used to update Job Visit details.
        ''' </summary>
        Public Function UpdateOrderDetails(ByVal objBEOrder As clsBEOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobVisitHistory"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateOrderDetails")
                cmd.Parameters.AddWithValue("JOBID", objBEOrder.JOBID)
                'cmd.Parameters.AddWithValue("ID", objBEOrder.ID)
                'cmd.Parameters.AddWithValue("OrderTakenBy", objBEOrder.OrderTakenBy)
                cmd.Parameters.AddWithValue("Status", objBEOrder.Status)
                'cmd.Parameters.AddWithValue("EntryDate", objBEOrder.EntryDate)
                cmd.Parameters.AddWithValue("EnquiryDate", objBEOrder.EnquiryDate)
                cmd.Parameters.AddWithValue("Engineer", objBEOrder.Engineer)



                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateOrderDetails")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetJobAllocationByJobID(ByVal objBEJobvisit As clsBEJobVisit) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobVisitHistory"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobAllocationByJobID")
                cmd.Parameters.AddWithValue("JOBID", objBEJobvisit.Jobid)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobAllocationByJobID")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBEJobvisit As clsBEJobVisit) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobVisitHistory"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdateVisitHistory")
                    cmd.Parameters.AddWithValue("VisitHistoryID", objBEJobvisit.VisitHistoryID)
                    cmd.Parameters.AddWithValue("IssueDate", objBEJobvisit.IssueDate)
                    cmd.Parameters.AddWithValue("HoursSpent", objBEJobvisit.HoursSpent)
                    cmd.Parameters.AddWithValue("IssueType", objBEJobvisit.IssueType)
                    cmd.Parameters.AddWithValue("IssueNotes", objBEJobvisit.IssueNotes)

                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeleteVisitHistory")
                    cmd.Parameters.AddWithValue("VisitHistoryID", objBEJobvisit.VisitHistoryID)
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
