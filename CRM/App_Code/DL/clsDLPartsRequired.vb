Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLPartsRequired
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddPartRequiredDetails(ByVal objBEPartRequired As clsBEPartRequired) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobSheetPartRequiredDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddPartRequiredDetails")
                cmd.Parameters.AddWithValue("JOBID", objBEPartRequired.JOBID)
                cmd.Parameters.AddWithValue("Quantity", objBEPartRequired.Quantity)
                cmd.Parameters.AddWithValue("PartDetail", objBEPartRequired.PartDetail)
                Dim intId As Integer = ExecuteNoneQueryByCommand(cmd, "AddPartRequiredDetails", "Y")
                Return intId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetPartRequiredDetailsByJobId(ByVal objBEPartRequired As clsBEPartRequired) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobSheetPartRequiredDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPartRequiredDetailsByJobId")
                cmd.Parameters.AddWithValue("JOBID", objBEPartRequired.JOBID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPartRequiredDetailsByJobId")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBEPartRequired As clsBEPartRequired) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobSheetPartRequiredDetails"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdateDetailsByID")
                    cmd.Parameters.AddWithValue("ID", objBEPartRequired.ID)
                    cmd.Parameters.AddWithValue("PartDetail", objBEPartRequired.PartDetail)
                    cmd.Parameters.AddWithValue("Quantity", objBEPartRequired.Quantity)

                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeleteDetailsByID")
                    cmd.Parameters.AddWithValue("ID", objBEPartRequired.ID)
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
