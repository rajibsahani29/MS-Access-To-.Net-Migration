Imports CRM.BE
Imports CRM.DL

Public Class gas_inspection_select_company
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEGas As clsBEGasInspection = New clsBEGasInspection
    Dim objBEClient As clsBEClient = New clsBEClient
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then

            Dim dstcompany As DataSet = (New clsDLClient()).GetClientFillInDD()
            objFunction.FillDropDownByDataSet(ddlCompany, dstcompany)
            ddlCompany.Items.Insert(0, New ListItem("Select Company", ""))
        End If
    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            objBEGas.ClientId = objFunction.ReturnInteger(ddlCompany.SelectedValue)
            Dim dstJobList As DataSet = (New clsDLGasInspection()).GetJobsGasDetailsByCompany(objBEGas)
            If objFunction.CheckDataSet(dstJobList) Then
                grdGagInspection.DataSource = dstJobList
                grdGagInspection.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    ''' <summary>
    ''' This function is used to set date value
    ''' </summary>
    Public Function SetDateVal(ByVal value As Object) As String
        Try
            If objFunction.ReturnString(value) <> "" Then
                Dim dt As DateTime = Convert.ToDateTime(value)
                Return dt.ToString("dd-MM-yyyy")
            Else
                Return ""
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
        Return ""
    End Function

    Protected Sub grdGagInspection_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles grdGagInspection.SelectedIndexChanging
        Try
            Dim GasInspectionId As String = objFunction.ReturnString(grdGagInspection.DataKeys(e.NewSelectedIndex).Value)
            Response.Redirect("gas-inspection.aspx?InspectionID=" + GasInspectionId)
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdGagInspection_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles grdGagInspection.PageIndexChanging
        Try
            grdGagInspection.PageIndex = e.NewPageIndex
            objBEGas.ClientId = objFunction.ReturnInteger(ddlCompany.SelectedValue)
            Dim dstJobList As DataSet = (New clsDLGasInspection()).GetJobsGasDetailsByCompany(objBEGas)
            If objFunction.CheckDataSet(dstJobList) Then
                grdGagInspection.DataSource = dstJobList
                grdGagInspection.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
End Class