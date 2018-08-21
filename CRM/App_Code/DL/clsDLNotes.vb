Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLNotes
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddJobNotesDetails(ByVal objBENotes As clsBENotes) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobNotesDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddJobNotesDetails")
                cmd.Parameters.AddWithValue("JOBID", objBENotes.JOBID)
                cmd.Parameters.AddWithValue("Notes", objBENotes.Notes)
                cmd.Parameters.AddWithValue("NoteDate", objBENotes.NoteDate)
                cmd.Parameters.AddWithValue("RecordedByPC", objBENotes.RecordedByPC)
                cmd.Parameters.AddWithValue("RecordedByUser", objBENotes.RecordedByUser)
                Dim intPartId As Integer = ExecuteNoneQueryByCommand(cmd, "AddJobNotesDetails", "Y")
                Return intPartId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetJobNotesToday(ByVal objBENotes As clsBENotes) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobNotesDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobNotesToday")
                cmd.Parameters.AddWithValue("JOBID", objBENotes.JOBID)
                cmd.Parameters.AddWithValue("NoteDate", objBENotes.NoteDate)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobNotesToday")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetJobNotesDetails(ByVal objBENotes As clsBENotes) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobNotesDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobNotesDetails")
                cmd.Parameters.AddWithValue("JOBID", objBENotes.JOBID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobNotesDetails")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBENotes As clsBENotes) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobNotesDetails"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdateJobNotesDetails")
                    cmd.Parameters.AddWithValue("JobNotesID", objBENotes.JobNotesID)
                    cmd.Parameters.AddWithValue("Notes", objBENotes.Notes)

                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeleteJobNotesDetails")
                    cmd.Parameters.AddWithValue("JobNotesID", objBENotes.JobNotesID)
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
