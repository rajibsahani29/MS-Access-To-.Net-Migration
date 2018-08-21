Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE

Namespace DL
    Public Class clsDLCateringInspection
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddCateringGasDetails(ByVal objBECatering As clsBECateringInspection) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spCateringGasDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddCateringGasDetails")
                cmd.Parameters.AddWithValue("ClientId", objBECatering.ClientId)
                cmd.Parameters.AddWithValue("JobId", objBECatering.JobId)
                cmd.Parameters.AddWithValue("EngineerId", objBECatering.EngineerId)
                cmd.Parameters.AddWithValue("RegNo", objBECatering.RegNo)
                cmd.Parameters.AddWithValue("Type", objBECatering.Type)
                cmd.Parameters.AddWithValue("AppliancesTested", objBECatering.AppliancesTested)
                cmd.Parameters.AddWithValue("LPG", objBECatering.LPG)
                cmd.Parameters.AddWithValue("Emergency", objBECatering.Emergency)
                cmd.Parameters.AddWithValue("Tightness", objBECatering.Tightness)
                cmd.Parameters.AddWithValue("installation", objBECatering.installation)
                cmd.Parameters.AddWithValue("OperatingPressure", objBECatering.OperatingPressure)
                cmd.Parameters.AddWithValue("LockupPressure", objBECatering.LockupPressure)
                cmd.Parameters.AddWithValue("ReceivedBy", objBECatering.ReceivedBy)
                cmd.Parameters.AddWithValue("PrintName", objBECatering.PrintName)
                cmd.Parameters.AddWithValue("IssuedBy", objBECatering.IssuedBy)
                cmd.Parameters.AddWithValue("IdcardNo", objBECatering.IdCardNo)
                cmd.Parameters.AddWithValue("IssuedDate", objBECatering.IssuedDate)

                Dim intCateringGasId As Integer = ExecuteNoneQueryByCommand(cmd, "AddCateringGasDetails", "Y")
                Return intCateringGasId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function UpdateCateringGasDetails(ByVal objBECatering As clsBECateringInspection) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spCateringGasDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateCateringGasDetails")
                cmd.Parameters.AddWithValue("CateringId", objBECatering.CateringId)
                cmd.Parameters.AddWithValue("ClientId", objBECatering.ClientId)
                cmd.Parameters.AddWithValue("JobId", objBECatering.JobId)
                cmd.Parameters.AddWithValue("EngineerId", objBECatering.EngineerId)
                cmd.Parameters.AddWithValue("RegNo", objBECatering.RegNo)
                cmd.Parameters.AddWithValue("Type", objBECatering.Type)
                cmd.Parameters.AddWithValue("AppliancesTested", objBECatering.AppliancesTested)
                cmd.Parameters.AddWithValue("LPG", objBECatering.LPG)
                cmd.Parameters.AddWithValue("Emergency", objBECatering.Emergency)
                cmd.Parameters.AddWithValue("Tightness", objBECatering.Tightness)
                cmd.Parameters.AddWithValue("installation", objBECatering.installation)
                cmd.Parameters.AddWithValue("OperatingPressure", objBECatering.OperatingPressure)
                cmd.Parameters.AddWithValue("LockupPressure", objBECatering.LockupPressure)
                cmd.Parameters.AddWithValue("ReceivedBy", objBECatering.ReceivedBy)
                cmd.Parameters.AddWithValue("PrintName", objBECatering.PrintName)
                cmd.Parameters.AddWithValue("IssuedBy", objBECatering.IssuedBy)
                cmd.Parameters.AddWithValue("IdcardNo", objBECatering.IdCardNo)
                cmd.Parameters.AddWithValue("IssuedDate", objBECatering.IssuedDate)

                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateCateringGasDetails")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetCateringDetailsByEngineer(ByVal objBECatering As clsBECateringInspection) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spCateringGasDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetCateringDetailsByEngineer")
                cmd.Parameters.AddWithValue("EngineerId", objBECatering.EngineerId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetCateringDetailsByEngineer")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetCateringDetailsByCompany(ByVal objBECatering As clsBECateringInspection) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spCateringGasDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetCateringDetailsByCompany")
                cmd.Parameters.AddWithValue("ClientId", objBECatering.ClientId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetCateringDetailsByCompany")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetCateringGasDetails(ByVal objBECatering As clsBECateringInspection) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spCateringGasDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetCateringGasDetails")
                cmd.Parameters.AddWithValue("CateringId", objBECatering.CateringId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetCateringGasDetails")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetCateringGasDetailsByJobId(ByVal objBECatering As clsBECateringInspection) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spCateringGasDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetCateringGasDetailsByJobId")
                cmd.Parameters.AddWithValue("JobId", objBECatering.JobId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetCateringGasDetailsByJobId")
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

