Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Public Class clsDLManufacturer
    Inherits BaseDB
    Dim objFunction As New clsCommon()

    Public Function AddManufactureDetails(ByVal objBEManufacture As clsBEManufacture) As Integer
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandText = "FF_spManufacturerDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("Action", "AddManufactureDetails")
            cmd.Parameters.AddWithValue("ManufacturerID", objBEManufacture.ManufacturerID)
            cmd.Parameters.AddWithValue("ManufacturerName", objBEManufacture.ManufacturerName)
            cmd.Parameters.AddWithValue("Address1", objBEManufacture.Address1)
            cmd.Parameters.AddWithValue("Address2", objBEManufacture.Address2)
            cmd.Parameters.AddWithValue("City", objBEManufacture.City)
            cmd.Parameters.AddWithValue("PCode1", objBEManufacture.PCode1)
            cmd.Parameters.AddWithValue("PCode2", objBEManufacture.PCode2)
            cmd.Parameters.AddWithValue("PhoneNumber", objBEManufacture.PhoneNumber)
            cmd.Parameters.AddWithValue("FAX", objBEManufacture.FAX)
            cmd.Parameters.AddWithValue("Mobile", objBEManufacture.Mobile)
            cmd.Parameters.AddWithValue("Email", objBEManufacture.Email)
            cmd.Parameters.AddWithValue("DelFlag", objBEManufacture.DelFlag)
            Dim intApplianceId As Integer = ExecuteNoneQueryByCommand(cmd, "AddManufactureDetails", "Y")
            Return intApplianceId

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
        Return Nothing
    End Function
    Public Function GetManufactureFillInDD() As DataSet
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandText = "FF_spManufacturerDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("Action", "GetManufactureFillInDD")
            Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetManufactureFillInDD")
            If objFunction.CheckDataSet(dstData) Then
                Return dstData
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
        Return Nothing
    End Function

    Public Function GetManufactureDetails() As DataSet
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandText = "FF_spManufacturerDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("Action", "GetManufactureDetails")
            Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetManufactureDetails")
            If objFunction.CheckDataSet(dstData) Then
                Return dstData
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
        Return Nothing
    End Function

    Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBEManufacture As clsBEManufacture) As Integer
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandText = "FF_spManufacturerDetails"
            cmd.CommandType = CommandType.StoredProcedure
            If strAction = "UPDATE" Then
                cmd.Parameters.AddWithValue("Action", "UpdateManufactureDetails")
                cmd.Parameters.AddWithValue("ManufacturerID", objBEManufacture.ManufacturerID)
                cmd.Parameters.AddWithValue("ManufacturerName", objBEManufacture.ManufacturerName)
                cmd.Parameters.AddWithValue("Address1", objBEManufacture.Address1)
                cmd.Parameters.AddWithValue("Address2", objBEManufacture.Address2)
                cmd.Parameters.AddWithValue("City", objBEManufacture.City)
                cmd.Parameters.AddWithValue("PCode1", objBEManufacture.PCode1)
                cmd.Parameters.AddWithValue("PCode2", objBEManufacture.PCode2)
                cmd.Parameters.AddWithValue("PhoneNumber", objBEManufacture.PhoneNumber)
                cmd.Parameters.AddWithValue("FAX", objBEManufacture.FAX)
                cmd.Parameters.AddWithValue("Mobile", objBEManufacture.Mobile)
                cmd.Parameters.AddWithValue("Email", objBEManufacture.Email)

            ElseIf strAction = "DELETE" Then
                cmd.Parameters.AddWithValue("Action", "DeleteManufactureDetails")
                cmd.Parameters.AddWithValue("ManufacturerID", objBEManufacture.ManufacturerID)
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
