Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLPartsFitted
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddPartFittedDetails(ByVal objBEPartsFitted As clsBEPartsFitted) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobSheetPartFittedDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddPartFittedDetails")
                cmd.Parameters.AddWithValue("JOBID", objBEPartsFitted.JOBID)
                cmd.Parameters.AddWithValue("qty", objBEPartsFitted.qty)
                cmd.Parameters.AddWithValue("ProductCode", objBEPartsFitted.ProductCode)
                cmd.Parameters.AddWithValue("Description", objBEPartsFitted.Description)
                cmd.Parameters.AddWithValue("Partprice", objBEPartsFitted.Partprice)
                Dim intId As Integer = ExecuteNoneQueryByCommand(cmd, "AddPartFittedDetails", "Y")
                Return intId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetPartFittedDetailsByJobId(ByVal objBEPartsFitted As clsBEPartsFitted) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobSheetPartFittedDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPartFittedDetailsByJobId")
                cmd.Parameters.AddWithValue("JOBID", objBEPartsFitted.JOBID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPartFittedDetailsByJobId")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBEPartsFitted As clsBEPartsFitted) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobSheetPartFittedDetails"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdateDetailsByID")
                    cmd.Parameters.AddWithValue("ID", objBEPartsFitted.ID)
                    cmd.Parameters.AddWithValue("ProductCode", objBEPartsFitted.ProductCode)
                    cmd.Parameters.AddWithValue("Description", objBEPartsFitted.Description)
                    cmd.Parameters.AddWithValue("qty", objBEPartsFitted.qty)
                    cmd.Parameters.AddWithValue("Partprice", objBEPartsFitted.Partprice)

                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeleteDetailsByID")
                    cmd.Parameters.AddWithValue("ID", objBEPartsFitted.ID)
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
