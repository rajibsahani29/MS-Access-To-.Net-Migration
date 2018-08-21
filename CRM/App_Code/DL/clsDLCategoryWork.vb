Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLCategoryWork
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddCateringWorkDetails(ByVal objBECategoryWork As clsBECategoryWork) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spCateringWorkDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddCateringWorkDetails")
                cmd.Parameters.AddWithValue("CateringId", objBECategoryWork.CateringId)
                cmd.Parameters.AddWithValue("Defects", objBECategoryWork.Defects)
                cmd.Parameters.AddWithValue("warnings", objBECategoryWork.warnings)
                cmd.Parameters.AddWithValue("Remedicals", objBECategoryWork.Remedicals)
                cmd.Parameters.AddWithValue("WorkDetails", objBECategoryWork.WorkDetails)
                Dim intCateringSafetyId As Integer = ExecuteNoneQueryByCommand(cmd, "AddCateringWorkDetails", "Y")
                Return intCateringSafetyId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function



        Public Function GetCateringWorkDetails(ByVal objBECategoryWork As clsBECategoryWork) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spCateringWorkDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetCateringWorkDetails")
                cmd.Parameters.AddWithValue("CateringId", objBECategoryWork.CateringId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetCateringWorkDetails")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBECategoryWork As clsBECategoryWork) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spCateringWorkDetails"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdateCateringWorkDetails")
                    cmd.Parameters.AddWithValue("CateringWorkId", objBECategoryWork.CateringWorkId)
                    cmd.Parameters.AddWithValue("Defects", objBECategoryWork.Defects)
                    cmd.Parameters.AddWithValue("warnings", objBECategoryWork.warnings)
                    cmd.Parameters.AddWithValue("Remedicals", objBECategoryWork.Remedicals)
                    cmd.Parameters.AddWithValue("WorkDetails", objBECategoryWork.WorkDetails)
                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeleteCateringWorkDetails")
                    cmd.Parameters.AddWithValue("CateringWorkId", objBECategoryWork.CateringWorkId)
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
