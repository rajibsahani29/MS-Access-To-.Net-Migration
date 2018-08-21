Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE

Namespace DL

    Public Class clsDLStaff
        Inherits BaseDB

        Dim objFunction As New clsCommon()

        ''' <summary>
        ''' This function is used to check the login credential of every uses.
        ''' </summary>
        Public Function StaffLogin(ByVal objBEStaff As clsBEStaff) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spStaffMember"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "LoginStaffMember")
                cmd.Parameters.AddWithValue("Email", objBEStaff.Email)
                cmd.Parameters.AddWithValue("Password", objBEStaff.Password)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "StaffLogin")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function



        Public Function CheckManagementForReport(ByVal objBEStaff As clsBEStaff) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spStaffMember"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "CheckManagementForReport")
                cmd.Parameters.AddWithValue("StaffID", objBEStaff.StaffID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "CheckManagementForReport")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        ''' <summary>
        ''' This function is used to update staff member.
        ''' </summary>
        Public Function UpdateStaffMember(ByVal objBEStaff As clsBEStaff) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spStaffMember"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateStaffMember")
                cmd.Parameters.AddWithValue("StaffID", objBEStaff.StaffID)
                cmd.Parameters.AddWithValue("RandomCode", objBEStaff.RandomCode)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateStaffMember")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        ''' <summary>
        ''' This function is used to add staff member detail.
        ''' </summary>
        Public Function AddStaffMemberDetail(ByVal objBEStaff As clsBEStaff) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spStaffMember"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddStaffMemberDetail")
                cmd.Parameters.AddWithValue("FirstName", objBEStaff.FirstName)
                cmd.Parameters.AddWithValue("LastName", objBEStaff.LastName)
                'cmd.Parameters.AddWithValue("EmployeeID", objBEStaff.EmployeeID)
                cmd.Parameters.AddWithValue("Address1", objBEStaff.Address1)
                cmd.Parameters.AddWithValue("Address2", objBEStaff.Address2)
                cmd.Parameters.AddWithValue("City", objBEStaff.City)
                cmd.Parameters.AddWithValue("PostCode", objBEStaff.Postcode)
                cmd.Parameters.AddWithValue("Phone", objBEStaff.Phone)
                cmd.Parameters.AddWithValue("Gender", objBEStaff.Gender)
                cmd.Parameters.AddWithValue("Email", objBEStaff.Email)
                cmd.Parameters.AddWithValue("DOB", objBEStaff.DOB)
                cmd.Parameters.AddWithValue("Password", objBEStaff.Password)
                cmd.Parameters.AddWithValue("Current", objBEStaff.Current)
                cmd.Parameters.AddWithValue("Site", objBEStaff.Site)
                cmd.Parameters.AddWithValue("Office", objBEStaff.Office)
                cmd.Parameters.AddWithValue("PCuser", objBEStaff.PCuser)
                cmd.Parameters.AddWithValue("Engineer", objBEStaff.Engineer)

                Dim intStaffId As Integer = ExecuteNoneQueryByCommand(cmd, "AddStaffMemberDetail", "Y")
                Return intStaffId
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        ''' <summary>
        ''' This function is used to change staff member password.
        ''' </summary>
        Public Function ChangeStaffMemberPassword(ByVal objBEStaff As clsBEStaff) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spStaffMember"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "ChangeStaffMemberPassword")
                cmd.Parameters.AddWithValue("Password", objBEStaff.Password)
                cmd.Parameters.AddWithValue("StaffId", objBEStaff.StaffID)
                Return ExecuteScalarByCommandReturnAffectedRow(cmd, "ChangeStaffMemberPassword")
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        ''' <summary>
        ''' This function is used to get staff member and fill in dropdown.
        ''' </summary>
        Public Function GetStaffMemberFillInDD() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spStaffMember"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetStaffMemberFillInDD")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetStaffMemberFillInDD")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetOfficeStaffMemberFillInDD() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spStaffMember"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetOfficeStaffMemberFillInDD")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetOfficeStaffMemberFillInDD")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function







        Public Function GetStaffFillInDD() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spStaffMember"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetStaffFillInDD")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetStaffFillInDD")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        ''' <summary>
        ''' This function is used to get staff member detail by staff id.
        ''' </summary>
        Public Function GetStaffEmailid(ByVal strEmail As String) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spStaffMember"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetStaffEmailid")
                cmd.Parameters.AddWithValue("Email", strEmail)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetStaffEmailid")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function LoginStaffMemberByCode(ByVal objBEStaff As clsBEStaff) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spStaffMember"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "LoginStaffMemberByCode")
                cmd.Parameters.AddWithValue("Email", objBEStaff.Email)
                cmd.Parameters.AddWithValue("RandomCode", objBEStaff.RandomCode)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "LoginStaffMemberByCode")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetPasswordByStaffId(ByVal objBEStaff As clsBEStaff) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spStaffMember"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPasswordByStaffId")
                cmd.Parameters.AddWithValue("StaffID", objBEStaff.StaffID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPasswordByStaffId")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetStaffList() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spStaffMember"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetStaffList")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetStaffList")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetStaffListByName(ByVal objBEStaff As clsBEStaff) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spStaffMember"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetStaffListByName")
                cmd.Parameters.AddWithValue("FirstName", objBEStaff.FirstName)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetStaffListByName")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function PerformGridViewOpertaion(ByVal strAction As String, ByVal objBEStaff As clsBEStaff) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spStaffMember"
                cmd.CommandType = CommandType.StoredProcedure
                If strAction = "UPDATE" Then
                    cmd.Parameters.AddWithValue("Action", "UpdateStaffMemberDetails")
                    cmd.Parameters.AddWithValue("StaffID", objBEStaff.StaffID)
                    cmd.Parameters.AddWithValue("FirstName", objBEStaff.FirstName)
                    cmd.Parameters.AddWithValue("LastName", objBEStaff.LastName)
                    cmd.Parameters.AddWithValue("Phone", objBEStaff.Phone)
                    cmd.Parameters.AddWithValue("City", objBEStaff.City)
                    cmd.Parameters.AddWithValue("DOB", objBEStaff.DOB)
                    cmd.Parameters.AddWithValue("Current", objBEStaff.Current)
                    cmd.Parameters.AddWithValue("Site", objBEStaff.Site)
                    cmd.Parameters.AddWithValue("Office", objBEStaff.Office)
                    cmd.Parameters.AddWithValue("PCuser", objBEStaff.PCuser)
                    cmd.Parameters.AddWithValue("Password", objBEStaff.Password)

                ElseIf strAction = "DELETE" Then
                    cmd.Parameters.AddWithValue("Action", "DeleteStaffMemberDetails")
                    cmd.Parameters.AddWithValue("StaffID", objBEStaff.StaffID)
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


