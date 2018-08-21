Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE

Namespace DL
    Public Class clsDLGasInspection
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddJobsGasDetails(ByVal objBEGas As clsBEGasInspection) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobsGasDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddJobsGasDetails")
                'cmd.Parameters.AddWithValue("InspectionId", objBEGas.InspectionId)
                cmd.Parameters.AddWithValue("clientId", objBEGas.ClientId)
                cmd.Parameters.AddWithValue("EngineerId", objBEGas.EngineerId)
                cmd.Parameters.AddWithValue("JobId", objBEGas.JobId)
                cmd.Parameters.AddWithValue("satisfactory", objBEGas.satisfactory)
                cmd.Parameters.AddWithValue("Accesible", objBEGas.Accesible)
                cmd.Parameters.AddWithValue("suitable", objBEGas.suitable)
                cmd.Parameters.AddWithValue("valve", objBEGas.valve)
                cmd.Parameters.AddWithValue("Direction", objBEGas.Direction)
                cmd.Parameters.AddWithValue("Emergency", objBEGas.Emergency)
                cmd.Parameters.AddWithValue("autopressure", objBEGas.autopressure)
                cmd.Parameters.AddWithValue("flameguard", objBEGas.flameguard)
                cmd.Parameters.AddWithValue("manual", objBEGas.manual)
                cmd.Parameters.AddWithValue("warning", objBEGas.warning)
                cmd.Parameters.AddWithValue("PrimarySafety", objBEGas.PrimarySafety)
                cmd.Parameters.AddWithValue("PrimaryInterlock", objBEGas.PrimaryInterlock)
                cmd.Parameters.AddWithValue("SecondaryInterlock", objBEGas.SecondaryInterlock)
                cmd.Parameters.AddWithValue("PrimarySatisfactory", objBEGas.PrimarySatisfactory)
                cmd.Parameters.AddWithValue("SecondarySatisfactory", objBEGas.SecondarySatisfactory)
                cmd.Parameters.AddWithValue("manuallyOveridden", objBEGas.manuallyOveridden)
                cmd.Parameters.AddWithValue("Apparant", objBEGas.Apparant)
                cmd.Parameters.AddWithValue("Evidenceventilation", objBEGas.Evidenceventilation)
                cmd.Parameters.AddWithValue("Unsatisfactory", objBEGas.Unsatisfactory)
                cmd.Parameters.AddWithValue("signventilation", objBEGas.signventilation)
                cmd.Parameters.AddWithValue("volume", objBEGas.volume)
                cmd.Parameters.AddWithValue("Evidencesystems", objBEGas.Evidencesystems)
                cmd.Parameters.AddWithValue("SignMaintenance", objBEGas.SignMaintenance)
                cmd.Parameters.AddWithValue("Extensive", objBEGas.Extensive)
                cmd.Parameters.AddWithValue("Aging", objBEGas.Aging)
                cmd.Parameters.AddWithValue("Fitted", objBEGas.Fitted)
                cmd.Parameters.AddWithValue("TotalScore", objBEGas.TotalScore)
                cmd.Parameters.AddWithValue("ReceiveDate", objBEGas.ReceiveDate)
                cmd.Parameters.AddWithValue("CorrectMatterials", objBEGas.CorrectMatterials)
                cmd.Parameters.AddWithValue("Identified", objBEGas.Identified)
                cmd.Parameters.AddWithValue("Pipework", objBEGas.Pipework)
                cmd.Parameters.AddWithValue("sleeves", objBEGas.sleeves)
                cmd.Parameters.AddWithValue("SuitablePurge", objBEGas.SuitablePurge)
                cmd.Parameters.AddWithValue("AdditinalIsolation", objBEGas.AdditinalIsolation)
                cmd.Parameters.AddWithValue("Electrical", objBEGas.Electrical)
                cmd.Parameters.AddWithValue("Protective", objBEGas.Protective)
                cmd.Parameters.AddWithValue("appropiate", objBEGas.appropiate)
                cmd.Parameters.AddWithValue("CanopySystem", objBEGas.CanopySystem)
                cmd.Parameters.AddWithValue("Overhang", objBEGas.Overhang)
                cmd.Parameters.AddWithValue("Type", objBEGas.Type)
                cmd.Parameters.AddWithValue("filterSatisfactory", objBEGas.filterSatisfactory)
                cmd.Parameters.AddWithValue("mechanically", objBEGas.mechanically)
                cmd.Parameters.AddWithValue("naturally", objBEGas.naturally)
                cmd.Parameters.AddWithValue("both", objBEGas.both)
                cmd.Parameters.AddWithValue("MechVentilation", objBEGas.MechVentilation)
                cmd.Parameters.AddWithValue("SatisfatoryVentilation", objBEGas.SatisfatoryVentilation)
                cmd.Parameters.AddWithValue("adequate", objBEGas.adequate)
                cmd.Parameters.AddWithValue("High", objBEGas.High)
                cmd.Parameters.AddWithValue("low", objBEGas.low)
                cmd.Parameters.AddWithValue("COdetect", objBEGas.COdetect)
                cmd.Parameters.AddWithValue("CO2detect", objBEGas.CO2detect)
                cmd.Parameters.AddWithValue("CO2recorded", objBEGas.CO2recorded)
                cmd.Parameters.AddWithValue("detectionInterlock", objBEGas.detectionInterlock)
                cmd.Parameters.AddWithValue("center", objBEGas.center)
                cmd.Parameters.AddWithValue("Model1", objBEGas.Model1)
                cmd.Parameters.AddWithValue("Model2", objBEGas.Model2)
                cmd.Parameters.AddWithValue("CollabrationDate1", objBEGas.CollabrationDate1)
                cmd.Parameters.AddWithValue("CollabrationDate2", objBEGas.CollabrationDate2)
                cmd.Parameters.AddWithValue("ReceivedBy", objBEGas.ReceivedBy)
                cmd.Parameters.AddWithValue("PrintName", objBEGas.PrintName)
                cmd.Parameters.AddWithValue("IssuedBy", objBEGas.IssuedBy)
                cmd.Parameters.AddWithValue("IdcardNo", objBEGas.IdcardNo)
                cmd.Parameters.AddWithValue("IssuedDate", objBEGas.IssuedDate)

                Dim intJobsGasId As Integer = ExecuteNoneQueryByCommand(cmd, "AddJobsGasDetails", "Y")
                Return intJobsGasId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function UpdateJobsGasDetails(ByVal objBEGas As clsBEGasInspection) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobsGasDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateJobsGasDetails")
                cmd.Parameters.AddWithValue("InspectionId", objBEGas.InspectionId)
                cmd.Parameters.AddWithValue("JobId", objBEGas.JobId)
                cmd.Parameters.AddWithValue("clientId", objBEGas.ClientId)
                cmd.Parameters.AddWithValue("EngineerId", objBEGas.EngineerId)
                cmd.Parameters.AddWithValue("satisfactory", objBEGas.satisfactory)
                cmd.Parameters.AddWithValue("Accesible", objBEGas.Accesible)
                cmd.Parameters.AddWithValue("suitable", objBEGas.suitable)
                cmd.Parameters.AddWithValue("valve", objBEGas.valve)
                cmd.Parameters.AddWithValue("Direction", objBEGas.Direction)
                cmd.Parameters.AddWithValue("Emergency", objBEGas.Emergency)
                cmd.Parameters.AddWithValue("autopressure", objBEGas.autopressure)
                cmd.Parameters.AddWithValue("flameguard", objBEGas.flameguard)
                cmd.Parameters.AddWithValue("manual", objBEGas.manual)
                cmd.Parameters.AddWithValue("warning", objBEGas.warning)
                cmd.Parameters.AddWithValue("PrimarySafety", objBEGas.PrimarySafety)
                cmd.Parameters.AddWithValue("PrimaryInterlock", objBEGas.PrimaryInterlock)
                cmd.Parameters.AddWithValue("SecondaryInterlock", objBEGas.SecondaryInterlock)
                cmd.Parameters.AddWithValue("PrimarySatisfactory", objBEGas.PrimarySatisfactory)
                cmd.Parameters.AddWithValue("SecondarySatisfactory", objBEGas.SecondarySatisfactory)
                cmd.Parameters.AddWithValue("manuallyOveridden", objBEGas.manuallyOveridden)
                cmd.Parameters.AddWithValue("Apparant", objBEGas.Apparant)
                cmd.Parameters.AddWithValue("Evidenceventilation", objBEGas.Evidenceventilation)
                cmd.Parameters.AddWithValue("Unsatisfactory", objBEGas.Unsatisfactory)
                cmd.Parameters.AddWithValue("signventilation", objBEGas.signventilation)
                cmd.Parameters.AddWithValue("volume", objBEGas.volume)
                cmd.Parameters.AddWithValue("Evidencesystems", objBEGas.Evidencesystems)
                cmd.Parameters.AddWithValue("SignMaintenance", objBEGas.SignMaintenance)
                cmd.Parameters.AddWithValue("Extensive", objBEGas.Extensive)
                cmd.Parameters.AddWithValue("Aging", objBEGas.Aging)
                cmd.Parameters.AddWithValue("Fitted", objBEGas.Fitted)
                cmd.Parameters.AddWithValue("TotalScore", objBEGas.TotalScore)
                cmd.Parameters.AddWithValue("ReceiveDate", objBEGas.ReceiveDate)
                cmd.Parameters.AddWithValue("CorrectMatterials", objBEGas.CorrectMatterials)
                cmd.Parameters.AddWithValue("Identified", objBEGas.Identified)
                cmd.Parameters.AddWithValue("Pipework", objBEGas.Pipework)
                cmd.Parameters.AddWithValue("sleeves", objBEGas.sleeves)
                cmd.Parameters.AddWithValue("SuitablePurge", objBEGas.SuitablePurge)
                cmd.Parameters.AddWithValue("AdditinalIsolation", objBEGas.AdditinalIsolation)
                cmd.Parameters.AddWithValue("Electrical", objBEGas.Electrical)
                cmd.Parameters.AddWithValue("Protective", objBEGas.Protective)
                cmd.Parameters.AddWithValue("appropiate", objBEGas.appropiate)
                cmd.Parameters.AddWithValue("CanopySystem", objBEGas.CanopySystem)
                cmd.Parameters.AddWithValue("Overhang", objBEGas.Overhang)
                cmd.Parameters.AddWithValue("Type", objBEGas.Type)
                cmd.Parameters.AddWithValue("filterSatisfactory", objBEGas.filterSatisfactory)
                cmd.Parameters.AddWithValue("mechanically", objBEGas.mechanically)
                cmd.Parameters.AddWithValue("naturally", objBEGas.naturally)
                cmd.Parameters.AddWithValue("both", objBEGas.both)
                cmd.Parameters.AddWithValue("MechVentilation", objBEGas.MechVentilation)
                cmd.Parameters.AddWithValue("SatisfatoryVentilation", objBEGas.SatisfatoryVentilation)
                cmd.Parameters.AddWithValue("adequate", objBEGas.adequate)
                cmd.Parameters.AddWithValue("High", objBEGas.High)
                cmd.Parameters.AddWithValue("low", objBEGas.low)
                cmd.Parameters.AddWithValue("COdetect", objBEGas.COdetect)
                cmd.Parameters.AddWithValue("CO2detect", objBEGas.CO2detect)
                cmd.Parameters.AddWithValue("CO2recorded", objBEGas.CO2recorded)
                cmd.Parameters.AddWithValue("detectionInterlock", objBEGas.detectionInterlock)
                cmd.Parameters.AddWithValue("center", objBEGas.center)
                cmd.Parameters.AddWithValue("Model1", objBEGas.Model1)
                cmd.Parameters.AddWithValue("Model2", objBEGas.Model2)
                cmd.Parameters.AddWithValue("CollabrationDate1", objBEGas.CollabrationDate1)
                cmd.Parameters.AddWithValue("CollabrationDate2", objBEGas.CollabrationDate2)
                cmd.Parameters.AddWithValue("ReceivedBy", objBEGas.ReceivedBy)
                cmd.Parameters.AddWithValue("PrintName", objBEGas.PrintName)
                cmd.Parameters.AddWithValue("IssuedBy", objBEGas.IssuedBy)
                cmd.Parameters.AddWithValue("IdcardNo", objBEGas.IdcardNo)
                cmd.Parameters.AddWithValue("IssuedDate", objBEGas.IssuedDate)

                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateJobsGasDetails")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetJobsGasDetails(ByVal objBEGas As clsBEGasInspection) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobsGasDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobsGasDetails")
                cmd.Parameters.AddWithValue("InspectionId", objBEGas.InspectionId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobsGasDetails")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetJobsGasDetailsByCompany(ByVal objBEGas As clsBEGasInspection) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobsGasDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobsGasDetailsByCompany")
                cmd.Parameters.AddWithValue("ClientId", objBEGas.ClientId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobsGasDetailsByCompany")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetJobsGasDetailsByJobId(ByVal objBEGas As clsBEGasInspection) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobsGasDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobsGasDetailsByJobId")
                cmd.Parameters.AddWithValue("JobId", objBEGas.JobId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobsGasDetailsByJobId")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetJobsGasDetailsByEngineer(ByVal objBEGas As clsBEGasInspection) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spJobsGasDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobsGasDetailsByEngineer")
                cmd.Parameters.AddWithValue("EngineerId", objBEGas.EngineerId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobsGasDetailsByEngineer")
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
