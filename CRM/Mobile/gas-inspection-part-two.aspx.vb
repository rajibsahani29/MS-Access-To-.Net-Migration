Imports CRM.BE
Imports CRM.DL
Public Class gas_inspection_part_two
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBEGasPart As clsBEJobGasPart = New clsBEJobGasPart
    Dim Status As String


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If objFunction.ReturnString(Request.QueryString("JobGasID")) = "" Or objFunction.ReturnString(Request.QueryString("JobGasID")) Is Nothing Then
            Response.Redirect("gas-inspection_edit.aspx")
        Else
            Status = Request.QueryString("SStatus").ToString()
        End If
        If Not Page.IsPostBack Then
            If Status = "UPDATE" Then
                FillPart(objFunction.ReturnInteger(Request.QueryString("JobGasID")))
            End If
            hdnID.Value = objFunction.ReturnInteger(Request.QueryString("JobGasID"))
        End If
    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim strManufacturer As String = ""
            Dim IsolationValve As String = ""
            Dim GasFitted As String = ""
            Dim strElectrical As String = ""
            Dim strFSDFitted As String = ""
            Dim strOperating As String = ""
            Dim strpipework As String = ""
            Dim strSafety As String = ""
            Dim strwarning As String = ""


            If RadioButton168.Checked() Then
                strManufacturer = "Yes"
            ElseIf RadioButton1.Checked() Then
                strManufacturer = "No"
            End If
            If RadioButton2.Checked() Then
                IsolationValve = "Yes"
            Else
                IsolationValve = "No"
            End If


            If RadioButton4.Checked() Then
                GasFitted = "Yes"
            Else
                GasFitted = "No"
            End If
            If RadioButton6.Checked() Then
                strElectrical = "Yes"
            Else
                strElectrical = "No"
            End If

            If RadioButton8.Checked() Then
                strFSDFitted = "Yes"
            Else
                strFSDFitted = "No"
            End If

            If RadioButton10.Checked() Then
                strOperating = "Yes"
            Else
                strOperating = "No"
            End If

            If RadioButton12.Checked() Then
                strpipework = "Yes"
            Else
                strpipework = "No"
            End If

            If RadioButton14.Checked() Then
                strSafety = "Yes"
            Else
                strSafety = "No"
            End If

            If RadioButton16.Checked() Then
                strwarning = "Yes"
            Else
                strwarning = "No"
            End If

            Dim id = objFunction.ReturnInteger(hdnID.Value)
            objBEGasPart.InspectionId = id
            objBEGasPart.ApplianceType = txtAppType.Text
            objBEGasPart.ApplianceMake = txtApplianceMake.Text
            objBEGasPart.Model = txtAppModel.Text
            objBEGasPart.Manufacturer = strManufacturer
            objBEGasPart.Pressure = txtOpPressure.Text
            objBEGasPart.HeatInput = txtHeatInput.Text
            objBEGasPart.MaxCO = txtMaxRead.Text
            objBEGasPart.MaxCO2 = txtMax.Text
            objBEGasPart.IsolationValve = IsolationValve
            objBEGasPart.FittedStatus = GasFitted
            objBEGasPart.Isolator = strElectrical
            objBEGasPart.FSDFitted = strFSDFitted
            objBEGasPart.FSDOperating = strOperating
            objBEGasPart.Pipework = strpipework
            objBEGasPart.Safety = strSafety
            objBEGasPart.Defects = txtDefIdentified.Text
            objBEGasPart.Warning = strwarning
            objBEGasPart.Remedical = txtWork.Text
            objBEGasPart.Details = txtDetails.Text

            Dim intJobsGasId As Integer = (New clsDLJobGasPart()).AddJobsGasPart2Details(objBEGasPart)
            If intJobsGasId > 0 Then
                FillPart(id)
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Job Gas Part Two Details has been submitted.','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                ClearControl()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try
    End Sub

    Public Sub FillPart(ByVal IntJobId As Integer)
        Try
            Dim dstList As New DataSet()
            objBEGasPart.InspectionId = IntJobId
            dstList = (New clsDLJobGasPart()).GetJobsGasPart2DetailsById(objBEGasPart)
            If objFunction.CheckDataSet(dstList) Then
                grdJobGasPart.DataSource = dstList
                grdJobGasPart.DataBind()
            Else
                grdJobGasPart.DataSource = Nothing
                grdJobGasPart.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Public Sub ClearControl()
        txtApplianceMake.Text = ""
        txtMaxRead.Text = ""
        txtAppModel.Text = ""
        txtAppType.Text = ""
        txtMax.Text = ""
        txtOpPressure.Text = ""
        txtWork.Text = ""
        txtDefIdentified.Text = ""
        txtDetails.Text = ""
        txtHeatInput.Text = ""
        RadioButton1.Checked = False
        RadioButton10.Checked = False
        RadioButton11.Checked = False
        RadioButton12.Checked = False
        RadioButton13.Checked = False
        RadioButton14.Checked = False
        RadioButton15.Checked = False
        RadioButton16.Checked = False
        RadioButton168.Checked = False
        RadioButton17.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton8.Checked = False
        RadioButton9.Checked = False

    End Sub

    Protected Sub grdJobGasPart_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdJobGasPart.RowEditing
        Try
            grdJobGasPart.EditIndex = e.NewEditIndex
            FillPart(objFunction.ReturnInteger(hdnID.Value))
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
            Dim txtIsolation As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtIsolation"), TextBox)
            Dim txtfitted As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtfitted"), TextBox)
            Dim txtisolator As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtisolator"), TextBox)
            Dim txtfsdfit As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtfsdfit"), TextBox)
            Dim txtfsdOperating As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtfsdOperating"), TextBox)
            Dim txtpipework As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtpipework"), TextBox)
            Dim txtsafety As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtsafety"), TextBox)
            Dim txtremedical As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtremedical"), TextBox)
            Dim txtwarning As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtwarning"), TextBox)
            Dim txtdetails As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtdetails"), TextBox)
            Dim txtdefects As TextBox = DirectCast(grdJobGasPart.Rows(e.RowIndex).FindControl("txtdefects"), TextBox)





            objBEGasPart.ApplianceType = txtType.Text
            objBEGasPart.ApplianceMake = txtMake.Text
            objBEGasPart.Model = txtModel.Text
            objBEGasPart.JobGasPartId = id
            objBEGasPart.Manufacturer = txtmanufacture.Text
            objBEGasPart.Pressure = txtpressure.Text
            objBEGasPart.HeatInput = txtheat.Text
            objBEGasPart.MaxCO = txtco.Text
            objBEGasPart.MaxCO2 = txtco2.Text
            objBEGasPart.IsolationValve = txtIsolation.Text
            objBEGasPart.FittedStatus = txtfitted.Text
            objBEGasPart.Isolator = txtisolator.Text
            objBEGasPart.FSDFitted = txtfsdfit.Text
            objBEGasPart.FSDOperating = txtfsdOperating.Text
            objBEGasPart.Pipework = txtpipework.Text
            objBEGasPart.Safety = txtsafety.Text


            objBEGasPart.Defects = txtdefects.Text
            objBEGasPart.Warning = txtwarning.Text
            objBEGasPart.Remedical = txtremedical.Text
            objBEGasPart.Details = txtdetails.Text

            Dim intAffectedRow As Integer = (New clsDLJobGasPart()).PerformGridViewOpertaionEditGrid1("UPDATE", objBEGasPart)
            If intAffectedRow > 0 Then
                Dim intAffectedRowDefect As Integer = (New clsDLJobGasPart()).PerformGridViewOpertaionEdit("UPDATE", objBEGasPart)
                If intAffectedRowDefect > 0 Then
                    Dim javaScript As String = ""
                    javaScript += "<script type='text/javascript'>"
                    javaScript += "$(document).ready(function(){"
                    javaScript += "ShowPopup('Part details have been updated','success');"
                    javaScript += "});"
                    javaScript += "</script>"
                    ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                End If

            End If
            grdJobGasPart.EditIndex = -1
            FillPart(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdJobGasPart_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdJobGasPart.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdJobGasPart.DataKeys(e.RowIndex).Values("JobGasPartId")))
            objBEGasPart.JobGasPartId = id
            Dim intAffectedRow As Integer = (New clsDLJobGasPart()).PerformGridViewOpertaion("DELETE", objBEGasPart)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Part details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdJobGasPart.EditIndex = -1
            FillPart(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdJobGasPart_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdJobGasPart.RowCancelingEdit
        Try
            grdJobGasPart.EditIndex = -1
            FillPart(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        If (txtApplianceMake.Text <> "" Or txtAppModel.Text <> "" Or txtOpPressure.Text <> "" Or txtHeatInput.Text <> "" Or txtMaxRead.Text <> "" Or txtMax.Text <> "") Then
            Dim javaScript As String = ""
            javaScript += "<script type='text/javascript'>"
            javaScript += "$(document).ready(function(){"
            javaScript += "ShowConfirmationPopup('Your form below has not been saved.');"
            javaScript += "});"
            javaScript += "</script>"
            ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
        Else
            Dim Id As String = hdnID.Value
            Response.Redirect("gas-inspection_edit.aspx?GasInspectionID=" + Id)
        End If

    End Sub

    Protected Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click

        If (txtApplianceMake.Text <> "" Or txtAppModel.Text <> "" Or txtOpPressure.Text <> "" Or txtHeatInput.Text <> "" Or txtMaxRead.Text <> "" Or txtMax.Text <> "") Then
            Dim javaScript As String = ""
            javaScript += "<script type='text/javascript'>"
            javaScript += "$(document).ready(function(){"
            javaScript += "ShowConfirmationPopupComplete('Your form below has not been saved.');"
            javaScript += "});"
            javaScript += "</script>"
            ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
        Else
            Response.Redirect("Index-mobile.aspx")
        End If
    End Sub
End Class