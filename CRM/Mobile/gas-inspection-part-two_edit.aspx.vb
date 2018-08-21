Imports CRM.BE
Imports CRM.DL

Public Class gas_inspection_part_two_edit
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEGas As clsBEGasInspection = New clsBEGasInspection
    Dim objBEGasPart As clsBEJobGasPart = New clsBEJobGasPart
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objFunction.ReturnString(Request.QueryString("JobGasID")) = "" Or objFunction.ReturnString(Request.QueryString("JobGasID")) Is Nothing Then
            Response.Redirect("gas-inspection_edit.aspx")
        End If
        If Not Page.IsPostBack Then
            FillPart(objFunction.ReturnInteger(Request.QueryString("JobGasID")))
            FillPartSection2(objFunction.ReturnInteger(Request.QueryString("JobGasID")))
        End If
    End Sub
    Public Sub FillPart(ByVal IntJobId As Integer)
        Try
            Dim dstList As New DataSet()
            objBEGasPart.InspectionId = IntJobId
            dstList = (New clsDLJobGasPart()).GetJobsGasPart2DetailsById(objBEGasPart)
            If objFunction.CheckDataSet(dstList) Then
                grdJobGasPart.DataSource = dstList
                grdJobGasPart.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
    Public Sub FillPartSection2(ByVal IntJobId As Integer)
        Try
            Dim dstList As New DataSet()
            objBEGasPart.InspectionId = IntJobId
            dstList = (New clsDLJobGasPart()).GetJobsGasPart2DetailsById(objBEGasPart)
            If objFunction.CheckDataSet(dstList) Then
                grdJobGasSection2.DataSource = dstList
                grdJobGasSection2.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
    Protected Sub grdJobGasSection2_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdJobGasSection2.RowEditing
        Try
            grdJobGasSection2.EditIndex = e.NewEditIndex
            FillPartSection2(objFunction.ReturnInteger(Request.QueryString("JobGasID")))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdJobGasSection2_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdJobGasSection2.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdJobGasSection2.DataKeys(e.RowIndex).Values("JobGasPartId")))
            objBEGasPart.JobGasPartId = id
            Dim intAffectedRow As Integer = (New clsDLJobGasPart()).PerformGridViewOpertaionEdit("DELETE", objBEGasPart)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Part2 details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdJobGasSection2.EditIndex = -1
            FillPartSection2(objFunction.ReturnInteger(Request.QueryString("JobGasID")))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdJobGasSection2_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdJobGasSection2.RowCancelingEdit
        Try
            grdJobGasSection2.EditIndex = -1
            FillPartSection2(objFunction.ReturnInteger(Request.QueryString("JobGasID")))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdJobGasSection2_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdJobGasSection2.RowUpdating
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdJobGasSection2.DataKeys(e.RowIndex).Values("JobGasPartId")))
            Dim txtremedical As TextBox = DirectCast(grdJobGasSection2.Rows(e.RowIndex).FindControl("txtremedical"), TextBox)
            Dim txtwarning As TextBox = DirectCast(grdJobGasSection2.Rows(e.RowIndex).FindControl("txtwarning"), TextBox)
            Dim txtdetails As TextBox = DirectCast(grdJobGasSection2.Rows(e.RowIndex).FindControl("txtdetails"), TextBox)
            Dim txtdefects As TextBox = DirectCast(grdJobGasSection2.Rows(e.RowIndex).FindControl("txtdefects"), TextBox)

            objBEGasPart.Defects = txtdefects.Text
            objBEGasPart.Warning = txtwarning.Text
            objBEGasPart.Remedical = txtremedical.Text
            objBEGasPart.Details = txtdetails.Text
            objBEGasPart.JobGasPartId = id
            Dim intAffectedRow As Integer = (New clsDLJobGasPart()).PerformGridViewOpertaionEdit("UPDATE", objBEGasPart)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Part 2 details have been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdJobGasSection2.EditIndex = -1
            FillPartSection2(objFunction.ReturnInteger(Request.QueryString("JobGasID")))

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdJobGasPart_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdJobGasPart.RowEditing
        Try
            grdJobGasPart.EditIndex = e.NewEditIndex
            FillPart(objFunction.ReturnInteger(Request.QueryString("JobGasID")))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdJobGasPart_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdJobGasPart.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdJobGasSection2.DataKeys(e.RowIndex).Values("JobGasPartId")))
            objBEGasPart.JobGasPartId = id
            Dim intAffectedRow As Integer = (New clsDLJobGasPart()).PerformGridViewOpertaionEditGrid1("DELETE", objBEGasPart)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Part2 details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdJobGasPart.EditIndex = -1
            FillPart(objFunction.ReturnInteger(Request.QueryString("JobGasID")))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdJobGasPart_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdJobGasPart.RowUpdating
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdJobGasPart.DataKeys(e.RowIndex).Values("JobGasPartId")))
            Dim txtType As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtType"), TextBox)
            Dim txtMake As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtMake"), TextBox)
            Dim txtModel As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtModel"), TextBox)
            Dim txtmanufacture As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtmanufacture"), TextBox)
            Dim txtpressure As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtpressure"), TextBox)
            Dim txtheat As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtheat"), TextBox)
            Dim txtco As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtco"), TextBox)
            Dim txtco2 As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtco2"), TextBox)

            objBEGasPart.ApplianceType = txtType.Text
            objBEGasPart.ApplianceMake = txtMake.Text
            objBEGasPart.Model = txtModel.Text
            objBEGasPart.JobGasPartId = id
            objBEGasPart.Manufacturer = txtmanufacture.Text
            objBEGasPart.Pressure = txtpressure.Text
            objBEGasPart.HeatInput = txtheat.Text
            objBEGasPart.MaxCO = txtco.Text
            objBEGasPart.MaxCO2 = txtco2.Text

            Dim intAffectedRow As Integer = (New clsDLJobGasPart()).PerformGridViewOpertaionEditGrid1("UPDATE", objBEGasPart)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Part details have been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdJobGasPart.EditIndex = -1
            FillPart(objFunction.ReturnInteger(Request.QueryString("JobGasID")))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdJobGasPart_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdJobGasPart.RowCancelingEdit
        Try
            grdJobGasPart.EditIndex = -1
            FillPart(objFunction.ReturnInteger(Request.QueryString("JobGasID")))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
End Class