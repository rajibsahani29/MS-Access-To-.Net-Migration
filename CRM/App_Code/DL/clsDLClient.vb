Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE

Namespace DL

    Public Class clsDLClient
        Inherits BaseDB

        Dim objFunction As New clsCommon()

        ''' <summary>
        ''' This function is used to add client details.
        ''' </summary>
        Public Function AddClientDetails(ByVal objBEClient As clsBEClient) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddClientDetails")
                cmd.Parameters.AddWithValue("UpliftPayment", objBEClient.UpliftPayment)
                cmd.Parameters.AddWithValue("OnStop", objBEClient.OnStop)
                'cmd.Parameters.AddWithValue("SageNos", objBEClient.SageNos)
                cmd.Parameters.AddWithValue("CompanyName", objBEClient.CompanyName)
                cmd.Parameters.AddWithValue("ContactPosition", objBEClient.ContactPosition)
                cmd.Parameters.AddWithValue("Forename", objBEClient.Forename)
                cmd.Parameters.AddWithValue("Surname", objBEClient.Surname)
                cmd.Parameters.AddWithValue("Phone", objBEClient.Phone)
                cmd.Parameters.AddWithValue("MobileNumber", objBEClient.MobileNumber)
                cmd.Parameters.AddWithValue("Email", objBEClient.Email)
                'cmd.Parameters.AddWithValue("AlternativeContactPosition", objBEClient.AlternativeContactPosition)
                'cmd.Parameters.AddWithValue("AlternativeForename", objBEClient.AlternativeForename)
                'cmd.Parameters.AddWithValue("AlternativeSurname", objBEClient.AlternativeSurname)
                'cmd.Parameters.AddWithValue("AlternativeEmail", objBEClient.AlternativeEmail)
                'cmd.Parameters.AddWithValue("AlternativePhone", objBEClient.AlternativePhone)
                'cmd.Parameters.AddWithValue("HourlyRate", objBEClient.HourlyRate)
                cmd.Parameters.AddWithValue("Street", objBEClient.Street)
                cmd.Parameters.AddWithValue("Area", objBEClient.Area)
                cmd.Parameters.AddWithValue("Town", objBEClient.Town)
                cmd.Parameters.AddWithValue("Postcode", objBEClient.Postcode)
                cmd.Parameters.AddWithValue("Fax", objBEClient.Fax)
                cmd.Parameters.AddWithValue("OnStatementList", objBEClient.OnStatementList)
                'cmd.Parameters.AddWithValue("Group", objBEClient.Group)
                'cmd.Parameters.AddWithValue("EntryDate", objBEClient.EntryDate)
                'cmd.Parameters.AddWithValue("Notes", objBEClient.Notes)
                'cmd.Parameters.AddWithValue("ClientNumber", objBEClient.ClientNumber)
                cmd.Parameters.AddWithValue("RemittanceSlip", objBEClient.RemittanceSlip)
                'cmd.Parameters.AddWithValue("FactorNumber", objBEClient.FactorNumber)
                cmd.Parameters.AddWithValue("NullNoJob", objBEClient.NullNoJob)
                'cmd.Parameters.AddWithValue("RateID", objBEClient.RateID)
                Dim intClientId As Integer = ExecuteNoneQueryByCommand(cmd, "AddClientDetails", "Y")
                Return intClientId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        ''' <summary>
        ''' This function is used to update client details.
        ''' </summary>
        ''' 


        Public Function AddClientDetailsInAddJob(ByVal objBEClient As clsBEClient) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddClientDetailsInAddJob")
                cmd.Parameters.AddWithValue("CompanyName", objBEClient.CompanyName)
                cmd.Parameters.AddWithValue("Street", objBEClient.Street)
                cmd.Parameters.AddWithValue("Area", objBEClient.Area)
                cmd.Parameters.AddWithValue("Town", objBEClient.Town)
                cmd.Parameters.AddWithValue("Postcode", objBEClient.Postcode)
                cmd.Parameters.AddWithValue("UpliftPayment", objBEClient.UpliftPayment)
                cmd.Parameters.AddWithValue("OnStop", objBEClient.OnStop)
                cmd.Parameters.AddWithValue("OnStatementList", objBEClient.OnStatementList)
                cmd.Parameters.AddWithValue("RemittanceSlip", objBEClient.RemittanceSlip)
                cmd.Parameters.AddWithValue("NullNoJob", objBEClient.NullNoJob)
                Dim intClientId As Integer = ExecuteNoneQueryByCommand(cmd, "AddClientDetailsInAddJob", "Y")
                Return intClientId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function UpdateClientDetails(ByVal objBEClient As clsBEClient) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateClientDetails")
                cmd.Parameters.AddWithValue("ClientId", objBEClient.ClientId)
                'cmd.Parameters.AddWithValue("UpliftPayment", objBEClient.UpliftPayment)
                'cmd.Parameters.AddWithValue("OnStop", objBEClient.OnStop)
                'cmd.Parameters.AddWithValue("SageNos", objBEClient.SageNos)
                'cmd.Parameters.AddWithValue("CompanyName", objBEClient.CompanyName)
                'cmd.Parameters.AddWithValue("ContactPosition", objBEClient.ContactPosition)
                'cmd.Parameters.AddWithValue("Forename", objBEClient.Forename)
                'cmd.Parameters.AddWithValue("Surname", objBEClient.Surname)
                cmd.Parameters.AddWithValue("Phone", objBEClient.Phone)
                'cmd.Parameters.AddWithValue("MobileNumber", objBEClient.MobileNumber)
                'cmd.Parameters.AddWithValue("Email", objBEClient.Email)
                'cmd.Parameters.AddWithValue("AlternativeContactPosition", objBEClient.AlternativeContactPosition)
                'cmd.Parameters.AddWithValue("AlternativeForename", objBEClient.AlternativeForename)
                'cmd.Parameters.AddWithValue("AlternativeSurname", objBEClient.AlternativeSurname)
                'cmd.Parameters.AddWithValue("AlternativeEmail", objBEClient.AlternativeEmail)
                'cmd.Parameters.AddWithValue("AlternativePhone", objBEClient.AlternativePhone)
                'cmd.Parameters.AddWithValue("HourlyRate", objBEClient.HourlyRate)
                'cmd.Parameters.AddWithValue("Street", objBEClient.Street)
                'cmd.Parameters.AddWithValue("Area", objBEClient.Area)
                'cmd.Parameters.AddWithValue("Town", objBEClient.Town)
                'cmd.Parameters.AddWithValue("Postcode", objBEClient.Postcode)
                'cmd.Parameters.AddWithValue("Fax", objBEClient.Fax)
                'cmd.Parameters.AddWithValue("OnStatementList", objBEClient.OnStatementList)
                'cmd.Parameters.AddWithValue("Group", objBEClient.Group)
                'cmd.Parameters.AddWithValue("EntryDate", objBEClient.EntryDate)
                'cmd.Parameters.AddWithValue("Notes", objBEClient.Notes)
                'cmd.Parameters.AddWithValue("ClientNumber", objBEClient.ClientNumber)
                'cmd.Parameters.AddWithValue("RemittanceSlip", objBEClient.RemittanceSlip)
                'cmd.Parameters.AddWithValue("FactorNumber", objBEClient.FactorNumber)
                'cmd.Parameters.AddWithValue("NullNoJob", objBEClient.NullNoJob)
                'cmd.Parameters.AddWithValue("RateID", objBEClient.RateID)

                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateClientDetails")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function UpdateClientDetailsByID(ByVal objBEClient As clsBEClient) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateClientDetailsByID")
                cmd.Parameters.AddWithValue("ClientId", objBEClient.ClientId)
                cmd.Parameters.AddWithValue("UpliftPayment", objBEClient.UpliftPayment)
                cmd.Parameters.AddWithValue("OnStop", objBEClient.OnStop)
                cmd.Parameters.AddWithValue("CompanyName", objBEClient.CompanyName)
                cmd.Parameters.AddWithValue("ContactPosition", objBEClient.ContactPosition)
                cmd.Parameters.AddWithValue("Forename", objBEClient.Forename)
                cmd.Parameters.AddWithValue("Surname", objBEClient.Surname)
                cmd.Parameters.AddWithValue("Phone", objBEClient.Phone)
                cmd.Parameters.AddWithValue("HourlyRate", objBEClient.HourlyRate)
                cmd.Parameters.AddWithValue("Street", objBEClient.Street)
                cmd.Parameters.AddWithValue("Area", objBEClient.Area)
                cmd.Parameters.AddWithValue("Town", objBEClient.Town)
                cmd.Parameters.AddWithValue("Postcode", objBEClient.Postcode)
                cmd.Parameters.AddWithValue("Fax", objBEClient.Fax)
                cmd.Parameters.AddWithValue("OnStatementList", objBEClient.OnStatementList)
                cmd.Parameters.AddWithValue("RemittanceSlip", objBEClient.RemittanceSlip)
                cmd.Parameters.AddWithValue("RateID", objBEClient.RateID)

                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateClientDetailsByID")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function



        Public Function UpdateClientFlag() As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateClientFlag")
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateClientFlag")
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        ''' <summary>
        ''' This function is used to get client detail by agent id.
        ''' </summary>
        Public Function GetClientDetailById(ByVal objBEClient As clsBEClient) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetClientDetailById")
                cmd.Parameters.AddWithValue("ClientId", objBEClient.ClientId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetClientDetailById")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetClientDetailByPostCode(ByVal objBEClient As clsBEClient) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetClientDetailByPostCode")
                cmd.Parameters.AddWithValue("Postcode", objBEClient.Postcode)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetClientDetailByPostCode")
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
        ''' This function is used to get client detail by agent id.
        ''' </summary>
        Public Function GetClientDetailByName(ByVal strsearch1 As String) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetClientDetailByName")
                cmd.Parameters.AddWithValue("search1", strsearch1)
                'cmd.Parameters.AddWithValue("Name2", objBEClient.Surname)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetClientDetailByName")
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
        ''' This function is used to update company id for delete client.
        ''' </summary>
        Public Function UpdateCompanyIdForDeleteClient(ByVal objBEClient As clsBEClient) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateCompanyIdForDeleteClient")
                cmd.Parameters.AddWithValue("ClientId", objBEClient.ClientId)

                Return ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateCompanyIdForDeleteClient")

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetClientDetails() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetClientDetails")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetClientDetails")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetClientDetailsBySearch(ByVal strsearch1 As String, ByVal strsearch2 As String) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetClientDetailsBySearch")
                cmd.Parameters.AddWithValue("search1", strsearch1)
                cmd.Parameters.AddWithValue("search2", strsearch2)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetClientDetailsBySearch")

                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetClientFillInDD() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spClientDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetClientFillInDD")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetClientFillInDD")
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