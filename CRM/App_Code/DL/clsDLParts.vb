Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports CRM.BE
Namespace DL
    Public Class clsDLParts
        Inherits BaseDB
        Dim objFunction As New clsCommon()
        Public Function AddPartsDetails(ByVal objBEParts As clsBEParts) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "AddPartsDetails")
                cmd.Parameters.AddWithValue("ManufacturerID", objBEParts.ManufacturerID)
                cmd.Parameters.AddWithValue("ApplianceID", objBEParts.ApplianceID)
                cmd.Parameters.AddWithValue("PartNumber", objBEParts.PartNumber)
                cmd.Parameters.AddWithValue("Description", objBEParts.Description)
                cmd.Parameters.AddWithValue("ManufacturersListPrice", objBEParts.ManufacturersListPrice)
                cmd.Parameters.AddWithValue("FastFixxSellingPrice", objBEParts.FastFixxSellingPrice)
                Dim intPartId As Integer = ExecuteNoneQueryByCommand(cmd, "AddPartsDetails", "Y")
                Return intPartId

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function UpdatePartsDetails(ByVal objBEParts As clsBEParts) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "UpdatePartsDetails")
                cmd.Parameters.AddWithValue("PartID", objBEParts.PartID)
                cmd.Parameters.AddWithValue("Description", objBEParts.Description)
                cmd.Parameters.AddWithValue("ManufacturersListPrice", objBEParts.ManufacturersListPrice)
                cmd.Parameters.AddWithValue("FastFixxSellingPrice", objBEParts.FastFixxSellingPrice)
                'cmd.Parameters.AddWithValue("ListPriceDate", objBEParts.ListPriceDate)
                cmd.Parameters.AddWithValue("ListPriceDate", (If(objBEParts.ListPriceDate <> DateTime.MinValue, objBEParts.ListPriceDate, DirectCast(DBNull.Value, Object))))
                'cmd.Parameters.AddWithValue("SellingPriceDate", objBEParts.SellingPriceDate)
                cmd.Parameters.AddWithValue("SellingPriceDate", (If(objBEParts.SellingPriceDate <> DateTime.MinValue, objBEParts.SellingPriceDate, DirectCast(DBNull.Value, Object))))

                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "UpdatePartsDetails")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function




        Public Function DeletePartsDetails(ByVal objBEParts As clsBEParts) As Integer
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "DeletePartsDetails")
                cmd.Parameters.AddWithValue("PartID", objBEParts.PartID)
                Dim intAffectedRow As Integer = ExecuteScalarByCommandReturnAffectedRow(cmd, "DeletePartsDetails")
                Return intAffectedRow

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetPartsDetailByID(ByVal objBEParts As clsBEParts) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPartsDetailByID")
                cmd.Parameters.AddWithValue("PartID", objBEParts.PartID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPartsDetailByID")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetPartEditorLocationByPartId(ByVal objBEParts As clsBEParts) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPartEditorLocationByPartId")
                cmd.Parameters.AddWithValue("PartID", objBEParts.PartID)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPartEditorLocationByPartId")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetPartIdByPartNumber(ByVal objBEParts As clsBEParts) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPartIdByPartNumber")
                cmd.Parameters.AddWithValue("PartNumber", objBEParts.PartNumber)
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPartIdByPartNumber")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetPartsDetailBySearch(ByVal strSearchByAppliance As String, ByVal strSearchByPart As String, ByVal strSearchByorder As String) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPartsDetailBySearch")
                'cmd.Parameters.AddWithValue("PartID", objBEParts.PartID)
                cmd.Parameters.AddWithValue("SearchByAppliance", strSearchByAppliance)
                cmd.Parameters.AddWithValue("SearchByPart", strSearchByPart)
                cmd.Parameters.AddWithValue("SearchByorder", strSearchByorder)

                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPartsDetailBySearch")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function GetPartsEditorDetails() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPartsEditorDetails")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPartsEditorDetails")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetPartsEditorBySearch(ByVal strSearchByPartNumber As String, ByVal strSearchByDescription As String, ByVal strSearchByManufacture As String) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPartsEditorBySearch")
                cmd.Parameters.AddWithValue("SearchByPartNumber", strSearchByPartNumber)
                cmd.Parameters.AddWithValue("SearchByDescription", strSearchByDescription)
                cmd.Parameters.AddWithValue("SearchByManufacture", strSearchByManufacture)

                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPartsEditorBySearch")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetPartsEditorNewBySearch(ByVal strSearchByPartNumber As String, ByVal strSearchByDescription As String, ByVal strSearchByManufacture As String) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPartsEditorNewBySearch")
                cmd.Parameters.AddWithValue("SearchByPartNumber", strSearchByPartNumber)
                cmd.Parameters.AddWithValue("SearchByDescription", strSearchByDescription)
                cmd.Parameters.AddWithValue("SearchByManufacture", strSearchByManufacture)

                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPartsEditorNewBySearch")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function
        Public Function GetPartsEditorDetailsNew() As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPartsEditorDetailsNew")
                Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPartsEditorDetailsNew")
                If objFunction.CheckDataSet(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function

        Public Function GetPartsForPartRequest() As DataTable
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "GetPartsForPartRequest")
                'Dim dstData As DataSet = FillDataSetByCommand(cmd, "GetPartsForPartRequest")
                'If objFunction.CheckDataSet(dstData) Then
                '    Return dstData
                'End If

                Dim dstData As DataTable = FillDataSetByCommandTable(cmd, "GetPartsForPartRequest")
                If objFunction.CheckDataTable(dstData) Then
                    Return dstData
                End If
            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
            End Try
            Return Nothing
        End Function


        Public Function SearchPartRequest(ByVal strSearchByFirst As String, ByVal strSearchBySecond As String) As DataSet
            Dim cmd As New SqlCommand()
            Try
                cmd.CommandText = "FF_spPartsDetail"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("Action", "SearchPartRequest")
                cmd.Parameters.AddWithValue("SearchByFirst", strSearchByFirst)
                cmd.Parameters.AddWithValue("SearchBySecond", strSearchBySecond)

                Dim dstData As DataSet = FillDataSetByCommand(cmd, "SearchPartRequest")
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
