Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE

Namespace DL
    Public Class clsDLOrder
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        ''' <summary>
        ''' This function is used to add Order details.
        ''' </summary>
        Public Function AddOrderDetails(ByVal objBEOrder As clsBEOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddOrderDetails")
                cmd.Parameters.AddWithValue("ID", objBEOrder.ID)
                cmd.Parameters.AddWithValue("OrderTakenBy", objBEOrder.OrderTakenBy)
                cmd.Parameters.AddWithValue("Status", objBEOrder.Status)
                cmd.Parameters.AddWithValue("EnquiryDate", objBEOrder.EnquiryDate)
                cmd.Parameters.AddWithValue("JobNumber", objBEOrder.JobNumber)
                cmd.Parameters.AddWithValue("OrderNumber", objBEOrder.OrderNumber)
                cmd.Parameters.AddWithValue("AssetNumber", objBEOrder.AssetNumber)
                cmd.Parameters.AddWithValue("EngineerListed", objBEOrder.EngineerListed)
                cmd.Parameters.AddWithValue("Premises", objBEOrder.Premises)
                cmd.Parameters.AddWithValue("Address1", objBEOrder.Address1)
                cmd.Parameters.AddWithValue("Address2", objBEOrder.Address2)
                cmd.Parameters.AddWithValue("Address3", objBEOrder.Address3)
                cmd.Parameters.AddWithValue("PremisesPostCode", objBEOrder.PremisesPostCode)
                cmd.Parameters.AddWithValue("ApplianceID", objBEOrder.ApplianceID)
                cmd.Parameters.AddWithValue("Telephone", objBEOrder.Telephone)
                cmd.Parameters.AddWithValue("ContactName", objBEOrder.ContactName)
                cmd.Parameters.AddWithValue("Appliance", objBEOrder.Appliance)
                cmd.Parameters.AddWithValue("Fault", objBEOrder.Fault)
                cmd.Parameters.AddWithValue("ModelofAppliance", objBEOrder.ModelofAppliance)
                cmd.Parameters.AddWithValue("FFNUMBER", objBEOrder.FFNUMBER)
                cmd.Parameters.AddWithValue("EnqDate", objBEOrder.EnqDate)
                cmd.Parameters.AddWithValue("Type", objBEOrder.Type)
                cmd.Parameters.AddWithValue("RecallFlag", objBEOrder.RecallFlag)
                cmd.Parameters.AddWithValue("StaffID", objBEOrder.StaffID)
                cmd.Parameters.AddWithValue("ServiceType", objBEOrder.ServiceType)

                Dim intClientId As Integer = ExecuteNoneQueryByCommand(cmd, "AddOrderDetails", "Y")
                Return intClientId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        ''' <summary>
        ''' This function is used to update Order details.
        ''' </summary>
        Public Function UpdateOrderDetails(ByVal objBEOrder As clsBEOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateOrderDetails")
                cmd.Parameters.AddWithValue("JOBID", objBEOrder.JOBID)
                cmd.Parameters.AddWithValue("ID", objBEOrder.ID)
                'cmd.Parameters.AddWithValue("OrderTakenBy", objBEOrder.OrderTakenBy)
                cmd.Parameters.AddWithValue("Status", objBEOrder.Status)
                'cmd.Parameters.AddWithValue("EntryDate", objBEOrder.EntryDate)
                cmd.Parameters.AddWithValue("EnquiryDate", objBEOrder.EnquiryDate)
                'cmd.Parameters.AddWithValue("EnquiryTime", objBEOrder.EnquiryTime)
                'cmd.Parameters.AddWithValue("OrderDate", objBEOrder.OrderDate)
                'cmd.Parameters.AddWithValue("OrderTime", objBEOrder.OrderTime)
                'cmd.Parameters.AddWithValue("RequiredDate", objBEOrder.RequiredDate)
                'cmd.Parameters.AddWithValue("CompletionDate", objBEOrder.CompletionDate)
                'cmd.Parameters.AddWithValue("InvoiceDate", objBEOrder.InvoiceDate)
                cmd.Parameters.AddWithValue("JobNumber", objBEOrder.JobNumber)
                cmd.Parameters.AddWithValue("OrderNumber", objBEOrder.OrderNumber)
                cmd.Parameters.AddWithValue("AssetNumber", objBEOrder.AssetNumber)
                cmd.Parameters.AddWithValue("Engineer", objBEOrder.Engineer)
                cmd.Parameters.AddWithValue("Premises", objBEOrder.Premises)
                cmd.Parameters.AddWithValue("Address1", objBEOrder.Address1)
                cmd.Parameters.AddWithValue("Address2", objBEOrder.Address2)
                cmd.Parameters.AddWithValue("Address3", objBEOrder.Address3)
                cmd.Parameters.AddWithValue("PremisesPostCode", objBEOrder.PremisesPostCode)
                cmd.Parameters.AddWithValue("Telephone", objBEOrder.Telephone)
                cmd.Parameters.AddWithValue("ContactName", objBEOrder.ContactName)
                cmd.Parameters.AddWithValue("Response", objBEOrder.Response)
                cmd.Parameters.AddWithValue("Appliance", objBEOrder.Appliance)
                cmd.Parameters.AddWithValue("Fault", objBEOrder.Fault)
                'cmd.Parameters.AddWithValue("QuoteNumber", objBEOrder.QuoteNumber)
                'cmd.Parameters.AddWithValue("QuoteAcc", objBEOrder.QuoteAcc)
                'cmd.Parameters.AddWithValue("ModelofAppliance", objBEOrder.ModelofAppliance)
                'cmd.Parameters.AddWithValue("Labour", objBEOrder.Labour)
                'cmd.Parameters.AddWithValue("Remarks", objBEOrder.Remarks)
                'cmd.Parameters.AddWithValue("Notes", objBEOrder.Notes)
                'cmd.Parameters.AddWithValue("FFNUMBER", objBEOrder.FFNUMBER)
                'cmd.Parameters.AddWithValue("EnqDate", objBEOrder.EnqDate)
                cmd.Parameters.AddWithValue("SheetDate", objBEOrder.SheetDate)
                'cmd.Parameters.AddWithValue("ChargeableStatus", objBEOrder.ChargeableStatus)
                'cmd.Parameters.AddWithValue("ChargedUnder", objBEOrder.ChargedUnder)
                'cmd.Parameters.AddWithValue("ApplianceID", objBEOrder.ApplianceID)
                'cmd.Parameters.AddWithValue("PremisesID", objBEOrder.PremisesID)
                'cmd.Parameters.AddWithValue("CSVfile", objBEOrder.CSVfile)
                'cmd.Parameters.AddWithValue("BatchID", objBEOrder.BatchID)
                'cmd.Parameters.AddWithValue("JJNUMBER", objBEOrder.JJNUMBER)
                'cmd.Parameters.AddWithValue("RecallFlag", objBEOrder.RecallFlag)
                'cmd.Parameters.AddWithValue("RecallNote", objBEOrder.RecallNote)
                'cmd.Parameters.AddWithValue("VatRate", objBEOrder.VatRate)
                'cmd.Parameters.AddWithValue("AccountCode", objBEOrder.AccountCode)
                'cmd.Parameters.AddWithValue("QuoteDays", objBEOrder.QuoteDays)
                cmd.Parameters.AddWithValue("Type", objBEOrder.Type)
                'cmd.Parameters.AddWithValue("QuoteVatRate", objBEOrder.QuoteVatRate)
                'cmd.Parameters.AddWithValue("RecallCount", objBEOrder.RecallCount)
                'cmd.Parameters.AddWithValue("QuoteDate", objBEOrder.QuoteDate)
                'cmd.Parameters.AddWithValue("StaffID", objBEOrder.StaffID)
                'cmd.Parameters.AddWithValue("IssueStatus", objBEOrder.IssueStatus)

                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateOrderDetails")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function UpdateOrderDetailsByInvoice(ByVal objBEOrder As clsBEOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateOrderDetailsByInvoice")
                cmd.Parameters.AddWithValue("JOBID", objBEOrder.JOBID)
                cmd.Parameters.AddWithValue("VatRate", objBEOrder.VatRate)
                cmd.Parameters.AddWithValue("InvoiceDate", objBEOrder.InvoiceDate)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateOrderDetailsByInvoice")
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function UpdateOrderStatus(ByVal objBEOrder As clsBEOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateOrderStatus")
                cmd.Parameters.AddWithValue("JOBID", objBEOrder.JOBID)
                cmd.Parameters.AddWithValue("Status", objBEOrder.Status)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateOrderStatus")
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function UpdateSortOrderByEngineer(ByVal objBEOrder As clsBEOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateSortOrderByEngineer")
                cmd.Parameters.AddWithValue("Engineer", objBEOrder.Engineer)
                cmd.Parameters.AddWithValue("SheetDate", objBEOrder.SheetDate)
                cmd.Parameters.AddWithValue("SortOrder", objBEOrder.SortOrder)
                cmd.Parameters.AddWithValue("JOBID", objBEOrder.JOBID)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateSortOrderByEngineer")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function UpdateSortOrderByJobId(ByVal objBEOrder As clsBEOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateSortOrderByJobId")
                cmd.Parameters.AddWithValue("JOBID", objBEOrder.JOBID)
                cmd.Parameters.AddWithValue("SortOrder", objBEOrder.SortOrder)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateQuotationDetailsByJobID")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function UpdateQuotationDetailsByJobID(ByVal objBEOrder As clsBEOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateQuotationDetailsByJobID")
                cmd.Parameters.AddWithValue("JOBID", objBEOrder.JOBID)
                cmd.Parameters.AddWithValue("QuoteNumber", objBEOrder.QuoteNumber)
                cmd.Parameters.AddWithValue("QuoteDays", objBEOrder.QuoteDays)
                cmd.Parameters.AddWithValue("QuoteVatRate", objBEOrder.QuoteVatRate)
                cmd.Parameters.AddWithValue("QuoteDate", objBEOrder.QuoteDate)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateQuotationDetailsByJobID")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        ''' <summary>
        ''' This function is used to update Order details.
        ''' </summary>
        Public Function UpdateOrderDetailsByJobAllocation(ByVal objBEOrder As clsBEOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateOrderDetailsByJobAllocation")
                cmd.Parameters.AddWithValue("JOBID", objBEOrder.JOBID)
                cmd.Parameters.AddWithValue("SheetDate", objBEOrder.SheetDate)
                cmd.Parameters.AddWithValue("AllocatedDate", objBEOrder.AllocatedDate)
                cmd.Parameters.AddWithValue("Engineer", objBEOrder.Engineer)
                cmd.Parameters.AddWithValue("Status", objBEOrder.Status)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateOrderDetailsByJobAllocation")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function UpdateJobDetailsPartOrder(ByVal objBEOrder As clsBEOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateJobDetailsPartOrder")
                cmd.Parameters.AddWithValue("JOBID", objBEOrder.JOBID)
                cmd.Parameters.AddWithValue("Appliance", objBEOrder.Appliance)
                cmd.Parameters.AddWithValue("Fault", objBEOrder.Fault)
                cmd.Parameters.AddWithValue("ModelofAppliance", objBEOrder.ModelofAppliance)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateJobDetailsPartOrder")
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function UpdateOrderFlagDetails() As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateOrderFlagDetails")
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateOrderFlagDetails")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function DeleteOrderDetailsByJobId(ByVal objBEOrder As clsBEOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "DeleteOrderDetailsByJobId")
                cmd.Parameters.AddWithValue("JOBID", objBEOrder.JOBID)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "DeleteOrderDetailsByJobId")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetNextInvoiceNumber() As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetNextInvoiceNumber")
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "GetNextInvoiceNumber")
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
        Public Function GetAllJobOrders() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetAllJobOrders")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetAllJobOrders")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetOrderDetail(ByVal strSearchByEngineer As String, ByVal strSearchByStatus As String, ByVal strSearchByCompany As String, ByVal strSearchByFFNos As String, ByVal strSearchByPermises As String, ByVal strSearchByAppliance As String, ByVal strSearchByFault As String, strSearchByOrder As String, strSearchByQuote As String) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetOrderDetail")
                cmd.Parameters.AddWithValue("SearchByEngineer", strSearchByEngineer)
                cmd.Parameters.AddWithValue("SearchByStatus", strSearchByStatus)
                cmd.Parameters.AddWithValue("SearchByCompany", strSearchByCompany)
                cmd.Parameters.AddWithValue("SearchByFFNos", strSearchByFFNos)
                cmd.Parameters.AddWithValue("SearchByPermises", strSearchByPermises)
                cmd.Parameters.AddWithValue("SearchByAppliance", strSearchByAppliance)
                cmd.Parameters.AddWithValue("SearchByFault", strSearchByFault)
                cmd.Parameters.AddWithValue("SearchByOrder", strSearchByOrder)
                cmd.Parameters.AddWithValue("SearchByQuote", strSearchByQuote)
                'cmd.Parameters.AddWithValue("StaffID", intUserId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetOrderDetail")
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
        ''' This function is used to get Job detail by Job Number.
        ''' </summary>
        Public Function GetJobDetailsByJobNumber(ByVal objBEOrder As clsBEOrder) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobDetailsByJobNumber")
                cmd.Parameters.AddWithValue("JobNumber", objBEOrder.JobNumber)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobDetailsByJobNumber")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetPartRequestJobDetailsByJobNumber(ByVal objBEOrder As clsBEOrder) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPartRequestJobDetailsByJobNumber")
                cmd.Parameters.AddWithValue("JobNumber", objBEOrder.JobNumber)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobDetailsByJobNumber")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetJobDetailsByJobID(ByVal objBEOrder As clsBEOrder) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobDetailsByJobID")
                cmd.Parameters.AddWithValue("JOBID", objBEOrder.JOBID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobDetailsByJobID")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetPartsOrderForJob(ByVal objBEOrder As clsBEOrder) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPartsOrderForJob")
                cmd.Parameters.AddWithValue("JOBID", objBEOrder.JOBID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPartsOrderForJob")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetJobAllocationToday(ByVal objBEOrder As clsBEOrder) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobAllocationToday")
                cmd.Parameters.AddWithValue("Sheetdate", objBEOrder.SheetDate)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobAllocationToday")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetOrderDetailForInvoice(ByVal objBEOrder As clsBEOrder) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetOrderDetailForInvoice")
                cmd.Parameters.AddWithValue("JOBID", objBEOrder.JOBID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetOrderDetailForInvoice")
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
        Public Function UpdateCompanyIdForDeleteClient(ByVal objBEOrder As clsBEOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdateCompanyIdForDeleteClient")
                cmd.Parameters.AddWithValue("JOBID", objBEOrder.JOBID)
                Return ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdateCompanyIdForDeleteClient")

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetJobDetailsPartOrder(ByVal objBEOrder As clsBEOrder) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobDetailsPartOrder")
                cmd.Parameters.AddWithValue("JOBID", objBEOrder.JOBID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobDetailsPartOrder")
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
        ''' This function is used to get accommodation details and fill in dropdown.
        ''' </summary>
        Public Function GetOrderDetailFillInDD() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetOrderDetailFillInDD")
                'cmd.Parameters.AddWithValue("CompanyId", intCompanyId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetOrderDetailFillInDD")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetOrderStatusFillInDD() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetOrderStatusFillInDD")
                'cmd.Parameters.AddWithValue("CompanyId", intCompanyId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetOrderStatusFillInDD")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetOrderApplianceFillInDD() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetOrderApplianceFillInDD")
                'cmd.Parameters.AddWithValue("CompanyId", intCompanyId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetOrderApplianceFillInDD")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetJobFillInDD() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobFillInDD")
                'cmd.Parameters.AddWithValue("CompanyId", intCompanyId)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobFillInDD")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetJobSheetDataByUser(ByVal objBEOrder As clsBEOrder) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobSheetDataByUser")
                cmd.Parameters.AddWithValue("SheetDate", objBEOrder.SheetDate)
                cmd.Parameters.AddWithValue("Engineer", objBEOrder.Engineer)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobSheetDataByUser")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetJobIdFillInDD(ByVal objBEOrder As clsBEOrder) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobIdFillInDD")
                cmd.Parameters.AddWithValue("SheetDate", objBEOrder.SheetDate)
                cmd.Parameters.AddWithValue("Engineer", objBEOrder.Engineer)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobIdFillInDD")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetJobSheetDataByIndividualEngineer(ByVal objBEOrder As clsBEOrder) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobSheetDataByIndividualEngineer")
                cmd.Parameters.AddWithValue("SheetDate", objBEOrder.SheetDate)
                cmd.Parameters.AddWithValue("Engineer", objBEOrder.Engineer)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobSheetDataByIndividualEngineer")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetJobSheetEngineer(ByVal objBEOrder As clsBEOrder) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobSheetEngineer")
                cmd.Parameters.AddWithValue("SheetDate", objBEOrder.SheetDate)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetJobSheetEngineer")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetJobIDBySortOrder(ByVal objBEOrder As clsBEOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetJobIDBySortOrder")
                cmd.Parameters.AddWithValue("SheetDate", objBEOrder.SheetDate)
                cmd.Parameters.AddWithValue("Engineer", objBEOrder.Engineer)
                cmd.Parameters.AddWithValue("SortOrder", objBEOrder.SortOrder)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "GetJobIDBySortOrder")
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetSortOrderByEngineer(ByVal objBEOrder As clsBEOrder) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetSortOrderByEngineer")
                cmd.Parameters.AddWithValue("SheetDate", objBEOrder.SheetDate)
                cmd.Parameters.AddWithValue("Engineer", objBEOrder.Engineer)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "GetSortOrderByEngineer")
                Return intAffectedRow
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetModelFillInDD() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetModelFillInDD")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetModelFillInDD")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetDetailsForDayBookByCompany(ByVal objBEOrder As clsBEOrder) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetDetailsForDayBookByCompany")
                cmd.Parameters.AddWithValue("EnqDate", objBEOrder.EnqDate)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetDetailsForDayBookByCompany")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetDetailsForDayBookByTime(ByVal objBEOrder As clsBEOrder) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spOrderDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetDetailsForDayBookByTime")
                cmd.Parameters.AddWithValue("EnqDate", objBEOrder.EnqDate)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetDetailsForDayBookByTime")
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
