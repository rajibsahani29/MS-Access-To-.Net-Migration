Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Public Class clsDLApplianceType
    Inherits BaseDB
    Dim objFunction As New clsCommon()

    Public Function AddApplianceTypeDetails(ByVal objBEApplianceType As clsBEApplianceType) As Integer
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandText = "FF_spApplianceTypeDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("Action", "AddApplianceTypeDetails")
            cmd.Parameters.AddWithValue("ApplianceType", objBEApplianceType.ApplianceType)
            cmd.Parameters.AddWithValue("DelFlag", objBEApplianceType.DelFlag)
            Dim intApplianceId As Integer = ExecuteNoneQueryByCommand(cmd, "AddApplianceTypeDetails", "Y")
            Return intApplianceId

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
        Return Nothing
    End Function


    Public Function GetApplianceTypeFillInDD() As DataSet
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandText = "FF_spApplianceTypeDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("Action", "GetApplianceTypeFillInDD")
            Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetApplianceTypeFillInDD")
            If objFunction.CheckDataSet(dstData) Then
                Return dstData
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
        Return Nothing
    End Function

    Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBEApplianceType As clsBEApplianceType) As Integer
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandText = "FF_spApplianceTypeDetails"
            cmd.CommandType = CommandType.StoredProcedure
            If strAction = "UPDATE" Then
                cmd.Parameters.AddWithValue("Action", "UpdateApplianceTypeDetails")
                cmd.Parameters.AddWithValue("ApplianceTypeID", objBEApplianceType.ApplianceTypeID)
                cmd.Parameters.AddWithValue("ApplianceType", objBEApplianceType.ApplianceType)
            ElseIf strAction = "DELETE" Then
                cmd.Parameters.AddWithValue("Action", "DeleteApplianceTypeDetails")
                cmd.Parameters.AddWithValue("ApplianceTypeID", objBEApplianceType.ApplianceTypeID)
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
