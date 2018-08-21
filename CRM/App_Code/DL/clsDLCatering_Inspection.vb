Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE

Namespace DL
    Public Class clsDLCatering_Inspection
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddCateringInspectionDetails(ByVal objBECateringIns As clsBECatering_Inspection) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spCateringInspectionDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddCateringInspectionDetails")
                cmd.Parameters.AddWithValue("CateringId", objBECateringIns.CateringId)
                cmd.Parameters.AddWithValue("Operating", objBECateringIns.Operating)
                cmd.Parameters.AddWithValue("Safety", objBECateringIns.Safety)
                cmd.Parameters.AddWithValue("Satisfactory", objBECateringIns.Satisfactory)
                cmd.Parameters.AddWithValue("Conditions", objBECateringIns.Conditions)
                cmd.Parameters.AddWithValue("Performances", objBECateringIns.Performances)
                cmd.Parameters.AddWithValue("Serviced", objBECateringIns.Serviced)
                cmd.Parameters.AddWithValue("SafeToUse", objBECateringIns.SafeToUse)


                Dim intCateringGasId As Integer = ExecuteNoneQueryByCommand(cmd, "AddCateringInspectionDetails", "Y")
                Return intCateringGasId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetCateringInspectionDetails(ByVal objBECateringIns As clsBECatering_Inspection) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spCateringInspectionDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetCateringInspectionDetails")
                cmd.Parameters.AddWithValue("CateringId", objBECateringIns.CateringId)
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


        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBECateringIns As clsBECatering_Inspection) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spCateringInspectionDetails"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdateCateringInspectionDetails")
                    cmd.Parameters.AddWithValue("CateringInspectionId", objBECateringIns.CateringInspectionId)
                    cmd.Parameters.AddWithValue("Operating", objBECateringIns.Operating)
                    cmd.Parameters.AddWithValue("Safety", objBECateringIns.Safety)
                    cmd.Parameters.AddWithValue("Satisfactory", objBECateringIns.Satisfactory)
                    cmd.Parameters.AddWithValue("Conditions", objBECateringIns.Conditions)
                    cmd.Parameters.AddWithValue("Performances", objBECateringIns.Performances)
                    cmd.Parameters.AddWithValue("Serviced", objBECateringIns.Serviced)
                    cmd.Parameters.AddWithValue("SafeToUse", objBECateringIns.SafeToUse)

                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeleteCateringInspectionDetails")
                    cmd.Parameters.AddWithValue("CateringInspectionId", objBECateringIns.CateringInspectionId)
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
