Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE

Namespace DL
    Public Class clsDLCateringAppliance
        Inherits BaseDB
        Dim objFunction As New clsCommon()

        Public Function AddCateringApplianceDetails(ByVal objBECateringApp As clsBECateringAppliance) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spCateringApplianceDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddCateringApplianceDetails")
                cmd.Parameters.AddWithValue("CateringId", objBECateringApp.CateringId)
                cmd.Parameters.AddWithValue("ApplianceType", objBECateringApp.ApplianceType)
                cmd.Parameters.AddWithValue("Model", objBECateringApp.Model)
                cmd.Parameters.AddWithValue("ApplianceMake", objBECateringApp.ApplianceMake)
                cmd.Parameters.AddWithValue("SerialNo", objBECateringApp.SerialNo)
                cmd.Parameters.AddWithValue("FlueType", objBECateringApp.FlueType)
                cmd.Parameters.AddWithValue("ApplianceSecure", objBECateringApp.ApplianceSecure)
                cmd.Parameters.AddWithValue("IsolationValve", objBECateringApp.IsolationValve)

                Dim intCateringGasId As Integer = ExecuteNoneQueryByCommand(cmd, "AddCateringApplianceDetails", "Y")
                Return intCateringGasId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function



        Public Function GetCateringApplianceDetails(ByVal objBECateringApp As clsBECateringAppliance) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spCateringApplianceDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetCateringApplianceDetails")
                cmd.Parameters.AddWithValue("CateringId", objBECateringApp.CateringId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetCateringApplianceDetails")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBECateringApp As clsBECateringAppliance) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spCateringApplianceDetails"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdateCateringApplianceDetails")
                    cmd.Parameters.AddWithValue("CateringAppId", objBECateringApp.CateringAppId)
                    cmd.Parameters.AddWithValue("ApplianceType", objBECateringApp.ApplianceType)
                    cmd.Parameters.AddWithValue("Model", objBECateringApp.Model)
                    cmd.Parameters.AddWithValue("ApplianceMake", objBECateringApp.ApplianceMake)
                    cmd.Parameters.AddWithValue("SerialNo", objBECateringApp.SerialNo)
                    cmd.Parameters.AddWithValue("FlueType", objBECateringApp.FlueType)
                    cmd.Parameters.AddWithValue("ApplianceSecure", objBECateringApp.ApplianceSecure)
                    cmd.Parameters.AddWithValue("IsolationValve", objBECateringApp.IsolationValve)
                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeleteCateringApplianceDetails")
                    cmd.Parameters.AddWithValue("CateringAppId", objBECateringApp.CateringAppId)
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
