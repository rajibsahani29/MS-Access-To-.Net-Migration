Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLPEcos
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddPECOSDetails(ByVal objBEPEcos As clsBEPEcos) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPECOSDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddPECOSDetails")
                'cmd.Parameters.AddWithValue("RoleId", objBEStaff.RoleId)
                'cmd.Parameters.AddWithValue("CompanyId", objBEStaff.CompanyId)
                'cmd.Parameters.AddWithValue("DateAdded", DateTime.Now)
                'cmd.Parameters.AddWithValue("Active", RecoredStatus.Active)
                'cmd.Parameters.AddWithValue("DateStarted", (If(objBEStaff.DateStarted <> DateTime.MinValue, objBEStaff.DateStarted, DirectCast(DBNull.Value, Object))))
                'cmd.Parameters.AddWithValue("Password", objBEStaff.Password)

                'Dim intStaffId As Integer = ExecuteNoneQueryByCommand(cmd, "AddStaffMember", "Y")
                'HttpContext.Current.Trace.Warn("intStaffId = " + Convert.ToString(intStaffId))
                'If intStaffId > 0 Then
                '    Dim strUserName As String = objBEStaff.Name1 + objBEStaff.Name2 + objFunction.ReturnString(intStaffId)
                '    HttpContext.Current.Trace.Warn("strUserName = " + strUserName)
                Dim cmdNew = New SqlCommand()
                'cmdNew.CommandText = "EW_spStaffMember"
                '    cmdNew.CommandType = CommandType.StoredProcedure
                '    cmdNew.Parameters.AddWithValue("Action", "UpdateStaffMemberUserName")
                '    cmdNew.Parameters.AddWithValue("Username", strUserName)
                '    cmdNew.Parameters.AddWithValue("LastUpdated", DateTime.Now)
                '    cmdNew.Parameters.AddWithValue("StaffId", intStaffId)
                '    ExecuteNoneQueryByCommand(cmdNew, "UpdateStaffMemberUserName")
                'End If

                'Return intStaffId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetPECOSFillInDD(ByVal objBEPEcos As clsBEPEcos) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPECOSDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPECOSFillInDD")
                cmd.Parameters.AddWithValue("FFStandard", objBEPEcos.FFStandard)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPECOSFillInDD")
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
