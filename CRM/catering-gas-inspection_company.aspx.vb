Imports CRM.BE
Imports CRM.DL
Public Class catering_gas_inspection_company
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBECatering As clsBECateringInspection = New clsBECateringInspection
    Dim objBEClient As clsBEClient = New clsBEClient

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim dstcompany As DataSet = (New clsDLClient()).GetClientFillInDD()
            objFunction.FillDropDownByDataSet(ddlCompany, dstcompany)
            ddlCompany.Items.Insert(0, New ListItem("Select Company", ""))
        End If
    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FillCateringDetails(ddlCompany.SelectedValue)
    End Sub

    Public Sub FillCateringDetails(ByVal intId As Integer)
        Try
            objBECatering.ClientId = intId
            Dim dstJobList As DataSet = (New clsDLCateringInspection()).GetCateringDetailsByCompany(objBECatering)
            If objFunction.CheckDataSet(dstJobList) Then
                grdCateringInspection.DataSource = dstJobList
                grdCateringInspection.DataBind()
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

    Protected Sub grdCateringInspection_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles grdCateringInspection.SelectedIndexChanging
        Try
            Dim GasCateringId As String = objFunction.ReturnString(grdCateringInspection.DataKeys(e.NewSelectedIndex).Value)
            Response.Redirect("catering-gas-inspection_print.aspx?GasCateringID=" + GasCateringId)
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdCateringInspection_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles grdCateringInspection.PageIndexChanging
        Try
            grdCateringInspection.PageIndex = e.NewPageIndex
            FillCateringDetails(ddlCompany.SelectedValue)
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
End Class