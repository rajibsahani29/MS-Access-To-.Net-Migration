Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLJobGasPart
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddJobsGasPart2Details(ByVal objBEGasPart As clsBEJobGasPart) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobsGasPart2Details"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddJobsGasPart2Details")
                cmd.Parameters.AddWithValue("InspectionId", objBEGasPart.InspectionId)
                cmd.Parameters.AddWithValue("ApplianceType", objBEGasPart.ApplianceType)
                cmd.Parameters.AddWithValue("ApplianceMake", objBEGasPart.ApplianceMake)
                cmd.Parameters.AddWithValue("Model", objBEGasPart.Model)
                cmd.Parameters.AddWithValue("Manufacturer", objBEGasPart.Manufacturer)
                cmd.Parameters.AddWithValue("Pressure", objBEGasPart.Pressure)
                cmd.Parameters.AddWithValue("HeatInput", objBEGasPart.HeatInput)
                cmd.Parameters.AddWithValue("MaxCO", objBEGasPart.MaxCO)
                cmd.Parameters.AddWithValue("MaxCO2", objBEGasPart.MaxCO2)
                cmd.Parameters.AddWithValue("IsolationValve", objBEGasPart.IsolationValve)
                cmd.Parameters.AddWithValue("FittedStatus", objBEGasPart.FittedStatus)
                cmd.Parameters.AddWithValue("Isolator", objBEGasPart.Isolator)
                cmd.Parameters.AddWithValue("FSDFitted", objBEGasPart.FSDFitted)
                cmd.Parameters.AddWithValue("FSDOperating", objBEGasPart.FSDOperating)
                cmd.Parameters.AddWithValue("Pipework", objBEGasPart.Pipework)
                cmd.Parameters.AddWithValue("Safety", objBEGasPart.Safety)
                cmd.Parameters.AddWithValue("Defects", objBEGasPart.Defects)
                cmd.Parameters.AddWithValue("warning", objBEGasPart.Warning)
                cmd.Parameters.AddWithValue("Remedical", objBEGasPart.Remedical)
                cmd.Parameters.AddWithValue("Details", objBEGasPart.Details)


                Dim intJobsGasPartId As Integer = ExecuteNoneQueryByCommand(cmd, "AddJobsGasPart2Details", "Y")
                Return intJobsGasPartId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetJobsGasPart2DetailsById(ByVal objBEGasPart As clsBEJobGasPart) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobsGasPart2Details"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobsGasPart2DetailsById")
                cmd.Parameters.AddWithValue("InspectionId", objBEGasPart.InspectionId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobsGasPart2DetailsById")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBEGasPart As clsBEJobGasPart) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobsGasPart2Details"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdateDetailsByID")
                    cmd.Parameters.AddWithValue("JobGasPartId", objBEGasPart.JobGasPartId)
                    cmd.Parameters.AddWithValue("ApplianceType", objBEGasPart.ApplianceType)
                    cmd.Parameters.AddWithValue("ApplianceMake", objBEGasPart.ApplianceMake)
                    cmd.Parameters.AddWithValue("Model", objBEGasPart.Model)

                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeleteDetailsByID")
                    cmd.Parameters.AddWithValue("JobGasPartId", objBEGasPart.JobGasPartId)
                End If
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "PerformGridViewOpertaion")
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function PerformGridViewOpertaionEdit(ByVal strAction As String, ByVal objBEGasPart As clsBEJobGasPart) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobsGasPart2Details"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdateDetailsJobPart2Edit")
                    cmd.Parameters.AddWithValue("JobGasPartId", objBEGasPart.JobGasPartId)
                    cmd.Parameters.AddWithValue("Defects", objBEGasPart.Defects)
                    cmd.Parameters.AddWithValue("Warning", objBEGasPart.Warning)
                    cmd.Parameters.AddWithValue("Remedical", objBEGasPart.Remedical)
                    cmd.Parameters.AddWithValue("Details", objBEGasPart.Details)

                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeleteDetailsByID")
                    cmd.Parameters.AddWithValue("JobGasPartId", objBEGasPart.JobGasPartId)
                End If
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "PerformGridViewOpertaion")
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function PerformGridViewOpertaionEditGrid1(ByVal strAction As String, ByVal objBEGasPart As clsBEJobGasPart) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobsGasPart2Details"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdateDetailsJobPart2EditGrid1")
                    cmd.Parameters.AddWithValue("JobGasPartId", objBEGasPart.JobGasPartId)
                    cmd.Parameters.AddWithValue("ApplianceType", objBEGasPart.ApplianceType)
                    cmd.Parameters.AddWithValue("ApplianceMake", objBEGasPart.ApplianceMake)
                    cmd.Parameters.AddWithValue("Model", objBEGasPart.Model)
                    cmd.Parameters.AddWithValue("Manufacturer", objBEGasPart.Manufacturer)
                    cmd.Parameters.AddWithValue("Pressure", objBEGasPart.Pressure)
                    cmd.Parameters.AddWithValue("HeatInput", objBEGasPart.HeatInput)
                    cmd.Parameters.AddWithValue("MaxCO", objBEGasPart.MaxCO)
                    cmd.Parameters.AddWithValue("MaxCO2", objBEGasPart.MaxCO2)
                    cmd.Parameters.AddWithValue("IsolationValve", objBEGasPart.IsolationValve)
                    cmd.Parameters.AddWithValue("FittedStatus", objBEGasPart.FittedStatus)
                    cmd.Parameters.AddWithValue("Isolator", objBEGasPart.Isolator)
                    cmd.Parameters.AddWithValue("FSDFitted", objBEGasPart.FSDFitted)
                    cmd.Parameters.AddWithValue("FSDOperating", objBEGasPart.FSDOperating)
                    cmd.Parameters.AddWithValue("Pipework", objBEGasPart.Pipework)
                    cmd.Parameters.AddWithValue("Safety", objBEGasPart.Safety)

                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeleteDetailsByID")
                    cmd.Parameters.AddWithValue("JobGasPartId", objBEGasPart.JobGasPartId)
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
