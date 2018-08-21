Imports System.Globalization
Imports CRM.BE
Imports CRM.DL
Public Class catering_gas_inspection_edit
    Inherits System.Web.UI.Page
    Dim objFunction As New clsCommon()
    Dim objBECatering As clsBECateringInspection = New clsBECateringInspection
    Dim objBEClient As clsBEClient = New clsBEClient
    Dim objBECateringApp As clsBECateringAppliance = New clsBECateringAppliance
    Dim objBECateringIns As clsBECatering_Inspection = New clsBECatering_Inspection
    Dim objBECateringSafe As clsBECateringSafety = New clsBECateringSafety
    Dim objBECategoryWork As clsBECategoryWork = New clsBECategoryWork
    Dim objBEOrder As clsBEOrder = New clsBEOrder

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If objFunction.ReturnString(Request.QueryString("GasCateringID")) = "" Or objFunction.ReturnString(Request.QueryString("GasCateringID")) Is Nothing Then
            Response.Redirect("gas_jobs_edit.aspx")
        End If
        If Not Page.IsPostBack Then
            FillDetails(objFunction.ReturnInteger(Request.QueryString("GasCateringID")))
            hdnID.Value = objFunction.ReturnString(Request.QueryString("GasCateringID"))
            FillCateringAppliance(objFunction.ReturnInteger(hdnID.Value))
            FillCateringInspection(objFunction.ReturnInteger(hdnID.Value))
            FillCateringSafety(objFunction.ReturnInteger(hdnID.Value))
            FillCateringWork(objFunction.ReturnInteger(hdnID.Value))
            Dim dstcompany As DataSet = (New clsDLClient()).GetClientFillInDD()
            objFunction.FillDropDownByDataSet(ddlCompany, dstcompany)
            ddlCompany.Items.Insert(0, New ListItem("Select Company", ""))

            objBEOrder.Engineer = objFunction.ReturnString(Session("UserName"))
            objBEOrder.SheetDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
            Dim dstJob As DataSet = (New clsDLOrder()).GetJobIdFillInDD(objBEOrder)
            objFunction.FillDropDownByDataSet(ddlJobId, dstJob)
            ddlJobId.Items.Insert(0, New ListItem("Select JobID", ""))
        End If
    End Sub
    Public Sub FillDetails(ByVal IntId As Integer)

        Try
            Dim dstList As New DataSet()
            objBECatering.CateringId = IntId
            dstList = (New clsDLCateringInspection()).GetCateringGasDetails(objBECatering)
            If objFunction.CheckDataSet(dstList) Then
                ddlCompany.SelectedValue = objFunction.ReturnString(dstList.Tables(0).Rows(0)("ClientId"))
                Dim strType As String = objFunction.ReturnString(dstList.Tables(0).Rows(0)("Type"))
                If (strType = "Vehicle") Then
                    RadioButton1.Checked = True
                Else
                    RadioButton2.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("LPG")) = "Yes") Then
                    RadioButton3.Checked = True
                Else
                    RadioButton4.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Emergency")) = "Yes") Then
                    RadioButton5.Checked = True
                Else
                    RadioButton6.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("Tightness")) = "Yes") Then
                    RadioButton7.Checked = True
                Else
                    RadioButton8.Checked = True
                End If

                If (objFunction.ReturnString(dstList.Tables(0).Rows(0)("installation")) = "Yes") Then
                    RadioButton9.Checked = True
                Else
                    RadioButton10.Checked = True
                End If
                ddlJobId.SelectedValue = objFunction.ReturnString(dstList.Tables(0).Rows(0)("JobId"))
                txtReg.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("RegNo"))
                txtAppTested.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("AppliancesTested"))
                txtLPGReg1.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("OperatingPressure"))
                txtLPGReg2.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("LockupPressure"))
                txtReceiveBy.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("ReceivedBy"))
                txtPrint.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("PrintName"))
                txtIssuedBy.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("IssuedBy"))
                txtIdCardNo.Text = objFunction.ReturnString(dstList.Tables(0).Rows(0)("IdcardNo"))
                txtDate.Text = Convert.ToDateTime(dstList.Tables(0).Rows(0)("IssuedDate")).ToString("dd/MM/yyyy")

            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
    Public Sub FillCateringAppliance(ByVal IntJobId As Integer)
        Try
            Dim dstList As New DataSet()
            objBECateringApp.CateringId = IntJobId
            dstList = (New clsDLCateringAppliance()).GetCateringApplianceDetails(objBECateringApp)
            If objFunction.CheckDataSet(dstList) Then
                grdAppliance.DataSource = dstList
                grdAppliance.DataBind()
            Else
                grdAppliance.DataSource = Nothing
                grdAppliance.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (ddlCompany.SelectedIndex = 0 Or txtDate.Text = "") Then

            Dim javaScript As String = ""
            javaScript += "<script type='text/javascript'>"
            javaScript += "$(document).ready(function(){"
            javaScript += "ShowPopupBlank('Fill Out All the Details First.');"
            javaScript += "});"
            javaScript += "</script>"
            ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
        Else
            Try
                Dim TypeStatus As String = ""
                Dim LpgStatus As String = ""
                Dim strEmergency As String = ""
                Dim strTightness As String = ""
                Dim strInstallation As String = ""
                If RadioButton1.Checked() Then
                    TypeStatus = "Vehicle"
                ElseIf RadioButton2.Checked() Then
                    TypeStatus = "Trailer"
                End If

                If RadioButton3.Checked() Then
                    LpgStatus = "Yes"
                ElseIf RadioButton4.Checked() Then
                    LpgStatus = "No"
                End If

                If RadioButton5.Checked() Then
                    strEmergency = "Yes"
                ElseIf RadioButton6.Checked() Then
                    strEmergency = "No"
                End If

                If RadioButton7.Checked() Then
                    strTightness = "Yes"
                ElseIf RadioButton8.Checked() Then
                    strTightness = "No"
                End If
                If RadioButton9.Checked() Then
                    strInstallation = "Yes"
                ElseIf RadioButton10.Checked() Then
                    strInstallation = "No"
                End If
                objBECatering.CateringId = objFunction.ReturnInteger(hdnID.Value)
                objBECatering.ClientId = ddlCompany.SelectedValue
                objBECatering.EngineerId = objFunction.ReturnInteger(Session("LoginUserId"))
                objBECatering.JobId = objFunction.ReturnInteger(ddlJobId.SelectedValue)
                objBECatering.RegNo = txtReg.Text
                objBECatering.Type = TypeStatus
                objBECatering.AppliancesTested = txtAppTested.Text
                objBECatering.LPG = LpgStatus
                objBECatering.Emergency = strEmergency
                objBECatering.Tightness = strTightness
                objBECatering.installation = strInstallation
                objBECatering.OperatingPressure = txtLPGReg1.Text
                objBECatering.LockupPressure = txtLPGReg2.Text
                objBECatering.ReceivedBy = txtReceiveBy.Text
                objBECatering.PrintName = txtPrint.Text
                objBECatering.IssuedBy = txtIssuedBy.Text
                objBECatering.IdCardNo = txtIdCardNo.Text
                objBECatering.IssuedDate = DateTime.ParseExact(txtDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
                Dim intCateringGasId As Integer = (New clsDLCateringInspection()).UpdateCateringGasDetails(objBECatering)
                If intCateringGasId > 0 Then
                    'hdnID.Value = objFunction.ReturnString(intCateringGasId)
                    hdnID.Value = objFunction.ReturnString(Request.QueryString("GasCateringID"))
                    Dim javaScript As String = ""
                    javaScript += "<script type='text/javascript'>"
                    javaScript += "$(document).ready(function(){"
                    javaScript += "ShowPopup('Catering Gas Inspection has been updated.','success');"
                    javaScript += "});"
                    javaScript += "</script>"
                    ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                End If

            Catch ex As Exception
                HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
                HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

            End Try
        End If

    End Sub

    Protected Sub grdAppliance_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdAppliance.RowEditing
        Try
            grdAppliance.EditIndex = e.NewEditIndex
            FillCateringAppliance(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdAppliance_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdAppliance.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdAppliance.DataKeys(e.RowIndex).Values("CateringAppId")))
            objBECateringApp.CateringAppId = id
            Dim intAffectedRow As Integer = (New clsDLCateringAppliance()).PerformGridViewOpertaion("DELETE", objBECateringApp)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Appliance details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdAppliance.EditIndex = -1
            FillCateringAppliance(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdAppliance_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdAppliance.RowUpdating
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdAppliance.DataKeys(e.RowIndex).Values("CateringAppId")))
            Dim txtType As TextBox = DirectCast(grdAppliance.Rows(e.RowIndex).FindControl("txtType"), TextBox)
            Dim txtMake As TextBox = DirectCast(grdAppliance.Rows(e.RowIndex).FindControl("txtMake"), TextBox)
            Dim txtModel As TextBox = DirectCast(grdAppliance.Rows(e.RowIndex).FindControl("txtModel"), TextBox)
            Dim txtSerial As TextBox = DirectCast(grdAppliance.Rows(e.RowIndex).FindControl("txtSerial"), TextBox)
            Dim txtFlue As TextBox = DirectCast(grdAppliance.Rows(e.RowIndex).FindControl("txtFlue"), TextBox)
            Dim txtSecure As TextBox = DirectCast(grdAppliance.Rows(e.RowIndex).FindControl("txtSecure"), TextBox)
            Dim txtIsolationValve As TextBox = DirectCast(grdAppliance.Rows(e.RowIndex).FindControl("txtIsolationValve"), TextBox)

            objBECateringApp.CateringAppId = id
            objBECateringApp.ApplianceType = txtType.Text
            objBECateringApp.ApplianceMake = txtMake.Text
            objBECateringApp.Model = txtModel.Text
            objBECateringApp.SerialNo = txtSerial.Text
            objBECateringApp.FlueType = txtFlue.Text
            objBECateringApp.ApplianceSecure = txtSecure.Text
            objBECateringApp.IsolationValve = txtIsolationValve.Text

            Dim intAffectedRow As Integer = (New clsDLCateringAppliance()).PerformGridViewOpertaion("UPDATE", objBECateringApp)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Catering Appliance details have been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdAppliance.EditIndex = -1
            FillCateringAppliance(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdAppliance_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdAppliance.RowCancelingEdit
        Try
            grdAppliance.EditIndex = -1
            FillCateringAppliance(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub btnSubmitAppliance_Click(sender As Object, e As EventArgs) Handles btnSubmitAppliance.Click
        Try

            Dim strFlue As String = ""
            Dim strSecure As String = ""
            Dim strIsolation As String = ""
            If RadioButton11.Checked() Then
                strFlue = "Yes"
            ElseIf RadioButton12.Checked() Then
                strFlue = "No"
            End If
            If RadioButton13.Checked() Then
                strSecure = "Yes"
            ElseIf RadioButton14.Checked() Then
                strSecure = "No"
            End If

            If RadioButton15.Checked() Then
                strIsolation = "Yes"
            ElseIf RadioButton16.Checked() Then
                strIsolation = "No"
            End If

            objBECateringApp.CateringId = hdnID.Value
            objBECateringApp.ApplianceType = txtAppliance.Text
            objBECateringApp.Model = txtApplianceModel.Text
            objBECateringApp.ApplianceMake = txtApplianceMake.Text
            objBECateringApp.SerialNo = txtAppSerialNum.Text
            objBECateringApp.FlueType = strFlue
            objBECateringApp.ApplianceSecure = strSecure
            objBECateringApp.IsolationValve = strIsolation
            Dim intCateringGasId As Integer = (New clsDLCateringAppliance()).AddCateringApplianceDetails(objBECateringApp)
            If intCateringGasId > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('New Catering Gas Appliance has been submitted.','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                FillCateringAppliance(objFunction.ReturnInteger(hdnID.Value))
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try
    End Sub

    Protected Sub btnInspection_Click(sender As Object, e As EventArgs) Handles btnInspection.Click
        Try

            Dim strOperating As String = ""
            Dim strSafety As String = ""
            Dim strsatisfactory As String = ""
            Dim strconditions As String = ""
            Dim strperformanace As String = ""
            Dim strServiced As String = ""
            Dim strSafeTouse As String = ""

            If RadioButton17.Checked() Then
                strOperating = "Yes"
            ElseIf RadioButton18.Checked() Then
                strOperating = "No"
            End If
            If RadioButton19.Checked() Then
                strSafety = "Yes"
            ElseIf RadioButton20.Checked() Then
                strSafety = "No"
            End If

            If RadioButton21.Checked() Then
                strsatisfactory = "Yes"
            ElseIf RadioButton22.Checked() Then
                strsatisfactory = "No"
            End If

            If RadioButton23.Checked() Then
                strconditions = "Yes"
            ElseIf RadioButton24.Checked() Then
                strconditions = "No"
            End If

            If RadioButton25.Checked() Then
                strperformanace = "Yes"
            ElseIf RadioButton26.Checked() Then
                strperformanace = "No"
            End If

            If RadioButton27.Checked() Then
                strServiced = "Yes"
            ElseIf RadioButton28.Checked() Then
                strServiced = "No"
            End If

            If RadioButton29.Checked() Then
                strSafeTouse = "Yes"
            ElseIf RadioButton30.Checked() Then
                strSafeTouse = "No"
            End If
            objBECateringIns.CateringId = hdnID.Value
            objBECateringIns.Operating = strOperating
            objBECateringIns.Safety = strSafety
            objBECateringIns.SafeToUse = strSafeTouse
            objBECateringIns.Satisfactory = strsatisfactory
            objBECateringIns.Performances = strperformanace
            objBECateringIns.Serviced = strServiced
            objBECateringIns.Conditions = strconditions

            Dim intCateringInspectionId As Integer = (New clsDLCatering_Inspection()).AddCateringInspectionDetails(objBECateringIns)
            If intCateringInspectionId > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Catering Inspection Details has been submitted.','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                FillCateringInspection(objFunction.ReturnInteger(hdnID.Value))
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try
    End Sub

    Public Sub FillCateringInspection(ByVal IntJobId As Integer)
        Try
            Dim dstList As New DataSet()
            objBECateringIns.CateringId = IntJobId
            dstList = (New clsDLCatering_Inspection()).GetCateringInspectionDetails(objBECateringIns)
            If objFunction.CheckDataSet(dstList) Then
                grdInspection.DataSource = dstList
                grdInspection.DataBind()
            Else
                grdInspection.DataSource = Nothing
                grdInspection.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdInspection_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdInspection.RowEditing
        Try
            grdInspection.EditIndex = e.NewEditIndex
            FillCateringInspection(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdInspection_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdInspection.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdInspection.DataKeys(e.RowIndex).Values("CateringInspectionId")))
            objBECateringIns.CateringInspectionId = id
            Dim intAffectedRow As Integer = (New clsDLCatering_Inspection()).PerformGridViewOpertaion("DELETE", objBECateringIns)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Inspection details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else
            End If
            grdInspection.EditIndex = -1
            FillCateringInspection(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdInspection_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdInspection.RowUpdating
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdInspection.DataKeys(e.RowIndex).Values("CateringInspectionId")))
            Dim txtOperating As TextBox = DirectCast(grdInspection.Rows(e.RowIndex).FindControl("txtOperating"), TextBox)
            Dim txtSafety As TextBox = DirectCast(grdInspection.Rows(e.RowIndex).FindControl("txtSafety"), TextBox)
            Dim txtVentillation As TextBox = DirectCast(grdInspection.Rows(e.RowIndex).FindControl("txtVentillation"), TextBox)
            Dim txtConditions As TextBox = DirectCast(grdInspection.Rows(e.RowIndex).FindControl("txtConditions"), TextBox)
            Dim txtPerformances As TextBox = DirectCast(grdInspection.Rows(e.RowIndex).FindControl("txtPerformances"), TextBox)
            Dim txtserviced As TextBox = DirectCast(grdInspection.Rows(e.RowIndex).FindControl("txtserviced"), TextBox)
            Dim txtSafeToUse As TextBox = DirectCast(grdInspection.Rows(e.RowIndex).FindControl("txtSafeToUse"), TextBox)

            objBECateringIns.CateringInspectionId = id
            objBECateringIns.Operating = txtOperating.Text
            objBECateringIns.Safety = txtSafety.Text
            objBECateringIns.Satisfactory = txtVentillation.Text
            objBECateringIns.Conditions = txtConditions.Text
            objBECateringIns.Performances = txtPerformances.Text
            objBECateringIns.Serviced = txtserviced.Text
            objBECateringIns.SafeToUse = txtSafeToUse.Text

            Dim intAffectedRow As Integer = (New clsDLCatering_Inspection()).PerformGridViewOpertaion("UPDATE", objBECateringIns)

            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Catering Inspection details have been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdInspection.EditIndex = -1
            FillCateringInspection(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdInspection_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdInspection.RowCancelingEdit
        Try
            grdInspection.EditIndex = -1
            FillCateringInspection(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub btnSaftety_Click(sender As Object, e As EventArgs) Handles btnSaftety.Click
        Try
            Dim strexstinguisher As String = ""
            Dim strBlanket As String = ""
            Dim strCurrentSafety As String = ""
            Dim strLPGSafety As String = ""

            If RadioButton31.Checked() Then
                strexstinguisher = "Yes"
            ElseIf RadioButton32.Checked() Then
                strexstinguisher = "No"
            End If

            If RadioButton33.Checked() Then
                strBlanket = "Yes"
            ElseIf RadioButton34.Checked() Then
                strBlanket = "No"
            End If

            If RadioButton35.Checked() Then
                strCurrentSafety = "Yes"
            ElseIf RadioButton36.Checked() Then
                strCurrentSafety = "No"
            End If

            If RadioButton37.Checked() Then
                strLPGSafety = "Yes"
            ElseIf RadioButton38.Checked() Then
                strLPGSafety = "No"
            End If


            objBECateringSafe.CateringId = hdnID.Value
            objBECateringSafe.Exstinguisher = strexstinguisher
            objBECateringSafe.Blanket = strBlanket
            objBECateringSafe.CurrentSafety = strCurrentSafety
            objBECateringSafe.LPGSafety = strLPGSafety

            Dim intCateringSafetyId As Integer = (New clsDLCateringSafety()).AddCateringSafetyDetails(objBECateringSafe)
            If intCateringSafetyId > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Catering Safety Details has been submitted.','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                FillCateringSafety(objFunction.ReturnInteger(hdnID.Value))
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try
    End Sub

    Public Sub FillCateringSafety(ByVal IntJobId As Integer)
        Try
            Dim dstList As New DataSet()
            objBECateringSafe.CateringId = IntJobId
            dstList = (New clsDLCateringSafety()).GetCateringSafetyDetails(objBECateringSafe)
            If objFunction.CheckDataSet(dstList) Then
                grdSafety.DataSource = dstList
                grdSafety.DataBind()
            Else
                grdSafety.DataSource = Nothing
                grdSafety.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub btnSubmitWork_Click(sender As Object, e As EventArgs) Handles btnSubmitWork.Click
        Try
            Dim strwarning As String = ""

            If RadioButton39.Checked() Then
                strwarning = "Yes"
            ElseIf RadioButton40.Checked() Then
                strwarning = "No"
            End If
            objBECategoryWork.CateringId = hdnID.Value
            objBECategoryWork.Defects = txtDefects.Text
            objBECategoryWork.warnings = strwarning
            objBECategoryWork.Remedicals = txtRemedical.Text
            objBECategoryWork.WorkDetails = txtDetails.Text
            Dim intCateringSafetyId As Integer = (New clsDLCategoryWork()).AddCateringWorkDetails(objBECategoryWork)
            If intCateringSafetyId > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Catering Work Details has been submitted.','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
                FillCateringWork(objFunction.ReturnInteger(hdnID.Value))
            End If

        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)

        End Try
    End Sub

    Public Sub FillCateringWork(ByVal IntJobId As Integer)
        Try
            Dim dstList As New DataSet()
            objBECategoryWork.CateringId = IntJobId
            dstList = (New clsDLCategoryWork()).GetCateringWorkDetails(objBECategoryWork)
            If objFunction.CheckDataSet(dstList) Then
                grdWork.DataSource = dstList
                grdWork.DataBind()
            Else
                grdWork.DataSource = Nothing
                grdWork.DataBind()
            End If
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdSafety_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdSafety.RowCancelingEdit
        Try
            grdSafety.EditIndex = -1
            FillCateringSafety(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdSafety_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdSafety.RowEditing
        Try
            grdSafety.EditIndex = e.NewEditIndex
            FillCateringSafety(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdSafety_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdSafety.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdSafety.DataKeys(e.RowIndex).Values("CateringSafetyId")))
            objBECateringSafe.CateringSafetyId = id
            Dim intAffectedRow As Integer = (New clsDLCateringSafety()).PerformGridViewOpertaion("DELETE", objBECateringSafe)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Safety details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else
            End If
            grdSafety.EditIndex = -1
            FillCateringSafety(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdSafety_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdSafety.RowUpdating
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdSafety.DataKeys(e.RowIndex).Values("CateringSafetyId")))
            Dim txtexstinguisher As TextBox = DirectCast(grdSafety.Rows(e.RowIndex).FindControl("txtexstinguisher"), TextBox)
            Dim txtblanket As TextBox = DirectCast(grdSafety.Rows(e.RowIndex).FindControl("txtblanket"), TextBox)
            Dim txtcurrentSafety As TextBox = DirectCast(grdSafety.Rows(e.RowIndex).FindControl("txtcurrentSafety"), TextBox)
            Dim txtLpgSafety As TextBox = DirectCast(grdSafety.Rows(e.RowIndex).FindControl("txtLpgSafety"), TextBox)
            objBECateringSafe.CateringSafetyId = id
            objBECateringSafe.Exstinguisher = txtexstinguisher.Text
            objBECateringSafe.Blanket = txtblanket.Text
            objBECateringSafe.CurrentSafety = txtcurrentSafety.Text
            objBECateringSafe.LPGSafety = txtLpgSafety.Text
            Dim intAffectedRow As Integer = (New clsDLCateringSafety()).PerformGridViewOpertaion("UPDATE", objBECateringSafe)

            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Catering Safety details have been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdSafety.EditIndex = -1
            FillCateringSafety(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdWork_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles grdWork.RowEditing
        Try
            grdWork.EditIndex = e.NewEditIndex
            FillCateringWork(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdWork_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdWork.RowDeleting
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdWork.DataKeys(e.RowIndex).Values("CateringWorkId")))
            objBECategoryWork.CateringWorkId = id
            Dim intAffectedRow As Integer = (New clsDLCategoryWork()).PerformGridViewOpertaion("DELETE", objBECategoryWork)
            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Work details have been Deleted','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)
            Else
            End If
            grdWork.EditIndex = -1
            FillCateringWork(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdWork_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs) Handles grdWork.RowCancelingEdit
        Try
            grdWork.EditIndex = -1
            FillCateringWork(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub

    Protected Sub grdWork_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles grdWork.RowUpdating
        Try
            Dim id As Integer = objFunction.ReturnInteger(objFunction.ReturnString(grdWork.DataKeys(e.RowIndex).Values("CateringWorkId")))
            Dim txtdefects As TextBox = DirectCast(grdWork.Rows(e.RowIndex).FindControl("txtdefects"), TextBox)
            Dim txtwarnings As TextBox = DirectCast(grdWork.Rows(e.RowIndex).FindControl("txtwarnings"), TextBox)
            Dim txtremedicals As TextBox = DirectCast(grdWork.Rows(e.RowIndex).FindControl("txtremedicals"), TextBox)
            Dim txtworkdetails As TextBox = DirectCast(grdWork.Rows(e.RowIndex).FindControl("txtworkdetails"), TextBox)
            objBECategoryWork.CateringWorkId = id
            objBECategoryWork.Defects = txtdefects.Text
            objBECategoryWork.warnings = txtwarnings.Text
            objBECategoryWork.Remedicals = txtremedicals.Text
            objBECategoryWork.WorkDetails = txtworkdetails.Text
            Dim intAffectedRow As Integer = (New clsDLCategoryWork()).PerformGridViewOpertaion("UPDATE", objBECategoryWork)

            If intAffectedRow > 0 Then
                Dim javaScript As String = ""
                javaScript += "<script type='text/javascript'>"
                javaScript += "$(document).ready(function(){"
                javaScript += "ShowPopup('Catering Work details have been updated','success');"
                javaScript += "});"
                javaScript += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "scriptKey", javaScript)

            Else

            End If
            grdWork.EditIndex = -1
            FillCateringWork(objFunction.ReturnInteger(hdnID.Value))
        Catch ex As Exception
            HttpContext.Current.Trace.Warn("Exception message:  ::", ex.Message)
            HttpContext.Current.Trace.Warn("Error Stack Trace ::", ex.StackTrace)
        End Try
    End Sub
End Class