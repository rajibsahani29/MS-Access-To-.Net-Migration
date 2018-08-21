Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLAppliances
        Inherits BaseDB
        Dim objFunction As New clsCommon()

        Public Function AddApplianceDetails(ByVal objBEAppliances As clsBEAppliances) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spApplianceDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddApplianceDetails")
                cmd.Parameters.AddWithValue("ManufacturerID", objBEAppliances.ManufacturerID)
                cmd.Parameters.AddWithValue("ApplianceTypeID", objBEAppliances.ApplianceTypeID)
                cmd.Parameters.AddWithValue("Model", objBEAppliances.Model)
                cmd.Parameters.AddWithValue("DellFlag", objBEAppliances.DellFlag)
                Dim intApplianceId As Integer = ExecuteNoneQueryByCommand(cmd, "AddApplianceDetails", "Y")
                Return intApplianceId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetByApplianceIdForPartsEditor(ByVal objBEAppliances As clsBEAppliances) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spApplianceDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetByApplianceIdForPartsEditor")
                cmd.Parameters.AddWithValue("ApplianceID", objBEAppliances.ApplianceID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetByApplianceIdForPartsEditor")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetModelTypeFillInDD(ByVal objBEAppliances As clsBEAppliances) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spApplianceDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetModelTypeFillInDD")
                cmd.Parameters.AddWithValue("ManufacturerID", objBEAppliances.ManufacturerID)
                cmd.Parameters.AddWithValue("ApplianceTypeID", objBEAppliances.ApplianceTypeID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetModelTypeFillInDD")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetModelTypeFillInDDByManufacturerID(ByVal objBEAppliances As clsBEAppliances) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spApplianceDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetModelTypeFillInDDByManufacturerID")
                cmd.Parameters.AddWithValue("ManufacturerID", objBEAppliances.ManufacturerID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetModelTypeFillInDDByManufacturerID")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetApplianceDetailsBySearch(ByVal strSearchByManufacturer As String, ByVal strSearchByAppliance As String, ByVal strSearchByModel As String) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spApplianceDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetApplianceDetailsBySearch")
                cmd.Parameters.AddWithValue("SearchByManufacturer", strSearchByManufacturer)
                cmd.Parameters.AddWithValue("SearchByAppliance", strSearchByAppliance)
                cmd.Parameters.AddWithValue("SearchByModel", strSearchByModel)

                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetApplianceDetailsBySearch")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBEAppliances As clsBEAppliances) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spApplianceDetails"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdateApplianceDetails")
                    cmd.Parameters.AddWithValue("ApplianceID", objBEAppliances.ApplianceID)
                    cmd.Parameters.AddWithValue("ManufacturerID", objBEAppliances.ManufacturerID)
                    cmd.Parameters.AddWithValue("ApplianceTypeID", objBEAppliances.ApplianceTypeID)
                    cmd.Parameters.AddWithValue("Model", objBEAppliances.Model)
                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeleteApplianceDetails")
                    cmd.Parameters.AddWithValue("ApplianceID", objBEAppliances.ApplianceID)
                End If
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "PerformGridViewOpertaion")
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetApplianceDetails() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spApplianceDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetApplianceDetails")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetApplianceDetails")
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
